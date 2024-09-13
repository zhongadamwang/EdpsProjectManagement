using MetaShare.Common.Core.CommonService;

namespace EdpsProjectManagement.Services
{
	public class RegisterServices
	{
		public static void RegisterAll()
		{
			Register(ServiceFactory.Instance, true);
		}
		
		public static void UnRegisterAll()
		{
			Register(ServiceFactory.Instance, false);
		}
		
		public static void Register(ServiceFactory factory, bool isRegister)
		{
			factory.Register(typeof(EdpsProjectManagement.Services.Interfaces.BusinessEntities.IIterationService), new EdpsProjectManagement.Services.BusinessEntities.IterationService(), isRegister);
			factory.Register(typeof(EdpsProjectManagement.Services.Interfaces.BusinessEntities.IManPowerService), new EdpsProjectManagement.Services.BusinessEntities.ManPowerService(), isRegister);
			factory.Register(typeof(EdpsProjectManagement.Services.Interfaces.BusinessEntities.IProjectService), new EdpsProjectManagement.Services.BusinessEntities.ProjectService(), isRegister);
			factory.Register(typeof(EdpsProjectManagement.Services.Interfaces.BusinessEntities.IRepositoryService), new EdpsProjectManagement.Services.BusinessEntities.RepositoryService(), isRegister);
			factory.Register(typeof(EdpsProjectManagement.Services.Interfaces.BusinessEntities.ITaskService), new EdpsProjectManagement.Services.BusinessEntities.TaskService(), isRegister);
		}
	}
}
