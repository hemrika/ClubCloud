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
	public class sgt_dss_irreele_rs_mutatie : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private CrmDecimal sgt_actuele_ratingField;

		private CrmDecimal sgt_basisresultaatField;

		private string sgt_bondsnummer_1Field;

		private string sgt_bondsnummer_2Field;

		private Picklist sgt_com_of_toeField;

		private Lookup sgt_competitie_idField;

		private string sgt_competitie_toernooiField;

		private Key sgt_dss_irreele_rs_mutatieidField;

		private string sgt_dss_omschrijvingField;

		private CrmDecimal sgt_gecorrigeerd_partijresultaatField;

		private Lookup sgt_irreele_rs_logboek_idField;

		private Lookup sgt_naam_irs_speleridField;

		private Lookup sgt_naam_tegenstanderidField;

		private CrmDecimal sgt_oud_partijresultaatField;

		private CrmDateTime sgt_partij_datum_cField;

		private CrmDateTime sgt_partij_datum_tField;

		private string sgt_partij_idField;

		private Picklist sgt_partij_statusField;

		private Picklist sgt_partij_status_tField;

		private Lookup sgt_partij_uitslag_competitie_idField;

		private Lookup sgt_partij_uitslag_toernooi_idField;

		private Lookup sgt_toernooi_idField;

		private string sgt_volgnummer_irs_logboekField;

		private Sgt_dss_irreele_rs_mutatieStateInfo statecodeField;

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
		public CrmDecimal sgt_actuele_rating
		{
			get
			{
				return this.sgt_actuele_ratingField;
			}
			set
			{
				this.sgt_actuele_ratingField = value;
				base.RaisePropertyChanged("sgt_actuele_rating");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public CrmDecimal sgt_basisresultaat
		{
			get
			{
				return this.sgt_basisresultaatField;
			}
			set
			{
				this.sgt_basisresultaatField = value;
				base.RaisePropertyChanged("sgt_basisresultaat");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public string sgt_bondsnummer_1
		{
			get
			{
				return this.sgt_bondsnummer_1Field;
			}
			set
			{
				this.sgt_bondsnummer_1Field = value;
				base.RaisePropertyChanged("sgt_bondsnummer_1");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public string sgt_bondsnummer_2
		{
			get
			{
				return this.sgt_bondsnummer_2Field;
			}
			set
			{
				this.sgt_bondsnummer_2Field = value;
				base.RaisePropertyChanged("sgt_bondsnummer_2");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public Picklist sgt_com_of_toe
		{
			get
			{
				return this.sgt_com_of_toeField;
			}
			set
			{
				this.sgt_com_of_toeField = value;
				base.RaisePropertyChanged("sgt_com_of_toe");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public Lookup sgt_competitie_id
		{
			get
			{
				return this.sgt_competitie_idField;
			}
			set
			{
				this.sgt_competitie_idField = value;
				base.RaisePropertyChanged("sgt_competitie_id");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public string sgt_competitie_toernooi
		{
			get
			{
				return this.sgt_competitie_toernooiField;
			}
			set
			{
				this.sgt_competitie_toernooiField = value;
				base.RaisePropertyChanged("sgt_competitie_toernooi");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public Key sgt_dss_irreele_rs_mutatieid
		{
			get
			{
				return this.sgt_dss_irreele_rs_mutatieidField;
			}
			set
			{
				this.sgt_dss_irreele_rs_mutatieidField = value;
				base.RaisePropertyChanged("sgt_dss_irreele_rs_mutatieid");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public string sgt_dss_omschrijving
		{
			get
			{
				return this.sgt_dss_omschrijvingField;
			}
			set
			{
				this.sgt_dss_omschrijvingField = value;
				base.RaisePropertyChanged("sgt_dss_omschrijving");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public CrmDecimal sgt_gecorrigeerd_partijresultaat
		{
			get
			{
				return this.sgt_gecorrigeerd_partijresultaatField;
			}
			set
			{
				this.sgt_gecorrigeerd_partijresultaatField = value;
				base.RaisePropertyChanged("sgt_gecorrigeerd_partijresultaat");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public Lookup sgt_irreele_rs_logboek_id
		{
			get
			{
				return this.sgt_irreele_rs_logboek_idField;
			}
			set
			{
				this.sgt_irreele_rs_logboek_idField = value;
				base.RaisePropertyChanged("sgt_irreele_rs_logboek_id");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public Lookup sgt_naam_irs_spelerid
		{
			get
			{
				return this.sgt_naam_irs_speleridField;
			}
			set
			{
				this.sgt_naam_irs_speleridField = value;
				base.RaisePropertyChanged("sgt_naam_irs_spelerid");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public Lookup sgt_naam_tegenstanderid
		{
			get
			{
				return this.sgt_naam_tegenstanderidField;
			}
			set
			{
				this.sgt_naam_tegenstanderidField = value;
				base.RaisePropertyChanged("sgt_naam_tegenstanderid");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public CrmDecimal sgt_oud_partijresultaat
		{
			get
			{
				return this.sgt_oud_partijresultaatField;
			}
			set
			{
				this.sgt_oud_partijresultaatField = value;
				base.RaisePropertyChanged("sgt_oud_partijresultaat");
			}
		}

		[XmlElement] //[XmlElement(Order=22)]
		public CrmDateTime sgt_partij_datum_c
		{
			get
			{
				return this.sgt_partij_datum_cField;
			}
			set
			{
				this.sgt_partij_datum_cField = value;
				base.RaisePropertyChanged("sgt_partij_datum_c");
			}
		}

		[XmlElement] //[XmlElement(Order=23)]
		public CrmDateTime sgt_partij_datum_t
		{
			get
			{
				return this.sgt_partij_datum_tField;
			}
			set
			{
				this.sgt_partij_datum_tField = value;
				base.RaisePropertyChanged("sgt_partij_datum_t");
			}
		}

		[XmlElement] //[XmlElement(Order=24)]
		public string sgt_partij_id
		{
			get
			{
				return this.sgt_partij_idField;
			}
			set
			{
				this.sgt_partij_idField = value;
				base.RaisePropertyChanged("sgt_partij_id");
			}
		}

		[XmlElement] //[XmlElement(Order=25)]
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

		[XmlElement] //[XmlElement(Order=26)]
		public Picklist sgt_partij_status_t
		{
			get
			{
				return this.sgt_partij_status_tField;
			}
			set
			{
				this.sgt_partij_status_tField = value;
				base.RaisePropertyChanged("sgt_partij_status_t");
			}
		}

		[XmlElement] //[XmlElement(Order=27)]
		public Lookup sgt_partij_uitslag_competitie_id
		{
			get
			{
				return this.sgt_partij_uitslag_competitie_idField;
			}
			set
			{
				this.sgt_partij_uitslag_competitie_idField = value;
				base.RaisePropertyChanged("sgt_partij_uitslag_competitie_id");
			}
		}

		[XmlElement] //[XmlElement(Order=28)]
		public Lookup sgt_partij_uitslag_toernooi_id
		{
			get
			{
				return this.sgt_partij_uitslag_toernooi_idField;
			}
			set
			{
				this.sgt_partij_uitslag_toernooi_idField = value;
				base.RaisePropertyChanged("sgt_partij_uitslag_toernooi_id");
			}
		}

		[XmlElement] //[XmlElement(Order=29)]
		public Lookup sgt_toernooi_id
		{
			get
			{
				return this.sgt_toernooi_idField;
			}
			set
			{
				this.sgt_toernooi_idField = value;
				base.RaisePropertyChanged("sgt_toernooi_id");
			}
		}

		[XmlElement] //[XmlElement(Order=30)]
		public string sgt_volgnummer_irs_logboek
		{
			get
			{
				return this.sgt_volgnummer_irs_logboekField;
			}
			set
			{
				this.sgt_volgnummer_irs_logboekField = value;
				base.RaisePropertyChanged("sgt_volgnummer_irs_logboek");
			}
		}

		[XmlElement] //[XmlElement(Order=31)]
		public Sgt_dss_irreele_rs_mutatieStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=32)]
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

		[XmlElement] //[XmlElement(Order=33)]
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

		[XmlElement] //[XmlElement(Order=34)]
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

		public sgt_dss_irreele_rs_mutatie()
		{
		}
	}
}