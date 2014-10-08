﻿//-----------------------------------------------------------------------
// <copyright file="IHelloWorldRESTService.cs" company="">
// Copyright © 
// </copyright>
//-----------------------------------------------------------------------
namespace ClubCloud.Service
{

    using ClubCloud.Service.Model;
    using Microsoft.SharePoint;
    using System;
    using System.Collections.Generic;
    using System.ServiceModel;
    using System.ServiceModel.Web;
    using System.Threading.Tasks;
    
    /// <summary>
    ///
    /// </summary>
    [ServiceContract(Namespace = "http://clubcloud.nl/", Name = "ClubCloudAfhangen")]

    public interface IClubCloudAfhangenService
    {
        #region Afhangen

        [OperationContract]
        bool DeleteReservering(string bondsnummer, Guid verenigingId, Guid reserveringId, bool push = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baanschema))]
        System.Collections.Generic.List<ClubCloud.Service.Model.ClubCloud_Baanschema> GetBaanSchemaByAccommodatieId(string bondsnummer, Guid verenigingId, Guid accommodatieId, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baanschema))]
        System.Collections.Generic.List<ClubCloud.Service.Model.ClubCloud_Baanschema> GetBaanSchemaByVerenigingId(string bondsnummer, Guid verenigingId, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baan))]
        System.Collections.Generic.List<ClubCloud.Service.Model.ClubCloud_Baan> GetBanenByAccommodatieId(string bondsnummer, Guid verenigingId, Guid accommodatieId, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baan))]
        System.Collections.Generic.List<ClubCloud.Service.Model.ClubCloud_Baan> GetBanenByVerenigingId(string bondsnummer, Guid verenigingId, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Gebruiker))]
        System.Collections.Generic.List<ClubCloud.Service.Model.ClubCloud_Gebruiker> GetGebruikersByReserveringId(string bondsnummer, Guid verenigingId, Guid reserveringId, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Gebruiker))]
        ClubCloud.Service.Model.ClubCloud_Gebruiker GetGebruikerByNummer(string bondsnummer, Guid verenigingId, string nummer, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Foto))]
        ClubCloud.Service.Model.ClubCloud_Foto GetFotoByNummer(string bondsnummer, Guid verenigingId, string nummer, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Foto))]
        ClubCloud.Service.Model.ClubCloud_Foto GetFotoById(string bondsnummer, Guid verenigingId, Guid gebruikerId, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Gebruiker))]
        ClubCloud.Service.Model.ClubCloud_Gebruiker GetGebruikerById(string bondsnummer, Guid verenigingId, Guid gebruikerId, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Reservering))]
        ClubCloud.Service.Model.ClubCloud_Reservering GetReserveringByReserveringId(string bondsnummer, Guid verenigingId, Guid reserveringId, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Reservering))]
        System.Collections.Generic.List<ClubCloud.Service.Model.ClubCloud_Reservering> GetReserveringenByBaanId(string bondsnummer, Guid verenigingId, Guid baanId, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Reservering))]
        System.Collections.Generic.List<ClubCloud.Service.Model.ClubCloud_Reservering> GetReserveringenByBondsnummer(string bondsnummer, Guid verenigingId, string nummer, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Reservering))]
        System.Collections.Generic.List<ClubCloud.Service.Model.ClubCloud_Reservering> GetReserveringenByVerenigingId(string bondsnummer, Guid verenigingId, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
        ClubCloud.Service.Model.ClubCloud_Vereniging GetVerenigingByLocation(string bondsnummer, double Latitude, double Longitude, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
        ClubCloud.Service.Model.ClubCloud_Vereniging GetVerenigingByNummer(string bondsnummer, string verenigingNummer, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
        ClubCloud.Service.Model.ClubCloud_Vereniging GetVerenigingById(string bondsnummer, Guid verenigingId, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Afhang))]
        ClubCloud.Service.Model.ClubCloud_Afhang GetVerenigingSettings(string bondsnummer, Guid verenigingId, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Reservering))]
        ClubCloud.Service.Model.ClubCloud_Reservering SetReservering(string bondsnummer, Guid verenigingId, Guid baanId, Guid[] gebruikers, DateTime Datum, TimeSpan Tijd, TimeSpan Duur, ReserveringSoort Soort = ReserveringSoort.Afhangen, bool final = false, bool push = false, string Beschrijving = "");

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Reservering))]
        ClubCloud.Service.Model.ClubCloud_Reservering UpdateReservering(string bondsnummer, Guid verenigingId, ClubCloud.Service.Model.ClubCloud_Reservering reservering, bool final = false, bool push = false);

        #endregion

    }
}
