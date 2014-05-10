using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_arb_sps_formulier : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private string sgt_arb_nameField;
		private Key sgt_arb_sps_formulieridField;
		private Lookup sgt_arbitragefunctionarisidField;
		private CrmDateTime sgt_datumField;
		private string sgt_speler1_thuisField;
		private string sgt_speler1_uitField;
		private Lookup sgt_speler1idField;
		private string sgt_speler2_thuisField;
		private string sgt_speler2_uitField;
		private Lookup sgt_speler2idField;
		private Lookup sgt_spsformulieridField;
		private Lookup sgt_tegenstander1idField;
		private Lookup sgt_tegenstander2idField;
		private Sgt_arb_sps_formulierStateInfo statecodeField;
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
		public string sgt_arb_name
		{
			get
			{
				return this.sgt_arb_nameField;
			}
			set
			{
				this.sgt_arb_nameField = value;
			}
		}
		public Key sgt_arb_sps_formulierid
		{
			get
			{
				return this.sgt_arb_sps_formulieridField;
			}
			set
			{
				this.sgt_arb_sps_formulieridField = value;
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
		public CrmDateTime sgt_datum
		{
			get
			{
				return this.sgt_datumField;
			}
			set
			{
				this.sgt_datumField = value;
			}
		}
		public string sgt_speler1_thuis
		{
			get
			{
				return this.sgt_speler1_thuisField;
			}
			set
			{
				this.sgt_speler1_thuisField = value;
			}
		}
		public string sgt_speler1_uit
		{
			get
			{
				return this.sgt_speler1_uitField;
			}
			set
			{
				this.sgt_speler1_uitField = value;
			}
		}
		public Lookup sgt_speler1id
		{
			get
			{
				return this.sgt_speler1idField;
			}
			set
			{
				this.sgt_speler1idField = value;
			}
		}
		public string sgt_speler2_thuis
		{
			get
			{
				return this.sgt_speler2_thuisField;
			}
			set
			{
				this.sgt_speler2_thuisField = value;
			}
		}
		public string sgt_speler2_uit
		{
			get
			{
				return this.sgt_speler2_uitField;
			}
			set
			{
				this.sgt_speler2_uitField = value;
			}
		}
		public Lookup sgt_speler2id
		{
			get
			{
				return this.sgt_speler2idField;
			}
			set
			{
				this.sgt_speler2idField = value;
			}
		}
		public Lookup sgt_spsformulierid
		{
			get
			{
				return this.sgt_spsformulieridField;
			}
			set
			{
				this.sgt_spsformulieridField = value;
			}
		}
		public Lookup sgt_tegenstander1id
		{
			get
			{
				return this.sgt_tegenstander1idField;
			}
			set
			{
				this.sgt_tegenstander1idField = value;
			}
		}
		public Lookup sgt_tegenstander2id
		{
			get
			{
				return this.sgt_tegenstander2idField;
			}
			set
			{
				this.sgt_tegenstander2idField = value;
			}
		}
		public Sgt_arb_sps_formulierStateInfo statecode
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
