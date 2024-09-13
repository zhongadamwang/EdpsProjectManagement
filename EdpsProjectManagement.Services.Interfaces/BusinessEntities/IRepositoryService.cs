using System.Collections.Generic;
using MetaShare.Common.Core.Entities;
using MetaShare.Common.Core.Services;
using EdpsProjectManagement.Entities.BusinessEntities;
/*add customized code between this region*/
/*add customized code between this region*/


namespace EdpsProjectManagement.Services.Interfaces.BusinessEntities
{
	public interface IRepositoryService: IPagingService<EdpsProjectManagement.Entities.BusinessEntities.Repository>
	{
	    List<EdpsProjectManagement.Entities.BusinessEntities.Repository> SelectAllWithReferenceData(List<EdpsProjectManagement.Entities.BusinessEntities.Repository> items);
	    /*add customized code between this region*/
	/*add customized code between this region*/
	}
}
