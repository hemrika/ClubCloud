
 
namespace ClubCloud.Service
{
    using ClubCloud.Model;
    using System;
    using System.Collections.Generic;
    using System.ServiceModel;
    using System.ServiceModel.Description;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    
    public partial class ClubCloudServiceClient //: BaseServiceClient
    {
        public ClubCloud_Setting GetSettingById(int Id, bool refresh = false, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Setting response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetSettingById(Id, refresh, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_Setting> GetSettings(bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_Setting> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetSettings(refresh, settings);
                },
                false);
    
            return response;
        }
    
        public ClubCloud_Setting SetSetting(ClubCloud_Setting entity, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Setting response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetSetting(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteSetting(ClubCloud_Setting entity, ClubCloud_Setting settings = null)
        {
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteSetting(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteSettingById(int Id, ClubCloud_Setting settings = null)
    	{
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteSettingById(Id, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public ClubCloud_Setting_View GetSettingsByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Setting_View response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetSettingsByQuery(bondsnummer, verenigingId, selectArgs, parameters, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_Setting> GetSettingsBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null)
    	{
    		List<ClubCloud_Setting> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetSettingsBySearch(prefixText, count, contextKey, settings);
                },
                false);
    
    		return response;
    	}
    
    
    	public ClubCloud_Gebruiker GetGebruikerForSetting(ClubCloud_Setting entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            ClubCloud_Gebruiker response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetGebruikerForSetting(entity, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	public bool SetGebruikerForSetting(ClubCloud_Gebruiker Gebruiker, ClubCloud_Setting entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    	    bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetGebruikerForSetting(Gebruiker, entity , refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	
    	public ClubCloud_Gebruiker GetGebruikerForSettingById(int Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    ClubCloud_Gebruiker response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetGebruikerForSettingById(Id, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	
    	public ClubCloud_Vereniging GetVerenigingForSetting(ClubCloud_Setting entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            ClubCloud_Vereniging response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetVerenigingForSetting(entity, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	public bool SetVerenigingForSetting(ClubCloud_Vereniging Vereniging, ClubCloud_Setting entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    	    bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetVerenigingForSetting(Vereniging, entity , refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	
    	public ClubCloud_Vereniging GetVerenigingForSettingById(int Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    ClubCloud_Vereniging response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetVerenigingForSettingById(Id, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	    public ClubCloud_Vereniging GetVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Vereniging response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetVerenigingById(Id, refresh, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_Vereniging> GetVerenigingen(bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_Vereniging> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetVerenigingen(refresh, settings);
                },
                false);
    
            return response;
        }
    
        public ClubCloud_Vereniging SetVereniging(ClubCloud_Vereniging entity, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Vereniging response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetVereniging(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteVereniging(ClubCloud_Vereniging entity, ClubCloud_Setting settings = null)
        {
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteVereniging(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteVerenigingById(System.Guid Id, ClubCloud_Setting settings = null)
    	{
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteVerenigingById(Id, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public ClubCloud_Vereniging_View GetVerenigingenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Vereniging_View response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetVerenigingenByQuery(bondsnummer, verenigingId, selectArgs, parameters, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_Vereniging> GetVerenigingenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null)
    	{
    		List<ClubCloud_Vereniging> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetVerenigingenBySearch(prefixText, count, contextKey, settings);
                },
                false);
    
    		return response;
    	}
    
    
    	public List<ClubCloud_Functionaris> GetFunctionarissenForVereniging(ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            List<ClubCloud_Functionaris> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetFunctionarissenForVereniging(entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	public bool SetFunctionarissenForVereniging(List<ClubCloud_Functionaris> Functionarissen, ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetFunctionarissenForVereniging(Functionarissen, entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	public List<ClubCloud_Functionaris> GetFunctionarissenForVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    List<ClubCloud_Functionaris> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetFunctionarissenForVerenigingById(Id, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	
    	public List<ClubCloud_Lidmaatschap> GetLidmaatschappenForVereniging(ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            List<ClubCloud_Lidmaatschap> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetLidmaatschappenForVereniging(entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	public bool SetLidmaatschappenForVereniging(List<ClubCloud_Lidmaatschap> Lidmaatschappen, ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetLidmaatschappenForVereniging(Lidmaatschappen, entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	public List<ClubCloud_Lidmaatschap> GetLidmaatschappenForVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    List<ClubCloud_Lidmaatschap> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetLidmaatschappenForVerenigingById(Id, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	
    	public List<ClubCloud_Bestuursorgaan> GetBestuursorganenForVereniging(ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            List<ClubCloud_Bestuursorgaan> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBestuursorganenForVereniging(entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	public bool SetBestuursorganenForVereniging(List<ClubCloud_Bestuursorgaan> Bestuursorganen, ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetBestuursorganenForVereniging(Bestuursorganen, entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	public List<ClubCloud_Bestuursorgaan> GetBestuursorganenForVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    List<ClubCloud_Bestuursorgaan> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBestuursorganenForVerenigingById(Id, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	
    	public ClubCloud_District GetDistrictForVereniging(ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            ClubCloud_District response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetDistrictForVereniging(entity, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	public bool SetDistrictForVereniging(ClubCloud_District District, ClubCloud_Vereniging entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    	    bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetDistrictForVereniging(District, entity , refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	
    	public ClubCloud_District GetDistrictForVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    ClubCloud_District response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetDistrictForVerenigingById(Id, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	
    	public ClubCloud_Rechtsvorm GetRechtsvormForVereniging(ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            ClubCloud_Rechtsvorm response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetRechtsvormForVereniging(entity, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	public bool SetRechtsvormForVereniging(ClubCloud_Rechtsvorm Rechtsvorm, ClubCloud_Vereniging entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    	    bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetRechtsvormForVereniging(Rechtsvorm, entity , refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	
    	public ClubCloud_Rechtsvorm GetRechtsvormForVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    ClubCloud_Rechtsvorm response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetRechtsvormForVerenigingById(Id, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	
    	public ClubCloud_Accommodatie GetAccommodatieForVereniging(ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            ClubCloud_Accommodatie response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetAccommodatieForVereniging(entity, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	public bool SetAccommodatieForVereniging(ClubCloud_Accommodatie Accommodatie, ClubCloud_Vereniging entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    	    bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetAccommodatieForVereniging(Accommodatie, entity , refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	
    	public ClubCloud_Accommodatie GetAccommodatieForVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    ClubCloud_Accommodatie response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetAccommodatieForVerenigingById(Id, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	
    	public List<ClubCloud_Address> GetAddressenForVereniging(ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            List<ClubCloud_Address> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetAddressenForVereniging(entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	public bool SetAddressenForVereniging(List<ClubCloud_Address> Addressen, ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetAddressenForVereniging(Addressen, entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	public List<ClubCloud_Address> GetAddressenForVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    List<ClubCloud_Address> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetAddressenForVerenigingById(Id, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	
    	public ClubCloud_Regio GetRegioForVereniging(ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            ClubCloud_Regio response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetRegioForVereniging(entity, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	public bool SetRegioForVereniging(ClubCloud_Regio Regio, ClubCloud_Vereniging entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    	    bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetRegioForVereniging(Regio, entity , refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	
    	public ClubCloud_Regio GetRegioForVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    ClubCloud_Regio response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetRegioForVerenigingById(Id, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	
    	public List<ClubCloud_Gebruiker> GetGebruikersForVereniging(ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            List<ClubCloud_Gebruiker> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetGebruikersForVereniging(entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	public bool SetGebruikersForVereniging(List<ClubCloud_Gebruiker> Gebruikers, ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetGebruikersForVereniging(Gebruikers, entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	public List<ClubCloud_Gebruiker> GetGebruikersForVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    List<ClubCloud_Gebruiker> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetGebruikersForVerenigingById(Id, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	
    	public List<ClubCloud_Afhang> GetAfhangenForVereniging(ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            List<ClubCloud_Afhang> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetAfhangenForVereniging(entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	public bool SetAfhangenForVereniging(List<ClubCloud_Afhang> Afhangen, ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetAfhangenForVereniging(Afhangen, entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	public List<ClubCloud_Afhang> GetAfhangenForVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    List<ClubCloud_Afhang> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetAfhangenForVerenigingById(Id, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	
    	public List<ClubCloud_Sponsor> GetSponsorenForVereniging(ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            List<ClubCloud_Sponsor> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetSponsorenForVereniging(entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	public bool SetSponsorenForVereniging(List<ClubCloud_Sponsor> Sponsoren, ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetSponsorenForVereniging(Sponsoren, entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	public List<ClubCloud_Sponsor> GetSponsorenForVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    List<ClubCloud_Sponsor> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetSponsorenForVerenigingById(Id, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	
    	public List<ClubCloud_Setting> GetSettingsForVereniging(ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            List<ClubCloud_Setting> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetSettingsForVereniging(entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	public bool SetSettingsForVereniging(List<ClubCloud_Setting> Settings, ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetSettingsForVereniging(Settings, entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	public List<ClubCloud_Setting> GetSettingsForVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    List<ClubCloud_Setting> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetSettingsForVerenigingById(Id, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	
    	public List<ClubCloud_Baanschema> GetBaanschemasForVereniging(ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            List<ClubCloud_Baanschema> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBaanschemasForVereniging(entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	public bool SetBaanschemasForVereniging(List<ClubCloud_Baanschema> Baanschemas, ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetBaanschemasForVereniging(Baanschemas, entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	public List<ClubCloud_Baanschema> GetBaanschemasForVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    List<ClubCloud_Baanschema> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBaanschemasForVerenigingById(Id, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	
    	public List<ClubCloud_Lidmaatschapsoort> GetLidmaatschapsoortenForVereniging(ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            List<ClubCloud_Lidmaatschapsoort> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetLidmaatschapsoortenForVereniging(entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	public bool SetLidmaatschapsoortenForVereniging(List<ClubCloud_Lidmaatschapsoort> Lidmaatschapsoorten, ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetLidmaatschapsoortenForVereniging(Lidmaatschapsoorten, entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	public List<ClubCloud_Lidmaatschapsoort> GetLidmaatschapsoortenForVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    List<ClubCloud_Lidmaatschapsoort> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetLidmaatschapsoortenForVerenigingById(Id, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	    public ClubCloud_Gebruiker GetGebruikerById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Gebruiker response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetGebruikerById(Id, refresh, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_Gebruiker> GetGebruikers(bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_Gebruiker> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetGebruikers(refresh, settings);
                },
                false);
    
            return response;
        }
    
        public ClubCloud_Gebruiker SetGebruiker(ClubCloud_Gebruiker entity, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Gebruiker response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetGebruiker(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteGebruiker(ClubCloud_Gebruiker entity, ClubCloud_Setting settings = null)
        {
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteGebruiker(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteGebruikerById(System.Guid Id, ClubCloud_Setting settings = null)
    	{
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteGebruikerById(Id, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public ClubCloud_Gebruiker_View GetGebruikersByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Gebruiker_View response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetGebruikersByQuery(bondsnummer, verenigingId, selectArgs, parameters, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_Gebruiker> GetGebruikersBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null)
    	{
    		List<ClubCloud_Gebruiker> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetGebruikersBySearch(prefixText, count, contextKey, settings);
                },
                false);
    
    		return response;
    	}
    
    
    	public List<ClubCloud_Functionaris> GetFunctionarissenForGebruiker(ClubCloud_Gebruiker entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            List<ClubCloud_Functionaris> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetFunctionarissenForGebruiker(entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	public bool SetFunctionarissenForGebruiker(List<ClubCloud_Functionaris> Functionarissen, ClubCloud_Gebruiker entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetFunctionarissenForGebruiker(Functionarissen, entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	public List<ClubCloud_Functionaris> GetFunctionarissenForGebruikerById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    List<ClubCloud_Functionaris> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetFunctionarissenForGebruikerById(Id, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	
    	public List<ClubCloud_Lidmaatschap> GetLidmaatschappenForGebruiker(ClubCloud_Gebruiker entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            List<ClubCloud_Lidmaatschap> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetLidmaatschappenForGebruiker(entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	public bool SetLidmaatschappenForGebruiker(List<ClubCloud_Lidmaatschap> Lidmaatschappen, ClubCloud_Gebruiker entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetLidmaatschappenForGebruiker(Lidmaatschappen, entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	public List<ClubCloud_Lidmaatschap> GetLidmaatschappenForGebruikerById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    List<ClubCloud_Lidmaatschap> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetLidmaatschappenForGebruikerById(Id, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	
    	public List<ClubCloud_Address> GetAddressenForGebruiker(ClubCloud_Gebruiker entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            List<ClubCloud_Address> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetAddressenForGebruiker(entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	public bool SetAddressenForGebruiker(List<ClubCloud_Address> Addressen, ClubCloud_Gebruiker entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetAddressenForGebruiker(Addressen, entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	public List<ClubCloud_Address> GetAddressenForGebruikerById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    List<ClubCloud_Address> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetAddressenForGebruikerById(Id, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	
    	public ClubCloud_Vereniging GetVerenigingForGebruiker(ClubCloud_Gebruiker entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            ClubCloud_Vereniging response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetVerenigingForGebruiker(entity, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	public bool SetVerenigingForGebruiker(ClubCloud_Vereniging Vereniging, ClubCloud_Gebruiker entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    	    bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetVerenigingForGebruiker(Vereniging, entity , refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	
    	public ClubCloud_Vereniging GetVerenigingForGebruikerById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    ClubCloud_Vereniging response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetVerenigingForGebruikerById(Id, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	
    	public List<ClubCloud_Profiel> GetProfielenForGebruiker(ClubCloud_Gebruiker entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            List<ClubCloud_Profiel> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetProfielenForGebruiker(entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	public bool SetProfielenForGebruiker(List<ClubCloud_Profiel> Profielen, ClubCloud_Gebruiker entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetProfielenForGebruiker(Profielen, entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	public List<ClubCloud_Profiel> GetProfielenForGebruikerById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    List<ClubCloud_Profiel> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetProfielenForGebruikerById(Id, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	
    	public List<ClubCloud_Setting> GetSettingsForGebruiker(ClubCloud_Gebruiker entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            List<ClubCloud_Setting> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetSettingsForGebruiker(entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	public bool SetSettingsForGebruiker(List<ClubCloud_Setting> Settings, ClubCloud_Gebruiker entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetSettingsForGebruiker(Settings, entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	public List<ClubCloud_Setting> GetSettingsForGebruikerById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    List<ClubCloud_Setting> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetSettingsForGebruikerById(Id, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	
    	public ClubCloud_Nationaliteit GetNationaliteitForGebruiker(ClubCloud_Gebruiker entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            ClubCloud_Nationaliteit response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetNationaliteitForGebruiker(entity, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	public bool SetNationaliteitForGebruiker(ClubCloud_Nationaliteit Nationaliteit, ClubCloud_Gebruiker entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    	    bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetNationaliteitForGebruiker(Nationaliteit, entity , refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	
    	public ClubCloud_Nationaliteit GetNationaliteitForGebruikerById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    ClubCloud_Nationaliteit response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetNationaliteitForGebruikerById(Id, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	    public ClubCloud_Accommodatie GetAccommodatieById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Accommodatie response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetAccommodatieById(Id, refresh, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_Accommodatie> GetAccommodaties(bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_Accommodatie> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetAccommodaties(refresh, settings);
                },
                false);
    
            return response;
        }
    
        public ClubCloud_Accommodatie SetAccommodatie(ClubCloud_Accommodatie entity, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Accommodatie response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetAccommodatie(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteAccommodatie(ClubCloud_Accommodatie entity, ClubCloud_Setting settings = null)
        {
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteAccommodatie(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteAccommodatieById(System.Guid Id, ClubCloud_Setting settings = null)
    	{
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteAccommodatieById(Id, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public ClubCloud_Accommodatie_View GetAccommodatiesByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Accommodatie_View response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetAccommodatiesByQuery(bondsnummer, verenigingId, selectArgs, parameters, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_Accommodatie> GetAccommodatiesBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null)
    	{
    		List<ClubCloud_Accommodatie> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetAccommodatiesBySearch(prefixText, count, contextKey, settings);
                },
                false);
    
    		return response;
    	}
    
    
    	public List<ClubCloud_Vereniging> GetVerenigingenForAccommodatie(ClubCloud_Accommodatie entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            List<ClubCloud_Vereniging> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetVerenigingenForAccommodatie(entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	public bool SetVerenigingenForAccommodatie(List<ClubCloud_Vereniging> Verenigingen, ClubCloud_Accommodatie entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetVerenigingenForAccommodatie(Verenigingen, entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	public List<ClubCloud_Vereniging> GetVerenigingenForAccommodatieById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    List<ClubCloud_Vereniging> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetVerenigingenForAccommodatieById(Id, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	
    	public ClubCloud_District GetDistrictForAccommodatie(ClubCloud_Accommodatie entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            ClubCloud_District response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetDistrictForAccommodatie(entity, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	public bool SetDistrictForAccommodatie(ClubCloud_District District, ClubCloud_Accommodatie entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    	    bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetDistrictForAccommodatie(District, entity , refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	
    	public ClubCloud_District GetDistrictForAccommodatieById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    ClubCloud_District response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetDistrictForAccommodatieById(Id, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	
    	public ClubCloud_Regio GetRegioForAccommodatie(ClubCloud_Accommodatie entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            ClubCloud_Regio response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetRegioForAccommodatie(entity, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	public bool SetRegioForAccommodatie(ClubCloud_Regio Regio, ClubCloud_Accommodatie entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    	    bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetRegioForAccommodatie(Regio, entity , refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	
    	public ClubCloud_Regio GetRegioForAccommodatieById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    ClubCloud_Regio response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetRegioForAccommodatieById(Id, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	
    	public List<ClubCloud_Baanblok> GetBaanblokkenForAccommodatie(ClubCloud_Accommodatie entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            List<ClubCloud_Baanblok> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBaanblokkenForAccommodatie(entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	public bool SetBaanblokkenForAccommodatie(List<ClubCloud_Baanblok> Baanblokken, ClubCloud_Accommodatie entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetBaanblokkenForAccommodatie(Baanblokken, entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	public List<ClubCloud_Baanblok> GetBaanblokkenForAccommodatieById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    List<ClubCloud_Baanblok> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBaanblokkenForAccommodatieById(Id, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	
    	public List<ClubCloud_Baan> GetBanenForAccommodatie(ClubCloud_Accommodatie entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            List<ClubCloud_Baan> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBanenForAccommodatie(entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	public bool SetBanenForAccommodatie(List<ClubCloud_Baan> Banen, ClubCloud_Accommodatie entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetBanenForAccommodatie(Banen, entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	public List<ClubCloud_Baan> GetBanenForAccommodatieById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    List<ClubCloud_Baan> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBanenForAccommodatieById(Id, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	
    	public List<ClubCloud_BaanSpeciaal> GetBanenSpeciaalForAccommodatie(ClubCloud_Accommodatie entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            List<ClubCloud_BaanSpeciaal> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBanenSpeciaalForAccommodatie(entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	public bool SetBanenSpeciaalForAccommodatie(List<ClubCloud_BaanSpeciaal> BanenSpeciaal, ClubCloud_Accommodatie entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetBanenSpeciaalForAccommodatie(BanenSpeciaal, entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	public List<ClubCloud_BaanSpeciaal> GetBanenSpeciaalForAccommodatieById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    List<ClubCloud_BaanSpeciaal> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBanenSpeciaalForAccommodatieById(Id, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	
    	public List<ClubCloud_Address> GetAddressenForAccommodatie(ClubCloud_Accommodatie entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            List<ClubCloud_Address> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetAddressenForAccommodatie(entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	public bool SetAddressenForAccommodatie(List<ClubCloud_Address> Addressen, ClubCloud_Accommodatie entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetAddressenForAccommodatie(Addressen, entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	public List<ClubCloud_Address> GetAddressenForAccommodatieById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    List<ClubCloud_Address> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetAddressenForAccommodatieById(Id, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	    public ClubCloud_Nationaliteit GetNationaliteitById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Nationaliteit response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetNationaliteitById(Id, refresh, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_Nationaliteit> GetNationaliteiten(bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_Nationaliteit> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetNationaliteiten(refresh, settings);
                },
                false);
    
            return response;
        }
    
        public ClubCloud_Nationaliteit SetNationaliteit(ClubCloud_Nationaliteit entity, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Nationaliteit response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetNationaliteit(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteNationaliteit(ClubCloud_Nationaliteit entity, ClubCloud_Setting settings = null)
        {
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteNationaliteit(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteNationaliteitById(System.Guid Id, ClubCloud_Setting settings = null)
    	{
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteNationaliteitById(Id, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public ClubCloud_Nationaliteit_View GetNationaliteitenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Nationaliteit_View response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetNationaliteitenByQuery(bondsnummer, verenigingId, selectArgs, parameters, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_Nationaliteit> GetNationaliteitenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null)
    	{
    		List<ClubCloud_Nationaliteit> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetNationaliteitenBySearch(prefixText, count, contextKey, settings);
                },
                false);
    
    		return response;
    	}
    
    
    	public List<ClubCloud_Gebruiker> GetGebruikersForNationaliteit(ClubCloud_Nationaliteit entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            List<ClubCloud_Gebruiker> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetGebruikersForNationaliteit(entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	public bool SetGebruikersForNationaliteit(List<ClubCloud_Gebruiker> Gebruikers, ClubCloud_Nationaliteit entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetGebruikersForNationaliteit(Gebruikers, entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	public List<ClubCloud_Gebruiker> GetGebruikersForNationaliteitById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    List<ClubCloud_Gebruiker> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetGebruikersForNationaliteitById(Id, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	    public ClubCloud_District GetDistrictById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_District response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetDistrictById(Id, refresh, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_District> GetDistricten(bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_District> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetDistricten(refresh, settings);
                },
                false);
    
            return response;
        }
    
        public ClubCloud_District SetDistrict(ClubCloud_District entity, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_District response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetDistrict(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteDistrict(ClubCloud_District entity, ClubCloud_Setting settings = null)
        {
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteDistrict(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteDistrictById(System.Guid Id, ClubCloud_Setting settings = null)
    	{
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteDistrictById(Id, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public ClubCloud_District_View GetDistrictenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_District_View response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetDistrictenByQuery(bondsnummer, verenigingId, selectArgs, parameters, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_District> GetDistrictenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null)
    	{
    		List<ClubCloud_District> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetDistrictenBySearch(prefixText, count, contextKey, settings);
                },
                false);
    
    		return response;
    	}
    
    
    	public List<ClubCloud_Functionaris> GetFunctionarissenForDistrict(ClubCloud_District entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            List<ClubCloud_Functionaris> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetFunctionarissenForDistrict(entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	public bool SetFunctionarissenForDistrict(List<ClubCloud_Functionaris> Functionarissen, ClubCloud_District entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetFunctionarissenForDistrict(Functionarissen, entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	public List<ClubCloud_Functionaris> GetFunctionarissenForDistrictById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    List<ClubCloud_Functionaris> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetFunctionarissenForDistrictById(Id, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	
    	public List<ClubCloud_Vereniging> GetVerenigingenForDistrict(ClubCloud_District entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            List<ClubCloud_Vereniging> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetVerenigingenForDistrict(entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	public bool SetVerenigingenForDistrict(List<ClubCloud_Vereniging> Verenigingen, ClubCloud_District entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetVerenigingenForDistrict(Verenigingen, entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	public List<ClubCloud_Vereniging> GetVerenigingenForDistrictById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    List<ClubCloud_Vereniging> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetVerenigingenForDistrictById(Id, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	
    	public ClubCloud_Regio GetRegioForDistrict(ClubCloud_District entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            ClubCloud_Regio response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetRegioForDistrict(entity, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	public bool SetRegioForDistrict(ClubCloud_Regio Regio, ClubCloud_District entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    	    bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetRegioForDistrict(Regio, entity , refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	
    	public ClubCloud_Regio GetRegioForDistrictById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    ClubCloud_Regio response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetRegioForDistrictById(Id, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	
    	public List<ClubCloud_Accommodatie> GetAccommodatiesForDistrict(ClubCloud_District entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            List<ClubCloud_Accommodatie> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetAccommodatiesForDistrict(entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	public bool SetAccommodatiesForDistrict(List<ClubCloud_Accommodatie> Accommodaties, ClubCloud_District entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetAccommodatiesForDistrict(Accommodaties, entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	public List<ClubCloud_Accommodatie> GetAccommodatiesForDistrictById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    List<ClubCloud_Accommodatie> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetAccommodatiesForDistrictById(Id, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	    public ClubCloud_Functie GetFunctieById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Functie response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetFunctieById(Id, refresh, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_Functie> GetFuncties(bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_Functie> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetFuncties(refresh, settings);
                },
                false);
    
            return response;
        }
    
        public ClubCloud_Functie SetFunctie(ClubCloud_Functie entity, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Functie response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetFunctie(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteFunctie(ClubCloud_Functie entity, ClubCloud_Setting settings = null)
        {
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteFunctie(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteFunctieById(System.Guid Id, ClubCloud_Setting settings = null)
    	{
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteFunctieById(Id, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public ClubCloud_Functie_View GetFunctiesByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Functie_View response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetFunctiesByQuery(bondsnummer, verenigingId, selectArgs, parameters, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_Functie> GetFunctiesBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null)
    	{
    		List<ClubCloud_Functie> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetFunctiesBySearch(prefixText, count, contextKey, settings);
                },
                false);
    
    		return response;
    	}
    
    
    	public List<ClubCloud_Functionaris> GetFunctionarissenForFunctie(ClubCloud_Functie entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            List<ClubCloud_Functionaris> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetFunctionarissenForFunctie(entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	public bool SetFunctionarissenForFunctie(List<ClubCloud_Functionaris> Functionarissen, ClubCloud_Functie entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetFunctionarissenForFunctie(Functionarissen, entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	public List<ClubCloud_Functionaris> GetFunctionarissenForFunctieById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    List<ClubCloud_Functionaris> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetFunctionarissenForFunctieById(Id, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	    public ClubCloud_Lidmaatschap GetLidmaatschapById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Lidmaatschap response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetLidmaatschapById(Id, refresh, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_Lidmaatschap> GetLidmaatschappen(bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_Lidmaatschap> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetLidmaatschappen(refresh, settings);
                },
                false);
    
            return response;
        }
    
        public ClubCloud_Lidmaatschap SetLidmaatschap(ClubCloud_Lidmaatschap entity, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Lidmaatschap response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetLidmaatschap(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteLidmaatschap(ClubCloud_Lidmaatschap entity, ClubCloud_Setting settings = null)
        {
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteLidmaatschap(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteLidmaatschapById(System.Guid Id, ClubCloud_Setting settings = null)
    	{
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteLidmaatschapById(Id, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public ClubCloud_Lidmaatschap_View GetLidmaatschappenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Lidmaatschap_View response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetLidmaatschappenByQuery(bondsnummer, verenigingId, selectArgs, parameters, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_Lidmaatschap> GetLidmaatschappenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null)
    	{
    		List<ClubCloud_Lidmaatschap> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetLidmaatschappenBySearch(prefixText, count, contextKey, settings);
                },
                false);
    
    		return response;
    	}
    
    
    	public ClubCloud_Vereniging GetVerenigingForLidmaatschap(ClubCloud_Lidmaatschap entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            ClubCloud_Vereniging response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetVerenigingForLidmaatschap(entity, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	public bool SetVerenigingForLidmaatschap(ClubCloud_Vereniging Vereniging, ClubCloud_Lidmaatschap entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    	    bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetVerenigingForLidmaatschap(Vereniging, entity , refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	
    	public ClubCloud_Vereniging GetVerenigingForLidmaatschapById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    ClubCloud_Vereniging response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetVerenigingForLidmaatschapById(Id, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	
    	public ClubCloud_Gebruiker GetGebruikerForLidmaatschap(ClubCloud_Lidmaatschap entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            ClubCloud_Gebruiker response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetGebruikerForLidmaatschap(entity, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	public bool SetGebruikerForLidmaatschap(ClubCloud_Gebruiker Gebruiker, ClubCloud_Lidmaatschap entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    	    bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetGebruikerForLidmaatschap(Gebruiker, entity , refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	
    	public ClubCloud_Gebruiker GetGebruikerForLidmaatschapById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    ClubCloud_Gebruiker response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetGebruikerForLidmaatschapById(Id, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	
    	public ClubCloud_Lidmaatschapsoort GetLidmaatschapsoortForLidmaatschap(ClubCloud_Lidmaatschap entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            ClubCloud_Lidmaatschapsoort response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetLidmaatschapsoortForLidmaatschap(entity, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	public bool SetLidmaatschapsoortForLidmaatschap(ClubCloud_Lidmaatschapsoort Lidmaatschapsoort, ClubCloud_Lidmaatschap entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    	    bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetLidmaatschapsoortForLidmaatschap(Lidmaatschapsoort, entity , refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	
    	public ClubCloud_Lidmaatschapsoort GetLidmaatschapsoortForLidmaatschapById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    ClubCloud_Lidmaatschapsoort response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetLidmaatschapsoortForLidmaatschapById(Id, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	    public ClubCloud_Profiel GetProfielById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Profiel response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetProfielById(Id, refresh, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_Profiel> GetProfielen(bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_Profiel> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetProfielen(refresh, settings);
                },
                false);
    
            return response;
        }
    
        public ClubCloud_Profiel SetProfiel(ClubCloud_Profiel entity, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Profiel response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetProfiel(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteProfiel(ClubCloud_Profiel entity, ClubCloud_Setting settings = null)
        {
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteProfiel(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteProfielById(System.Guid Id, ClubCloud_Setting settings = null)
    	{
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteProfielById(Id, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public ClubCloud_Profiel_View GetProfielenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Profiel_View response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetProfielenByQuery(bondsnummer, verenigingId, selectArgs, parameters, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_Profiel> GetProfielenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null)
    	{
    		List<ClubCloud_Profiel> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetProfielenBySearch(prefixText, count, contextKey, settings);
                },
                false);
    
    		return response;
    	}
    
    
    	public ClubCloud_Gebruiker GetGebruikerForProfiel(ClubCloud_Profiel entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            ClubCloud_Gebruiker response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetGebruikerForProfiel(entity, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	public bool SetGebruikerForProfiel(ClubCloud_Gebruiker Gebruiker, ClubCloud_Profiel entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    	    bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetGebruikerForProfiel(Gebruiker, entity , refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	
    	public ClubCloud_Gebruiker GetGebruikerForProfielById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    ClubCloud_Gebruiker response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetGebruikerForProfielById(Id, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	    public ClubCloud_Functionaris GetFunctionarisById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Functionaris response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetFunctionarisById(Id, refresh, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_Functionaris> GetFunctionarissen(bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_Functionaris> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetFunctionarissen(refresh, settings);
                },
                false);
    
            return response;
        }
    
        public ClubCloud_Functionaris SetFunctionaris(ClubCloud_Functionaris entity, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Functionaris response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetFunctionaris(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteFunctionaris(ClubCloud_Functionaris entity, ClubCloud_Setting settings = null)
        {
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteFunctionaris(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteFunctionarisById(System.Guid Id, ClubCloud_Setting settings = null)
    	{
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteFunctionarisById(Id, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public ClubCloud_Functionaris_View GetFunctionarissenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Functionaris_View response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetFunctionarissenByQuery(bondsnummer, verenigingId, selectArgs, parameters, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_Functionaris> GetFunctionarissenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null)
    	{
    		List<ClubCloud_Functionaris> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetFunctionarissenBySearch(prefixText, count, contextKey, settings);
                },
                false);
    
    		return response;
    	}
    
    
    	public ClubCloud_Functie GetFunctieForFunctionaris(ClubCloud_Functionaris entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            ClubCloud_Functie response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetFunctieForFunctionaris(entity, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	public bool SetFunctieForFunctionaris(ClubCloud_Functie Functie, ClubCloud_Functionaris entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    	    bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetFunctieForFunctionaris(Functie, entity , refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	
    	public ClubCloud_Functie GetFunctieForFunctionarisById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    ClubCloud_Functie response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetFunctieForFunctionarisById(Id, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	
    	public ClubCloud_Vereniging GetVerenigingForFunctionaris(ClubCloud_Functionaris entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            ClubCloud_Vereniging response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetVerenigingForFunctionaris(entity, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	public bool SetVerenigingForFunctionaris(ClubCloud_Vereniging Vereniging, ClubCloud_Functionaris entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    	    bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetVerenigingForFunctionaris(Vereniging, entity , refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	
    	public ClubCloud_Vereniging GetVerenigingForFunctionarisById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    ClubCloud_Vereniging response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetVerenigingForFunctionarisById(Id, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	
    	public ClubCloud_Gebruiker GetGebruikerForFunctionaris(ClubCloud_Functionaris entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            ClubCloud_Gebruiker response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetGebruikerForFunctionaris(entity, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	public bool SetGebruikerForFunctionaris(ClubCloud_Gebruiker Gebruiker, ClubCloud_Functionaris entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    	    bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetGebruikerForFunctionaris(Gebruiker, entity , refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	
    	public ClubCloud_Gebruiker GetGebruikerForFunctionarisById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    ClubCloud_Gebruiker response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetGebruikerForFunctionarisById(Id, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	
    	public ClubCloud_District GetDistrictForFunctionaris(ClubCloud_Functionaris entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            ClubCloud_District response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetDistrictForFunctionaris(entity, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	public bool SetDistrictForFunctionaris(ClubCloud_District District, ClubCloud_Functionaris entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    	    bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetDistrictForFunctionaris(District, entity , refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	
    	public ClubCloud_District GetDistrictForFunctionarisById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    ClubCloud_District response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetDistrictForFunctionarisById(Id, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	
    	public ClubCloud_Bestuursorgaan GetBestuursorgaanForFunctionaris(ClubCloud_Functionaris entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            ClubCloud_Bestuursorgaan response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBestuursorgaanForFunctionaris(entity, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	public bool SetBestuursorgaanForFunctionaris(ClubCloud_Bestuursorgaan Bestuursorgaan, ClubCloud_Functionaris entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    	    bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetBestuursorgaanForFunctionaris(Bestuursorgaan, entity , refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	
    	public ClubCloud_Bestuursorgaan GetBestuursorgaanForFunctionarisById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    ClubCloud_Bestuursorgaan response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBestuursorgaanForFunctionarisById(Id, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	    public ClubCloud_Bestuursorgaan GetBestuursorgaanById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Bestuursorgaan response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBestuursorgaanById(Id, refresh, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_Bestuursorgaan> GetBestuursorganen(bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_Bestuursorgaan> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBestuursorganen(refresh, settings);
                },
                false);
    
            return response;
        }
    
        public ClubCloud_Bestuursorgaan SetBestuursorgaan(ClubCloud_Bestuursorgaan entity, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Bestuursorgaan response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetBestuursorgaan(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteBestuursorgaan(ClubCloud_Bestuursorgaan entity, ClubCloud_Setting settings = null)
        {
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteBestuursorgaan(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteBestuursorgaanById(System.Guid Id, ClubCloud_Setting settings = null)
    	{
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteBestuursorgaanById(Id, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public ClubCloud_Bestuursorgaan_View GetBestuursorganenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Bestuursorgaan_View response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBestuursorganenByQuery(bondsnummer, verenigingId, selectArgs, parameters, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_Bestuursorgaan> GetBestuursorganenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null)
    	{
    		List<ClubCloud_Bestuursorgaan> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBestuursorganenBySearch(prefixText, count, contextKey, settings);
                },
                false);
    
    		return response;
    	}
    
    
    	public List<ClubCloud_Functionaris> GetFunctionarissenForBestuursorgaan(ClubCloud_Bestuursorgaan entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            List<ClubCloud_Functionaris> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetFunctionarissenForBestuursorgaan(entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	public bool SetFunctionarissenForBestuursorgaan(List<ClubCloud_Functionaris> Functionarissen, ClubCloud_Bestuursorgaan entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetFunctionarissenForBestuursorgaan(Functionarissen, entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	public List<ClubCloud_Functionaris> GetFunctionarissenForBestuursorgaanById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    List<ClubCloud_Functionaris> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetFunctionarissenForBestuursorgaanById(Id, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	
    	public ClubCloud_Vereniging GetVerenigingForBestuursorgaan(ClubCloud_Bestuursorgaan entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            ClubCloud_Vereniging response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetVerenigingForBestuursorgaan(entity, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	public bool SetVerenigingForBestuursorgaan(ClubCloud_Vereniging Vereniging, ClubCloud_Bestuursorgaan entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    	    bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetVerenigingForBestuursorgaan(Vereniging, entity , refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	
    	public ClubCloud_Vereniging GetVerenigingForBestuursorgaanById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    ClubCloud_Vereniging response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetVerenigingForBestuursorgaanById(Id, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	    public ClubCloud_Rechtsvorm GetRechtsvormById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Rechtsvorm response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetRechtsvormById(Id, refresh, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_Rechtsvorm> GetRechtsvormen(bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_Rechtsvorm> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetRechtsvormen(refresh, settings);
                },
                false);
    
            return response;
        }
    
        public ClubCloud_Rechtsvorm SetRechtsvorm(ClubCloud_Rechtsvorm entity, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Rechtsvorm response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetRechtsvorm(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteRechtsvorm(ClubCloud_Rechtsvorm entity, ClubCloud_Setting settings = null)
        {
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteRechtsvorm(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteRechtsvormById(System.Guid Id, ClubCloud_Setting settings = null)
    	{
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteRechtsvormById(Id, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public ClubCloud_Rechtsvorm_View GetRechtsvormenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Rechtsvorm_View response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetRechtsvormenByQuery(bondsnummer, verenigingId, selectArgs, parameters, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_Rechtsvorm> GetRechtsvormenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null)
    	{
    		List<ClubCloud_Rechtsvorm> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetRechtsvormenBySearch(prefixText, count, contextKey, settings);
                },
                false);
    
    		return response;
    	}
    
    
    	public List<ClubCloud_Vereniging> GetVerenigingenForRechtsvorm(ClubCloud_Rechtsvorm entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            List<ClubCloud_Vereniging> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetVerenigingenForRechtsvorm(entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	public bool SetVerenigingenForRechtsvorm(List<ClubCloud_Vereniging> Verenigingen, ClubCloud_Rechtsvorm entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetVerenigingenForRechtsvorm(Verenigingen, entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	public List<ClubCloud_Vereniging> GetVerenigingenForRechtsvormById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    List<ClubCloud_Vereniging> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetVerenigingenForRechtsvormById(Id, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	    public ClubCloud_Address GetAddressById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Address response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetAddressById(Id, refresh, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_Address> GetAddressen(bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_Address> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetAddressen(refresh, settings);
                },
                false);
    
            return response;
        }
    
        public ClubCloud_Address SetAddress(ClubCloud_Address entity, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Address response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetAddress(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteAddress(ClubCloud_Address entity, ClubCloud_Setting settings = null)
        {
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteAddress(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteAddressById(System.Guid Id, ClubCloud_Setting settings = null)
    	{
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteAddressById(Id, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public ClubCloud_Address_View GetAddressenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Address_View response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetAddressenByQuery(bondsnummer, verenigingId, selectArgs, parameters, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_Address> GetAddressenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null)
    	{
    		List<ClubCloud_Address> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetAddressenBySearch(prefixText, count, contextKey, settings);
                },
                false);
    
    		return response;
    	}
    
    
    	public ClubCloud_Vereniging GetVerenigingForAddress(ClubCloud_Address entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            ClubCloud_Vereniging response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetVerenigingForAddress(entity, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	public bool SetVerenigingForAddress(ClubCloud_Vereniging Vereniging, ClubCloud_Address entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    	    bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetVerenigingForAddress(Vereniging, entity , refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	
    	public ClubCloud_Vereniging GetVerenigingForAddressById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    ClubCloud_Vereniging response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetVerenigingForAddressById(Id, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	
    	public ClubCloud_Gebruiker GetGebruikerForAddress(ClubCloud_Address entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            ClubCloud_Gebruiker response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetGebruikerForAddress(entity, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	public bool SetGebruikerForAddress(ClubCloud_Gebruiker Gebruiker, ClubCloud_Address entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    	    bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetGebruikerForAddress(Gebruiker, entity , refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	
    	public ClubCloud_Gebruiker GetGebruikerForAddressById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    ClubCloud_Gebruiker response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetGebruikerForAddressById(Id, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	
    	public ClubCloud_Regio GetRegioForAddress(ClubCloud_Address entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            ClubCloud_Regio response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetRegioForAddress(entity, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	public bool SetRegioForAddress(ClubCloud_Regio Regio, ClubCloud_Address entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    	    bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetRegioForAddress(Regio, entity , refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	
    	public ClubCloud_Regio GetRegioForAddressById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    ClubCloud_Regio response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetRegioForAddressById(Id, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	
    	public ClubCloud_Accommodatie GetAccommodatieForAddress(ClubCloud_Address entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            ClubCloud_Accommodatie response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetAccommodatieForAddress(entity, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	public bool SetAccommodatieForAddress(ClubCloud_Accommodatie Accommodatie, ClubCloud_Address entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    	    bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetAccommodatieForAddress(Accommodatie, entity , refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	
    	public ClubCloud_Accommodatie GetAccommodatieForAddressById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    ClubCloud_Accommodatie response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetAccommodatieForAddressById(Id, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	
    	public ClubCloud_Land GetLandForAddress(ClubCloud_Address entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            ClubCloud_Land response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetLandForAddress(entity, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	public bool SetLandForAddress(ClubCloud_Land Land, ClubCloud_Address entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    	    bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetLandForAddress(Land, entity , refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	
    	public ClubCloud_Land GetLandForAddressById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    ClubCloud_Land response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetLandForAddressById(Id, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	    public ClubCloud_Regio GetRegioById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Regio response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetRegioById(Id, refresh, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_Regio> GetRegios(bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_Regio> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetRegios(refresh, settings);
                },
                false);
    
            return response;
        }
    
        public ClubCloud_Regio SetRegio(ClubCloud_Regio entity, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Regio response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetRegio(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteRegio(ClubCloud_Regio entity, ClubCloud_Setting settings = null)
        {
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteRegio(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteRegioById(System.Guid Id, ClubCloud_Setting settings = null)
    	{
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteRegioById(Id, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public ClubCloud_Regio_View GetRegiosByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Regio_View response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetRegiosByQuery(bondsnummer, verenigingId, selectArgs, parameters, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_Regio> GetRegiosBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null)
    	{
    		List<ClubCloud_Regio> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetRegiosBySearch(prefixText, count, contextKey, settings);
                },
                false);
    
    		return response;
    	}
    
    
    	public List<ClubCloud_Vereniging> GetVerenigingenForRegio(ClubCloud_Regio entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            List<ClubCloud_Vereniging> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetVerenigingenForRegio(entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	public bool SetVerenigingenForRegio(List<ClubCloud_Vereniging> Verenigingen, ClubCloud_Regio entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetVerenigingenForRegio(Verenigingen, entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	public List<ClubCloud_Vereniging> GetVerenigingenForRegioById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    List<ClubCloud_Vereniging> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetVerenigingenForRegioById(Id, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	
    	public List<ClubCloud_District> GetDistrictenForRegio(ClubCloud_Regio entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            List<ClubCloud_District> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetDistrictenForRegio(entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	public bool SetDistrictenForRegio(List<ClubCloud_District> Districten, ClubCloud_Regio entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetDistrictenForRegio(Districten, entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	public List<ClubCloud_District> GetDistrictenForRegioById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    List<ClubCloud_District> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetDistrictenForRegioById(Id, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	
    	public List<ClubCloud_Accommodatie> GetAccommodatiesForRegio(ClubCloud_Regio entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            List<ClubCloud_Accommodatie> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetAccommodatiesForRegio(entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	public bool SetAccommodatiesForRegio(List<ClubCloud_Accommodatie> Accommodaties, ClubCloud_Regio entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetAccommodatiesForRegio(Accommodaties, entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	public List<ClubCloud_Accommodatie> GetAccommodatiesForRegioById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    List<ClubCloud_Accommodatie> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetAccommodatiesForRegioById(Id, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	
    	public List<ClubCloud_Address> GetAddressenForRegio(ClubCloud_Regio entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            List<ClubCloud_Address> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetAddressenForRegio(entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	public bool SetAddressenForRegio(List<ClubCloud_Address> Addressen, ClubCloud_Regio entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetAddressenForRegio(Addressen, entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	public List<ClubCloud_Address> GetAddressenForRegioById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    List<ClubCloud_Address> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetAddressenForRegioById(Id, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	    public ClubCloud_Baansoort GetBaansoortById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Baansoort response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBaansoortById(Id, refresh, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_Baansoort> GetBaansoorten(bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_Baansoort> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBaansoorten(refresh, settings);
                },
                false);
    
            return response;
        }
    
        public ClubCloud_Baansoort SetBaansoort(ClubCloud_Baansoort entity, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Baansoort response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetBaansoort(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteBaansoort(ClubCloud_Baansoort entity, ClubCloud_Setting settings = null)
        {
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteBaansoort(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteBaansoortById(System.Guid Id, ClubCloud_Setting settings = null)
    	{
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteBaansoortById(Id, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public ClubCloud_Baansoort_View GetBaansoortenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Baansoort_View response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBaansoortenByQuery(bondsnummer, verenigingId, selectArgs, parameters, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_Baansoort> GetBaansoortenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null)
    	{
    		List<ClubCloud_Baansoort> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBaansoortenBySearch(prefixText, count, contextKey, settings);
                },
                false);
    
    		return response;
    	}
    
    
    	public ClubCloud_Baantype GetBaantypeForBaansoort(ClubCloud_Baansoort entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            ClubCloud_Baantype response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBaantypeForBaansoort(entity, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	public bool SetBaantypeForBaansoort(ClubCloud_Baantype Baantype, ClubCloud_Baansoort entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    	    bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetBaantypeForBaansoort(Baantype, entity , refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	
    	public ClubCloud_Baantype GetBaantypeForBaansoortById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    ClubCloud_Baantype response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBaantypeForBaansoortById(Id, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	
    	public List<ClubCloud_Baanblok> GetBaanblokkenForBaansoort(ClubCloud_Baansoort entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            List<ClubCloud_Baanblok> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBaanblokkenForBaansoort(entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	public bool SetBaanblokkenForBaansoort(List<ClubCloud_Baanblok> Baanblokken, ClubCloud_Baansoort entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetBaanblokkenForBaansoort(Baanblokken, entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	public List<ClubCloud_Baanblok> GetBaanblokkenForBaansoortById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    List<ClubCloud_Baanblok> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBaanblokkenForBaansoortById(Id, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	    public ClubCloud_Baantype GetBaantypeById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Baantype response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBaantypeById(Id, refresh, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_Baantype> GetBaantypes(bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_Baantype> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBaantypes(refresh, settings);
                },
                false);
    
            return response;
        }
    
        public ClubCloud_Baantype SetBaantype(ClubCloud_Baantype entity, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Baantype response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetBaantype(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteBaantype(ClubCloud_Baantype entity, ClubCloud_Setting settings = null)
        {
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteBaantype(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteBaantypeById(System.Guid Id, ClubCloud_Setting settings = null)
    	{
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteBaantypeById(Id, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public ClubCloud_Baantype_View GetBaantypesByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Baantype_View response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBaantypesByQuery(bondsnummer, verenigingId, selectArgs, parameters, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_Baantype> GetBaantypesBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null)
    	{
    		List<ClubCloud_Baantype> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBaantypesBySearch(prefixText, count, contextKey, settings);
                },
                false);
    
    		return response;
    	}
    
    
    	public List<ClubCloud_Baansoort> GetBaansoortenForBaantype(ClubCloud_Baantype entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            List<ClubCloud_Baansoort> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBaansoortenForBaantype(entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	public bool SetBaansoortenForBaantype(List<ClubCloud_Baansoort> Baansoorten, ClubCloud_Baantype entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetBaansoortenForBaantype(Baansoorten, entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	public List<ClubCloud_Baansoort> GetBaansoortenForBaantypeById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    List<ClubCloud_Baansoort> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBaansoortenForBaantypeById(Id, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	
    	public List<ClubCloud_Baanblok> GetBaanblokkenForBaantype(ClubCloud_Baantype entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            List<ClubCloud_Baanblok> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBaanblokkenForBaantype(entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	public bool SetBaanblokkenForBaantype(List<ClubCloud_Baanblok> Baanblokken, ClubCloud_Baantype entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetBaanblokkenForBaantype(Baanblokken, entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	public List<ClubCloud_Baanblok> GetBaanblokkenForBaantypeById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    List<ClubCloud_Baanblok> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBaanblokkenForBaantypeById(Id, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	    public ClubCloud_Baan GetBaanById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Baan response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBaanById(Id, refresh, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_Baan> GetBanen(bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_Baan> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBanen(refresh, settings);
                },
                false);
    
            return response;
        }
    
        public ClubCloud_Baan SetBaan(ClubCloud_Baan entity, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Baan response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetBaan(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteBaan(ClubCloud_Baan entity, ClubCloud_Setting settings = null)
        {
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteBaan(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteBaanById(System.Guid Id, ClubCloud_Setting settings = null)
    	{
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteBaanById(Id, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public ClubCloud_Baan_View GetBanenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Baan_View response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBanenByQuery(bondsnummer, verenigingId, selectArgs, parameters, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_Baan> GetBanenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null)
    	{
    		List<ClubCloud_Baan> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBanenBySearch(prefixText, count, contextKey, settings);
                },
                false);
    
    		return response;
    	}
    
    
    	public ClubCloud_Baanblok GetBaanblokForBaan(ClubCloud_Baan entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            ClubCloud_Baanblok response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBaanblokForBaan(entity, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	public bool SetBaanblokForBaan(ClubCloud_Baanblok Baanblok, ClubCloud_Baan entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    	    bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetBaanblokForBaan(Baanblok, entity , refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	
    	public ClubCloud_Baanblok GetBaanblokForBaanById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    ClubCloud_Baanblok response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBaanblokForBaanById(Id, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	
    	public ClubCloud_Accommodatie GetAccommodatieForBaan(ClubCloud_Baan entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            ClubCloud_Accommodatie response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetAccommodatieForBaan(entity, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	public bool SetAccommodatieForBaan(ClubCloud_Accommodatie Accommodatie, ClubCloud_Baan entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    	    bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetAccommodatieForBaan(Accommodatie, entity , refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	
    	public ClubCloud_Accommodatie GetAccommodatieForBaanById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    ClubCloud_Accommodatie response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetAccommodatieForBaanById(Id, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	
    	public List<ClubCloud_Baanschema> GetBaanschemasForBaan(ClubCloud_Baan entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            List<ClubCloud_Baanschema> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBaanschemasForBaan(entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	public bool SetBaanschemasForBaan(List<ClubCloud_Baanschema> Baanschemas, ClubCloud_Baan entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetBaanschemasForBaan(Baanschemas, entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	public List<ClubCloud_Baanschema> GetBaanschemasForBaanById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    List<ClubCloud_Baanschema> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBaanschemasForBaanById(Id, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	    public ClubCloud_Bouwaard GetBouwaardById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Bouwaard response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBouwaardById(Id, refresh, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_Bouwaard> GetBouwaarden(bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_Bouwaard> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBouwaarden(refresh, settings);
                },
                false);
    
            return response;
        }
    
        public ClubCloud_Bouwaard SetBouwaard(ClubCloud_Bouwaard entity, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Bouwaard response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetBouwaard(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteBouwaard(ClubCloud_Bouwaard entity, ClubCloud_Setting settings = null)
        {
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteBouwaard(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteBouwaardById(System.Guid Id, ClubCloud_Setting settings = null)
    	{
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteBouwaardById(Id, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public ClubCloud_Bouwaard_View GetBouwaardenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Bouwaard_View response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBouwaardenByQuery(bondsnummer, verenigingId, selectArgs, parameters, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_Bouwaard> GetBouwaardenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null)
    	{
    		List<ClubCloud_Bouwaard> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBouwaardenBySearch(prefixText, count, contextKey, settings);
                },
                false);
    
    		return response;
    	}
    
        public ClubCloud_BaanSpeciaal GetBaanSpeciaalById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_BaanSpeciaal response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBaanSpeciaalById(Id, refresh, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_BaanSpeciaal> GetBanenSpeciaal(bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_BaanSpeciaal> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBanenSpeciaal(refresh, settings);
                },
                false);
    
            return response;
        }
    
        public ClubCloud_BaanSpeciaal SetBaanSpeciaal(ClubCloud_BaanSpeciaal entity, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_BaanSpeciaal response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetBaanSpeciaal(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteBaanSpeciaal(ClubCloud_BaanSpeciaal entity, ClubCloud_Setting settings = null)
        {
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteBaanSpeciaal(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteBaanSpeciaalById(System.Guid Id, ClubCloud_Setting settings = null)
    	{
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteBaanSpeciaalById(Id, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public ClubCloud_BaanSpeciaal_View GetBanenSpeciaalByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_BaanSpeciaal_View response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBanenSpeciaalByQuery(bondsnummer, verenigingId, selectArgs, parameters, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_BaanSpeciaal> GetBanenSpeciaalBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null)
    	{
    		List<ClubCloud_BaanSpeciaal> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBanenSpeciaalBySearch(prefixText, count, contextKey, settings);
                },
                false);
    
    		return response;
    	}
    
    
    	public ClubCloud_Accommodatie GetAccommodatieForBaanSpeciaal(ClubCloud_BaanSpeciaal entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            ClubCloud_Accommodatie response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetAccommodatieForBaanSpeciaal(entity, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	public bool SetAccommodatieForBaanSpeciaal(ClubCloud_Accommodatie Accommodatie, ClubCloud_BaanSpeciaal entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    	    bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetAccommodatieForBaanSpeciaal(Accommodatie, entity , refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	
    	public ClubCloud_Accommodatie GetAccommodatieForBaanSpeciaalById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    ClubCloud_Accommodatie response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetAccommodatieForBaanSpeciaalById(Id, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	
    	public ClubCloud_Baantoplaag GetBaantoplaagForBaanSpeciaal(ClubCloud_BaanSpeciaal entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            ClubCloud_Baantoplaag response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBaantoplaagForBaanSpeciaal(entity, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	public bool SetBaantoplaagForBaanSpeciaal(ClubCloud_Baantoplaag Baantoplaag, ClubCloud_BaanSpeciaal entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    	    bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetBaantoplaagForBaanSpeciaal(Baantoplaag, entity , refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	
    	public ClubCloud_Baantoplaag GetBaantoplaagForBaanSpeciaalById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    ClubCloud_Baantoplaag response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBaantoplaagForBaanSpeciaalById(Id, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	    public ClubCloud_Reservering GetReserveringById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Reservering response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetReserveringById(Id, refresh, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_Reservering> GetReserveringen(bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_Reservering> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetReserveringen(refresh, settings);
                },
                false);
    
            return response;
        }
    
        public ClubCloud_Reservering SetReservering(ClubCloud_Reservering entity, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Reservering response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetReservering(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteReservering(ClubCloud_Reservering entity, ClubCloud_Setting settings = null)
        {
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteReservering(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteReserveringById(System.Guid Id, ClubCloud_Setting settings = null)
    	{
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteReserveringById(Id, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public ClubCloud_Reservering_View GetReserveringenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Reservering_View response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetReserveringenByQuery(bondsnummer, verenigingId, selectArgs, parameters, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_Reservering> GetReserveringenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null)
    	{
    		List<ClubCloud_Reservering> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetReserveringenBySearch(prefixText, count, contextKey, settings);
                },
                false);
    
    		return response;
    	}
    
        public ClubCloud_Afhang GetAfhangById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Afhang response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetAfhangById(Id, refresh, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_Afhang> GetAfhangen(bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_Afhang> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetAfhangen(refresh, settings);
                },
                false);
    
            return response;
        }
    
        public ClubCloud_Afhang SetAfhang(ClubCloud_Afhang entity, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Afhang response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetAfhang(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteAfhang(ClubCloud_Afhang entity, ClubCloud_Setting settings = null)
        {
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteAfhang(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteAfhangById(System.Guid Id, ClubCloud_Setting settings = null)
    	{
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteAfhangById(Id, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public ClubCloud_Afhang_View GetAfhangenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Afhang_View response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetAfhangenByQuery(bondsnummer, verenigingId, selectArgs, parameters, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_Afhang> GetAfhangenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null)
    	{
    		List<ClubCloud_Afhang> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetAfhangenBySearch(prefixText, count, contextKey, settings);
                },
                false);
    
    		return response;
    	}
    
    
    	public ClubCloud_Vereniging GetVerenigingForAfhang(ClubCloud_Afhang entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            ClubCloud_Vereniging response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetVerenigingForAfhang(entity, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	public bool SetVerenigingForAfhang(ClubCloud_Vereniging Vereniging, ClubCloud_Afhang entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    	    bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetVerenigingForAfhang(Vereniging, entity , refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	
    	public ClubCloud_Vereniging GetVerenigingForAfhangById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    ClubCloud_Vereniging response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetVerenigingForAfhangById(Id, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	    public ClubCloud_Baanschema GetBaanschemaById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Baanschema response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBaanschemaById(Id, refresh, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_Baanschema> GetBaanschemas(bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_Baanschema> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBaanschemas(refresh, settings);
                },
                false);
    
            return response;
        }
    
        public ClubCloud_Baanschema SetBaanschema(ClubCloud_Baanschema entity, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Baanschema response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetBaanschema(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteBaanschema(ClubCloud_Baanschema entity, ClubCloud_Setting settings = null)
        {
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteBaanschema(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteBaanschemaById(System.Guid Id, ClubCloud_Setting settings = null)
    	{
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteBaanschemaById(Id, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public ClubCloud_Baanschema_View GetBaanschemasByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Baanschema_View response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBaanschemasByQuery(bondsnummer, verenigingId, selectArgs, parameters, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_Baanschema> GetBaanschemasBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null)
    	{
    		List<ClubCloud_Baanschema> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBaanschemasBySearch(prefixText, count, contextKey, settings);
                },
                false);
    
    		return response;
    	}
    
    
    	public ClubCloud_Baan GetBaanForBaanschema(ClubCloud_Baanschema entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            ClubCloud_Baan response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBaanForBaanschema(entity, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	public bool SetBaanForBaanschema(ClubCloud_Baan Baan, ClubCloud_Baanschema entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    	    bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetBaanForBaanschema(Baan, entity , refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	
    	public ClubCloud_Baan GetBaanForBaanschemaById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    ClubCloud_Baan response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBaanForBaanschemaById(Id, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	
    	public ClubCloud_Vereniging GetVerenigingForBaanschema(ClubCloud_Baanschema entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            ClubCloud_Vereniging response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetVerenigingForBaanschema(entity, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	public bool SetVerenigingForBaanschema(ClubCloud_Vereniging Vereniging, ClubCloud_Baanschema entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    	    bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetVerenigingForBaanschema(Vereniging, entity , refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	
    	public ClubCloud_Vereniging GetVerenigingForBaanschemaById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    ClubCloud_Vereniging response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetVerenigingForBaanschemaById(Id, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	    public ClubCloud_Foto GetFotoById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Foto response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetFotoById(Id, refresh, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_Foto> GetFotos(bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_Foto> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetFotos(refresh, settings);
                },
                false);
    
            return response;
        }
    
        public ClubCloud_Foto SetFoto(ClubCloud_Foto entity, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Foto response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetFoto(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteFoto(ClubCloud_Foto entity, ClubCloud_Setting settings = null)
        {
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteFoto(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteFotoById(System.Guid Id, ClubCloud_Setting settings = null)
    	{
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteFotoById(Id, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public ClubCloud_Foto_View GetFotosByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Foto_View response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetFotosByQuery(bondsnummer, verenigingId, selectArgs, parameters, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_Foto> GetFotosBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null)
    	{
    		List<ClubCloud_Foto> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetFotosBySearch(prefixText, count, contextKey, settings);
                },
                false);
    
    		return response;
    	}
    
        public ClubCloud_Lidmaatschapsoort GetLidmaatschapsoortById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Lidmaatschapsoort response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetLidmaatschapsoortById(Id, refresh, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_Lidmaatschapsoort> GetLidmaatschapsoorten(bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_Lidmaatschapsoort> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetLidmaatschapsoorten(refresh, settings);
                },
                false);
    
            return response;
        }
    
        public ClubCloud_Lidmaatschapsoort SetLidmaatschapsoort(ClubCloud_Lidmaatschapsoort entity, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Lidmaatschapsoort response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetLidmaatschapsoort(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteLidmaatschapsoort(ClubCloud_Lidmaatschapsoort entity, ClubCloud_Setting settings = null)
        {
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteLidmaatschapsoort(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteLidmaatschapsoortById(System.Guid Id, ClubCloud_Setting settings = null)
    	{
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteLidmaatschapsoortById(Id, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public ClubCloud_Lidmaatschapsoort_View GetLidmaatschapsoortenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Lidmaatschapsoort_View response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetLidmaatschapsoortenByQuery(bondsnummer, verenigingId, selectArgs, parameters, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_Lidmaatschapsoort> GetLidmaatschapsoortenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null)
    	{
    		List<ClubCloud_Lidmaatschapsoort> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetLidmaatschapsoortenBySearch(prefixText, count, contextKey, settings);
                },
                false);
    
    		return response;
    	}
    
    
    	public List<ClubCloud_Lidmaatschap> GetLidmaatschappenForLidmaatschapsoort(ClubCloud_Lidmaatschapsoort entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            List<ClubCloud_Lidmaatschap> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetLidmaatschappenForLidmaatschapsoort(entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	public bool SetLidmaatschappenForLidmaatschapsoort(List<ClubCloud_Lidmaatschap> Lidmaatschappen, ClubCloud_Lidmaatschapsoort entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetLidmaatschappenForLidmaatschapsoort(Lidmaatschappen, entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	public List<ClubCloud_Lidmaatschap> GetLidmaatschappenForLidmaatschapsoortById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    List<ClubCloud_Lidmaatschap> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetLidmaatschappenForLidmaatschapsoortById(Id, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	
    	public ClubCloud_Vereniging GetVerenigingForLidmaatschapsoort(ClubCloud_Lidmaatschapsoort entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            ClubCloud_Vereniging response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetVerenigingForLidmaatschapsoort(entity, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	public bool SetVerenigingForLidmaatschapsoort(ClubCloud_Vereniging Vereniging, ClubCloud_Lidmaatschapsoort entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    	    bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetVerenigingForLidmaatschapsoort(Vereniging, entity , refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	
    	public ClubCloud_Vereniging GetVerenigingForLidmaatschapsoortById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    ClubCloud_Vereniging response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetVerenigingForLidmaatschapsoortById(Id, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	    public ClubCloud_Sponsor GetSponsorById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Sponsor response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetSponsorById(Id, refresh, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_Sponsor> GetSponsoren(bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_Sponsor> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetSponsoren(refresh, settings);
                },
                false);
    
            return response;
        }
    
        public ClubCloud_Sponsor SetSponsor(ClubCloud_Sponsor entity, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Sponsor response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetSponsor(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteSponsor(ClubCloud_Sponsor entity, ClubCloud_Setting settings = null)
        {
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteSponsor(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteSponsorById(System.Guid Id, ClubCloud_Setting settings = null)
    	{
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteSponsorById(Id, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public ClubCloud_Sponsor_View GetSponsorenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Sponsor_View response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetSponsorenByQuery(bondsnummer, verenigingId, selectArgs, parameters, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_Sponsor> GetSponsorenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null)
    	{
    		List<ClubCloud_Sponsor> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetSponsorenBySearch(prefixText, count, contextKey, settings);
                },
                false);
    
    		return response;
    	}
    
    
    	public ClubCloud_Vereniging GetVerenigingForSponsor(ClubCloud_Sponsor entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            ClubCloud_Vereniging response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetVerenigingForSponsor(entity, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	public bool SetVerenigingForSponsor(ClubCloud_Vereniging Vereniging, ClubCloud_Sponsor entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    	    bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetVerenigingForSponsor(Vereniging, entity , refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	
    	public ClubCloud_Vereniging GetVerenigingForSponsorById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    ClubCloud_Vereniging response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetVerenigingForSponsorById(Id, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	
    	public ClubCloud_Sponsor_Afbeelding GetAfbeeldingForSponsor(ClubCloud_Sponsor entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            ClubCloud_Sponsor_Afbeelding response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetAfbeeldingForSponsor(entity, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	public bool SetAfbeeldingForSponsor(ClubCloud_Sponsor_Afbeelding Afbeelding, ClubCloud_Sponsor entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    	    bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetAfbeeldingForSponsor(Afbeelding, entity , refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	
    	public ClubCloud_Sponsor_Afbeelding GetAfbeeldingForSponsorById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    ClubCloud_Sponsor_Afbeelding response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetAfbeeldingForSponsorById(Id, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	    public ClubCloud_Sponsor_Afbeelding GetAfbeeldingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Sponsor_Afbeelding response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetAfbeeldingById(Id, refresh, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_Sponsor_Afbeelding> GetAfbeeldingen(bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_Sponsor_Afbeelding> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetAfbeeldingen(refresh, settings);
                },
                false);
    
            return response;
        }
    
        public ClubCloud_Sponsor_Afbeelding SetAfbeelding(ClubCloud_Sponsor_Afbeelding entity, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Sponsor_Afbeelding response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetAfbeelding(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteAfbeelding(ClubCloud_Sponsor_Afbeelding entity, ClubCloud_Setting settings = null)
        {
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteAfbeelding(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteAfbeeldingById(System.Guid Id, ClubCloud_Setting settings = null)
    	{
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteAfbeeldingById(Id, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public ClubCloud_Sponsor_Afbeelding_View GetAfbeeldingenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Sponsor_Afbeelding_View response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetAfbeeldingenByQuery(bondsnummer, verenigingId, selectArgs, parameters, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_Sponsor_Afbeelding> GetAfbeeldingenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null)
    	{
    		List<ClubCloud_Sponsor_Afbeelding> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetAfbeeldingenBySearch(prefixText, count, contextKey, settings);
                },
                false);
    
    		return response;
    	}
    
    
    	public List<ClubCloud_Sponsor> GetSponsorenForAfbeelding(ClubCloud_Sponsor_Afbeelding entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            List<ClubCloud_Sponsor> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetSponsorenForAfbeelding(entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	public bool SetSponsorenForAfbeelding(List<ClubCloud_Sponsor> Sponsoren, ClubCloud_Sponsor_Afbeelding entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetSponsorenForAfbeelding(Sponsoren, entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	public List<ClubCloud_Sponsor> GetSponsorenForAfbeeldingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    List<ClubCloud_Sponsor> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetSponsorenForAfbeeldingById(Id, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	    public ClubCloud_Baanblok GetBaanblokById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Baanblok response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBaanblokById(Id, refresh, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_Baanblok> GetBaanblokken(bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_Baanblok> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBaanblokken(refresh, settings);
                },
                false);
    
            return response;
        }
    
        public ClubCloud_Baanblok SetBaanblok(ClubCloud_Baanblok entity, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Baanblok response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetBaanblok(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteBaanblok(ClubCloud_Baanblok entity, ClubCloud_Setting settings = null)
        {
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteBaanblok(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteBaanblokById(System.Guid Id, ClubCloud_Setting settings = null)
    	{
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteBaanblokById(Id, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public ClubCloud_Baanblok_View GetBaanblokkenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Baanblok_View response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBaanblokkenByQuery(bondsnummer, verenigingId, selectArgs, parameters, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_Baanblok> GetBaanblokkenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null)
    	{
    		List<ClubCloud_Baanblok> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBaanblokkenBySearch(prefixText, count, contextKey, settings);
                },
                false);
    
    		return response;
    	}
    
    
    	public List<ClubCloud_Baan> GetBanenForBaanblok(ClubCloud_Baanblok entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            List<ClubCloud_Baan> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBanenForBaanblok(entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	public bool SetBanenForBaanblok(List<ClubCloud_Baan> Banen, ClubCloud_Baanblok entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetBanenForBaanblok(Banen, entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	public List<ClubCloud_Baan> GetBanenForBaanblokById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    List<ClubCloud_Baan> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBanenForBaanblokById(Id, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	
    	public ClubCloud_Accommodatie GetAccommodatieForBaanblok(ClubCloud_Baanblok entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            ClubCloud_Accommodatie response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetAccommodatieForBaanblok(entity, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	public bool SetAccommodatieForBaanblok(ClubCloud_Accommodatie Accommodatie, ClubCloud_Baanblok entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    	    bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetAccommodatieForBaanblok(Accommodatie, entity , refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	
    	public ClubCloud_Accommodatie GetAccommodatieForBaanblokById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    ClubCloud_Accommodatie response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetAccommodatieForBaanblokById(Id, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	
    	public ClubCloud_Baantype GetBaantypeForBaanblok(ClubCloud_Baanblok entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            ClubCloud_Baantype response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBaantypeForBaanblok(entity, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	public bool SetBaantypeForBaanblok(ClubCloud_Baantype Baantype, ClubCloud_Baanblok entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    	    bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetBaantypeForBaanblok(Baantype, entity , refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	
    	public ClubCloud_Baantype GetBaantypeForBaanblokById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    ClubCloud_Baantype response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBaantypeForBaanblokById(Id, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	
    	public ClubCloud_Baansoort GetBaansoortForBaanblok(ClubCloud_Baanblok entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            ClubCloud_Baansoort response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBaansoortForBaanblok(entity, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	public bool SetBaansoortForBaanblok(ClubCloud_Baansoort Baansoort, ClubCloud_Baanblok entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    	    bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetBaansoortForBaanblok(Baansoort, entity , refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	
    	public ClubCloud_Baansoort GetBaansoortForBaanblokById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    ClubCloud_Baansoort response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBaansoortForBaanblokById(Id, refresh, settings);
                },
                false);
    
            return response;	
    	}
    
    	    public ClubCloud_Baantoplaag GetBaantoplaagById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Baantoplaag response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBaantoplaagById(Id, refresh, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_Baantoplaag> GetBaantoplagen(bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_Baantoplaag> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBaantoplagen(refresh, settings);
                },
                false);
    
            return response;
        }
    
        public ClubCloud_Baantoplaag SetBaantoplaag(ClubCloud_Baantoplaag entity, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Baantoplaag response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetBaantoplaag(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteBaantoplaag(ClubCloud_Baantoplaag entity, ClubCloud_Setting settings = null)
        {
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteBaantoplaag(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteBaantoplaagById(System.Guid Id, ClubCloud_Setting settings = null)
    	{
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteBaantoplaagById(Id, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public ClubCloud_Baantoplaag_View GetBaantoplagenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Baantoplaag_View response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBaantoplagenByQuery(bondsnummer, verenigingId, selectArgs, parameters, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_Baantoplaag> GetBaantoplagenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null)
    	{
    		List<ClubCloud_Baantoplaag> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBaantoplagenBySearch(prefixText, count, contextKey, settings);
                },
                false);
    
    		return response;
    	}
    
    
    	public List<ClubCloud_BaanSpeciaal> GetBanenSpeciaalForBaantoplaag(ClubCloud_Baantoplaag entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            List<ClubCloud_BaanSpeciaal> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBanenSpeciaalForBaantoplaag(entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	public bool SetBanenSpeciaalForBaantoplaag(List<ClubCloud_BaanSpeciaal> BanenSpeciaal, ClubCloud_Baantoplaag entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetBanenSpeciaalForBaantoplaag(BanenSpeciaal, entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	public List<ClubCloud_BaanSpeciaal> GetBanenSpeciaalForBaantoplaagById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    List<ClubCloud_BaanSpeciaal> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBanenSpeciaalForBaantoplaagById(Id, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	    public ClubCloud_Land GetLandById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Land response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetLandById(Id, refresh, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_Land> GetLanden(bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_Land> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetLanden(refresh, settings);
                },
                false);
    
            return response;
        }
    
        public ClubCloud_Land SetLand(ClubCloud_Land entity, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Land response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetLand(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteLand(ClubCloud_Land entity, ClubCloud_Setting settings = null)
        {
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteLand(entity, settings);
                },
                false);
    
            return response;
    
        }
    
    	public bool DeleteLandById(System.Guid Id, ClubCloud_Setting settings = null)
    	{
    
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteLandById(Id, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public ClubCloud_Land_View GetLandenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null)
        {
    
            ClubCloud_Land_View response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetLandenByQuery(bondsnummer, verenigingId, selectArgs, parameters, settings);
                },
                false);
    
            return response;
    
        }
    
    
    	public List<ClubCloud_Land> GetLandenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting settings = null)
    	{
    		List<ClubCloud_Land> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetLandenBySearch(prefixText, count, contextKey, settings);
                },
                false);
    
    		return response;
    	}
    
    
    	public List<ClubCloud_Address> GetAddressenForLand(ClubCloud_Land entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            List<ClubCloud_Address> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetAddressenForLand(entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    	public bool SetAddressenForLand(List<ClubCloud_Address> Addressen, ClubCloud_Land entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
            bool response = false;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetAddressenForLand(Addressen, entity, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    	public List<ClubCloud_Address> GetAddressenForLandById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    
    	    List<ClubCloud_Address> response = null;
    
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetAddressenForLandById(Id, refresh, settings);
                },
                false);
    
            return response;
    	}
    
    
    		
    }
}

