//-----------------------------------------------------------------------
// <copyright file="IHelloWorldWCFService.cs" company="">
// Copyright © 
// </copyright>
//-----------------------------------------------------------------------

namespace ClubCloud.Service
{
    using ClubCloud.KNLTB.ServIt.LedenAdministratieService;
    using ClubCloud.Service.Model;
    using System;
    using System.Collections.Generic;
    using System.ServiceModel;
    using System.ServiceModel.Description;

    /// <summary>
    /// The Service Contract.
    /// </summary>
    [ServiceContract(Namespace = "http://clubcloud.nl/", Name = "ClubCloudService")]
    [System.Runtime.InteropServices.Guid("23c6e4c4-d8d7-4bef-8d11-420c88bbefc2")]
    internal interface IClubCloudApplicationService
    {
        #region Methods    

        #region MetaData

        [OperationContract]
        string GetPostcode(string postcode, int huisnummer);

        #endregion

        #region Gebruiker

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Gebruiker))]
        ClubCloud_Gebruiker GetClubCloudUser(string user);

        [OperationContract]
        [ServiceKnownType(typeof(Persoonsgegevens))]
        Persoonsgegevens GetPersoonsgegevens(string bondsnummer, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(SpelersProfiel))]
        SpelersProfiel GetPersoonsprofiel(string bondsnummer);

        [OperationContract]
        [ServiceKnownType(typeof(SpelerTracking))]
        SpelerTracking GetTracking(string bondsnummer, bool update = false);

        [OperationContract]
        [ServiceKnownType(typeof(District))]
        List<District> GetDistricten(string bondsnummer, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(Vereniging))]
        List<Vereniging> GetVerenigingen(string bondsnummer, bool refresh = false);

        #endregion

        #region Club

        [OperationContract]
        ClubCloud_Vereniging GetVereniging(string bondsnummer, Guid verenigingId, bool refresh = false);

        [OperationContract]
        ClubCloud_Vereniging GetVereniging(string bondsnummer, string vereniginsnummer, bool refresh = false);

        #endregion


        [OperationContract]
        bool CreateClubCloudWebSite(string verenigingsummer);
        #endregion
    }
}
