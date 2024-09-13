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
	public class IterationService: ObjectVersionService<EdpsProjectManagement.Entities.BusinessEntities.Iteration>,IIterationService
	{
		public IterationService() : base(typeof(IIterationDao))
		{
		}
		
		public List<EdpsProjectManagement.Entities.BusinessEntities.Iteration> SelectAllWithReferenceData(List<EdpsProjectManagement.Entities.BusinessEntities.Iteration> items)        {            if (items != null && items.Count > 0)            {                 return this.SelectBy(items, this.CreateReferenceInfoAggregation());            }                return items;        }
		
		private ServiceAggregationInfo CreateReferenceInfoAggregation()
		{
		    ServiceAggregationInfo aggregation = ServiceAggregationInfo.CreateRoot(typeof(EdpsProjectManagement.Entities.BusinessEntities.Iteration),typeof(EdpsProjectManagement.Daos.Interfaces.BusinessEntities.IIterationDao));
		
		    return aggregation;
		}
		
		protected override ServiceAggregationInfo CreateAllInfoAggregation()
		{
		    ServiceAggregationInfo aggregation = ServiceAggregationInfo.CreateRoot(typeof(EdpsProjectManagement.Entities.BusinessEntities.Iteration),typeof(EdpsProjectManagement.Daos.Interfaces.BusinessEntities.IIterationDao));
		
		    return aggregation;
		}
		
		
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
