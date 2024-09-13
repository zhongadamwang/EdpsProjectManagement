using System.Collections.Generic;
using MetaShare.Common.Core.Entities;
using MetaShare.Common.Core.Services;
using EdpsProjectManagement.Entities.BusinessEntities;
/*add customized code between this region*/
/*add customized code between this region*/


namespace EdpsProjectManagement.Services.Interfaces.BusinessEntities
{
	public interface IProjectService: IPagingService<EdpsProjectManagement.Entities.BusinessEntities.Project>
	{
	    List<EdpsProjectManagement.Entities.BusinessEntities.Project> SelectAllWithReferenceData(List<EdpsProjectManagement.Entities.BusinessEntities.Project> items);
	    /*add customized code between this region*/
	/*add customized code between this region*/
	}
}
