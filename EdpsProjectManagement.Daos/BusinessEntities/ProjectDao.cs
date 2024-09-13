using System;
using System.Data;
using MetaShare.Common.Core.Daos;
using EdpsProjectManagement.Daos.Interfaces.BusinessEntities;
using EdpsProjectManagement.Entities.BusinessEntities;
/*add customized code between this region*/
/*add customized code between this region*/


namespace EdpsProjectManagement.Daos.BusinessEntities
{
	public class ProjectDao:CommonObjectDao<EdpsProjectManagement.Entities.BusinessEntities.Project>,EdpsProjectManagement.Daos.Interfaces.BusinessEntities.IProjectDao
	{
		public class ProjectSqlBuilder : ObjectSqlBuilder
		{
			public ProjectSqlBuilder(SqlDialect sqlDialect) : base(sqlDialect,"Project")
			{
				this.SqlInsert = "INSERT INTO " + this.TableName + "(" + this.SqlBaseFieldInsertFront + ") VALUES (" + this.SqlBaseFieldInsertBack + ")";
				this.SqlUpdate = "UPDATE " + this.TableName + " SET " + this.SqlBaseFieldUpdate + " WHERE Id=@Id";
			}
		}
		
		public class ProjectResultHandler : CommonObjectResultHandler<EdpsProjectManagement.Entities.BusinessEntities.Project>
		{
			public override void GetColumnValues(IDataReader reader,EdpsProjectManagement.Entities.BusinessEntities.Project item)
			{
				base.GetColumnValues(reader, item);
				/*add customized code between this region*/
				/*add customized code between this region*/
			}
			
			public override void AddInsertParameters(IContext context, IDbCommand command, EdpsProjectManagement.Entities.BusinessEntities.Project item)
			{
				base.AddInsertParameters(context, command, item);
				/*add customized code between this region*/
				/*add customized code between this region*/
			}
		}
		
		public ProjectDao(SqlDialect sqlDialect) : base(new ProjectSqlBuilder(sqlDialect), new ProjectResultHandler())
		{
		}
		public ProjectDao(SqlDialect sqlDialect, string schemaConnectionString) : base(new ProjectSqlBuilder(sqlDialect), new ProjectResultHandler(), schemaConnectionString)
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
