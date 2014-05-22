using ClubCloud.SignalR;
using ClubCloud.SignalR.Connections;
using ClubCloud.SignalR.Hubs;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Routing;
using Microsoft.Owin.Security.OAuth;

[assembly: OwinStartupAttribute(typeof(ClubCloud.SignalR.Startup), "Configuration")]
[assembly: PreApplicationStartMethodAttribute(typeof(ClubCloud.SignalR.Startup), "Start")]

namespace ClubCloud.SignalR
{
    public partial class Startup
    {
        public static void Start()
        {
            HostingEnvironment.RegisterVirtualPathProvider(new SignalRVirtualPathProvider());
        }

        public void Configuration(IAppBuilder app)
        {
            app.Use(typeof(SPMiddleware));
            ConfigureSignalR(GlobalHost.DependencyResolver, GlobalHost.HubPipeline);

            // Branch the pipeline here for requests that start with "/signalr"
            app.Map("/signalr", map =>
            {
                map.UseCors(CorsOptions.AllowAll);
                var hubConfiguration = new HubConfiguration
                {
                    EnableJSONP = true,
                    EnableDetailedErrors = true,
                    EnableJavaScriptProxies = true
                };
                map.RunSignalR(hubConfiguration);
                
            });

            /*
            app.Map("/_zimbra", map =>
                {
                    map.UseCors(CorsOptions.AllowAll);

                    var fed = new Microsoft.Owin.Security.ActiveDirectory.ActiveDirectoryFederationServicesBearerAuthenticationOptions
                    {
                    };

                    map.UseActiveDirectoryFederationServicesBearerAuthentication(fed);
                });
            */
            /*            
            HubConfiguration hub = new HubConfiguration
            {
                EnableJSONP = true,
                EnableDetailedErrors = true,
                EnableJavaScriptProxies = true
            };

            app.MapSignalR(hub);
            */
        }
    }
}
