using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MetaShare.Common.Core.Presentation;

using EdpsProjectManagement.WebApi.Models;
using MetaShare.Common.Core.Entities;
using MetaShare.Common.Core.Services;
using ServiceFactory = MetaShare.Common.Core.CommonService.ServiceFactory;


namespace EdpsProjectManagement.WebApi.Controllers
{
	public class CommonApiController<TEntity, TService> : Controller where TEntity : MetaShare.Common.Core.Entities.Common, new() where TService : IPagingService<TEntity>
	{
		#region Consts
		protected TService Service  { get; set; }
		
		protected CommonApiController()
		[Route("SelectById")]
		[Route("SelectByIdWithChild")]
		[Route("SelectAll")]
		[Route("SelectAllWithChild")]
		[Route("SelectBy")]
		[Route("Insert")]
		[Route("Update")]
		[Route("Delete")]
		[Route("Delete")]
		[Route("SelectPagerByColumns")]
		[Route("SelectAllByPager")]
		[Route("SelectAllByPagerWithChild")]
		#region Api For App
		
		[Route("SelectAllByColumns")]
		[Route("SelectByColumns")]
		[Route("Add")]
		protected virtual void AdditionalInsertLogic(TEntity entity)
		[Route("Edit")]
		[Route("UpdateFromBody")]
		protected virtual void AdditionalUpdateLogic(TEntity entity, TEntity newEntity)
		protected virtual void AdditionalUpdateLogic(dynamic entity, TEntity newEntity)
		[HttpPost]
		protected virtual ICollection<string> RemoveByteArrayKey(TEntity fileSource,ICollection<string> keys)
		protected virtual List<string> GetByteArrayPropertyKeys(TEntity fileSource)
		#endregion
		
	}
}