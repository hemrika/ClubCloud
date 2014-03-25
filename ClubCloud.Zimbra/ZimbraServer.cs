﻿using ClubCloud.Zimbra.Account;
using ClubCloud.Zimbra.Administration;
using ClubCloud.Zimbra.Global;
using ClubCloud.Zimbra.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra
{
    public class ZimbraServer : System.ComponentModel.INotifyPropertyChanged
    {
        private static ZimbraBinding binding = new ZimbraBinding();
        private static ZimbraEndpointAddress remoteAddress { get; set; }
        internal static ZimbraEndpointAddress remoteAddressAdmin { get; set; }

        private static string _serverName;
        private static string _serverNameAdmin;

        private static System.Nullable<bool> _authenticated;
        private static System.Nullable<bool> _authenticatedAdmin;

        public static string ServerName
        {
            get { return ZimbraServer._serverName; }
            set { ZimbraServer._serverName = value; }
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
        public ZimbraServer(string ServerName)
        {
            Connect(ServerName);
        }



        public ZimbraServer(string Username, string Password, string ServerName)
        {
            Connect(ServerName);

            Authenticate(Username, Password);

        }

        public void Authenticate(string Username, string Password, bool asAdmin = false)
        {
            if (asAdmin)
            {
                Zimbra.Administration.AuthResponse response;
                if (administration == null)
                {
                    administration = new ZimbraAdminSoapClient(binding, remoteAddressAdmin);
                }
                Zimbra.Administration.AuthRequest request = new Administration.AuthRequest { account = new Global.accountSelector { by = Global.accountBy.AdministratorName, Value = Username }, password = Password };
                response = administration.AccountAuth(request);
                if (!string.IsNullOrEmpty(response.authToken))
                {
                    AuthenticatedAdmin = true;
                }

                ZimbraEndpointAddress.ZimbraHeaderContext.authToken = response.authToken;
                ZimbraEndpointAddress.ZimbraHeaderContext.AuthTokenControl = new authTokenControl { voidOnExpired = true };
                ZimbraEndpointAddress.ZimbraHeaderContext.account = request.account.Value;
                //ZimbraEndpointAddress.ZimbraHeaderContext.account.by = accountBy.name;

            }
            else
            {
                Zimbra.Account.AuthResponse response;
                if (account == null)
                {
                    account = new ZimbraAccountSoapClient(binding, remoteAddress);
                }
                Zimbra.Account.AuthRequest request = new Account.AuthRequest { account = new Global.accountSelector { by = Global.accountBy.Name, Value = Username }, password = Password };
                response = account.AccountAuth(request);
                if (!string.IsNullOrEmpty(response.authToken))
                {
                    Authenticated = true;
                }

                ZimbraEndpointAddress.ZimbraHeaderContext.authToken = response.authToken;
                ZimbraEndpointAddress.ZimbraHeaderContext.AuthTokenControl = new authTokenControl { voidOnExpired = true };
                ZimbraEndpointAddress.ZimbraHeaderContext.account = request.account.Value;

            }

            GetVersioInfo(asAdmin);

        }

        private void GetVersioInfo(bool asAdmin = false)
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

        public ZimbraMessage Message(ZimbraMessage zimbraMessage)
        {
            ZimbraMessage message = null;
            if(Authenticated.Value || AuthenticatedAdmin.Value)
            {
                string ns = zimbraMessage.GetType().Namespace;

                switch (ns)
                {
                    case "ClubCloud.Zimbra.Account":
                        message = ProcessAccountMessage(zimbraMessage);
                        break;
                    case "ClubCloud.Zimbra.Administration":
                        message = ProcessAdministrationMessage(zimbraMessage);
                        break;
                    case "ClubCloud.Zimbra.Administration.Extended":
                        message = ProcessAdministrationExtendedMessage(zimbraMessage);
                        break;
                    case "ClubCloud.Zimbra.Mail":
                        message = ProcessMailMessage(zimbraMessage);
                        break;
                    case "ClubCloud.Zimbra.Replication":
                        message = ProcessReplicationMessage(zimbraMessage);
                        break;
                    case "ClubCloud.Zimbra.Synchronization":
                        message = ProcessSynchronizationMessage(zimbraMessage);
                        break;
                    case "ClubCloud.Zimbra.Voice":
                        message = ProcessVoiceMessage(zimbraMessage);
                        break;
                    default:
                        {
                            message = new ZimbraMessage();
                            break;
                        }
                }
            }

            return message;
        }

        //private static ZimbraVoiceSoapClient voice = null;
        private ZimbraMessage ProcessVoiceMessage(ZimbraMessage zimbraMessage)
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

        private ZimbraMessage ProcessSynchronizationMessage(ZimbraMessage zimbraMessage)
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

        private ZimbraMessage ProcessReplicationMessage(ZimbraMessage zimbraMessage)
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

        private ZimbraMessage ProcessMailMessage(ZimbraMessage zimbraMessage)
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

        private ZimbraMessage ProcessAdministrationExtendedMessage(ZimbraMessage zimbraMessage)
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

        private ZimbraMessage ProcessAdministrationMessage(ZimbraMessage zimbraMessage)
        {
            if(administration == null)
            {
                administration = new ZimbraAdminSoapClient(binding, remoteAddressAdmin);

            }
            return ProcessMessage(administration, zimbraMessage);
        }

        private static ZimbraAccountSoapClient account = null;

        private ZimbraMessage ProcessAccountMessage(ZimbraMessage zimbraMessage)
        {
            if(account == null)
            {
                account = new ZimbraAccountSoapClient(binding, remoteAddress);
            }

            return ProcessMessage(account, zimbraMessage);
        }

        private ZimbraMessage ProcessMessage(object client, ZimbraMessage zimbraMessage)
        {
            try
            {
                string name = zimbraMessage.GetType().Name;
                MethodInfo methodInfo = client.GetType().GetMethod(name);
                object response = methodInfo.Invoke(client, new object[] { zimbraMessage });
                return (ZimbraMessage)response;
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

        private static void Connect(string ServerName)
        {
            ZimbraServer.ServerName = "https://" + ServerName + ":443/service/soap/";
            ZimbraServer.ServerNameAdmin = "https://" + ServerName + ":7071/service/admin/soap/";

            remoteAddress= new Service.ZimbraEndpointAddress(ZimbraServer.ServerName);
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
    }
}