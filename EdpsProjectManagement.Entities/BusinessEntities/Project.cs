using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using MetaShare.Common.Core.Entities;
/*add customized code between this region*/
/*add customized code between this region*/


namespace EdpsProjectManagement.Entities.BusinessEntities
{
	public class Project : MetaShare.Common.Core.Entities.Common
	{
		public Project()
		{
			this.Task = new List<EdpsProjectManagement.Entities.BusinessEntities.Task>();
		}
		[DataMember]
		public List<EdpsProjectManagement.Entities.BusinessEntities.Task> Task{get; set;}
		
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
	/*add customized code between this region*/
	/*add customized code between this region*/
}
