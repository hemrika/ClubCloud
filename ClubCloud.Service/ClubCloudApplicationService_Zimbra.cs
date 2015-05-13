namespace ClubCloud.Service
{
    using ClubCloud.Model;
    using ClubCloud.Provider;
    using ClubCloud.Zimbra;
    using ClubCloud.Zimbra.Mail;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data.Entity.Migrations;
    using System.Data.SqlClient;
    using System.IO;
    using System.Linq;
    using System.Net.Mail;
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using System.Text;
    using System.Threading.Tasks;
    using System.Web.Security;

    internal partial class ClubCloudApplicationService
    {
        private ZimbraMembershipProvider m_membershipProvider;

        internal ZimbraMembershipProvider ZimbraMembershipProvider
        {
            get
            {
                if (this.m_membershipProvider == null)
                {
                    this.m_membershipProvider = System.Web.Security.Membership.Providers["ZimbraMembershipProvider"] as ZimbraMembershipProvider;
                }
                return this.m_membershipProvider;
            }
        }

        private ZimbraRoleProvider m_roleProvider;

        internal ZimbraRoleProvider ZimbraRoleProvider
        {
            get
            {
                if (this.m_roleProvider == null)
                {
                    this.m_roleProvider = System.Web.Security.Roles.Providers["ZimbraRoleProvider"] as ZimbraRoleProvider;
                }
                return this.m_roleProvider;
            }
        }

        /*
        private ZimbraServer _zimbra;

        internal ZimbraServer Zimbra
        {
            get
            {
                if(this._zimbra == null)
                {
                    this._zimbra = new ZimbraServer("mail.clubcloud.nl");
                }

                return this._zimbra;
            }
        }
        */

        /// <summary>
        /// 
        /// </summary>
        /// <param name="gebruiker"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private async Task<bool> CreateOrUpdateMembershipGebruiker(ClubCloud_Gebruiker gebruiker, ClubCloud_Setting settings = null)
        {
            try
            {
                if (settings == null)
                {
                    settings = GetClubCloudSettings(gebruiker.Bondsnummer);// beheerModel.ClubCloud_Settings.SingleOrDefault(g => g.GebruikerId == gebruiker.Id);
                }
                //ClubCloud_Setting updatesettings = beheerModel.ClubCloud_Settings.SingleOrDefault(g => g.GebruikerId == gebruiker.Id);
                if (settings != null)// && updatesettings.Id != null)
                {
                    ZimbraMembershipUser zuser = await ZimbraMembershipProvider.GetZimbraUserAsync(gebruiker.Bondsnummer, false);

                    MembershipCreateStatus status = MembershipCreateStatus.Success;

                    if (zuser == null)
                    {
                        string nummer = "00000";
                        ClubCloud_Vereniging vereniging = null;
                        try
                        {
                            vereniging = GetVerenigingById(gebruiker.Bondsnummer, gebruiker.VerenigingId.Value, false);
                        }
                        catch { }

                        if (vereniging != null)
                            nummer = vereniging.Nummer;

                        string password = gebruiker.Achternaam[0] + gebruiker.Bondsnummer + '!';
                        string email = string.IsNullOrEmpty(gebruiker.EmailKNLTB) ? gebruiker.Bondsnummer + "@clubcloud.nl" : gebruiker.EmailKNLTB;

                        Tuple<MembershipCreateStatus, MembershipUser> result = await ZimbraMembershipProvider.CreateUserAsync(gebruiker.Bondsnummer + "@clubcloud.nl", password, email, "Wat uw verenigingsnummer?", nummer, true, null);

                        if (result.Item1 == MembershipCreateStatus.Success)
                        {
                            status = result.Item1;
                            zuser = result.Item2 as ZimbraMembershipUser;
                        }
                    }

                    if (status == MembershipCreateStatus.Success)
                    {
                        List<ClubCloud_Address> adressen = GetAddressenForGebruikerById(gebruiker.Id, false, settings);

                        ClubCloud_Address home = new ClubCloud_Address();
                        ClubCloud_Address post = new ClubCloud_Address();
                        if (adressen != null && adressen.Count > 0)
                        {
                            home = adressen.First();
                            post = adressen.Last();
                        }
                        ClubCloud_Nationaliteit nationaliteit = GetNationaliteitById(gebruiker.Bondsnummer, gebruiker.NationaliteitId.Value, false, settings);
                        ClubCloud_Vereniging vereniging = GetVerenigingById(gebruiker.Bondsnummer, gebruiker.VerenigingId.Value, false);
                        ClubCloud_District district = GetDistrictById(gebruiker.Bondsnummer, vereniging.DistrictId.Value, false, settings);

                        if (gebruiker != null)
                        {
                            zuser.cn = gebruiker.Volledigenaam;
                            zuser.sn = gebruiker.Achternaam;
                            zuser.displayName = gebruiker.Volledigenaam;
                            zuser.employeeNumber = gebruiker.Id.ToString();
                            zuser.givenName = gebruiker.Voornamen;
                            zuser.initials = gebruiker.Voorletters;
                            zuser.telephoneNumber = gebruiker.Mobiel;
                            zuser.zimbraPrefMailForwardingAddress = gebruiker.EmailKNLTB;
                            zuser.homePhone = gebruiker.TelefoonAvond;
                            zuser.mobile = gebruiker.Mobiel;
                        }

                        if (nationaliteit != null)
                            zuser.co = nationaliteit.Naam;

                        if (vereniging != null)
                        {
                            zuser.o = vereniging.Nummer;
                            zuser.company = vereniging.Nummer;
                        }

                        if (district != null)
                            zuser.departmentNumber = district.Naam;



                        if (home != null)
                        {
                            zuser.homePostalAddress = home.Straat + " " + home.Nummer + " " + home.Toevoeging + " " + Environment.NewLine + home.Postcode + "," + home.Stad + " " + Environment.NewLine + home.Gemeente + "," + home.Provincie;
                            zuser.l = home.Stad;
                            zuser.postalCode = home.Postcode;
                            zuser.st = home.Gemeente;
                            zuser.street = home.Straat + " " + home.Nummer + " " + home.Toevoeging;
                        }

                        if (post != null)
                        {
                            zuser.postalAddress = post.Straat + " " + post.Nummer + " " + post.Toevoeging + " " + Environment.NewLine + post.Postcode + "," + post.Stad + " " + Environment.NewLine + post.Gemeente + "," + post.Provincie;
                        }
                    }

                    if (zuser != null && status == MembershipCreateStatus.Success)
                        await ZimbraMembershipProvider.UpdateZimbraUserAsync(zuser);
                }
                //}

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vereniging"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private async Task<bool> CreateOrUpdateMembershipVereniging(ClubCloud_Vereniging vereniging, ClubCloud_Setting settings = null)
        {
            try
            {
                if (settings == null)
                {
                    settings = beheerModel.ClubCloud_Settings.SingleOrDefault(g => g.VerenigingId == vereniging.Id);
                }

                if (settings != null)
                {
                    ZimbraMembershipUser zuser = await ZimbraMembershipProvider.GetZimbraUserAsync(vereniging.Nummer, false);
                    MembershipCreateStatus status = MembershipCreateStatus.Success;

                    if (zuser == null)
                    {

                        string password = vereniging.Naam[0] + vereniging.Nummer + '!';
                        string email = string.IsNullOrEmpty(vereniging.EmailKNLTB) ? vereniging.Nummer + "@clubcloud.nl" : vereniging.EmailKNLTB;
                        Tuple<MembershipCreateStatus, MembershipUser> result = await ZimbraMembershipProvider.CreateUserAsync(vereniging.Nummer + "@clubcloud.nl", password, email, "Wat uw verenigingsnummer?", vereniging.Nummer, true, null);

                        if (result.Item1 == MembershipCreateStatus.Success)
                        {
                            status = result.Item1;
                            zuser = result.Item2 as ZimbraMembershipUser;
                        }
                    }

                    if (status == MembershipCreateStatus.Success)
                    {
                        List<ClubCloud_Address> adressen = GetAddressenForVerenigingById(vereniging.Id, false, settings);
                        ClubCloud_Address home = new ClubCloud_Address();
                        ClubCloud_Address post = new ClubCloud_Address();
                        if (adressen != null && adressen.Count > 0)
                        {
                            home = adressen.First();
                            post = adressen.Last();
                        }

                        //ClubCloud_Nationaliteit nationaliteit = GetNationaliteitById(vereniging.Nummer, vereniging.NationaliteitId.Value, false, settings);

                        if (vereniging != null)
                        {
                            zuser.cn = vereniging.Naam;
                            zuser.sn = vereniging.Naam;
                            zuser.company = vereniging.Nummer;
                            zuser.displayName = vereniging.Naam;
                            zuser.employeeNumber = vereniging.Id.ToString();
                            zuser.givenName = vereniging.Naam;
                            zuser.homePhone = vereniging.TelefoonOverdag;
                            zuser.mobile = vereniging.TelefoonOverig;
                            zuser.o = vereniging.Nummer;
                            zuser.telephoneNumber = vereniging.TelefoonAvond;
                            zuser.zimbraPrefMailForwardingAddress = vereniging.EmailKNLTB;
                            //zuser.co = gebruiker.NationaliteitId.ToString();
                            //zuser.initials = gebruiker.Voorletters;
                        }

                        ClubCloud_District district = null;
                        if (vereniging.DistrictId != null)
                            district = GetDistrictById(vereniging.Nummer, vereniging.DistrictId.Value, false, settings);

                        if (district != null)
                            zuser.departmentNumber = district.Naam;

                        if (home != null)
                        {
                            zuser.homePostalAddress = home.Straat + " " + home.Nummer + " " + home.Toevoeging + " " + Environment.NewLine + home.Postcode + "," + home.Stad + " " + Environment.NewLine + home.Gemeente + "," + home.Provincie;
                            zuser.l = home.Stad;
                            zuser.postalCode = home.Postcode;
                            zuser.st = home.Gemeente;
                            zuser.street = home.Straat + " " + home.Nummer + " " + home.Toevoeging;
                        }

                        if (post != null)
                        {
                            zuser.postalAddress = post.Straat + " " + post.Nummer + " " + post.Toevoeging + " " + Environment.NewLine + post.Postcode + "," + post.Stad + " " + Environment.NewLine + post.Gemeente + "," + post.Provincie;
                        }
                    }


                    if (zuser != null && status == MembershipCreateStatus.Success)
                        await ZimbraMembershipProvider.UpdateZimbraUserAsync(zuser);
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="functie"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private async Task<bool> CreateOrUpdateGroupFunctie(ClubCloud_Functie functie, ClubCloud_Setting settings = null)
        {
            try
            {
                if (settings == null)
                {
                    return false;
                }

                if (settings != null)
                {
                    if(await ZimbraRoleProvider.GroupExistsAsync(functie.Naam)) return true;

                    await ZimbraRoleProvider.CreateGroupAsync(functie.Naam);
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="functie"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private async Task<bool> CreateOrUpdateRoleFunctie(ClubCloud_Functie functie, ClubCloud_Setting settings = null)
        {
            try
            {
                if (settings == null)
                {
                    return false;
                }

                if (settings != null)
                {
                    if (await ZimbraRoleProvider.RoleExistsAsync(functie.Naam)) return true;

                    await ZimbraRoleProvider.CreateRoleAsync(functie.Naam);
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="functie"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private async Task<bool> CreateOrUpdateRoleFunctionaris(ClubCloud_Functionaris functionaris, ClubCloud_Setting settings = null)
        {
            try
            {
                if (settings == null)
                {
                    return false;
                }

                if (settings != null)
                {
                    if (functionaris != null && functionaris.ClubCloud_Gebruiker == null)
                        beheerModel.Entry(functionaris).Reference(e => e.ClubCloud_Gebruiker).Load();

                    if (functionaris.ClubCloud_Gebruiker == null)
                        functionaris.ClubCloud_Gebruiker = GetGebruikerById(functionaris.GebruikerId.Value, false, settings);

                    if (functionaris != null && functionaris.ClubCloud_Functie == null)
                        beheerModel.Entry(functionaris).Reference(e => e.ClubCloud_Functie).Load();

                    if (functionaris.ClubCloud_Functie == null)
                        functionaris.ClubCloud_Functie = GetFunctieById(functionaris.FunctieId.Value, false, settings);

                    if (functionaris.Actief == ActiefSoort.Actief)
                    {
                        await ZimbraRoleProvider.AddUsersToRolesAsync(new string[] { functionaris.ClubCloud_Gebruiker.Bondsnummer }, new string[] { functionaris.ClubCloud_Functie.Naam });
                    }
                    else
                    {
                        await ZimbraRoleProvider.RemoveUsersFromRolesAsync(new string[] { functionaris.ClubCloud_Gebruiker.Bondsnummer }, new string[] { functionaris.ClubCloud_Functie.Naam });
                    }
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        /*
        public bool SendMessage(MailMessage message, ClubCloud_Setting settings = null)
        {
            bool result = Task.Run(async () => await SendMessageAsync(message, settings)).Result;
            return result;
        }

        private async Task<bool> SendMessageAsync(MailMessage message, ClubCloud_Setting settings = null)
        {
            if(settings != null)
            {
                try
                {

                    ClubCloud_Setting currentsettings = beheerModel.ClubCloud_Settings.Find(settings.Id);
                    ClubCloud_Gebruiker gebruiker = currentsettings.ClubCloud_Gebruiker;

                    //string pw = BeheerEncryption.Decrypt((currentsettings.Password, currentsettings.VerenigingId.Value.ToString(), currentsettings.GebruikerId.Value.ToString());

                    _zimbra.Authenticate();//currentsettings.Id.ToString(),pw, false);
                    SendMsgRequest request = new SendMsgRequest { isCalendarForward = false, needCalendarSentByFixup = false, noSave = true };
                    msgToSend messagetosend = new msgToSend();//
                    messagetosend.e = new List<emailAddrInfo>();
                    //To
                    foreach (MailAddress emailto in message.To)
                    {
                        messagetosend.e.Add(new emailAddrInfo { a = emailto.Address, t = "t", p = emailto.DisplayName });
                    }

                    //From
                    messagetosend.e.Add(new emailAddrInfo { a = gebruiker.EmailKNLTB, t = "f", p = gebruiker.Volledigenaam });

                    messagetosend.mp = new mimePartInfo();

                    foreach (AlternateView view in message.AlternateViews)
                    {
                        string content = string.Empty;
                        view.ContentStream.Position = 0;
                        using (StreamReader reader = new StreamReader(view.ContentStream, Encoding.UTF8))
                        {
                            content = reader.ReadToEnd();
                        }

                        mimePartInfo part = new mimePartInfo { content = content, ct = view.ContentType.Name };
                        messagetosend.mp.mp.Add(part);
                    }

                    request.m = messagetosend;

                    SendMsgResponse response = await Zimbra.Message(request) as SendMsgResponse;
                    return true;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return false;
        }
        /*
    }

    internal partial interface IClubCloudApplicationService
    {
        /*
        [OperationContract]
        bool SendMessage(MailMessage message, ClubCloud_Setting settings = null);
        */
    }

}