using Owin;
using System.Web;
using System.Web.Hosting;

namespace ClubCloud.SignalR
{
    public class SignalRModule : IHttpModule
    {
        public static bool IsAttached = false;
        private readonly object _lock = new object();
        private static IAppBuilder app;
        /// <summary>

        /// </summary>

        public void Dispose()
        {
            //nothing to clean up.
        }

        public void Init(HttpApplication context)
        {
            //check if the routes are already attached - this only happens once.
            if (IsAttached) return;
            
            //lock it, could be called several times in parallel 
            lock (_lock)
            {
                //check if the call before attached.
                if (IsAttached) return;

                //register the custom VirtualPath provider that trims the starting ~ from the requested url.
                HostingEnvironment.RegisterVirtualPathProvider(new SignalRVirtualPathProvider());

                //System.Web.Routing.RouteTable.Routes
                //this is usually call in the App_Start thing from SignalR and registers the hub endpoint.
                /*
                HubConfiguration hubConfiguration = new HubConfiguration
                {
                    EnableDetailedErrors = true,
                    EnableJavaScriptProxies = true,
                    EnableJSONP = true,
                };
                RouteTable.Routes.MapHubs(hubConfiguration);
                */

                app = new Microsoft.Owin.Builder.AppBuilder();
                /*
                app.Map("/signalr", map =>
                {
                    map.UseCors(CorsOptions.AllowAll);

                    HubConfiguration hubConfiguration = new HubConfiguration
                    {
                        EnableDetailedErrors = true,
                        EnableJSONP = true,
                        EnableJavaScriptProxies = true
                    };

                    map.RunSignalR(hubConfiguration);
                });
                app.MapSignalR<ClubCloud.SignalR.Connections.StreamingConnection>("/Connected");
                RouteTable.Routes.MapConnection<ClubCloud.SignalR.Connections.StreamingConnection>("Connected", "/Connected");
                */
                //app.MapSignalR();

                //app.MapSignalR(hubConfiguration);
                //builder.MapSignalR(hubConfiguration);
                //RouteTable.Routes.MapHubs(hubConfiguration);
                //RouteTable.Routes.MapConnection<ClubCloud.SignalR.Connections.StreamingConnection>("Connected", "/Connected");
                //SPIisWebServiceApplication curr = SPIisWebServiceApplication.Current;
                //ClubCloudServiceApplication application = SPIisWebServiceApplication.Current as ClubCloudServiceApplication;
                /*
                ClubCloudServiceProxy serviceProxy = SPFarm.Local.ServiceProxies.GetValue<ClubCloudServiceProxy>();

                HttpRequest req = context.Request;
                SPSite site = new SPSite(req.Url.ToString());
                SPServiceContext serviceContext = SPServiceContext.GetContext(site);
                ClubCloudServiceApplicationProxy sapp = serviceContext.GetDefaultProxy(typeof(ClubCloudServiceApplicationProxy)) as ClubCloudServiceApplicationProxy;
                */
                
                //GlobalHost.DependencyResolver.UseSqlServer(sapp.Database.DatabaseConnectionString);

                //app.MapConnection<ClubCloud.SignalR.Connections.StreamingConnection>("/Connected");
                //builder.MapConnection<ClubCloud.SignalR.Connections.StreamingConnection>("/Connected");
                //Owin.IAppBuilder builder = new Microsoft.Owin.Builder.AppBuilder();
                /*
                builder.Map("/cors", map =>
                {
                    map.UseCors(CorsOptions.AllowAll);
                    //map.MapSignalR<RawConnection>("/raw-connection");
                    map.MapSignalR();
                });
                */
                //builder.MapHubs()
                //builder.MapHubs(hubConfiguration);
                //app.RunSignalR();
                //builder.RunSignalR();
                //RouteTable.Routes.MapHubs(hubConfiguration);

                //throw new Exception("on purpose");
                

                IsAttached = true;
            }
        }
    }
}
