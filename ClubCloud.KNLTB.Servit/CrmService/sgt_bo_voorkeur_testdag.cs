using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_bo_voorkeur_testdag : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private string sgt_bo_voorkeur_testdag1Field;
		private Key sgt_bo_voorkeur_testdagidField;
		private Lookup sgt_cursistidField;
		private Lookup sgt_opleidingidField;
		private Lookup sgt_testdagidField;
		private Sgt_bo_voorkeur_testdagStateInfo statecodeField;
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
		[XmlElement("sgt_bo_voorkeur_testdag")]
		public string sgt_bo_voorkeur_testdag1
		{
			get
			{
				return this.sgt_bo_voorkeur_testdag1Field;
			}
			set
			{
				this.sgt_bo_voorkeur_testdag1Field = value;
			}
		}
		public Key sgt_bo_voorkeur_testdagid
		{
			get
			{
				return this.sgt_bo_voorkeur_testdagidField;
			}
			set
			{
				this.sgt_bo_voorkeur_testdagidField = value;
			}
		}
		public Lookup sgt_cursistid
		{
			get
			{
				return this.sgt_cursistidField;
			}
			set
			{
				this.sgt_cursistidField = value;
			}
		}
		public Lookup sgt_opleidingid
		{
			get
			{
				return this.sgt_opleidingidField;
			}
			set
			{
				this.sgt_opleidingidField = value;
			}
		}
		public Lookup sgt_testdagid
		{
			get
			{
				return this.sgt_testdagidField;
			}
			set
			{
				this.sgt_testdagidField = value;
			}
		}
		public Sgt_bo_voorkeur_testdagStateInfo statecode
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