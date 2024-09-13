using System.Collections.Generic;
using MetaShare.Common.Core.Entities;
using MetaShare.Common.Core.Services;
using MetaShare.Common.Core.Services.Version;
using EdpsProjectManagement.Entities.BusinessEntities;
/*add customized code between this region*/
/*add customized code between this region*/


namespace EdpsProjectManagement.Services.Interfaces.BusinessEntities
{
	public interface IManPowerService: IObjectVersionService<EdpsProjectManagement.Entities.BusinessEntities.ManPower>
	{
	    List<EdpsProjectManagement.Entities.BusinessEntities.ManPower> SelectAllWithReferenceData(List<EdpsProjectManagement.Entities.BusinessEntities.ManPower> items);
	    /*add customized code between this region*/
	/*add customized code between this region*/
	}
}
