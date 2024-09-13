using System.Collections.Generic;
using MetaShare.Common.Core.Entities;
using MetaShare.Common.Core.Services;
using MetaShare.Common.Core.Services.Version;
using EdpsProjectManagement.Entities.BusinessEntities;
using EdpsProjectManagement.Daos.Interfaces.BusinessEntities;
using EdpsProjectManagement.Services.Interfaces.BusinessEntities;

/*add customized code between this region*/
/*add customized code between this region*/

namespace EdpsProjectManagement.Services.BusinessEntities
{
	public class TaskService: ObjectVersionService<EdpsProjectManagement.Entities.BusinessEntities.Task>,ITaskService
	{
		public TaskService() : base(typeof(ITaskDao))
		{
		}
		
		public List<EdpsProjectManagement.Entities.BusinessEntities.Task> SelectAllWithReferenceData(List<EdpsProjectManagement.Entities.BusinessEntities.Task> items)
		
		private ServiceAggregationInfo CreateReferenceInfoAggregation()
		{
		    ServiceAggregationInfo aggregation = ServiceAggregationInfo.CreateRoot(typeof(EdpsProjectManagement.Entities.BusinessEntities.Task),typeof(EdpsProjectManagement.Daos.Interfaces.BusinessEntities.ITaskDao));
		
		    aggregation.AddReferenceChild("Iteration",typeof(EdpsProjectManagement.Entities.BusinessEntities.Iteration),typeof(EdpsProjectManagement.Daos.Interfaces.BusinessEntities.IIterationDao));
		    aggregation.AddReferenceChild("Project",typeof(EdpsProjectManagement.Entities.BusinessEntities.Project),typeof(EdpsProjectManagement.Daos.Interfaces.BusinessEntities.IProjectDao));
		    aggregation.AddReferenceChild("Repository",typeof(EdpsProjectManagement.Entities.BusinessEntities.Repository),typeof(EdpsProjectManagement.Daos.Interfaces.BusinessEntities.IRepositoryDao));
		    return aggregation;
		}
		
		protected override ServiceAggregationInfo CreateAllInfoAggregation()
		{
		    ServiceAggregationInfo aggregation = ServiceAggregationInfo.CreateRoot(typeof(EdpsProjectManagement.Entities.BusinessEntities.Task),typeof(EdpsProjectManagement.Daos.Interfaces.BusinessEntities.ITaskDao));
		
		    ServiceAggregationInfo IterationServiceAggregation = aggregation.AddReferenceChild("Iteration",typeof(EdpsProjectManagement.Entities.BusinessEntities.Iteration),typeof(EdpsProjectManagement.Daos.Interfaces.BusinessEntities.IIterationDao));
		    ServiceAggregationInfo ProjectServiceAggregation = aggregation.AddReferenceChild("Project",typeof(EdpsProjectManagement.Entities.BusinessEntities.Project),typeof(EdpsProjectManagement.Daos.Interfaces.BusinessEntities.IProjectDao));
		    ServiceAggregationInfo RepositoryServiceAggregation = aggregation.AddReferenceChild("Repository",typeof(EdpsProjectManagement.Entities.BusinessEntities.Repository),typeof(EdpsProjectManagement.Daos.Interfaces.BusinessEntities.IRepositoryDao));
		    return aggregation;
		}
		
		public List<EdpsProjectManagement.Entities.BusinessEntities.Task> SelectTaskByIterations(int[] iterationIds, bool isAggregatedChildren = false)
		public List<EdpsProjectManagement.Entities.BusinessEntities.Task> SelectTaskByProjects(int[] projectIds, bool isAggregatedChildren = false)
		public List<EdpsProjectManagement.Entities.BusinessEntities.Task> SelectTaskByRepositorys(int[] repositoryIds, bool isAggregatedChildren = false)
		public List<EdpsProjectManagement.Entities.BusinessEntities.Task> SelectByIterationProject(int pageIndex,int pageSize,int iterationId,int projectId)
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}