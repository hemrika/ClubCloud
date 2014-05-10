using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_dss_speelsterkte : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private CrmBoolean sgt_aanpassenField;
		private CrmBoolean sgt_berekenen_corrigeren_basisgetallenField;
		private CrmBoolean sgt_berekenen_eindejaarsratingField;
		private CrmBoolean sgt_berekenen_speelsterkteField;
		private CrmDateTime sgt_datum_berekend_aanpassen_spelersprofielField;
		private CrmDateTime sgt_datum_berekend_corrigeren_basisgetallenField;
		private CrmDateTime sgt_datum_berekend_eindejaarsratingField;
		private CrmDateTime sgt_datum_berekend_speelsterkteField;
		private CrmDateTime sgt_datum_herstart_aanpassen_spelersprofielField;
		private CrmDateTime sgt_datum_herstart_corrigeren_basisgetallenField;
		private CrmDateTime sgt_datum_herstart_eindejaarsratingField;
		private CrmDateTime sgt_datum_herstart_speelsterkteField;
		private string sgt_dss_nameField;
		private Key sgt_dss_speelsterkteidField;
		private CrmBoolean sgt_herstarten_aanpassen_spelersprofielField;
		private CrmBoolean sgt_herstarten_corrigeren_basisgetallenField;
		private CrmBoolean sgt_herstarten_eindejaarsraringField;
		private CrmBoolean sgt_herstarten_speelsterkteField;
		private string sgt_herstelpunt_aanpassen_spelersprofielField;
		private string sgt_herstelpunt_corrigeren_basisgetallenField;
		private string sgt_herstelpunt_eindejaarsratingField;
		private string sgt_herstelpunt_speelsterkteField;
		private string sgt_omschrijvingField;
		private string sgt_reden_status_aanpassen_spelersprofielField;
		private string sgt_reden_status_corrigeren_basisgetallenField;
		private string sgt_reden_status_eindejaarsratingField;
		private string sgt_reden_status_speelsterkteField;
		private Picklist sgt_status_aanpassen_spelersprofielField;
		private Picklist sgt_status_corrigeren_basisgetallenField;
		private Picklist sgt_status_eindejaarsratingField;
		private Picklist sgt_status_speelsterkteField;
		private Lookup sgt_variabelen_dssidField;
		private Sgt_dss_speelsterkteStateInfo statecodeField;
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
		public CrmBoolean sgt_aanpassen
		{
			get
			{
				return this.sgt_aanpassenField;
			}
			set
			{
				this.sgt_aanpassenField = value;
			}
		}
		public CrmBoolean sgt_berekenen_corrigeren_basisgetallen
		{
			get
			{
				return this.sgt_berekenen_corrigeren_basisgetallenField;
			}
			set
			{
				this.sgt_berekenen_corrigeren_basisgetallenField = value;
			}
		}
		public CrmBoolean sgt_berekenen_eindejaarsrating
		{
			get
			{
				return this.sgt_berekenen_eindejaarsratingField;
			}
			set
			{
				this.sgt_berekenen_eindejaarsratingField = value;
			}
		}
		public CrmBoolean sgt_berekenen_speelsterkte
		{
			get
			{
				return this.sgt_berekenen_speelsterkteField;
			}
			set
			{
				this.sgt_berekenen_speelsterkteField = value;
			}
		}
		public CrmDateTime sgt_datum_berekend_aanpassen_spelersprofiel
		{
			get
			{
				return this.sgt_datum_berekend_aanpassen_spelersprofielField;
			}
			set
			{
				this.sgt_datum_berekend_aanpassen_spelersprofielField = value;
			}
		}
		public CrmDateTime sgt_datum_berekend_corrigeren_basisgetallen
		{
			get
			{
				return this.sgt_datum_berekend_corrigeren_basisgetallenField;
			}
			set
			{
				this.sgt_datum_berekend_corrigeren_basisgetallenField = value;
			}
		}
		public CrmDateTime sgt_datum_berekend_eindejaarsrating
		{
			get
			{
				return this.sgt_datum_berekend_eindejaarsratingField;
			}
			set
			{
				this.sgt_datum_berekend_eindejaarsratingField = value;
			}
		}
		public CrmDateTime sgt_datum_berekend_speelsterkte
		{
			get
			{
				return this.sgt_datum_berekend_speelsterkteField;
			}
			set
			{
				this.sgt_datum_berekend_speelsterkteField = value;
			}
		}
		public CrmDateTime sgt_datum_herstart_aanpassen_spelersprofiel
		{
			get
			{
				return this.sgt_datum_herstart_aanpassen_spelersprofielField;
			}
			set
			{
				this.sgt_datum_herstart_aanpassen_spelersprofielField = value;
			}
		}
		public CrmDateTime sgt_datum_herstart_corrigeren_basisgetallen
		{
			get
			{
				return this.sgt_datum_herstart_corrigeren_basisgetallenField;
			}
			set
			{
				this.sgt_datum_herstart_corrigeren_basisgetallenField = value;
			}
		}
		public CrmDateTime sgt_datum_herstart_eindejaarsrating
		{
			get
			{
				return this.sgt_datum_herstart_eindejaarsratingField;
			}
			set
			{
				this.sgt_datum_herstart_eindejaarsratingField = value;
			}
		}
		public CrmDateTime sgt_datum_herstart_speelsterkte
		{
			get
			{
				return this.sgt_datum_herstart_speelsterkteField;
			}
			set
			{
				this.sgt_datum_herstart_speelsterkteField = value;
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
		public Key sgt_dss_speelsterkteid
		{
			get
			{
				return this.sgt_dss_speelsterkteidField;
			}
			set
			{
				this.sgt_dss_speelsterkteidField = value;
			}
		}
		public CrmBoolean sgt_herstarten_aanpassen_spelersprofiel
		{
			get
			{
				return this.sgt_herstarten_aanpassen_spelersprofielField;
			}
			set
			{
				this.sgt_herstarten_aanpassen_spelersprofielField = value;
			}
		}
		public CrmBoolean sgt_herstarten_corrigeren_basisgetallen
		{
			get
			{
				return this.sgt_herstarten_corrigeren_basisgetallenField;
			}
			set
			{
				this.sgt_herstarten_corrigeren_basisgetallenField = value;
			}
		}
		public CrmBoolean sgt_herstarten_eindejaarsraring
		{
			get
			{
				return this.sgt_herstarten_eindejaarsraringField;
			}
			set
			{
				this.sgt_herstarten_eindejaarsraringField = value;
			}
		}
		public CrmBoolean sgt_herstarten_speelsterkte
		{
			get
			{
				return this.sgt_herstarten_speelsterkteField;
			}
			set
			{
				this.sgt_herstarten_speelsterkteField = value;
			}
		}
		public string sgt_herstelpunt_aanpassen_spelersprofiel
		{
			get
			{
				return this.sgt_herstelpunt_aanpassen_spelersprofielField;
			}
			set
			{
				this.sgt_herstelpunt_aanpassen_spelersprofielField = value;
			}
		}
		public string sgt_herstelpunt_corrigeren_basisgetallen
		{
			get
			{
				return this.sgt_herstelpunt_corrigeren_basisgetallenField;
			}
			set
			{
				this.sgt_herstelpunt_corrigeren_basisgetallenField = value;
			}
		}
		public string sgt_herstelpunt_eindejaarsrating
		{
			get
			{
				return this.sgt_herstelpunt_eindejaarsratingField;
			}
			set
			{
				this.sgt_herstelpunt_eindejaarsratingField = value;
			}
		}
		public string sgt_herstelpunt_speelsterkte
		{
			get
			{
				return this.sgt_herstelpunt_speelsterkteField;
			}
			set
			{
				this.sgt_herstelpunt_speelsterkteField = value;
			}
		}
		public string sgt_omschrijving
		{
			get
			{
				return this.sgt_omschrijvingField;
			}
			set
			{
				this.sgt_omschrijvingField = value;
			}
		}
		public string sgt_reden_status_aanpassen_spelersprofiel
		{
			get
			{
				return this.sgt_reden_status_aanpassen_spelersprofielField;
			}
			set
			{
				this.sgt_reden_status_aanpassen_spelersprofielField = value;
			}
		}
		public string sgt_reden_status_corrigeren_basisgetallen
		{
			get
			{
				return this.sgt_reden_status_corrigeren_basisgetallenField;
			}
			set
			{
				this.sgt_reden_status_corrigeren_basisgetallenField = value;
			}
		}
		public string sgt_reden_status_eindejaarsrating
		{
			get
			{
				return this.sgt_reden_status_eindejaarsratingField;
			}
			set
			{
				this.sgt_reden_status_eindejaarsratingField = value;
			}
		}
		public string sgt_reden_status_speelsterkte
		{
			get
			{
				return this.sgt_reden_status_speelsterkteField;
			}
			set
			{
				this.sgt_reden_status_speelsterkteField = value;
			}
		}
		public Picklist sgt_status_aanpassen_spelersprofiel
		{
			get
			{
				return this.sgt_status_aanpassen_spelersprofielField;
			}
			set
			{
				this.sgt_status_aanpassen_spelersprofielField = value;
			}
		}
		public Picklist sgt_status_corrigeren_basisgetallen
		{
			get
			{
				return this.sgt_status_corrigeren_basisgetallenField;
			}
			set
			{
				this.sgt_status_corrigeren_basisgetallenField = value;
			}
		}
		public Picklist sgt_status_eindejaarsrating
		{
			get
			{
				return this.sgt_status_eindejaarsratingField;
			}
			set
			{
				this.sgt_status_eindejaarsratingField = value;
			}
		}
		public Picklist sgt_status_speelsterkte
		{
			get
			{
				return this.sgt_status_speelsterkteField;
			}
			set
			{
				this.sgt_status_speelsterkteField = value;
			}
		}
		public Lookup sgt_variabelen_dssid
		{
			get
			{
				return this.sgt_variabelen_dssidField;
			}
			set
			{
				this.sgt_variabelen_dssidField = value;
			}
		}
		public Sgt_dss_speelsterkteStateInfo statecode
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
