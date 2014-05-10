using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_alg_gebeurtenis : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmDecimal exchangerateField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private string sgt_alg_gebeurtenis1Field;
		private Key sgt_alg_gebeurtenisidField;
		private Picklist sgt_alg_gespreksduurField;
		private Lookup sgt_alg_gespreksonderwerpidField;
		private Picklist sgt_alg_gesprokenoverField;
		private Picklist sgt_alg_webregistratieField;
		private Lookup sgt_basisorganisatieidField;
		private CrmMoney sgt_bedrag_deelnameField;
		private CrmMoney sgt_bedrag_deelname_baseField;
		private CrmMoney sgt_bijdrage_straattennisField;
		private CrmMoney sgt_bijdrage_straattennis_baseField;
		private Lookup sgt_campagneidField;
		private CrmDateTime sgt_controleaantalinschrijvingenField;
		private CrmDateTime sgt_datumgebeurtenisField;
		private CrmBoolean sgt_deelnemerslijst_tonenField;
		private Lookup sgt_districtidField;
		private Lookup sgt_dynamicformidField;
		private CrmDateTime sgt_einddatumgebeurtenisField;
		private CrmBoolean sgt_facturerenField;
		private Lookup sgt_gebeurtenistypeidField;
		private CrmBoolean sgt_ideal_betalingField;
		private Lookup sgt_locatieidField;
		private CrmNumber sgt_minimaleinschrijvingField;
		private string sgt_omschrijvingField;
		private Lookup sgt_onderwerp1idField;
		private Lookup sgt_onderwerp2idField;
		private Lookup sgt_onderwerp3idField;
		private Lookup sgt_onderwerp4idField;
		private Lookup sgt_onderwerp5idField;
		private Lookup sgt_persoonidField;
		private CrmDateTime sgt_sluitinginschirjvingField;
		private Lookup sgt_toernooionderdee_lidField;
		private Sgt_alg_gebeurtenisStateInfo statecodeField;
		private Status statuscodeField;
		private CrmNumber timezoneruleversionnumberField;
		private Lookup transactioncurrencyidField;
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
		public CrmDecimal exchangerate
		{
			get
			{
				return this.exchangerateField;
			}
			set
			{
				this.exchangerateField = value;
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
		[XmlElement("sgt_alg_gebeurtenis")]
		public string sgt_alg_gebeurtenis1
		{
			get
			{
				return this.sgt_alg_gebeurtenis1Field;
			}
			set
			{
				this.sgt_alg_gebeurtenis1Field = value;
			}
		}
		public Key sgt_alg_gebeurtenisid
		{
			get
			{
				return this.sgt_alg_gebeurtenisidField;
			}
			set
			{
				this.sgt_alg_gebeurtenisidField = value;
			}
		}
		public Picklist sgt_alg_gespreksduur
		{
			get
			{
				return this.sgt_alg_gespreksduurField;
			}
			set
			{
				this.sgt_alg_gespreksduurField = value;
			}
		}
		public Lookup sgt_alg_gespreksonderwerpid
		{
			get
			{
				return this.sgt_alg_gespreksonderwerpidField;
			}
			set
			{
				this.sgt_alg_gespreksonderwerpidField = value;
			}
		}
		public Picklist sgt_alg_gesprokenover
		{
			get
			{
				return this.sgt_alg_gesprokenoverField;
			}
			set
			{
				this.sgt_alg_gesprokenoverField = value;
			}
		}
		public Picklist sgt_alg_webregistratie
		{
			get
			{
				return this.sgt_alg_webregistratieField;
			}
			set
			{
				this.sgt_alg_webregistratieField = value;
			}
		}
		public Lookup sgt_basisorganisatieid
		{
			get
			{
				return this.sgt_basisorganisatieidField;
			}
			set
			{
				this.sgt_basisorganisatieidField = value;
			}
		}
		public CrmMoney sgt_bedrag_deelname
		{
			get
			{
				return this.sgt_bedrag_deelnameField;
			}
			set
			{
				this.sgt_bedrag_deelnameField = value;
			}
		}
		public CrmMoney sgt_bedrag_deelname_base
		{
			get
			{
				return this.sgt_bedrag_deelname_baseField;
			}
			set
			{
				this.sgt_bedrag_deelname_baseField = value;
			}
		}
		public CrmMoney sgt_bijdrage_straattennis
		{
			get
			{
				return this.sgt_bijdrage_straattennisField;
			}
			set
			{
				this.sgt_bijdrage_straattennisField = value;
			}
		}
		public CrmMoney sgt_bijdrage_straattennis_base
		{
			get
			{
				return this.sgt_bijdrage_straattennis_baseField;
			}
			set
			{
				this.sgt_bijdrage_straattennis_baseField = value;
			}
		}
		public Lookup sgt_campagneid
		{
			get
			{
				return this.sgt_campagneidField;
			}
			set
			{
				this.sgt_campagneidField = value;
			}
		}
		public CrmDateTime sgt_controleaantalinschrijvingen
		{
			get
			{
				return this.sgt_controleaantalinschrijvingenField;
			}
			set
			{
				this.sgt_controleaantalinschrijvingenField = value;
			}
		}
		public CrmDateTime sgt_datumgebeurtenis
		{
			get
			{
				return this.sgt_datumgebeurtenisField;
			}
			set
			{
				this.sgt_datumgebeurtenisField = value;
			}
		}
		public CrmBoolean sgt_deelnemerslijst_tonen
		{
			get
			{
				return this.sgt_deelnemerslijst_tonenField;
			}
			set
			{
				this.sgt_deelnemerslijst_tonenField = value;
			}
		}
		public Lookup sgt_districtid
		{
			get
			{
				return this.sgt_districtidField;
			}
			set
			{
				this.sgt_districtidField = value;
			}
		}
		public Lookup sgt_dynamicformid
		{
			get
			{
				return this.sgt_dynamicformidField;
			}
			set
			{
				this.sgt_dynamicformidField = value;
			}
		}
		public CrmDateTime sgt_einddatumgebeurtenis
		{
			get
			{
				return this.sgt_einddatumgebeurtenisField;
			}
			set
			{
				this.sgt_einddatumgebeurtenisField = value;
			}
		}
		public CrmBoolean sgt_factureren
		{
			get
			{
				return this.sgt_facturerenField;
			}
			set
			{
				this.sgt_facturerenField = value;
			}
		}
		public Lookup sgt_gebeurtenistypeid
		{
			get
			{
				return this.sgt_gebeurtenistypeidField;
			}
			set
			{
				this.sgt_gebeurtenistypeidField = value;
			}
		}
		public CrmBoolean sgt_ideal_betaling
		{
			get
			{
				return this.sgt_ideal_betalingField;
			}
			set
			{
				this.sgt_ideal_betalingField = value;
			}
		}
		public Lookup sgt_locatieid
		{
			get
			{
				return this.sgt_locatieidField;
			}
			set
			{
				this.sgt_locatieidField = value;
			}
		}
		public CrmNumber sgt_minimaleinschrijving
		{
			get
			{
				return this.sgt_minimaleinschrijvingField;
			}
			set
			{
				this.sgt_minimaleinschrijvingField = value;
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
		public Lookup sgt_onderwerp1id
		{
			get
			{
				return this.sgt_onderwerp1idField;
			}
			set
			{
				this.sgt_onderwerp1idField = value;
			}
		}
		public Lookup sgt_onderwerp2id
		{
			get
			{
				return this.sgt_onderwerp2idField;
			}
			set
			{
				this.sgt_onderwerp2idField = value;
			}
		}
		public Lookup sgt_onderwerp3id
		{
			get
			{
				return this.sgt_onderwerp3idField;
			}
			set
			{
				this.sgt_onderwerp3idField = value;
			}
		}
		public Lookup sgt_onderwerp4id
		{
			get
			{
				return this.sgt_onderwerp4idField;
			}
			set
			{
				this.sgt_onderwerp4idField = value;
			}
		}
		public Lookup sgt_onderwerp5id
		{
			get
			{
				return this.sgt_onderwerp5idField;
			}
			set
			{
				this.sgt_onderwerp5idField = value;
			}
		}
		public Lookup sgt_persoonid
		{
			get
			{
				return this.sgt_persoonidField;
			}
			set
			{
				this.sgt_persoonidField = value;
			}
		}
		public CrmDateTime sgt_sluitinginschirjving
		{
			get
			{
				return this.sgt_sluitinginschirjvingField;
			}
			set
			{
				this.sgt_sluitinginschirjvingField = value;
			}
		}
		public Lookup sgt_toernooionderdee_lid
		{
			get
			{
				return this.sgt_toernooionderdee_lidField;
			}
			set
			{
				this.sgt_toernooionderdee_lidField = value;
			}
		}
		public Sgt_alg_gebeurtenisStateInfo statecode
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
		public Lookup transactioncurrencyid
		{
			get
			{
				return this.transactioncurrencyidField;
			}
			set
			{
				this.transactioncurrencyidField = value;
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
