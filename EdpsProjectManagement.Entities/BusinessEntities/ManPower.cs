using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using MetaShare.Common.Core.Entities;
/*add customized code between this region*/
/*add customized code between this region*/


namespace EdpsProjectManagement.Entities.BusinessEntities
{
	public class ManPower : MetaShare.Common.Core.Entities.ObjectVersion
	{
		public ManPower()
		{
		}
		[DataMember]
		public int AvailableHours{get; set;}
		
		[DataMember]
		public DateTime EndDate{get; set;}
		
		[DataMember]
		public DateTime StartDate{get; set;}
		
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
	/*add customized code between this region*/
	/*add customized code between this region*/
}
