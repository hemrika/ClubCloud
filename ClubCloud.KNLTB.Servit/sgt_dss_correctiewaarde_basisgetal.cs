using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_dss_correctiewaarde_basisgetal : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private CrmDecimal sgt_dames_dubbelField;
		private CrmDecimal sgt_dames_enkelField;
		private Key sgt_dss_correctiewaarde_basisgetalidField;
		private string sgt_dss_nameField;
		private CrmDecimal sgt_heren_dubbelField;
		private CrmDecimal sgt_heren_enkelField;
		private CrmNumber sgt_speelsterkteField;
		private Lookup sgt_speelsterktebepalingidField;
		private Sgt_dss_correctiewaarde_basisgetalStateInfo statecodeField;
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
		public CrmDecimal sgt_dames_dubbel
		{
			get
			{
				return this.sgt_dames_dubbelField;
			}
			set
			{
				this.sgt_dames_dubbelField = value;
				base.RaisePropertyChanged("sgt_dames_dubbel");
			}
		}
		[XmlElement(Order = 9)]
		public CrmDecimal sgt_dames_enkel
		{
			get
			{
				return this.sgt_dames_enkelField;
			}
			set
			{
				this.sgt_dames_enkelField = value;
				base.RaisePropertyChanged("sgt_dames_enkel");
			}
		}
		[XmlElement(Order = 10)]
		public Key sgt_dss_correctiewaarde_basisgetalid
		{
			get
			{
				return this.sgt_dss_correctiewaarde_basisgetalidField;
			}
			set
			{
				this.sgt_dss_correctiewaarde_basisgetalidField = value;
				base.RaisePropertyChanged("sgt_dss_correctiewaarde_basisgetalid");
			}
		}
		[XmlElement(Order = 11)]
		public string sgt_dss_name
		{
			get
			{
				return this.sgt_dss_nameField;
			}
			set
			{
				this.sgt_dss_nameField = value;
				base.RaisePropertyChanged("sgt_dss_name");
			}
		}
		[XmlElement(Order = 12)]
		public CrmDecimal sgt_heren_dubbel
		{
			get
			{
				return this.sgt_heren_dubbelField;
			}
			set
			{
				this.sgt_heren_dubbelField = value;
				base.RaisePropertyChanged("sgt_heren_dubbel");
			}
		}
		[XmlElement(Order = 13)]
		public CrmDecimal sgt_heren_enkel
		{
			get
			{
				return this.sgt_heren_enkelField;
			}
			set
			{
				this.sgt_heren_enkelField = value;
				base.RaisePropertyChanged("sgt_heren_enkel");
			}
		}
		[XmlElement(Order = 14)]
		public CrmNumber sgt_speelsterkte
		{
			get
			{
				return this.sgt_speelsterkteField;
			}
			set
			{
				this.sgt_speelsterkteField = value;
				base.RaisePropertyChanged("sgt_speelsterkte");
			}
		}
		[XmlElement(Order = 15)]
		public Lookup sgt_speelsterktebepalingid
		{
			get
			{
				return this.sgt_speelsterktebepalingidField;
			}
			set
			{
				this.sgt_speelsterktebepalingidField = value;
				base.RaisePropertyChanged("sgt_speelsterktebepalingid");
			}
		}
		[XmlElement(Order = 16)]
		public Sgt_dss_correctiewaarde_basisgetalStateInfo statecode
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
		[XmlElement(Order = 17)]
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
		[XmlElement(Order = 18)]
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
		[XmlElement(Order = 19)]
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
