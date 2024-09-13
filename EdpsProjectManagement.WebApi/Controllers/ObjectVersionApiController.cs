using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MetaShare.Common.Core.Presentation;

using EdpsProjectManagement.WebApi.Models;
using MetaShare.Common.Core.Entities;
using MetaShare.Common.Core.Services.Version;

namespace EdpsProjectManagement.WebApi.Controllers
{
	public class ObjectVersionApiController<TEntity, TService> : CommonApiController<TEntity, TService> where TEntity : ObjectVersion, new() where TService : IObjectVersionService<TEntity>
	{
		[Route("SelectBySpecifyDate")]
		[Route("SelectAllByDateTime")]
		[Route("SelectAllByDateTimeWithChild")]
	}
}