using System.Collections.Generic;
using MetaShare.Common.Core.Entities;
using MetaShare.Common.Core.Services;
using MetaShare.Common.Core.Services.Version;
using EdpsProjectManagement.Entities.BusinessEntities;
/*add customized code between this region*/
/*add customized code between this region*/


namespace EdpsProjectManagement.Services.Interfaces.BusinessEntities
{
	public interface IIterationService: IObjectVersionService<EdpsProjectManagement.Entities.BusinessEntities.Iteration>
	{
	    List<EdpsProjectManagement.Entities.BusinessEntities.Iteration> SelectAllWithReferenceData(List<EdpsProjectManagement.Entities.BusinessEntities.Iteration> items);
	    /*add customized code between this region*/
	/*add customized code between this region*/
	}
}
