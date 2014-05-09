using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
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
		[XmlElement(Order = 0)]
		public Lookup createdby
		{
			get
			{
				return this.createdbyField;
			}
			set
			{
				this.createdbyField = value;
				base.RaisePropertyChanged("createdby");
			}
		}
		[XmlElement(Order = 1)]
		public CrmDateTime createdon
		{
			get
			{
				return this.createdonField;
			}
			set
			{
				this.createdonField = value;
				base.RaisePropertyChanged("createdon");
			}
		}
		[XmlElement(Order = 2)]
		public CrmNumber importsequencenumber
		{
			get
			{
				return this.importsequencenumberField;
			}
			set
			{
				this.importsequencenumberField = value;
				base.RaisePropertyChanged("importsequencenumber");
			}
		}
		[XmlElement(Order = 3)]
		public Lookup modifiedby
		{
			get
			{
				return this.modifiedbyField;
			}
			set
			{
				this.modifiedbyField = value;
				base.RaisePropertyChanged("modifiedby");
			}
		}
		[XmlElement(Order = 4)]
		public CrmDateTime modifiedon
		{
			get
			{
				return this.modifiedonField;
			}
			set
			{
				this.modifiedonField = value;
				base.RaisePropertyChanged("modifiedon");
			}
		}
		[XmlElement(Order = 5)]
		public CrmDateTime overriddencreatedon
		{
			get
			{
				return this.overriddencreatedonField;
			}
			set
			{
				this.overriddencreatedonField = value;
				base.RaisePropertyChanged("overriddencreatedon");
			}
		}
		[XmlElement(Order = 6)]
		public Owner ownerid
		{
			get
			{
				return this.owneridField;
			}
			set
			{
				this.owneridField = value;
				base.RaisePropertyChanged("ownerid");
			}
		}
		[XmlElement(Order = 7)]
		public Lookup owningbusinessunit
		{
			get
			{
				return this.owningbusinessunitField;
			}
			set
			{
				this.owningbusinessunitField = value;
				base.RaisePropertyChanged("owningbusinessunit");
			}
		}
		[XmlElement(Order = 8)]
		public string sgt_defaultvalue
		{
			get
			{
				return this.sgt_defaultvalueField;
			}
			set
			{
				this.sgt_defaultvalueField = value;
				base.RaisePropertyChanged("sgt_defaultvalue");
			}
		}
		[XmlElement(Order = 9)]
		public Key sgt_dynamicformfieldid
		{
			get
			{
				return this.sgt_dynamicformfieldidField;
			}
			set
			{
				this.sgt_dynamicformfieldidField = value;
				base.RaisePropertyChanged("sgt_dynamicformfieldid");
			}
		}
		[XmlElement(Order = 10)]
		public Lookup sgt_dynamicformid
		{
			get
			{
				return this.sgt_dynamicformidField;
			}
			set
			{
				this.sgt_dynamicformidField = value;
				base.RaisePropertyChanged("sgt_dynamicformid");
			}
		}
		[XmlElement(Order = 11)]
		public Picklist sgt_dynamischveld
		{
			get
			{
				return this.sgt_dynamischveldField;
			}
			set
			{
				this.sgt_dynamischveldField = value;
				base.RaisePropertyChanged("sgt_dynamischveld");
			}
		}
		[XmlElement(Order = 12)]
		public Picklist sgt_kenmerk_type
		{
			get
			{
				return this.sgt_kenmerk_typeField;
			}
			set
			{
				this.sgt_kenmerk_typeField = value;
				base.RaisePropertyChanged("sgt_kenmerk_type");
			}
		}
		[XmlElement(Order = 13)]
		public string sgt_label
		{
			get
			{
				return this.sgt_labelField;
			}
			set
			{
				this.sgt_labelField = value;
				base.RaisePropertyChanged("sgt_label");
			}
		}
		[XmlElement(Order = 14)]
		public CrmNumber sgt_linkedentitynumber
		{
			get
			{
				return this.sgt_linkedentitynumberField;
			}
			set
			{
				this.sgt_linkedentitynumberField = value;
				base.RaisePropertyChanged("sgt_linkedentitynumber");
			}
		}
		[XmlElement(Order = 15)]
		public string sgt_linkedrecordid
		{
			get
			{
				return this.sgt_linkedrecordidField;
			}
			set
			{
				this.sgt_linkedrecordidField = value;
				base.RaisePropertyChanged("sgt_linkedrecordid");
			}
		}
		[XmlElement(Order = 16)]
		public string sgt_linkedrecordname
		{
			get
			{
				return this.sgt_linkedrecordnameField;
			}
			set
			{
				this.sgt_linkedrecordnameField = value;
				base.RaisePropertyChanged("sgt_linkedrecordname");
			}
		}
		[XmlElement(Order = 17)]
		public string sgt_linkedrecordtype
		{
			get
			{
				return this.sgt_linkedrecordtypeField;
			}
			set
			{
				this.sgt_linkedrecordtypeField = value;
				base.RaisePropertyChanged("sgt_linkedrecordtype");
			}
		}
		[XmlElement(Order = 18)]
		public string sgt_name
		{
			get
			{
				return this.sgt_nameField;
			}
			set
			{
				this.sgt_nameField = value;
				base.RaisePropertyChanged("sgt_name");
			}
		}
		[XmlElement(Order = 19)]
		public string sgt_opzoeken_in
		{
			get
			{
				return this.sgt_opzoeken_inField;
			}
			set
			{
				this.sgt_opzoeken_inField = value;
				base.RaisePropertyChanged("sgt_opzoeken_in");
			}
		}
		[XmlElement(Order = 20)]
		public CrmBoolean sgt_required
		{
			get
			{
				return this.sgt_requiredField;
			}
			set
			{
				this.sgt_requiredField = value;
				base.RaisePropertyChanged("sgt_required");
			}
		}
		[XmlElement(Order = 21)]
		public CrmNumber sgt_sequence
		{
			get
			{
				return this.sgt_sequenceField;
			}
			set
			{
				this.sgt_sequenceField = value;
				base.RaisePropertyChanged("sgt_sequence");
			}
		}
		[XmlElement(Order = 22)]
		public string sgt_translatekey
		{
			get
			{
				return this.sgt_translatekeyField;
			}
			set
			{
				this.sgt_translatekeyField = value;
				base.RaisePropertyChanged("sgt_translatekey");
			}
		}
		[XmlElement(Order = 23)]
		public CrmBoolean sgt_visible
		{
			get
			{
				return this.sgt_visibleField;
			}
			set
			{
				this.sgt_visibleField = value;
				base.RaisePropertyChanged("sgt_visible");
			}
		}
		[XmlElement(Order = 24)]
		public string sgt_volgorde
		{
			get
			{
				return this.sgt_volgordeField;
			}
			set
			{
				this.sgt_volgordeField = value;
				base.RaisePropertyChanged("sgt_volgorde");
			}
		}
		[XmlElement(Order = 25)]
		public Sgt_dynamicformfieldStateInfo statecode
		{
			get
			{
				return this.statecodeField;
			}
			set
			{
				this.statecodeField = value;
				base.RaisePropertyChanged("statecode");
			}
		}
		[XmlElement(Order = 26)]
		public Status statuscode
		{
			get
			{
				return this.statuscodeField;
			}
			set
			{
				this.statuscodeField = value;
				base.RaisePropertyChanged("statuscode");
			}
		}
		[XmlElement(Order = 27)]
		public CrmNumber timezoneruleversionnumber
		{
			get
			{
				return this.timezoneruleversionnumberField;
			}
			set
			{
				this.timezoneruleversionnumberField = value;
				base.RaisePropertyChanged("timezoneruleversionnumber");
			}
		}
		[XmlElement(Order = 28)]
		public CrmNumber utcconversiontimezonecode
		{
			get
			{
				return this.utcconversiontimezonecodeField;
			}
			set
			{
				this.utcconversiontimezonecodeField = value;
				base.RaisePropertyChanged("utcconversiontimezonecode");
			}
		}
	}
}
