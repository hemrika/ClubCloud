using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_alg_persoonlijke_relatie : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private string sgt_alg_persoonlijke_relatie1Field;
		private Key sgt_alg_persoonlijke_relatieidField;
		private string sgt_beschrijving_1Field;
		private string sgt_beschrijving_2Field;
		private Lookup sgt_betrokkene_1idField;
		private Lookup sgt_betrokkene_2idField;
		private Lookup sgt_rol_1idField;
		private Lookup sgt_rol_2idField;
		private Sgt_alg_persoonlijke_relatieStateInfo statecodeField;
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
		[XmlElement("sgt_alg_persoonlijke_relatie")]
		public string sgt_alg_persoonlijke_relatie1
		{
			get
			{
				return this.sgt_alg_persoonlijke_relatie1Field;
			}
			set
			{
				this.sgt_alg_persoonlijke_relatie1Field = value;
			}
		}
		public Key sgt_alg_persoonlijke_relatieid
		{
			get
			{
				return this.sgt_alg_persoonlijke_relatieidField;
			}
			set
			{
				this.sgt_alg_persoonlijke_relatieidField = value;
			}
		}
		public string sgt_beschrijving_1
		{
			get
			{
				return this.sgt_beschrijving_1Field;
			}
			set
			{
				this.sgt_beschrijving_1Field = value;
			}
		}
		public string sgt_beschrijving_2
		{
			get
			{
				return this.sgt_beschrijving_2Field;
			}
			set
			{
				this.sgt_beschrijving_2Field = value;
			}
		}
		public Lookup sgt_betrokkene_1id
		{
			get
			{
				return this.sgt_betrokkene_1idField;
			}
			set
			{
				this.sgt_betrokkene_1idField = value;
			}
		}
		public Lookup sgt_betrokkene_2id
		{
			get
			{
				return this.sgt_betrokkene_2idField;
			}
			set
			{
				this.sgt_betrokkene_2idField = value;
			}
		}
		public Lookup sgt_rol_1id
		{
			get
			{
				return this.sgt_rol_1idField;
			}
			set
			{
				this.sgt_rol_1idField = value;
			}
		}
		public Lookup sgt_rol_2id
		{
			get
			{
				return this.sgt_rol_2idField;
			}
			set
			{
				this.sgt_rol_2idField = value;
			}
		}
		public Sgt_alg_persoonlijke_relatieStateInfo statecode
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
