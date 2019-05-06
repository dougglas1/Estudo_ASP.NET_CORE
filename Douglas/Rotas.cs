using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Douglas
{
    public static class Rotas
    {
        public static void AdicionarRotas(IApplicationBuilder app)
        {
            app.UseMvc(routes =>
            {
                routes.MapRoute("Menu", "{controller=Menu}/{action=Index}/{id?}");
                routes.MapRoute("Cabecalho", "{controller=Menu}/{action=Cabecalho}/{id?}");
                routes.MapRoute("Rodape", "{controller=Menu}/{action=Rodape}/{id?}");
                routes.MapRoute("Cliente", "{controller=CSHTML}/{action=Cliente}/{id?}");
            });
        }
    }
}
