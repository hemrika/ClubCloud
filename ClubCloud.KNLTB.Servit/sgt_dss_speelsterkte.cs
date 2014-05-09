using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
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
		[XmlElement(Order = 0)]
		public Lookup createdby
		{
			get
			{
				return this.createdbyField;
			}
			set
			{
				this.createdbyField = value;
				base.RaisePropertyChanged("createdby");
			}
		}
		[XmlElement(Order = 1)]
		public CrmDateTime createdon
		{
			get
			{
				return this.createdonField;
			}
			set
			{
				this.createdonField = value;
				base.RaisePropertyChanged("createdon");
			}
		}
		[XmlElement(Order = 2)]
		public CrmNumber importsequencenumber
		{
			get
			{
				return this.importsequencenumberField;
			}
			set
			{
				this.importsequencenumberField = value;
				base.RaisePropertyChanged("importsequencenumber");
			}
		}
		[XmlElement(Order = 3)]
		public Lookup modifiedby
		{
			get
			{
				return this.modifiedbyField;
			}
			set
			{
				this.modifiedbyField = value;
				base.RaisePropertyChanged("modifiedby");
			}
		}
		[XmlElement(Order = 4)]
		public CrmDateTime modifiedon
		{
			get
			{
				return this.modifiedonField;
			}
			set
			{
				this.modifiedonField = value;
				base.RaisePropertyChanged("modifiedon");
			}
		}
		[XmlElement(Order = 5)]
		public CrmDateTime overriddencreatedon
		{
			get
			{
				return this.overriddencreatedonField;
			}
			set
			{
				this.overriddencreatedonField = value;
				base.RaisePropertyChanged("overriddencreatedon");
			}
		}
		[XmlElement(Order = 6)]
		public Owner ownerid
		{
			get
			{
				return this.owneridField;
			}
			set
			{
				this.owneridField = value;
				base.RaisePropertyChanged("ownerid");
			}
		}
		[XmlElement(Order = 7)]
		public Lookup owningbusinessunit
		{
			get
			{
				return this.owningbusinessunitField;
			}
			set
			{
				this.owningbusinessunitField = value;
				base.RaisePropertyChanged("owningbusinessunit");
			}
		}
		[XmlElement(Order = 8)]
		public CrmBoolean sgt_aanpassen
		{
			get
			{
				return this.sgt_aanpassenField;
			}
			set
			{
				this.sgt_aanpassenField = value;
				base.RaisePropertyChanged("sgt_aanpassen");
			}
		}
		[XmlElement(Order = 9)]
		public CrmBoolean sgt_berekenen_corrigeren_basisgetallen
		{
			get
			{
				return this.sgt_berekenen_corrigeren_basisgetallenField;
			}
			set
			{
				this.sgt_berekenen_corrigeren_basisgetallenField = value;
				base.RaisePropertyChanged("sgt_berekenen_corrigeren_basisgetallen");
			}
		}
		[XmlElement(Order = 10)]
		public CrmBoolean sgt_berekenen_eindejaarsrating
		{
			get
			{
				return this.sgt_berekenen_eindejaarsratingField;
			}
			set
			{
				this.sgt_berekenen_eindejaarsratingField = value;
				base.RaisePropertyChanged("sgt_berekenen_eindejaarsrating");
			}
		}
		[XmlElement(Order = 11)]
		public CrmBoolean sgt_berekenen_speelsterkte
		{
			get
			{
				return this.sgt_berekenen_speelsterkteField;
			}
			set
			{
				this.sgt_berekenen_speelsterkteField = value;
				base.RaisePropertyChanged("sgt_berekenen_speelsterkte");
			}
		}
		[XmlElement(Order = 12)]
		public CrmDateTime sgt_datum_berekend_aanpassen_spelersprofiel
		{
			get
			{
				return this.sgt_datum_berekend_aanpassen_spelersprofielField;
			}
			set
			{
				this.sgt_datum_berekend_aanpassen_spelersprofielField = value;
				base.RaisePropertyChanged("sgt_datum_berekend_aanpassen_spelersprofiel");
			}
		}
		[XmlElement(Order = 13)]
		public CrmDateTime sgt_datum_berekend_corrigeren_basisgetallen
		{
			get
			{
				return this.sgt_datum_berekend_corrigeren_basisgetallenField;
			}
			set
			{
				this.sgt_datum_berekend_corrigeren_basisgetallenField = value;
				base.RaisePropertyChanged("sgt_datum_berekend_corrigeren_basisgetallen");
			}
		}
		[XmlElement(Order = 14)]
		public CrmDateTime sgt_datum_berekend_eindejaarsrating
		{
			get
			{
				return this.sgt_datum_berekend_eindejaarsratingField;
			}
			set
			{
				this.sgt_datum_berekend_eindejaarsratingField = value;
				base.RaisePropertyChanged("sgt_datum_berekend_eindejaarsrating");
			}
		}
		[XmlElement(Order = 15)]
		public CrmDateTime sgt_datum_berekend_speelsterkte
		{
			get
			{
				return this.sgt_datum_berekend_speelsterkteField;
			}
			set
			{
				this.sgt_datum_berekend_speelsterkteField = value;
				base.RaisePropertyChanged("sgt_datum_berekend_speelsterkte");
			}
		}
		[XmlElement(Order = 16)]
		public CrmDateTime sgt_datum_herstart_aanpassen_spelersprofiel
		{
			get
			{
				return this.sgt_datum_herstart_aanpassen_spelersprofielField;
			}
			set
			{
				this.sgt_datum_herstart_aanpassen_spelersprofielField = value;
				base.RaisePropertyChanged("sgt_datum_herstart_aanpassen_spelersprofiel");
			}
		}
		[XmlElement(Order = 17)]
		public CrmDateTime sgt_datum_herstart_corrigeren_basisgetallen
		{
			get
			{
				return this.sgt_datum_herstart_corrigeren_basisgetallenField;
			}
			set
			{
				this.sgt_datum_herstart_corrigeren_basisgetallenField = value;
				base.RaisePropertyChanged("sgt_datum_herstart_corrigeren_basisgetallen");
			}
		}
		[XmlElement(Order = 18)]
		public CrmDateTime sgt_datum_herstart_eindejaarsrating
		{
			get
			{
				return this.sgt_datum_herstart_eindejaarsratingField;
			}
			set
			{
				this.sgt_datum_herstart_eindejaarsratingField = value;
				base.RaisePropertyChanged("sgt_datum_herstart_eindejaarsrating");
			}
		}
		[XmlElement(Order = 19)]
		public CrmDateTime sgt_datum_herstart_speelsterkte
		{
			get
			{
				return this.sgt_datum_herstart_speelsterkteField;
			}
			set
			{
				this.sgt_datum_herstart_speelsterkteField = value;
				base.RaisePropertyChanged("sgt_datum_herstart_speelsterkte");
			}
		}
		[XmlElement(Order = 20)]
		public string sgt_dss_name
		{
			get
			{
				return this.sgt_dss_nameField;
			}
			set
			{
				this.sgt_dss_nameField = value;
				base.RaisePropertyChanged("sgt_dss_name");
			}
		}
		[XmlElement(Order = 21)]
		public Key sgt_dss_speelsterkteid
		{
			get
			{
				return this.sgt_dss_speelsterkteidField;
			}
			set
			{
				this.sgt_dss_speelsterkteidField = value;
				base.RaisePropertyChanged("sgt_dss_speelsterkteid");
			}
		}
		[XmlElement(Order = 22)]
		public CrmBoolean sgt_herstarten_aanpassen_spelersprofiel
		{
			get
			{
				return this.sgt_herstarten_aanpassen_spelersprofielField;
			}
			set
			{
				this.sgt_herstarten_aanpassen_spelersprofielField = value;
				base.RaisePropertyChanged("sgt_herstarten_aanpassen_spelersprofiel");
			}
		}
		[XmlElement(Order = 23)]
		public CrmBoolean sgt_herstarten_corrigeren_basisgetallen
		{
			get
			{
				return this.sgt_herstarten_corrigeren_basisgetallenField;
			}
			set
			{
				this.sgt_herstarten_corrigeren_basisgetallenField = value;
				base.RaisePropertyChanged("sgt_herstarten_corrigeren_basisgetallen");
			}
		}
		[XmlElement(Order = 24)]
		public CrmBoolean sgt_herstarten_eindejaarsraring
		{
			get
			{
				return this.sgt_herstarten_eindejaarsraringField;
			}
			set
			{
				this.sgt_herstarten_eindejaarsraringField = value;
				base.RaisePropertyChanged("sgt_herstarten_eindejaarsraring");
			}
		}
		[XmlElement(Order = 25)]
		public CrmBoolean sgt_herstarten_speelsterkte
		{
			get
			{
				return this.sgt_herstarten_speelsterkteField;
			}
			set
			{
				this.sgt_herstarten_speelsterkteField = value;
				base.RaisePropertyChanged("sgt_herstarten_speelsterkte");
			}
		}
		[XmlElement(Order = 26)]
		public string sgt_herstelpunt_aanpassen_spelersprofiel
		{
			get
			{
				return this.sgt_herstelpunt_aanpassen_spelersprofielField;
			}
			set
			{
				this.sgt_herstelpunt_aanpassen_spelersprofielField = value;
				base.RaisePropertyChanged("sgt_herstelpunt_aanpassen_spelersprofiel");
			}
		}
		[XmlElement(Order = 27)]
		public string sgt_herstelpunt_corrigeren_basisgetallen
		{
			get
			{
				return this.sgt_herstelpunt_corrigeren_basisgetallenField;
			}
			set
			{
				this.sgt_herstelpunt_corrigeren_basisgetallenField = value;
				base.RaisePropertyChanged("sgt_herstelpunt_corrigeren_basisgetallen");
			}
		}
		[XmlElement(Order = 28)]
		public string sgt_herstelpunt_eindejaarsrating
		{
			get
			{
				return this.sgt_herstelpunt_eindejaarsratingField;
			}
			set
			{
				this.sgt_herstelpunt_eindejaarsratingField = value;
				base.RaisePropertyChanged("sgt_herstelpunt_eindejaarsrating");
			}
		}
		[XmlElement(Order = 29)]
		public string sgt_herstelpunt_speelsterkte
		{
			get
			{
				return this.sgt_herstelpunt_speelsterkteField;
			}
			set
			{
				this.sgt_herstelpunt_speelsterkteField = value;
				base.RaisePropertyChanged("sgt_herstelpunt_speelsterkte");
			}
		}
		[XmlElement(Order = 30)]
		public string sgt_omschrijving
		{
			get
			{
				return this.sgt_omschrijvingField;
			}
			set
			{
				this.sgt_omschrijvingField = value;
				base.RaisePropertyChanged("sgt_omschrijving");
			}
		}
		[XmlElement(Order = 31)]
		public string sgt_reden_status_aanpassen_spelersprofiel
		{
			get
			{
				return this.sgt_reden_status_aanpassen_spelersprofielField;
			}
			set
			{
				this.sgt_reden_status_aanpassen_spelersprofielField = value;
				base.RaisePropertyChanged("sgt_reden_status_aanpassen_spelersprofiel");
			}
		}
		[XmlElement(Order = 32)]
		public string sgt_reden_status_corrigeren_basisgetallen
		{
			get
			{
				return this.sgt_reden_status_corrigeren_basisgetallenField;
			}
			set
			{
				this.sgt_reden_status_corrigeren_basisgetallenField = value;
				base.RaisePropertyChanged("sgt_reden_status_corrigeren_basisgetallen");
			}
		}
		[XmlElement(Order = 33)]
		public string sgt_reden_status_eindejaarsrating
		{
			get
			{
				return this.sgt_reden_status_eindejaarsratingField;
			}
			set
			{
				this.sgt_reden_status_eindejaarsratingField = value;
				base.RaisePropertyChanged("sgt_reden_status_eindejaarsrating");
			}
		}
		[XmlElement(Order = 34)]
		public string sgt_reden_status_speelsterkte
		{
			get
			{
				return this.sgt_reden_status_speelsterkteField;
			}
			set
			{
				this.sgt_reden_status_speelsterkteField = value;
				base.RaisePropertyChanged("sgt_reden_status_speelsterkte");
			}
		}
		[XmlElement(Order = 35)]
		public Picklist sgt_status_aanpassen_spelersprofiel
		{
			get
			{
				return this.sgt_status_aanpassen_spelersprofielField;
			}
			set
			{
				this.sgt_status_aanpassen_spelersprofielField = value;
				base.RaisePropertyChanged("sgt_status_aanpassen_spelersprofiel");
			}
		}
		[XmlElement(Order = 36)]
		public Picklist sgt_status_corrigeren_basisgetallen
		{
			get
			{
				return this.sgt_status_corrigeren_basisgetallenField;
			}
			set
			{
				this.sgt_status_corrigeren_basisgetallenField = value;
				base.RaisePropertyChanged("sgt_status_corrigeren_basisgetallen");
			}
		}
		[XmlElement(Order = 37)]
		public Picklist sgt_status_eindejaarsrating
		{
			get
			{
				return this.sgt_status_eindejaarsratingField;
			}
			set
			{
				this.sgt_status_eindejaarsratingField = value;
				base.RaisePropertyChanged("sgt_status_eindejaarsrating");
			}
		}
		[XmlElement(Order = 38)]
		public Picklist sgt_status_speelsterkte
		{
			get
			{
				return this.sgt_status_speelsterkteField;
			}
			set
			{
				this.sgt_status_speelsterkteField = value;
				base.RaisePropertyChanged("sgt_status_speelsterkte");
			}
		}
		[XmlElement(Order = 39)]
		public Lookup sgt_variabelen_dssid
		{
			get
			{
				return this.sgt_variabelen_dssidField;
			}
			set
			{
				this.sgt_variabelen_dssidField = value;
				base.RaisePropertyChanged("sgt_variabelen_dssid");
			}
		}
		[XmlElement(Order = 40)]
		public Sgt_dss_speelsterkteStateInfo statecode
		{
			get
			{
				return this.statecodeField;
			}
			set
			{
				this.statecodeField = value;
				base.RaisePropertyChanged("statecode");
			}
		}
		[XmlElement(Order = 41)]
		public Status statuscode
		{
			get
			{
				return this.statuscodeField;
			}
			set
			{
				this.statuscodeField = value;
				base.RaisePropertyChanged("statuscode");
			}
		}
		[XmlElement(Order = 42)]
		public CrmNumber timezoneruleversionnumber
		{
			get
			{
				return this.timezoneruleversionnumberField;
			}
			set
			{
				this.timezoneruleversionnumberField = value;
				base.RaisePropertyChanged("timezoneruleversionnumber");
			}
		}
		[XmlElement(Order = 43)]
		public CrmNumber utcconversiontimezonecode
		{
			get
			{
				return this.utcconversiontimezonecodeField;
			}
			set
			{
				this.utcconversiontimezonecodeField = value;
				base.RaisePropertyChanged("utcconversiontimezonecode");
			}
		}
	}
}
