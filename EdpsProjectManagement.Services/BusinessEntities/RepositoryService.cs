using System.Collections.Generic;
using MetaShare.Common.Core.Entities;
using MetaShare.Common.Core.Services;
using EdpsProjectManagement.Entities.BusinessEntities;
using EdpsProjectManagement.Daos.Interfaces.BusinessEntities;
using EdpsProjectManagement.Services.Interfaces.BusinessEntities;

/*add customized code between this region*/
/*add customized code between this region*/

namespace EdpsProjectManagement.Services.BusinessEntities
{
	public class RepositoryService: Service<EdpsProjectManagement.Entities.BusinessEntities.Repository>,IRepositoryService
	{
		public RepositoryService() : base(typeof(IRepositoryDao))
		{
		}
		
		public List<EdpsProjectManagement.Entities.BusinessEntities.Repository> SelectAllWithReferenceData(List<EdpsProjectManagement.Entities.BusinessEntities.Repository> items)        {            if (items != null && items.Count > 0)            {                 return this.SelectBy(items, this.CreateReferenceInfoAggregation());            }                return items;        }
		
		private ServiceAggregationInfo CreateReferenceInfoAggregation()
		{
		    ServiceAggregationInfo aggregation = ServiceAggregationInfo.CreateRoot(typeof(EdpsProjectManagement.Entities.BusinessEntities.Repository),typeof(EdpsProjectManagement.Daos.Interfaces.BusinessEntities.IRepositoryDao));
		
		    return aggregation;
		}
		
		protected override ServiceAggregationInfo CreateAllInfoAggregation()
		{
		    ServiceAggregationInfo aggregation = ServiceAggregationInfo.CreateRoot(typeof(EdpsProjectManagement.Entities.BusinessEntities.Repository),typeof(EdpsProjectManagement.Daos.Interfaces.BusinessEntities.IRepositoryDao));
		
		    return aggregation;
		}
		
		
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
