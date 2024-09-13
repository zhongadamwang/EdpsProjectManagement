using System.Collections.Generic;
using MetaShare.Common.Core.Entities;
using MetaShare.Common.Core.Services;
using MetaShare.Common.Core.Services.Version;
using EdpsProjectManagement.Entities.BusinessEntities;
/*add customized code between this region*/
/*add customized code between this region*/


namespace EdpsProjectManagement.Services.Interfaces.BusinessEntities
{
	public interface ITaskService: IObjectVersionService<EdpsProjectManagement.Entities.BusinessEntities.Task>
	{
	    List<EdpsProjectManagement.Entities.BusinessEntities.Task> SelectAllWithReferenceData(List<EdpsProjectManagement.Entities.BusinessEntities.Task> items);
	    List<EdpsProjectManagement.Entities.BusinessEntities.Task> SelectTaskByIterations(int[] iterationIds, bool isAggregatedChildren = false);
	
	    List<EdpsProjectManagement.Entities.BusinessEntities.Task> SelectTaskByProjects(int[] projectIds, bool isAggregatedChildren = false);
	
	    List<EdpsProjectManagement.Entities.BusinessEntities.Task> SelectTaskByRepositorys(int[] repositoryIds, bool isAggregatedChildren = false);
	
	    List<EdpsProjectManagement.Entities.BusinessEntities.Task> SelectByIterationProject(int pageIndex,int pageSize,int iterationId,int projectId);
	/*add customized code between this region*/
	}
}