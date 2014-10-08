using ClubCloud.Zimbra.Account;
using ClubCloud.Zimbra.Administration;
using ClubCloud.Zimbra.Global;
using ClubCloud.Zimbra.Service;
using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Net;
using System.Reflection;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra
{
    public class ZimbraServer : System.ComponentModel.INotifyPropertyChanged, IDisposable
    {
        private static ZimbraBinding binding = new ZimbraBinding();
        private static ZimbraEndpointAddress remoteAddress { get; set; }
        internal static ZimbraEndpointAddress remoteAddressAdmin { get; set; }
        internal static ZimbraConfigurationSection configuration = null;
        private static string _serverNameClient;
        private static string _serverNameAdmin;

        private static System.Nullable<bool> _authenticated;
        private static System.Nullable<bool> _authenticatedAdmin;
        private static System.Nullable<long> _authenticatedLifetime;
        private static System.Nullable<long> _authenticatedAdminLifetime;

        public ZimbraServer()
        {
            try
            {
                configuration = (ZimbraConfigurationSection)ConfigurationManager.GetSection("Zimbra/Configuration");
            }
            catch { };

            if (configuration == null)
            {
                configuration = new ZimbraConfigurationSection();
            }
            Connect();

        }

        public static string ServerNameClient
        {
            get { return ZimbraServer._serverNameClient; }
            set { ZimbraServer._serverNameClient = value; }
        }

        public static string ServerNameAdmin 
        {
            get { return ZimbraServer._serverNameAdmin; }
            set { ZimbraServer._serverNameAdmin = value; }

        }

        public System.Nullable<bool> Authenticated
        {
            get
            {
                if (_authenticated.HasValue)
                {
                    return _authenticated.Value;
                }
                else
                {
                    return default(bool);
                }
            }
            set
            {
                if ((_authenticated.Equals(value) != true))
                {
                    _authenticated = value;
                    OnPropertyChanged("Authenticated");
                }
            }
        }

        public System.Nullable<bool> AuthenticatedAdmin
        {
            get
            {
                if (_authenticatedAdmin.HasValue)
                {
                    return _authenticatedAdmin.Value;
                }
                else
                {
                    return default(bool);
                }
            }
            set
            {
                if ((_authenticatedAdmin.Equals(value) != true))
                {
                    _authenticatedAdmin = value;
                    OnPropertyChanged("AuthenticatedAdmin");
                }
            }
        }

        public System.Nullable<long> AuthenticatedLifetime
        {
            get
            {
                if (_authenticatedLifetime.HasValue)
                {
                    return _authenticatedLifetime.Value;
                }
                else
                {
                    return DateTime.Now.Ticks;
                }
            }
            set
            {
                    _authenticatedLifetime = DateTime.Now.Ticks + value;
                    OnPropertyChanged("AuthenticatedLifetime");
            }
        }

        public System.Nullable<long> AuthenticatedAdminLifetime
        {
            get
            {
                if (_authenticatedAdminLifetime.HasValue)
                {
                    return _authenticatedAdminLifetime.Value;
                }
                else
                {
                    return DateTime.Now.Ticks;
                }
            }
            set
            {
                _authenticatedAdminLifetime = DateTime.Now.Ticks + value;
                OnPropertyChanged("AuthenticatedAdminLifetime");
            }
        }

        public bool AuthenticationExpired
        {
            get
            {
                //return ((AuthenticatedLifetime - DateTime.Now.Ticks) < TimeSpan.TicksPerMinute);
                return ((AuthenticatedLifetime < DateTime.Now.Ticks) == true);
            }
        }

        public bool AuthenticationAdminExpired
        {
            get
            {
                //return ((AuthenticatedAdminLifetime - DateTime.Now.Ticks) < TimeSpan.TicksPerMinute);
                return ((AuthenticatedAdminLifetime < DateTime.Now.Ticks) == true);
            }
        }

        public ZimbraServer(string ServerName)
        {
            try
            {
                configuration = (ZimbraConfigurationSection)ConfigurationManager.GetSection("Zimbra/Configuration");
            }
            catch { };

            if (configuration == null)
            {
                configuration = new ZimbraConfigurationSection();
            }
            if (!string.IsNullOrEmpty(ServerName))
            {
                configuration.Server.ServerName = ServerName;
            }
            if (!string.IsNullOrEmpty(configuration.Server.ServerName))
            {
                Connect();
            }
        }



        public ZimbraServer(string UserName, string Password, string ServerName, bool IsAdmin = false)
        {
            try
            {
                configuration = (ZimbraConfigurationSection)ConfigurationManager.GetSection("Zimbra/Configuration");
            }
            catch { };

            if (configuration == null)
            {
                configuration = new ZimbraConfigurationSection();
            }

            configuration.Server.ServerName = ServerName;
            configuration.Server.UserName = UserName;
            configuration.Server.Password = Password;
            configuration.Server.IsAdmin = IsAdmin;
            Connect();

            Authenticate();

        }
        public string Authenticate() 
        {
            return Authenticate(configuration.Server.UserName, configuration.Server.Password, configuration.Server.IsAdmin);
        }

        public string Authenticate(string UserName, string Password, bool IsAdmin = false)
        {
            configuration.Server.UserName = UserName;
            configuration.Server.Password = Password;
            configuration.Server.IsAdmin = IsAdmin;

            string AuthToken = string.Empty;

            if (IsAdmin)
            {
                //ZimbraEndpointAddress.ZimbraHeaderContext = new ZimbraHeaderContext();

                Zimbra.Administration.AuthResponse response;
                if (administration == null)
                {
                    administration = new ZimbraAdminSoapClient(binding, remoteAddressAdmin);
                }
                Zimbra.Administration.AuthRequest request = new Administration.AuthRequest { account = new Global.accountSelector { by = Global.accountBy.AdministratorName, Value = UserName }, password = Password };
                response = administration.AccountAuth(request);
                if (!string.IsNullOrEmpty(response.authToken))
                {
                    ZimbraEndpointAddress.ZimbraHeaderContext.authToken = response.authToken;
                    ZimbraEndpointAddress.ZimbraHeaderContext.AuthTokenControl = new authTokenControl { voidOnExpired = true };
                    ZimbraEndpointAddress.ZimbraHeaderContext.account = request.account.Value;
                    //ZimbraEndpointAddress.ZimbraHeaderContext.account.by = accountBy.name;

                    AuthenticatedAdminLifetime = response.lifetime;
                    AuthenticatedAdmin = true;
                    AuthToken = response.authToken;
                }
            }
            else
            {
                //ZimbraEndpointAddress.ZimbraHeaderContext = new ZimbraHeaderContext();

                Zimbra.Account.AuthResponse response;
                if (account == null)
                {
                    account = new ZimbraAccountSoapClient(binding, remoteAddress);
                }
                Zimbra.Account.AuthRequest request = new Account.AuthRequest { account = new Global.accountSelector { by = Global.accountBy.Name, Value = UserName }, password = Password };
                response = account.AccountAuth(request);
                if (!string.IsNullOrEmpty(response.authToken))
                {
                    AuthenticatedLifetime = response.lifetime;
                    Authenticated = true;
                    AuthToken = response.authToken;
                }

                //ZimbraEndpointAddress.ZimbraHeaderContext.authToken = response.authToken;
                //ZimbraEndpointAddress.ZimbraHeaderContext.AuthTokenControl = new authTokenControl { voidOnExpired = true };
                //ZimbraEndpointAddress.ZimbraHeaderContext.account = request.account.Value;

            }

            //GetVersioInfo(asAdmin);
            return AuthToken;
        }

        public void TriggerWebSite()
        {
            try
            {
                string URLAuth = "https://" + configuration.Server.ServerName + ":7071/zimbraAdmin/";
                WebClient webClient = new WebClient();

                NameValueCollection formData = new NameValueCollection();
                formData["ZLoginUserName"] = configuration.Server.UserName;
                formData["ZLoginPassword"] = configuration.Server.Password;

                byte[] responseBytes = webClient.UploadValues(URLAuth, "POST", formData);
                string resultAuthTicket = Encoding.UTF8.GetString(responseBytes);
                webClient.Dispose();
            }
            catch { }
        }

        private void GetVersionInfo(bool asAdmin = false)
        {
            if (asAdmin)
            {
                Zimbra.Administration.GetVersionInfoResponse Adminresponse;
                if (administration == null)
                {
                    administration = new ZimbraAdminSoapClient(binding, remoteAddressAdmin);
                }
                Zimbra.Administration.GetVersionInfoRequest Adminrequest = new Administration.GetVersionInfoRequest { };
                Adminresponse = administration.GetVersionInfoRequest(Adminrequest);
                if (Adminresponse.info != null)
                {
                    string BuildDate = Adminresponse.info.buildDate;
                }
            }

            try
            {
                Zimbra.Account.GetVersionInfoResponse response;
                if (account == null)
                {
                    account = new ZimbraAccountSoapClient(binding, remoteAddress);
                }
                Zimbra.Account.GetVersionInfoRequest request = new Account.GetVersionInfoRequest { };
                response = account.GetVersionInfoRequest(request);
                if (response.info != null)
                {
                    string BuildDate = response.info.buildDate;
                }
            }
            catch (FaultException fex)
            {
                Console.Write(fex.Message);
                //throw fex;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                //throw ex;
            }
        }

        public async Task<ZimbraMessage> Message(ZimbraMessage zimbraMessage)
        {
            ZimbraMessage message = null;
            bool reauthenticate = false;

            try
            {
                if (!Authenticated.Value && !AuthenticatedAdmin.Value)
                {
                    Authenticate();
                }
                /*
                if (AuthenticationExpired && Authenticated.Value)
                {
                    Authenticate();
                }

                if (AuthenticationAdminExpired && AuthenticatedAdmin.Value)
                {
                    Authenticate();
                }
                */

                string ns = zimbraMessage.GetType().Namespace;

                switch (ns)
                {
                    case "ClubCloud.Zimbra.Account":
                        message = await ProcessAccountMessage(zimbraMessage);
                        break;
                    case "ClubCloud.Zimbra.Administration":
                        message = await ProcessAdministrationMessage(zimbraMessage);
                        break;
                    case "ClubCloud.Zimbra.Administration.Extended":
                        message = await ProcessAdministrationExtendedMessage(zimbraMessage);
                        break;
                    case "ClubCloud.Zimbra.Mail":
                        message = await ProcessMailMessage(zimbraMessage);
                        break;
                    case "ClubCloud.Zimbra.Replication":
                        message = await ProcessReplicationMessage(zimbraMessage);
                        break;
                    case "ClubCloud.Zimbra.Synchronization":
                        message = await ProcessSynchronizationMessage(zimbraMessage);
                        break;
                    case "ClubCloud.Zimbra.Voice":
                        message = await ProcessVoiceMessage(zimbraMessage);
                        break;
                    default:
                        {
                            message = new ZimbraMessage();
                            break;
                        }
                }
            }
            catch (TargetInvocationException tiex)
            {
                //bool reauthenticate = false;
                if(tiex.InnerException.GetType() == typeof(FaultException))
                {
                    if(tiex.InnerException.Message.Equals("no valid authtoken present", StringComparison.InvariantCultureIgnoreCase))
                    {
                        reauthenticate = true;
                    }
                    else
                    {
                        throw tiex;
                    }
                }
            }

            if (reauthenticate)
            {
                Authenticate();
                message = await Message(zimbraMessage);
            }

            return message;
        }

        //private static ZimbraVoiceSoapClient voice = null;
        private async Task<ZimbraMessage> ProcessVoiceMessage(ZimbraMessage zimbraMessage)
        {
            /*
            if (voice == null)
            {
                voice = new ZimbraVoiceSoapClient(binding, remoteAddress);
            }
            
            return ProcessMessage(voice, zimbraMessage);
            */

            throw new NotImplementedException();
        }

        //private static ZimbraSynchronizationSoapClient synchronization = null;

        private async Task<ZimbraMessage> ProcessSynchronizationMessage(ZimbraMessage zimbraMessage)
        {
            /*
            if (synchronization == null)
            {
                synchronization = new ZimbraSynchronizationSoapClient(binding, remoteAddress);
            }
            
            return ProcessMessage(synchronization, zimbraMessage);
            */

            throw new NotImplementedException();
        }

        //private static ZimbraReplicationSoapClient replication = null;

        private async Task<ZimbraMessage> ProcessReplicationMessage(ZimbraMessage zimbraMessage)
        {
            /*
            if (replication == null)
            {
                replication = new ZimbraReplicationSoapClient(binding, remoteAddress);
            }
            
            return ProcessMessage(replication, zimbraMessage);
            */

            throw new NotImplementedException();
        }

        //private static ZimbraMailSoapClient mail = null;

        private async Task<ZimbraMessage> ProcessMailMessage(ZimbraMessage zimbraMessage)
        {
            /*
            if (mail == null)
            {
                mail = new ZimbraMailSoapClient(binding, remoteAddress);
            }
            
            return ProcessMessage(mail, zimbraMessage);
            */

            throw new NotImplementedException();
        }

        //private static ZimbraAdminExtSoapClient administrationExtended = null;

        private async Task<ZimbraMessage> ProcessAdministrationExtendedMessage(ZimbraMessage zimbraMessage)
        {
            /*
            if (administrationExtended == null)
            {
                administrationExtended = new ZimbraAdminExtSoapClient(binding, remoteAddressAdmin);
            }
            
            return ProcessMessage(administrationExtended, zimbraMessage);
            */
            throw new NotImplementedException();
        }

        private static ZimbraAdminSoapClient administration = null;

        private async Task<ZimbraMessage> ProcessAdministrationMessage(ZimbraMessage zimbraMessage)
        {
            if(administration == null)
            {
                administration = new ZimbraAdminSoapClient(binding, remoteAddressAdmin);

            }
            object message = await ProcessMessage(administration, zimbraMessage);
            return message as ZimbraMessage;
        }

        private static ZimbraAccountSoapClient account = null;

        private async Task<ZimbraMessage> ProcessAccountMessage(ZimbraMessage zimbraMessage)
        {
            if(account == null)
            {
                account = new ZimbraAccountSoapClient(binding, remoteAddress);
            }
            object message = await ProcessMessage(account, zimbraMessage);
            return message as ZimbraMessage;
        }

        private delegate ZimbraMessage InvokeZimbra(object client, object[] args);

        private async Task<object> ProcessMessage(object client, ZimbraMessage zimbraMessage)
        {
            try
            {
                string name = zimbraMessage.GetType().Name;
                MethodInfo methodInfo = client.GetType().GetMethod(name);
                object[] parameters = new object[] { zimbraMessage };
                object response = await Task.Run(async () => methodInfo.Invoke(client, parameters));

                //System.Func<object,object[]> delegate = methodInfo.Invoke;
                //delegate.BeginInvoke(client, new object[] { zimbraMessage });
                //Func<ZimbraAdminSoapClient, ZimbraMessage[], ZimbraMessage> messageDelegate = (Func<ZimbraAdminSoapClient, ZimbraMessage[], ZimbraMessage>)Delegate.CreateDelegate(typeof(Func<ZimbraAdminSoapClient, ZimbraMessage[], ZimbraMessage>), methodInfo,);
                
                //invoke = new InvokeZimbra(client, messages);
                //Delegate zimbraDelegate = InvokeZimbra.CreateDelegate(client.GetType(),methodInfo);
                //Task<object> response = (Task<object>)zimbraDelegate.DynamicInvoke(messages);
                //Task<object> response = (Task<object>)methodInfo.Invoke(client, new object[] { zimbraMessage });
                //object response = methodInfo.Invoke(client, new object[] { zimbraMessage });
                //return (ZimbraMessage)response;

                return response;
            }
            catch (FaultException fex)
            {
                throw fex;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private static void Connect()
        {
            ZimbraServer.ServerNameClient = "https://" + configuration.Server.ServerName + ":443/service/soap/";
            ZimbraServer.ServerNameAdmin = "https://" + configuration.Server.ServerName + ":7071/service/admin/soap/";

            remoteAddress= new Service.ZimbraEndpointAddress(ZimbraServer.ServerNameClient);
            remoteAddressAdmin = new Service.ZimbraEndpointAddress(ZimbraServer.ServerNameAdmin);            
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        public void Dispose()
        {
            if(account != null)
            {
                account.InnerChannel.Dispose();
                account = null;
            }

            if (administration != null)
            {
                administration.InnerChannel.Dispose();
                administration = null;
            }
        }
    }
}
