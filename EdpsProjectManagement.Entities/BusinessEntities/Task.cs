using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using MetaShare.Common.Core.Entities;
/*add customized code between this region*/
/*add customized code between this region*/


namespace EdpsProjectManagement.Entities.BusinessEntities
{
	public class Task : MetaShare.Common.Core.Entities.ObjectVersion
	{
		public Task()
		{
		}
		[DataMember]
		public int ActualHours{get; set;}
		
		[DataMember]
		public string Assignee{get; set;}
		
		[DataMember]
		public int EstimateHours{get; set;}
		
		[DataMember]
		public DateTime ImportDateTime{get; set;}
		
		[DataMember]
		public string Label{get; set;}
		
		[DataMember]
		public string ReleaseTarget{get; set;}
		
		[DataMember]
		public int RemainHours{get; set;}
		
		[DataMember]
		public string Status{get; set;}
		
		[DataMember]
		public string UniqueLink{get; set;}
		
		[DataMember]
		public DateTime WorkDate{get; set;}
		
		[DataMember]
		public EdpsProjectManagement.Entities.BusinessEntities.Iteration Iteration{get; set;}
		
		[DataMember]
		public EdpsProjectManagement.Entities.BusinessEntities.Project Project{get; set;}
		
		[DataMember]
		public EdpsProjectManagement.Entities.BusinessEntities.Repository Repository{get; set;}
		
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
	/*add customized code between this region*/
	/*add customized code between this region*/
}
