using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_com_partij_uitslag : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private CrmBoolean sgt_automatisch_tellenField;
		private string sgt_com_naamField;
		private Key sgt_com_partij_uitslagidField;
		private Lookup sgt_ingevoerd_dooridField;
		private Lookup sgt_lid1_thuisidField;
		private Lookup sgt_lid1_uitidField;
		private Lookup sgt_lid2_thuisidField;
		private Lookup sgt_lid2_uitidField;
		private CrmBoolean sgt_opgave_tijdens_wedstrijdField;
		private string sgt_partijField;
		private Picklist sgt_partij_statusField;
		private CrmNumber sgt_set1_thuisField;
		private CrmNumber sgt_set1_uitField;
		private CrmNumber sgt_set2_thuisField;
		private CrmNumber sgt_set2_uitField;
		private CrmNumber sgt_set3_thuisField;
		private CrmNumber sgt_set3_uitField;
		private CrmNumber sgt_set4_thuisField;
		private CrmNumber sgt_set4_uitField;
		private CrmNumber sgt_set5_thuisField;
		private CrmNumber sgt_set5_uitField;
		private Lookup sgt_speler_thuis_niet_knltb_lididField;
		private Lookup sgt_speler_thuis2_idField;
		private Lookup sgt_speler_thuis2_niet_knltb_lididField;
		private Lookup sgt_speler_thuisidField;
		private Lookup sgt_speler_uit_niet_knltb_lididField;
		private Lookup sgt_speler_uit2_idField;
		private Lookup sgt_speler_uit2_niet_knltb_lididField;
		private Lookup sgt_speler_uitidField;
		private CrmBoolean sgt_teamautorisaties_uitschakelenField;
		private Picklist sgt_typeField;
		private CrmNumber sgt_uitslag_thuisField;
		private CrmNumber sgt_uitslag_uitField;
		private Lookup sgt_wedstrijdidField;
		private Sgt_com_partij_uitslagStateInfo statecodeField;
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
		public CrmBoolean sgt_automatisch_tellen
		{
			get
			{
				return this.sgt_automatisch_tellenField;
			}
			set
			{
				this.sgt_automatisch_tellenField = value;
				base.RaisePropertyChanged("sgt_automatisch_tellen");
			}
		}
		[XmlElement(Order = 9)]
		public string sgt_com_naam
		{
			get
			{
				return this.sgt_com_naamField;
			}
			set
			{
				this.sgt_com_naamField = value;
				base.RaisePropertyChanged("sgt_com_naam");
			}
		}
		[XmlElement(Order = 10)]
		public Key sgt_com_partij_uitslagid
		{
			get
			{
				return this.sgt_com_partij_uitslagidField;
			}
			set
			{
				this.sgt_com_partij_uitslagidField = value;
				base.RaisePropertyChanged("sgt_com_partij_uitslagid");
			}
		}
		[XmlElement(Order = 11)]
		public Lookup sgt_ingevoerd_doorid
		{
			get
			{
				return this.sgt_ingevoerd_dooridField;
			}
			set
			{
				this.sgt_ingevoerd_dooridField = value;
				base.RaisePropertyChanged("sgt_ingevoerd_doorid");
			}
		}
		[XmlElement(Order = 12)]
		public Lookup sgt_lid1_thuisid
		{
			get
			{
				return this.sgt_lid1_thuisidField;
			}
			set
			{
				this.sgt_lid1_thuisidField = value;
				base.RaisePropertyChanged("sgt_lid1_thuisid");
			}
		}
		[XmlElement(Order = 13)]
		public Lookup sgt_lid1_uitid
		{
			get
			{
				return this.sgt_lid1_uitidField;
			}
			set
			{
				this.sgt_lid1_uitidField = value;
				base.RaisePropertyChanged("sgt_lid1_uitid");
			}
		}
		[XmlElement(Order = 14)]
		public Lookup sgt_lid2_thuisid
		{
			get
			{
				return this.sgt_lid2_thuisidField;
			}
			set
			{
				this.sgt_lid2_thuisidField = value;
				base.RaisePropertyChanged("sgt_lid2_thuisid");
			}
		}
		[XmlElement(Order = 15)]
		public Lookup sgt_lid2_uitid
		{
			get
			{
				return this.sgt_lid2_uitidField;
			}
			set
			{
				this.sgt_lid2_uitidField = value;
				base.RaisePropertyChanged("sgt_lid2_uitid");
			}
		}
		[XmlElement(Order = 16)]
		public CrmBoolean sgt_opgave_tijdens_wedstrijd
		{
			get
			{
				return this.sgt_opgave_tijdens_wedstrijdField;
			}
			set
			{
				this.sgt_opgave_tijdens_wedstrijdField = value;
				base.RaisePropertyChanged("sgt_opgave_tijdens_wedstrijd");
			}
		}
		[XmlElement(Order = 17)]
		public string sgt_partij
		{
			get
			{
				return this.sgt_partijField;
			}
			set
			{
				this.sgt_partijField = value;
				base.RaisePropertyChanged("sgt_partij");
			}
		}
		[XmlElement(Order = 18)]
		public Picklist sgt_partij_status
		{
			get
			{
				return this.sgt_partij_statusField;
			}
			set
			{
				this.sgt_partij_statusField = value;
				base.RaisePropertyChanged("sgt_partij_status");
			}
		}
		[XmlElement(Order = 19)]
		public CrmNumber sgt_set1_thuis
		{
			get
			{
				return this.sgt_set1_thuisField;
			}
			set
			{
				this.sgt_set1_thuisField = value;
				base.RaisePropertyChanged("sgt_set1_thuis");
			}
		}
		[XmlElement(Order = 20)]
		public CrmNumber sgt_set1_uit
		{
			get
			{
				return this.sgt_set1_uitField;
			}
			set
			{
				this.sgt_set1_uitField = value;
				base.RaisePropertyChanged("sgt_set1_uit");
			}
		}
		[XmlElement(Order = 21)]
		public CrmNumber sgt_set2_thuis
		{
			get
			{
				return this.sgt_set2_thuisField;
			}
			set
			{
				this.sgt_set2_thuisField = value;
				base.RaisePropertyChanged("sgt_set2_thuis");
			}
		}
		[XmlElement(Order = 22)]
		public CrmNumber sgt_set2_uit
		{
			get
			{
				return this.sgt_set2_uitField;
			}
			set
			{
				this.sgt_set2_uitField = value;
				base.RaisePropertyChanged("sgt_set2_uit");
			}
		}
		[XmlElement(Order = 23)]
		public CrmNumber sgt_set3_thuis
		{
			get
			{
				return this.sgt_set3_thuisField;
			}
			set
			{
				this.sgt_set3_thuisField = value;
				base.RaisePropertyChanged("sgt_set3_thuis");
			}
		}
		[XmlElement(Order = 24)]
		public CrmNumber sgt_set3_uit
		{
			get
			{
				return this.sgt_set3_uitField;
			}
			set
			{
				this.sgt_set3_uitField = value;
				base.RaisePropertyChanged("sgt_set3_uit");
			}
		}
		[XmlElement(Order = 25)]
		public CrmNumber sgt_set4_thuis
		{
			get
			{
				return this.sgt_set4_thuisField;
			}
			set
			{
				this.sgt_set4_thuisField = value;
				base.RaisePropertyChanged("sgt_set4_thuis");
			}
		}
		[XmlElement(Order = 26)]
		public CrmNumber sgt_set4_uit
		{
			get
			{
				return this.sgt_set4_uitField;
			}
			set
			{
				this.sgt_set4_uitField = value;
				base.RaisePropertyChanged("sgt_set4_uit");
			}
		}
		[XmlElement(Order = 27)]
		public CrmNumber sgt_set5_thuis
		{
			get
			{
				return this.sgt_set5_thuisField;
			}
			set
			{
				this.sgt_set5_thuisField = value;
				base.RaisePropertyChanged("sgt_set5_thuis");
			}
		}
		[XmlElement(Order = 28)]
		public CrmNumber sgt_set5_uit
		{
			get
			{
				return this.sgt_set5_uitField;
			}
			set
			{
				this.sgt_set5_uitField = value;
				base.RaisePropertyChanged("sgt_set5_uit");
			}
		}
		[XmlElement(Order = 29)]
		public Lookup sgt_speler_thuis_niet_knltb_lidid
		{
			get
			{
				return this.sgt_speler_thuis_niet_knltb_lididField;
			}
			set
			{
				this.sgt_speler_thuis_niet_knltb_lididField = value;
				base.RaisePropertyChanged("sgt_speler_thuis_niet_knltb_lidid");
			}
		}
		[XmlElement(Order = 30)]
		public Lookup sgt_speler_thuis2_id
		{
			get
			{
				return this.sgt_speler_thuis2_idField;
			}
			set
			{
				this.sgt_speler_thuis2_idField = value;
				base.RaisePropertyChanged("sgt_speler_thuis2_id");
			}
		}
		[XmlElement(Order = 31)]
		public Lookup sgt_speler_thuis2_niet_knltb_lidid
		{
			get
			{
				return this.sgt_speler_thuis2_niet_knltb_lididField;
			}
			set
			{
				this.sgt_speler_thuis2_niet_knltb_lididField = value;
				base.RaisePropertyChanged("sgt_speler_thuis2_niet_knltb_lidid");
			}
		}
		[XmlElement(Order = 32)]
		public Lookup sgt_speler_thuisid
		{
			get
			{
				return this.sgt_speler_thuisidField;
			}
			set
			{
				this.sgt_speler_thuisidField = value;
				base.RaisePropertyChanged("sgt_speler_thuisid");
			}
		}
		[XmlElement(Order = 33)]
		public Lookup sgt_speler_uit_niet_knltb_lidid
		{
			get
			{
				return this.sgt_speler_uit_niet_knltb_lididField;
			}
			set
			{
				this.sgt_speler_uit_niet_knltb_lididField = value;
				base.RaisePropertyChanged("sgt_speler_uit_niet_knltb_lidid");
			}
		}
		[XmlElement(Order = 34)]
		public Lookup sgt_speler_uit2_id
		{
			get
			{
				return this.sgt_speler_uit2_idField;
			}
			set
			{
				this.sgt_speler_uit2_idField = value;
				base.RaisePropertyChanged("sgt_speler_uit2_id");
			}
		}
		[XmlElement(Order = 35)]
		public Lookup sgt_speler_uit2_niet_knltb_lidid
		{
			get
			{
				return this.sgt_speler_uit2_niet_knltb_lididField;
			}
			set
			{
				this.sgt_speler_uit2_niet_knltb_lididField = value;
				base.RaisePropertyChanged("sgt_speler_uit2_niet_knltb_lidid");
			}
		}
		[XmlElement(Order = 36)]
		public Lookup sgt_speler_uitid
		{
			get
			{
				return this.sgt_speler_uitidField;
			}
			set
			{
				this.sgt_speler_uitidField = value;
				base.RaisePropertyChanged("sgt_speler_uitid");
			}
		}
		[XmlElement(Order = 37)]
		public CrmBoolean sgt_teamautorisaties_uitschakelen
		{
			get
			{
				return this.sgt_teamautorisaties_uitschakelenField;
			}
			set
			{
				this.sgt_teamautorisaties_uitschakelenField = value;
				base.RaisePropertyChanged("sgt_teamautorisaties_uitschakelen");
			}
		}
		[XmlElement(Order = 38)]
		public Picklist sgt_type
		{
			get
			{
				return this.sgt_typeField;
			}
			set
			{
				this.sgt_typeField = value;
				base.RaisePropertyChanged("sgt_type");
			}
		}
		[XmlElement(Order = 39)]
		public CrmNumber sgt_uitslag_thuis
		{
			get
			{
				return this.sgt_uitslag_thuisField;
			}
			set
			{
				this.sgt_uitslag_thuisField = value;
				base.RaisePropertyChanged("sgt_uitslag_thuis");
			}
		}
		[XmlElement(Order = 40)]
		public CrmNumber sgt_uitslag_uit
		{
			get
			{
				return this.sgt_uitslag_uitField;
			}
			set
			{
				this.sgt_uitslag_uitField = value;
				base.RaisePropertyChanged("sgt_uitslag_uit");
			}
		}
		[XmlElement(Order = 41)]
		public Lookup sgt_wedstrijdid
		{
			get
			{
				return this.sgt_wedstrijdidField;
			}
			set
			{
				this.sgt_wedstrijdidField = value;
				base.RaisePropertyChanged("sgt_wedstrijdid");
			}
		}
		[XmlElement(Order = 42)]
		public Sgt_com_partij_uitslagStateInfo statecode
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
		[XmlElement(Order = 43)]
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
		[XmlElement(Order = 44)]
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
		[XmlElement(Order = 45)]
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
