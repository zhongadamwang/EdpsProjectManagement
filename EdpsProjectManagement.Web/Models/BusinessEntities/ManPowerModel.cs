using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace EdpsProjectManagement.Web.Models.BusinessEntities
{
	public class ManPowerModel: ObjectVersionModel<EdpsProjectManagement.Entities.BusinessEntities.ManPower>
	{
		public  int AvailableHours { get; set; }
		public  DateTime EndDate { get; set; }
		public  DateTime StartDate { get; set; }
		
		public override void PopulateFrom(EdpsProjectManagement.Entities.BusinessEntities.ManPower entity)
		{
			if (entity == null) return;
			base.PopulateFrom(entity);
			this.AvailableHours = entity.AvailableHours;
			this.EndDate = entity.EndDate;
			this.StartDate = entity.StartDate;
		}
		
		public override void PopulateTo(EdpsProjectManagement.Entities.BusinessEntities.ManPower entity)
		{
			if (entity == null) return;
			base.PopulateTo(entity);
			entity.AvailableHours = this.AvailableHours;
			entity.EndDate = this.EndDate;
			entity.StartDate = this.StartDate;
		}
	}
}
