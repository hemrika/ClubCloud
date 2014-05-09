using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_toernooicircuit : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Lookup sgt_basisorganisatieidField;
		private string sgt_beschrijvingField;
		private CrmBoolean sgt_bonusfactor_niet_categorie_spelersField;
		private CrmBoolean sgt_circuitpunten_voor_1ste_en_2de_jaarsField;
		private CrmDateTime sgt_datum_laatste_berekeningField;
		private Lookup sgt_districtidField;
		private CrmBoolean sgt_handmatigField;
		private Lookup sgt_herkomstcircuitidField;
		private Picklist sgt_statusField;
		private string sgt_toe_toernooicircuit1Field;
		private Key sgt_toe_toernooicircuitidField;
		private Lookup sgt_toernooigroepidField;
		private CrmBoolean sgt_tonen_mijnknltbField;
		private Sgt_toe_toernooicircuitStateInfo statecodeField;
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
		public Lookup sgt_basisorganisatieid
		{
			get
			{
				return this.sgt_basisorganisatieidField;
			}
			set
			{
				this.sgt_basisorganisatieidField = value;
				base.RaisePropertyChanged("sgt_basisorganisatieid");
			}
		}
		[XmlElement(Order = 9)]
		public string sgt_beschrijving
		{
			get
			{
				return this.sgt_beschrijvingField;
			}
			set
			{
				this.sgt_beschrijvingField = value;
				base.RaisePropertyChanged("sgt_beschrijving");
			}
		}
		[XmlElement(Order = 10)]
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
		[XmlElement(Order = 11)]
		public CrmBoolean sgt_circuitpunten_voor_1ste_en_2de_jaars
		{
			get
			{
				return this.sgt_circuitpunten_voor_1ste_en_2de_jaarsField;
			}
			set
			{
				this.sgt_circuitpunten_voor_1ste_en_2de_jaarsField = value;
				base.RaisePropertyChanged("sgt_circuitpunten_voor_1ste_en_2de_jaars");
			}
		}
		[XmlElement(Order = 12)]
		public CrmDateTime sgt_datum_laatste_berekening
		{
			get
			{
				return this.sgt_datum_laatste_berekeningField;
			}
			set
			{
				this.sgt_datum_laatste_berekeningField = value;
				base.RaisePropertyChanged("sgt_datum_laatste_berekening");
			}
		}
		[XmlElement(Order = 13)]
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
		[XmlElement(Order = 14)]
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
		[XmlElement(Order = 15)]
		public Lookup sgt_herkomstcircuitid
		{
			get
			{
				return this.sgt_herkomstcircuitidField;
			}
			set
			{
				this.sgt_herkomstcircuitidField = value;
				base.RaisePropertyChanged("sgt_herkomstcircuitid");
			}
		}
		[XmlElement(Order = 16)]
		public Picklist sgt_status
		{
			get
			{
				return this.sgt_statusField;
			}
			set
			{
				this.sgt_statusField = value;
				base.RaisePropertyChanged("sgt_status");
			}
		}
		[XmlElement("sgt_toe_toernooicircuit", Order = 17)]
		public string sgt_toe_toernooicircuit1
		{
			get
			{
				return this.sgt_toe_toernooicircuit1Field;
			}
			set
			{
				this.sgt_toe_toernooicircuit1Field = value;
				base.RaisePropertyChanged("sgt_toe_toernooicircuit1");
			}
		}
		[XmlElement(Order = 18)]
		public Key sgt_toe_toernooicircuitid
		{
			get
			{
				return this.sgt_toe_toernooicircuitidField;
			}
			set
			{
				this.sgt_toe_toernooicircuitidField = value;
				base.RaisePropertyChanged("sgt_toe_toernooicircuitid");
			}
		}
		[XmlElement(Order = 19)]
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
		[XmlElement(Order = 20)]
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
		[XmlElement(Order = 21)]
		public Sgt_toe_toernooicircuitStateInfo statecode
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
		[XmlElement(Order = 22)]
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
		[XmlElement(Order = 23)]
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
		[XmlElement(Order = 24)]
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
