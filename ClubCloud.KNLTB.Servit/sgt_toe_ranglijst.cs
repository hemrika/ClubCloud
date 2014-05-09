using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
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
		public CrmBoolean sgt_bonusfactor_niet_categorie_spelers
		{
			get
			{
				return this.sgt_bonusfactor_niet_categorie_spelersField;
			}
			set
			{
				this.sgt_bonusfactor_niet_categorie_spelersField = value;
				base.RaisePropertyChanged("sgt_bonusfactor_niet_categorie_spelers");
			}
		}
		[XmlElement(Order = 9)]
		public Lookup sgt_circuitid
		{
			get
			{
				return this.sgt_circuitidField;
			}
			set
			{
				this.sgt_circuitidField = value;
				base.RaisePropertyChanged("sgt_circuitid");
			}
		}
		[XmlElement(Order = 10)]
		public CrmDateTime sgt_datum_laatste_ranglijst
		{
			get
			{
				return this.sgt_datum_laatste_ranglijstField;
			}
			set
			{
				this.sgt_datum_laatste_ranglijstField = value;
				base.RaisePropertyChanged("sgt_datum_laatste_ranglijst");
			}
		}
		[XmlElement(Order = 11)]
		public CrmDateTime sgt_datum_tm
		{
			get
			{
				return this.sgt_datum_tmField;
			}
			set
			{
				this.sgt_datum_tmField = value;
				base.RaisePropertyChanged("sgt_datum_tm");
			}
		}
		[XmlElement(Order = 12)]
		public Lookup sgt_districtid
		{
			get
			{
				return this.sgt_districtidField;
			}
			set
			{
				this.sgt_districtidField = value;
				base.RaisePropertyChanged("sgt_districtid");
			}
		}
		[XmlElement(Order = 13)]
		public CrmNumber sgt_drempe_lop_ranglijst_bonuspunten
		{
			get
			{
				return this.sgt_drempe_lop_ranglijst_bonuspuntenField;
			}
			set
			{
				this.sgt_drempe_lop_ranglijst_bonuspuntenField = value;
				base.RaisePropertyChanged("sgt_drempe_lop_ranglijst_bonuspunten");
			}
		}
		[XmlElement(Order = 14)]
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
		[XmlElement(Order = 15)]
		public CrmBoolean sgt_handmatig
		{
			get
			{
				return this.sgt_handmatigField;
			}
			set
			{
				this.sgt_handmatigField = value;
				base.RaisePropertyChanged("sgt_handmatig");
			}
		}
		[XmlElement(Order = 16)]
		public Lookup sgt_herkomstranglijstid
		{
			get
			{
				return this.sgt_herkomstranglijstidField;
			}
			set
			{
				this.sgt_herkomstranglijstidField = value;
				base.RaisePropertyChanged("sgt_herkomstranglijstid");
			}
		}
		[XmlElement(Order = 17)]
		public Lookup sgt_ranglijst_bonuspuntenid
		{
			get
			{
				return this.sgt_ranglijst_bonuspuntenidField;
			}
			set
			{
				this.sgt_ranglijst_bonuspuntenidField = value;
				base.RaisePropertyChanged("sgt_ranglijst_bonuspuntenid");
			}
		}
		[XmlElement(Order = 18)]
		public Lookup sgt_ranglijst_groepid
		{
			get
			{
				return this.sgt_ranglijst_groepidField;
			}
			set
			{
				this.sgt_ranglijst_groepidField = value;
				base.RaisePropertyChanged("sgt_ranglijst_groepid");
			}
		}
		[XmlElement(Order = 19)]
		public CrmBoolean sgt_ranglijstpunten_voor_1ste_en_2de_jaars
		{
			get
			{
				return this.sgt_ranglijstpunten_voor_1ste_en_2de_jaarsField;
			}
			set
			{
				this.sgt_ranglijstpunten_voor_1ste_en_2de_jaarsField = value;
				base.RaisePropertyChanged("sgt_ranglijstpunten_voor_1ste_en_2de_jaars");
			}
		}
		[XmlElement(Order = 20)]
		public Picklist sgt_ranglijsttype
		{
			get
			{
				return this.sgt_ranglijsttypeField;
			}
			set
			{
				this.sgt_ranglijsttypeField = value;
				base.RaisePropertyChanged("sgt_ranglijsttype");
			}
		}
		[XmlElement(Order = 21)]
		public Lookup sgt_referentieranglijstidr
		{
			get
			{
				return this.sgt_referentieranglijstidrField;
			}
			set
			{
				this.sgt_referentieranglijstidrField = value;
				base.RaisePropertyChanged("sgt_referentieranglijstidr");
			}
		}
		[XmlElement(Order = 22)]
		public Picklist sgt_spelsoort
		{
			get
			{
				return this.sgt_spelsoortField;
			}
			set
			{
				this.sgt_spelsoortField = value;
				base.RaisePropertyChanged("sgt_spelsoort");
			}
		}
		[XmlElement(Order = 23)]
		public Lookup sgt_tennisnationaliteitid
		{
			get
			{
				return this.sgt_tennisnationaliteitidField;
			}
			set
			{
				this.sgt_tennisnationaliteitidField = value;
				base.RaisePropertyChanged("sgt_tennisnationaliteitid");
			}
		}
		[XmlElement("sgt_toe_ranglijst", Order = 24)]
		public string sgt_toe_ranglijst1
		{
			get
			{
				return this.sgt_toe_ranglijst1Field;
			}
			set
			{
				this.sgt_toe_ranglijst1Field = value;
				base.RaisePropertyChanged("sgt_toe_ranglijst1");
			}
		}
		[XmlElement(Order = 25)]
		public Key sgt_toe_ranglijstid
		{
			get
			{
				return this.sgt_toe_ranglijstidField;
			}
			set
			{
				this.sgt_toe_ranglijstidField = value;
				base.RaisePropertyChanged("sgt_toe_ranglijstid");
			}
		}
		[XmlElement(Order = 26)]
		public Lookup sgt_toernooigroepid
		{
			get
			{
				return this.sgt_toernooigroepidField;
			}
			set
			{
				this.sgt_toernooigroepidField = value;
				base.RaisePropertyChanged("sgt_toernooigroepid");
			}
		}
		[XmlElement(Order = 27)]
		public Lookup sgt_toernooisoortid
		{
			get
			{
				return this.sgt_toernooisoortidField;
			}
			set
			{
				this.sgt_toernooisoortidField = value;
				base.RaisePropertyChanged("sgt_toernooisoortid");
			}
		}
		[XmlElement(Order = 28)]
		public CrmBoolean sgt_tonen_mijnknltb
		{
			get
			{
				return this.sgt_tonen_mijnknltbField;
			}
			set
			{
				this.sgt_tonen_mijnknltbField = value;
				base.RaisePropertyChanged("sgt_tonen_mijnknltb");
			}
		}
		[XmlElement(Order = 29)]
		public Lookup sgt_type_ranglijstid
		{
			get
			{
				return this.sgt_type_ranglijstidField;
			}
			set
			{
				this.sgt_type_ranglijstidField = value;
				base.RaisePropertyChanged("sgt_type_ranglijstid");
			}
		}
		[XmlElement(Order = 30)]
		public Sgt_toe_ranglijstStateInfo statecode
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
		[XmlElement(Order = 31)]
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
		[XmlElement(Order = 32)]
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
		[XmlElement(Order = 33)]
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
