using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_com_speelschema_tegenovergesteld : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private CrmDateTime overriddencreatedonField;
		private string sgt_com_naamField;
		private Key sgt_com_speelschema_tegenovergesteldidField;
		private CrmNumber sgt_ploegField;
		private Lookup sgt_speelschema_standaardidField;
		private CrmNumber sgt_tegenovergesteld_1Field;
		private CrmNumber sgt_tegenovergesteld_2Field;
		private Sgt_com_speelschema_tegenovergesteldStateInfo statecodeField;
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
		public Lookup organizationid
		{
			get
			{
				return this.organizationidField;
			}
			set
			{
				this.organizationidField = value;
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
		public string sgt_com_naam
		{
			get
			{
				return this.sgt_com_naamField;
			}
			set
			{
				this.sgt_com_naamField = value;
			}
		}
		public Key sgt_com_speelschema_tegenovergesteldid
		{
			get
			{
				return this.sgt_com_speelschema_tegenovergesteldidField;
			}
			set
			{
				this.sgt_com_speelschema_tegenovergesteldidField = value;
			}
		}
		public CrmNumber sgt_ploeg
		{
			get
			{
				return this.sgt_ploegField;
			}
			set
			{
				this.sgt_ploegField = value;
			}
		}
		public Lookup sgt_speelschema_standaardid
		{
			get
			{
				return this.sgt_speelschema_standaardidField;
			}
			set
			{
				this.sgt_speelschema_standaardidField = value;
			}
		}
		public CrmNumber sgt_tegenovergesteld_1
		{
			get
			{
				return this.sgt_tegenovergesteld_1Field;
			}
			set
			{
				this.sgt_tegenovergesteld_1Field = value;
			}
		}
		public CrmNumber sgt_tegenovergesteld_2
		{
			get
			{
				return this.sgt_tegenovergesteld_2Field;
			}
			set
			{
				this.sgt_tegenovergesteld_2Field = value;
			}
		}
		public Sgt_com_speelschema_tegenovergesteldStateInfo statecode
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
