using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_com_competitieinschrijving : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Lookup sgt_accommodatieidField;
		private CrmBoolean sgt_alle_ploegen_thuisField;
		private CrmBoolean sgt_alle_ploegen_thuis_di_avondField;
		private CrmBoolean sgt_alle_ploegen_thuis_di_heledagField;
		private CrmBoolean sgt_alle_ploegen_thuis_di_middagField;
		private CrmBoolean sgt_alle_ploegen_thuis_di_morgenField;
		private CrmBoolean sgt_alle_ploegen_thuis_do_avondField;
		private CrmBoolean sgt_alle_ploegen_thuis_do_heledagField;
		private CrmBoolean sgt_alle_ploegen_thuis_do_middagField;
		private CrmBoolean sgt_alle_ploegen_thuis_do_morgenField;
		private CrmBoolean sgt_alle_ploegen_thuis_ma_avondField;
		private CrmBoolean sgt_alle_ploegen_thuis_ma_heledagField;
		private CrmBoolean sgt_alle_ploegen_thuis_ma_middagField;
		private CrmBoolean sgt_alle_ploegen_thuis_ma_morgenField;
		private CrmBoolean sgt_alle_ploegen_thuis_vr_avondField;
		private CrmBoolean sgt_alle_ploegen_thuis_vr_heledagField;
		private CrmBoolean sgt_alle_ploegen_thuis_vr_middagField;
		private CrmBoolean sgt_alle_ploegen_thuis_vr_morgenField;
		private CrmBoolean sgt_alle_ploegen_thuis_wo_avondField;
		private CrmBoolean sgt_alle_ploegen_thuis_wo_heledagField;
		private CrmBoolean sgt_alle_ploegen_thuis_wo_middagField;
		private CrmBoolean sgt_alle_ploegen_thuis_wo_morgenField;
		private CrmBoolean sgt_alle_ploegen_thuis_za_avondField;
		private CrmBoolean sgt_alle_ploegen_thuis_za_heledagField;
		private CrmBoolean sgt_alle_ploegen_thuis_za_middagField;
		private CrmBoolean sgt_alle_ploegen_thuis_za_morgenField;
		private CrmBoolean sgt_alle_ploegen_thuis_zo_avondField;
		private CrmBoolean sgt_alle_ploegen_thuis_zo_heledagField;
		private CrmBoolean sgt_alle_ploegen_thuis_zo_middagField;
		private CrmBoolean sgt_alle_ploegen_thuis_zo_morgenField;
		private Key sgt_com_competitieinschrijvingidField;
		private string sgt_com_verenigingsnummerField;
		private Lookup sgt_competitieidField;
		private CrmDateTime sgt_datum_inschrijvingField;
		private string sgt_email_inhoudField;
		private Lookup sgt_functieidField;
		private Lookup sgt_ingeschreven_dooridField;
		private string sgt_melding_certificaatField;
		private Picklist sgt_status_inschrijvingField;
		private CrmBoolean sgt_variabele_begintijden_avondField;
		private CrmBoolean sgt_variabele_begintijden_hele_dagField;
		private CrmBoolean sgt_variabele_begintijden_middagField;
		private CrmBoolean sgt_variabele_begintijden_morgenField;
		private Lookup sgt_verenigingidField;
		private Lookup sgt_verenigingsrechtidField;
		private Sgt_com_competitieinschrijvingStateInfo statecodeField;
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
		public Lookup sgt_accommodatieid
		{
			get
			{
				return this.sgt_accommodatieidField;
			}
			set
			{
				this.sgt_accommodatieidField = value;
			}
		}
		public CrmBoolean sgt_alle_ploegen_thuis
		{
			get
			{
				return this.sgt_alle_ploegen_thuisField;
			}
			set
			{
				this.sgt_alle_ploegen_thuisField = value;
			}
		}
		public CrmBoolean sgt_alle_ploegen_thuis_di_avond
		{
			get
			{
				return this.sgt_alle_ploegen_thuis_di_avondField;
			}
			set
			{
				this.sgt_alle_ploegen_thuis_di_avondField = value;
			}
		}
		public CrmBoolean sgt_alle_ploegen_thuis_di_heledag
		{
			get
			{
				return this.sgt_alle_ploegen_thuis_di_heledagField;
			}
			set
			{
				this.sgt_alle_ploegen_thuis_di_heledagField = value;
			}
		}
		public CrmBoolean sgt_alle_ploegen_thuis_di_middag
		{
			get
			{
				return this.sgt_alle_ploegen_thuis_di_middagField;
			}
			set
			{
				this.sgt_alle_ploegen_thuis_di_middagField = value;
			}
		}
		public CrmBoolean sgt_alle_ploegen_thuis_di_morgen
		{
			get
			{
				return this.sgt_alle_ploegen_thuis_di_morgenField;
			}
			set
			{
				this.sgt_alle_ploegen_thuis_di_morgenField = value;
			}
		}
		public CrmBoolean sgt_alle_ploegen_thuis_do_avond
		{
			get
			{
				return this.sgt_alle_ploegen_thuis_do_avondField;
			}
			set
			{
				this.sgt_alle_ploegen_thuis_do_avondField = value;
			}
		}
		public CrmBoolean sgt_alle_ploegen_thuis_do_heledag
		{
			get
			{
				return this.sgt_alle_ploegen_thuis_do_heledagField;
			}
			set
			{
				this.sgt_alle_ploegen_thuis_do_heledagField = value;
			}
		}
		public CrmBoolean sgt_alle_ploegen_thuis_do_middag
		{
			get
			{
				return this.sgt_alle_ploegen_thuis_do_middagField;
			}
			set
			{
				this.sgt_alle_ploegen_thuis_do_middagField = value;
			}
		}
		public CrmBoolean sgt_alle_ploegen_thuis_do_morgen
		{
			get
			{
				return this.sgt_alle_ploegen_thuis_do_morgenField;
			}
			set
			{
				this.sgt_alle_ploegen_thuis_do_morgenField = value;
			}
		}
		public CrmBoolean sgt_alle_ploegen_thuis_ma_avond
		{
			get
			{
				return this.sgt_alle_ploegen_thuis_ma_avondField;
			}
			set
			{
				this.sgt_alle_ploegen_thuis_ma_avondField = value;
			}
		}
		public CrmBoolean sgt_alle_ploegen_thuis_ma_heledag
		{
			get
			{
				return this.sgt_alle_ploegen_thuis_ma_heledagField;
			}
			set
			{
				this.sgt_alle_ploegen_thuis_ma_heledagField = value;
			}
		}
		public CrmBoolean sgt_alle_ploegen_thuis_ma_middag
		{
			get
			{
				return this.sgt_alle_ploegen_thuis_ma_middagField;
			}
			set
			{
				this.sgt_alle_ploegen_thuis_ma_middagField = value;
			}
		}
		public CrmBoolean sgt_alle_ploegen_thuis_ma_morgen
		{
			get
			{
				return this.sgt_alle_ploegen_thuis_ma_morgenField;
			}
			set
			{
				this.sgt_alle_ploegen_thuis_ma_morgenField = value;
			}
		}
		public CrmBoolean sgt_alle_ploegen_thuis_vr_avond
		{
			get
			{
				return this.sgt_alle_ploegen_thuis_vr_avondField;
			}
			set
			{
				this.sgt_alle_ploegen_thuis_vr_avondField = value;
			}
		}
		public CrmBoolean sgt_alle_ploegen_thuis_vr_heledag
		{
			get
			{
				return this.sgt_alle_ploegen_thuis_vr_heledagField;
			}
			set
			{
				this.sgt_alle_ploegen_thuis_vr_heledagField = value;
			}
		}
		public CrmBoolean sgt_alle_ploegen_thuis_vr_middag
		{
			get
			{
				return this.sgt_alle_ploegen_thuis_vr_middagField;
			}
			set
			{
				this.sgt_alle_ploegen_thuis_vr_middagField = value;
			}
		}
		public CrmBoolean sgt_alle_ploegen_thuis_vr_morgen
		{
			get
			{
				return this.sgt_alle_ploegen_thuis_vr_morgenField;
			}
			set
			{
				this.sgt_alle_ploegen_thuis_vr_morgenField = value;
			}
		}
		public CrmBoolean sgt_alle_ploegen_thuis_wo_avond
		{
			get
			{
				return this.sgt_alle_ploegen_thuis_wo_avondField;
			}
			set
			{
				this.sgt_alle_ploegen_thuis_wo_avondField = value;
			}
		}
		public CrmBoolean sgt_alle_ploegen_thuis_wo_heledag
		{
			get
			{
				return this.sgt_alle_ploegen_thuis_wo_heledagField;
			}
			set
			{
				this.sgt_alle_ploegen_thuis_wo_heledagField = value;
			}
		}
		public CrmBoolean sgt_alle_ploegen_thuis_wo_middag
		{
			get
			{
				return this.sgt_alle_ploegen_thuis_wo_middagField;
			}
			set
			{
				this.sgt_alle_ploegen_thuis_wo_middagField = value;
			}
		}
		public CrmBoolean sgt_alle_ploegen_thuis_wo_morgen
		{
			get
			{
				return this.sgt_alle_ploegen_thuis_wo_morgenField;
			}
			set
			{
				this.sgt_alle_ploegen_thuis_wo_morgenField = value;
			}
		}
		public CrmBoolean sgt_alle_ploegen_thuis_za_avond
		{
			get
			{
				return this.sgt_alle_ploegen_thuis_za_avondField;
			}
			set
			{
				this.sgt_alle_ploegen_thuis_za_avondField = value;
			}
		}
		public CrmBoolean sgt_alle_ploegen_thuis_za_heledag
		{
			get
			{
				return this.sgt_alle_ploegen_thuis_za_heledagField;
			}
			set
			{
				this.sgt_alle_ploegen_thuis_za_heledagField = value;
			}
		}
		public CrmBoolean sgt_alle_ploegen_thuis_za_middag
		{
			get
			{
				return this.sgt_alle_ploegen_thuis_za_middagField;
			}
			set
			{
				this.sgt_alle_ploegen_thuis_za_middagField = value;
			}
		}
		public CrmBoolean sgt_alle_ploegen_thuis_za_morgen
		{
			get
			{
				return this.sgt_alle_ploegen_thuis_za_morgenField;
			}
			set
			{
				this.sgt_alle_ploegen_thuis_za_morgenField = value;
			}
		}
		public CrmBoolean sgt_alle_ploegen_thuis_zo_avond
		{
			get
			{
				return this.sgt_alle_ploegen_thuis_zo_avondField;
			}
			set
			{
				this.sgt_alle_ploegen_thuis_zo_avondField = value;
			}
		}
		public CrmBoolean sgt_alle_ploegen_thuis_zo_heledag
		{
			get
			{
				return this.sgt_alle_ploegen_thuis_zo_heledagField;
			}
			set
			{
				this.sgt_alle_ploegen_thuis_zo_heledagField = value;
			}
		}
		public CrmBoolean sgt_alle_ploegen_thuis_zo_middag
		{
			get
			{
				return this.sgt_alle_ploegen_thuis_zo_middagField;
			}
			set
			{
				this.sgt_alle_ploegen_thuis_zo_middagField = value;
			}
		}
		public CrmBoolean sgt_alle_ploegen_thuis_zo_morgen
		{
			get
			{
				return this.sgt_alle_ploegen_thuis_zo_morgenField;
			}
			set
			{
				this.sgt_alle_ploegen_thuis_zo_morgenField = value;
			}
		}
		public Key sgt_com_competitieinschrijvingid
		{
			get
			{
				return this.sgt_com_competitieinschrijvingidField;
			}
			set
			{
				this.sgt_com_competitieinschrijvingidField = value;
			}
		}
		public string sgt_com_verenigingsnummer
		{
			get
			{
				return this.sgt_com_verenigingsnummerField;
			}
			set
			{
				this.sgt_com_verenigingsnummerField = value;
			}
		}
		public Lookup sgt_competitieid
		{
			get
			{
				return this.sgt_competitieidField;
			}
			set
			{
				this.sgt_competitieidField = value;
			}
		}
		public CrmDateTime sgt_datum_inschrijving
		{
			get
			{
				return this.sgt_datum_inschrijvingField;
			}
			set
			{
				this.sgt_datum_inschrijvingField = value;
			}
		}
		public string sgt_email_inhoud
		{
			get
			{
				return this.sgt_email_inhoudField;
			}
			set
			{
				this.sgt_email_inhoudField = value;
			}
		}
		public Lookup sgt_functieid
		{
			get
			{
				return this.sgt_functieidField;
			}
			set
			{
				this.sgt_functieidField = value;
			}
		}
		public Lookup sgt_ingeschreven_doorid
		{
			get
			{
				return this.sgt_ingeschreven_dooridField;
			}
			set
			{
				this.sgt_ingeschreven_dooridField = value;
			}
		}
		public string sgt_melding_certificaat
		{
			get
			{
				return this.sgt_melding_certificaatField;
			}
			set
			{
				this.sgt_melding_certificaatField = value;
			}
		}
		public Picklist sgt_status_inschrijving
		{
			get
			{
				return this.sgt_status_inschrijvingField;
			}
			set
			{
				this.sgt_status_inschrijvingField = value;
			}
		}
		public CrmBoolean sgt_variabele_begintijden_avond
		{
			get
			{
				return this.sgt_variabele_begintijden_avondField;
			}
			set
			{
				this.sgt_variabele_begintijden_avondField = value;
			}
		}
		public CrmBoolean sgt_variabele_begintijden_hele_dag
		{
			get
			{
				return this.sgt_variabele_begintijden_hele_dagField;
			}
			set
			{
				this.sgt_variabele_begintijden_hele_dagField = value;
			}
		}
		public CrmBoolean sgt_variabele_begintijden_middag
		{
			get
			{
				return this.sgt_variabele_begintijden_middagField;
			}
			set
			{
				this.sgt_variabele_begintijden_middagField = value;
			}
		}
		public CrmBoolean sgt_variabele_begintijden_morgen
		{
			get
			{
				return this.sgt_variabele_begintijden_morgenField;
			}
			set
			{
				this.sgt_variabele_begintijden_morgenField = value;
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
		public Lookup sgt_verenigingsrechtid
		{
			get
			{
				return this.sgt_verenigingsrechtidField;
			}
			set
			{
				this.sgt_verenigingsrechtidField = value;
			}
		}
		public Sgt_com_competitieinschrijvingStateInfo statecode
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
