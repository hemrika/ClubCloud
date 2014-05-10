using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
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
		public string sgt_beschrijving
		{
			get
			{
				return this.sgt_beschrijvingField;
			}
			set
			{
				this.sgt_beschrijvingField = value;
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
		public CrmBoolean sgt_circuitpunten_voor_1ste_en_2de_jaars
		{
			get
			{
				return this.sgt_circuitpunten_voor_1ste_en_2de_jaarsField;
			}
			set
			{
				this.sgt_circuitpunten_voor_1ste_en_2de_jaarsField = value;
			}
		}
		public CrmDateTime sgt_datum_laatste_berekening
		{
			get
			{
				return this.sgt_datum_laatste_berekeningField;
			}
			set
			{
				this.sgt_datum_laatste_berekeningField = value;
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
		public Lookup sgt_herkomstcircuitid
		{
			get
			{
				return this.sgt_herkomstcircuitidField;
			}
			set
			{
				this.sgt_herkomstcircuitidField = value;
			}
		}
		public Picklist sgt_status
		{
			get
			{
				return this.sgt_statusField;
			}
			set
			{
				this.sgt_statusField = value;
			}
		}
		[XmlElement("sgt_toe_toernooicircuit")]
		public string sgt_toe_toernooicircuit1
		{
			get
			{
				return this.sgt_toe_toernooicircuit1Field;
			}
			set
			{
				this.sgt_toe_toernooicircuit1Field = value;
			}
		}
		public Key sgt_toe_toernooicircuitid
		{
			get
			{
				return this.sgt_toe_toernooicircuitidField;
			}
			set
			{
				this.sgt_toe_toernooicircuitidField = value;
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
		public Sgt_toe_toernooicircuitStateInfo statecode
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
