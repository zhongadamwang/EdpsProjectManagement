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
	public class IterationDao:ObjectVersionDao<EdpsProjectManagement.Entities.BusinessEntities.Iteration>,EdpsProjectManagement.Daos.Interfaces.BusinessEntities.IIterationDao
	{
		public class IterationSqlBuilder : ObjectVersionSqlBuilder
		{
			public IterationSqlBuilder(SqlDialect sqlDialect) : base(sqlDialect,"Iteration")
			{
				this.SqlInsertFront = "EndDate,StartDate,";
				this.SqlInsertBack = "@EndDate,@StartDate,";
			}
		}
		
		public class IterationResultHandler : ObjectVersionResultHandler<EdpsProjectManagement.Entities.BusinessEntities.Iteration>
		{
			public override void GetColumnValues(IDataReader reader,EdpsProjectManagement.Entities.BusinessEntities.Iteration item)
			{
				base.GetColumnValues(reader, item);
				int ordinalEndDate = reader.GetOrdinal("EndDate");
				item.EndDate = reader.IsDBNull(ordinalEndDate) ? DateTime.MinValue : reader.GetDateTime(ordinalEndDate);
				int ordinalStartDate = reader.GetOrdinal("StartDate");
				item.StartDate = reader.IsDBNull(ordinalStartDate) ? DateTime.MinValue : reader.GetDateTime(ordinalStartDate);
				/*add customized code between this region*/
				/*add customized code between this region*/
			}
			
			public override void AddInsertParameters(IContext context, IDbCommand command, EdpsProjectManagement.Entities.BusinessEntities.Iteration item)
			{
				base.AddInsertParameters(context, command, item);
				context.AddParameter(command,"EndDate",item.EndDate == DateTime.MinValue ?  (object) DBNull.Value : item.EndDate);
				context.AddParameter(command,"StartDate",item.StartDate == DateTime.MinValue ?  (object) DBNull.Value : item.StartDate);
				/*add customized code between this region*/
				/*add customized code between this region*/
			}
		}
		
		public IterationDao(SqlDialect sqlDialect) : base(new IterationSqlBuilder(sqlDialect), new IterationResultHandler())
		{
		}
		public IterationDao(SqlDialect sqlDialect, string schemaConnectionString) : base(new IterationSqlBuilder(sqlDialect), new IterationResultHandler(), schemaConnectionString)
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
