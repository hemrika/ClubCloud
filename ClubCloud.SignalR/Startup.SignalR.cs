using ClubCloud.Service;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using Microsoft.SharePoint;
using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Web;

namespace ClubCloud.SignalR
{
    public partial class Startup
    {
        public static void ConfigureSignalR(IDependencyResolver dependencyResolver, IHubPipeline hubPipeline)
        {
            // Uncomment the following line to enable scale-out using SQL Server
            //SignalRScaleOutDatabase(ref dependencyResolver);
            string connection = string.Empty;
            try
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                connection = client.ScaleOutConnection("ClubCloudService_SignalR");
            }
            catch { }
            finally
            {
                if (!string.IsNullOrWhiteSpace(connection))
                {
                    dependencyResolver.UseSqlServer(connection);
                }
            }

            // Any connection or hub wire up and configuration should go here
            hubPipeline.AddModule(new ClubCloudPipelineModule());
        }

        private class ClubCloudPipelineModule : HubPipelineModule
        {
            protected override bool OnBeforeIncoming(IHubIncomingInvokerContext context)
            {
                Debug.WriteLine("=> Invoking " + context.MethodDescriptor.Name + " on hub " + context.MethodDescriptor.Hub.Name);
                return base.OnBeforeIncoming(context);
            }

            protected override bool OnBeforeOutgoing(IHubOutgoingInvokerContext context)
            {
                Debug.WriteLine("<= Invoking " + context.Invocation.Method + " on client hub " + context.Invocation.Hub);
                return base.OnBeforeOutgoing(context);
            }
        }

        /// <summary>
        /// No SPContext available...
        /// </summary>
        /// <param name="dependencyResolver"></param>
        private static void SignalRScaleOutDatabase(ref IDependencyResolver dependencyResolver)
        {

            Guid siteId = SPContext.GetContext(HttpContext.Current).Site.ID;//.Current.Site.ID;
            string key = "ClubCloudService_SignalR";
            string value = string.Empty;
            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                using (SPSite currentSiteCollection = new SPSite(siteId))
                {
                    using (SPWeb currentWeb = currentSiteCollection.OpenWeb())
                    {
                        currentWeb.AllowUnsafeUpdates = true;



                        if (!currentWeb.AllProperties.ContainsKey(key))
                        {
                            ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                            value = client.ScaleOutConnection(key);
                            currentWeb.Properties.Add(key, value);
                            currentWeb.Properties.Update();
                        }
                        else
                        {
                            value = currentWeb.AllProperties[key].ToString();
                            SqlConnectionStringBuilder builder = null;
                            using (SqlConnection connection = new SqlConnection(value))
                            {
                                builder = new SqlConnectionStringBuilder(connection.ConnectionString);

                                if (!builder.InitialCatalog.Equals(key, StringComparison.InvariantCultureIgnoreCase))
                                {
                                    ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                                    value = client.ScaleOutConnection(key);
                                    currentWeb.AllProperties[key] = value;
                                    currentWeb.Properties.Update();
                                }
                            }
                        }

                        currentWeb.AllowUnsafeUpdates = false;
                    }
                }
            });

            if (string.IsNullOrWhiteSpace(value))
            {
                dependencyResolver.UseSqlServer(value);
            }
        }
    }
}
