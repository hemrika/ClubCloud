using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
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
		public CrmDecimal sgt_actuele_rating
		{
			get
			{
				return this.sgt_actuele_ratingField;
			}
			set
			{
				this.sgt_actuele_ratingField = value;
			}
		}
		public CrmDecimal sgt_basisresultaat
		{
			get
			{
				return this.sgt_basisresultaatField;
			}
			set
			{
				this.sgt_basisresultaatField = value;
			}
		}
		public string sgt_bondsnummer_1
		{
			get
			{
				return this.sgt_bondsnummer_1Field;
			}
			set
			{
				this.sgt_bondsnummer_1Field = value;
			}
		}
		public string sgt_bondsnummer_2
		{
			get
			{
				return this.sgt_bondsnummer_2Field;
			}
			set
			{
				this.sgt_bondsnummer_2Field = value;
			}
		}
		public Picklist sgt_com_of_toe
		{
			get
			{
				return this.sgt_com_of_toeField;
			}
			set
			{
				this.sgt_com_of_toeField = value;
			}
		}
		public Lookup sgt_competitie_id
		{
			get
			{
				return this.sgt_competitie_idField;
			}
			set
			{
				this.sgt_competitie_idField = value;
			}
		}
		public string sgt_competitie_toernooi
		{
			get
			{
				return this.sgt_competitie_toernooiField;
			}
			set
			{
				this.sgt_competitie_toernooiField = value;
			}
		}
		public Key sgt_dss_irreele_rs_mutatieid
		{
			get
			{
				return this.sgt_dss_irreele_rs_mutatieidField;
			}
			set
			{
				this.sgt_dss_irreele_rs_mutatieidField = value;
			}
		}
		public string sgt_dss_omschrijving
		{
			get
			{
				return this.sgt_dss_omschrijvingField;
			}
			set
			{
				this.sgt_dss_omschrijvingField = value;
			}
		}
		public CrmDecimal sgt_gecorrigeerd_partijresultaat
		{
			get
			{
				return this.sgt_gecorrigeerd_partijresultaatField;
			}
			set
			{
				this.sgt_gecorrigeerd_partijresultaatField = value;
			}
		}
		public Lookup sgt_irreele_rs_logboek_id
		{
			get
			{
				return this.sgt_irreele_rs_logboek_idField;
			}
			set
			{
				this.sgt_irreele_rs_logboek_idField = value;
			}
		}
		public Lookup sgt_naam_irs_spelerid
		{
			get
			{
				return this.sgt_naam_irs_speleridField;
			}
			set
			{
				this.sgt_naam_irs_speleridField = value;
			}
		}
		public Lookup sgt_naam_tegenstanderid
		{
			get
			{
				return this.sgt_naam_tegenstanderidField;
			}
			set
			{
				this.sgt_naam_tegenstanderidField = value;
			}
		}
		public CrmDecimal sgt_oud_partijresultaat
		{
			get
			{
				return this.sgt_oud_partijresultaatField;
			}
			set
			{
				this.sgt_oud_partijresultaatField = value;
			}
		}
		public CrmDateTime sgt_partij_datum_c
		{
			get
			{
				return this.sgt_partij_datum_cField;
			}
			set
			{
				this.sgt_partij_datum_cField = value;
			}
		}
		public CrmDateTime sgt_partij_datum_t
		{
			get
			{
				return this.sgt_partij_datum_tField;
			}
			set
			{
				this.sgt_partij_datum_tField = value;
			}
		}
		public string sgt_partij_id
		{
			get
			{
				return this.sgt_partij_idField;
			}
			set
			{
				this.sgt_partij_idField = value;
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
		public Picklist sgt_partij_status_t
		{
			get
			{
				return this.sgt_partij_status_tField;
			}
			set
			{
				this.sgt_partij_status_tField = value;
			}
		}
		public Lookup sgt_partij_uitslag_competitie_id
		{
			get
			{
				return this.sgt_partij_uitslag_competitie_idField;
			}
			set
			{
				this.sgt_partij_uitslag_competitie_idField = value;
			}
		}
		public Lookup sgt_partij_uitslag_toernooi_id
		{
			get
			{
				return this.sgt_partij_uitslag_toernooi_idField;
			}
			set
			{
				this.sgt_partij_uitslag_toernooi_idField = value;
			}
		}
		public Lookup sgt_toernooi_id
		{
			get
			{
				return this.sgt_toernooi_idField;
			}
			set
			{
				this.sgt_toernooi_idField = value;
			}
		}
		public string sgt_volgnummer_irs_logboek
		{
			get
			{
				return this.sgt_volgnummer_irs_logboekField;
			}
			set
			{
				this.sgt_volgnummer_irs_logboekField = value;
			}
		}
		public Sgt_dss_irreele_rs_mutatieStateInfo statecode
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
