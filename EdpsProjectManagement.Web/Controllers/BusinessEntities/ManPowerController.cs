using System.Collections.Generic;
using System.Linq;
using MetaShare.Common.Core.CommonService;
using MetaShare.Common.Core.Entities;
using EdpsProjectManagement.Web.Models;

namespace EdpsProjectManagement.Web.Controllers.BusinessEntities
{
	
	public class ManPowerController: ObjectVersionController<EdpsProjectManagement.Entities.BusinessEntities.ManPower,EdpsProjectManagement.Services.Interfaces.BusinessEntities.IManPowerService,EdpsProjectManagement.Web.Models.BusinessEntities.ManPowerModel>
	{
		
		protected override string GetCurrentAreaPath()
		{
			return "BusinessEntities/ManPower";
		}
		
		protected override List<EdpsProjectManagement.Entities.BusinessEntities.ManPower> GetPagerData(Pager pager)
		{
			return this.Service.SelectAll(pager);
		}
		
		protected override List<EdpsProjectManagement.Entities.BusinessEntities.ManPower> GetBySearchModel(SearchModel pagerSearchModel)
		{
			if (pagerSearchModel == null) return this.GetPagerData(new Pager { PageIndex = 1, PageSize = PageSize });
			List<EdpsProjectManagement.Entities.BusinessEntities.ManPower> lists = this.Service.SelectBy(pagerSearchModel.Pager,new EdpsProjectManagement.Entities.BusinessEntities.ManPower { Name = pagerSearchModel.Name }, ManPower => ManPower.Name.Contains(pagerSearchModel.Name));
			return lists;
		}
		
		protected override EdpsProjectManagement.Entities.BusinessEntities.ManPower GetEntity(int id)
		{
			return this.Service.SelectById(new EdpsProjectManagement.Entities.BusinessEntities.ManPower { Id = id }, true);
		}
		
		protected override void LoadViewReferenceData(EdpsProjectManagement.Web.Models.BusinessEntities.ManPowerModel model)
		{
			if (model == null) return;
			base.LoadViewReferenceData(model);
			
		}
	}
}
