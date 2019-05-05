using DouglasBiblioteca.Controllers;
using DouglasBiblioteca.Controllers.Interfaces;
using DouglasBiblioteca.Dao;
using DouglasBiblioteca.Dao.Interfaces;
using DouglasInfra.UnitOfWork;
using Microsoft.Extensions.DependencyInjection;

namespace DouglasBiblioteca
{
    public static class InjencaoDependencia
    {
        public static void InjetarDependencia(IServiceCollection services)
        {
            // Injeção Unit Of Work
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            //cria a cada solicitação
            services.AddTransient<IClienteController, ClienteController>();
            services.AddTransient<IClienteDao, ClienteDao>();
        }        
    }
}
