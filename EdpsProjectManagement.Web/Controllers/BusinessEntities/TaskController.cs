using System.Collections.Generic;
using System.Linq;
using MetaShare.Common.Core.CommonService;
using MetaShare.Common.Core.Entities;
using EdpsProjectManagement.Web.Models;

namespace EdpsProjectManagement.Web.Controllers.BusinessEntities
{
	
	public class TaskController: ObjectVersionController<EdpsProjectManagement.Entities.BusinessEntities.Task,EdpsProjectManagement.Services.Interfaces.BusinessEntities.ITaskService,EdpsProjectManagement.Web.Models.BusinessEntities.TaskModel>
	{
		
		protected override string GetCurrentAreaPath()
		{
			return "BusinessEntities/Task";
		}
		
		protected override List<EdpsProjectManagement.Entities.BusinessEntities.Task> GetPagerData(Pager pager)
		{
			return this.Service.SelectAll(pager);
		}
		
		protected override List<EdpsProjectManagement.Entities.BusinessEntities.Task> GetBySearchModel(SearchModel pagerSearchModel)
		{
			if (pagerSearchModel == null) return this.GetPagerData(new Pager { PageIndex = 1, PageSize = PageSize });
			List<EdpsProjectManagement.Entities.BusinessEntities.Task> lists = this.Service.SelectBy(pagerSearchModel.Pager,new EdpsProjectManagement.Entities.BusinessEntities.Task { Name = pagerSearchModel.Name }, Task => Task.Name.Contains(pagerSearchModel.Name));
			return lists;
		}
		
		protected override EdpsProjectManagement.Entities.BusinessEntities.Task GetEntity(int id)
		{
			return this.Service.SelectById(new EdpsProjectManagement.Entities.BusinessEntities.Task { Id = id }, true);
		}
		
		protected override void LoadViewReferenceData(EdpsProjectManagement.Web.Models.BusinessEntities.TaskModel model)
		{
			if (model == null) return;
			base.LoadViewReferenceData(model);
			
			EdpsProjectManagement.Services.Interfaces.BusinessEntities.IIterationService IterationService = ServiceFactory.Instance.GetService<EdpsProjectManagement.Services.Interfaces.BusinessEntities.IIterationService>(); 
			model.Iterations =IterationService.SelectAll().OrderBy(p => p.Name).ToList();
			EdpsProjectManagement.Services.Interfaces.BusinessEntities.IRepositoryService RepositoryService = ServiceFactory.Instance.GetService<EdpsProjectManagement.Services.Interfaces.BusinessEntities.IRepositoryService>(); 
			model.Repositorys =RepositoryService.SelectAll().OrderBy(p => p.Name).ToList();
		}
		
		protected override int DoInsert(EdpsProjectManagement.Entities.BusinessEntities.Task entity)
		{
			return this.Service.Insert(entity, true);
		}
		
		protected override int DoUpdate(EdpsProjectManagement.Entities.BusinessEntities.Task entity)
		{
			return this.Service.Update(entity, true);
		}
		
		protected override int DoDelete(EdpsProjectManagement.Entities.BusinessEntities.Task entity)
		{
			return this.Service.Delete(entity, true);
		}
	}
}
