using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("System.Xml", "4.0.30319.33440")]
	[Serializable]
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2007/WebServices")]
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

		[XmlElement] //[XmlElement(Order=0)]
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

		[XmlElement] //[XmlElement(Order=1)]
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

		[XmlElement] //[XmlElement(Order=2)]
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

		[XmlElement] //[XmlElement(Order=3)]
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

		[XmlElement] //[XmlElement(Order=4)]
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

		[XmlElement] //[XmlElement(Order=5)]
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

		[XmlElement] //[XmlElement(Order=6)]
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

		[XmlElement] //[XmlElement(Order=7)]
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

		[XmlElement] //[XmlElement(Order=8)]
		public Lookup sgt_aangevraagd_door_id
		{
			get
			{
				return this.sgt_aangevraagd_door_idField;
			}
			set
			{
				this.sgt_aangevraagd_door_idField = value;
				base.RaisePropertyChanged("sgt_aangevraagd_door_id");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public Lookup sgt_aangevraagd_doorid
		{
			get
			{
				return this.sgt_aangevraagd_dooridField;
			}
			set
			{
				this.sgt_aangevraagd_dooridField = value;
				base.RaisePropertyChanged("sgt_aangevraagd_doorid");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public CrmDecimal sgt_basisgetal_dubbel_gewenste_speelsterkte
		{
			get
			{
				return this.sgt_basisgetal_dubbel_gewenste_speelsterkteField;
			}
			set
			{
				this.sgt_basisgetal_dubbel_gewenste_speelsterkteField = value;
				base.RaisePropertyChanged("sgt_basisgetal_dubbel_gewenste_speelsterkte");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public CrmDecimal sgt_basisgetal_dubbel_toegewezen
		{
			get
			{
				return this.sgt_basisgetal_dubbel_toegewezenField;
			}
			set
			{
				this.sgt_basisgetal_dubbel_toegewezenField = value;
				base.RaisePropertyChanged("sgt_basisgetal_dubbel_toegewezen");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public CrmDecimal sgt_basisgetal_enkel_gewenste_speelsterkte
		{
			get
			{
				return this.sgt_basisgetal_enkel_gewenste_speelsterkteField;
			}
			set
			{
				this.sgt_basisgetal_enkel_gewenste_speelsterkteField = value;
				base.RaisePropertyChanged("sgt_basisgetal_enkel_gewenste_speelsterkte");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public CrmDecimal sgt_basisgetal_enkel_toegewezen
		{
			get
			{
				return this.sgt_basisgetal_enkel_toegewezenField;
			}
			set
			{
				this.sgt_basisgetal_enkel_toegewezenField = value;
				base.RaisePropertyChanged("sgt_basisgetal_enkel_toegewezen");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public string sgt_bondsnummer
		{
			get
			{
				return this.sgt_bondsnummerField;
			}
			set
			{
				this.sgt_bondsnummerField = value;
				base.RaisePropertyChanged("sgt_bondsnummer");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public CrmDateTime sgt_datum_aangevraagd
		{
			get
			{
				return this.sgt_datum_aangevraagdField;
			}
			set
			{
				this.sgt_datum_aangevraagdField = value;
				base.RaisePropertyChanged("sgt_datum_aangevraagd");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
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

		[XmlElement] //[XmlElement(Order=17)]
		public Key sgt_dss_speelsterktemutatie_aanvraagid
		{
			get
			{
				return this.sgt_dss_speelsterktemutatie_aanvraagidField;
			}
			set
			{
				this.sgt_dss_speelsterktemutatie_aanvraagidField = value;
				base.RaisePropertyChanged("sgt_dss_speelsterktemutatie_aanvraagid");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public CrmDecimal sgt_eindejaarsrating_dubbel
		{
			get
			{
				return this.sgt_eindejaarsrating_dubbelField;
			}
			set
			{
				this.sgt_eindejaarsrating_dubbelField = value;
				base.RaisePropertyChanged("sgt_eindejaarsrating_dubbel");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public CrmDecimal sgt_eindejaarsrating_enkel
		{
			get
			{
				return this.sgt_eindejaarsrating_enkelField;
			}
			set
			{
				this.sgt_eindejaarsrating_enkelField = value;
				base.RaisePropertyChanged("sgt_eindejaarsrating_enkel");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public CrmDateTime sgt_geboortedatum
		{
			get
			{
				return this.sgt_geboortedatumField;
			}
			set
			{
				this.sgt_geboortedatumField = value;
				base.RaisePropertyChanged("sgt_geboortedatum");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public Picklist sgt_geslacht
		{
			get
			{
				return this.sgt_geslachtField;
			}
			set
			{
				this.sgt_geslachtField = value;
				base.RaisePropertyChanged("sgt_geslacht");
			}
		}

		[XmlElement] //[XmlElement(Order=22)]
		public Lookup sgt_naam_spelerid
		{
			get
			{
				return this.sgt_naam_speleridField;
			}
			set
			{
				this.sgt_naam_speleridField = value;
				base.RaisePropertyChanged("sgt_naam_spelerid");
			}
		}

		[XmlElement] //[XmlElement(Order=23)]
		public Lookup sgt_reden_aanvraagid
		{
			get
			{
				return this.sgt_reden_aanvraagidField;
			}
			set
			{
				this.sgt_reden_aanvraagidField = value;
				base.RaisePropertyChanged("sgt_reden_aanvraagid");
			}
		}

		[XmlElement] //[XmlElement(Order=24)]
		public CrmNumber sgt_speelsterkte_dubbel
		{
			get
			{
				return this.sgt_speelsterkte_dubbelField;
			}
			set
			{
				this.sgt_speelsterkte_dubbelField = value;
				base.RaisePropertyChanged("sgt_speelsterkte_dubbel");
			}
		}

		[XmlElement] //[XmlElement(Order=25)]
		public CrmNumber sgt_speelsterkte_dubbel_gewenste_speelsterkte
		{
			get
			{
				return this.sgt_speelsterkte_dubbel_gewenste_speelsterkteField;
			}
			set
			{
				this.sgt_speelsterkte_dubbel_gewenste_speelsterkteField = value;
				base.RaisePropertyChanged("sgt_speelsterkte_dubbel_gewenste_speelsterkte");
			}
		}

		[XmlElement] //[XmlElement(Order=26)]
		public CrmNumber sgt_speelsterkte_dubbel_oud
		{
			get
			{
				return this.sgt_speelsterkte_dubbel_oudField;
			}
			set
			{
				this.sgt_speelsterkte_dubbel_oudField = value;
				base.RaisePropertyChanged("sgt_speelsterkte_dubbel_oud");
			}
		}

		[XmlElement] //[XmlElement(Order=27)]
		public CrmNumber sgt_speelsterkte_dubbel_toegewezen
		{
			get
			{
				return this.sgt_speelsterkte_dubbel_toegewezenField;
			}
			set
			{
				this.sgt_speelsterkte_dubbel_toegewezenField = value;
				base.RaisePropertyChanged("sgt_speelsterkte_dubbel_toegewezen");
			}
		}

		[XmlElement] //[XmlElement(Order=28)]
		public CrmNumber sgt_speelsterkte_enkel
		{
			get
			{
				return this.sgt_speelsterkte_enkelField;
			}
			set
			{
				this.sgt_speelsterkte_enkelField = value;
				base.RaisePropertyChanged("sgt_speelsterkte_enkel");
			}
		}

		[XmlElement] //[XmlElement(Order=29)]
		public CrmNumber sgt_speelsterkte_enkel_gewenste_speelsterkte
		{
			get
			{
				return this.sgt_speelsterkte_enkel_gewenste_speelsterkteField;
			}
			set
			{
				this.sgt_speelsterkte_enkel_gewenste_speelsterkteField = value;
				base.RaisePropertyChanged("sgt_speelsterkte_enkel_gewenste_speelsterkte");
			}
		}

		[XmlElement] //[XmlElement(Order=30)]
		public CrmNumber sgt_speelsterkte_enkel_oud
		{
			get
			{
				return this.sgt_speelsterkte_enkel_oudField;
			}
			set
			{
				this.sgt_speelsterkte_enkel_oudField = value;
				base.RaisePropertyChanged("sgt_speelsterkte_enkel_oud");
			}
		}

		[XmlElement] //[XmlElement(Order=31)]
		public CrmNumber sgt_speelsterkte_enkel_toegewezen
		{
			get
			{
				return this.sgt_speelsterkte_enkel_toegewezenField;
			}
			set
			{
				this.sgt_speelsterkte_enkel_toegewezenField = value;
				base.RaisePropertyChanged("sgt_speelsterkte_enkel_toegewezen");
			}
		}

		[XmlElement] //[XmlElement(Order=32)]
		public Picklist sgt_type_wijziging
		{
			get
			{
				return this.sgt_type_wijzigingField;
			}
			set
			{
				this.sgt_type_wijzigingField = value;
				base.RaisePropertyChanged("sgt_type_wijziging");
			}
		}

		[XmlElement] //[XmlElement(Order=33)]
		public Lookup sgt_verenigingid
		{
			get
			{
				return this.sgt_verenigingidField;
			}
			set
			{
				this.sgt_verenigingidField = value;
				base.RaisePropertyChanged("sgt_verenigingid");
			}
		}

		[XmlElement] //[XmlElement(Order=34)]
		public Sgt_dss_speelsterktemutatie_aanvraagStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=35)]
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

		[XmlElement] //[XmlElement(Order=36)]
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

		[XmlElement] //[XmlElement(Order=37)]
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

		public sgt_dss_speelsterktemutatie_aanvraag()
		{
		}
	}
}