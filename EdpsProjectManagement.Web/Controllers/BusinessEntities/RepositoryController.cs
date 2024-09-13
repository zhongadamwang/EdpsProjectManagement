using System.Collections.Generic;
using System.Linq;
using MetaShare.Common.Core.CommonService;
using MetaShare.Common.Core.Entities;
using EdpsProjectManagement.Web.Models;

namespace EdpsProjectManagement.Web.Controllers.BusinessEntities
{
	
	public class RepositoryController: CommonController<EdpsProjectManagement.Entities.BusinessEntities.Repository,EdpsProjectManagement.Services.Interfaces.BusinessEntities.IRepositoryService,EdpsProjectManagement.Web.Models.BusinessEntities.RepositoryModel>
	{
		
		protected override string GetCurrentAreaPath()
		{
			return "BusinessEntities/Repository";
		}
		
		protected override List<EdpsProjectManagement.Entities.BusinessEntities.Repository> GetPagerData(Pager pager)
		{
			return this.Service.SelectAll(pager);
		}
		
		protected override List<EdpsProjectManagement.Entities.BusinessEntities.Repository> GetBySearchModel(SearchModel pagerSearchModel)
		{
			if (pagerSearchModel == null) return this.GetPagerData(new Pager { PageIndex = 1, PageSize = PageSize });
			List<EdpsProjectManagement.Entities.BusinessEntities.Repository> lists = this.Service.SelectBy(pagerSearchModel.Pager,new EdpsProjectManagement.Entities.BusinessEntities.Repository { Name = pagerSearchModel.Name }, Repository => Repository.Name.Contains(pagerSearchModel.Name));
			return lists;
		}
		
		protected override EdpsProjectManagement.Entities.BusinessEntities.Repository GetEntity(int id)
		{
			return this.Service.SelectById(new EdpsProjectManagement.Entities.BusinessEntities.Repository { Id = id }, true);
		}
		
		protected override void LoadViewReferenceData(EdpsProjectManagement.Web.Models.BusinessEntities.RepositoryModel model)
		{
			if (model == null) return;
			base.LoadViewReferenceData(model);
			
		}
	}
}
