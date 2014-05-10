using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_arb_arbitrage_inzet_competitie : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Lookup sgt_afdelingidField;
		private string sgt_arb_arbitrage_inzet_competitie1Field;
		private Key sgt_arb_arbitrage_inzet_competitieidField;
		private Lookup sgt_arbitragefunctionarisidField;
		private Lookup sgt_competitieidField;
		private Lookup sgt_functieidField;
		private Picklist sgt_inzet_statusField;
		private Lookup sgt_klassegroepidField;
		private Lookup sgt_piramideidField;
		private Lookup sgt_ploegthuisidField;
		private Lookup sgt_ploeguitidField;
		private CrmDateTime sgt_speeldag_datumField;
		private Lookup sgt_verenigingthuisidField;
		private Lookup sgt_vereniginguitidField;
		private Lookup sgt_wedstrijdidField;
		private Sgt_arb_arbitrage_inzet_competitieStateInfo statecodeField;
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
		public Lookup sgt_afdelingid
		{
			get
			{
				return this.sgt_afdelingidField;
			}
			set
			{
				this.sgt_afdelingidField = value;
			}
		}
		[XmlElement("sgt_arb_arbitrage_inzet_competitie")]
		public string sgt_arb_arbitrage_inzet_competitie1
		{
			get
			{
				return this.sgt_arb_arbitrage_inzet_competitie1Field;
			}
			set
			{
				this.sgt_arb_arbitrage_inzet_competitie1Field = value;
			}
		}
		public Key sgt_arb_arbitrage_inzet_competitieid
		{
			get
			{
				return this.sgt_arb_arbitrage_inzet_competitieidField;
			}
			set
			{
				this.sgt_arb_arbitrage_inzet_competitieidField = value;
			}
		}
		public Lookup sgt_arbitragefunctionarisid
		{
			get
			{
				return this.sgt_arbitragefunctionarisidField;
			}
			set
			{
				this.sgt_arbitragefunctionarisidField = value;
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
		public Picklist sgt_inzet_status
		{
			get
			{
				return this.sgt_inzet_statusField;
			}
			set
			{
				this.sgt_inzet_statusField = value;
			}
		}
		public Lookup sgt_klassegroepid
		{
			get
			{
				return this.sgt_klassegroepidField;
			}
			set
			{
				this.sgt_klassegroepidField = value;
			}
		}
		public Lookup sgt_piramideid
		{
			get
			{
				return this.sgt_piramideidField;
			}
			set
			{
				this.sgt_piramideidField = value;
			}
		}
		public Lookup sgt_ploegthuisid
		{
			get
			{
				return this.sgt_ploegthuisidField;
			}
			set
			{
				this.sgt_ploegthuisidField = value;
			}
		}
		public Lookup sgt_ploeguitid
		{
			get
			{
				return this.sgt_ploeguitidField;
			}
			set
			{
				this.sgt_ploeguitidField = value;
			}
		}
		public CrmDateTime sgt_speeldag_datum
		{
			get
			{
				return this.sgt_speeldag_datumField;
			}
			set
			{
				this.sgt_speeldag_datumField = value;
			}
		}
		public Lookup sgt_verenigingthuisid
		{
			get
			{
				return this.sgt_verenigingthuisidField;
			}
			set
			{
				this.sgt_verenigingthuisidField = value;
			}
		}
		public Lookup sgt_vereniginguitid
		{
			get
			{
				return this.sgt_vereniginguitidField;
			}
			set
			{
				this.sgt_vereniginguitidField = value;
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
		public Sgt_arb_arbitrage_inzet_competitieStateInfo statecode
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
