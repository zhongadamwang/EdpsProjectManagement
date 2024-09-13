using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace EdpsProjectManagement.Web.Models.BusinessEntities
{
	public class TaskModel: ObjectVersionModel<EdpsProjectManagement.Entities.BusinessEntities.Task>
	{
		public EdpsProjectManagement.Entities.BusinessEntities.Iteration Iteration { get; set; }
		public  List<EdpsProjectManagement.Entities.BusinessEntities.Iteration> Iterations { get; set; }
		public EdpsProjectManagement.Entities.BusinessEntities.Project Project { get; set; }
		public EdpsProjectManagement.Entities.BusinessEntities.Repository Repository { get; set; }
		public  List<EdpsProjectManagement.Entities.BusinessEntities.Repository> Repositorys { get; set; }
		public  int ActualHours { get; set; }
		public  string Assignee { get; set; }
		public  int EstimateHours { get; set; }
		public  DateTime ImportDateTime { get; set; }
		public  string Label { get; set; }
		public  string ReleaseTarget { get; set; }
		public  int RemainHours { get; set; }
		public  string Status { get; set; }
		public  string UniqueLink { get; set; }
		public  DateTime WorkDate { get; set; }
		
		public override void PopulateFrom(EdpsProjectManagement.Entities.BusinessEntities.Task entity)
		{
			if (entity == null) return;
			base.PopulateFrom(entity);
			this.ActualHours = entity.ActualHours;
			this.Assignee = entity.Assignee;
			this.EstimateHours = entity.EstimateHours;
			this.ImportDateTime = entity.ImportDateTime;
			this.Label = entity.Label;
			this.ReleaseTarget = entity.ReleaseTarget;
			this.RemainHours = entity.RemainHours;
			this.Status = entity.Status;
			this.UniqueLink = entity.UniqueLink;
			this.WorkDate = entity.WorkDate;
			this.Iteration = entity.Iteration;
			this.Project = entity.Project;
			this.Repository = entity.Repository;
		}
		
		public override void PopulateTo(EdpsProjectManagement.Entities.BusinessEntities.Task entity)
		{
			if (entity == null) return;
			base.PopulateTo(entity);
			entity.ActualHours = this.ActualHours;
			entity.Assignee = this.Assignee;
			entity.EstimateHours = this.EstimateHours;
			entity.ImportDateTime = this.ImportDateTime;
			entity.Label = this.Label;
			entity.ReleaseTarget = this.ReleaseTarget;
			entity.RemainHours = this.RemainHours;
			entity.Status = this.Status;
			entity.UniqueLink = this.UniqueLink;
			entity.WorkDate = this.WorkDate;
			entity.Iteration = this.Iteration;
			if (this.Iterations != null && this.Iterations.Count > 0)			{				entity.Iteration = this.Iterations.Find(p => entity.Iteration != null && entity.Iteration.Id == p.Id);			}
			entity.Project = this.Project;
			entity.Repository = this.Repository;
			if (this.Repositorys != null && this.Repositorys.Count > 0)			{				entity.Repository = this.Repositorys.Find(p => entity.Repository != null && entity.Repository.Id == p.Id);			}
		}
	}
}
