using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("System.Xml", "4.0.30319.33440")]
	[Serializable]
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2007/WebServices")]
	public class sw_lookupcolumn : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private Lookup organizationidField;

		private CrmDateTime overriddencreatedonField;

		private Sw_lookupcolumnStateInfo statecodeField;

		private Status statuscodeField;

		private string sw_attributenameField;

		private Picklist sw_databindingField;

		private string sw_formatstringField;

		private Key sw_lookupcolumnidField;

		private Lookup sw_lookupdefinitionidField;

		private CrmNumber sw_sortindexField;

		private string sw_widthField;

		private CrmNumber timezoneruleversionnumberField;

		private CrmNumber utcconversiontimezonecodeField;

		[XmlElement] //[XmlElement(Order=0)]
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

		[XmlElement] //[XmlElement(Order=1)]
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

		[XmlElement] //[XmlElement(Order=2)]
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

		[XmlElement] //[XmlElement(Order=3)]
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

		[XmlElement] //[XmlElement(Order=4)]
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

		[XmlElement] //[XmlElement(Order=5)]
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

		[XmlElement] //[XmlElement(Order=6)]
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

		[XmlElement] //[XmlElement(Order=7)]
		public Sw_lookupcolumnStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=8)]
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

		[XmlElement] //[XmlElement(Order=9)]
		public string sw_attributename
		{
			get
			{
				return this.sw_attributenameField;
			}
			set
			{
				this.sw_attributenameField = value;
				base.RaisePropertyChanged("sw_attributename");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public Picklist sw_databinding
		{
			get
			{
				return this.sw_databindingField;
			}
			set
			{
				this.sw_databindingField = value;
				base.RaisePropertyChanged("sw_databinding");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public string sw_formatstring
		{
			get
			{
				return this.sw_formatstringField;
			}
			set
			{
				this.sw_formatstringField = value;
				base.RaisePropertyChanged("sw_formatstring");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public Key sw_lookupcolumnid
		{
			get
			{
				return this.sw_lookupcolumnidField;
			}
			set
			{
				this.sw_lookupcolumnidField = value;
				base.RaisePropertyChanged("sw_lookupcolumnid");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public Lookup sw_lookupdefinitionid
		{
			get
			{
				return this.sw_lookupdefinitionidField;
			}
			set
			{
				this.sw_lookupdefinitionidField = value;
				base.RaisePropertyChanged("sw_lookupdefinitionid");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public CrmNumber sw_sortindex
		{
			get
			{
				return this.sw_sortindexField;
			}
			set
			{
				this.sw_sortindexField = value;
				base.RaisePropertyChanged("sw_sortindex");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public string sw_width
		{
			get
			{
				return this.sw_widthField;
			}
			set
			{
				this.sw_widthField = value;
				base.RaisePropertyChanged("sw_width");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
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

		[XmlElement] //[XmlElement(Order=17)]
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

		public sw_lookupcolumn()
		{
		}
	}
}