using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_alg_gebeurtenis_beinvloeder : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private CrmDateTime overriddencreatedonField;
		private string sgt_alg_gebeurtenis_beinvloeder1Field;
		private Key sgt_alg_gebeurtenis_beinvloederidField;
		private Lookup sgt_basisorganisatieidField;
		private Lookup sgt_beinvloederrolidField;
		private Lookup sgt_gebeurtenisidField;
		private Lookup sgt_persoonidField;
		private Sgt_alg_gebeurtenis_beinvloederStateInfo statecodeField;
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
		public Lookup organizationid
		{
			get
			{
				return this.organizationidField;
			}
			set
			{
				this.organizationidField = value;
				base.RaisePropertyChanged("organizationid");
			}
		}
		[XmlElement(Order = 6)]
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
		[XmlElement("sgt_alg_gebeurtenis_beinvloeder", Order = 7)]
		public string sgt_alg_gebeurtenis_beinvloeder1
		{
			get
			{
				return this.sgt_alg_gebeurtenis_beinvloeder1Field;
			}
			set
			{
				this.sgt_alg_gebeurtenis_beinvloeder1Field = value;
				base.RaisePropertyChanged("sgt_alg_gebeurtenis_beinvloeder1");
			}
		}
		[XmlElement(Order = 8)]
		public Key sgt_alg_gebeurtenis_beinvloederid
		{
			get
			{
				return this.sgt_alg_gebeurtenis_beinvloederidField;
			}
			set
			{
				this.sgt_alg_gebeurtenis_beinvloederidField = value;
				base.RaisePropertyChanged("sgt_alg_gebeurtenis_beinvloederid");
			}
		}
		[XmlElement(Order = 9)]
		public Lookup sgt_basisorganisatieid
		{
			get
			{
				return this.sgt_basisorganisatieidField;
			}
			set
			{
				this.sgt_basisorganisatieidField = value;
				base.RaisePropertyChanged("sgt_basisorganisatieid");
			}
		}
		[XmlElement(Order = 10)]
		public Lookup sgt_beinvloederrolid
		{
			get
			{
				return this.sgt_beinvloederrolidField;
			}
			set
			{
				this.sgt_beinvloederrolidField = value;
				base.RaisePropertyChanged("sgt_beinvloederrolid");
			}
		}
		[XmlElement(Order = 11)]
		public Lookup sgt_gebeurtenisid
		{
			get
			{
				return this.sgt_gebeurtenisidField;
			}
			set
			{
				this.sgt_gebeurtenisidField = value;
				base.RaisePropertyChanged("sgt_gebeurtenisid");
			}
		}
		[XmlElement(Order = 12)]
		public Lookup sgt_persoonid
		{
			get
			{
				return this.sgt_persoonidField;
			}
			set
			{
				this.sgt_persoonidField = value;
				base.RaisePropertyChanged("sgt_persoonid");
			}
		}
		[XmlElement(Order = 13)]
		public Sgt_alg_gebeurtenis_beinvloederStateInfo statecode
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
		[XmlElement(Order = 14)]
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
		[XmlElement(Order = 15)]
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
		[XmlElement(Order = 16)]
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
