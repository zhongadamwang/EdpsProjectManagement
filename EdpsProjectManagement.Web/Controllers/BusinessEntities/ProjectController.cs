using System.Collections.Generic;
using System.Linq;
using MetaShare.Common.Core.CommonService;
using MetaShare.Common.Core.Entities;
using EdpsProjectManagement.Web.Models;

namespace EdpsProjectManagement.Web.Controllers.BusinessEntities
{
	
	public class ProjectController: CommonController<EdpsProjectManagement.Entities.BusinessEntities.Project,EdpsProjectManagement.Services.Interfaces.BusinessEntities.IProjectService,EdpsProjectManagement.Web.Models.BusinessEntities.ProjectModel>
	{
		
		protected override string GetCurrentAreaPath()
		{
			return "BusinessEntities/Project";
		}
		
		protected override List<EdpsProjectManagement.Entities.BusinessEntities.Project> GetPagerData(Pager pager)
		{
			return this.Service.SelectAll(pager);
		}
		
		protected override List<EdpsProjectManagement.Entities.BusinessEntities.Project> GetBySearchModel(SearchModel pagerSearchModel)
		{
			if (pagerSearchModel == null) return this.GetPagerData(new Pager { PageIndex = 1, PageSize = PageSize });
			List<EdpsProjectManagement.Entities.BusinessEntities.Project> lists = this.Service.SelectBy(pagerSearchModel.Pager,new EdpsProjectManagement.Entities.BusinessEntities.Project { Name = pagerSearchModel.Name }, Project => Project.Name.Contains(pagerSearchModel.Name));
			return lists;
		}
		
		protected override EdpsProjectManagement.Entities.BusinessEntities.Project GetEntity(int id)
		{
			return this.Service.SelectById(new EdpsProjectManagement.Entities.BusinessEntities.Project { Id = id }, true);
		}
		
		protected override void LoadViewReferenceData(EdpsProjectManagement.Web.Models.BusinessEntities.ProjectModel model)
		{
			if (model == null) return;
			base.LoadViewReferenceData(model);
			
		}
	}
}
