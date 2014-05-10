using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_arb_behoefte_per_competitiewedstrijd : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private CrmNumber sgt_aantalField;
		private string sgt_arb_behoefte_per_competitiewedstrijd1Field;
		private Key sgt_arb_behoefte_per_competitiewedstrijdidField;
		private Lookup sgt_arbitragebehoeftecompetitieperwidField;
		private Lookup sgt_arbitragefunctieisField;
		private Lookup sgt_baansoortidField;
		private Lookup sgt_ploeg_thuisidField;
		private Lookup sgt_ploeg_uitidField;
		private CrmNumber sgt_regelementair_aantalField;
		private Picklist sgt_statusField;
		private Lookup sgt_verenigingthuisidField;
		private Lookup sgt_vereniginguitidField;
		private Lookup sgt_wedstrijdidField;
		private Sgt_arb_behoefte_per_competitiewedstrijdStateInfo statecodeField;
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
		public CrmNumber sgt_aantal
		{
			get
			{
				return this.sgt_aantalField;
			}
			set
			{
				this.sgt_aantalField = value;
			}
		}
		[XmlElement("sgt_arb_behoefte_per_competitiewedstrijd")]
		public string sgt_arb_behoefte_per_competitiewedstrijd1
		{
			get
			{
				return this.sgt_arb_behoefte_per_competitiewedstrijd1Field;
			}
			set
			{
				this.sgt_arb_behoefte_per_competitiewedstrijd1Field = value;
			}
		}
		public Key sgt_arb_behoefte_per_competitiewedstrijdid
		{
			get
			{
				return this.sgt_arb_behoefte_per_competitiewedstrijdidField;
			}
			set
			{
				this.sgt_arb_behoefte_per_competitiewedstrijdidField = value;
			}
		}
		public Lookup sgt_arbitragebehoeftecompetitieperwid
		{
			get
			{
				return this.sgt_arbitragebehoeftecompetitieperwidField;
			}
			set
			{
				this.sgt_arbitragebehoeftecompetitieperwidField = value;
			}
		}
		public Lookup sgt_arbitragefunctieis
		{
			get
			{
				return this.sgt_arbitragefunctieisField;
			}
			set
			{
				this.sgt_arbitragefunctieisField = value;
			}
		}
		public Lookup sgt_baansoortid
		{
			get
			{
				return this.sgt_baansoortidField;
			}
			set
			{
				this.sgt_baansoortidField = value;
			}
		}
		public Lookup sgt_ploeg_thuisid
		{
			get
			{
				return this.sgt_ploeg_thuisidField;
			}
			set
			{
				this.sgt_ploeg_thuisidField = value;
			}
		}
		public Lookup sgt_ploeg_uitid
		{
			get
			{
				return this.sgt_ploeg_uitidField;
			}
			set
			{
				this.sgt_ploeg_uitidField = value;
			}
		}
		public CrmNumber sgt_regelementair_aantal
		{
			get
			{
				return this.sgt_regelementair_aantalField;
			}
			set
			{
				this.sgt_regelementair_aantalField = value;
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
		public Sgt_arb_behoefte_per_competitiewedstrijdStateInfo statecode
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
