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
	    List<EdpsProjectManagement.Entities.BusinessEntities.Task> SelectTaskByIterations(int[] iterationIds, bool isAggregatedChildren = false);        List<EdpsProjectManagement.Entities.BusinessEntities.Task> SelectTaskByIterations(Pager pager, int[] iterationIds, bool isAggregatedChildren = false);		List<EdpsProjectManagement.Entities.BusinessEntities.Task> SelectByIteration(int pageIndex,int pageSize,int iterationId);		List<EdpsProjectManagement.Entities.BusinessEntities.Task> SelectByIteration(int iterationId);
	
	    List<EdpsProjectManagement.Entities.BusinessEntities.Task> SelectTaskByProjects(int[] projectIds, bool isAggregatedChildren = false);        List<EdpsProjectManagement.Entities.BusinessEntities.Task> SelectTaskByProjects(Pager pager, int[] projectIds, bool isAggregatedChildren = false);		List<EdpsProjectManagement.Entities.BusinessEntities.Task> SelectByProject(int pageIndex,int pageSize,int projectId);		List<EdpsProjectManagement.Entities.BusinessEntities.Task> SelectByProject(int projectId);
	
	    List<EdpsProjectManagement.Entities.BusinessEntities.Task> SelectTaskByRepositorys(int[] repositoryIds, bool isAggregatedChildren = false);        List<EdpsProjectManagement.Entities.BusinessEntities.Task> SelectTaskByRepositorys(Pager pager, int[] repositoryIds, bool isAggregatedChildren = false);		List<EdpsProjectManagement.Entities.BusinessEntities.Task> SelectByRepository(int pageIndex,int pageSize,int repositoryId);		List<EdpsProjectManagement.Entities.BusinessEntities.Task> SelectByRepository(int repositoryId);
	
	    List<EdpsProjectManagement.Entities.BusinessEntities.Task> SelectByIterationProject(int pageIndex,int pageSize,int iterationId,int projectId);        List<EdpsProjectManagement.Entities.BusinessEntities.Task> SelectByIterationProject(int iterationId,int projectId);		List<EdpsProjectManagement.Entities.BusinessEntities.Task> SelectByIterationRepository(int pageIndex,int pageSize,int iterationId,int repositoryId);        List<EdpsProjectManagement.Entities.BusinessEntities.Task> SelectByIterationRepository(int iterationId,int repositoryId);		List<EdpsProjectManagement.Entities.BusinessEntities.Task> SelectByProjectRepository(int pageIndex,int pageSize,int projectId,int repositoryId);        List<EdpsProjectManagement.Entities.BusinessEntities.Task> SelectByProjectRepository(int projectId,int repositoryId);		/*add customized code between this region*/
	/*add customized code between this region*/
	}
}
