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
	public class ManPowerDao:ObjectVersionDao<EdpsProjectManagement.Entities.BusinessEntities.ManPower>,EdpsProjectManagement.Daos.Interfaces.BusinessEntities.IManPowerDao
	{
		public class ManPowerSqlBuilder : ObjectVersionSqlBuilder
		{
			public ManPowerSqlBuilder(SqlDialect sqlDialect) : base(sqlDialect,"ManPower")
			{
				this.SqlInsertFront = "AvailableHours,EndDate,StartDate,";
				this.SqlInsertBack = "@AvailableHours,@EndDate,@StartDate,";
			}
		}
		
		public class ManPowerResultHandler : ObjectVersionResultHandler<EdpsProjectManagement.Entities.BusinessEntities.ManPower>
		{
			public override void GetColumnValues(IDataReader reader,EdpsProjectManagement.Entities.BusinessEntities.ManPower item)
			{
				base.GetColumnValues(reader, item);
				int ordinalAvailableHours = reader.GetOrdinal("AvailableHours");
				item.AvailableHours = reader.IsDBNull(ordinalAvailableHours) ? 0 : reader.GetInt32(ordinalAvailableHours);
				int ordinalEndDate = reader.GetOrdinal("EndDate");
				item.EndDate = reader.IsDBNull(ordinalEndDate) ? DateTime.MinValue : reader.GetDateTime(ordinalEndDate);
				int ordinalStartDate = reader.GetOrdinal("StartDate");
				item.StartDate = reader.IsDBNull(ordinalStartDate) ? DateTime.MinValue : reader.GetDateTime(ordinalStartDate);
				/*add customized code between this region*/
				/*add customized code between this region*/
			}
			
			public override void AddInsertParameters(IContext context, IDbCommand command, EdpsProjectManagement.Entities.BusinessEntities.ManPower item)
			{
				base.AddInsertParameters(context, command, item);
				context.AddParameter(command,"AvailableHours",item.AvailableHours);
				context.AddParameter(command,"EndDate",item.EndDate == DateTime.MinValue ?  (object) DBNull.Value : item.EndDate);
				context.AddParameter(command,"StartDate",item.StartDate == DateTime.MinValue ?  (object) DBNull.Value : item.StartDate);
				/*add customized code between this region*/
				/*add customized code between this region*/
			}
		}
		
		public ManPowerDao(SqlDialect sqlDialect) : base(new ManPowerSqlBuilder(sqlDialect), new ManPowerResultHandler())
		{
		}
		public ManPowerDao(SqlDialect sqlDialect, string schemaConnectionString) : base(new ManPowerSqlBuilder(sqlDialect), new ManPowerResultHandler(), schemaConnectionString)
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
