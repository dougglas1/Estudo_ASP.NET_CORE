using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hangfire;
using System.Configuration;
namespace DouglasAgendador
{
    public class HangfireBootstrapper //: IRegisteredObject
    {
        //public static readonly HangfireBootstrapper Instance = new HangfireBootstrapper();
        //
        //private readonly object _lockObject = new object();
        //private bool _started;
        //
        //private BackgroundJobServer _backgroundJobServer;
        //
        //private HangfireBootstrapper()
        //{
        //}
        //
        //public void Start()
        //{
        //    lock (_lockObject)
        //    {
        //        if (_started) return;
        //        _started = true;
        //
        //        HostingEnvironment.RegisterObject(this);
        //
        //        GlobalConfiguration.Configuration.UseRedisStorage(ConfigurationManager
        //            .ConnectionStrings["HangfireRedisUrl"].ConnectionString);
        //
        //        _backgroundJobServer = new BackgroundJobServer();
        //
        //        var cron1ForDay = "20 4 * * 1-6";
        //
        //        RecurringJob.AddOrUpdate<ClienteController>("Douglas.Angedar.ClienteConsultaTeste", x => x.BuscarClientes(), cron1ForDay);
        //    }
        //}
        //
        //public void Stop()
        //{
        //    lock (_lockObject)
        //    {
        //        if (_backgroundJobServer != null)
        //        {
        //            _backgroundJobServer.Dispose();
        //        }
        //
        //        HostingEnvironment.UnregisterObject(this);
        //    }
        //}
        //
        //void IRegisteredObject.Stop(bool immediate)
        //{
        //    Stop();
        //}
    }
}
