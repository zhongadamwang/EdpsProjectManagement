using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

using EdpsProjectManagement.WebApi.Models;
/*add customized code between this region*/
/*add customized code between this region*/


namespace EdpsProjectManagement.WebApi.Controllers.BusinessEntities
{
	[Route("BusinessEntities/ManPowerApi")]
	public class ManPowerApiController: ObjectVersionApiController<EdpsProjectManagement.Entities.BusinessEntities.ManPower,EdpsProjectManagement.Services.Interfaces.BusinessEntities.IManPowerService>
	{
		
		/*add customized code between this region*/
		/*add customized code between this region*/
		
	}
}
