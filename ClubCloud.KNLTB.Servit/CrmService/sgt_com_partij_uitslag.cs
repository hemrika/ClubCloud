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
		public CrmBoolean sgt_automatisch_tellen
		{
			get
			{
				return this.sgt_automatisch_tellenField;
			}
			set
			{
				this.sgt_automatisch_tellenField = value;
			}
		}
		public string sgt_com_naam
		{
			get
			{
				return this.sgt_com_naamField;
			}
			set
			{
				this.sgt_com_naamField = value;
			}
		}
		public Key sgt_com_partij_uitslagid
		{
			get
			{
				return this.sgt_com_partij_uitslagidField;
			}
			set
			{
				this.sgt_com_partij_uitslagidField = value;
			}
		}
		public Lookup sgt_ingevoerd_doorid
		{
			get
			{
				return this.sgt_ingevoerd_dooridField;
			}
			set
			{
				this.sgt_ingevoerd_dooridField = value;
			}
		}
		public Lookup sgt_lid1_thuisid
		{
			get
			{
				return this.sgt_lid1_thuisidField;
			}
			set
			{
				this.sgt_lid1_thuisidField = value;
			}
		}
		public Lookup sgt_lid1_uitid
		{
			get
			{
				return this.sgt_lid1_uitidField;
			}
			set
			{
				this.sgt_lid1_uitidField = value;
			}
		}
		public Lookup sgt_lid2_thuisid
		{
			get
			{
				return this.sgt_lid2_thuisidField;
			}
			set
			{
				this.sgt_lid2_thuisidField = value;
			}
		}
		public Lookup sgt_lid2_uitid
		{
			get
			{
				return this.sgt_lid2_uitidField;
			}
			set
			{
				this.sgt_lid2_uitidField = value;
			}
		}
		public CrmBoolean sgt_opgave_tijdens_wedstrijd
		{
			get
			{
				return this.sgt_opgave_tijdens_wedstrijdField;
			}
			set
			{
				this.sgt_opgave_tijdens_wedstrijdField = value;
			}
		}
		public string sgt_partij
		{
			get
			{
				return this.sgt_partijField;
			}
			set
			{
				this.sgt_partijField = value;
			}
		}
		public Picklist sgt_partij_status
		{
			get
			{
				return this.sgt_partij_statusField;
			}
			set
			{
				this.sgt_partij_statusField = value;
			}
		}
		public CrmNumber sgt_set1_thuis
		{
			get
			{
				return this.sgt_set1_thuisField;
			}
			set
			{
				this.sgt_set1_thuisField = value;
			}
		}
		public CrmNumber sgt_set1_uit
		{
			get
			{
				return this.sgt_set1_uitField;
			}
			set
			{
				this.sgt_set1_uitField = value;
			}
		}
		public CrmNumber sgt_set2_thuis
		{
			get
			{
				return this.sgt_set2_thuisField;
			}
			set
			{
				this.sgt_set2_thuisField = value;
			}
		}
		public CrmNumber sgt_set2_uit
		{
			get
			{
				return this.sgt_set2_uitField;
			}
			set
			{
				this.sgt_set2_uitField = value;
			}
		}
		public CrmNumber sgt_set3_thuis
		{
			get
			{
				return this.sgt_set3_thuisField;
			}
			set
			{
				this.sgt_set3_thuisField = value;
			}
		}
		public CrmNumber sgt_set3_uit
		{
			get
			{
				return this.sgt_set3_uitField;
			}
			set
			{
				this.sgt_set3_uitField = value;
			}
		}
		public CrmNumber sgt_set4_thuis
		{
			get
			{
				return this.sgt_set4_thuisField;
			}
			set
			{
				this.sgt_set4_thuisField = value;
			}
		}
		public CrmNumber sgt_set4_uit
		{
			get
			{
				return this.sgt_set4_uitField;
			}
			set
			{
				this.sgt_set4_uitField = value;
			}
		}
		public CrmNumber sgt_set5_thuis
		{
			get
			{
				return this.sgt_set5_thuisField;
			}
			set
			{
				this.sgt_set5_thuisField = value;
			}
		}
		public CrmNumber sgt_set5_uit
		{
			get
			{
				return this.sgt_set5_uitField;
			}
			set
			{
				this.sgt_set5_uitField = value;
			}
		}
		public Lookup sgt_speler_thuis_niet_knltb_lidid
		{
			get
			{
				return this.sgt_speler_thuis_niet_knltb_lididField;
			}
			set
			{
				this.sgt_speler_thuis_niet_knltb_lididField = value;
			}
		}
		public Lookup sgt_speler_thuis2_id
		{
			get
			{
				return this.sgt_speler_thuis2_idField;
			}
			set
			{
				this.sgt_speler_thuis2_idField = value;
			}
		}
		public Lookup sgt_speler_thuis2_niet_knltb_lidid
		{
			get
			{
				return this.sgt_speler_thuis2_niet_knltb_lididField;
			}
			set
			{
				this.sgt_speler_thuis2_niet_knltb_lididField = value;
			}
		}
		public Lookup sgt_speler_thuisid
		{
			get
			{
				return this.sgt_speler_thuisidField;
			}
			set
			{
				this.sgt_speler_thuisidField = value;
			}
		}
		public Lookup sgt_speler_uit_niet_knltb_lidid
		{
			get
			{
				return this.sgt_speler_uit_niet_knltb_lididField;
			}
			set
			{
				this.sgt_speler_uit_niet_knltb_lididField = value;
			}
		}
		public Lookup sgt_speler_uit2_id
		{
			get
			{
				return this.sgt_speler_uit2_idField;
			}
			set
			{
				this.sgt_speler_uit2_idField = value;
			}
		}
		public Lookup sgt_speler_uit2_niet_knltb_lidid
		{
			get
			{
				return this.sgt_speler_uit2_niet_knltb_lididField;
			}
			set
			{
				this.sgt_speler_uit2_niet_knltb_lididField = value;
			}
		}
		public Lookup sgt_speler_uitid
		{
			get
			{
				return this.sgt_speler_uitidField;
			}
			set
			{
				this.sgt_speler_uitidField = value;
			}
		}
		public CrmBoolean sgt_teamautorisaties_uitschakelen
		{
			get
			{
				return this.sgt_teamautorisaties_uitschakelenField;
			}
			set
			{
				this.sgt_teamautorisaties_uitschakelenField = value;
			}
		}
		public Picklist sgt_type
		{
			get
			{
				return this.sgt_typeField;
			}
			set
			{
				this.sgt_typeField = value;
			}
		}
		public CrmNumber sgt_uitslag_thuis
		{
			get
			{
				return this.sgt_uitslag_thuisField;
			}
			set
			{
				this.sgt_uitslag_thuisField = value;
			}
		}
		public CrmNumber sgt_uitslag_uit
		{
			get
			{
				return this.sgt_uitslag_uitField;
			}
			set
			{
				this.sgt_uitslag_uitField = value;
			}
		}
		public Lookup sgt_wedstrijdid
		{
			get
			{
				return this.sgt_wedstrijdidField;
			}
			set
			{
				this.sgt_wedstrijdidField = value;
			}
		}
		public Sgt_com_partij_uitslagStateInfo statecode
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
