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
        #region Mobiel

        [OperationContract]
        [WebInvoke(Method = "*", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetLand/{LandId}", ResponseFormat = WebMessageFormat.Json)]
        ClubCloud.Model.ClubCloud_Land GetLand(string LandId);

        [OperationContract]
        [WebInvoke(Method = "*", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetDistrict/{DistrictId}", ResponseFormat = WebMessageFormat.Json)]
        ClubCloud.Model.ClubCloud_District GetDistrict(string DistrictId);

        [OperationContract]
        [WebInvoke(Method = "*", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetRegio/{RegioId}", ResponseFormat = WebMessageFormat.Json)]
        ClubCloud.Model.ClubCloud_Regio GetRegio(string RegioId);

        [OperationContract]
        [WebInvoke(Method = "*", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetRechtsvorm/{RechtsvormId}", ResponseFormat = WebMessageFormat.Json)]
        ClubCloud.Model.ClubCloud_Rechtsvorm GetRechtsvorm(string RechtsvormId);

        [OperationContract]
        [WebInvoke(Method = "*", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetBestuursorgaan/{BestuursorgaanId}", ResponseFormat = WebMessageFormat.Json)]
        ClubCloud.Model.ClubCloud_Bestuursorgaan GetBestuursorgaan(string BestuursorgaanId);

        [OperationContract]
        [WebInvoke(Method = "*", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetFunctie/{FunctieId}", ResponseFormat = WebMessageFormat.Json)]
        ClubCloud.Model.ClubCloud_Functie GetFunctie(string FunctieId);        

        [OperationContract]
        [WebInvoke(Method = "*", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetLidmaatschapsoort/{LidmaatschapsoortId}", ResponseFormat = WebMessageFormat.Json)]
        ClubCloud.Model.ClubCloud_Lidmaatschapsoort GetLidmaatschapsoort(string LidmaatschapsoortId);        

        [OperationContract]
        [WebInvoke(Method = "*", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetNationaliteit/{NationaliteitId}", ResponseFormat = WebMessageFormat.Json)]
        ClubCloud.Model.ClubCloud_Nationaliteit GetNationaliteit(string NationaliteitId);        

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
        [WebInvoke(Method = "*", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetGebruikerById/{GebruikerId}", ResponseFormat = WebMessageFormat.Json)]
        ClubCloud.Model.ClubCloud_Gebruiker GetGebruikerById(string GebruikerId);

        [OperationContract]
        [WebInvoke(Method = "*", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetLidmaatschappen", ResponseFormat = WebMessageFormat.Json)]
        System.Collections.Generic.List<ClubCloud.Model.ClubCloud_Lidmaatschap> GetLidmaatschappen();

        [OperationContract]
        [WebInvoke(Method = "*", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetLidmaatschapsoortenForVereniging", ResponseFormat = WebMessageFormat.Json)]
        System.Collections.Generic.List<ClubCloud.Model.ClubCloud_Lidmaatschapsoort> GetLidmaatschapsoortenForVereniging();

        [OperationContract]
        [WebInvoke(Method = "*", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetNationaliteitForGebruiker", ResponseFormat = WebMessageFormat.Json)]
        ClubCloud.Model.ClubCloud_Nationaliteit GetNationaliteitForGebruiker();

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

        [OperationContract]
        [WebInvoke(Method = "*", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetReserveringen", ResponseFormat = WebMessageFormat.Json)]
        List<ClubCloud_Reservering> GetReserveringen();

        [OperationContract]
        [WebInvoke(Method = "*", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetVerenigingenBySearch/{prefixText}/{count}/{contextKey}", ResponseFormat = WebMessageFormat.Json)]
        List<ClubCloud_Vereniging> GetVerenigingenBySearch(string prefixText, int count, string contextKey);

        [OperationContract]
        [WebInvoke(Method = "*", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetGebruikersBySearch/{prefixText}/{count}/{contextKey}", ResponseFormat = WebMessageFormat.Json)]
        List<ClubCloud_Gebruiker> GetGebruikersBySearch(string prefixText, int count, string contextKey);

        #endregion

    }
}
