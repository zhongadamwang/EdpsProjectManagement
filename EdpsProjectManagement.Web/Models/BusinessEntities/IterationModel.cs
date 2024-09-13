using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace EdpsProjectManagement.Web.Models.BusinessEntities
{
	public class IterationModel: ObjectVersionModel<EdpsProjectManagement.Entities.BusinessEntities.Iteration>
	{
		public  DateTime EndDate { get; set; }
		public  DateTime StartDate { get; set; }
		
		public override void PopulateFrom(EdpsProjectManagement.Entities.BusinessEntities.Iteration entity)
		{
			if (entity == null) return;
			base.PopulateFrom(entity);
			this.EndDate = entity.EndDate;
			this.StartDate = entity.StartDate;
		}
		
		public override void PopulateTo(EdpsProjectManagement.Entities.BusinessEntities.Iteration entity)
		{
			if (entity == null) return;
			base.PopulateTo(entity);
			entity.EndDate = this.EndDate;
			entity.StartDate = this.StartDate;
		}
	}
}
