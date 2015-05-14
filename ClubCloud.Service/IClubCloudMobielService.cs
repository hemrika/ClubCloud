//-----------------------------------------------------------------------
// <copyright file="IHelloWorldRESTService.cs" company="">
// Copyright © 
// </copyright>
//-----------------------------------------------------------------------
namespace ClubCloud.Service
{

    using ClubCloud.Model;
    using Microsoft.SharePoint;
    using System;
    using System.Collections.Generic;
    using System.Net.Security;
    using System.ServiceModel;
    using System.ServiceModel.Web;
    using System.Threading.Tasks;
    using System.Web.Configuration;
    
    /// <summary>
    ///
    /// </summary>
    [ServiceKnownType("GetKnownTypes", typeof(BeheerContainer_KnownTypes))]
    [ServiceContract(Namespace = "http://clubcloud.nl/", Name = "ClubCloudMobiel")]
    public interface IClubCloudMobielService
    {
        #region Afhangen

        [OperationContract]
        [WebInvoke(Method = "*", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetAccommodatieForVereniging", ResponseFormat = WebMessageFormat.Json)]
        ClubCloud.Model.ClubCloud_Accommodatie GetAccommodatieForVereniging();

        [OperationContract]
        [WebInvoke(Method = "*", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetAddressen", ResponseFormat = WebMessageFormat.Json)]
        List<ClubCloud.Model.ClubCloud_Address> GetAddressen();

        [OperationContract]
        [WebInvoke(Method = "*", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetAddressenForAccommodatie/{AccommodatieId}", ResponseFormat = WebMessageFormat.Json)]
        System.Collections.Generic.List<ClubCloud.Model.ClubCloud_Address> GetAddressenForAccommodatie(string AccommodatieId);

        [OperationContract]
        [WebInvoke(Method = "*", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetAddressenForVereniging", ResponseFormat = WebMessageFormat.Json)]
        System.Collections.Generic.List<ClubCloud.Model.ClubCloud_Address> GetAddressenForVereniging();

        [OperationContract]
        [WebInvoke(Method = "*", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetAfhangenForVereniging", ResponseFormat = WebMessageFormat.Json)]
        System.Collections.Generic.List<ClubCloud.Model.ClubCloud_Afhang> GetAfhangenForVereniging();

        [OperationContract]
        [WebInvoke(Method = "*", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetBaanblokkenForAccommodatie/{AccommodatieId}", ResponseFormat = WebMessageFormat.Json)]
        System.Collections.Generic.List<ClubCloud.Model.ClubCloud_Baanblok> GetBaanblokkenForAccommodatie(string AccommodatieId);

        [OperationContract]
        [WebInvoke(Method = "*", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetBaanschemasForVereniging", ResponseFormat = WebMessageFormat.Json)]
        System.Collections.Generic.List<ClubCloud.Model.ClubCloud_Baanschema> GetBaanschemasForVereniging();

        [OperationContract]
        [WebInvoke(Method = "*", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetBanenForAccommodatie/{AccommodatieId}", ResponseFormat = WebMessageFormat.Json)]
        System.Collections.Generic.List<ClubCloud.Model.ClubCloud_Baan> GetBanenForAccommodatie(string AccommodatieId);

        [OperationContract]
        [WebInvoke(Method = "*", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetBanenSpeciaalForAccommodatie/{AccommodatieId}", ResponseFormat = WebMessageFormat.Json)]
        System.Collections.Generic.List<ClubCloud.Model.ClubCloud_BaanSpeciaal> GetBanenSpeciaalForAccommodatie(string AccommodatieId);

        [OperationContract]
        [WebInvoke(Method = "*", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetBestuursorganenForVereniging", ResponseFormat = WebMessageFormat.Json)]
        System.Collections.Generic.List<ClubCloud.Model.ClubCloud_Bestuursorgaan> GetBestuursorganenForVereniging();

        [OperationContract]
        [WebInvoke(Method = "*", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetDistrictForVereniging", ResponseFormat = WebMessageFormat.Json)]
        ClubCloud.Model.ClubCloud_District GetDistrictForVereniging();

        [OperationContract]
        [WebInvoke(Method = "*", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetFoto", ResponseFormat = WebMessageFormat.Json)]
        ClubCloud.Model.ClubCloud_Foto GetFoto();

        [OperationContract]
        [WebInvoke(Method = "*", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetFunctionarissen", ResponseFormat = WebMessageFormat.Json)]
        System.Collections.Generic.List<ClubCloud.Model.ClubCloud_Functionaris> GetFunctionarissen();

        [OperationContract]
        [WebInvoke(Method = "*", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetFunctionarissenForVereniging", ResponseFormat = WebMessageFormat.Json)]
        System.Collections.Generic.List<ClubCloud.Model.ClubCloud_Functionaris> GetFunctionarissenForVereniging();

        [OperationContract]
        [WebInvoke(Method = "*", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetGebruiker", ResponseFormat = WebMessageFormat.Json)]
        ClubCloud.Model.ClubCloud_Gebruiker GetGebruiker();

        [OperationContract]
        [WebInvoke(Method = "*", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetGebruikerByNummer/{nummer}", ResponseFormat = WebMessageFormat.Json)]
        ClubCloud.Model.ClubCloud_Gebruiker GetGebruikerByNummer(string nummer);

        [OperationContract]
        [WebInvoke(Method = "*", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetLidmaatschappen", ResponseFormat = WebMessageFormat.Json)]
        System.Collections.Generic.List<ClubCloud.Model.ClubCloud_Lidmaatschap> GetLidmaatschappen();

        [OperationContract]
        [WebInvoke(Method = "*", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetLidmaatschapsoortenForVereniging", ResponseFormat = WebMessageFormat.Json)]
        System.Collections.Generic.List<ClubCloud.Model.ClubCloud_Lidmaatschapsoort> GetLidmaatschapsoortenForVereniging();

        [OperationContract]
        [WebInvoke(Method = "*", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetNationaliteit", ResponseFormat = WebMessageFormat.Json)]
        ClubCloud.Model.ClubCloud_Nationaliteit GetNationaliteit();

        [OperationContract]
        [WebInvoke(Method = "*", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetProfielen", ResponseFormat = WebMessageFormat.Json)]
        System.Collections.Generic.List<ClubCloud.Model.ClubCloud_Profiel> GetProfielen();

        [OperationContract]
        [WebInvoke(Method = "*", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetRegioForVereniging", ResponseFormat = WebMessageFormat.Json)]
        ClubCloud.Model.ClubCloud_Regio GetRegioForVereniging();

        [OperationContract]
        [WebInvoke(Method = "*", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetSettings", ResponseFormat = WebMessageFormat.Json)]
        ClubCloud.Model.ClubCloud_Setting GetSettings();

        [OperationContract]
        [WebInvoke(Method = "*", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetSponsorenForVereniging", ResponseFormat = WebMessageFormat.Json)]
        System.Collections.Generic.List<ClubCloud.Model.ClubCloud_Sponsor> GetSponsorenForVereniging();

        [OperationContract]
        [WebInvoke(Method = "*", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetAccommodatie/{AccommodatieId}", ResponseFormat = WebMessageFormat.Json)]
        ClubCloud.Model.ClubCloud_Accommodatie GetAccommodatie(string AccommodatieId);

        [OperationContract]
        [WebInvoke(Method = "*", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetVereniging", ResponseFormat = WebMessageFormat.Json)]
        ClubCloud.Model.ClubCloud_Vereniging GetVereniging();

        [OperationContract]
        [WebInvoke(Method = "*", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetVerenigingByLocation/{Latitude}/{Longitude}", ResponseFormat = WebMessageFormat.Json)]
        ClubCloud.Model.ClubCloud_Vereniging GetVerenigingByLocation(string Latitude, string Longitude);

        [OperationContract]
        [WebInvoke(Method = "*", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetVerenigingByNummer/{verenigingNummer}", ResponseFormat = WebMessageFormat.Json)]
        ClubCloud.Model.ClubCloud_Vereniging GetVerenigingByNummer(string verenigingNummer);

        [OperationContract]
        [WebInvoke(Method = "*", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "Login/{username}/{password}", ResponseFormat = WebMessageFormat.Json)]
        LoginResult Login(string username, string password);

        [OperationContract]
        [WebInvoke(Method = "*", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "LoginMode", ResponseFormat = WebMessageFormat.Json)]
        System.Web.Configuration.AuthenticationMode LoginMode();

        /*
        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "LoginMode", ResponseFormat = WebMessageFormat.Json)]
        AuthenticationMode LoginMode();

        [OperationContract]
        [ServiceKnownType(typeof(LoginResult))]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "Login/{username}/{password}", ResponseFormat= WebMessageFormat.Json)]
        LoginResult Login(string username, string password);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Setting))]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetClubCloudSettings", ResponseFormat = WebMessageFormat.Json)]
        ClubCloud_Setting GetClubCloudSettings();
        */
        
        #endregion

    }
}
