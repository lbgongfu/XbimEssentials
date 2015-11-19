﻿using System;
using System.Diagnostics;
using System.Xml;
using System.Xml.Schema;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xbim.Ifc2x3;
using Xbim.IO;
using Xbim.IO.Esent;
using Xbim.IO.Memory;

namespace Xbim.MemoryModel.Tests
{
    [TestClass]
    [DeploymentItem("TestFiles")]
    public class XmlTests2x3
    {
        [TestMethod]
        public void Ifc2X3XMLSerialization()
        {
            using (var esent = new IO.Esent.EsentModel(new EntityFactory()))
            {
                esent.CreateFrom("4walls1floorSite.ifc", null, null, true, true);
                esent.SaveAs("..\\..\\4walls1floorSite.xml", XbimStorageType.IfcXml);
                var errs = ValidateIfc2X3("..\\..\\4walls1floorSite.xml");
                Assert.AreEqual(0, errs);
            }
        }


        /// <summary>
        /// </summary>
        /// <param name="path">Path of the file to be validated</param>
        /// <returns>Number of errors</returns>
        private int ValidateIfc2X3(string path)
        {
            var errCount = 0;
            var dom = new XmlDocument();
            dom.Load(path);
            var schemas = new XmlSchemaSet();
            schemas.Add("http://www.iai-tech.org/ifcXML/IFC2x3/FINAL", "http://www.iai-tech.org/ifcXML/IFC2x3/FINAL/IFC2X3.xsd");
            schemas.Add("urn:iso.org:standard:10303:part(28):version(2):xmlschema:common","http://www.iai-tech.org/ifcXML/IFC2x3/FINAL/ex.xsd");
            dom.Schemas = schemas;
            dom.Validate((sender, args) =>
            {
                Debug.WriteLine("Validation error: {0} \nLine: {1}, Position: {2}", args.Message, args.Exception.LineNumber, args.Exception.LinePosition);
                errCount++;
            });

            return errCount;
        }
    }
}
