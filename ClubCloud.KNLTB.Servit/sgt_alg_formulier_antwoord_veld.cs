using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_alg_formulier_antwoord_veld : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Key sgt_alg_formulier_antwoord_veldidField;
		private Lookup sgt_formulier_antwoord_idField;
		private string sgt_inhoudField;
		private string sgt_labelField;
		private string sgt_nameField;
		private CrmNumber sgt_sequenceField;
		private string sgt_volgordeField;
		private Sgt_alg_formulier_antwoord_veldStateInfo statecodeField;
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
		public Key sgt_alg_formulier_antwoord_veldid
		{
			get
			{
				return this.sgt_alg_formulier_antwoord_veldidField;
			}
			set
			{
				this.sgt_alg_formulier_antwoord_veldidField = value;
				base.RaisePropertyChanged("sgt_alg_formulier_antwoord_veldid");
			}
		}
		[XmlElement(Order = 9)]
		public Lookup sgt_formulier_antwoord_id
		{
			get
			{
				return this.sgt_formulier_antwoord_idField;
			}
			set
			{
				this.sgt_formulier_antwoord_idField = value;
				base.RaisePropertyChanged("sgt_formulier_antwoord_id");
			}
		}
		[XmlElement(Order = 10)]
		public string sgt_inhoud
		{
			get
			{
				return this.sgt_inhoudField;
			}
			set
			{
				this.sgt_inhoudField = value;
				base.RaisePropertyChanged("sgt_inhoud");
			}
		}
		[XmlElement(Order = 11)]
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
		[XmlElement(Order = 12)]
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
		[XmlElement(Order = 13)]
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
		[XmlElement(Order = 14)]
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
		[XmlElement(Order = 15)]
		public Sgt_alg_formulier_antwoord_veldStateInfo statecode
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
		[XmlElement(Order = 16)]
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
		[XmlElement(Order = 17)]
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
		[XmlElement(Order = 18)]
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
