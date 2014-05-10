using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_baansoort_toernooi : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private CrmDateTime overriddencreatedonField;
		private Lookup sgt_baansoortField;
		private Lookup sgt_dagtoernooiidField;
		private string sgt_toe_baansoort_toernooi1Field;
		private Key sgt_toe_baansoort_toernooiidField;
		private Lookup sgt_toernooiidField;
		private Lookup sgt_verwerken_toernooiaanvraagidField;
		private Sgt_toe_baansoort_toernooiStateInfo statecodeField;
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
		public Lookup sgt_baansoort
		{
			get
			{
				return this.sgt_baansoortField;
			}
			set
			{
				this.sgt_baansoortField = value;
			}
		}
		public Lookup sgt_dagtoernooiid
		{
			get
			{
				return this.sgt_dagtoernooiidField;
			}
			set
			{
				this.sgt_dagtoernooiidField = value;
			}
		}
		[XmlElement("sgt_toe_baansoort_toernooi")]
		public string sgt_toe_baansoort_toernooi1
		{
			get
			{
				return this.sgt_toe_baansoort_toernooi1Field;
			}
			set
			{
				this.sgt_toe_baansoort_toernooi1Field = value;
			}
		}
		public Key sgt_toe_baansoort_toernooiid
		{
			get
			{
				return this.sgt_toe_baansoort_toernooiidField;
			}
			set
			{
				this.sgt_toe_baansoort_toernooiidField = value;
			}
		}
		public Lookup sgt_toernooiid
		{
			get
			{
				return this.sgt_toernooiidField;
			}
			set
			{
				this.sgt_toernooiidField = value;
			}
		}
		public Lookup sgt_verwerken_toernooiaanvraagid
		{
			get
			{
				return this.sgt_verwerken_toernooiaanvraagidField;
			}
			set
			{
				this.sgt_verwerken_toernooiaanvraagidField = value;
			}
		}
		public Sgt_toe_baansoort_toernooiStateInfo statecode
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
