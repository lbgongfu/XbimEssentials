// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.FacilitiesMgmtDomain
{
	public partial class @IfcMove : IIfcTask
	{
		Xbim.Ifc4.MeasureResource.IfcLabel? IIfcTask.Status 
		{ 
			get
			{
				if (Status == null) return null;
				return new Xbim.Ifc4.MeasureResource.IfcLabel((string)Status);
			} 
		}
		Xbim.Ifc4.MeasureResource.IfcLabel? IIfcTask.WorkMethod 
		{ 
			get
			{
				if (WorkMethod == null) return null;
				return new Xbim.Ifc4.MeasureResource.IfcLabel((string)WorkMethod);
			} 
		}
		bool IIfcTask.IsMilestone 
		{ 
			get
			{
				return IsMilestone;
			} 
		}
		long? IIfcTask.Priority 
		{ 
			get
			{
				if (Priority == null) return null;
				return Priority;
			} 
		}
		IIfcTaskTime IIfcTask.TaskTime 
		{ 
			get
			{
				//TODO: Handle return of TaskTime for which no match was found
				throw new System.NotImplementedException();
			} 
		}
		Xbim.Ifc4.ProcessExtension.IfcTaskTypeEnum? IIfcTask.PredefinedType 
		{ 
			get
			{
				//TODO: Handle return of PredefinedType for which no match was found
				throw new System.NotImplementedException();
			} 
		}
	}
}