using Douglas.Controllers;
using Douglas.Controllers.Interfaces;
using Douglas.Dao;
using Douglas.Dao.Interfaces;
using DouglasInfra.UnitOfWork;
using SimpleInjector;

namespace Douglas
{
    public static class InjecaoDependencia
    {
        public static void RegisterServices(ref Container container)
        {
            // Injeção Unit Of Work
            container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Scoped);

            // Injeção Daos
            container.Register<IClienteDao, ClienteDao>(Lifestyle.Scoped);

            // Injeção Controllers
            container.Register<IClienteController, ClienteController>(Lifestyle.Scoped);
        }
    }
}
