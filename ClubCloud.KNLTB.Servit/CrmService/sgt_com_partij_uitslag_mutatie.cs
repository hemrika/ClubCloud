using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_com_partij_uitslag_mutatie : BusinessEntity
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
		private Key sgt_com_partij_uitslag_mutatieidField;
		private Lookup sgt_lid1_thuis_nieuwidField;
		private Lookup sgt_lid1_thuisidField;
		private Lookup sgt_lid1_uit_nieuwidField;
		private Lookup sgt_lid1_uitidField;
		private Lookup sgt_lid2_thuis_nieuwidField;
		private Lookup sgt_lid2_thuisidField;
		private Lookup sgt_lid2_uit_nieuwidField;
		private Lookup sgt_lid2_uitidField;
		private CrmBoolean sgt_opgave_tijdens_wedstrijdField;
		private CrmBoolean sgt_opgave_tijdens_wedstrijd_nieuwField;
		private string sgt_partij_nummerField;
		private Lookup sgt_partij_uitslagidField;
		private CrmNumber sgt_set1_thuisField;
		private CrmNumber sgt_set1_thuis_nieuwField;
		private CrmNumber sgt_set1_uitField;
		private CrmNumber sgt_set1_uit_nieuwField;
		private CrmNumber sgt_set2_thuisField;
		private CrmNumber sgt_set2_thuis_nieuwField;
		private CrmNumber sgt_set2_uitField;
		private CrmNumber sgt_set2_uit_nieuwField;
		private CrmNumber sgt_set3_thuisField;
		private CrmNumber sgt_set3_thuis_nieuwField;
		private CrmNumber sgt_set3_uitField;
		private CrmNumber sgt_set3_uit_nieuwField;
		private CrmNumber sgt_set4_thuisField;
		private CrmNumber sgt_set4_thuis_nieuwField;
		private CrmNumber sgt_set4_uitField;
		private CrmNumber sgt_set4_uit_nieuwField;
		private CrmNumber sgt_set5_thuisField;
		private CrmNumber sgt_set5_thuis_nieuwField;
		private CrmNumber sgt_set5_uitField;
		private CrmNumber sgt_set5_uit_nieuwField;
		private CrmDateTime sgt_speeldatumField;
		private Lookup sgt_speler1_thuis_nieuwidField;
		private Lookup sgt_speler1_thuisidField;
		private Lookup sgt_speler1_uit_nieuwidField;
		private Lookup sgt_speler1_uitidField;
		private Lookup sgt_speler2_thuis_nieuwidField;
		private Lookup sgt_speler2_thuisidField;
		private Lookup sgt_speler2_uit_nieuwidField;
		private Lookup sgt_speler2_uitidField;
		private Lookup sgt_spelerthuis2nietknltblididField;
		private Lookup sgt_spelerthuis2nietknltblidid_nieuwField;
		private Lookup sgt_spelerthuisnietknltblididField;
		private Lookup sgt_spelerthuisnietknltblidid_nieuwField;
		private Lookup sgt_speleruit2nietknltblididField;
		private Lookup sgt_speleruit2nietknltblidid_nieuwField;
		private Lookup sgt_speleruitnietknltblididField;
		private Lookup sgt_speleruitnietknltblidid_nieuwField;
		private Picklist sgt_uitslag_partijField;
		private Picklist sgt_uitslag_partij_nieuwField;
		private CrmNumber sgt_uitslag_thuisField;
		private CrmNumber sgt_uitslag_thuis_nieuwField;
		private CrmNumber sgt_uitslag_uitField;
		private CrmNumber sgt_uitslag_uit_nieuwField;
		private string sgt_wedstrijd_nummerField;
		private Lookup sgt_wedstrijd_uitslag_mutatieidField;
		private Lookup sgt_wedstrijdgegevensidField;
		private Sgt_com_partij_uitslag_mutatieStateInfo statecodeField;
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
		public Key sgt_com_partij_uitslag_mutatieid
		{
			get
			{
				return this.sgt_com_partij_uitslag_mutatieidField;
			}
			set
			{
				this.sgt_com_partij_uitslag_mutatieidField = value;
			}
		}
		public Lookup sgt_lid1_thuis_nieuwid
		{
			get
			{
				return this.sgt_lid1_thuis_nieuwidField;
			}
			set
			{
				this.sgt_lid1_thuis_nieuwidField = value;
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
		public Lookup sgt_lid1_uit_nieuwid
		{
			get
			{
				return this.sgt_lid1_uit_nieuwidField;
			}
			set
			{
				this.sgt_lid1_uit_nieuwidField = value;
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
		public Lookup sgt_lid2_thuis_nieuwid
		{
			get
			{
				return this.sgt_lid2_thuis_nieuwidField;
			}
			set
			{
				this.sgt_lid2_thuis_nieuwidField = value;
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
		public Lookup sgt_lid2_uit_nieuwid
		{
			get
			{
				return this.sgt_lid2_uit_nieuwidField;
			}
			set
			{
				this.sgt_lid2_uit_nieuwidField = value;
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
		public CrmBoolean sgt_opgave_tijdens_wedstrijd_nieuw
		{
			get
			{
				return this.sgt_opgave_tijdens_wedstrijd_nieuwField;
			}
			set
			{
				this.sgt_opgave_tijdens_wedstrijd_nieuwField = value;
			}
		}
		public string sgt_partij_nummer
		{
			get
			{
				return this.sgt_partij_nummerField;
			}
			set
			{
				this.sgt_partij_nummerField = value;
			}
		}
		public Lookup sgt_partij_uitslagid
		{
			get
			{
				return this.sgt_partij_uitslagidField;
			}
			set
			{
				this.sgt_partij_uitslagidField = value;
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
		public CrmNumber sgt_set1_thuis_nieuw
		{
			get
			{
				return this.sgt_set1_thuis_nieuwField;
			}
			set
			{
				this.sgt_set1_thuis_nieuwField = value;
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
		public CrmNumber sgt_set1_uit_nieuw
		{
			get
			{
				return this.sgt_set1_uit_nieuwField;
			}
			set
			{
				this.sgt_set1_uit_nieuwField = value;
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
		public CrmNumber sgt_set2_thuis_nieuw
		{
			get
			{
				return this.sgt_set2_thuis_nieuwField;
			}
			set
			{
				this.sgt_set2_thuis_nieuwField = value;
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
		public CrmNumber sgt_set2_uit_nieuw
		{
			get
			{
				return this.sgt_set2_uit_nieuwField;
			}
			set
			{
				this.sgt_set2_uit_nieuwField = value;
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
		public CrmNumber sgt_set3_thuis_nieuw
		{
			get
			{
				return this.sgt_set3_thuis_nieuwField;
			}
			set
			{
				this.sgt_set3_thuis_nieuwField = value;
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
		public CrmNumber sgt_set3_uit_nieuw
		{
			get
			{
				return this.sgt_set3_uit_nieuwField;
			}
			set
			{
				this.sgt_set3_uit_nieuwField = value;
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
		public CrmNumber sgt_set4_thuis_nieuw
		{
			get
			{
				return this.sgt_set4_thuis_nieuwField;
			}
			set
			{
				this.sgt_set4_thuis_nieuwField = value;
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
		public CrmNumber sgt_set4_uit_nieuw
		{
			get
			{
				return this.sgt_set4_uit_nieuwField;
			}
			set
			{
				this.sgt_set4_uit_nieuwField = value;
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
		public CrmNumber sgt_set5_thuis_nieuw
		{
			get
			{
				return this.sgt_set5_thuis_nieuwField;
			}
			set
			{
				this.sgt_set5_thuis_nieuwField = value;
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
		public CrmNumber sgt_set5_uit_nieuw
		{
			get
			{
				return this.sgt_set5_uit_nieuwField;
			}
			set
			{
				this.sgt_set5_uit_nieuwField = value;
			}
		}
		public CrmDateTime sgt_speeldatum
		{
			get
			{
				return this.sgt_speeldatumField;
			}
			set
			{
				this.sgt_speeldatumField = value;
			}
		}
		public Lookup sgt_speler1_thuis_nieuwid
		{
			get
			{
				return this.sgt_speler1_thuis_nieuwidField;
			}
			set
			{
				this.sgt_speler1_thuis_nieuwidField = value;
			}
		}
		public Lookup sgt_speler1_thuisid
		{
			get
			{
				return this.sgt_speler1_thuisidField;
			}
			set
			{
				this.sgt_speler1_thuisidField = value;
			}
		}
		public Lookup sgt_speler1_uit_nieuwid
		{
			get
			{
				return this.sgt_speler1_uit_nieuwidField;
			}
			set
			{
				this.sgt_speler1_uit_nieuwidField = value;
			}
		}
		public Lookup sgt_speler1_uitid
		{
			get
			{
				return this.sgt_speler1_uitidField;
			}
			set
			{
				this.sgt_speler1_uitidField = value;
			}
		}
		public Lookup sgt_speler2_thuis_nieuwid
		{
			get
			{
				return this.sgt_speler2_thuis_nieuwidField;
			}
			set
			{
				this.sgt_speler2_thuis_nieuwidField = value;
			}
		}
		public Lookup sgt_speler2_thuisid
		{
			get
			{
				return this.sgt_speler2_thuisidField;
			}
			set
			{
				this.sgt_speler2_thuisidField = value;
			}
		}
		public Lookup sgt_speler2_uit_nieuwid
		{
			get
			{
				return this.sgt_speler2_uit_nieuwidField;
			}
			set
			{
				this.sgt_speler2_uit_nieuwidField = value;
			}
		}
		public Lookup sgt_speler2_uitid
		{
			get
			{
				return this.sgt_speler2_uitidField;
			}
			set
			{
				this.sgt_speler2_uitidField = value;
			}
		}
		public Lookup sgt_spelerthuis2nietknltblidid
		{
			get
			{
				return this.sgt_spelerthuis2nietknltblididField;
			}
			set
			{
				this.sgt_spelerthuis2nietknltblididField = value;
			}
		}
		public Lookup sgt_spelerthuis2nietknltblidid_nieuw
		{
			get
			{
				return this.sgt_spelerthuis2nietknltblidid_nieuwField;
			}
			set
			{
				this.sgt_spelerthuis2nietknltblidid_nieuwField = value;
			}
		}
		public Lookup sgt_spelerthuisnietknltblidid
		{
			get
			{
				return this.sgt_spelerthuisnietknltblididField;
			}
			set
			{
				this.sgt_spelerthuisnietknltblididField = value;
			}
		}
		public Lookup sgt_spelerthuisnietknltblidid_nieuw
		{
			get
			{
				return this.sgt_spelerthuisnietknltblidid_nieuwField;
			}
			set
			{
				this.sgt_spelerthuisnietknltblidid_nieuwField = value;
			}
		}
		public Lookup sgt_speleruit2nietknltblidid
		{
			get
			{
				return this.sgt_speleruit2nietknltblididField;
			}
			set
			{
				this.sgt_speleruit2nietknltblididField = value;
			}
		}
		public Lookup sgt_speleruit2nietknltblidid_nieuw
		{
			get
			{
				return this.sgt_speleruit2nietknltblidid_nieuwField;
			}
			set
			{
				this.sgt_speleruit2nietknltblidid_nieuwField = value;
			}
		}
		public Lookup sgt_speleruitnietknltblidid
		{
			get
			{
				return this.sgt_speleruitnietknltblididField;
			}
			set
			{
				this.sgt_speleruitnietknltblididField = value;
			}
		}
		public Lookup sgt_speleruitnietknltblidid_nieuw
		{
			get
			{
				return this.sgt_speleruitnietknltblidid_nieuwField;
			}
			set
			{
				this.sgt_speleruitnietknltblidid_nieuwField = value;
			}
		}
		public Picklist sgt_uitslag_partij
		{
			get
			{
				return this.sgt_uitslag_partijField;
			}
			set
			{
				this.sgt_uitslag_partijField = value;
			}
		}
		public Picklist sgt_uitslag_partij_nieuw
		{
			get
			{
				return this.sgt_uitslag_partij_nieuwField;
			}
			set
			{
				this.sgt_uitslag_partij_nieuwField = value;
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
		public CrmNumber sgt_uitslag_thuis_nieuw
		{
			get
			{
				return this.sgt_uitslag_thuis_nieuwField;
			}
			set
			{
				this.sgt_uitslag_thuis_nieuwField = value;
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
		public CrmNumber sgt_uitslag_uit_nieuw
		{
			get
			{
				return this.sgt_uitslag_uit_nieuwField;
			}
			set
			{
				this.sgt_uitslag_uit_nieuwField = value;
			}
		}
		public string sgt_wedstrijd_nummer
		{
			get
			{
				return this.sgt_wedstrijd_nummerField;
			}
			set
			{
				this.sgt_wedstrijd_nummerField = value;
			}
		}
		public Lookup sgt_wedstrijd_uitslag_mutatieid
		{
			get
			{
				return this.sgt_wedstrijd_uitslag_mutatieidField;
			}
			set
			{
				this.sgt_wedstrijd_uitslag_mutatieidField = value;
			}
		}
		public Lookup sgt_wedstrijdgegevensid
		{
			get
			{
				return this.sgt_wedstrijdgegevensidField;
			}
			set
			{
				this.sgt_wedstrijdgegevensidField = value;
			}
		}
		public Sgt_com_partij_uitslag_mutatieStateInfo statecode
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
