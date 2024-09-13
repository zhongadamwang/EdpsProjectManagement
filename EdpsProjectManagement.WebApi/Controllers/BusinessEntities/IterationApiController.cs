using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

using EdpsProjectManagement.WebApi.Models;
/*add customized code between this region*/
/*add customized code between this region*/


namespace EdpsProjectManagement.WebApi.Controllers.BusinessEntities
{
	[Route("BusinessEntities/IterationApi")]
	public class IterationApiController: ObjectVersionApiController<EdpsProjectManagement.Entities.BusinessEntities.Iteration,EdpsProjectManagement.Services.Interfaces.BusinessEntities.IIterationService>
	{
		
		/*add customized code between this region*/
		/*add customized code between this region*/
		
	}
}
