﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Net;
using System.Collections.Specialized;
using ClubCloud.Zimbra.Account;
using ClubCloud.Zimbra.Global;
using ClubCloud.Zimbra.Administration;
using System.ServiceModel;
using System.Reflection;

namespace ClubCloud.Zimbra.Client
{
    public partial class Form1 : Form
    {
        private static ZimbraServer server;

        public Form1()
        {
            InitializeComponent();
            server = new ZimbraServer("mail.clubcloud.nl");//("info@clubcloud.nl", "rjm557308453!", "mail.clubcloud.nl");
            server.PropertyChanged += server_PropertyChanged;
            server.Authenticate("admin@clubcloud.nl", "rjm557308453!",true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                string zimbraId = null;

                Zimbra.Administration.GetAccountInfoRequest request = new Zimbra.Administration.GetAccountInfoRequest { account = new Zimbra.Global.accountSelector { by = Zimbra.Global.accountBy.Name, Value = "info@clubcloud.nl" } };
                Zimbra.Administration.GetAccountInfoResponse response = server.Message(request) as Zimbra.Administration.GetAccountInfoResponse;
                if (response != null)
                {

                    foreach (var item in response.a)
                    {
                        if (item.name == "zimbraId")
                        {
                            zimbraId = item.Value;
                        }
                    }
                }
                if (!string.IsNullOrWhiteSpace(zimbraId))
                {
                    List<attrN> password = new List<attrN>();
                    password.Add(new attrN { name = "userPassword", Value = "rjm557308453!" });

                    Zimbra.Administration.ModifyAccountRequest modify = new Zimbra.Administration.ModifyAccountRequest { id = zimbraId, a = password };
                    Zimbra.Administration.ModifyAccountResponse modified = server.Message(modify) as Zimbra.Administration.ModifyAccountResponse;

                    string id = modified.account.id;
                }
                */

                Zimbra.Administration.GetAccountRequest request = new Zimbra.Administration.GetAccountRequest { account = new Zimbra.Global.accountSelector { by = Zimbra.Global.accountBy.Name, Value = "12073385@clubcloud.nl" }, applyCos = true};//, attrs = "displayName" };
                Zimbra.Administration.GetAccountResponse response = server.Message(request) as Zimbra.Administration.GetAccountResponse;
                if (response != null)
                {
                    string name = response.account.a[0].Value;
                }

                //Zimbra.Administration.GetAccountInfoRequest request = new Zimbra.Administration.GetAccountInfoRequest { account = new Zimbra.Global.accountSelector { by = Zimbra.Global.accountBy.Name, Value = "info@clubcloud.nl" } };
                //Zimbra.Administration.GetAccountInfoResponse response = server.Message(request) as Zimbra.Administration.GetAccountInfoResponse;
                //if (response != null)
                //{
                //    string name = response.name;
                //}

                //zimbraPasswordMaxLength,zimbraPasswordMinLength,zimbraPasswordMinLowerCaseChars,zimbraPasswordMinAlphaChars,zimbraPasswordMinNumericChars,zimbraPasswordMinDigitsOrPuncs,zimbraPasswordMinPunctuationChars,zimbraPasswordMinUpperCaseChars,zimbraPasswordAllowedChars,zimbraPasswordAllowedPunctuationChars
                //zimbraPasswordLockoutDuration,zimbraPasswordLockoutEnabled,zimbraPasswordLockoutMaxFailures
                //GetCosRequest request = new GetCosRequest { cos = new cosSelector { by = cosBy.name, Value = "clubcloud" }, attrs = "zimbraPasswordMaxLength,zimbraPasswordMinLength,zimbraPasswordMinLowerCaseChars,zimbraPasswordMinAlphaChars,zimbraPasswordMinNumericChars,zimbraPasswordMinDigitsOrPuncs,zimbraPasswordMinPunctuationChars,zimbraPasswordMinUpperCaseChars,zimbraPasswordAllowedChars,zimbraPasswordAllowedPunctuationChars" };
                //GetCosResponse response = server.Message(request) as GetCosResponse;

                //foreach (var item in response.cos.a)
                //{
                //    PropertyInfo propertyInfo = this.GetType().GetProperty(item.name);
                //    propertyInfo.SetValue(this, Convert.ChangeType(item.Value, propertyInfo.PropertyType), null);
                //}

                //int z = zimbraPasswordMinLength;
                //string name = response.cos.name;

                /*
                Zimbra.Account.ChangePasswordRequest request = new Zimbra.Account.ChangePasswordRequest { account = new Zimbra.Global.accountSelector { by = Zimbra.Global.accountBy.Name, Value = username }, oldPassword = oldPassword, password = newPassword };
                Zimbra.Account.ChangePasswordResponse response = clientServer.Message(request) as Zimbra.Account.ChangePasswordResponse;
                string AuthToken = response.authToken;
                */

                /*
                CreateDomainRequest createdomain = new CreateDomainRequest { name = "centralweb.nl" };
                createdomain.a.Add(new attrN { name = "zimbraDomainType", Value = "alias" });
                createdomain.a.Add(new attrN { name = "zimbraDomainAliasTargetId", Value = "5e69fe13-6ba0-45df-9135-e079c64b4521" });
                createdomain.a.Add(new attrN { name = "description", Value = "domeinalias van clubcloud.nl" });
                createdomain.a.Add(new attrN { name = "zimbraMailCatchAllAddress", Value = "@centralweb.nl" });
                createdomain.a.Add(new attrN { name = "zimbraMailCatchAllForwardingAddress", Value = "@clubcloud.nl" });
                createdomain.a.Add(new attrN { name = "zimbraSkinLogoURL", Value = "http://www.centralweb.nl" });

                CreateDomainResponse createdomainresponse = server.Message(createdomain) as CreateDomainResponse;
                string name = createdomainresponse.domain.name;
                */
                /*
                Account.GetAccountInfoRequest message = new Account.GetAccountInfoRequest();
                //message.account = new Global.accountSelector { Value = "d0ec1768-02dd-4fd3-b302-1da0cd6e868a", by = accountBy.Id };
                message.account = new Global.accountSelector { Value = "info@clubcloud.nl", by = Global.accountBy.Name };

                Account.GetAccountInfoResponse response = server.Message(message) as Account.GetAccountInfoResponse;
                string publicURL = response.publicURL;
                */
                /*
                GetDomainRequest domainrequest = new GetDomainRequest { domain = new domainSelector { by = domainBy.name, Value = "clubcloud.nl" } };
                GetDomainResponse domainresponse = server.Message(domainrequest) as GetDomainResponse;

                domainInfo domain = domainresponse.domain;
                //string name = domain.name;
                */

                /*
                ModifyDomainRequest modifyDomainrequest = new ModifyDomainRequest { id = "5e69fe13-6ba0-45df-9135-e079c64b4521" };
                modifyDomainrequest.a.Add(new Global.attrN { name = "zimbraSkinLogoURL", Value = "http://www.clubcloud.nl" });
                ModifyDomainResponse modifyDomainresponse = server.Message(modifyDomainrequest) as ModifyDomainResponse;

                string name = modifyDomainresponse.domain.name;
                */

                /*
                GetAllDomainsRequest domainsrequest = new GetAllDomainsRequest { applyConfig = false };
                GetAllDomainsResponse domainsresponse = server.Message(domainsrequest) as GetAllDomainsResponse;

                List<domainInfo> domains = domainsresponse.Domains;

                foreach (domainInfo domain in domains)
                {
                    string id = domain.id;
                    string name = domain.name;
                    List<Global.attr> aa = domain.a;

                    foreach (Global.attr a in aa)
                    {
                        string a_name = a.name;
                        string a_value = a.Value;
                        bool a_pd = a.pd;
                    }
                }
                */
                /*
                GetInfoRequest info = new GetInfoRequest{ sections = infoSection.All.ToString() };
                GetInfoResponse inforesponse = server.Message(info) as GetInfoResponse;
                List<prop> props = inforesponse.props;
                */
                
            }
            catch (FaultException fex)
            {
                Console.Write(fex.Message);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            //Application.Exit();
            
        }

        void server_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Console.Write(server.Authenticated.Value);
        }
    }
}
