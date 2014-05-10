using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_dynamicformfield : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private string sgt_defaultvalueField;
		private Key sgt_dynamicformfieldidField;
		private Lookup sgt_dynamicformidField;
		private Picklist sgt_dynamischveldField;
		private Picklist sgt_kenmerk_typeField;
		private string sgt_labelField;
		private CrmNumber sgt_linkedentitynumberField;
		private string sgt_linkedrecordidField;
		private string sgt_linkedrecordnameField;
		private string sgt_linkedrecordtypeField;
		private string sgt_nameField;
		private string sgt_opzoeken_inField;
		private CrmBoolean sgt_requiredField;
		private CrmNumber sgt_sequenceField;
		private string sgt_translatekeyField;
		private CrmBoolean sgt_visibleField;
		private string sgt_volgordeField;
		private Sgt_dynamicformfieldStateInfo statecodeField;
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
		public string sgt_defaultvalue
		{
			get
			{
				return this.sgt_defaultvalueField;
			}
			set
			{
				this.sgt_defaultvalueField = value;
			}
		}
		public Key sgt_dynamicformfieldid
		{
			get
			{
				return this.sgt_dynamicformfieldidField;
			}
			set
			{
				this.sgt_dynamicformfieldidField = value;
			}
		}
		public Lookup sgt_dynamicformid
		{
			get
			{
				return this.sgt_dynamicformidField;
			}
			set
			{
				this.sgt_dynamicformidField = value;
			}
		}
		public Picklist sgt_dynamischveld
		{
			get
			{
				return this.sgt_dynamischveldField;
			}
			set
			{
				this.sgt_dynamischveldField = value;
			}
		}
		public Picklist sgt_kenmerk_type
		{
			get
			{
				return this.sgt_kenmerk_typeField;
			}
			set
			{
				this.sgt_kenmerk_typeField = value;
			}
		}
		public string sgt_label
		{
			get
			{
				return this.sgt_labelField;
			}
			set
			{
				this.sgt_labelField = value;
			}
		}
		public CrmNumber sgt_linkedentitynumber
		{
			get
			{
				return this.sgt_linkedentitynumberField;
			}
			set
			{
				this.sgt_linkedentitynumberField = value;
			}
		}
		public string sgt_linkedrecordid
		{
			get
			{
				return this.sgt_linkedrecordidField;
			}
			set
			{
				this.sgt_linkedrecordidField = value;
			}
		}
		public string sgt_linkedrecordname
		{
			get
			{
				return this.sgt_linkedrecordnameField;
			}
			set
			{
				this.sgt_linkedrecordnameField = value;
			}
		}
		public string sgt_linkedrecordtype
		{
			get
			{
				return this.sgt_linkedrecordtypeField;
			}
			set
			{
				this.sgt_linkedrecordtypeField = value;
			}
		}
		public string sgt_name
		{
			get
			{
				return this.sgt_nameField;
			}
			set
			{
				this.sgt_nameField = value;
			}
		}
		public string sgt_opzoeken_in
		{
			get
			{
				return this.sgt_opzoeken_inField;
			}
			set
			{
				this.sgt_opzoeken_inField = value;
			}
		}
		public CrmBoolean sgt_required
		{
			get
			{
				return this.sgt_requiredField;
			}
			set
			{
				this.sgt_requiredField = value;
			}
		}
		public CrmNumber sgt_sequence
		{
			get
			{
				return this.sgt_sequenceField;
			}
			set
			{
				this.sgt_sequenceField = value;
			}
		}
		public string sgt_translatekey
		{
			get
			{
				return this.sgt_translatekeyField;
			}
			set
			{
				this.sgt_translatekeyField = value;
			}
		}
		public CrmBoolean sgt_visible
		{
			get
			{
				return this.sgt_visibleField;
			}
			set
			{
				this.sgt_visibleField = value;
			}
		}
		public string sgt_volgorde
		{
			get
			{
				return this.sgt_volgordeField;
			}
			set
			{
				this.sgt_volgordeField = value;
			}
		}
		public Sgt_dynamicformfieldStateInfo statecode
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
