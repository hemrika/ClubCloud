using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_arb_beschikbaarheid_competitie : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private string sgt_arb_arbitragebeschikbaarheid_competitieField;
		private Key sgt_arb_beschikbaarheid_competitieidField;
		private Lookup sgt_arbiteridField;
		private Lookup sgt_arbitragefunctieidField;
		private Lookup sgt_comptetitieidField;
		private Lookup sgt_klassengroepidField;
		private string sgt_opmerkingField;
		private Lookup sgt_piramideidField;
		private Picklist sgt_statusField;
		private CrmDateTime sgt_wedstrijddagField;
		private Sgt_arb_beschikbaarheid_competitieStateInfo statecodeField;
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
		public string sgt_arb_arbitragebeschikbaarheid_competitie
		{
			get
			{
				return this.sgt_arb_arbitragebeschikbaarheid_competitieField;
			}
			set
			{
				this.sgt_arb_arbitragebeschikbaarheid_competitieField = value;
			}
		}
		public Key sgt_arb_beschikbaarheid_competitieid
		{
			get
			{
				return this.sgt_arb_beschikbaarheid_competitieidField;
			}
			set
			{
				this.sgt_arb_beschikbaarheid_competitieidField = value;
			}
		}
		public Lookup sgt_arbiterid
		{
			get
			{
				return this.sgt_arbiteridField;
			}
			set
			{
				this.sgt_arbiteridField = value;
			}
		}
		public Lookup sgt_arbitragefunctieid
		{
			get
			{
				return this.sgt_arbitragefunctieidField;
			}
			set
			{
				this.sgt_arbitragefunctieidField = value;
			}
		}
		public Lookup sgt_comptetitieid
		{
			get
			{
				return this.sgt_comptetitieidField;
			}
			set
			{
				this.sgt_comptetitieidField = value;
			}
		}
		public Lookup sgt_klassengroepid
		{
			get
			{
				return this.sgt_klassengroepidField;
			}
			set
			{
				this.sgt_klassengroepidField = value;
			}
		}
		public string sgt_opmerking
		{
			get
			{
				return this.sgt_opmerkingField;
			}
			set
			{
				this.sgt_opmerkingField = value;
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
		public CrmDateTime sgt_wedstrijddag
		{
			get
			{
				return this.sgt_wedstrijddagField;
			}
			set
			{
				this.sgt_wedstrijddagField = value;
			}
		}
		public Sgt_arb_beschikbaarheid_competitieStateInfo statecode
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
