using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_arb_sps_straf : BusinessEntity
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
		private Key sgt_arb_sps_strafidField;
		private Lookup sgt_arbitragefunctionarisidField;
		private string sgt_bondsnummerField;
		private string sgt_bondsnummer_spelerField;
		private Picklist sgt_codeField;
		private Lookup sgt_gestraftespelersidField;
		private string sgt_naam_spelerField;
		private string sgt_omschrijvingField;
		private Lookup sgt_speleridField;
		private string sgt_standField;
		private Picklist sgt_straf_ivm_gedragField;
		private Picklist sgt_straf_ivm_tijdField;
		private Sgt_arb_sps_strafStateInfo statecodeField;
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
		public Key sgt_arb_sps_strafid
		{
			get
			{
				return this.sgt_arb_sps_strafidField;
			}
			set
			{
				this.sgt_arb_sps_strafidField = value;
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
		public string sgt_bondsnummer
		{
			get
			{
				return this.sgt_bondsnummerField;
			}
			set
			{
				this.sgt_bondsnummerField = value;
			}
		}
		public string sgt_bondsnummer_speler
		{
			get
			{
				return this.sgt_bondsnummer_spelerField;
			}
			set
			{
				this.sgt_bondsnummer_spelerField = value;
			}
		}
		public Picklist sgt_code
		{
			get
			{
				return this.sgt_codeField;
			}
			set
			{
				this.sgt_codeField = value;
			}
		}
		public Lookup sgt_gestraftespelersid
		{
			get
			{
				return this.sgt_gestraftespelersidField;
			}
			set
			{
				this.sgt_gestraftespelersidField = value;
			}
		}
		public string sgt_naam_speler
		{
			get
			{
				return this.sgt_naam_spelerField;
			}
			set
			{
				this.sgt_naam_spelerField = value;
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
		public Lookup sgt_spelerid
		{
			get
			{
				return this.sgt_speleridField;
			}
			set
			{
				this.sgt_speleridField = value;
			}
		}
		public string sgt_stand
		{
			get
			{
				return this.sgt_standField;
			}
			set
			{
				this.sgt_standField = value;
			}
		}
		public Picklist sgt_straf_ivm_gedrag
		{
			get
			{
				return this.sgt_straf_ivm_gedragField;
			}
			set
			{
				this.sgt_straf_ivm_gedragField = value;
			}
		}
		public Picklist sgt_straf_ivm_tijd
		{
			get
			{
				return this.sgt_straf_ivm_tijdField;
			}
			set
			{
				this.sgt_straf_ivm_tijdField = value;
			}
		}
		public Sgt_arb_sps_strafStateInfo statecode
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
