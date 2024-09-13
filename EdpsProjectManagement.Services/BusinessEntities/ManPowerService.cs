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
	public class ManPowerService: ObjectVersionService<EdpsProjectManagement.Entities.BusinessEntities.ManPower>,IManPowerService
	{
		public ManPowerService() : base(typeof(IManPowerDao))
		{
		}
		
		public List<EdpsProjectManagement.Entities.BusinessEntities.ManPower> SelectAllWithReferenceData(List<EdpsProjectManagement.Entities.BusinessEntities.ManPower> items)        {            if (items != null && items.Count > 0)            {                 return this.SelectBy(items, this.CreateReferenceInfoAggregation());            }                return items;        }
		
		private ServiceAggregationInfo CreateReferenceInfoAggregation()
		{
		    ServiceAggregationInfo aggregation = ServiceAggregationInfo.CreateRoot(typeof(EdpsProjectManagement.Entities.BusinessEntities.ManPower),typeof(EdpsProjectManagement.Daos.Interfaces.BusinessEntities.IManPowerDao));
		
		    return aggregation;
		}
		
		protected override ServiceAggregationInfo CreateAllInfoAggregation()
		{
		    ServiceAggregationInfo aggregation = ServiceAggregationInfo.CreateRoot(typeof(EdpsProjectManagement.Entities.BusinessEntities.ManPower),typeof(EdpsProjectManagement.Daos.Interfaces.BusinessEntities.IManPowerDao));
		
		    return aggregation;
		}
		
		
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
