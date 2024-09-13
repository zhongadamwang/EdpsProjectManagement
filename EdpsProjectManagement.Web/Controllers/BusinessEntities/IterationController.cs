using System.Collections.Generic;
using System.Linq;
using MetaShare.Common.Core.CommonService;
using MetaShare.Common.Core.Entities;
using EdpsProjectManagement.Web.Models;

namespace EdpsProjectManagement.Web.Controllers.BusinessEntities
{
	
	public class IterationController: ObjectVersionController<EdpsProjectManagement.Entities.BusinessEntities.Iteration,EdpsProjectManagement.Services.Interfaces.BusinessEntities.IIterationService,EdpsProjectManagement.Web.Models.BusinessEntities.IterationModel>
	{
		
		protected override string GetCurrentAreaPath()
		{
			return "BusinessEntities/Iteration";
		}
		
		protected override List<EdpsProjectManagement.Entities.BusinessEntities.Iteration> GetPagerData(Pager pager)
		{
			return this.Service.SelectAll(pager);
		}
		
		protected override List<EdpsProjectManagement.Entities.BusinessEntities.Iteration> GetBySearchModel(SearchModel pagerSearchModel)
		{
			if (pagerSearchModel == null) return this.GetPagerData(new Pager { PageIndex = 1, PageSize = PageSize });
			List<EdpsProjectManagement.Entities.BusinessEntities.Iteration> lists = this.Service.SelectBy(pagerSearchModel.Pager,new EdpsProjectManagement.Entities.BusinessEntities.Iteration { Name = pagerSearchModel.Name }, Iteration => Iteration.Name.Contains(pagerSearchModel.Name));
			return lists;
		}
		
		protected override EdpsProjectManagement.Entities.BusinessEntities.Iteration GetEntity(int id)
		{
			return this.Service.SelectById(new EdpsProjectManagement.Entities.BusinessEntities.Iteration { Id = id }, true);
		}
		
		protected override void LoadViewReferenceData(EdpsProjectManagement.Web.Models.BusinessEntities.IterationModel model)
		{
			if (model == null) return;
			base.LoadViewReferenceData(model);
			
		}
	}
}
