﻿using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;
using System;
using System.Collections.Generic;
using System.Configuration.Provider;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using ClubCloud.Zimbra;
using ClubCloud.Zimbra.Service;
using System.Configuration;
using System.Collections.Specialized;
using ClubCloud.Zimbra.Global;

namespace ClubCloud.Provider
{
    public class ZimbraRoleProvider : System.Web.Security.RoleProvider
    {
        #region properties

        private bool Initialized;
        private string applicationName;
        private Zimbra.ZimbraServer zimbraServer;
        private ZimbraProviderSettings zimbraSettings;
        internal static ZimbraConfigurationSection zimbraconfiguration = null;
        private Zimbra.Global.VersionInfo zimbraVersion;
        private string AdminToken;
        public const string AllAuthenticatedUsersRoleName = "All Authenticated Users";

        #endregion

        #region Initialisation

        public ZimbraRoleProvider() : base()
        {
            SetConfiguration();
        }

        private void SetConfiguration()
        {
            try
            {
                zimbraconfiguration = (ZimbraConfigurationSection)ConfigurationManager.GetSection("Zimbra/Configuration");
            }
            catch (Exception ex)
            {
                string messsage = ex.Message;
            }

            if (zimbraconfiguration == null)
            {
                zimbraconfiguration = new ZimbraConfigurationSection();
            }
        }

        public override string Name
        {
            get
            {
                return "ZimbraRoleProvider";
            }
        }

        public override string Description
        {
            get
            {
                return "Zimbra Role Provider";
            }
        }

        public override string ApplicationName
        {
            get
            {
                if (!Initialized)
                {
                    SetConfiguration();
                    Initialize(string.Empty, new NameValueCollection());

                    if (!Initialized)
                    {
                        string message = String.Format("Membership Role Provider {0}: {1}", this.applicationName, "The Role provider was not initialized.");
                        LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                        throw new ProviderException(message);
                    }
                }

                return this.applicationName;
            }
            set
            {
                if (!this.Initialized)
                {
                    this.applicationName = value;
                }
            }
        }

        public override void Initialize(string name, System.Collections.Specialized.NameValueCollection config)
        {
            Task.Run(async () => await InitializeAsync(name, config));
        }

        public async Task InitializeAsync(string name, System.Collections.Specialized.NameValueCollection config)
        {
            try
            {
                base.Initialize(name, config);
            }
            catch { }

            /*
            if (HostingEnvironment.IsHosted)
            {
                NamedPermissionSet permission = HttpRuntime.GetNamedPermissionSet();
                AspNetHostingPermission aspNetHostingPermission = (AspNetHostingPermission)permission.GetPermission(typeof(AspNetHostingPermission));
                if (!(aspNetHostingPermission != null && aspNetHostingPermission.Level >= AspNetHostingPermissionLevel.Low))
                {
                    string message = String.Format("Error while initializing settings Role Provider {0}: {1}", this.applicationName, "Zimbra Provider kan niet in AspNetHostingPermissionLevel.Low werken.");
                    LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                    throw new ProviderException(message);
                }
            }
            */

            if (this.Initialized)
            {
                return;
            }

            if (string.IsNullOrEmpty(name))
            {
                this.applicationName = "ZimbraRoleProvider";
            }
            else
            {
                this.applicationName = name;
            }

            try
            {
                zimbraSettings = ZimbraProviderSettings.Current;

                if (zimbraSettings != null && !String.IsNullOrEmpty(zimbraSettings.ZimbraServer) && !String.IsNullOrEmpty(zimbraSettings.ZimbraUserName) && !String.IsNullOrEmpty(zimbraSettings.ZimbraPassword))
                {
                    zimbraconfiguration.Server.UserName = zimbraSettings.ZimbraUserName;
                    zimbraconfiguration.Server.Password = zimbraSettings.ZimbraPassword;
                    zimbraconfiguration.Server.ServerName = zimbraSettings.ZimbraServer;
                    zimbraconfiguration.Server.IsAdmin = true;
                    /*
                    string message = String.Format("Error while initializing settings Role Provider {0}: {1}", this.applicationName, "The setting for Zimbra are not complete.");
                    LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                    throw new ProviderException(message);
                    */
                }
            }
            catch (ZimbraSettingsException zex)
            {
                string message = String.Format("Error while initializing settings Role Provider {0}: {1}", this.applicationName, zex.Message);
                LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                throw new ProviderException(message, zex);
            }
            /*
            if (string.IsNullOrEmpty(zimbraSettings.ZimbraServer.Trim()))
            {
                string message = String.Format("Error while initializing settings Role Provider {0}: {1}", this.applicationName, "The Zimbra server name can not be empty.");
                LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                throw new ZimbraMembershipException(message);
            }
            */

            if (!string.IsNullOrEmpty(zimbraconfiguration.Server.ServerName))
            {
                zimbraServer = new Zimbra.ZimbraServer(zimbraconfiguration.Server.ServerName);

                try
                {
                    while (!zimbraServer.AuthenticatedAdmin.Value)
                    {
                        try
                        {
                            AdminToken = zimbraServer.Authenticate(zimbraconfiguration.Server.UserName, zimbraconfiguration.Server.Password, zimbraconfiguration.Server.IsAdmin);
                        }
                        catch { }

                        if (string.IsNullOrEmpty(AdminToken))
                        {
                            //zimbraServer = new Zimbra.ZimbraServer(zimbraconfiguration.Server.ServerName);
                            zimbraServer.TriggerWebSite();
                            System.Threading.Thread.Sleep(1000);
                        }
                    }

                    using (Zimbra.Administration.GetVersionInfoResponse response = await zimbraServer.Message(new Zimbra.Administration.GetVersionInfoRequest()) as Zimbra.Administration.GetVersionInfoResponse)
                    {
                        if (response != null)
                        {
                            zimbraVersion = response.info;
                        }
                        else
                        {
                            string message = String.Format("Error while getting VersionInfo for {0}: {1}", this.applicationName, "The Zimbra server returned no VersionInfo.");
                            LogToULS(message, TraceSeverity.Unexpected, EventSeverity.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    string message = String.Format("Error while initializing settings Role Provider {0}: {1}", this.applicationName, ex.Message);
                    LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                    throw new ProviderException(message, ex);
                }
                //GetPasswordProperties();

                //GetLockProperties();

                this.Initialized = true;
            }
        }

        #endregion

        #region Find

        public async Task<string[]> FindUsersInGroup(string groupName, string usernameToMatch)
        {
            if (!Initialized)
            {
                SetConfiguration();
                await InitializeAsync(string.Empty, new NameValueCollection());

                if (!Initialized)
                {
                    string message = String.Format("Membership Role Provider {0}: {1}", this.applicationName, "The Role provider was not initialized.");
                    LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                    throw new ProviderException(message);
                }
            }

            try
            {
                List<string> users = new List<string>();
                string dl_id = null;
                SPContext context = SPContext.Current;
                string domain = null;
                if (context != null)
                {
                    domain = GetZimbraDomain(context.Site.Url);

                    Zimbra.Administration.SearchDirectoryRequest srequest = new Zimbra.Administration.SearchDirectoryRequest { applyConfig = false, applyCos = false, domain = domain, limit = 50, countOnly = false, offset = 0, sortAscending = true, sortBy = "name", types = "accounts" };
                    srequest.query = String.Format("(|(mail=*{0}*)(cn=*{0}*)(sn=*{0}*)(gn=*{0}*)(displayName=*{0}*)(zimbraMailDeliveryAddress=*{0}*)(zimbraPrefMailForwardingAddress=*{0}*)(zimbraMail=*{0}*)(zimbraMailAlias=*{0}*))", usernameToMatch);

                    Zimbra.Administration.SearchDirectoryResponse sresponse = await zimbraServer.Message(srequest) as Zimbra.Administration.SearchDirectoryResponse;
                    List<Zimbra.Global.accountInfo> accounts = sresponse.Items.ConvertAll<Zimbra.Global.accountInfo>(delegate(object o) { return o as Zimbra.Global.accountInfo; });

                    if (accounts.Count > 0)
                    {
                        Zimbra.Administration.GetAllDistributionListsRequest request = new Zimbra.Administration.GetAllDistributionListsRequest { domain = new Zimbra.Global.domainSelector { by = Zimbra.Global.domainBy.name, Value = domain } };
                        Zimbra.Administration.GetAllDistributionListsResponse response = await zimbraServer.Message(request) as Zimbra.Administration.GetAllDistributionListsResponse;

                        if (response != null)
                        {
                            foreach (Zimbra.Global.DistributionListInfo dl in response.dl)
                            {
                                if (dl.dynamic)
                                {
                                    List<Zimbra.Global.attrN> attributes = dl.a;
                                    string displayName = dl.id;
                                    foreach (Zimbra.Global.attrN attr in attributes)
                                    {
                                        if (attr.name == "displayName" && attr.Value == groupName)
                                        {
                                            dl_id = dl.id;
                                            break;
                                        }
                                    }
                                }
                            }
                        }

                        if (!string.IsNullOrEmpty(dl_id))
                        {
                            Zimbra.Administration.GetDistributionListRequest dlrequest = new Zimbra.Administration.GetDistributionListRequest { dl = new Zimbra.Global.DistributionListSelector { by = Zimbra.Global.DistributionListBy.id, Value = dl_id } };
                            Zimbra.Administration.GetDistributionListResponse dlresponse = await zimbraServer.Message(dlrequest) as Zimbra.Administration.GetDistributionListResponse;

                            if (dlresponse != null)
                            {
                                foreach (string member in dlresponse.dl.dlm)
                                {
                                    Zimbra.Global.accountInfo account = accounts.Find(a => a.name.Equals(member));
                                    if (account != null)
                                    {
                                        users.Add(account.a.Single<Zimbra.Global.attrN>(a => a.name == "displayName").Value);
                                    }
                                }
                            }
                        }
                    }
                }
                return users.ToArray();
            }
            catch (Exception ex)
            {
                string message = String.Format("Role Provider {0}: {1}", this.applicationName, ex.Message);
                LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                return null;
            }

        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            return Task.Run(async () => await FindUsersInRoleAsync(roleName, usernameToMatch)).Result;
        }

        public async Task<string[]> FindUsersInRoleAsync(string roleName, string usernameToMatch)
        {
            if (!Initialized)
            {
                SetConfiguration();
                await InitializeAsync(string.Empty, new NameValueCollection());

                if (!Initialized)
                {
                    string message = String.Format("Membership Role Provider {0}: {1}", this.applicationName, "The Role provider was not initialized.");
                    LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                    throw new ProviderException(message);
                }
            }

            try
            {
                List<string> users = new List<string>();
                string dl_id = null;
                SPContext context = SPContext.Current;
                string domain = null;
                if (context != null)
                {
                    domain = GetZimbraDomain(context.Site.Url);

                    Zimbra.Administration.SearchDirectoryRequest srequest = new Zimbra.Administration.SearchDirectoryRequest { applyConfig = false, applyCos = false, domain = domain, limit = 50, countOnly = false, offset = 0, sortAscending = true, sortBy = "name", types = "accounts" };
                    srequest.query = String.Format("(|(mail=*{0}*)(cn=*{0}*)(sn=*{0}*)(gn=*{0}*)(displayName=*{0}*)(zimbraMailDeliveryAddress=*{0}*)(zimbraPrefMailForwardingAddress=*{0}*)(zimbraMail=*{0}*)(zimbraMailAlias=*{0}*))", usernameToMatch);

                    Zimbra.Administration.SearchDirectoryResponse sresponse = await zimbraServer.Message(srequest) as Zimbra.Administration.SearchDirectoryResponse;
                    List<Zimbra.Global.accountInfo> accounts = sresponse.Items.ConvertAll<Zimbra.Global.accountInfo>(delegate(object o) { return o as Zimbra.Global.accountInfo; });

                    if (accounts.Count > 0)
                    {
                        Zimbra.Administration.GetAllDistributionListsRequest request = new Zimbra.Administration.GetAllDistributionListsRequest { domain = new Zimbra.Global.domainSelector { by = Zimbra.Global.domainBy.name, Value = domain } };
                        Zimbra.Administration.GetAllDistributionListsResponse response = await zimbraServer.Message(request) as Zimbra.Administration.GetAllDistributionListsResponse;

                        if (response != null)
                        {
                            foreach (Zimbra.Global.DistributionListInfo dl in response.dl)
                            {
                                if (dl.dynamic)
                                {
                                    List<Zimbra.Global.attrN> attributes = dl.a;
                                    string displayName = dl.id;
                                    foreach (Zimbra.Global.attrN attr in attributes)
                                    {
                                        if (attr.name == "displayName" && attr.Value == roleName)
                                        {
                                            dl_id = dl.id;
                                            break;
                                        }
                                    }
                                }
                            }
                        }

                        if (!string.IsNullOrEmpty(dl_id))
                        {
                            Zimbra.Administration.GetDistributionListRequest dlrequest = new Zimbra.Administration.GetDistributionListRequest { dl = new Zimbra.Global.DistributionListSelector { by = Zimbra.Global.DistributionListBy.id, Value = dl_id } };
                            Zimbra.Administration.GetDistributionListResponse dlresponse = await zimbraServer.Message(dlrequest) as Zimbra.Administration.GetDistributionListResponse;

                            if (dlresponse != null)
                            {
                                foreach (string member in dlresponse.dl.dlm)
                                {
                                    Zimbra.Global.accountInfo account = accounts.Find(a => a.name.Equals(member));
                                    if (account != null)
                                    {
                                        users.Add(account.a.Single<Zimbra.Global.attrN>(a => a.name == "displayName").Value);
                                    }
                                }
                            }
                        }
                    }
                }
                return users.ToArray();
            }
            catch (Exception ex)
            {
                string message = String.Format("Role Provider {0}: {1}", this.applicationName, ex.Message);
                LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                return null;
            }

        }

        #endregion

        #region Get

        public async Task<string[]> GetAllGroups()
        {
            if (!Initialized)
            {
                SetConfiguration();
                await InitializeAsync(string.Empty, new NameValueCollection());

                if (!Initialized)
                {
                    string message = String.Format("Membership Role Provider {0}: {1}", this.applicationName, "The Role provider was not initialized.");
                    LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                    throw new ProviderException(message);
                }
            }

            try
            {
                List<string> groups = new List<string>();
                SPContext context = SPContext.Current;
                if (context != null)
                {
                    string domain = GetZimbraDomain(context.Site.Url);
                    Zimbra.Administration.GetAllDistributionListsRequest request = new Zimbra.Administration.GetAllDistributionListsRequest { domain = new Zimbra.Global.domainSelector { by = Zimbra.Global.domainBy.name, Value = domain } };
                    Zimbra.Administration.GetAllDistributionListsResponse response = await zimbraServer.Message(request) as Zimbra.Administration.GetAllDistributionListsResponse;

                    if(response != null)
                    {
                        foreach (Zimbra.Global.DistributionListInfo dl in response.dl)
                        {
                            if(dl.dynamic)
                            {
                                List<Zimbra.Global.attrN> attributes = dl.a;
                                string displayName = dl.name;
                                foreach (Zimbra.Global.attrN attr in attributes)
                                {
                                    if (attr.name == "displayName")
                                    {
                                        displayName = attr.Value;
                                        break;
                                    }
                                }
                                groups.Add(displayName);
                            }
                        }
                    }
                }

                return groups.ToArray();
            }
            catch (Exception ex)
            {
                string message = String.Format("Role Provider {0}: {1}", this.applicationName, ex.Message);
                LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                return null;
            }

        }

        public override string[] GetAllRoles()
        {
            return Task.Run(async () => await GetAllRolesAsync()).Result;
        }

        public async Task<string[]> GetAllRolesAsync()
        {
            if (!Initialized)
            {
                SetConfiguration();
                await InitializeAsync(string.Empty, new NameValueCollection());

                if (!Initialized)
                {
                    string message = String.Format("Membership Role Provider {0}: {1}", this.applicationName, "The Role provider was not initialized.");
                    LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                    throw new ProviderException(message);
                }
            }

            try
            {
                List<string> roles = new List<string>();
                SPContext context = SPContext.Current;
                if (context != null)
                {
                    string domain = GetZimbraDomain(context.Site.Url);
                    Zimbra.Administration.GetAllDistributionListsRequest request = new Zimbra.Administration.GetAllDistributionListsRequest { domain = new Zimbra.Global.domainSelector { by = Zimbra.Global.domainBy.name, Value = domain } };
                    Zimbra.Administration.GetAllDistributionListsResponse response = await zimbraServer.Message(request) as Zimbra.Administration.GetAllDistributionListsResponse;

                    if (response != null)
                    {
                        foreach (Zimbra.Global.DistributionListInfo dl in response.dl)
                        {
                            if (!dl.dynamic)
                            {
                                List<Zimbra.Global.attrN> attributes = dl.a;
                                string displayName = dl.name;
                                foreach (Zimbra.Global.attrN attr in attributes)
                                {
                                    if (attr.name == "displayName")
                                    {
                                        displayName = attr.Value;
                                        break;
                                    }
                                }
                                roles.Add(displayName);
                            }
                        }
                    }
                }

                return roles.ToArray();
            }
            catch (Exception ex)
            {
                string message = String.Format("Role Provider {0}: {1}", this.applicationName, ex.Message);
                LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                return null;
            }

        }

        public async Task<string[]> GetGroupsForUser(string username)
        {
            if (!Initialized)
            {
                SetConfiguration();
                await InitializeAsync(string.Empty, new NameValueCollection());

                if (!Initialized)
                {
                    string message = String.Format("Membership Role Provider {0}: {1}", this.applicationName, "The Role provider was not initialized.");
                    LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                    throw new ProviderException(message);
                }
            }

            try
            {
                List<string> userGroups = new List<string>();
                Zimbra.Administration.GetAccountMembershipRequest request = new Zimbra.Administration.GetAccountMembershipRequest { account = new Zimbra.Global.accountSelector { by = Zimbra.Global.accountBy.Name, Value = username } };
                Zimbra.Administration.GetAccountMembershipResponse respons = await zimbraServer.Message(request) as Zimbra.Administration.GetAccountMembershipResponse;

                List<Zimbra.Global.dlInfo> dls = respons.dl;

                foreach (Zimbra.Global.dlInfo dl in dls)
                {
                    if (dl.dynamic)
                    {
                        Zimbra.Administration.GetDistributionListRequest dlrequest = new Zimbra.Administration.GetDistributionListRequest { dl = new Zimbra.Global.DistributionListSelector { by = Zimbra.Global.DistributionListBy.id, Value = dl.id } };
                        Zimbra.Administration.GetDistributionListResponse dlresponse = await zimbraServer.Message(dlrequest) as Zimbra.Administration.GetDistributionListResponse;

                        List<Zimbra.Global.attrN> attributes = dlresponse.dl.a;
                        string displayName = dlresponse.dl.name;
                        foreach (Zimbra.Global.attrN attr in attributes)
                        {
                            if (attr.name == "displayName")
                            {
                                displayName = attr.Value;
                                break;
                            }
                        }
                        userGroups.Add(displayName);
                    }
                }

                return userGroups.ToArray();
            }
            catch (Exception ex)
            {
                string message = String.Format("Role Provider {0}: {1}", this.applicationName, ex.Message);
                LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                return null;
            }
        }

        public override string[] GetRolesForUser(string username)
        {
            return Task.Run(async () => await GetRolesForUserAsync(username)).Result;
        }

        public async Task<string[]> GetRolesForUserAsync(string username)
        {
            if (!Initialized)
            {
                SetConfiguration();
                await InitializeAsync(string.Empty, new NameValueCollection());

                if (!Initialized)
                {
                    string message = String.Format("Membership Role Provider {0}: {1}", this.applicationName, "The Role provider was not initialized.");
                    LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                    throw new ProviderException(message);
                }
            }

            try
            {
                List<string> userRoles = new List<string>();
                userRoles.Add(AllAuthenticatedUsersRoleName);

                Zimbra.Administration.GetAccountMembershipRequest request = new Zimbra.Administration.GetAccountMembershipRequest { account = new Zimbra.Global.accountSelector { by = Zimbra.Global.accountBy.Name, Value = username } };
                Zimbra.Administration.GetAccountMembershipResponse respons = await zimbraServer.Message(request) as Zimbra.Administration.GetAccountMembershipResponse;

                List<Zimbra.Global.dlInfo> dls = respons.dl;

                foreach (Zimbra.Global.dlInfo dl in dls)
                {
                    if (!dl.dynamic)
                    {
                        Zimbra.Administration.GetDistributionListRequest dlrequest = new Zimbra.Administration.GetDistributionListRequest { dl = new Zimbra.Global.DistributionListSelector { by = Zimbra.Global.DistributionListBy.id, Value = dl.id } };
                        Zimbra.Administration.GetDistributionListResponse dlresponse = await zimbraServer.Message(dlrequest) as Zimbra.Administration.GetDistributionListResponse;

                        List<Zimbra.Global.attrN> attributes = dlresponse.dl.a;
                        string displayName = dlresponse.dl.name;
                        displayName = attributes.SingleOrDefault(a => a.name == "displayName").Value;
                        /*
                        foreach (Zimbra.Global.attrN attr in attributes)
                        {
                            if (attr.name == "displayName")
                            {
                                displayName = attr.Value;
                                //break;
                            }
                        }
                        */
                        userRoles.Add(displayName);
                    }
                }

                return userRoles.ToArray();
            }
            catch (Exception ex)
            {
                string message = String.Format("Role Provider {0}: {1}", this.applicationName, ex.Message);
                LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                return null;
            }
        }

        #endregion

        #region In

        public async Task<string[]> GetUsersInGroup(string groupName)
        {
            if (!Initialized)
            {
                SetConfiguration();
                await InitializeAsync(string.Empty, new NameValueCollection());

                if (!Initialized)
                {
                    string message = String.Format("Membership Role Provider {0}: {1}", this.applicationName, "The Role provider was not initialized.");
                    LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                    throw new ProviderException(message);
                }
            }

            try
            {
                List<string> users = new List<string>();
                string dl_id = null;
                SPContext context = SPContext.Current;
                if (context != null)
                {
                    string domain = GetZimbraDomain(context.Site.Url);
                    Zimbra.Administration.GetAllDistributionListsRequest request = new Zimbra.Administration.GetAllDistributionListsRequest { domain = new Zimbra.Global.domainSelector { by = Zimbra.Global.domainBy.name, Value = domain } };
                    Zimbra.Administration.GetAllDistributionListsResponse response = await zimbraServer.Message(request) as Zimbra.Administration.GetAllDistributionListsResponse;

                    if (response != null)
                    {
                        foreach (Zimbra.Global.DistributionListInfo dl in response.dl)
                        {
                            if (dl.dynamic)
                            {
                                List<Zimbra.Global.attrN> attributes = dl.a;
                                string displayName = dl.id;
                                foreach (Zimbra.Global.attrN attr in attributes)
                                {
                                    if (attr.name == "displayName" && attr.Value == groupName)
                                    {
                                        dl_id = dl.id;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }

                if(!string.IsNullOrEmpty(dl_id))
                {
                    Zimbra.Administration.GetDistributionListRequest dlrequest = new Zimbra.Administration.GetDistributionListRequest { dl = new Zimbra.Global.DistributionListSelector { by = Zimbra.Global.DistributionListBy.id, Value = dl_id } };
                    Zimbra.Administration.GetDistributionListResponse dlresponse = await zimbraServer.Message(dlrequest) as Zimbra.Administration.GetDistributionListResponse;

                    if (dlresponse != null)
                    {
                        return dlresponse.dl.dlm.ToArray();
                    }
                }

                return users.ToArray();
            }
            catch (Exception ex)
            {
                string message = String.Format("Role Provider {0}: {1}", this.applicationName, ex.Message);
                LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                return null;
            }

        }

        public override string[] GetUsersInRole(string roleName)
        {
            return Task.Run(async () => await GetUsersInRoleAsync(roleName)).Result;
        }

        public async Task<string[]> GetUsersInRoleAsync(string roleName)
        {
            if (!Initialized)
            {
                SetConfiguration();
                await InitializeAsync(string.Empty, new NameValueCollection());

                if (!Initialized)
                {
                    string message = String.Format("Membership Role Provider {0}: {1}", this.applicationName, "The Role provider was not initialized.");
                    LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                    throw new ProviderException(message);
                }
            }

            try
            {
                List<string> user = new List<string>();
                string dl_id = null;
                SPContext context = SPContext.Current;
                if (context != null)
                {
                    string domain = GetZimbraDomain(context.Site.Url);
                    Zimbra.Administration.GetAllDistributionListsRequest request = new Zimbra.Administration.GetAllDistributionListsRequest { domain = new Zimbra.Global.domainSelector { by = Zimbra.Global.domainBy.name, Value = domain } };
                    Zimbra.Administration.GetAllDistributionListsResponse response = await zimbraServer.Message(request) as Zimbra.Administration.GetAllDistributionListsResponse;

                    if (response != null)
                    {
                        foreach (Zimbra.Global.DistributionListInfo dl in response.dl)
                        {
                            if (!dl.dynamic)
                            {
                                List<Zimbra.Global.attrN> attributes = dl.a;
                                string displayName = dl.id;
                                foreach (Zimbra.Global.attrN attr in attributes)
                                {
                                    if (attr.name == "displayName" && attr.Value == roleName)
                                    {
                                        dl_id = dl.id;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }

                if (!string.IsNullOrEmpty(dl_id))
                {
                    Zimbra.Administration.GetDistributionListRequest dlrequest = new Zimbra.Administration.GetDistributionListRequest { dl = new Zimbra.Global.DistributionListSelector { by = Zimbra.Global.DistributionListBy.id, Value = dl_id } };
                    Zimbra.Administration.GetDistributionListResponse dlresponse = await zimbraServer.Message(dlrequest) as Zimbra.Administration.GetDistributionListResponse;

                    if (dlresponse != null)
                    {
                        return dlresponse.dl.dlm.ToArray();
                    }
                }
                return user.ToArray();
            }
            catch (Exception ex)
            {
                string message = String.Format("Role Provider {0}: {1}", this.applicationName, ex.Message);
                LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                return null;
            }

        }

        public async Task<bool> IsUserInGroup(string username, string groupName)
        {
            if (!Initialized)
            {
                SetConfiguration();
                await InitializeAsync(string.Empty, new NameValueCollection());

                if (!Initialized)
                {
                    string message = String.Format("Membership Role Provider {0}: {1}", this.applicationName, "The Role provider was not initialized.");
                    LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                    throw new ProviderException(message);
                }
            }

            try
            {
                bool inGroup = false;

                SPContext context = SPContext.Current;
                if (context != null)
                {
                    string domain = GetZimbraDomain(context.Site.Url);
                    Zimbra.Administration.GetAllDistributionListsRequest request = new Zimbra.Administration.GetAllDistributionListsRequest { domain = new Zimbra.Global.domainSelector { by = Zimbra.Global.domainBy.name, Value = domain } };
                    Zimbra.Administration.GetAllDistributionListsResponse response = await zimbraServer.Message(request) as Zimbra.Administration.GetAllDistributionListsResponse;

                    if (response != null)
                    {
                        foreach (Zimbra.Global.DistributionListInfo dl in response.dl)
                        {
                            if (dl.dynamic)
                            {
                                List<Zimbra.Global.attrN> attributes = dl.a;
                                string displayName = dl.id;
                                foreach (Zimbra.Global.attrN attr in attributes)
                                {
                                    if (attr.name == "displayName" && attr.Value == groupName)
                                    {
                                        inGroup = dl.dlm.Contains(username);
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }

                return inGroup;
            }
            catch (Exception ex)
            {
                string message = String.Format("Role Provider {0}: {1}", this.applicationName, ex.Message);
                LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                return false;
            }

        }

        public override bool IsUserInRole(string username, string roleName)
        {
            return Task.Run(async () => await IsUserInRoleAsync(username, roleName)).Result;
        }

        public async Task<bool> IsUserInRoleAsync(string username, string roleName)
        {
            if (!Initialized)
            {
                SetConfiguration();
                await InitializeAsync(string.Empty, new NameValueCollection());

                if (!Initialized)
                {
                    string message = String.Format("Membership Role Provider {0}: {1}", this.applicationName, "The Role provider was not initialized.");
                    LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                    throw new ProviderException(message);
                }
            }

            try
            {
                bool inRole = false;

                SPContext context = SPContext.Current;
                if (context != null)
                {
                    string domain = GetZimbraDomain(context.Site.Url);
                    Zimbra.Administration.GetAllDistributionListsRequest request = new Zimbra.Administration.GetAllDistributionListsRequest { domain = new Zimbra.Global.domainSelector { by = Zimbra.Global.domainBy.name, Value = domain } };
                    Zimbra.Administration.GetAllDistributionListsResponse response = await zimbraServer.Message(request) as Zimbra.Administration.GetAllDistributionListsResponse;

                    if (response != null)
                    {
                        foreach (Zimbra.Global.DistributionListInfo dl in response.dl)
                        {
                            if (!dl.dynamic)
                            {
                                List<Zimbra.Global.attrN> attributes = dl.a;
                                string displayName = dl.id;
                                foreach (Zimbra.Global.attrN attr in attributes)
                                {
                                    if (attr.name == "displayName" && attr.Value == roleName)
                                    {
                                        inRole = dl.dlm.Contains(username);
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }

                return inRole;
            }
            catch (Exception ex)
            {
                string message = String.Format("Role Provider {0}: {1}", this.applicationName, ex.Message);
                LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                return false;
            }

        }

        #endregion

        #region Create

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="groupName"></param>
        /// <returns></returns>
        public async Task CreateGroupAsync(string groupName, string groupDisplayName)
        {
            if (!Initialized)
            {
                SetConfiguration();
                await InitializeAsync(string.Empty, new NameValueCollection());

                if (!Initialized)
                {
                    string message = String.Format("Membership Role Provider {0}: {1}", this.applicationName, "The Role provider was not initialized.");
                    LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                    throw new ProviderException(message);
                }
            }

            try
            {
                /*
                <name xmlns="">ac@clubcloud.nl</name>
                <a xmlns="" n="zimbraIsACLGroup">TRUE</a>
                <a xmlns="" n="zimbraMailStatus">enabled</a>
                <a xmlns="" n="displayName">Activiteiten Commissie</a>
                <a xmlns="" n="zimbraHideInGal">TRUE</a>
                <a xmlns="" n="zimbraDistributionListSubscriptionPolicy">ACCEPT</a>
                <a xmlns="" n="zimbraDistributionListUnsubscriptionPolicy">ACCEPT</a>
                <a xmlns="" n="zimbraPrefReplyToEnabled">TRUE</a>
                <a xmlns="" n="zimbraPrefReplyToDisplay">Activiteiten Commissie</a>
                <a xmlns="" n="zimbraPrefReplyToAddress">ac@clubcloud.nl</a>
                */

                SPContext context = SPContext.Current;
                string domain = GetZimbraDomain(context.Site.Url);
                string email = groupName+"@"+domain;

                List<Zimbra.Global.attrN> attributes = new List<Zimbra.Global.attrN>(){
                    new Zimbra.Global.attrN{ name = "zimbraIsACLGroup" , Value = "TRUE"},
                    new Zimbra.Global.attrN{ name = "zimbraMailStatus" , Value = "enabled"},
                    new Zimbra.Global.attrN{ name = "displayName" , Value = groupDisplayName},
                    new Zimbra.Global.attrN{ name = "zimbraHideInGal" , Value = "TRUE"},
                    new Zimbra.Global.attrN{ name = "zimbraDistributionListSubscriptionPolicy" , Value = "ACCEPT"},
                    new Zimbra.Global.attrN{ name = "zimbraDistributionListUnsubscriptionPolicy" , Value = "ACCEPT"},
                    new Zimbra.Global.attrN{ name = "zimbraPrefReplyToEnabled" , Value = "TRUE"},
                    new Zimbra.Global.attrN{ name = "zimbraPrefReplyToDisplay" , Value = groupDisplayName},
                    new Zimbra.Global.attrN{ name = "zimbraPrefReplyToAddress" , Value = groupName}
                };
                
                Zimbra.Administration.CreateDistributionListRequest dlrequest = new Zimbra.Administration.CreateDistributionListRequest { dynamic = true, name = email, a = attributes };
                Zimbra.Administration.CreateDistributionListResponse dlresponse = await zimbraServer.Message(dlrequest) as Zimbra.Administration.CreateDistributionListResponse;

                Zimbra.Account.DistributionListActionRequest acrequest = new Zimbra.Account.DistributionListActionRequest
                {
                    dl = new DistributionListSelector { by = DistributionListBy.id, Value = dlresponse.dl.id },
                    action = new Zimbra.Global.DistributionListAction
                    {
                        op = Operation.addOwners,
                        owner = new List<DistributionListGranteeSelector>{ 
                            new DistributionListGranteeSelector{ by = DistributionListGranteeBy.name, type = GranteeType.usr, Value = context.Web.CurrentUser.Email }}
                    }
                };

                Zimbra.Account.DistributionListActionResponse acresponse = await zimbraServer.Message(acrequest) as Zimbra.Account.DistributionListActionResponse;
                
            }
            catch (Exception ex)
            {
                string message = String.Format("Role Provider {0}: {1}", this.applicationName, ex.Message);
                LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
            }
            /*
            Zimbra.Administration.GetAccountInfoRequest request = new Zimbra.Administration.GetAccountInfoRequest { account = new Zimbra.Global.accountSelector { by = Zimbra.Global.accountBy.Name, Value = username } };
            Zimbra.Administration.GetAccountInfoResponse response = zimbraServer.Message(request) as Zimbra.Administration.GetAccountInfoResponse;
            if (response != null)
            {

            }
            */
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="roleName"></param>
        public override void CreateRole(string roleName)
        {
            Task.Run(async () => await CreateRoleAsync(roleName));
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="roleName"></param>
        /// <returns></returns>
        public async Task CreateRoleAsync(string roleName)
        {
            if (!Initialized)
            {
                SetConfiguration();
                await InitializeAsync(string.Empty, new NameValueCollection());

                if (!Initialized)
                {
                    string message = String.Format("Membership Role Provider {0}: {1}", this.applicationName, "The Role provider was not initialized.");
                    LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                    throw new ProviderException(message);
                }
            }

            try
            {
            }
            catch (Exception ex)
            {
                string message = String.Format("Role Provider {0}: {1}", this.applicationName, ex.Message);
                LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
            }
        }

        #endregion

        #region Delete

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="groupName"></param>
        /// <param name="throwOnPopulatedGroup"></param>
        /// <returns></returns>
        public async Task<bool> DeleteGroupAsync(string groupName, bool throwOnPopulatedGroup)
        {
            if (!Initialized)
            {
                SetConfiguration();
                await InitializeAsync(string.Empty, new NameValueCollection());

                if (!Initialized)
                {
                    string message = String.Format("Membership Role Provider {0}: {1}", this.applicationName, "The Role provider was not initialized.");
                    LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                    throw new ProviderException(message);
                }
            }

            try
            {
                return true;
            }
            catch (Exception ex)
            {
                string message = String.Format("Role Provider {0}: {1}", this.applicationName, ex.Message);
                LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                return false;
            }

        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="roleName"></param>
        /// <param name="throwOnPopulatedRole"></param>
        /// <returns></returns>
        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            return Task.Run(async () => await DeleteRoleAsync(roleName, throwOnPopulatedRole)).Result;
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="roleName"></param>
        /// <param name="throwOnPopulatedRole"></param>
        /// <returns></returns>
        public async Task<bool> DeleteRoleAsync(string roleName, bool throwOnPopulatedRole)
        {
            if (!Initialized)
            {
                SetConfiguration();
                await InitializeAsync(string.Empty, new NameValueCollection());

                if (!Initialized)
                {
                    string message = String.Format("Membership Role Provider {0}: {1}", this.applicationName, "The Role provider was not initialized.");
                    LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                    throw new ProviderException(message);
                }
            }

            try
            {
                return true;
            }
            catch (Exception ex)
            {
                string message = String.Format("Role Provider {0}: {1}", this.applicationName, ex.Message);
                LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                return false;
            }

        }

        #endregion

        #region Remove

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="usernames"></param>
        /// <param name="groupNames"></param>
        public async Task RemoveUsersFromGroupsAsync(string[] usernames, string[] groupNames)
        {
            if (!Initialized)
            {
                SetConfiguration();
                await InitializeAsync(string.Empty, new NameValueCollection());

                if (!Initialized)
                {
                    string message = String.Format("Membership Role Provider {0}: {1}", this.applicationName, "The Role provider was not initialized.");
                    LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                    throw new ProviderException(message);
                }
            }

            try
            {
                List<DistributionListInfo> dls = new List<DistributionListInfo>();
                List<Zimbra.Global.accountInfo> accounts = new List<accountInfo>();

                SPContext context = SPContext.Current;
                if (context != null)
                {
                    string domain = GetZimbraDomain(context.Site.Url);
                    Zimbra.Administration.GetAllDistributionListsRequest request = new Zimbra.Administration.GetAllDistributionListsRequest { domain = new Zimbra.Global.domainSelector { by = Zimbra.Global.domainBy.name, Value = domain } };
                    Zimbra.Administration.GetAllDistributionListsResponse response = await zimbraServer.Message(request) as Zimbra.Administration.GetAllDistributionListsResponse;

                    if (response != null)
                    {
                        foreach (Zimbra.Global.DistributionListInfo dl in response.dl)
                        {
                            if (!dl.dynamic)
                            {
                                List<Zimbra.Global.attrN> attributes = dl.a;
                                string displayName = dl.id;
                                foreach (Zimbra.Global.attrN attr in attributes)
                                {
                                    if (attr.name == "displayName" && groupNames.Contains(attr.Value))
                                    {
                                        dls.Add(dl);
                                    }
                                }
                            }
                        }
                    }

                    foreach (string username in usernames)
                    {
                        Zimbra.Administration.SearchDirectoryRequest srequest = new Zimbra.Administration.SearchDirectoryRequest { applyConfig = false, applyCos = false, domain = domain, limit = 50, countOnly = false, offset = 0, sortAscending = true, sortBy = "name", types = "accounts" };
                        srequest.query = String.Format("(|(mail=*{0}*)(cn=*{0}*)(sn=*{0}*)(gn=*{0}*)(displayName=*{0}*)(zimbraMailDeliveryAddress=*{0}*)(zimbraPrefMailForwardingAddress=*{0}*)(zimbraMail=*{0}*)(zimbraMailAlias=*{0}*))", username);

                        Zimbra.Administration.SearchDirectoryResponse sresponse = await zimbraServer.Message(srequest) as Zimbra.Administration.SearchDirectoryResponse;
                        accounts.AddRange(sresponse.Items.ConvertAll<Zimbra.Global.accountInfo>(delegate(object o) { return o as Zimbra.Global.accountInfo; }));
                    }
                }

                if (dls.Count > 0 && accounts.Count > 0)
                {
                    List<string> dlm = new List<string>();
                    foreach (accountInfo account in accounts)
                    {
                        dlm.Add(account.name);
                    }

                    foreach (DistributionListInfo dl in dls)
                    {
                        Zimbra.Administration.RemoveDistributionListMemberRequest dlrequest = new Zimbra.Administration.RemoveDistributionListMemberRequest { id = dl.id, dlm = dlm };
                        Zimbra.Administration.RemoveDistributionListMemberResponse dlresponse = await zimbraServer.Message(dlrequest) as Zimbra.Administration.RemoveDistributionListMemberResponse;
                    }
                }

            }
            catch (Exception ex)
            {
                string message = String.Format("Role Provider {0}: {1}", this.applicationName, ex.Message);
                LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
            }

        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="usernames"></param>
        /// <param name="roleNames"></param>
        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            Task.Run(async () => await RemoveUsersFromRolesAsync(usernames, roleNames));
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="usernames"></param>
        /// <param name="roleNames"></param>
        /// <returns></returns>
        public async Task RemoveUsersFromRolesAsync(string[] usernames, string[] roleNames)
        {
            if (!Initialized)
            {
                SetConfiguration();
                await InitializeAsync(string.Empty, new NameValueCollection());

                if (!Initialized)
                {
                    string message = String.Format("Membership Role Provider {0}: {1}", this.applicationName, "The Role provider was not initialized.");
                    LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                    throw new ProviderException(message);
                }
            }

            try
            {
                List<DistributionListInfo> dls = new List<DistributionListInfo>();
                List<Zimbra.Global.accountInfo> accounts = new List<accountInfo>();

                SPContext context = SPContext.Current;
                if (context != null)
                {
                    string domain = GetZimbraDomain(context.Site.Url);
                    Zimbra.Administration.GetAllDistributionListsRequest request = new Zimbra.Administration.GetAllDistributionListsRequest { domain = new Zimbra.Global.domainSelector { by = Zimbra.Global.domainBy.name, Value = domain } };
                    Zimbra.Administration.GetAllDistributionListsResponse response = await zimbraServer.Message(request) as Zimbra.Administration.GetAllDistributionListsResponse;

                    if (response != null)
                    {
                        foreach (Zimbra.Global.DistributionListInfo dl in response.dl)
                        {
                            if (!dl.dynamic)
                            {
                                List<Zimbra.Global.attrN> attributes = dl.a;
                                string displayName = dl.id;
                                foreach (Zimbra.Global.attrN attr in attributes)
                                {
                                    if (attr.name == "displayName" && roleNames.Contains(attr.Value))
                                    {
                                        dls.Add(dl);
                                    }
                                }
                            }
                        }
                    }

                    foreach (string username in usernames)
                    {
                        Zimbra.Administration.SearchDirectoryRequest srequest = new Zimbra.Administration.SearchDirectoryRequest { applyConfig = false, applyCos = false, domain = domain, limit = 50, countOnly = false, offset = 0, sortAscending = true, sortBy = "name", types = "accounts" };
                        srequest.query = String.Format("(|(mail=*{0}*)(cn=*{0}*)(sn=*{0}*)(gn=*{0}*)(displayName=*{0}*)(zimbraMailDeliveryAddress=*{0}*)(zimbraPrefMailForwardingAddress=*{0}*)(zimbraMail=*{0}*)(zimbraMailAlias=*{0}*))", username);

                        Zimbra.Administration.SearchDirectoryResponse sresponse = await zimbraServer.Message(srequest) as Zimbra.Administration.SearchDirectoryResponse;
                        accounts.AddRange(sresponse.Items.ConvertAll<Zimbra.Global.accountInfo>(delegate(object o) { return o as Zimbra.Global.accountInfo; }));
                    }
                }

                if (dls.Count > 0 && accounts.Count > 0)
                {
                    List<string> dlm = new List<string>();
                    foreach (accountInfo account in accounts)
                    {
                        dlm.Add(account.name);
                    }

                    foreach (DistributionListInfo dl in dls)
                    {
                        Zimbra.Administration.RemoveDistributionListMemberRequest dlrequest = new Zimbra.Administration.RemoveDistributionListMemberRequest { id = dl.id, dlm = dlm };
                        Zimbra.Administration.RemoveDistributionListMemberResponse dlresponse = await zimbraServer.Message(dlrequest) as Zimbra.Administration.RemoveDistributionListMemberResponse;
                    }
                }

            }
            catch (Exception ex)
            {
                string message = String.Format("Role Provider {0}: {1}", this.applicationName, ex.Message);
                LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
            }

        }

        #endregion

        #region Add

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            Task.Run(async () => await AddUsersToRolesAsync(usernames, roleNames));
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="usernames"></param>
        /// <param name="roleNames"></param>
        /// <returns></returns>
        public async Task AddUsersToRolesAsync(string[] usernames, string[] roleNames)
        {
            if (!Initialized)
            {
                SetConfiguration();
                await InitializeAsync(string.Empty, new NameValueCollection());

                if (!Initialized)
                {
                    string message = String.Format("Membership Role Provider {0}: {1}", this.applicationName, "The Role provider was not initialized.");
                    LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                    throw new ProviderException(message);
                }
            }

            try
            {
                List<DistributionListInfo> dls = new List<DistributionListInfo>();
                List<Zimbra.Global.accountInfo> accounts = new List<accountInfo>();

                SPContext context = SPContext.Current;
                if (context != null)
                {
                    string domain = GetZimbraDomain(context.Site.Url);
                    Zimbra.Administration.GetAllDistributionListsRequest request = new Zimbra.Administration.GetAllDistributionListsRequest { domain = new Zimbra.Global.domainSelector { by = Zimbra.Global.domainBy.name, Value = domain } };
                    Zimbra.Administration.GetAllDistributionListsResponse response = await zimbraServer.Message(request) as Zimbra.Administration.GetAllDistributionListsResponse;

                    if (response != null)
                    {
                        foreach (Zimbra.Global.DistributionListInfo dl in response.dl)
                        {
                            if (!dl.dynamic)
                            {
                                List<Zimbra.Global.attrN> attributes = dl.a;
                                string displayName = dl.id;
                                foreach (Zimbra.Global.attrN attr in attributes)
                                {
                                    if (attr.name == "displayName" && roleNames.Contains(attr.Value))
                                    {
                                        dls.Add(dl);
                                    }
                                }
                            }
                        }
                    }

                    foreach (string username in usernames)
                    {
                        Zimbra.Administration.SearchDirectoryRequest srequest = new Zimbra.Administration.SearchDirectoryRequest { applyConfig = false, applyCos = false, domain = domain, limit = 50, countOnly = false, offset = 0, sortAscending = true, sortBy = "name", types = "accounts" };
                        srequest.query = String.Format("(|(mail=*{0}*)(cn=*{0}*)(sn=*{0}*)(gn=*{0}*)(displayName=*{0}*)(zimbraMailDeliveryAddress=*{0}*)(zimbraPrefMailForwardingAddress=*{0}*)(zimbraMail=*{0}*)(zimbraMailAlias=*{0}*))", username);

                        Zimbra.Administration.SearchDirectoryResponse sresponse = await zimbraServer.Message(srequest) as Zimbra.Administration.SearchDirectoryResponse;
                        accounts.AddRange(sresponse.Items.ConvertAll<Zimbra.Global.accountInfo>(delegate(object o) { return o as Zimbra.Global.accountInfo; }));
                    }
                }

                if (dls.Count > 0 && accounts.Count > 0)
                {
                    List<string> dlm = new List<string>();
                    foreach (accountInfo account in accounts)
                    {
                        dlm.Add(account.name);
                    }

                    foreach (DistributionListInfo dl in dls)
                    {
                        Zimbra.Administration.AddDistributionListMemberRequest dlrequest = new Zimbra.Administration.AddDistributionListMemberRequest { id = dl.id, dlm = dlm };
                        Zimbra.Administration.AddDistributionListMemberResponse dlresponse = await zimbraServer.Message(dlrequest) as Zimbra.Administration.AddDistributionListMemberResponse;
                    }
                }

            }
            catch (Exception ex)
            {
                string message = String.Format("Role Provider {0}: {1}", this.applicationName, ex.Message);
                LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
            }

        }

        public async Task AddUsersToGroupsAsync(string[] usernames, string[] groupNames)
        {
            if (!Initialized)
            {
                SetConfiguration();
                await InitializeAsync(string.Empty, new NameValueCollection());

                if (!Initialized)
                {
                    string message = String.Format("Membership Role Provider {0}: {1}", this.applicationName, "The Role provider was not initialized.");
                    LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                    throw new ProviderException(message);
                }
            }

            try
            {
                List<DistributionListInfo> dls = new List<DistributionListInfo>();
                List<Zimbra.Global.accountInfo> accounts = new List<accountInfo>();

                SPContext context = SPContext.Current;
                if (context != null)
                {
                    string domain = GetZimbraDomain(context.Site.Url);
                    Zimbra.Administration.GetAllDistributionListsRequest request = new Zimbra.Administration.GetAllDistributionListsRequest { domain = new Zimbra.Global.domainSelector { by = Zimbra.Global.domainBy.name, Value = domain } };
                    Zimbra.Administration.GetAllDistributionListsResponse response = await zimbraServer.Message(request) as Zimbra.Administration.GetAllDistributionListsResponse;

                    if (response != null)
                    {
                        foreach (Zimbra.Global.DistributionListInfo dl in response.dl)
                        {
                            if (!dl.dynamic)
                            {
                                List<Zimbra.Global.attrN> attributes = dl.a;
                                string displayName = dl.id;
                                foreach (Zimbra.Global.attrN attr in attributes)
                                {
                                    if (attr.name == "displayName" && groupNames.Contains(attr.Value))
                                    {
                                        dls.Add(dl);
                                    }
                                }
                            }
                        }
                    }

                    foreach (string username in usernames)
                    {
                        Zimbra.Administration.SearchDirectoryRequest srequest = new Zimbra.Administration.SearchDirectoryRequest { applyConfig = false, applyCos = false, domain = domain, limit = 50, countOnly = false, offset = 0, sortAscending = true, sortBy = "name", types = "accounts" };
                        srequest.query = String.Format("(|(mail=*{0}*)(cn=*{0}*)(sn=*{0}*)(gn=*{0}*)(displayName=*{0}*)(zimbraMailDeliveryAddress=*{0}*)(zimbraPrefMailForwardingAddress=*{0}*)(zimbraMail=*{0}*)(zimbraMailAlias=*{0}*))", username);

                        Zimbra.Administration.SearchDirectoryResponse sresponse = await zimbraServer.Message(srequest) as Zimbra.Administration.SearchDirectoryResponse;
                        accounts.AddRange(sresponse.Items.ConvertAll<Zimbra.Global.accountInfo>(delegate(object o) { return o as Zimbra.Global.accountInfo; }));                        
                    }

                }

                if (dls.Count > 0 && accounts.Count > 0)
                {
                    List<string> dlm = new List<string>();
                    foreach (accountInfo account in accounts)
                    {
                        dlm.Add(account.name);
                    }

                    foreach (DistributionListInfo dl in dls)
                    {
                        Zimbra.Administration.AddDistributionListMemberRequest dlrequest = new Zimbra.Administration.AddDistributionListMemberRequest { id = dl.id, dlm = dlm };
                        Zimbra.Administration.AddDistributionListMemberResponse dlresponse = await zimbraServer.Message(dlrequest) as Zimbra.Administration.AddDistributionListMemberResponse;
                    }
                }

            }
            catch (Exception ex)
            {
                string message = String.Format("Role Provider {0}: {1}", this.applicationName, ex.Message);
                LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
            }

        }

        #endregion

        #region Exists

        /// <summary>
        /// 
        /// </summary>
        /// <param name="groupName"></param>
        /// <returns></returns>
        public async Task<bool> GroupExistsAsync(string groupName)
        {
            if (!Initialized)
            {
                SetConfiguration();
                await InitializeAsync(string.Empty, new NameValueCollection());

                if (!Initialized)
                {
                    string message = String.Format("Membership Role Provider {0}: {1}", this.applicationName, "The Role provider was not initialized.");
                    LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                    throw new ProviderException(message);
                }
            }

            try
            {
                bool groupExists = false;

                SPContext context = SPContext.Current;
                if (context != null)
                {
                    string domain = GetZimbraDomain(context.Site.Url);
                    Zimbra.Administration.GetAllDistributionListsRequest request = new Zimbra.Administration.GetAllDistributionListsRequest { domain = new Zimbra.Global.domainSelector { by = Zimbra.Global.domainBy.name, Value = domain } };
                    Zimbra.Administration.GetAllDistributionListsResponse response = await zimbraServer.Message(request) as Zimbra.Administration.GetAllDistributionListsResponse;

                    if (response != null)
                    {
                        foreach (Zimbra.Global.DistributionListInfo dl in response.dl)
                        {
                            if (dl.dynamic)
                            {
                                List<Zimbra.Global.attrN> attributes = dl.a;
                                string displayName = dl.id;
                                foreach (Zimbra.Global.attrN attr in attributes)
                                {
                                    if (attr.name == "displayName" && attr.Value == groupName)
                                    {
                                        groupExists = true;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }

                return groupExists;
            }
            catch (Exception ex)
            {
                string message = String.Format("Role Provider {0}: {1}", this.applicationName, ex.Message);
                LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                return false;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="roleName"></param>
        /// <returns></returns>
        public override bool RoleExists(string roleName)
        {
            return Task.Run(async () => await RoleExistsAsync(roleName)).Result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="roleName"></param>
        /// <returns></returns>
        public async Task<bool> RoleExistsAsync(string roleName)
        {
            if (!Initialized)
            {
                SetConfiguration();
                await InitializeAsync(string.Empty, new NameValueCollection());

                if (!Initialized)
                {
                    string message = String.Format("Membership Role Provider {0}: {1}", this.applicationName, "The Role provider was not initialized.");
                    LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                    throw new ProviderException(message);
                }
            }

            try
            {
                bool roleExists = false;

                SPContext context = SPContext.Current;
                if (context != null)
                {
                    string domain = GetZimbraDomain(context.Site.Url);
                    Zimbra.Administration.GetAllDistributionListsRequest request = new Zimbra.Administration.GetAllDistributionListsRequest { domain = new Zimbra.Global.domainSelector { by = Zimbra.Global.domainBy.name, Value = domain } };
                    Zimbra.Administration.GetAllDistributionListsResponse response = await zimbraServer.Message(request) as Zimbra.Administration.GetAllDistributionListsResponse;

                    if (response != null)
                    {
                        foreach (Zimbra.Global.DistributionListInfo dl in response.dl)
                        {
                            if (dl.dynamic)
                            {
                                List<Zimbra.Global.attrN> attributes = dl.a;
                                string displayName = dl.id;
                                foreach (Zimbra.Global.attrN attr in attributes)
                                {
                                    if (attr.name == "displayName" && attr.Value == roleName)
                                    {
                                        roleExists = true;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }

                return roleExists;
            }
            catch (Exception ex)
            {
                string message = String.Format("Role Provider {0}: {1}", this.applicationName, ex.Message);
                LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                return false;
            }

        }

        #endregion

        #region helpers

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static string GetZimbraDomain(string url)
        {
            StringBuilder returnUrl = new StringBuilder();

            Uri uri = new Uri(url);
            if (uri.HostNameType == UriHostNameType.Dns)
            {
                string[] parts = uri.DnsSafeHost.Split(new char[] { '.' });
                if (parts.Length > 1)
                {
                    if (parts.Length == 2)
                    {
                        returnUrl.Append(parts[0] + "." + parts[1]);
                    }

                    if (parts.Length == 3)
                    {
                        if ((parts[1].ToLower() == "clubcloud") && ((parts[0].ToLower() != "www") && (parts[0].ToLower() != "mijn") && (parts[0].ToLower() != "afhangen") && (parts[0].ToLower() != "websites") && (parts[0].ToLower() != "development")))
                        {
                            returnUrl.Append(parts[0] + "." + parts[2]);
                        }
                        else
                        {
                            returnUrl.Append(parts[1] + "." + parts[2]);
                        }
                    }
                }
                else
                {
                    return "clubcloud.nl";
                }
            }
            return returnUrl.ToString();
        }

        #endregion

        #region ULS

        public static void LogToULS(string message, TraceSeverity traceSeverity, EventSeverity eventSeverity)
        {
            try
            {
                SPDiagnosticsCategory category = new SPDiagnosticsCategory("Zimbra Role Provider", traceSeverity, eventSeverity);
                SPDiagnosticsService ds = SPDiagnosticsService.Local;
                ds.WriteTrace(0, category, traceSeverity, message);
            }
            catch
            {
            }
        }

        #endregion
    }
}