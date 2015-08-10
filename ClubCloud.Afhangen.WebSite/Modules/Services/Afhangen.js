Type.registerNamespace('clubcloud.nl');
clubcloud.nl.ClubCloudAfhangen = function () {
    clubcloud.nl.ClubCloudAfhangen.initializeBase(this);
    this._timeout = 0;
    this._userContext = null;
    this._succeeded = null;
    this._failed = null;
}
clubcloud.nl.ClubCloudAfhangen.prototype = {
    _get_path: function () {
        var p = this.get_path();
        if (p) return p;
        else return clubcloud.nl.ClubCloudAfhangen._staticInstance.get_path();
    },
    GetBaanById: function (bondsnummer, verenigingId, baanId, refresh, succeededCallback, failedCallback, userContext) {
        /// <param name="bondsnummer" type="String">System.String</param>
        /// <param name="verenigingId" type="String">System.Guid</param>
        /// <param name="baanId" type="String">System.Guid</param>
        /// <param name="refresh" type="Boolean">System.Boolean</param>
        /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="userContext" optional="true" mayBeNull="true"></param>
        return this._invoke(this._get_path(), 'GetBaanById', false, { bondsnummer: bondsnummer, verenigingId: verenigingId, baanId: baanId, refresh: refresh }, succeededCallback, failedCallback, userContext);
    },
    GetBaanSchemaByVerenigingId: function (bondsnummer, verenigingId, refresh, succeededCallback, failedCallback, userContext) {
        /// <param name="bondsnummer" type="String">System.String</param>
        /// <param name="verenigingId" type="String">System.Guid</param>
        /// <param name="refresh" type="Boolean">System.Boolean</param>
        /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="userContext" optional="true" mayBeNull="true"></param>
        return this._invoke(this._get_path(), 'GetBaanSchemaByVerenigingId', false, { bondsnummer: bondsnummer, verenigingId: verenigingId, refresh: refresh }, succeededCallback, failedCallback, userContext);
    },
    GetBaanSchemaByDate: function (bondsnummer, verenigingId, date, refresh, succeededCallback, failedCallback, userContext) {
        /// <param name="bondsnummer" type="String">System.String</param>
        /// <param name="verenigingId" type="String">System.Guid</param>
        /// <param name="date" type="Date">System.DateTime</param>
        /// <param name="refresh" type="Boolean">System.Boolean</param>
        /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="userContext" optional="true" mayBeNull="true"></param>
        return this._invoke(this._get_path(), 'GetBaanSchemaByDate', false, { bondsnummer: bondsnummer, verenigingId: verenigingId, date: date, refresh: refresh }, succeededCallback, failedCallback, userContext);
    },
    GetBanenByAccommodatieId: function (bondsnummer, verenigingId, accommodatieId, refresh, succeededCallback, failedCallback, userContext) {
        /// <param name="bondsnummer" type="String">System.String</param>
        /// <param name="verenigingId" type="String">System.Guid</param>
        /// <param name="accommodatieId" type="String">System.Guid</param>
        /// <param name="refresh" type="Boolean">System.Boolean</param>
        /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="userContext" optional="true" mayBeNull="true"></param>
        return this._invoke(this._get_path(), 'GetBanenByAccommodatieId', false, { bondsnummer: bondsnummer, verenigingId: verenigingId, accommodatieId: accommodatieId, refresh: refresh }, succeededCallback, failedCallback, userContext);
    },
    GetBaanblokkenByAccommodatieId: function (bondsnummer, verenigingId, accommodatieId, refresh, succeededCallback, failedCallback, userContext) {
        /// <param name="bondsnummer" type="String">System.String</param>
        /// <param name="verenigingId" type="String">System.Guid</param>
        /// <param name="accommodatieId" type="String">System.Guid</param>
        /// <param name="refresh" type="Boolean">System.Boolean</param>
        /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="userContext" optional="true" mayBeNull="true"></param>
        return this._invoke(this._get_path(), 'GetBaanblokkenByAccommodatieId', false, { bondsnummer: bondsnummer, verenigingId: verenigingId, accommodatieId: accommodatieId, refresh: refresh }, succeededCallback, failedCallback, userContext);
    },
    GetBaansoortById: function (bondsnummer, verenigingId, accommodatieId, baansoortId, refresh, succeededCallback, failedCallback, userContext) {
        /// <param name="bondsnummer" type="String">System.String</param>
        /// <param name="verenigingId" type="String">System.Guid</param>
        /// <param name="accommodatieId" type="String">System.Guid</param>
        /// <param name="baansoortId" type="String">System.Guid</param>
        /// <param name="refresh" type="Boolean">System.Boolean</param>
        /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="userContext" optional="true" mayBeNull="true"></param>
        return this._invoke(this._get_path(), 'GetBaansoortById', false, { bondsnummer: bondsnummer, verenigingId: verenigingId, accommodatieId: accommodatieId, baansoortId: baansoortId, refresh: refresh }, succeededCallback, failedCallback, userContext);
    },
    GetBaantypeById: function (bondsnummer, verenigingId, accommodatieId, BaantypeId, refresh, succeededCallback, failedCallback, userContext) {
        /// <param name="bondsnummer" type="String">System.String</param>
        /// <param name="verenigingId" type="String">System.Guid</param>
        /// <param name="accommodatieId" type="String">System.Guid</param>
        /// <param name="BaantypeId" type="String">System.Guid</param>
        /// <param name="refresh" type="Boolean">System.Boolean</param>
        /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="userContext" optional="true" mayBeNull="true"></param>
        return this._invoke(this._get_path(), 'GetBaantypeById', false, { bondsnummer: bondsnummer, verenigingId: verenigingId, accommodatieId: accommodatieId, BaantypeId: BaantypeId, refresh: refresh }, succeededCallback, failedCallback, userContext);
    },
    DeleteReservering: function (bondsnummer, verenigingId, reserveringId, push, succeededCallback, failedCallback, userContext) {
        /// <param name="bondsnummer" type="String">System.String</param>
        /// <param name="verenigingId" type="String">System.Guid</param>
        /// <param name="reserveringId" type="String">System.Guid</param>
        /// <param name="push" type="Boolean">System.Boolean</param>
        /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="userContext" optional="true" mayBeNull="true"></param>
        return this._invoke(this._get_path(), 'DeleteReservering', false, { bondsnummer: bondsnummer, verenigingId: verenigingId, reserveringId: reserveringId, push: push }, succeededCallback, failedCallback, userContext);
    },
    GetGebruikersByReserveringId: function (bondsnummer, verenigingId, reserveringId, refresh, succeededCallback, failedCallback, userContext) {
        /// <param name="bondsnummer" type="String">System.String</param>
        /// <param name="verenigingId" type="String">System.Guid</param>
        /// <param name="reserveringId" type="String">System.Guid</param>
        /// <param name="refresh" type="Boolean">System.Boolean</param>
        /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="userContext" optional="true" mayBeNull="true"></param>
        return this._invoke(this._get_path(), 'GetGebruikersByReserveringId', false, { bondsnummer: bondsnummer, verenigingId: verenigingId, reserveringId: reserveringId, refresh: refresh }, succeededCallback, failedCallback, userContext);
    },
    GetReserveringByReserveringId: function (bondsnummer, verenigingId, reserveringId, refresh, succeededCallback, failedCallback, userContext) {
        /// <param name="bondsnummer" type="String">System.String</param>
        /// <param name="verenigingId" type="String">System.Guid</param>
        /// <param name="reserveringId" type="String">System.Guid</param>
        /// <param name="refresh" type="Boolean">System.Boolean</param>
        /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="userContext" optional="true" mayBeNull="true"></param>
        return this._invoke(this._get_path(), 'GetReserveringByReserveringId', false, { bondsnummer: bondsnummer, verenigingId: verenigingId, reserveringId: reserveringId, refresh: refresh }, succeededCallback, failedCallback, userContext);
    },
    GetReserveringenByBaanId: function (bondsnummer, verenigingId, baanId, refresh, succeededCallback, failedCallback, userContext) {
        /// <param name="bondsnummer" type="String">System.String</param>
        /// <param name="verenigingId" type="String">System.Guid</param>
        /// <param name="baanId" type="String">System.Guid</param>
        /// <param name="refresh" type="Boolean">System.Boolean</param>
        /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="userContext" optional="true" mayBeNull="true"></param>
        return this._invoke(this._get_path(), 'GetReserveringenByBaanId', false, { bondsnummer: bondsnummer, verenigingId: verenigingId, baanId: baanId, refresh: refresh }, succeededCallback, failedCallback, userContext);
    },
    GetReserveringenByDate: function (bondsnummer, verenigingId, date, refresh, succeededCallback, failedCallback, userContext) {
        /// <param name="bondsnummer" type="String">System.String</param>
        /// <param name="verenigingId" type="String">System.Guid</param>
        /// <param name="date" type="Date">System.DateTime</param>
        /// <param name="refresh" type="Boolean">System.Boolean</param>
        /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="userContext" optional="true" mayBeNull="true"></param>
        return this._invoke(this._get_path(), 'GetReserveringenByDate', false, { bondsnummer: bondsnummer, verenigingId: verenigingId, date: date, refresh: refresh }, succeededCallback, failedCallback, userContext);
    },
    GetReserveringenByBondsnummer: function (bondsnummer, verenigingId, nummer, refresh, succeededCallback, failedCallback, userContext) {
        /// <param name="bondsnummer" type="String">System.String</param>
        /// <param name="verenigingId" type="String">System.Guid</param>
        /// <param name="nummer" type="String">System.String</param>
        /// <param name="refresh" type="Boolean">System.Boolean</param>
        /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="userContext" optional="true" mayBeNull="true"></param>
        return this._invoke(this._get_path(), 'GetReserveringenByBondsnummer', false, { bondsnummer: bondsnummer, verenigingId: verenigingId, nummer: nummer, refresh: refresh }, succeededCallback, failedCallback, userContext);
    },
    GetReserveringenByVerenigingId: function (bondsnummer, verenigingId, refresh, succeededCallback, failedCallback, userContext) {
        /// <param name="bondsnummer" type="String">System.String</param>
        /// <param name="verenigingId" type="String">System.Guid</param>
        /// <param name="refresh" type="Boolean">System.Boolean</param>
        /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="userContext" optional="true" mayBeNull="true"></param>
        return this._invoke(this._get_path(), 'GetReserveringenByVerenigingId', false, { bondsnummer: bondsnummer, verenigingId: verenigingId, refresh: refresh }, succeededCallback, failedCallback, userContext);
    },
    AddReservering: function (bondsnummer, verenigingId, baanId, gebruikers, Datum, Tijd, Duur, Soort, final, push, Beschrijving, succeededCallback, failedCallback, userContext) {
        /// <param name="bondsnummer" type="String">System.String</param>
        /// <param name="verenigingId" type="String">System.Guid</param>
        /// <param name="baanId" type="String">System.Guid</param>
        /// <param name="gebruikers" type="Array">System.Guid[]</param>
        /// <param name="Datum" type="Date">System.DateTime</param>
        /// <param name="Tijd" type="schemas.microsoft.com._2003._10.Serialization.duration">System.TimeSpan</param>
        /// <param name="Duur" type="schemas.microsoft.com._2003._10.Serialization.duration">System.TimeSpan</param>
        /// <param name="Soort" type="ClubCloud.Model.ReserveringSoort">ClubCloud.Model.ReserveringSoort</param>
        /// <param name="final" type="Boolean">System.Boolean</param>
        /// <param name="push" type="Boolean">System.Boolean</param>
        /// <param name="Beschrijving" type="String">System.String</param>
        /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="userContext" optional="true" mayBeNull="true"></param>
        return this._invoke(this._get_path(), 'AddReservering', false, { bondsnummer: bondsnummer, verenigingId: verenigingId, baanId: baanId, gebruikers: gebruikers, Datum: Datum, Tijd: Tijd, Duur: Duur, Soort: Soort, final: final, push: push, Beschrijving: Beschrijving }, succeededCallback, failedCallback, userContext);
    },
    UpdateReservering: function (bondsnummer, verenigingId, reservering, final, push, succeededCallback, failedCallback, userContext) {
        /// <param name="bondsnummer" type="String">System.String</param>
        /// <param name="verenigingId" type="String">System.Guid</param>
        /// <param name="reservering" type="ClubCloud.Model.ClubCloud_Reservering">ClubCloud.Model.ClubCloud_Reservering</param>
        /// <param name="final" type="Boolean">System.Boolean</param>
        /// <param name="push" type="Boolean">System.Boolean</param>
        /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="userContext" optional="true" mayBeNull="true"></param>
        return this._invoke(this._get_path(), 'UpdateReservering', false, { bondsnummer: bondsnummer, verenigingId: verenigingId, reservering: reservering, final: final, push: push }, succeededCallback, failedCallback, userContext);
    },
    GetGebruikerByNummer: function (bondsnummer, verenigingId, nummer, refresh, succeededCallback, failedCallback, userContext) {
        /// <param name="bondsnummer" type="String">System.String</param>
        /// <param name="verenigingId" type="String">System.Guid</param>
        /// <param name="nummer" type="String">System.String</param>
        /// <param name="refresh" type="Boolean">System.Boolean</param>
        /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="userContext" optional="true" mayBeNull="true"></param>
        return this._invoke(this._get_path(), 'GetGebruikerByNummer', false, { bondsnummer: bondsnummer, verenigingId: verenigingId, nummer: nummer, refresh: refresh }, succeededCallback, failedCallback, userContext);
    },
    GetFotoById: function (bondsnummer, verenigingId, gebruikerId, refresh, succeededCallback, failedCallback, userContext) {
        /// <param name="bondsnummer" type="String">System.String</param>
        /// <param name="verenigingId" type="String">System.Guid</param>
        /// <param name="gebruikerId" type="String">System.Guid</param>
        /// <param name="refresh" type="Boolean">System.Boolean</param>
        /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="userContext" optional="true" mayBeNull="true"></param>
        return this._invoke(this._get_path(), 'GetFotoById', false, { bondsnummer: bondsnummer, verenigingId: verenigingId, gebruikerId: gebruikerId, refresh: refresh }, succeededCallback, failedCallback, userContext);
    },
    GetGebruikerById: function (bondsnummer, verenigingId, gebruikerId, refresh, succeededCallback, failedCallback, userContext) {
        /// <param name="bondsnummer" type="String">System.String</param>
        /// <param name="verenigingId" type="String">System.Guid</param>
        /// <param name="gebruikerId" type="String">System.Guid</param>
        /// <param name="refresh" type="Boolean">System.Boolean</param>
        /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="userContext" optional="true" mayBeNull="true"></param>
        return this._invoke(this._get_path(), 'GetGebruikerById', false, { bondsnummer: bondsnummer, verenigingId: verenigingId, gebruikerId: gebruikerId, refresh: refresh }, succeededCallback, failedCallback, userContext);
    },
    GetVerenigingByLocation: function (bondsnummer, Latitude, Longitude, refresh, succeededCallback, failedCallback, userContext) {
        /// <param name="bondsnummer" type="String">System.String</param>
        /// <param name="Latitude" type="Number">System.Double</param>
        /// <param name="Longitude" type="Number">System.Double</param>
        /// <param name="refresh" type="Boolean">System.Boolean</param>
        /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="userContext" optional="true" mayBeNull="true"></param>
        return this._invoke(this._get_path(), 'GetVerenigingByLocation', false, { bondsnummer: bondsnummer, Latitude: Latitude, Longitude: Longitude, refresh: refresh }, succeededCallback, failedCallback, userContext);
    },
    GetVerenigingByNummer: function (bondsnummer, verenigingNummer, refresh, succeededCallback, failedCallback, userContext) {
        /// <param name="bondsnummer" type="String">System.String</param>
        /// <param name="verenigingNummer" type="String">System.String</param>
        /// <param name="refresh" type="Boolean">System.Boolean</param>
        /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="userContext" optional="true" mayBeNull="true"></param>
        return this._invoke(this._get_path(), 'GetVerenigingByNummer', false, { bondsnummer: bondsnummer, verenigingNummer: verenigingNummer, refresh: refresh }, succeededCallback, failedCallback, userContext);
    },
    GetVerenigingById: function (bondsnummer, verenigingId, refresh, succeededCallback, failedCallback, userContext) {
        /// <param name="bondsnummer" type="String">System.String</param>
        /// <param name="verenigingId" type="String">System.Guid</param>
        /// <param name="refresh" type="Boolean">System.Boolean</param>
        /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="userContext" optional="true" mayBeNull="true"></param>
        return this._invoke(this._get_path(), 'GetVerenigingById', false, { bondsnummer: bondsnummer, verenigingId: verenigingId, refresh: refresh }, succeededCallback, failedCallback, userContext);
    },
    GetVerenigingAfhangSettings: function (bondsnummer, verenigingId, refresh, succeededCallback, failedCallback, userContext) {
        /// <param name="bondsnummer" type="String">System.String</param>
        /// <param name="verenigingId" type="String">System.Guid</param>
        /// <param name="refresh" type="Boolean">System.Boolean</param>
        /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="userContext" optional="true" mayBeNull="true"></param>
        return this._invoke(this._get_path(), 'GetVerenigingAfhangSettings', false, { bondsnummer: bondsnummer, verenigingId: verenigingId, refresh: refresh }, succeededCallback, failedCallback, userContext);
    },
    GetSponsorenByVerenigingId: function (bondsnummer, verenigingId, refresh, succeededCallback, failedCallback, userContext) {
        /// <param name="bondsnummer" type="String">System.String</param>
        /// <param name="verenigingId" type="String">System.Guid</param>
        /// <param name="refresh" type="Boolean">System.Boolean</param>
        /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="userContext" optional="true" mayBeNull="true"></param>
        return this._invoke(this._get_path(), 'GetSponsorenByVerenigingId', false, { bondsnummer: bondsnummer, verenigingId: verenigingId, refresh: refresh }, succeededCallback, failedCallback, userContext);
    },
    GetSponsorById: function (bondsnummer, verenigingId, sponsorId, refresh, succeededCallback, failedCallback, userContext) {
        /// <param name="bondsnummer" type="String">System.String</param>
        /// <param name="verenigingId" type="String">System.Guid</param>
        /// <param name="sponsorId" type="String">System.Guid</param>
        /// <param name="refresh" type="Boolean">System.Boolean</param>
        /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="userContext" optional="true" mayBeNull="true"></param>
        return this._invoke(this._get_path(), 'GetSponsorById', false, { bondsnummer: bondsnummer, verenigingId: verenigingId, sponsorId: sponsorId, refresh: refresh }, succeededCallback, failedCallback, userContext);
    },
    GetSponsorImageById: function (bondsnummer, verenigingId, afbeeldingId, refresh, succeededCallback, failedCallback, userContext) {
        /// <param name="bondsnummer" type="String">System.String</param>
        /// <param name="verenigingId" type="String">System.Guid</param>
        /// <param name="afbeeldingId" type="String">System.Guid</param>
        /// <param name="refresh" type="Boolean">System.Boolean</param>
        /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="userContext" optional="true" mayBeNull="true"></param>
        return this._invoke(this._get_path(), 'GetSponsorImageById', false, { bondsnummer: bondsnummer, verenigingId: verenigingId, afbeeldingId: afbeeldingId, refresh: refresh }, succeededCallback, failedCallback, userContext);
    },
    GetApplicationInfos: function (succeededCallback, failedCallback, userContext) {
        /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="userContext" optional="true" mayBeNull="true"></param>
        return this._invoke(this._get_path(), 'GetApplicationInfos', false, {}, succeededCallback, failedCallback, userContext);
    },
    GetApplicationVersion: function (applicationInfoId, version, succeededCallback, failedCallback, userContext) {
        /// <param name="applicationInfoId" type="Number">System.Int32</param>
        /// <param name="version" type="String">System.String</param>
        /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="userContext" optional="true" mayBeNull="true"></param>
        return this._invoke(this._get_path(), 'GetApplicationVersion', false, { applicationInfoId: applicationInfoId, version: version }, succeededCallback, failedCallback, userContext);
    },
    GetApplicationProcessorArchitectures: function (applicationVersionId, version, succeededCallback, failedCallback, userContext) {
        /// <param name="applicationVersionId" type="Number">System.Int32</param>
        /// <param name="version" type="String">System.String</param>
        /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
        /// <param name="userContext" optional="true" mayBeNull="true"></param>
        return this._invoke(this._get_path(), 'GetApplicationProcessorArchitectures', false, { applicationVersionId: applicationVersionId, version: version }, succeededCallback, failedCallback, userContext);
    }
}
clubcloud.nl.ClubCloudAfhangen.registerClass('clubcloud.nl.ClubCloudAfhangen', Sys.Net.WebServiceProxy);
clubcloud.nl.ClubCloudAfhangen._staticInstance = new clubcloud.nl.ClubCloudAfhangen();
clubcloud.nl.ClubCloudAfhangen.set_path = function (value) {
    clubcloud.nl.ClubCloudAfhangen._staticInstance.set_path(value);
}
clubcloud.nl.ClubCloudAfhangen.get_path = function () {
    /// <value type="String" mayBeNull="true">The service url.</value>
    return clubcloud.nl.ClubCloudAfhangen._staticInstance.get_path();
}
clubcloud.nl.ClubCloudAfhangen.set_timeout = function (value) {
    clubcloud.nl.ClubCloudAfhangen._staticInstance.set_timeout(value);
}
clubcloud.nl.ClubCloudAfhangen.get_timeout = function () {
    /// <value type="Number">The service timeout.</value>
    return clubcloud.nl.ClubCloudAfhangen._staticInstance.get_timeout();
}
clubcloud.nl.ClubCloudAfhangen.set_defaultUserContext = function (value) {
    clubcloud.nl.ClubCloudAfhangen._staticInstance.set_defaultUserContext(value);
}
clubcloud.nl.ClubCloudAfhangen.get_defaultUserContext = function () {
    /// <value mayBeNull="true">The service default user context.</value>
    return clubcloud.nl.ClubCloudAfhangen._staticInstance.get_defaultUserContext();
}
clubcloud.nl.ClubCloudAfhangen.set_defaultSucceededCallback = function (value) {
    clubcloud.nl.ClubCloudAfhangen._staticInstance.set_defaultSucceededCallback(value);
}
clubcloud.nl.ClubCloudAfhangen.get_defaultSucceededCallback = function () {
    /// <value type="Function" mayBeNull="true">The service default succeeded callback.</value>
    return clubcloud.nl.ClubCloudAfhangen._staticInstance.get_defaultSucceededCallback();
}
clubcloud.nl.ClubCloudAfhangen.set_defaultFailedCallback = function (value) {
    clubcloud.nl.ClubCloudAfhangen._staticInstance.set_defaultFailedCallback(value);
}
clubcloud.nl.ClubCloudAfhangen.get_defaultFailedCallback = function () {
    /// <value type="Function" mayBeNull="true">The service default failed callback.</value>
    return clubcloud.nl.ClubCloudAfhangen._staticInstance.get_defaultFailedCallback();
}
clubcloud.nl.ClubCloudAfhangen.set_enableJsonp = function (value) { clubcloud.nl.ClubCloudAfhangen._staticInstance.set_enableJsonp(value); }
clubcloud.nl.ClubCloudAfhangen.get_enableJsonp = function () {
    /// <value type="Boolean">Specifies whether the service supports JSONP for cross domain calling.</value>
    return clubcloud.nl.ClubCloudAfhangen._staticInstance.get_enableJsonp();
}
clubcloud.nl.ClubCloudAfhangen.set_jsonpCallbackParameter = function (value) { clubcloud.nl.ClubCloudAfhangen._staticInstance.set_jsonpCallbackParameter(value); }
clubcloud.nl.ClubCloudAfhangen.get_jsonpCallbackParameter = function () {
    /// <value type="String">Specifies the parameter name that contains the callback function name for a JSONP request.</value>
    return clubcloud.nl.ClubCloudAfhangen._staticInstance.get_jsonpCallbackParameter();
}
clubcloud.nl.ClubCloudAfhangen.set_path("https://development.clubcloud.nl/_vti_bin/ClubCloud.Afhangen/Afhangen.svc/script");
clubcloud.nl.ClubCloudAfhangen.GetBaanById = function (bondsnummer, verenigingId, baanId, refresh, onSuccess, onFailed, userContext) {
    /// <param name="bondsnummer" type="String">System.String</param>
    /// <param name="verenigingId" type="String">System.Guid</param>
    /// <param name="baanId" type="String">System.Guid</param>
    /// <param name="refresh" type="Boolean">System.Boolean</param>
    /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="userContext" optional="true" mayBeNull="true"></param>
    clubcloud.nl.ClubCloudAfhangen._staticInstance.GetBaanById(bondsnummer, verenigingId, baanId, refresh, onSuccess, onFailed, userContext);
}
clubcloud.nl.ClubCloudAfhangen.GetBaanSchemaByVerenigingId = function (bondsnummer, verenigingId, refresh, onSuccess, onFailed, userContext) {
    /// <param name="bondsnummer" type="String">System.String</param>
    /// <param name="verenigingId" type="String">System.Guid</param>
    /// <param name="refresh" type="Boolean">System.Boolean</param>
    /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="userContext" optional="true" mayBeNull="true"></param>
    clubcloud.nl.ClubCloudAfhangen._staticInstance.GetBaanSchemaByVerenigingId(bondsnummer, verenigingId, refresh, onSuccess, onFailed, userContext);
}
clubcloud.nl.ClubCloudAfhangen.GetBaanSchemaByDate = function (bondsnummer, verenigingId, date, refresh, onSuccess, onFailed, userContext) {
    /// <param name="bondsnummer" type="String">System.String</param>
    /// <param name="verenigingId" type="String">System.Guid</param>
    /// <param name="date" type="Date">System.DateTime</param>
    /// <param name="refresh" type="Boolean">System.Boolean</param>
    /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="userContext" optional="true" mayBeNull="true"></param>
    clubcloud.nl.ClubCloudAfhangen._staticInstance.GetBaanSchemaByDate(bondsnummer, verenigingId, date, refresh, onSuccess, onFailed, userContext);
}
clubcloud.nl.ClubCloudAfhangen.GetBanenByAccommodatieId = function (bondsnummer, verenigingId, accommodatieId, refresh, onSuccess, onFailed, userContext) {
    /// <param name="bondsnummer" type="String">System.String</param>
    /// <param name="verenigingId" type="String">System.Guid</param>
    /// <param name="accommodatieId" type="String">System.Guid</param>
    /// <param name="refresh" type="Boolean">System.Boolean</param>
    /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="userContext" optional="true" mayBeNull="true"></param>
    clubcloud.nl.ClubCloudAfhangen._staticInstance.GetBanenByAccommodatieId(bondsnummer, verenigingId, accommodatieId, refresh, onSuccess, onFailed, userContext);
}
clubcloud.nl.ClubCloudAfhangen.GetBaanblokkenByAccommodatieId = function (bondsnummer, verenigingId, accommodatieId, refresh, onSuccess, onFailed, userContext) {
    /// <param name="bondsnummer" type="String">System.String</param>
    /// <param name="verenigingId" type="String">System.Guid</param>
    /// <param name="accommodatieId" type="String">System.Guid</param>
    /// <param name="refresh" type="Boolean">System.Boolean</param>
    /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="userContext" optional="true" mayBeNull="true"></param>
    clubcloud.nl.ClubCloudAfhangen._staticInstance.GetBaanblokkenByAccommodatieId(bondsnummer, verenigingId, accommodatieId, refresh, onSuccess, onFailed, userContext);
}
clubcloud.nl.ClubCloudAfhangen.GetBaansoortById = function (bondsnummer, verenigingId, accommodatieId, baansoortId, refresh, onSuccess, onFailed, userContext) {
    /// <param name="bondsnummer" type="String">System.String</param>
    /// <param name="verenigingId" type="String">System.Guid</param>
    /// <param name="accommodatieId" type="String">System.Guid</param>
    /// <param name="baansoortId" type="String">System.Guid</param>
    /// <param name="refresh" type="Boolean">System.Boolean</param>
    /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="userContext" optional="true" mayBeNull="true"></param>
    clubcloud.nl.ClubCloudAfhangen._staticInstance.GetBaansoortById(bondsnummer, verenigingId, accommodatieId, baansoortId, refresh, onSuccess, onFailed, userContext);
}
clubcloud.nl.ClubCloudAfhangen.GetBaantypeById = function (bondsnummer, verenigingId, accommodatieId, BaantypeId, refresh, onSuccess, onFailed, userContext) {
    /// <param name="bondsnummer" type="String">System.String</param>
    /// <param name="verenigingId" type="String">System.Guid</param>
    /// <param name="accommodatieId" type="String">System.Guid</param>
    /// <param name="BaantypeId" type="String">System.Guid</param>
    /// <param name="refresh" type="Boolean">System.Boolean</param>
    /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="userContext" optional="true" mayBeNull="true"></param>
    clubcloud.nl.ClubCloudAfhangen._staticInstance.GetBaantypeById(bondsnummer, verenigingId, accommodatieId, BaantypeId, refresh, onSuccess, onFailed, userContext);
}
clubcloud.nl.ClubCloudAfhangen.DeleteReservering = function (bondsnummer, verenigingId, reserveringId, push, onSuccess, onFailed, userContext) {
    /// <param name="bondsnummer" type="String">System.String</param>
    /// <param name="verenigingId" type="String">System.Guid</param>
    /// <param name="reserveringId" type="String">System.Guid</param>
    /// <param name="push" type="Boolean">System.Boolean</param>
    /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="userContext" optional="true" mayBeNull="true"></param>
    clubcloud.nl.ClubCloudAfhangen._staticInstance.DeleteReservering(bondsnummer, verenigingId, reserveringId, push, onSuccess, onFailed, userContext);
}
clubcloud.nl.ClubCloudAfhangen.GetGebruikersByReserveringId = function (bondsnummer, verenigingId, reserveringId, refresh, onSuccess, onFailed, userContext) {
    /// <param name="bondsnummer" type="String">System.String</param>
    /// <param name="verenigingId" type="String">System.Guid</param>
    /// <param name="reserveringId" type="String">System.Guid</param>
    /// <param name="refresh" type="Boolean">System.Boolean</param>
    /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="userContext" optional="true" mayBeNull="true"></param>
    clubcloud.nl.ClubCloudAfhangen._staticInstance.GetGebruikersByReserveringId(bondsnummer, verenigingId, reserveringId, refresh, onSuccess, onFailed, userContext);
}
clubcloud.nl.ClubCloudAfhangen.GetReserveringByReserveringId = function (bondsnummer, verenigingId, reserveringId, refresh, onSuccess, onFailed, userContext) {
    /// <param name="bondsnummer" type="String">System.String</param>
    /// <param name="verenigingId" type="String">System.Guid</param>
    /// <param name="reserveringId" type="String">System.Guid</param>
    /// <param name="refresh" type="Boolean">System.Boolean</param>
    /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="userContext" optional="true" mayBeNull="true"></param>
    clubcloud.nl.ClubCloudAfhangen._staticInstance.GetReserveringByReserveringId(bondsnummer, verenigingId, reserveringId, refresh, onSuccess, onFailed, userContext);
}
clubcloud.nl.ClubCloudAfhangen.GetReserveringenByBaanId = function (bondsnummer, verenigingId, baanId, refresh, onSuccess, onFailed, userContext) {
    /// <param name="bondsnummer" type="String">System.String</param>
    /// <param name="verenigingId" type="String">System.Guid</param>
    /// <param name="baanId" type="String">System.Guid</param>
    /// <param name="refresh" type="Boolean">System.Boolean</param>
    /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="userContext" optional="true" mayBeNull="true"></param>
    clubcloud.nl.ClubCloudAfhangen._staticInstance.GetReserveringenByBaanId(bondsnummer, verenigingId, baanId, refresh, onSuccess, onFailed, userContext);
}
clubcloud.nl.ClubCloudAfhangen.GetReserveringenByDate = function (bondsnummer, verenigingId, date, refresh, onSuccess, onFailed, userContext) {
    /// <param name="bondsnummer" type="String">System.String</param>
    /// <param name="verenigingId" type="String">System.Guid</param>
    /// <param name="date" type="Date">System.DateTime</param>
    /// <param name="refresh" type="Boolean">System.Boolean</param>
    /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="userContext" optional="true" mayBeNull="true"></param>
    clubcloud.nl.ClubCloudAfhangen._staticInstance.GetReserveringenByDate(bondsnummer, verenigingId, date, refresh, onSuccess, onFailed, userContext);
}
clubcloud.nl.ClubCloudAfhangen.GetReserveringenByBondsnummer = function (bondsnummer, verenigingId, nummer, refresh, onSuccess, onFailed, userContext) {
    /// <param name="bondsnummer" type="String">System.String</param>
    /// <param name="verenigingId" type="String">System.Guid</param>
    /// <param name="nummer" type="String">System.String</param>
    /// <param name="refresh" type="Boolean">System.Boolean</param>
    /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="userContext" optional="true" mayBeNull="true"></param>
    clubcloud.nl.ClubCloudAfhangen._staticInstance.GetReserveringenByBondsnummer(bondsnummer, verenigingId, nummer, refresh, onSuccess, onFailed, userContext);
}
clubcloud.nl.ClubCloudAfhangen.GetReserveringenByVerenigingId = function (bondsnummer, verenigingId, refresh, onSuccess, onFailed, userContext) {
    /// <param name="bondsnummer" type="String">System.String</param>
    /// <param name="verenigingId" type="String">System.Guid</param>
    /// <param name="refresh" type="Boolean">System.Boolean</param>
    /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="userContext" optional="true" mayBeNull="true"></param>
    clubcloud.nl.ClubCloudAfhangen._staticInstance.GetReserveringenByVerenigingId(bondsnummer, verenigingId, refresh, onSuccess, onFailed, userContext);
}
clubcloud.nl.ClubCloudAfhangen.AddReservering = function (bondsnummer, verenigingId, baanId, gebruikers, Datum, Tijd, Duur, Soort, final, push, Beschrijving, onSuccess, onFailed, userContext) {
    /// <param name="bondsnummer" type="String">System.String</param>
    /// <param name="verenigingId" type="String">System.Guid</param>
    /// <param name="baanId" type="String">System.Guid</param>
    /// <param name="gebruikers" type="Array">System.Guid[]</param>
    /// <param name="Datum" type="Date">System.DateTime</param>
    /// <param name="Tijd" type="schemas.microsoft.com._2003._10.Serialization.duration">System.TimeSpan</param>
    /// <param name="Duur" type="schemas.microsoft.com._2003._10.Serialization.duration">System.TimeSpan</param>
    /// <param name="Soort" type="ClubCloud.Model.ReserveringSoort">ClubCloud.Model.ReserveringSoort</param>
    /// <param name="final" type="Boolean">System.Boolean</param>
    /// <param name="push" type="Boolean">System.Boolean</param>
    /// <param name="Beschrijving" type="String">System.String</param>
    /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="userContext" optional="true" mayBeNull="true"></param>
    clubcloud.nl.ClubCloudAfhangen._staticInstance.AddReservering(bondsnummer, verenigingId, baanId, gebruikers, Datum, Tijd, Duur, Soort, final, push, Beschrijving, onSuccess, onFailed, userContext);
}
clubcloud.nl.ClubCloudAfhangen.UpdateReservering = function (bondsnummer, verenigingId, reservering, final, push, onSuccess, onFailed, userContext) {
    /// <param name="bondsnummer" type="String">System.String</param>
    /// <param name="verenigingId" type="String">System.Guid</param>
    /// <param name="reservering" type="ClubCloud.Model.ClubCloud_Reservering">ClubCloud.Model.ClubCloud_Reservering</param>
    /// <param name="final" type="Boolean">System.Boolean</param>
    /// <param name="push" type="Boolean">System.Boolean</param>
    /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="userContext" optional="true" mayBeNull="true"></param>
    clubcloud.nl.ClubCloudAfhangen._staticInstance.UpdateReservering(bondsnummer, verenigingId, reservering, final, push, onSuccess, onFailed, userContext);
}
clubcloud.nl.ClubCloudAfhangen.GetGebruikerByNummer = function (bondsnummer, verenigingId, nummer, refresh, onSuccess, onFailed, userContext) {
    /// <param name="bondsnummer" type="String">System.String</param>
    /// <param name="verenigingId" type="String">System.Guid</param>
    /// <param name="nummer" type="String">System.String</param>
    /// <param name="refresh" type="Boolean">System.Boolean</param>
    /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="userContext" optional="true" mayBeNull="true"></param>
    clubcloud.nl.ClubCloudAfhangen._staticInstance.GetGebruikerByNummer(bondsnummer, verenigingId, nummer, refresh, onSuccess, onFailed, userContext);
}
clubcloud.nl.ClubCloudAfhangen.GetFotoById = function (bondsnummer, verenigingId, gebruikerId, refresh, onSuccess, onFailed, userContext) {
    /// <param name="bondsnummer" type="String">System.String</param>
    /// <param name="verenigingId" type="String">System.Guid</param>
    /// <param name="gebruikerId" type="String">System.Guid</param>
    /// <param name="refresh" type="Boolean">System.Boolean</param>
    /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="userContext" optional="true" mayBeNull="true"></param>
    clubcloud.nl.ClubCloudAfhangen._staticInstance.GetFotoById(bondsnummer, verenigingId, gebruikerId, refresh, onSuccess, onFailed, userContext);
}
clubcloud.nl.ClubCloudAfhangen.GetGebruikerById = function (bondsnummer, verenigingId, gebruikerId, refresh, onSuccess, onFailed, userContext) {
    /// <param name="bondsnummer" type="String">System.String</param>
    /// <param name="verenigingId" type="String">System.Guid</param>
    /// <param name="gebruikerId" type="String">System.Guid</param>
    /// <param name="refresh" type="Boolean">System.Boolean</param>
    /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="userContext" optional="true" mayBeNull="true"></param>
    clubcloud.nl.ClubCloudAfhangen._staticInstance.GetGebruikerById(bondsnummer, verenigingId, gebruikerId, refresh, onSuccess, onFailed, userContext);
}
clubcloud.nl.ClubCloudAfhangen.GetVerenigingByLocation = function (bondsnummer, Latitude, Longitude, refresh, onSuccess, onFailed, userContext) {
    /// <param name="bondsnummer" type="String">System.String</param>
    /// <param name="Latitude" type="Number">System.Double</param>
    /// <param name="Longitude" type="Number">System.Double</param>
    /// <param name="refresh" type="Boolean">System.Boolean</param>
    /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="userContext" optional="true" mayBeNull="true"></param>
    clubcloud.nl.ClubCloudAfhangen._staticInstance.GetVerenigingByLocation(bondsnummer, Latitude, Longitude, refresh, onSuccess, onFailed, userContext);
}
clubcloud.nl.ClubCloudAfhangen.GetVerenigingByNummer = function (bondsnummer, verenigingNummer, refresh, onSuccess, onFailed, userContext) {
    /// <param name="bondsnummer" type="String">System.String</param>
    /// <param name="verenigingNummer" type="String">System.String</param>
    /// <param name="refresh" type="Boolean">System.Boolean</param>
    /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="userContext" optional="true" mayBeNull="true"></param>
    clubcloud.nl.ClubCloudAfhangen._staticInstance.GetVerenigingByNummer(bondsnummer, verenigingNummer, refresh, onSuccess, onFailed, userContext);
}
clubcloud.nl.ClubCloudAfhangen.GetVerenigingById = function (bondsnummer, verenigingId, refresh, onSuccess, onFailed, userContext) {
    /// <param name="bondsnummer" type="String">System.String</param>
    /// <param name="verenigingId" type="String">System.Guid</param>
    /// <param name="refresh" type="Boolean">System.Boolean</param>
    /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="userContext" optional="true" mayBeNull="true"></param>
    clubcloud.nl.ClubCloudAfhangen._staticInstance.GetVerenigingById(bondsnummer, verenigingId, refresh, onSuccess, onFailed, userContext);
}
clubcloud.nl.ClubCloudAfhangen.GetVerenigingAfhangSettings = function (bondsnummer, verenigingId, refresh, onSuccess, onFailed, userContext) {
    /// <param name="bondsnummer" type="String">System.String</param>
    /// <param name="verenigingId" type="String">System.Guid</param>
    /// <param name="refresh" type="Boolean">System.Boolean</param>
    /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="userContext" optional="true" mayBeNull="true"></param>
    clubcloud.nl.ClubCloudAfhangen._staticInstance.GetVerenigingAfhangSettings(bondsnummer, verenigingId, refresh, onSuccess, onFailed, userContext);
}
clubcloud.nl.ClubCloudAfhangen.GetSponsorenByVerenigingId = function (bondsnummer, verenigingId, refresh, onSuccess, onFailed, userContext) {
    /// <param name="bondsnummer" type="String">System.String</param>
    /// <param name="verenigingId" type="String">System.Guid</param>
    /// <param name="refresh" type="Boolean">System.Boolean</param>
    /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="userContext" optional="true" mayBeNull="true"></param>
    clubcloud.nl.ClubCloudAfhangen._staticInstance.GetSponsorenByVerenigingId(bondsnummer, verenigingId, refresh, onSuccess, onFailed, userContext);
}
clubcloud.nl.ClubCloudAfhangen.GetSponsorById = function (bondsnummer, verenigingId, sponsorId, refresh, onSuccess, onFailed, userContext) {
    /// <param name="bondsnummer" type="String">System.String</param>
    /// <param name="verenigingId" type="String">System.Guid</param>
    /// <param name="sponsorId" type="String">System.Guid</param>
    /// <param name="refresh" type="Boolean">System.Boolean</param>
    /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="userContext" optional="true" mayBeNull="true"></param>
    clubcloud.nl.ClubCloudAfhangen._staticInstance.GetSponsorById(bondsnummer, verenigingId, sponsorId, refresh, onSuccess, onFailed, userContext);
}
clubcloud.nl.ClubCloudAfhangen.GetSponsorImageById = function (bondsnummer, verenigingId, afbeeldingId, refresh, onSuccess, onFailed, userContext) {
    /// <param name="bondsnummer" type="String">System.String</param>
    /// <param name="verenigingId" type="String">System.Guid</param>
    /// <param name="afbeeldingId" type="String">System.Guid</param>
    /// <param name="refresh" type="Boolean">System.Boolean</param>
    /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="userContext" optional="true" mayBeNull="true"></param>
    clubcloud.nl.ClubCloudAfhangen._staticInstance.GetSponsorImageById(bondsnummer, verenigingId, afbeeldingId, refresh, onSuccess, onFailed, userContext);
}
clubcloud.nl.ClubCloudAfhangen.GetApplicationInfos = function (onSuccess, onFailed, userContext) {
    /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="userContext" optional="true" mayBeNull="true"></param>
    clubcloud.nl.ClubCloudAfhangen._staticInstance.GetApplicationInfos(onSuccess, onFailed, userContext);
}
clubcloud.nl.ClubCloudAfhangen.GetApplicationVersion = function (applicationInfoId, version, onSuccess, onFailed, userContext) {
    /// <param name="applicationInfoId" type="Number">System.Int32</param>
    /// <param name="version" type="String">System.String</param>
    /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="userContext" optional="true" mayBeNull="true"></param>
    clubcloud.nl.ClubCloudAfhangen._staticInstance.GetApplicationVersion(applicationInfoId, version, onSuccess, onFailed, userContext);
}
clubcloud.nl.ClubCloudAfhangen.GetApplicationProcessorArchitectures = function (applicationVersionId, version, onSuccess, onFailed, userContext) {
    /// <param name="applicationVersionId" type="Number">System.Int32</param>
    /// <param name="version" type="String">System.String</param>
    /// <param name="succeededCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="failedCallback" type="Function" optional="true" mayBeNull="true"></param>
    /// <param name="userContext" optional="true" mayBeNull="true"></param>
    clubcloud.nl.ClubCloudAfhangen._staticInstance.GetApplicationProcessorArchitectures(applicationVersionId, version, onSuccess, onFailed, userContext);
}
var gtc = Sys.Net.WebServiceProxy._generateTypedConstructor;
Type.registerNamespace('ClubCloud.Model');
if (typeof (ClubCloud.Model.ClubCloud_Baan) === 'undefined') {
    ClubCloud.Model.ClubCloud_Baan = gtc("ClubCloud_Baan:http://schemas.datacontract.org/2004/07/ClubCloud.Model");
    ClubCloud.Model.ClubCloud_Baan.registerClass('ClubCloud.Model.ClubCloud_Baan');
}
if (typeof (ClubCloud.Model.ClubCloud_Reservering) === 'undefined') {
    ClubCloud.Model.ClubCloud_Reservering = gtc("ClubCloud_Reservering:http://schemas.datacontract.org/2004/07/ClubCloud.Model");
    ClubCloud.Model.ClubCloud_Reservering.registerClass('ClubCloud.Model.ClubCloud_Reservering');
}
if (typeof (ClubCloud.Model.ClubCloud_Accommodatie) === 'undefined') {
    ClubCloud.Model.ClubCloud_Accommodatie = gtc("ClubCloud_Accommodatie:http://schemas.datacontract.org/2004/07/ClubCloud.Model");
    ClubCloud.Model.ClubCloud_Accommodatie.registerClass('ClubCloud.Model.ClubCloud_Accommodatie');
}
if (typeof (ClubCloud.Model.ClubCloud_Baanblok) === 'undefined') {
    ClubCloud.Model.ClubCloud_Baanblok = gtc("ClubCloud_Baanblok:http://schemas.datacontract.org/2004/07/ClubCloud.Model");
    ClubCloud.Model.ClubCloud_Baanblok.registerClass('ClubCloud.Model.ClubCloud_Baanblok');
}
if (typeof (ClubCloud.Model.ClubCloud_Baansoort) === 'undefined') {
    ClubCloud.Model.ClubCloud_Baansoort = gtc("ClubCloud_Baansoort:http://schemas.datacontract.org/2004/07/ClubCloud.Model");
    ClubCloud.Model.ClubCloud_Baansoort.registerClass('ClubCloud.Model.ClubCloud_Baansoort');
}
if (typeof (ClubCloud.Model.ClubCloud_Baantype) === 'undefined') {
    ClubCloud.Model.ClubCloud_Baantype = gtc("ClubCloud_Baantype:http://schemas.datacontract.org/2004/07/ClubCloud.Model");
    ClubCloud.Model.ClubCloud_Baantype.registerClass('ClubCloud.Model.ClubCloud_Baantype');
}
if (typeof (ClubCloud.Model.ClubCloud_Gebruiker) === 'undefined') {
    ClubCloud.Model.ClubCloud_Gebruiker = gtc("ClubCloud_Gebruiker:http://schemas.datacontract.org/2004/07/ClubCloud.Model");
    ClubCloud.Model.ClubCloud_Gebruiker.registerClass('ClubCloud.Model.ClubCloud_Gebruiker');
}
if (typeof (ClubCloud.Model.ClubCloud_Nationaliteit) === 'undefined') {
    ClubCloud.Model.ClubCloud_Nationaliteit = gtc("ClubCloud_Nationaliteit:http://schemas.datacontract.org/2004/07/ClubCloud.Model");
    ClubCloud.Model.ClubCloud_Nationaliteit.registerClass('ClubCloud.Model.ClubCloud_Nationaliteit');
}
if (typeof (ClubCloud.Model.ClubCloud_Setting) === 'undefined') {
    ClubCloud.Model.ClubCloud_Setting = gtc("ClubCloud_Setting:http://schemas.datacontract.org/2004/07/ClubCloud.Model");
    ClubCloud.Model.ClubCloud_Setting.registerClass('ClubCloud.Model.ClubCloud_Setting');
}
if (typeof (ClubCloud.Model.ClubCloud_Vereniging) === 'undefined') {
    ClubCloud.Model.ClubCloud_Vereniging = gtc("ClubCloud_Vereniging:http://schemas.datacontract.org/2004/07/ClubCloud.Model");
    ClubCloud.Model.ClubCloud_Vereniging.registerClass('ClubCloud.Model.ClubCloud_Vereniging');
}
if (typeof (ClubCloud.Model.ClubCloud_Lidmaatschap) === 'undefined') {
    ClubCloud.Model.ClubCloud_Lidmaatschap = gtc("ClubCloud_Lidmaatschap:http://schemas.datacontract.org/2004/07/ClubCloud.Model");
    ClubCloud.Model.ClubCloud_Lidmaatschap.registerClass('ClubCloud.Model.ClubCloud_Lidmaatschap');
}
if (typeof (ClubCloud.Model.ClubCloud_Lidmaatschapsoort) === 'undefined') {
    ClubCloud.Model.ClubCloud_Lidmaatschapsoort = gtc("ClubCloud_Lidmaatschapsoort:http://schemas.datacontract.org/2004/07/ClubCloud.Model");
    ClubCloud.Model.ClubCloud_Lidmaatschapsoort.registerClass('ClubCloud.Model.ClubCloud_Lidmaatschapsoort');
}
if (typeof (ClubCloud.Model.ClubCloud_District) === 'undefined') {
    ClubCloud.Model.ClubCloud_District = gtc("ClubCloud_District:http://schemas.datacontract.org/2004/07/ClubCloud.Model");
    ClubCloud.Model.ClubCloud_District.registerClass('ClubCloud.Model.ClubCloud_District');
}
if (typeof (ClubCloud.Model.ClubCloud_Address) === 'undefined') {
    ClubCloud.Model.ClubCloud_Address = gtc("ClubCloud_Address:http://schemas.datacontract.org/2004/07/ClubCloud.Model");
    ClubCloud.Model.ClubCloud_Address.registerClass('ClubCloud.Model.ClubCloud_Address');
}
if (typeof (ClubCloud.Model.ClubCloud_Functionaris) === 'undefined') {
    ClubCloud.Model.ClubCloud_Functionaris = gtc("ClubCloud_Functionaris:http://schemas.datacontract.org/2004/07/ClubCloud.Model");
    ClubCloud.Model.ClubCloud_Functionaris.registerClass('ClubCloud.Model.ClubCloud_Functionaris');
}
if (typeof (ClubCloud.Model.ClubCloud_Baanschema) === 'undefined') {
    ClubCloud.Model.ClubCloud_Baanschema = gtc("ClubCloud_Baanschema:http://schemas.datacontract.org/2004/07/ClubCloud.Model");
    ClubCloud.Model.ClubCloud_Baanschema.registerClass('ClubCloud.Model.ClubCloud_Baanschema');
}
if (typeof (ClubCloud.Model.ClubCloud_Regio) === 'undefined') {
    ClubCloud.Model.ClubCloud_Regio = gtc("ClubCloud_Regio:http://schemas.datacontract.org/2004/07/ClubCloud.Model");
    ClubCloud.Model.ClubCloud_Regio.registerClass('ClubCloud.Model.ClubCloud_Regio');
}
if (typeof (ClubCloud.Model.ClubCloud_BaanSpeciaal) === 'undefined') {
    ClubCloud.Model.ClubCloud_BaanSpeciaal = gtc("ClubCloud_BaanSpeciaal:http://schemas.datacontract.org/2004/07/ClubCloud.Model");
    ClubCloud.Model.ClubCloud_BaanSpeciaal.registerClass('ClubCloud.Model.ClubCloud_BaanSpeciaal');
}
if (typeof (ClubCloud.Model.ClubCloud_Bestuursorgaan) === 'undefined') {
    ClubCloud.Model.ClubCloud_Bestuursorgaan = gtc("ClubCloud_Bestuursorgaan:http://schemas.datacontract.org/2004/07/ClubCloud.Model");
    ClubCloud.Model.ClubCloud_Bestuursorgaan.registerClass('ClubCloud.Model.ClubCloud_Bestuursorgaan');
}
if (typeof (ClubCloud.Model.ClubCloud_Functie) === 'undefined') {
    ClubCloud.Model.ClubCloud_Functie = gtc("ClubCloud_Functie:http://schemas.datacontract.org/2004/07/ClubCloud.Model");
    ClubCloud.Model.ClubCloud_Functie.registerClass('ClubCloud.Model.ClubCloud_Functie');
}
if (typeof (ClubCloud.Model.ClubCloud_Land) === 'undefined') {
    ClubCloud.Model.ClubCloud_Land = gtc("ClubCloud_Land:http://schemas.datacontract.org/2004/07/ClubCloud.Model");
    ClubCloud.Model.ClubCloud_Land.registerClass('ClubCloud.Model.ClubCloud_Land');
}
if (typeof (ClubCloud.Model.ClubCloud_Rechtsvorm) === 'undefined') {
    ClubCloud.Model.ClubCloud_Rechtsvorm = gtc("ClubCloud_Rechtsvorm:http://schemas.datacontract.org/2004/07/ClubCloud.Model");
    ClubCloud.Model.ClubCloud_Rechtsvorm.registerClass('ClubCloud.Model.ClubCloud_Rechtsvorm');
}
if (typeof (ClubCloud.Model.ClubCloud_Baantoplaag) === 'undefined') {
    ClubCloud.Model.ClubCloud_Baantoplaag = gtc("ClubCloud_Baantoplaag:http://schemas.datacontract.org/2004/07/ClubCloud.Model");
    ClubCloud.Model.ClubCloud_Baantoplaag.registerClass('ClubCloud.Model.ClubCloud_Baantoplaag');
}
if (typeof (ClubCloud.Model.ClubCloud_Afhang) === 'undefined') {
    ClubCloud.Model.ClubCloud_Afhang = gtc("ClubCloud_Afhang:http://schemas.datacontract.org/2004/07/ClubCloud.Model");
    ClubCloud.Model.ClubCloud_Afhang.registerClass('ClubCloud.Model.ClubCloud_Afhang');
}
if (typeof (ClubCloud.Model.ClubCloud_Profiel) === 'undefined') {
    ClubCloud.Model.ClubCloud_Profiel = gtc("ClubCloud_Profiel:http://schemas.datacontract.org/2004/07/ClubCloud.Model");
    ClubCloud.Model.ClubCloud_Profiel.registerClass('ClubCloud.Model.ClubCloud_Profiel');
}
if (typeof (ClubCloud.Model.ClubCloud_Sponsor) === 'undefined') {
    ClubCloud.Model.ClubCloud_Sponsor = gtc("ClubCloud_Sponsor:http://schemas.datacontract.org/2004/07/ClubCloud.Model");
    ClubCloud.Model.ClubCloud_Sponsor.registerClass('ClubCloud.Model.ClubCloud_Sponsor');
}
if (typeof (ClubCloud.Model.ClubCloud_Sponsor_Afbeelding) === 'undefined') {
    ClubCloud.Model.ClubCloud_Sponsor_Afbeelding = gtc("ClubCloud_Sponsor_Afbeelding:http://schemas.datacontract.org/2004/07/ClubCloud.Model");
    ClubCloud.Model.ClubCloud_Sponsor_Afbeelding.registerClass('ClubCloud.Model.ClubCloud_Sponsor_Afbeelding');
}
Type.registerNamespace('System.Data.Entity.Spatial');
if (typeof (System.Data.Entity.Spatial.DbGeography) === 'undefined') {
    System.Data.Entity.Spatial.DbGeography = gtc("DbGeography:http://schemas.datacontract.org/2004/07/System.Data.Entity.Spatial");
    System.Data.Entity.Spatial.DbGeography.registerClass('System.Data.Entity.Spatial.DbGeography');
}
if (typeof (System.Data.Entity.Spatial.DbGeographyWellKnownValue) === 'undefined') {
    System.Data.Entity.Spatial.DbGeographyWellKnownValue = gtc("DbGeographyWellKnownValue:http://schemas.datacontract.org/2004/07/System.Data.Entity.Spatial");
    System.Data.Entity.Spatial.DbGeographyWellKnownValue.registerClass('System.Data.Entity.Spatial.DbGeographyWellKnownValue');
}
if (typeof (ClubCloud.Model.ClubCloud_Bouwaard) === 'undefined') {
    ClubCloud.Model.ClubCloud_Bouwaard = gtc("ClubCloud_Bouwaard:http://schemas.datacontract.org/2004/07/ClubCloud.Model");
    ClubCloud.Model.ClubCloud_Bouwaard.registerClass('ClubCloud.Model.ClubCloud_Bouwaard');
}
if (typeof (ClubCloud.Model.ClubCloud_Foto) === 'undefined') {
    ClubCloud.Model.ClubCloud_Foto = gtc("ClubCloud_Foto:http://schemas.datacontract.org/2004/07/ClubCloud.Model");
    ClubCloud.Model.ClubCloud_Foto.registerClass('ClubCloud.Model.ClubCloud_Foto');
}
Type.registerNamespace('schemas.microsoft.com._2003._10.Serialization');
if (typeof (schemas.microsoft.com._2003._10.Serialization.duration) === 'undefined') {
    schemas.microsoft.com._2003._10.Serialization.duration = gtc("duration:http://schemas.microsoft.com/2003/10/Serialization/");
    schemas.microsoft.com._2003._10.Serialization.duration.registerClass('schemas.microsoft.com._2003._10.Serialization.duration');
}
if (typeof (ClubCloud.Model.ApplicationInfo) === 'undefined') {
    ClubCloud.Model.ApplicationInfo = gtc("ApplicationInfo:http://schemas.datacontract.org/2004/07/ClubCloud.Model");
    ClubCloud.Model.ApplicationInfo.registerClass('ClubCloud.Model.ApplicationInfo');
}
if (typeof (ClubCloud.Model.ApplicationOperationRecord) === 'undefined') {
    ClubCloud.Model.ApplicationOperationRecord = gtc("ApplicationOperationRecord:http://schemas.datacontract.org/2004/07/ClubCloud.Model");
    ClubCloud.Model.ApplicationOperationRecord.registerClass('ClubCloud.Model.ApplicationOperationRecord');
}
if (typeof (ClubCloud.Model.ApplicationVersion) === 'undefined') {
    ClubCloud.Model.ApplicationVersion = gtc("ApplicationVersion:http://schemas.datacontract.org/2004/07/ClubCloud.Model");
    ClubCloud.Model.ApplicationVersion.registerClass('ClubCloud.Model.ApplicationVersion');
}
if (typeof (ClubCloud.Model.ApplicationProcessorArchitecture) === 'undefined') {
    ClubCloud.Model.ApplicationProcessorArchitecture = gtc("ApplicationProcessorArchitecture:http://schemas.datacontract.org/2004/07/ClubCloud.Model");
    ClubCloud.Model.ApplicationProcessorArchitecture.registerClass('ClubCloud.Model.ApplicationProcessorArchitecture');
}
if (typeof (ClubCloud.Model.ActiefSoort) === 'undefined') {
    ClubCloud.Model.ActiefSoort = function () { throw Error.invalidOperation(); }
    ClubCloud.Model.ActiefSoort.prototype = { Onbekend: 0, Actief: 1, Inactief: 2 }
    ClubCloud.Model.ActiefSoort.registerEnum('ClubCloud.Model.ActiefSoort', true);
}
if (typeof (ClubCloud.Model.ReserveringSoort) === 'undefined') {
    ClubCloud.Model.ReserveringSoort = function () { throw Error.invalidOperation(); }
    ClubCloud.Model.ReserveringSoort.prototype = { Onbekend: 0, Afhangen: 1, Les: 2, Competitie: 3, Toernooi: 4, Evenement: 5, Onderhoud: 6, Seizoen: 7, Mobiel: 8, Overig: 9 }
    ClubCloud.Model.ReserveringSoort.registerEnum('ClubCloud.Model.ReserveringSoort', true);
}
if (typeof (ClubCloud.Model.GeslachtSoort) === 'undefined') {
    ClubCloud.Model.GeslachtSoort = function () { throw Error.invalidOperation(); }
    ClubCloud.Model.GeslachtSoort.prototype = { Onbekend: 0, Man: 1, Vrouw: 2 }
    ClubCloud.Model.GeslachtSoort.registerEnum('ClubCloud.Model.GeslachtSoort', true);
}
if (typeof (ClubCloud.Model.Facebook) === 'undefined') {
    ClubCloud.Model.Facebook = function () { throw Error.invalidOperation(); }
    ClubCloud.Model.Facebook.prototype = { None: 0 }
    ClubCloud.Model.Facebook.registerEnum('ClubCloud.Model.Facebook', true);
}
if (typeof (ClubCloud.Model.Financieel) === 'undefined') {
    ClubCloud.Model.Financieel = function () { throw Error.invalidOperation(); }
    ClubCloud.Model.Financieel.prototype = { None: 0, Machtiging: 1, iDEAL: 2, PayPal: 4, Factuur: 8 }
    ClubCloud.Model.Financieel.registerEnum('ClubCloud.Model.Financieel', true);
}
if (typeof (ClubCloud.Model.Privacy) === 'undefined') {
    ClubCloud.Model.Privacy = function () { throw Error.invalidOperation(); }
    ClubCloud.Model.Privacy.prototype = { None: 0, leden_club: 1, leden_clubcloud: 2, competitie_club: 4, competitie_leden: 8, toernooi_club: 16, toernooi_leden: 32 }
    ClubCloud.Model.Privacy.registerEnum('ClubCloud.Model.Privacy', true);
}
if (typeof (ClubCloud.Model.Twitter) === 'undefined') {
    ClubCloud.Model.Twitter = function () { throw Error.invalidOperation(); }
    ClubCloud.Model.Twitter.prototype = { None: 0, Tweet: 1, Succes: 2, Competitie: 4, Toernooi: 8 }
    ClubCloud.Model.Twitter.registerEnum('ClubCloud.Model.Twitter', true);
}
if (typeof (ClubCloud.Model.AddressSoort) === 'undefined') {
    ClubCloud.Model.AddressSoort = function () { throw Error.invalidOperation(); }
    ClubCloud.Model.AddressSoort.prototype = { Bezoekadres: 0, Postadres: 1, Onbekend: 0 }
    ClubCloud.Model.AddressSoort.registerEnum('ClubCloud.Model.AddressSoort', true);
}
if (typeof (ClubCloud.Model.DaysSoort) === 'undefined') {
    ClubCloud.Model.DaysSoort = function () { throw Error.invalidOperation(); }
    ClubCloud.Model.DaysSoort.prototype = { maandag: 0, dinsdag: 1, woensdag: 3, donderdag: 4, vrijdag: 5, zaterdag: 6, zondag: 0 }
    ClubCloud.Model.DaysSoort.registerEnum('ClubCloud.Model.DaysSoort', true);
}
if (typeof (ClubCloud.Model.MonthSoort) === 'undefined') {
    ClubCloud.Model.MonthSoort = function () { throw Error.invalidOperation(); }
    ClubCloud.Model.MonthSoort.prototype = { januari: 0, februari: 1, maart: 3, april: 4, mei: 5, juni: 6, juli: 7, augustus: 8, september: 9, oktober: 10, november: 11, december: 12, Onbekend: 0 }
    ClubCloud.Model.MonthSoort.registerEnum('ClubCloud.Model.MonthSoort', true);
}
if (typeof (ClubCloud.Model.BaanSoort) === 'undefined') {
    ClubCloud.Model.BaanSoort = function () { throw Error.invalidOperation(); }
    ClubCloud.Model.BaanSoort.prototype = { Rodebaan: 0, Oranjebaan: 1, Minibaan: 3, Oefenmuur: 4, Playground: 5, Onbekend: 0 }
    ClubCloud.Model.BaanSoort.registerEnum('ClubCloud.Model.BaanSoort', true);
}
if (typeof (ClubCloud.Model.ApplicationStatus) === 'undefined') {
    ClubCloud.Model.ApplicationStatus = function () { throw Error.invalidOperation(); }
    ClubCloud.Model.ApplicationStatus.prototype = { NA: 0, NotSubmitted: 1, EmptyDescription: 2, NotPublished: 3, Published: 4, PublicStoreApp: 5 }
    ClubCloud.Model.ApplicationStatus.registerEnum('ClubCloud.Model.ApplicationStatus', true);
}
if (typeof (ClubCloud.Model.ApplicationOperationType) === 'undefined') {
    ClubCloud.Model.ApplicationOperationType = function () { throw Error.invalidOperation(); }
    ClubCloud.Model.ApplicationOperationType.prototype = { NA: -1, Install: 1, Update: 2, Uninstall: 3, RequestToInstall: 4, RequestToUninstall: 5 }
    ClubCloud.Model.ApplicationOperationType.registerEnum('ClubCloud.Model.ApplicationOperationType', true);
}
if (typeof (ClubCloud.Model.ProcessorArchitecture) === 'undefined') {
    ClubCloud.Model.ProcessorArchitecture = function () { throw Error.invalidOperation(); }
    ClubCloud.Model.ProcessorArchitecture.prototype = { x86: 0, x64: 9, ARM: 2, Neutual: 11, Unknown: 65535 }
    ClubCloud.Model.ProcessorArchitecture.registerEnum('ClubCloud.Model.ProcessorArchitecture', true);
}
