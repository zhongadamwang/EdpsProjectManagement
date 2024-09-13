using System;
using System.Data;
using MetaShare.Common.Core.Daos;
using MetaShare.Common.Core.Daos.Version;
using EdpsProjectManagement.Daos.Interfaces.BusinessEntities;
using EdpsProjectManagement.Entities.BusinessEntities;
/*add customized code between this region*/
/*add customized code between this region*/


namespace EdpsProjectManagement.Daos.BusinessEntities
{
	public class TaskDao:ObjectVersionDao<EdpsProjectManagement.Entities.BusinessEntities.Task>,EdpsProjectManagement.Daos.Interfaces.BusinessEntities.ITaskDao
	{
		public class TaskSqlBuilder : ObjectVersionSqlBuilder
		{
			public TaskSqlBuilder(SqlDialect sqlDialect) : base(sqlDialect,"Task")
			{
				this.SqlInsertFront = "ActualHours,Assignee,EstimateHours,ImportDateTime,Label,ReleaseTarget,RemainHours,Status,UniqueLink,WorkDate,IterationId,IterationName,IterationDescription,IterationSystemId,ProjectId,ProjectName,ProjectDescription,RepositoryId,RepositoryName,RepositoryDescription,";
				this.SqlInsertBack = "@ActualHours,@Assignee,@EstimateHours,@ImportDateTime,@Label,@ReleaseTarget,@RemainHours,@Status,@UniqueLink,@WorkDate,@IterationId,@IterationName,@IterationDescription,@IterationSystemId,@ProjectId,@ProjectName,@ProjectDescription,@RepositoryId,@RepositoryName,@RepositoryDescription,";
			}
		}
		
		public class TaskResultHandler : ObjectVersionResultHandler<EdpsProjectManagement.Entities.BusinessEntities.Task>
		{
			public override void GetColumnValues(IDataReader reader,EdpsProjectManagement.Entities.BusinessEntities.Task item)
			{
				base.GetColumnValues(reader, item);
				int ordinalActualHours = reader.GetOrdinal("ActualHours");
				item.ActualHours = reader.IsDBNull(ordinalActualHours) ? 0 : reader.GetInt32(ordinalActualHours);
				int ordinalAssignee = reader.GetOrdinal("Assignee");
				item.Assignee = reader.IsDBNull(ordinalAssignee) ? null : reader.GetString(ordinalAssignee);
				int ordinalEstimateHours = reader.GetOrdinal("EstimateHours");
				item.EstimateHours = reader.IsDBNull(ordinalEstimateHours) ? 0 : reader.GetInt32(ordinalEstimateHours);
				int ordinalImportDateTime = reader.GetOrdinal("ImportDateTime");
				item.ImportDateTime = reader.IsDBNull(ordinalImportDateTime) ? DateTime.MinValue : reader.GetDateTime(ordinalImportDateTime);
				int ordinalLabel = reader.GetOrdinal("Label");
				item.Label = reader.IsDBNull(ordinalLabel) ? null : reader.GetString(ordinalLabel);
				int ordinalReleaseTarget = reader.GetOrdinal("ReleaseTarget");
				item.ReleaseTarget = reader.IsDBNull(ordinalReleaseTarget) ? null : reader.GetString(ordinalReleaseTarget);
				int ordinalRemainHours = reader.GetOrdinal("RemainHours");
				item.RemainHours = reader.IsDBNull(ordinalRemainHours) ? 0 : reader.GetInt32(ordinalRemainHours);
				int ordinalStatus = reader.GetOrdinal("Status");
				item.Status = reader.IsDBNull(ordinalStatus) ? null : reader.GetString(ordinalStatus);
				int ordinalUniqueLink = reader.GetOrdinal("UniqueLink");
				item.UniqueLink = reader.IsDBNull(ordinalUniqueLink) ? null : reader.GetString(ordinalUniqueLink);
				int ordinalWorkDate = reader.GetOrdinal("WorkDate");
				item.WorkDate = reader.IsDBNull(ordinalWorkDate) ? DateTime.MinValue : reader.GetDateTime(ordinalWorkDate);
				int ordinalIterationId = reader.GetOrdinal("IterationId");
				int ordinalIterationName = reader.GetOrdinal("IterationName");
				string IterationName = reader.IsDBNull(ordinalIterationName) ? null :reader.GetString(ordinalIterationName);
				int ordinalIterationDescription = reader.GetOrdinal("IterationDescription");
				string IterationDescription = reader.IsDBNull(ordinalIterationDescription) ? null :reader.GetString(ordinalIterationDescription);
				int IterationId = reader.IsDBNull(ordinalIterationId) ? 0 :reader.GetInt32(ordinalIterationId);
				int ordinalIterationSystemId = reader.GetOrdinal("IterationSystemId");
				int IterationSystemId = reader.IsDBNull(ordinalIterationSystemId) ? 0 :reader.GetInt32(ordinalIterationSystemId);
				item.Iteration = new EdpsProjectManagement.Entities.BusinessEntities.Iteration{ Id = IterationId,Name = IterationName, Description = IterationDescription,SystemId = IterationSystemId};
				int ordinalProjectId = reader.GetOrdinal("ProjectId");
				int ordinalProjectName = reader.GetOrdinal("ProjectName");
				string ProjectName = reader.IsDBNull(ordinalProjectName) ? null :reader.GetString(ordinalProjectName);
				int ordinalProjectDescription = reader.GetOrdinal("ProjectDescription");
				string ProjectDescription = reader.IsDBNull(ordinalProjectDescription) ? null :reader.GetString(ordinalProjectDescription);
				item.Project = reader.IsDBNull(ordinalProjectId) ? null : reader.GetInt32(ordinalProjectId) == 0 ? null:new EdpsProjectManagement.Entities.BusinessEntities.Project{ Id = reader.GetInt32(ordinalProjectId),Name = ProjectName, Description = ProjectDescription};
				int ordinalRepositoryId = reader.GetOrdinal("RepositoryId");
				int ordinalRepositoryName = reader.GetOrdinal("RepositoryName");
				string RepositoryName = reader.IsDBNull(ordinalRepositoryName) ? null :reader.GetString(ordinalRepositoryName);
				int ordinalRepositoryDescription = reader.GetOrdinal("RepositoryDescription");
				string RepositoryDescription = reader.IsDBNull(ordinalRepositoryDescription) ? null :reader.GetString(ordinalRepositoryDescription);
				item.Repository = reader.IsDBNull(ordinalRepositoryId) ? null : reader.GetInt32(ordinalRepositoryId) == 0 ? null:new EdpsProjectManagement.Entities.BusinessEntities.Repository{ Id = reader.GetInt32(ordinalRepositoryId),Name = RepositoryName, Description = RepositoryDescription};
				/*add customized code between this region*/
				/*add customized code between this region*/
			}
			
			public override void AddInsertParameters(IContext context, IDbCommand command, EdpsProjectManagement.Entities.BusinessEntities.Task item)
			{
				base.AddInsertParameters(context, command, item);
				context.AddParameter(command,"ActualHours",item.ActualHours);
				context.AddParameter(command,"Assignee",item.Assignee ?? (object)DBNull.Value);
				context.AddParameter(command,"EstimateHours",item.EstimateHours);
				context.AddParameter(command,"ImportDateTime",item.ImportDateTime == DateTime.MinValue ?  (object) DBNull.Value : item.ImportDateTime);
				context.AddParameter(command,"Label",item.Label ?? (object)DBNull.Value);
				context.AddParameter(command,"ReleaseTarget",item.ReleaseTarget ?? (object)DBNull.Value);
				context.AddParameter(command,"RemainHours",item.RemainHours);
				context.AddParameter(command,"Status",item.Status ?? (object)DBNull.Value);
				context.AddParameter(command,"UniqueLink",item.UniqueLink ?? (object)DBNull.Value);
				context.AddParameter(command,"WorkDate",item.WorkDate == DateTime.MinValue ?  (object) DBNull.Value : item.WorkDate);
				context.AddParameter(command,"IterationId",item.Iteration== null? 0 :item.Iteration.Id);
				context.AddParameter(command,"IterationName",item.Iteration== null? (object) DBNull.Value : string.IsNullOrEmpty(item.Iteration.Name) ? (object)DBNull.Value : item.Iteration.Name);
				context.AddParameter(command,"IterationDescription",item.Iteration== null? (object) DBNull.Value : string.IsNullOrEmpty(item.Iteration.Description) ? (object)DBNull.Value : item.Iteration.Description);
				context.AddParameter(command,"IterationSystemId",item.Iteration== null? 0 :item.Iteration.SystemId);
				context.AddParameter(command,"ProjectId",item.Project== null? 0 :item.Project.Id);
				context.AddParameter(command,"ProjectName",item.Project== null? (object) DBNull.Value : string.IsNullOrEmpty(item.Project.Name) ? (object)DBNull.Value : item.Project.Name);
				context.AddParameter(command,"ProjectDescription",item.Project== null? (object) DBNull.Value : string.IsNullOrEmpty(item.Project.Description) ? (object)DBNull.Value : item.Project.Description);
				context.AddParameter(command,"RepositoryId",item.Repository== null? 0 :item.Repository.Id);
				context.AddParameter(command,"RepositoryName",item.Repository== null? (object) DBNull.Value : string.IsNullOrEmpty(item.Repository.Name) ? (object)DBNull.Value : item.Repository.Name);
				context.AddParameter(command,"RepositoryDescription",item.Repository== null? (object) DBNull.Value : string.IsNullOrEmpty(item.Repository.Description) ? (object)DBNull.Value : item.Repository.Description);
				/*add customized code between this region*/
				/*add customized code between this region*/
			}
		}
		
		public TaskDao(SqlDialect sqlDialect) : base(new TaskSqlBuilder(sqlDialect), new TaskResultHandler())
		{
		}
		public TaskDao(SqlDialect sqlDialect, string schemaConnectionString) : base(new TaskSqlBuilder(sqlDialect), new TaskResultHandler(), schemaConnectionString)
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
