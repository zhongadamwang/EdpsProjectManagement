using System;
using System.Data;
using MetaShare.Common.Core.Daos;
using EdpsProjectManagement.Daos.Interfaces.BusinessEntities;
using EdpsProjectManagement.Entities.BusinessEntities;
/*add customized code between this region*/
/*add customized code between this region*/


namespace EdpsProjectManagement.Daos.BusinessEntities
{
	public class RepositoryDao:CommonObjectDao<EdpsProjectManagement.Entities.BusinessEntities.Repository>,EdpsProjectManagement.Daos.Interfaces.BusinessEntities.IRepositoryDao
	{
		public class RepositorySqlBuilder : ObjectSqlBuilder
		{
			public RepositorySqlBuilder(SqlDialect sqlDialect) : base(sqlDialect,"Repository")
			{
				this.SqlInsert = "INSERT INTO " + this.TableName + "(" + this.SqlBaseFieldInsertFront + ") VALUES (" + this.SqlBaseFieldInsertBack + ")";
				this.SqlUpdate = "UPDATE " + this.TableName + " SET " + this.SqlBaseFieldUpdate + " WHERE Id=@Id";
			}
		}
		
		public class RepositoryResultHandler : CommonObjectResultHandler<EdpsProjectManagement.Entities.BusinessEntities.Repository>
		{
			public override void GetColumnValues(IDataReader reader,EdpsProjectManagement.Entities.BusinessEntities.Repository item)
			{
				base.GetColumnValues(reader, item);
				/*add customized code between this region*/
				/*add customized code between this region*/
			}
			
			public override void AddInsertParameters(IContext context, IDbCommand command, EdpsProjectManagement.Entities.BusinessEntities.Repository item)
			{
				base.AddInsertParameters(context, command, item);
				/*add customized code between this region*/
				/*add customized code between this region*/
			}
		}
		
		public RepositoryDao(SqlDialect sqlDialect) : base(new RepositorySqlBuilder(sqlDialect), new RepositoryResultHandler())
		{
		}
		public RepositoryDao(SqlDialect sqlDialect, string schemaConnectionString) : base(new RepositorySqlBuilder(sqlDialect), new RepositoryResultHandler(), schemaConnectionString)
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
