using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_toernooi_in_interface_logboek : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Lookup sgt_dagtoernooinaam_idField;
		private Lookup sgt_logboek_idField;
		private string sgt_nameField;
		private Key sgt_toe_toernooi_in_interface_logboekidField;
		private Lookup sgt_toernooiaanvraag_verwerking_idField;
		private Lookup sgt_toernooinaam_idField;
		private Sgt_toe_toernooi_in_interface_logboekStateInfo statecodeField;
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
		public Lookup sgt_dagtoernooinaam_id
		{
			get
			{
				return this.sgt_dagtoernooinaam_idField;
			}
			set
			{
				this.sgt_dagtoernooinaam_idField = value;
				base.RaisePropertyChanged("sgt_dagtoernooinaam_id");
			}
		}
		[XmlElement(Order = 9)]
		public Lookup sgt_logboek_id
		{
			get
			{
				return this.sgt_logboek_idField;
			}
			set
			{
				this.sgt_logboek_idField = value;
				base.RaisePropertyChanged("sgt_logboek_id");
			}
		}
		[XmlElement(Order = 10)]
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
		[XmlElement(Order = 11)]
		public Key sgt_toe_toernooi_in_interface_logboekid
		{
			get
			{
				return this.sgt_toe_toernooi_in_interface_logboekidField;
			}
			set
			{
				this.sgt_toe_toernooi_in_interface_logboekidField = value;
				base.RaisePropertyChanged("sgt_toe_toernooi_in_interface_logboekid");
			}
		}
		[XmlElement(Order = 12)]
		public Lookup sgt_toernooiaanvraag_verwerking_id
		{
			get
			{
				return this.sgt_toernooiaanvraag_verwerking_idField;
			}
			set
			{
				this.sgt_toernooiaanvraag_verwerking_idField = value;
				base.RaisePropertyChanged("sgt_toernooiaanvraag_verwerking_id");
			}
		}
		[XmlElement(Order = 13)]
		public Lookup sgt_toernooinaam_id
		{
			get
			{
				return this.sgt_toernooinaam_idField;
			}
			set
			{
				this.sgt_toernooinaam_idField = value;
				base.RaisePropertyChanged("sgt_toernooinaam_id");
			}
		}
		[XmlElement(Order = 14)]
		public Sgt_toe_toernooi_in_interface_logboekStateInfo statecode
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
		[XmlElement(Order = 15)]
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
		[XmlElement(Order = 16)]
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
		[XmlElement(Order = 17)]
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
