using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace EdpsProjectManagement.Web.Models.BusinessEntities
{
	public class ProjectModel: CommonModel<EdpsProjectManagement.Entities.BusinessEntities.Project>
	{
		public List<EdpsProjectManagement.Entities.BusinessEntities.Task> Task { get; set; }
		
		public override void PopulateFrom(EdpsProjectManagement.Entities.BusinessEntities.Project entity)
		{
			if (entity == null) return;
			base.PopulateFrom(entity);
		}
		
		public override void PopulateTo(EdpsProjectManagement.Entities.BusinessEntities.Project entity)
		{
			if (entity == null) return;
			base.PopulateTo(entity);
		}
	}
}
