using System;
using MetaShare.Common.Core.Daos;
/*add customized code between this region*/
/*add customized code between this region*/

namespace EdpsProjectManagement.Daos
{
	public class RegisterDaos
	{
		public static void RegisterAll(Type sqlDialect, Type sqlDialectVersion)
		{
			Register(DaoFactory.Instance, true,sqlDialect,sqlDialectVersion);
		}
		
		public static void UnRegisterAll(Type sqlDialect, Type sqlDialectVersion)
		{
			Register(DaoFactory.Instance, false,sqlDialect,sqlDialectVersion);
		}
		
		public static void Register(DaoFactory factory, bool isRegister, Type sqlDialect, Type sqlDialectVersion)
		{
			factory.Register(typeof(EdpsProjectManagement.Daos.Interfaces.BusinessEntities.IIterationDao), new EdpsProjectManagement.Daos.BusinessEntities.IterationDao(Activator.CreateInstance(sqlDialectVersion) as SqlDialect), isRegister);
			factory.Register(typeof(EdpsProjectManagement.Daos.Interfaces.BusinessEntities.IManPowerDao), new EdpsProjectManagement.Daos.BusinessEntities.ManPowerDao(Activator.CreateInstance(sqlDialectVersion) as SqlDialect), isRegister);
			factory.Register(typeof(EdpsProjectManagement.Daos.Interfaces.BusinessEntities.IProjectDao), new EdpsProjectManagement.Daos.BusinessEntities.ProjectDao(Activator.CreateInstance(sqlDialect) as SqlDialect), isRegister);
			factory.Register(typeof(EdpsProjectManagement.Daos.Interfaces.BusinessEntities.IRepositoryDao), new EdpsProjectManagement.Daos.BusinessEntities.RepositoryDao(Activator.CreateInstance(sqlDialect) as SqlDialect), isRegister);
			factory.Register(typeof(EdpsProjectManagement.Daos.Interfaces.BusinessEntities.ITaskDao), new EdpsProjectManagement.Daos.BusinessEntities.TaskDao(Activator.CreateInstance(sqlDialectVersion) as SqlDialect), isRegister);
			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	}
}
