using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_alg_kenmerk : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Lookup sgt_accommodatie_idField;
		private Key sgt_alg_kenmerkidField;
		private Lookup sgt_basisorganisatie_idField;
		private Lookup sgt_flexibel_kenmerk_idField;
		private Lookup sgt_flexibel_kenmerk_type_idField;
		private string sgt_kenmerkField;
		private Lookup sgt_persoon_idField;
		private string sgt_waardeField;
		private Sgt_alg_kenmerkStateInfo statecodeField;
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
		public Lookup sgt_accommodatie_id
		{
			get
			{
				return this.sgt_accommodatie_idField;
			}
			set
			{
				this.sgt_accommodatie_idField = value;
			}
		}
		public Key sgt_alg_kenmerkid
		{
			get
			{
				return this.sgt_alg_kenmerkidField;
			}
			set
			{
				this.sgt_alg_kenmerkidField = value;
			}
		}
		public Lookup sgt_basisorganisatie_id
		{
			get
			{
				return this.sgt_basisorganisatie_idField;
			}
			set
			{
				this.sgt_basisorganisatie_idField = value;
			}
		}
		public Lookup sgt_flexibel_kenmerk_id
		{
			get
			{
				return this.sgt_flexibel_kenmerk_idField;
			}
			set
			{
				this.sgt_flexibel_kenmerk_idField = value;
			}
		}
		public Lookup sgt_flexibel_kenmerk_type_id
		{
			get
			{
				return this.sgt_flexibel_kenmerk_type_idField;
			}
			set
			{
				this.sgt_flexibel_kenmerk_type_idField = value;
			}
		}
		public string sgt_kenmerk
		{
			get
			{
				return this.sgt_kenmerkField;
			}
			set
			{
				this.sgt_kenmerkField = value;
			}
		}
		public Lookup sgt_persoon_id
		{
			get
			{
				return this.sgt_persoon_idField;
			}
			set
			{
				this.sgt_persoon_idField = value;
			}
		}
		public string sgt_waarde
		{
			get
			{
				return this.sgt_waardeField;
			}
			set
			{
				this.sgt_waardeField = value;
			}
		}
		public Sgt_alg_kenmerkStateInfo statecode
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
