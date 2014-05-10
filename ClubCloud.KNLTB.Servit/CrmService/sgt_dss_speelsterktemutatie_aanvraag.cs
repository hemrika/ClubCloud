using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_dss_speelsterktemutatie_aanvraag : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Lookup sgt_aangevraagd_door_idField;
		private Lookup sgt_aangevraagd_dooridField;
		private CrmDecimal sgt_basisgetal_dubbel_gewenste_speelsterkteField;
		private CrmDecimal sgt_basisgetal_dubbel_toegewezenField;
		private CrmDecimal sgt_basisgetal_enkel_gewenste_speelsterkteField;
		private CrmDecimal sgt_basisgetal_enkel_toegewezenField;
		private string sgt_bondsnummerField;
		private CrmDateTime sgt_datum_aangevraagdField;
		private string sgt_dss_nameField;
		private Key sgt_dss_speelsterktemutatie_aanvraagidField;
		private CrmDecimal sgt_eindejaarsrating_dubbelField;
		private CrmDecimal sgt_eindejaarsrating_enkelField;
		private CrmDateTime sgt_geboortedatumField;
		private Picklist sgt_geslachtField;
		private Lookup sgt_naam_speleridField;
		private Lookup sgt_reden_aanvraagidField;
		private CrmNumber sgt_speelsterkte_dubbelField;
		private CrmNumber sgt_speelsterkte_dubbel_gewenste_speelsterkteField;
		private CrmNumber sgt_speelsterkte_dubbel_oudField;
		private CrmNumber sgt_speelsterkte_dubbel_toegewezenField;
		private CrmNumber sgt_speelsterkte_enkelField;
		private CrmNumber sgt_speelsterkte_enkel_gewenste_speelsterkteField;
		private CrmNumber sgt_speelsterkte_enkel_oudField;
		private CrmNumber sgt_speelsterkte_enkel_toegewezenField;
		private Picklist sgt_type_wijzigingField;
		private Lookup sgt_verenigingidField;
		private Sgt_dss_speelsterktemutatie_aanvraagStateInfo statecodeField;
		private Status statuscodeField;
		private CrmNumber timezoneruleversionnumberField;
		private CrmNumber utcconversiontimezonecodeField;
		public Lookup createdby
		{
			get
			{
				return this.createdbyField;
			}
			set
			{
				this.createdbyField = value;
			}
		}
		public CrmDateTime createdon
		{
			get
			{
				return this.createdonField;
			}
			set
			{
				this.createdonField = value;
			}
		}
		public CrmNumber importsequencenumber
		{
			get
			{
				return this.importsequencenumberField;
			}
			set
			{
				this.importsequencenumberField = value;
			}
		}
		public Lookup modifiedby
		{
			get
			{
				return this.modifiedbyField;
			}
			set
			{
				this.modifiedbyField = value;
			}
		}
		public CrmDateTime modifiedon
		{
			get
			{
				return this.modifiedonField;
			}
			set
			{
				this.modifiedonField = value;
			}
		}
		public CrmDateTime overriddencreatedon
		{
			get
			{
				return this.overriddencreatedonField;
			}
			set
			{
				this.overriddencreatedonField = value;
			}
		}
		public Owner ownerid
		{
			get
			{
				return this.owneridField;
			}
			set
			{
				this.owneridField = value;
			}
		}
		public Lookup owningbusinessunit
		{
			get
			{
				return this.owningbusinessunitField;
			}
			set
			{
				this.owningbusinessunitField = value;
			}
		}
		public Lookup sgt_aangevraagd_door_id
		{
			get
			{
				return this.sgt_aangevraagd_door_idField;
			}
			set
			{
				this.sgt_aangevraagd_door_idField = value;
			}
		}
		public Lookup sgt_aangevraagd_doorid
		{
			get
			{
				return this.sgt_aangevraagd_dooridField;
			}
			set
			{
				this.sgt_aangevraagd_dooridField = value;
			}
		}
		public CrmDecimal sgt_basisgetal_dubbel_gewenste_speelsterkte
		{
			get
			{
				return this.sgt_basisgetal_dubbel_gewenste_speelsterkteField;
			}
			set
			{
				this.sgt_basisgetal_dubbel_gewenste_speelsterkteField = value;
			}
		}
		public CrmDecimal sgt_basisgetal_dubbel_toegewezen
		{
			get
			{
				return this.sgt_basisgetal_dubbel_toegewezenField;
			}
			set
			{
				this.sgt_basisgetal_dubbel_toegewezenField = value;
			}
		}
		public CrmDecimal sgt_basisgetal_enkel_gewenste_speelsterkte
		{
			get
			{
				return this.sgt_basisgetal_enkel_gewenste_speelsterkteField;
			}
			set
			{
				this.sgt_basisgetal_enkel_gewenste_speelsterkteField = value;
			}
		}
		public CrmDecimal sgt_basisgetal_enkel_toegewezen
		{
			get
			{
				return this.sgt_basisgetal_enkel_toegewezenField;
			}
			set
			{
				this.sgt_basisgetal_enkel_toegewezenField = value;
			}
		}
		public string sgt_bondsnummer
		{
			get
			{
				return this.sgt_bondsnummerField;
			}
			set
			{
				this.sgt_bondsnummerField = value;
			}
		}
		public CrmDateTime sgt_datum_aangevraagd
		{
			get
			{
				return this.sgt_datum_aangevraagdField;
			}
			set
			{
				this.sgt_datum_aangevraagdField = value;
			}
		}
		public string sgt_dss_name
		{
			get
			{
				return this.sgt_dss_nameField;
			}
			set
			{
				this.sgt_dss_nameField = value;
			}
		}
		public Key sgt_dss_speelsterktemutatie_aanvraagid
		{
			get
			{
				return this.sgt_dss_speelsterktemutatie_aanvraagidField;
			}
			set
			{
				this.sgt_dss_speelsterktemutatie_aanvraagidField = value;
			}
		}
		public CrmDecimal sgt_eindejaarsrating_dubbel
		{
			get
			{
				return this.sgt_eindejaarsrating_dubbelField;
			}
			set
			{
				this.sgt_eindejaarsrating_dubbelField = value;
			}
		}
		public CrmDecimal sgt_eindejaarsrating_enkel
		{
			get
			{
				return this.sgt_eindejaarsrating_enkelField;
			}
			set
			{
				this.sgt_eindejaarsrating_enkelField = value;
			}
		}
		public CrmDateTime sgt_geboortedatum
		{
			get
			{
				return this.sgt_geboortedatumField;
			}
			set
			{
				this.sgt_geboortedatumField = value;
			}
		}
		public Picklist sgt_geslacht
		{
			get
			{
				return this.sgt_geslachtField;
			}
			set
			{
				this.sgt_geslachtField = value;
			}
		}
		public Lookup sgt_naam_spelerid
		{
			get
			{
				return this.sgt_naam_speleridField;
			}
			set
			{
				this.sgt_naam_speleridField = value;
			}
		}
		public Lookup sgt_reden_aanvraagid
		{
			get
			{
				return this.sgt_reden_aanvraagidField;
			}
			set
			{
				this.sgt_reden_aanvraagidField = value;
			}
		}
		public CrmNumber sgt_speelsterkte_dubbel
		{
			get
			{
				return this.sgt_speelsterkte_dubbelField;
			}
			set
			{
				this.sgt_speelsterkte_dubbelField = value;
			}
		}
		public CrmNumber sgt_speelsterkte_dubbel_gewenste_speelsterkte
		{
			get
			{
				return this.sgt_speelsterkte_dubbel_gewenste_speelsterkteField;
			}
			set
			{
				this.sgt_speelsterkte_dubbel_gewenste_speelsterkteField = value;
			}
		}
		public CrmNumber sgt_speelsterkte_dubbel_oud
		{
			get
			{
				return this.sgt_speelsterkte_dubbel_oudField;
			}
			set
			{
				this.sgt_speelsterkte_dubbel_oudField = value;
			}
		}
		public CrmNumber sgt_speelsterkte_dubbel_toegewezen
		{
			get
			{
				return this.sgt_speelsterkte_dubbel_toegewezenField;
			}
			set
			{
				this.sgt_speelsterkte_dubbel_toegewezenField = value;
			}
		}
		public CrmNumber sgt_speelsterkte_enkel
		{
			get
			{
				return this.sgt_speelsterkte_enkelField;
			}
			set
			{
				this.sgt_speelsterkte_enkelField = value;
			}
		}
		public CrmNumber sgt_speelsterkte_enkel_gewenste_speelsterkte
		{
			get
			{
				return this.sgt_speelsterkte_enkel_gewenste_speelsterkteField;
			}
			set
			{
				this.sgt_speelsterkte_enkel_gewenste_speelsterkteField = value;
			}
		}
		public CrmNumber sgt_speelsterkte_enkel_oud
		{
			get
			{
				return this.sgt_speelsterkte_enkel_oudField;
			}
			set
			{
				this.sgt_speelsterkte_enkel_oudField = value;
			}
		}
		public CrmNumber sgt_speelsterkte_enkel_toegewezen
		{
			get
			{
				return this.sgt_speelsterkte_enkel_toegewezenField;
			}
			set
			{
				this.sgt_speelsterkte_enkel_toegewezenField = value;
			}
		}
		public Picklist sgt_type_wijziging
		{
			get
			{
				return this.sgt_type_wijzigingField;
			}
			set
			{
				this.sgt_type_wijzigingField = value;
			}
		}
		public Lookup sgt_verenigingid
		{
			get
			{
				return this.sgt_verenigingidField;
			}
			set
			{
				this.sgt_verenigingidField = value;
			}
		}
		public Sgt_dss_speelsterktemutatie_aanvraagStateInfo statecode
		{
			get
			{
				return this.statecodeField;
			}
			set
			{
				this.statecodeField = value;
			}
		}
		public Status statuscode
		{
			get
			{
				return this.statuscodeField;
			}
			set
			{
				this.statuscodeField = value;
			}
		}
		public CrmNumber timezoneruleversionnumber
		{
			get
			{
				return this.timezoneruleversionnumberField;
			}
			set
			{
				this.timezoneruleversionnumberField = value;
			}
		}
		public CrmNumber utcconversiontimezonecode
		{
			get
			{
				return this.utcconversiontimezonecodeField;
			}
			set
			{
				this.utcconversiontimezonecodeField = value;
			}
		}
	}
}
