
 
namespace ClubCloud.Service
{
    using ClubCloud.Model;
    using System;
    using System.Collections.Generic;
    using System.ServiceModel;
    using System.ServiceModel.Description;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    
    internal partial interface IClubCloudApplicationService
    {
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Setting))]
        ClubCloud_Setting  GetSettingById(int Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Setting))]
        List<ClubCloud_Setting> GetSettings(bool refresh = false, ClubCloud_Setting settings = null);
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Setting))]
    	ClubCloud_Setting SetSetting(ClubCloud_Setting entity, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
    	bool DeleteSetting(ClubCloud_Setting entity, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	bool DeleteSettingById(int Id, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Setting))]
    	[ServiceKnownType(typeof(ClubCloud_Setting_View))]
    	ClubCloud_Setting_View GetSettingsByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Setting))]
    	List<ClubCloud_Setting> GetSettingsBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null);
    
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Setting))]
    	[ServiceKnownType(typeof(ClubCloud_Gebruiker))]
    	ClubCloud_Gebruiker GetGebruikerForSetting(ClubCloud_Setting entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Setting))]
    	[ServiceKnownType(typeof(ClubCloud_Gebruiker))]
    	bool SetGebruikerForSetting(ClubCloud_Gebruiker Gebruiker, ClubCloud_Setting entity , bool refresh = false, ClubCloud_Setting settings = null);
    
    
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Gebruiker))]
    	ClubCloud_Gebruiker GetGebruikerForSettingById(int Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Setting))]
    	[ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	ClubCloud_Vereniging GetVerenigingForSetting(ClubCloud_Setting entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Setting))]
    	[ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	bool SetVerenigingForSetting(ClubCloud_Vereniging Vereniging, ClubCloud_Setting entity , bool refresh = false, ClubCloud_Setting settings = null);
    
    
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	ClubCloud_Vereniging GetVerenigingForSettingById(int Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	    [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
        ClubCloud_Vereniging  GetVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
        List<ClubCloud_Vereniging> GetVerenigingen(bool refresh = false, ClubCloud_Setting settings = null);
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	ClubCloud_Vereniging SetVereniging(ClubCloud_Vereniging entity, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
    	bool DeleteVereniging(ClubCloud_Vereniging entity, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	bool DeleteVerenigingById(System.Guid Id, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	[ServiceKnownType(typeof(ClubCloud_Vereniging_View))]
    	ClubCloud_Vereniging_View GetVerenigingenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	List<ClubCloud_Vereniging> GetVerenigingenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null);
    
    	
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Vereniging))]
        [ServiceKnownType(typeof(ClubCloud_Functionaris))]
    	List<ClubCloud_Functionaris> GetFunctionarissenForVereniging(ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	[ServiceKnownType(typeof(ClubCloud_Functionaris))]
    	bool SetFunctionarissenForVereniging(List<ClubCloud_Functionaris> Functionarissen, ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null);
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	[ServiceKnownType(typeof(ClubCloud_Functionaris))]
    	List<ClubCloud_Functionaris> GetFunctionarissenForVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    		
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Vereniging))]
        [ServiceKnownType(typeof(ClubCloud_Lidmaatschap))]
    	List<ClubCloud_Lidmaatschap> GetLidmaatschappenForVereniging(ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	[ServiceKnownType(typeof(ClubCloud_Lidmaatschap))]
    	bool SetLidmaatschappenForVereniging(List<ClubCloud_Lidmaatschap> Lidmaatschappen, ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null);
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	[ServiceKnownType(typeof(ClubCloud_Lidmaatschap))]
    	List<ClubCloud_Lidmaatschap> GetLidmaatschappenForVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    		
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Vereniging))]
        [ServiceKnownType(typeof(ClubCloud_Bestuursorgaan))]
    	List<ClubCloud_Bestuursorgaan> GetBestuursorganenForVereniging(ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	[ServiceKnownType(typeof(ClubCloud_Bestuursorgaan))]
    	bool SetBestuursorganenForVereniging(List<ClubCloud_Bestuursorgaan> Bestuursorganen, ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null);
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	[ServiceKnownType(typeof(ClubCloud_Bestuursorgaan))]
    	List<ClubCloud_Bestuursorgaan> GetBestuursorganenForVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    	
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	[ServiceKnownType(typeof(ClubCloud_District))]
    	ClubCloud_District GetDistrictForVereniging(ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	[ServiceKnownType(typeof(ClubCloud_District))]
    	bool SetDistrictForVereniging(ClubCloud_District District, ClubCloud_Vereniging entity , bool refresh = false, ClubCloud_Setting settings = null);
    
    
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_District))]
    	ClubCloud_District GetDistrictForVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	[ServiceKnownType(typeof(ClubCloud_Rechtsvorm))]
    	ClubCloud_Rechtsvorm GetRechtsvormForVereniging(ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	[ServiceKnownType(typeof(ClubCloud_Rechtsvorm))]
    	bool SetRechtsvormForVereniging(ClubCloud_Rechtsvorm Rechtsvorm, ClubCloud_Vereniging entity , bool refresh = false, ClubCloud_Setting settings = null);
    
    
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Rechtsvorm))]
    	ClubCloud_Rechtsvorm GetRechtsvormForVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	[ServiceKnownType(typeof(ClubCloud_Accommodatie))]
    	ClubCloud_Accommodatie GetAccommodatieForVereniging(ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	[ServiceKnownType(typeof(ClubCloud_Accommodatie))]
    	bool SetAccommodatieForVereniging(ClubCloud_Accommodatie Accommodatie, ClubCloud_Vereniging entity , bool refresh = false, ClubCloud_Setting settings = null);
    
    
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Accommodatie))]
    	ClubCloud_Accommodatie GetAccommodatieForVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    		
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Vereniging))]
        [ServiceKnownType(typeof(ClubCloud_Address))]
    	List<ClubCloud_Address> GetAddressenForVereniging(ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	[ServiceKnownType(typeof(ClubCloud_Address))]
    	bool SetAddressenForVereniging(List<ClubCloud_Address> Addressen, ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null);
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	[ServiceKnownType(typeof(ClubCloud_Address))]
    	List<ClubCloud_Address> GetAddressenForVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    	
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	[ServiceKnownType(typeof(ClubCloud_Regio))]
    	ClubCloud_Regio GetRegioForVereniging(ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	[ServiceKnownType(typeof(ClubCloud_Regio))]
    	bool SetRegioForVereniging(ClubCloud_Regio Regio, ClubCloud_Vereniging entity , bool refresh = false, ClubCloud_Setting settings = null);
    
    
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Regio))]
    	ClubCloud_Regio GetRegioForVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    		
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Vereniging))]
        [ServiceKnownType(typeof(ClubCloud_Gebruiker))]
    	List<ClubCloud_Gebruiker> GetGebruikersForVereniging(ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	[ServiceKnownType(typeof(ClubCloud_Gebruiker))]
    	bool SetGebruikersForVereniging(List<ClubCloud_Gebruiker> Gebruikers, ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null);
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	[ServiceKnownType(typeof(ClubCloud_Gebruiker))]
    	List<ClubCloud_Gebruiker> GetGebruikersForVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    		
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Vereniging))]
        [ServiceKnownType(typeof(ClubCloud_Afhang))]
    	List<ClubCloud_Afhang> GetAfhangenForVereniging(ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	[ServiceKnownType(typeof(ClubCloud_Afhang))]
    	bool SetAfhangenForVereniging(List<ClubCloud_Afhang> Afhangen, ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null);
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	[ServiceKnownType(typeof(ClubCloud_Afhang))]
    	List<ClubCloud_Afhang> GetAfhangenForVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    		
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Vereniging))]
        [ServiceKnownType(typeof(ClubCloud_Sponsor))]
    	List<ClubCloud_Sponsor> GetSponsorenForVereniging(ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	[ServiceKnownType(typeof(ClubCloud_Sponsor))]
    	bool SetSponsorenForVereniging(List<ClubCloud_Sponsor> Sponsoren, ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null);
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	[ServiceKnownType(typeof(ClubCloud_Sponsor))]
    	List<ClubCloud_Sponsor> GetSponsorenForVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    		
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Vereniging))]
        [ServiceKnownType(typeof(ClubCloud_Setting))]
    	List<ClubCloud_Setting> GetSettingsForVereniging(ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	[ServiceKnownType(typeof(ClubCloud_Setting))]
    	bool SetSettingsForVereniging(List<ClubCloud_Setting> Settings, ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null);
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	[ServiceKnownType(typeof(ClubCloud_Setting))]
    	List<ClubCloud_Setting> GetSettingsForVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    		
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Vereniging))]
        [ServiceKnownType(typeof(ClubCloud_Baanschema))]
    	List<ClubCloud_Baanschema> GetBaanschemasForVereniging(ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	[ServiceKnownType(typeof(ClubCloud_Baanschema))]
    	bool SetBaanschemasForVereniging(List<ClubCloud_Baanschema> Baanschemas, ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null);
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	[ServiceKnownType(typeof(ClubCloud_Baanschema))]
    	List<ClubCloud_Baanschema> GetBaanschemasForVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    		
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Vereniging))]
        [ServiceKnownType(typeof(ClubCloud_Lidmaatschapsoort))]
    	List<ClubCloud_Lidmaatschapsoort> GetLidmaatschapsoortenForVereniging(ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	[ServiceKnownType(typeof(ClubCloud_Lidmaatschapsoort))]
    	bool SetLidmaatschapsoortenForVereniging(List<ClubCloud_Lidmaatschapsoort> Lidmaatschapsoorten, ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null);
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	[ServiceKnownType(typeof(ClubCloud_Lidmaatschapsoort))]
    	List<ClubCloud_Lidmaatschapsoort> GetLidmaatschapsoortenForVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    	    [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Gebruiker))]
        ClubCloud_Gebruiker  GetGebruikerById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Gebruiker))]
        List<ClubCloud_Gebruiker> GetGebruikers(bool refresh = false, ClubCloud_Setting settings = null);
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Gebruiker))]
    	ClubCloud_Gebruiker SetGebruiker(ClubCloud_Gebruiker entity, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
    	bool DeleteGebruiker(ClubCloud_Gebruiker entity, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	bool DeleteGebruikerById(System.Guid Id, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Gebruiker))]
    	[ServiceKnownType(typeof(ClubCloud_Gebruiker_View))]
    	ClubCloud_Gebruiker_View GetGebruikersByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Gebruiker))]
    	List<ClubCloud_Gebruiker> GetGebruikersBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null);
    
    	
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Gebruiker))]
        [ServiceKnownType(typeof(ClubCloud_Functionaris))]
    	List<ClubCloud_Functionaris> GetFunctionarissenForGebruiker(ClubCloud_Gebruiker entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Gebruiker))]
    	[ServiceKnownType(typeof(ClubCloud_Functionaris))]
    	bool SetFunctionarissenForGebruiker(List<ClubCloud_Functionaris> Functionarissen, ClubCloud_Gebruiker entity, bool refresh = false, ClubCloud_Setting settings = null);
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Gebruiker))]
    	[ServiceKnownType(typeof(ClubCloud_Functionaris))]
    	List<ClubCloud_Functionaris> GetFunctionarissenForGebruikerById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    		
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Gebruiker))]
        [ServiceKnownType(typeof(ClubCloud_Lidmaatschap))]
    	List<ClubCloud_Lidmaatschap> GetLidmaatschappenForGebruiker(ClubCloud_Gebruiker entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Gebruiker))]
    	[ServiceKnownType(typeof(ClubCloud_Lidmaatschap))]
    	bool SetLidmaatschappenForGebruiker(List<ClubCloud_Lidmaatschap> Lidmaatschappen, ClubCloud_Gebruiker entity, bool refresh = false, ClubCloud_Setting settings = null);
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Gebruiker))]
    	[ServiceKnownType(typeof(ClubCloud_Lidmaatschap))]
    	List<ClubCloud_Lidmaatschap> GetLidmaatschappenForGebruikerById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    		
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Gebruiker))]
        [ServiceKnownType(typeof(ClubCloud_Address))]
    	List<ClubCloud_Address> GetAddressenForGebruiker(ClubCloud_Gebruiker entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Gebruiker))]
    	[ServiceKnownType(typeof(ClubCloud_Address))]
    	bool SetAddressenForGebruiker(List<ClubCloud_Address> Addressen, ClubCloud_Gebruiker entity, bool refresh = false, ClubCloud_Setting settings = null);
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Gebruiker))]
    	[ServiceKnownType(typeof(ClubCloud_Address))]
    	List<ClubCloud_Address> GetAddressenForGebruikerById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    	
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Gebruiker))]
    	[ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	ClubCloud_Vereniging GetVerenigingForGebruiker(ClubCloud_Gebruiker entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Gebruiker))]
    	[ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	bool SetVerenigingForGebruiker(ClubCloud_Vereniging Vereniging, ClubCloud_Gebruiker entity , bool refresh = false, ClubCloud_Setting settings = null);
    
    
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	ClubCloud_Vereniging GetVerenigingForGebruikerById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    		
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Gebruiker))]
        [ServiceKnownType(typeof(ClubCloud_Profiel))]
    	List<ClubCloud_Profiel> GetProfielenForGebruiker(ClubCloud_Gebruiker entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Gebruiker))]
    	[ServiceKnownType(typeof(ClubCloud_Profiel))]
    	bool SetProfielenForGebruiker(List<ClubCloud_Profiel> Profielen, ClubCloud_Gebruiker entity, bool refresh = false, ClubCloud_Setting settings = null);
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Gebruiker))]
    	[ServiceKnownType(typeof(ClubCloud_Profiel))]
    	List<ClubCloud_Profiel> GetProfielenForGebruikerById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    		
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Gebruiker))]
        [ServiceKnownType(typeof(ClubCloud_Setting))]
    	List<ClubCloud_Setting> GetSettingsForGebruiker(ClubCloud_Gebruiker entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Gebruiker))]
    	[ServiceKnownType(typeof(ClubCloud_Setting))]
    	bool SetSettingsForGebruiker(List<ClubCloud_Setting> Settings, ClubCloud_Gebruiker entity, bool refresh = false, ClubCloud_Setting settings = null);
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Gebruiker))]
    	[ServiceKnownType(typeof(ClubCloud_Setting))]
    	List<ClubCloud_Setting> GetSettingsForGebruikerById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    	
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Gebruiker))]
    	[ServiceKnownType(typeof(ClubCloud_Nationaliteit))]
    	ClubCloud_Nationaliteit GetNationaliteitForGebruiker(ClubCloud_Gebruiker entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Gebruiker))]
    	[ServiceKnownType(typeof(ClubCloud_Nationaliteit))]
    	bool SetNationaliteitForGebruiker(ClubCloud_Nationaliteit Nationaliteit, ClubCloud_Gebruiker entity , bool refresh = false, ClubCloud_Setting settings = null);
    
    
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Nationaliteit))]
    	ClubCloud_Nationaliteit GetNationaliteitForGebruikerById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	    [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Accommodatie))]
        ClubCloud_Accommodatie  GetAccommodatieById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Accommodatie))]
        List<ClubCloud_Accommodatie> GetAccommodaties(bool refresh = false, ClubCloud_Setting settings = null);
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Accommodatie))]
    	ClubCloud_Accommodatie SetAccommodatie(ClubCloud_Accommodatie entity, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
    	bool DeleteAccommodatie(ClubCloud_Accommodatie entity, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	bool DeleteAccommodatieById(System.Guid Id, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Accommodatie))]
    	[ServiceKnownType(typeof(ClubCloud_Accommodatie_View))]
    	ClubCloud_Accommodatie_View GetAccommodatiesByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Accommodatie))]
    	List<ClubCloud_Accommodatie> GetAccommodatiesBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null);
    
    	
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Accommodatie))]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	List<ClubCloud_Vereniging> GetVerenigingenForAccommodatie(ClubCloud_Accommodatie entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Accommodatie))]
    	[ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	bool SetVerenigingenForAccommodatie(List<ClubCloud_Vereniging> Verenigingen, ClubCloud_Accommodatie entity, bool refresh = false, ClubCloud_Setting settings = null);
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Accommodatie))]
    	[ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	List<ClubCloud_Vereniging> GetVerenigingenForAccommodatieById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    	
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Accommodatie))]
    	[ServiceKnownType(typeof(ClubCloud_District))]
    	ClubCloud_District GetDistrictForAccommodatie(ClubCloud_Accommodatie entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Accommodatie))]
    	[ServiceKnownType(typeof(ClubCloud_District))]
    	bool SetDistrictForAccommodatie(ClubCloud_District District, ClubCloud_Accommodatie entity , bool refresh = false, ClubCloud_Setting settings = null);
    
    
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_District))]
    	ClubCloud_District GetDistrictForAccommodatieById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Accommodatie))]
    	[ServiceKnownType(typeof(ClubCloud_Regio))]
    	ClubCloud_Regio GetRegioForAccommodatie(ClubCloud_Accommodatie entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Accommodatie))]
    	[ServiceKnownType(typeof(ClubCloud_Regio))]
    	bool SetRegioForAccommodatie(ClubCloud_Regio Regio, ClubCloud_Accommodatie entity , bool refresh = false, ClubCloud_Setting settings = null);
    
    
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Regio))]
    	ClubCloud_Regio GetRegioForAccommodatieById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    		
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Accommodatie))]
        [ServiceKnownType(typeof(ClubCloud_Baanblok))]
    	List<ClubCloud_Baanblok> GetBaanblokkenForAccommodatie(ClubCloud_Accommodatie entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Accommodatie))]
    	[ServiceKnownType(typeof(ClubCloud_Baanblok))]
    	bool SetBaanblokkenForAccommodatie(List<ClubCloud_Baanblok> Baanblokken, ClubCloud_Accommodatie entity, bool refresh = false, ClubCloud_Setting settings = null);
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Accommodatie))]
    	[ServiceKnownType(typeof(ClubCloud_Baanblok))]
    	List<ClubCloud_Baanblok> GetBaanblokkenForAccommodatieById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    		
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Accommodatie))]
        [ServiceKnownType(typeof(ClubCloud_Baan))]
    	List<ClubCloud_Baan> GetBanenForAccommodatie(ClubCloud_Accommodatie entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Accommodatie))]
    	[ServiceKnownType(typeof(ClubCloud_Baan))]
    	bool SetBanenForAccommodatie(List<ClubCloud_Baan> Banen, ClubCloud_Accommodatie entity, bool refresh = false, ClubCloud_Setting settings = null);
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Accommodatie))]
    	[ServiceKnownType(typeof(ClubCloud_Baan))]
    	List<ClubCloud_Baan> GetBanenForAccommodatieById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    		
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Accommodatie))]
        [ServiceKnownType(typeof(ClubCloud_BaanSpeciaal))]
    	List<ClubCloud_BaanSpeciaal> GetBanenSpeciaalForAccommodatie(ClubCloud_Accommodatie entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Accommodatie))]
    	[ServiceKnownType(typeof(ClubCloud_BaanSpeciaal))]
    	bool SetBanenSpeciaalForAccommodatie(List<ClubCloud_BaanSpeciaal> BanenSpeciaal, ClubCloud_Accommodatie entity, bool refresh = false, ClubCloud_Setting settings = null);
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Accommodatie))]
    	[ServiceKnownType(typeof(ClubCloud_BaanSpeciaal))]
    	List<ClubCloud_BaanSpeciaal> GetBanenSpeciaalForAccommodatieById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    		
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Accommodatie))]
        [ServiceKnownType(typeof(ClubCloud_Address))]
    	List<ClubCloud_Address> GetAddressenForAccommodatie(ClubCloud_Accommodatie entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Accommodatie))]
    	[ServiceKnownType(typeof(ClubCloud_Address))]
    	bool SetAddressenForAccommodatie(List<ClubCloud_Address> Addressen, ClubCloud_Accommodatie entity, bool refresh = false, ClubCloud_Setting settings = null);
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Accommodatie))]
    	[ServiceKnownType(typeof(ClubCloud_Address))]
    	List<ClubCloud_Address> GetAddressenForAccommodatieById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    	    [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Nationaliteit))]
        ClubCloud_Nationaliteit  GetNationaliteitById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Nationaliteit))]
        List<ClubCloud_Nationaliteit> GetNationaliteiten(bool refresh = false, ClubCloud_Setting settings = null);
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Nationaliteit))]
    	ClubCloud_Nationaliteit SetNationaliteit(ClubCloud_Nationaliteit entity, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
    	bool DeleteNationaliteit(ClubCloud_Nationaliteit entity, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	bool DeleteNationaliteitById(System.Guid Id, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Nationaliteit))]
    	[ServiceKnownType(typeof(ClubCloud_Nationaliteit_View))]
    	ClubCloud_Nationaliteit_View GetNationaliteitenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Nationaliteit))]
    	List<ClubCloud_Nationaliteit> GetNationaliteitenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null);
    
    	
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Nationaliteit))]
        [ServiceKnownType(typeof(ClubCloud_Gebruiker))]
    	List<ClubCloud_Gebruiker> GetGebruikersForNationaliteit(ClubCloud_Nationaliteit entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Nationaliteit))]
    	[ServiceKnownType(typeof(ClubCloud_Gebruiker))]
    	bool SetGebruikersForNationaliteit(List<ClubCloud_Gebruiker> Gebruikers, ClubCloud_Nationaliteit entity, bool refresh = false, ClubCloud_Setting settings = null);
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Nationaliteit))]
    	[ServiceKnownType(typeof(ClubCloud_Gebruiker))]
    	List<ClubCloud_Gebruiker> GetGebruikersForNationaliteitById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    	    [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_District))]
        ClubCloud_District  GetDistrictById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_District))]
        List<ClubCloud_District> GetDistricten(bool refresh = false, ClubCloud_Setting settings = null);
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_District))]
    	ClubCloud_District SetDistrict(ClubCloud_District entity, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
    	bool DeleteDistrict(ClubCloud_District entity, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	bool DeleteDistrictById(System.Guid Id, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_District))]
    	[ServiceKnownType(typeof(ClubCloud_District_View))]
    	ClubCloud_District_View GetDistrictenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_District))]
    	List<ClubCloud_District> GetDistrictenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null);
    
    	
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_District))]
        [ServiceKnownType(typeof(ClubCloud_Functionaris))]
    	List<ClubCloud_Functionaris> GetFunctionarissenForDistrict(ClubCloud_District entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_District))]
    	[ServiceKnownType(typeof(ClubCloud_Functionaris))]
    	bool SetFunctionarissenForDistrict(List<ClubCloud_Functionaris> Functionarissen, ClubCloud_District entity, bool refresh = false, ClubCloud_Setting settings = null);
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_District))]
    	[ServiceKnownType(typeof(ClubCloud_Functionaris))]
    	List<ClubCloud_Functionaris> GetFunctionarissenForDistrictById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    		
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_District))]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	List<ClubCloud_Vereniging> GetVerenigingenForDistrict(ClubCloud_District entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_District))]
    	[ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	bool SetVerenigingenForDistrict(List<ClubCloud_Vereniging> Verenigingen, ClubCloud_District entity, bool refresh = false, ClubCloud_Setting settings = null);
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_District))]
    	[ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	List<ClubCloud_Vereniging> GetVerenigingenForDistrictById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    	
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_District))]
    	[ServiceKnownType(typeof(ClubCloud_Regio))]
    	ClubCloud_Regio GetRegioForDistrict(ClubCloud_District entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_District))]
    	[ServiceKnownType(typeof(ClubCloud_Regio))]
    	bool SetRegioForDistrict(ClubCloud_Regio Regio, ClubCloud_District entity , bool refresh = false, ClubCloud_Setting settings = null);
    
    
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Regio))]
    	ClubCloud_Regio GetRegioForDistrictById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    		
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_District))]
        [ServiceKnownType(typeof(ClubCloud_Accommodatie))]
    	List<ClubCloud_Accommodatie> GetAccommodatiesForDistrict(ClubCloud_District entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_District))]
    	[ServiceKnownType(typeof(ClubCloud_Accommodatie))]
    	bool SetAccommodatiesForDistrict(List<ClubCloud_Accommodatie> Accommodaties, ClubCloud_District entity, bool refresh = false, ClubCloud_Setting settings = null);
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_District))]
    	[ServiceKnownType(typeof(ClubCloud_Accommodatie))]
    	List<ClubCloud_Accommodatie> GetAccommodatiesForDistrictById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    	    [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Functie))]
        ClubCloud_Functie  GetFunctieById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Functie))]
        List<ClubCloud_Functie> GetFuncties(bool refresh = false, ClubCloud_Setting settings = null);
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Functie))]
    	ClubCloud_Functie SetFunctie(ClubCloud_Functie entity, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
    	bool DeleteFunctie(ClubCloud_Functie entity, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	bool DeleteFunctieById(System.Guid Id, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Functie))]
    	[ServiceKnownType(typeof(ClubCloud_Functie_View))]
    	ClubCloud_Functie_View GetFunctiesByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Functie))]
    	List<ClubCloud_Functie> GetFunctiesBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null);
    
    	
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Functie))]
        [ServiceKnownType(typeof(ClubCloud_Functionaris))]
    	List<ClubCloud_Functionaris> GetFunctionarissenForFunctie(ClubCloud_Functie entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Functie))]
    	[ServiceKnownType(typeof(ClubCloud_Functionaris))]
    	bool SetFunctionarissenForFunctie(List<ClubCloud_Functionaris> Functionarissen, ClubCloud_Functie entity, bool refresh = false, ClubCloud_Setting settings = null);
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Functie))]
    	[ServiceKnownType(typeof(ClubCloud_Functionaris))]
    	List<ClubCloud_Functionaris> GetFunctionarissenForFunctieById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    	    [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Lidmaatschap))]
        ClubCloud_Lidmaatschap  GetLidmaatschapById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Lidmaatschap))]
        List<ClubCloud_Lidmaatschap> GetLidmaatschappen(bool refresh = false, ClubCloud_Setting settings = null);
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Lidmaatschap))]
    	ClubCloud_Lidmaatschap SetLidmaatschap(ClubCloud_Lidmaatschap entity, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
    	bool DeleteLidmaatschap(ClubCloud_Lidmaatschap entity, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	bool DeleteLidmaatschapById(System.Guid Id, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Lidmaatschap))]
    	[ServiceKnownType(typeof(ClubCloud_Lidmaatschap_View))]
    	ClubCloud_Lidmaatschap_View GetLidmaatschappenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Lidmaatschap))]
    	List<ClubCloud_Lidmaatschap> GetLidmaatschappenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null);
    
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Lidmaatschap))]
    	[ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	ClubCloud_Vereniging GetVerenigingForLidmaatschap(ClubCloud_Lidmaatschap entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Lidmaatschap))]
    	[ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	bool SetVerenigingForLidmaatschap(ClubCloud_Vereniging Vereniging, ClubCloud_Lidmaatschap entity , bool refresh = false, ClubCloud_Setting settings = null);
    
    
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	ClubCloud_Vereniging GetVerenigingForLidmaatschapById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Lidmaatschap))]
    	[ServiceKnownType(typeof(ClubCloud_Gebruiker))]
    	ClubCloud_Gebruiker GetGebruikerForLidmaatschap(ClubCloud_Lidmaatschap entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Lidmaatschap))]
    	[ServiceKnownType(typeof(ClubCloud_Gebruiker))]
    	bool SetGebruikerForLidmaatschap(ClubCloud_Gebruiker Gebruiker, ClubCloud_Lidmaatschap entity , bool refresh = false, ClubCloud_Setting settings = null);
    
    
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Gebruiker))]
    	ClubCloud_Gebruiker GetGebruikerForLidmaatschapById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Lidmaatschap))]
    	[ServiceKnownType(typeof(ClubCloud_Lidmaatschapsoort))]
    	ClubCloud_Lidmaatschapsoort GetLidmaatschapsoortForLidmaatschap(ClubCloud_Lidmaatschap entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Lidmaatschap))]
    	[ServiceKnownType(typeof(ClubCloud_Lidmaatschapsoort))]
    	bool SetLidmaatschapsoortForLidmaatschap(ClubCloud_Lidmaatschapsoort Lidmaatschapsoort, ClubCloud_Lidmaatschap entity , bool refresh = false, ClubCloud_Setting settings = null);
    
    
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Lidmaatschapsoort))]
    	ClubCloud_Lidmaatschapsoort GetLidmaatschapsoortForLidmaatschapById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	    [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Profiel))]
        ClubCloud_Profiel  GetProfielById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Profiel))]
        List<ClubCloud_Profiel> GetProfielen(bool refresh = false, ClubCloud_Setting settings = null);
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Profiel))]
    	ClubCloud_Profiel SetProfiel(ClubCloud_Profiel entity, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
    	bool DeleteProfiel(ClubCloud_Profiel entity, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	bool DeleteProfielById(System.Guid Id, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Profiel))]
    	[ServiceKnownType(typeof(ClubCloud_Profiel_View))]
    	ClubCloud_Profiel_View GetProfielenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Profiel))]
    	List<ClubCloud_Profiel> GetProfielenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null);
    
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Profiel))]
    	[ServiceKnownType(typeof(ClubCloud_Gebruiker))]
    	ClubCloud_Gebruiker GetGebruikerForProfiel(ClubCloud_Profiel entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Profiel))]
    	[ServiceKnownType(typeof(ClubCloud_Gebruiker))]
    	bool SetGebruikerForProfiel(ClubCloud_Gebruiker Gebruiker, ClubCloud_Profiel entity , bool refresh = false, ClubCloud_Setting settings = null);
    
    
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Gebruiker))]
    	ClubCloud_Gebruiker GetGebruikerForProfielById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	    [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Functionaris))]
        ClubCloud_Functionaris  GetFunctionarisById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Functionaris))]
        List<ClubCloud_Functionaris> GetFunctionarissen(bool refresh = false, ClubCloud_Setting settings = null);
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Functionaris))]
    	ClubCloud_Functionaris SetFunctionaris(ClubCloud_Functionaris entity, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
    	bool DeleteFunctionaris(ClubCloud_Functionaris entity, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	bool DeleteFunctionarisById(System.Guid Id, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Functionaris))]
    	[ServiceKnownType(typeof(ClubCloud_Functionaris_View))]
    	ClubCloud_Functionaris_View GetFunctionarissenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Functionaris))]
    	List<ClubCloud_Functionaris> GetFunctionarissenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null);
    
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Functionaris))]
    	[ServiceKnownType(typeof(ClubCloud_Functie))]
    	ClubCloud_Functie GetFunctieForFunctionaris(ClubCloud_Functionaris entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Functionaris))]
    	[ServiceKnownType(typeof(ClubCloud_Functie))]
    	bool SetFunctieForFunctionaris(ClubCloud_Functie Functie, ClubCloud_Functionaris entity , bool refresh = false, ClubCloud_Setting settings = null);
    
    
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Functie))]
    	ClubCloud_Functie GetFunctieForFunctionarisById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Functionaris))]
    	[ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	ClubCloud_Vereniging GetVerenigingForFunctionaris(ClubCloud_Functionaris entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Functionaris))]
    	[ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	bool SetVerenigingForFunctionaris(ClubCloud_Vereniging Vereniging, ClubCloud_Functionaris entity , bool refresh = false, ClubCloud_Setting settings = null);
    
    
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	ClubCloud_Vereniging GetVerenigingForFunctionarisById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Functionaris))]
    	[ServiceKnownType(typeof(ClubCloud_Gebruiker))]
    	ClubCloud_Gebruiker GetGebruikerForFunctionaris(ClubCloud_Functionaris entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Functionaris))]
    	[ServiceKnownType(typeof(ClubCloud_Gebruiker))]
    	bool SetGebruikerForFunctionaris(ClubCloud_Gebruiker Gebruiker, ClubCloud_Functionaris entity , bool refresh = false, ClubCloud_Setting settings = null);
    
    
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Gebruiker))]
    	ClubCloud_Gebruiker GetGebruikerForFunctionarisById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Functionaris))]
    	[ServiceKnownType(typeof(ClubCloud_District))]
    	ClubCloud_District GetDistrictForFunctionaris(ClubCloud_Functionaris entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Functionaris))]
    	[ServiceKnownType(typeof(ClubCloud_District))]
    	bool SetDistrictForFunctionaris(ClubCloud_District District, ClubCloud_Functionaris entity , bool refresh = false, ClubCloud_Setting settings = null);
    
    
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_District))]
    	ClubCloud_District GetDistrictForFunctionarisById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Functionaris))]
    	[ServiceKnownType(typeof(ClubCloud_Bestuursorgaan))]
    	ClubCloud_Bestuursorgaan GetBestuursorgaanForFunctionaris(ClubCloud_Functionaris entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Functionaris))]
    	[ServiceKnownType(typeof(ClubCloud_Bestuursorgaan))]
    	bool SetBestuursorgaanForFunctionaris(ClubCloud_Bestuursorgaan Bestuursorgaan, ClubCloud_Functionaris entity , bool refresh = false, ClubCloud_Setting settings = null);
    
    
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Bestuursorgaan))]
    	ClubCloud_Bestuursorgaan GetBestuursorgaanForFunctionarisById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	    [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Bestuursorgaan))]
        ClubCloud_Bestuursorgaan  GetBestuursorgaanById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Bestuursorgaan))]
        List<ClubCloud_Bestuursorgaan> GetBestuursorganen(bool refresh = false, ClubCloud_Setting settings = null);
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Bestuursorgaan))]
    	ClubCloud_Bestuursorgaan SetBestuursorgaan(ClubCloud_Bestuursorgaan entity, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
    	bool DeleteBestuursorgaan(ClubCloud_Bestuursorgaan entity, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	bool DeleteBestuursorgaanById(System.Guid Id, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Bestuursorgaan))]
    	[ServiceKnownType(typeof(ClubCloud_Bestuursorgaan_View))]
    	ClubCloud_Bestuursorgaan_View GetBestuursorganenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Bestuursorgaan))]
    	List<ClubCloud_Bestuursorgaan> GetBestuursorganenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null);
    
    	
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Bestuursorgaan))]
        [ServiceKnownType(typeof(ClubCloud_Functionaris))]
    	List<ClubCloud_Functionaris> GetFunctionarissenForBestuursorgaan(ClubCloud_Bestuursorgaan entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Bestuursorgaan))]
    	[ServiceKnownType(typeof(ClubCloud_Functionaris))]
    	bool SetFunctionarissenForBestuursorgaan(List<ClubCloud_Functionaris> Functionarissen, ClubCloud_Bestuursorgaan entity, bool refresh = false, ClubCloud_Setting settings = null);
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Bestuursorgaan))]
    	[ServiceKnownType(typeof(ClubCloud_Functionaris))]
    	List<ClubCloud_Functionaris> GetFunctionarissenForBestuursorgaanById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    	
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Bestuursorgaan))]
    	[ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	ClubCloud_Vereniging GetVerenigingForBestuursorgaan(ClubCloud_Bestuursorgaan entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Bestuursorgaan))]
    	[ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	bool SetVerenigingForBestuursorgaan(ClubCloud_Vereniging Vereniging, ClubCloud_Bestuursorgaan entity , bool refresh = false, ClubCloud_Setting settings = null);
    
    
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	ClubCloud_Vereniging GetVerenigingForBestuursorgaanById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	    [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Rechtsvorm))]
        ClubCloud_Rechtsvorm  GetRechtsvormById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Rechtsvorm))]
        List<ClubCloud_Rechtsvorm> GetRechtsvormen(bool refresh = false, ClubCloud_Setting settings = null);
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Rechtsvorm))]
    	ClubCloud_Rechtsvorm SetRechtsvorm(ClubCloud_Rechtsvorm entity, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
    	bool DeleteRechtsvorm(ClubCloud_Rechtsvorm entity, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	bool DeleteRechtsvormById(System.Guid Id, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Rechtsvorm))]
    	[ServiceKnownType(typeof(ClubCloud_Rechtsvorm_View))]
    	ClubCloud_Rechtsvorm_View GetRechtsvormenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Rechtsvorm))]
    	List<ClubCloud_Rechtsvorm> GetRechtsvormenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null);
    
    	
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Rechtsvorm))]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	List<ClubCloud_Vereniging> GetVerenigingenForRechtsvorm(ClubCloud_Rechtsvorm entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Rechtsvorm))]
    	[ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	bool SetVerenigingenForRechtsvorm(List<ClubCloud_Vereniging> Verenigingen, ClubCloud_Rechtsvorm entity, bool refresh = false, ClubCloud_Setting settings = null);
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Rechtsvorm))]
    	[ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	List<ClubCloud_Vereniging> GetVerenigingenForRechtsvormById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    	    [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Address))]
        ClubCloud_Address  GetAddressById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Address))]
        List<ClubCloud_Address> GetAddressen(bool refresh = false, ClubCloud_Setting settings = null);
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Address))]
    	ClubCloud_Address SetAddress(ClubCloud_Address entity, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
    	bool DeleteAddress(ClubCloud_Address entity, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	bool DeleteAddressById(System.Guid Id, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Address))]
    	[ServiceKnownType(typeof(ClubCloud_Address_View))]
    	ClubCloud_Address_View GetAddressenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Address))]
    	List<ClubCloud_Address> GetAddressenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null);
    
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Address))]
    	[ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	ClubCloud_Vereniging GetVerenigingForAddress(ClubCloud_Address entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Address))]
    	[ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	bool SetVerenigingForAddress(ClubCloud_Vereniging Vereniging, ClubCloud_Address entity , bool refresh = false, ClubCloud_Setting settings = null);
    
    
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	ClubCloud_Vereniging GetVerenigingForAddressById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Address))]
    	[ServiceKnownType(typeof(ClubCloud_Gebruiker))]
    	ClubCloud_Gebruiker GetGebruikerForAddress(ClubCloud_Address entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Address))]
    	[ServiceKnownType(typeof(ClubCloud_Gebruiker))]
    	bool SetGebruikerForAddress(ClubCloud_Gebruiker Gebruiker, ClubCloud_Address entity , bool refresh = false, ClubCloud_Setting settings = null);
    
    
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Gebruiker))]
    	ClubCloud_Gebruiker GetGebruikerForAddressById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Address))]
    	[ServiceKnownType(typeof(ClubCloud_Regio))]
    	ClubCloud_Regio GetRegioForAddress(ClubCloud_Address entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Address))]
    	[ServiceKnownType(typeof(ClubCloud_Regio))]
    	bool SetRegioForAddress(ClubCloud_Regio Regio, ClubCloud_Address entity , bool refresh = false, ClubCloud_Setting settings = null);
    
    
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Regio))]
    	ClubCloud_Regio GetRegioForAddressById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Address))]
    	[ServiceKnownType(typeof(ClubCloud_Accommodatie))]
    	ClubCloud_Accommodatie GetAccommodatieForAddress(ClubCloud_Address entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Address))]
    	[ServiceKnownType(typeof(ClubCloud_Accommodatie))]
    	bool SetAccommodatieForAddress(ClubCloud_Accommodatie Accommodatie, ClubCloud_Address entity , bool refresh = false, ClubCloud_Setting settings = null);
    
    
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Accommodatie))]
    	ClubCloud_Accommodatie GetAccommodatieForAddressById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Address))]
    	[ServiceKnownType(typeof(ClubCloud_Land))]
    	ClubCloud_Land GetLandForAddress(ClubCloud_Address entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Address))]
    	[ServiceKnownType(typeof(ClubCloud_Land))]
    	bool SetLandForAddress(ClubCloud_Land Land, ClubCloud_Address entity , bool refresh = false, ClubCloud_Setting settings = null);
    
    
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Land))]
    	ClubCloud_Land GetLandForAddressById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	    [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Regio))]
        ClubCloud_Regio  GetRegioById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Regio))]
        List<ClubCloud_Regio> GetRegios(bool refresh = false, ClubCloud_Setting settings = null);
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Regio))]
    	ClubCloud_Regio SetRegio(ClubCloud_Regio entity, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
    	bool DeleteRegio(ClubCloud_Regio entity, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	bool DeleteRegioById(System.Guid Id, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Regio))]
    	[ServiceKnownType(typeof(ClubCloud_Regio_View))]
    	ClubCloud_Regio_View GetRegiosByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Regio))]
    	List<ClubCloud_Regio> GetRegiosBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null);
    
    	
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Regio))]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	List<ClubCloud_Vereniging> GetVerenigingenForRegio(ClubCloud_Regio entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Regio))]
    	[ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	bool SetVerenigingenForRegio(List<ClubCloud_Vereniging> Verenigingen, ClubCloud_Regio entity, bool refresh = false, ClubCloud_Setting settings = null);
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Regio))]
    	[ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	List<ClubCloud_Vereniging> GetVerenigingenForRegioById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    		
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Regio))]
        [ServiceKnownType(typeof(ClubCloud_District))]
    	List<ClubCloud_District> GetDistrictenForRegio(ClubCloud_Regio entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Regio))]
    	[ServiceKnownType(typeof(ClubCloud_District))]
    	bool SetDistrictenForRegio(List<ClubCloud_District> Districten, ClubCloud_Regio entity, bool refresh = false, ClubCloud_Setting settings = null);
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Regio))]
    	[ServiceKnownType(typeof(ClubCloud_District))]
    	List<ClubCloud_District> GetDistrictenForRegioById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    		
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Regio))]
        [ServiceKnownType(typeof(ClubCloud_Accommodatie))]
    	List<ClubCloud_Accommodatie> GetAccommodatiesForRegio(ClubCloud_Regio entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Regio))]
    	[ServiceKnownType(typeof(ClubCloud_Accommodatie))]
    	bool SetAccommodatiesForRegio(List<ClubCloud_Accommodatie> Accommodaties, ClubCloud_Regio entity, bool refresh = false, ClubCloud_Setting settings = null);
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Regio))]
    	[ServiceKnownType(typeof(ClubCloud_Accommodatie))]
    	List<ClubCloud_Accommodatie> GetAccommodatiesForRegioById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    		
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Regio))]
        [ServiceKnownType(typeof(ClubCloud_Address))]
    	List<ClubCloud_Address> GetAddressenForRegio(ClubCloud_Regio entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Regio))]
    	[ServiceKnownType(typeof(ClubCloud_Address))]
    	bool SetAddressenForRegio(List<ClubCloud_Address> Addressen, ClubCloud_Regio entity, bool refresh = false, ClubCloud_Setting settings = null);
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Regio))]
    	[ServiceKnownType(typeof(ClubCloud_Address))]
    	List<ClubCloud_Address> GetAddressenForRegioById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    	    [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baansoort))]
        ClubCloud_Baansoort  GetBaansoortById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baansoort))]
        List<ClubCloud_Baansoort> GetBaansoorten(bool refresh = false, ClubCloud_Setting settings = null);
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baansoort))]
    	ClubCloud_Baansoort SetBaansoort(ClubCloud_Baansoort entity, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
    	bool DeleteBaansoort(ClubCloud_Baansoort entity, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	bool DeleteBaansoortById(System.Guid Id, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baansoort))]
    	[ServiceKnownType(typeof(ClubCloud_Baansoort_View))]
    	ClubCloud_Baansoort_View GetBaansoortenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Baansoort))]
    	List<ClubCloud_Baansoort> GetBaansoortenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null);
    
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baansoort))]
    	[ServiceKnownType(typeof(ClubCloud_Baantype))]
    	ClubCloud_Baantype GetBaantypeForBaansoort(ClubCloud_Baansoort entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baansoort))]
    	[ServiceKnownType(typeof(ClubCloud_Baantype))]
    	bool SetBaantypeForBaansoort(ClubCloud_Baantype Baantype, ClubCloud_Baansoort entity , bool refresh = false, ClubCloud_Setting settings = null);
    
    
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baantype))]
    	ClubCloud_Baantype GetBaantypeForBaansoortById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    		
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Baansoort))]
        [ServiceKnownType(typeof(ClubCloud_Baanblok))]
    	List<ClubCloud_Baanblok> GetBaanblokkenForBaansoort(ClubCloud_Baansoort entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baansoort))]
    	[ServiceKnownType(typeof(ClubCloud_Baanblok))]
    	bool SetBaanblokkenForBaansoort(List<ClubCloud_Baanblok> Baanblokken, ClubCloud_Baansoort entity, bool refresh = false, ClubCloud_Setting settings = null);
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baansoort))]
    	[ServiceKnownType(typeof(ClubCloud_Baanblok))]
    	List<ClubCloud_Baanblok> GetBaanblokkenForBaansoortById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    	    [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baantype))]
        ClubCloud_Baantype  GetBaantypeById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baantype))]
        List<ClubCloud_Baantype> GetBaantypes(bool refresh = false, ClubCloud_Setting settings = null);
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baantype))]
    	ClubCloud_Baantype SetBaantype(ClubCloud_Baantype entity, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
    	bool DeleteBaantype(ClubCloud_Baantype entity, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	bool DeleteBaantypeById(System.Guid Id, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baantype))]
    	[ServiceKnownType(typeof(ClubCloud_Baantype_View))]
    	ClubCloud_Baantype_View GetBaantypesByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Baantype))]
    	List<ClubCloud_Baantype> GetBaantypesBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null);
    
    	
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Baantype))]
        [ServiceKnownType(typeof(ClubCloud_Baansoort))]
    	List<ClubCloud_Baansoort> GetBaansoortenForBaantype(ClubCloud_Baantype entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baantype))]
    	[ServiceKnownType(typeof(ClubCloud_Baansoort))]
    	bool SetBaansoortenForBaantype(List<ClubCloud_Baansoort> Baansoorten, ClubCloud_Baantype entity, bool refresh = false, ClubCloud_Setting settings = null);
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baantype))]
    	[ServiceKnownType(typeof(ClubCloud_Baansoort))]
    	List<ClubCloud_Baansoort> GetBaansoortenForBaantypeById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    		
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Baantype))]
        [ServiceKnownType(typeof(ClubCloud_Baanblok))]
    	List<ClubCloud_Baanblok> GetBaanblokkenForBaantype(ClubCloud_Baantype entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baantype))]
    	[ServiceKnownType(typeof(ClubCloud_Baanblok))]
    	bool SetBaanblokkenForBaantype(List<ClubCloud_Baanblok> Baanblokken, ClubCloud_Baantype entity, bool refresh = false, ClubCloud_Setting settings = null);
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baantype))]
    	[ServiceKnownType(typeof(ClubCloud_Baanblok))]
    	List<ClubCloud_Baanblok> GetBaanblokkenForBaantypeById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    	    [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baan))]
        ClubCloud_Baan  GetBaanById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baan))]
        List<ClubCloud_Baan> GetBanen(bool refresh = false, ClubCloud_Setting settings = null);
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baan))]
    	ClubCloud_Baan SetBaan(ClubCloud_Baan entity, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
    	bool DeleteBaan(ClubCloud_Baan entity, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	bool DeleteBaanById(System.Guid Id, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baan))]
    	[ServiceKnownType(typeof(ClubCloud_Baan_View))]
    	ClubCloud_Baan_View GetBanenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Baan))]
    	List<ClubCloud_Baan> GetBanenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null);
    
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baan))]
    	[ServiceKnownType(typeof(ClubCloud_Baanblok))]
    	ClubCloud_Baanblok GetBaanblokForBaan(ClubCloud_Baan entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baan))]
    	[ServiceKnownType(typeof(ClubCloud_Baanblok))]
    	bool SetBaanblokForBaan(ClubCloud_Baanblok Baanblok, ClubCloud_Baan entity , bool refresh = false, ClubCloud_Setting settings = null);
    
    
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baanblok))]
    	ClubCloud_Baanblok GetBaanblokForBaanById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baan))]
    	[ServiceKnownType(typeof(ClubCloud_Accommodatie))]
    	ClubCloud_Accommodatie GetAccommodatieForBaan(ClubCloud_Baan entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baan))]
    	[ServiceKnownType(typeof(ClubCloud_Accommodatie))]
    	bool SetAccommodatieForBaan(ClubCloud_Accommodatie Accommodatie, ClubCloud_Baan entity , bool refresh = false, ClubCloud_Setting settings = null);
    
    
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Accommodatie))]
    	ClubCloud_Accommodatie GetAccommodatieForBaanById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    		
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Baan))]
        [ServiceKnownType(typeof(ClubCloud_Baanschema))]
    	List<ClubCloud_Baanschema> GetBaanschemasForBaan(ClubCloud_Baan entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baan))]
    	[ServiceKnownType(typeof(ClubCloud_Baanschema))]
    	bool SetBaanschemasForBaan(List<ClubCloud_Baanschema> Baanschemas, ClubCloud_Baan entity, bool refresh = false, ClubCloud_Setting settings = null);
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baan))]
    	[ServiceKnownType(typeof(ClubCloud_Baanschema))]
    	List<ClubCloud_Baanschema> GetBaanschemasForBaanById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    	    [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Bouwaard))]
        ClubCloud_Bouwaard  GetBouwaardById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Bouwaard))]
        List<ClubCloud_Bouwaard> GetBouwaarden(bool refresh = false, ClubCloud_Setting settings = null);
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Bouwaard))]
    	ClubCloud_Bouwaard SetBouwaard(ClubCloud_Bouwaard entity, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
    	bool DeleteBouwaard(ClubCloud_Bouwaard entity, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	bool DeleteBouwaardById(System.Guid Id, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Bouwaard))]
    	[ServiceKnownType(typeof(ClubCloud_Bouwaard_View))]
    	ClubCloud_Bouwaard_View GetBouwaardenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Bouwaard))]
    	List<ClubCloud_Bouwaard> GetBouwaardenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null);
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_BaanSpeciaal))]
        ClubCloud_BaanSpeciaal  GetBaanSpeciaalById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_BaanSpeciaal))]
        List<ClubCloud_BaanSpeciaal> GetBanenSpeciaal(bool refresh = false, ClubCloud_Setting settings = null);
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_BaanSpeciaal))]
    	ClubCloud_BaanSpeciaal SetBaanSpeciaal(ClubCloud_BaanSpeciaal entity, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
    	bool DeleteBaanSpeciaal(ClubCloud_BaanSpeciaal entity, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	bool DeleteBaanSpeciaalById(System.Guid Id, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_BaanSpeciaal))]
    	[ServiceKnownType(typeof(ClubCloud_BaanSpeciaal_View))]
    	ClubCloud_BaanSpeciaal_View GetBanenSpeciaalByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_BaanSpeciaal))]
    	List<ClubCloud_BaanSpeciaal> GetBanenSpeciaalBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null);
    
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_BaanSpeciaal))]
    	[ServiceKnownType(typeof(ClubCloud_Accommodatie))]
    	ClubCloud_Accommodatie GetAccommodatieForBaanSpeciaal(ClubCloud_BaanSpeciaal entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_BaanSpeciaal))]
    	[ServiceKnownType(typeof(ClubCloud_Accommodatie))]
    	bool SetAccommodatieForBaanSpeciaal(ClubCloud_Accommodatie Accommodatie, ClubCloud_BaanSpeciaal entity , bool refresh = false, ClubCloud_Setting settings = null);
    
    
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Accommodatie))]
    	ClubCloud_Accommodatie GetAccommodatieForBaanSpeciaalById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_BaanSpeciaal))]
    	[ServiceKnownType(typeof(ClubCloud_Baantoplaag))]
    	ClubCloud_Baantoplaag GetBaantoplaagForBaanSpeciaal(ClubCloud_BaanSpeciaal entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_BaanSpeciaal))]
    	[ServiceKnownType(typeof(ClubCloud_Baantoplaag))]
    	bool SetBaantoplaagForBaanSpeciaal(ClubCloud_Baantoplaag Baantoplaag, ClubCloud_BaanSpeciaal entity , bool refresh = false, ClubCloud_Setting settings = null);
    
    
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baantoplaag))]
    	ClubCloud_Baantoplaag GetBaantoplaagForBaanSpeciaalById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	    [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Reservering))]
        ClubCloud_Reservering  GetReserveringById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Reservering))]
        List<ClubCloud_Reservering> GetReserveringen(bool refresh = false, ClubCloud_Setting settings = null);
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Reservering))]
    	ClubCloud_Reservering SetReservering(ClubCloud_Reservering entity, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
    	bool DeleteReservering(ClubCloud_Reservering entity, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	bool DeleteReserveringById(System.Guid Id, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Reservering))]
    	[ServiceKnownType(typeof(ClubCloud_Reservering_View))]
    	ClubCloud_Reservering_View GetReserveringenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Reservering))]
    	List<ClubCloud_Reservering> GetReserveringenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null);
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Afhang))]
        ClubCloud_Afhang  GetAfhangById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Afhang))]
        List<ClubCloud_Afhang> GetAfhangen(bool refresh = false, ClubCloud_Setting settings = null);
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Afhang))]
    	ClubCloud_Afhang SetAfhang(ClubCloud_Afhang entity, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
    	bool DeleteAfhang(ClubCloud_Afhang entity, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	bool DeleteAfhangById(System.Guid Id, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Afhang))]
    	[ServiceKnownType(typeof(ClubCloud_Afhang_View))]
    	ClubCloud_Afhang_View GetAfhangenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Afhang))]
    	List<ClubCloud_Afhang> GetAfhangenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null);
    
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Afhang))]
    	[ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	ClubCloud_Vereniging GetVerenigingForAfhang(ClubCloud_Afhang entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Afhang))]
    	[ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	bool SetVerenigingForAfhang(ClubCloud_Vereniging Vereniging, ClubCloud_Afhang entity , bool refresh = false, ClubCloud_Setting settings = null);
    
    
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	ClubCloud_Vereniging GetVerenigingForAfhangById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	    [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baanschema))]
        ClubCloud_Baanschema  GetBaanschemaById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baanschema))]
        List<ClubCloud_Baanschema> GetBaanschemas(bool refresh = false, ClubCloud_Setting settings = null);
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baanschema))]
    	ClubCloud_Baanschema SetBaanschema(ClubCloud_Baanschema entity, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
    	bool DeleteBaanschema(ClubCloud_Baanschema entity, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	bool DeleteBaanschemaById(System.Guid Id, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baanschema))]
    	[ServiceKnownType(typeof(ClubCloud_Baanschema_View))]
    	ClubCloud_Baanschema_View GetBaanschemasByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Baanschema))]
    	List<ClubCloud_Baanschema> GetBaanschemasBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null);
    
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baanschema))]
    	[ServiceKnownType(typeof(ClubCloud_Baan))]
    	ClubCloud_Baan GetBaanForBaanschema(ClubCloud_Baanschema entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baanschema))]
    	[ServiceKnownType(typeof(ClubCloud_Baan))]
    	bool SetBaanForBaanschema(ClubCloud_Baan Baan, ClubCloud_Baanschema entity , bool refresh = false, ClubCloud_Setting settings = null);
    
    
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baan))]
    	ClubCloud_Baan GetBaanForBaanschemaById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baanschema))]
    	[ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	ClubCloud_Vereniging GetVerenigingForBaanschema(ClubCloud_Baanschema entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baanschema))]
    	[ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	bool SetVerenigingForBaanschema(ClubCloud_Vereniging Vereniging, ClubCloud_Baanschema entity , bool refresh = false, ClubCloud_Setting settings = null);
    
    
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	ClubCloud_Vereniging GetVerenigingForBaanschemaById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	    [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Foto))]
        ClubCloud_Foto  GetFotoById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Foto))]
        List<ClubCloud_Foto> GetFotos(bool refresh = false, ClubCloud_Setting settings = null);
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Foto))]
    	ClubCloud_Foto SetFoto(ClubCloud_Foto entity, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
    	bool DeleteFoto(ClubCloud_Foto entity, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	bool DeleteFotoById(System.Guid Id, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Foto))]
    	[ServiceKnownType(typeof(ClubCloud_Foto_View))]
    	ClubCloud_Foto_View GetFotosByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Foto))]
    	List<ClubCloud_Foto> GetFotosBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null);
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Lidmaatschapsoort))]
        ClubCloud_Lidmaatschapsoort  GetLidmaatschapsoortById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Lidmaatschapsoort))]
        List<ClubCloud_Lidmaatschapsoort> GetLidmaatschapsoorten(bool refresh = false, ClubCloud_Setting settings = null);
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Lidmaatschapsoort))]
    	ClubCloud_Lidmaatschapsoort SetLidmaatschapsoort(ClubCloud_Lidmaatschapsoort entity, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
    	bool DeleteLidmaatschapsoort(ClubCloud_Lidmaatschapsoort entity, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	bool DeleteLidmaatschapsoortById(System.Guid Id, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Lidmaatschapsoort))]
    	[ServiceKnownType(typeof(ClubCloud_Lidmaatschapsoort_View))]
    	ClubCloud_Lidmaatschapsoort_View GetLidmaatschapsoortenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Lidmaatschapsoort))]
    	List<ClubCloud_Lidmaatschapsoort> GetLidmaatschapsoortenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null);
    
    	
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Lidmaatschapsoort))]
        [ServiceKnownType(typeof(ClubCloud_Lidmaatschap))]
    	List<ClubCloud_Lidmaatschap> GetLidmaatschappenForLidmaatschapsoort(ClubCloud_Lidmaatschapsoort entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Lidmaatschapsoort))]
    	[ServiceKnownType(typeof(ClubCloud_Lidmaatschap))]
    	bool SetLidmaatschappenForLidmaatschapsoort(List<ClubCloud_Lidmaatschap> Lidmaatschappen, ClubCloud_Lidmaatschapsoort entity, bool refresh = false, ClubCloud_Setting settings = null);
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Lidmaatschapsoort))]
    	[ServiceKnownType(typeof(ClubCloud_Lidmaatschap))]
    	List<ClubCloud_Lidmaatschap> GetLidmaatschappenForLidmaatschapsoortById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    	
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Lidmaatschapsoort))]
    	[ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	ClubCloud_Vereniging GetVerenigingForLidmaatschapsoort(ClubCloud_Lidmaatschapsoort entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Lidmaatschapsoort))]
    	[ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	bool SetVerenigingForLidmaatschapsoort(ClubCloud_Vereniging Vereniging, ClubCloud_Lidmaatschapsoort entity , bool refresh = false, ClubCloud_Setting settings = null);
    
    
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	ClubCloud_Vereniging GetVerenigingForLidmaatschapsoortById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	    [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Sponsor))]
        ClubCloud_Sponsor  GetSponsorById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Sponsor))]
        List<ClubCloud_Sponsor> GetSponsoren(bool refresh = false, ClubCloud_Setting settings = null);
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Sponsor))]
    	ClubCloud_Sponsor SetSponsor(ClubCloud_Sponsor entity, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
    	bool DeleteSponsor(ClubCloud_Sponsor entity, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	bool DeleteSponsorById(System.Guid Id, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Sponsor))]
    	[ServiceKnownType(typeof(ClubCloud_Sponsor_View))]
    	ClubCloud_Sponsor_View GetSponsorenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Sponsor))]
    	List<ClubCloud_Sponsor> GetSponsorenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null);
    
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Sponsor))]
    	[ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	ClubCloud_Vereniging GetVerenigingForSponsor(ClubCloud_Sponsor entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Sponsor))]
    	[ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	bool SetVerenigingForSponsor(ClubCloud_Vereniging Vereniging, ClubCloud_Sponsor entity , bool refresh = false, ClubCloud_Setting settings = null);
    
    
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
    	ClubCloud_Vereniging GetVerenigingForSponsorById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Sponsor))]
    	[ServiceKnownType(typeof(ClubCloud_Sponsor_Afbeelding))]
    	ClubCloud_Sponsor_Afbeelding GetAfbeeldingForSponsor(ClubCloud_Sponsor entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Sponsor))]
    	[ServiceKnownType(typeof(ClubCloud_Sponsor_Afbeelding))]
    	bool SetAfbeeldingForSponsor(ClubCloud_Sponsor_Afbeelding Afbeelding, ClubCloud_Sponsor entity , bool refresh = false, ClubCloud_Setting settings = null);
    
    
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Sponsor_Afbeelding))]
    	ClubCloud_Sponsor_Afbeelding GetAfbeeldingForSponsorById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	    [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Sponsor_Afbeelding))]
        ClubCloud_Sponsor_Afbeelding  GetAfbeeldingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Sponsor_Afbeelding))]
        List<ClubCloud_Sponsor_Afbeelding> GetAfbeeldingen(bool refresh = false, ClubCloud_Setting settings = null);
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Sponsor_Afbeelding))]
    	ClubCloud_Sponsor_Afbeelding SetAfbeelding(ClubCloud_Sponsor_Afbeelding entity, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
    	bool DeleteAfbeelding(ClubCloud_Sponsor_Afbeelding entity, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	bool DeleteAfbeeldingById(System.Guid Id, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Sponsor_Afbeelding))]
    	[ServiceKnownType(typeof(ClubCloud_Sponsor_Afbeelding_View))]
    	ClubCloud_Sponsor_Afbeelding_View GetAfbeeldingenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Sponsor_Afbeelding))]
    	List<ClubCloud_Sponsor_Afbeelding> GetAfbeeldingenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null);
    
    	
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Sponsor_Afbeelding))]
        [ServiceKnownType(typeof(ClubCloud_Sponsor))]
    	List<ClubCloud_Sponsor> GetSponsorenForAfbeelding(ClubCloud_Sponsor_Afbeelding entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Sponsor_Afbeelding))]
    	[ServiceKnownType(typeof(ClubCloud_Sponsor))]
    	bool SetSponsorenForAfbeelding(List<ClubCloud_Sponsor> Sponsoren, ClubCloud_Sponsor_Afbeelding entity, bool refresh = false, ClubCloud_Setting settings = null);
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Sponsor_Afbeelding))]
    	[ServiceKnownType(typeof(ClubCloud_Sponsor))]
    	List<ClubCloud_Sponsor> GetSponsorenForAfbeeldingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    	    [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baanblok))]
        ClubCloud_Baanblok  GetBaanblokById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baanblok))]
        List<ClubCloud_Baanblok> GetBaanblokken(bool refresh = false, ClubCloud_Setting settings = null);
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baanblok))]
    	ClubCloud_Baanblok SetBaanblok(ClubCloud_Baanblok entity, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
    	bool DeleteBaanblok(ClubCloud_Baanblok entity, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	bool DeleteBaanblokById(System.Guid Id, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baanblok))]
    	[ServiceKnownType(typeof(ClubCloud_Baanblok_View))]
    	ClubCloud_Baanblok_View GetBaanblokkenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Baanblok))]
    	List<ClubCloud_Baanblok> GetBaanblokkenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null);
    
    	
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Baanblok))]
        [ServiceKnownType(typeof(ClubCloud_Baan))]
    	List<ClubCloud_Baan> GetBanenForBaanblok(ClubCloud_Baanblok entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baanblok))]
    	[ServiceKnownType(typeof(ClubCloud_Baan))]
    	bool SetBanenForBaanblok(List<ClubCloud_Baan> Banen, ClubCloud_Baanblok entity, bool refresh = false, ClubCloud_Setting settings = null);
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baanblok))]
    	[ServiceKnownType(typeof(ClubCloud_Baan))]
    	List<ClubCloud_Baan> GetBanenForBaanblokById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    	
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baanblok))]
    	[ServiceKnownType(typeof(ClubCloud_Accommodatie))]
    	ClubCloud_Accommodatie GetAccommodatieForBaanblok(ClubCloud_Baanblok entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baanblok))]
    	[ServiceKnownType(typeof(ClubCloud_Accommodatie))]
    	bool SetAccommodatieForBaanblok(ClubCloud_Accommodatie Accommodatie, ClubCloud_Baanblok entity , bool refresh = false, ClubCloud_Setting settings = null);
    
    
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Accommodatie))]
    	ClubCloud_Accommodatie GetAccommodatieForBaanblokById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baanblok))]
    	[ServiceKnownType(typeof(ClubCloud_Baantype))]
    	ClubCloud_Baantype GetBaantypeForBaanblok(ClubCloud_Baanblok entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baanblok))]
    	[ServiceKnownType(typeof(ClubCloud_Baantype))]
    	bool SetBaantypeForBaanblok(ClubCloud_Baantype Baantype, ClubCloud_Baanblok entity , bool refresh = false, ClubCloud_Setting settings = null);
    
    
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baantype))]
    	ClubCloud_Baantype GetBaantypeForBaanblokById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baanblok))]
    	[ServiceKnownType(typeof(ClubCloud_Baansoort))]
    	ClubCloud_Baansoort GetBaansoortForBaanblok(ClubCloud_Baanblok entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baanblok))]
    	[ServiceKnownType(typeof(ClubCloud_Baansoort))]
    	bool SetBaansoortForBaanblok(ClubCloud_Baansoort Baansoort, ClubCloud_Baanblok entity , bool refresh = false, ClubCloud_Setting settings = null);
    
    
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baansoort))]
    	ClubCloud_Baansoort GetBaansoortForBaanblokById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	    [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baantoplaag))]
        ClubCloud_Baantoplaag  GetBaantoplaagById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baantoplaag))]
        List<ClubCloud_Baantoplaag> GetBaantoplagen(bool refresh = false, ClubCloud_Setting settings = null);
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baantoplaag))]
    	ClubCloud_Baantoplaag SetBaantoplaag(ClubCloud_Baantoplaag entity, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
    	bool DeleteBaantoplaag(ClubCloud_Baantoplaag entity, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	bool DeleteBaantoplaagById(System.Guid Id, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baantoplaag))]
    	[ServiceKnownType(typeof(ClubCloud_Baantoplaag_View))]
    	ClubCloud_Baantoplaag_View GetBaantoplagenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Baantoplaag))]
    	List<ClubCloud_Baantoplaag> GetBaantoplagenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null);
    
    	
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Baantoplaag))]
        [ServiceKnownType(typeof(ClubCloud_BaanSpeciaal))]
    	List<ClubCloud_BaanSpeciaal> GetBanenSpeciaalForBaantoplaag(ClubCloud_Baantoplaag entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baantoplaag))]
    	[ServiceKnownType(typeof(ClubCloud_BaanSpeciaal))]
    	bool SetBanenSpeciaalForBaantoplaag(List<ClubCloud_BaanSpeciaal> BanenSpeciaal, ClubCloud_Baantoplaag entity, bool refresh = false, ClubCloud_Setting settings = null);
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baantoplaag))]
    	[ServiceKnownType(typeof(ClubCloud_BaanSpeciaal))]
    	List<ClubCloud_BaanSpeciaal> GetBanenSpeciaalForBaantoplaagById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    	    [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Land))]
        ClubCloud_Land  GetLandById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Land))]
        List<ClubCloud_Land> GetLanden(bool refresh = false, ClubCloud_Setting settings = null);
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Land))]
    	ClubCloud_Land SetLand(ClubCloud_Land entity, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
    	bool DeleteLand(ClubCloud_Land entity, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	bool DeleteLandById(System.Guid Id, ClubCloud_Setting settings = null);
    
    
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Land))]
    	[ServiceKnownType(typeof(ClubCloud_Land_View))]
    	ClubCloud_Land_View GetLandenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null);
    
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Land))]
    	List<ClubCloud_Land> GetLandenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null);
    
    	
    	[OperationContract]
    	[ServiceKnownType(typeof(ClubCloud_Land))]
        [ServiceKnownType(typeof(ClubCloud_Address))]
    	List<ClubCloud_Address> GetAddressenForLand(ClubCloud_Land entity, bool refresh = false, ClubCloud_Setting settings = null);
    
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Land))]
    	[ServiceKnownType(typeof(ClubCloud_Address))]
    	bool SetAddressenForLand(List<ClubCloud_Address> Addressen, ClubCloud_Land entity, bool refresh = false, ClubCloud_Setting settings = null);
    	[OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Land))]
    	[ServiceKnownType(typeof(ClubCloud_Address))]
    	List<ClubCloud_Address> GetAddressenForLandById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null);
    
    	
    		}
}

