using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_ranglijst : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private CrmBoolean sgt_bonusfactor_niet_categorie_spelersField;
		private Lookup sgt_circuitidField;
		private CrmDateTime sgt_datum_laatste_ranglijstField;
		private CrmDateTime sgt_datum_tmField;
		private Lookup sgt_districtidField;
		private CrmNumber sgt_drempe_lop_ranglijst_bonuspuntenField;
		private Picklist sgt_geslachtField;
		private CrmBoolean sgt_handmatigField;
		private Lookup sgt_herkomstranglijstidField;
		private Lookup sgt_ranglijst_bonuspuntenidField;
		private Lookup sgt_ranglijst_groepidField;
		private CrmBoolean sgt_ranglijstpunten_voor_1ste_en_2de_jaarsField;
		private Picklist sgt_ranglijsttypeField;
		private Lookup sgt_referentieranglijstidrField;
		private Picklist sgt_spelsoortField;
		private Lookup sgt_tennisnationaliteitidField;
		private string sgt_toe_ranglijst1Field;
		private Key sgt_toe_ranglijstidField;
		private Lookup sgt_toernooigroepidField;
		private Lookup sgt_toernooisoortidField;
		private CrmBoolean sgt_tonen_mijnknltbField;
		private Lookup sgt_type_ranglijstidField;
		private Sgt_toe_ranglijstStateInfo statecodeField;
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
		public CrmBoolean sgt_bonusfactor_niet_categorie_spelers
		{
			get
			{
				return this.sgt_bonusfactor_niet_categorie_spelersField;
			}
			set
			{
				this.sgt_bonusfactor_niet_categorie_spelersField = value;
			}
		}
		public Lookup sgt_circuitid
		{
			get
			{
				return this.sgt_circuitidField;
			}
			set
			{
				this.sgt_circuitidField = value;
			}
		}
		public CrmDateTime sgt_datum_laatste_ranglijst
		{
			get
			{
				return this.sgt_datum_laatste_ranglijstField;
			}
			set
			{
				this.sgt_datum_laatste_ranglijstField = value;
			}
		}
		public CrmDateTime sgt_datum_tm
		{
			get
			{
				return this.sgt_datum_tmField;
			}
			set
			{
				this.sgt_datum_tmField = value;
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
		public CrmNumber sgt_drempe_lop_ranglijst_bonuspunten
		{
			get
			{
				return this.sgt_drempe_lop_ranglijst_bonuspuntenField;
			}
			set
			{
				this.sgt_drempe_lop_ranglijst_bonuspuntenField = value;
			}
		}
		public Picklist sgt_geslacht
		{
			get
			{
				return this.sgt_geslachtField;
			}
			set
			{
				this.sgt_geslachtField = value;
			}
		}
		public CrmBoolean sgt_handmatig
		{
			get
			{
				return this.sgt_handmatigField;
			}
			set
			{
				this.sgt_handmatigField = value;
			}
		}
		public Lookup sgt_herkomstranglijstid
		{
			get
			{
				return this.sgt_herkomstranglijstidField;
			}
			set
			{
				this.sgt_herkomstranglijstidField = value;
			}
		}
		public Lookup sgt_ranglijst_bonuspuntenid
		{
			get
			{
				return this.sgt_ranglijst_bonuspuntenidField;
			}
			set
			{
				this.sgt_ranglijst_bonuspuntenidField = value;
			}
		}
		public Lookup sgt_ranglijst_groepid
		{
			get
			{
				return this.sgt_ranglijst_groepidField;
			}
			set
			{
				this.sgt_ranglijst_groepidField = value;
			}
		}
		public CrmBoolean sgt_ranglijstpunten_voor_1ste_en_2de_jaars
		{
			get
			{
				return this.sgt_ranglijstpunten_voor_1ste_en_2de_jaarsField;
			}
			set
			{
				this.sgt_ranglijstpunten_voor_1ste_en_2de_jaarsField = value;
			}
		}
		public Picklist sgt_ranglijsttype
		{
			get
			{
				return this.sgt_ranglijsttypeField;
			}
			set
			{
				this.sgt_ranglijsttypeField = value;
			}
		}
		public Lookup sgt_referentieranglijstidr
		{
			get
			{
				return this.sgt_referentieranglijstidrField;
			}
			set
			{
				this.sgt_referentieranglijstidrField = value;
			}
		}
		public Picklist sgt_spelsoort
		{
			get
			{
				return this.sgt_spelsoortField;
			}
			set
			{
				this.sgt_spelsoortField = value;
			}
		}
		public Lookup sgt_tennisnationaliteitid
		{
			get
			{
				return this.sgt_tennisnationaliteitidField;
			}
			set
			{
				this.sgt_tennisnationaliteitidField = value;
			}
		}
		[XmlElement("sgt_toe_ranglijst")]
		public string sgt_toe_ranglijst1
		{
			get
			{
				return this.sgt_toe_ranglijst1Field;
			}
			set
			{
				this.sgt_toe_ranglijst1Field = value;
			}
		}
		public Key sgt_toe_ranglijstid
		{
			get
			{
				return this.sgt_toe_ranglijstidField;
			}
			set
			{
				this.sgt_toe_ranglijstidField = value;
			}
		}
		public Lookup sgt_toernooigroepid
		{
			get
			{
				return this.sgt_toernooigroepidField;
			}
			set
			{
				this.sgt_toernooigroepidField = value;
			}
		}
		public Lookup sgt_toernooisoortid
		{
			get
			{
				return this.sgt_toernooisoortidField;
			}
			set
			{
				this.sgt_toernooisoortidField = value;
			}
		}
		public CrmBoolean sgt_tonen_mijnknltb
		{
			get
			{
				return this.sgt_tonen_mijnknltbField;
			}
			set
			{
				this.sgt_tonen_mijnknltbField = value;
			}
		}
		public Lookup sgt_type_ranglijstid
		{
			get
			{
				return this.sgt_type_ranglijstidField;
			}
			set
			{
				this.sgt_type_ranglijstidField = value;
			}
		}
		public Sgt_toe_ranglijstStateInfo statecode
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
