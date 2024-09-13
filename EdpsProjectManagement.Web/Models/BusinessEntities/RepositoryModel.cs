using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace EdpsProjectManagement.Web.Models.BusinessEntities
{
	public class RepositoryModel: CommonModel<EdpsProjectManagement.Entities.BusinessEntities.Repository>
	{
		
		public override void PopulateFrom(EdpsProjectManagement.Entities.BusinessEntities.Repository entity)
		{
			if (entity == null) return;
			base.PopulateFrom(entity);
		}
		
		public override void PopulateTo(EdpsProjectManagement.Entities.BusinessEntities.Repository entity)
		{
			if (entity == null) return;
			base.PopulateTo(entity);
		}
	}
}
