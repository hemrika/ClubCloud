using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sw_lookuplabels : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private CrmDateTime overriddencreatedonField;
		private Sw_lookuplabelsStateInfo statecodeField;
		private Status statuscodeField;
		private string sw_cancelField;
		private string sw_canceltooltipField;
		private string sw_dialogtitleField;
		private string sw_findbuttontooltipField;
		private string sw_headingField;
		private CrmNumber sw_languageField;
		private string sw_loadfirstpageField;
		private string sw_loadnextpageField;
		private string sw_loadpreviouspageField;
		private string sw_lookforField;
		private Key sw_lookuplabelsidField;
		private string sw_nameField;
		private string sw_newField;
		private string sw_newtooltipField;
		private string sw_okField;
		private string sw_oktooltipField;
		private string sw_pageField;
		private string sw_propertiesField;
		private string sw_propertiestooltipField;
		private string sw_refreshtooltipField;
		private string sw_removeField;
		private string sw_removetooltipField;
		private string sw_rtl_ofField;
		private string sw_rtl_selectedField;
		private string sw_searchforrecordsField;
		private string sw_selectedrecordsField;
		private string sw_selectionField;
		private string sw_subheadingField;
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
		[XmlElement(Order = 7)]
		public Sw_lookuplabelsStateInfo statecode
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
		[XmlElement(Order = 8)]
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
		[XmlElement(Order = 9)]
		public string sw_cancel
		{
			get
			{
				return this.sw_cancelField;
			}
			set
			{
				this.sw_cancelField = value;
				base.RaisePropertyChanged("sw_cancel");
			}
		}
		[XmlElement(Order = 10)]
		public string sw_canceltooltip
		{
			get
			{
				return this.sw_canceltooltipField;
			}
			set
			{
				this.sw_canceltooltipField = value;
				base.RaisePropertyChanged("sw_canceltooltip");
			}
		}
		[XmlElement(Order = 11)]
		public string sw_dialogtitle
		{
			get
			{
				return this.sw_dialogtitleField;
			}
			set
			{
				this.sw_dialogtitleField = value;
				base.RaisePropertyChanged("sw_dialogtitle");
			}
		}
		[XmlElement(Order = 12)]
		public string sw_findbuttontooltip
		{
			get
			{
				return this.sw_findbuttontooltipField;
			}
			set
			{
				this.sw_findbuttontooltipField = value;
				base.RaisePropertyChanged("sw_findbuttontooltip");
			}
		}
		[XmlElement(Order = 13)]
		public string sw_heading
		{
			get
			{
				return this.sw_headingField;
			}
			set
			{
				this.sw_headingField = value;
				base.RaisePropertyChanged("sw_heading");
			}
		}
		[XmlElement(Order = 14)]
		public CrmNumber sw_language
		{
			get
			{
				return this.sw_languageField;
			}
			set
			{
				this.sw_languageField = value;
				base.RaisePropertyChanged("sw_language");
			}
		}
		[XmlElement(Order = 15)]
		public string sw_loadfirstpage
		{
			get
			{
				return this.sw_loadfirstpageField;
			}
			set
			{
				this.sw_loadfirstpageField = value;
				base.RaisePropertyChanged("sw_loadfirstpage");
			}
		}
		[XmlElement(Order = 16)]
		public string sw_loadnextpage
		{
			get
			{
				return this.sw_loadnextpageField;
			}
			set
			{
				this.sw_loadnextpageField = value;
				base.RaisePropertyChanged("sw_loadnextpage");
			}
		}
		[XmlElement(Order = 17)]
		public string sw_loadpreviouspage
		{
			get
			{
				return this.sw_loadpreviouspageField;
			}
			set
			{
				this.sw_loadpreviouspageField = value;
				base.RaisePropertyChanged("sw_loadpreviouspage");
			}
		}
		[XmlElement(Order = 18)]
		public string sw_lookfor
		{
			get
			{
				return this.sw_lookforField;
			}
			set
			{
				this.sw_lookforField = value;
				base.RaisePropertyChanged("sw_lookfor");
			}
		}
		[XmlElement(Order = 19)]
		public Key sw_lookuplabelsid
		{
			get
			{
				return this.sw_lookuplabelsidField;
			}
			set
			{
				this.sw_lookuplabelsidField = value;
				base.RaisePropertyChanged("sw_lookuplabelsid");
			}
		}
		[XmlElement(Order = 20)]
		public string sw_name
		{
			get
			{
				return this.sw_nameField;
			}
			set
			{
				this.sw_nameField = value;
				base.RaisePropertyChanged("sw_name");
			}
		}
		[XmlElement(Order = 21)]
		public string sw_new
		{
			get
			{
				return this.sw_newField;
			}
			set
			{
				this.sw_newField = value;
				base.RaisePropertyChanged("sw_new");
			}
		}
		[XmlElement(Order = 22)]
		public string sw_newtooltip
		{
			get
			{
				return this.sw_newtooltipField;
			}
			set
			{
				this.sw_newtooltipField = value;
				base.RaisePropertyChanged("sw_newtooltip");
			}
		}
		[XmlElement(Order = 23)]
		public string sw_ok
		{
			get
			{
				return this.sw_okField;
			}
			set
			{
				this.sw_okField = value;
				base.RaisePropertyChanged("sw_ok");
			}
		}
		[XmlElement(Order = 24)]
		public string sw_oktooltip
		{
			get
			{
				return this.sw_oktooltipField;
			}
			set
			{
				this.sw_oktooltipField = value;
				base.RaisePropertyChanged("sw_oktooltip");
			}
		}
		[XmlElement(Order = 25)]
		public string sw_page
		{
			get
			{
				return this.sw_pageField;
			}
			set
			{
				this.sw_pageField = value;
				base.RaisePropertyChanged("sw_page");
			}
		}
		[XmlElement(Order = 26)]
		public string sw_properties
		{
			get
			{
				return this.sw_propertiesField;
			}
			set
			{
				this.sw_propertiesField = value;
				base.RaisePropertyChanged("sw_properties");
			}
		}
		[XmlElement(Order = 27)]
		public string sw_propertiestooltip
		{
			get
			{
				return this.sw_propertiestooltipField;
			}
			set
			{
				this.sw_propertiestooltipField = value;
				base.RaisePropertyChanged("sw_propertiestooltip");
			}
		}
		[XmlElement(Order = 28)]
		public string sw_refreshtooltip
		{
			get
			{
				return this.sw_refreshtooltipField;
			}
			set
			{
				this.sw_refreshtooltipField = value;
				base.RaisePropertyChanged("sw_refreshtooltip");
			}
		}
		[XmlElement(Order = 29)]
		public string sw_remove
		{
			get
			{
				return this.sw_removeField;
			}
			set
			{
				this.sw_removeField = value;
				base.RaisePropertyChanged("sw_remove");
			}
		}
		[XmlElement(Order = 30)]
		public string sw_removetooltip
		{
			get
			{
				return this.sw_removetooltipField;
			}
			set
			{
				this.sw_removetooltipField = value;
				base.RaisePropertyChanged("sw_removetooltip");
			}
		}
		[XmlElement(Order = 31)]
		public string sw_rtl_of
		{
			get
			{
				return this.sw_rtl_ofField;
			}
			set
			{
				this.sw_rtl_ofField = value;
				base.RaisePropertyChanged("sw_rtl_of");
			}
		}
		[XmlElement(Order = 32)]
		public string sw_rtl_selected
		{
			get
			{
				return this.sw_rtl_selectedField;
			}
			set
			{
				this.sw_rtl_selectedField = value;
				base.RaisePropertyChanged("sw_rtl_selected");
			}
		}
		[XmlElement(Order = 33)]
		public string sw_searchforrecords
		{
			get
			{
				return this.sw_searchforrecordsField;
			}
			set
			{
				this.sw_searchforrecordsField = value;
				base.RaisePropertyChanged("sw_searchforrecords");
			}
		}
		[XmlElement(Order = 34)]
		public string sw_selectedrecords
		{
			get
			{
				return this.sw_selectedrecordsField;
			}
			set
			{
				this.sw_selectedrecordsField = value;
				base.RaisePropertyChanged("sw_selectedrecords");
			}
		}
		[XmlElement(Order = 35)]
		public string sw_selection
		{
			get
			{
				return this.sw_selectionField;
			}
			set
			{
				this.sw_selectionField = value;
				base.RaisePropertyChanged("sw_selection");
			}
		}
		[XmlElement(Order = 36)]
		public string sw_subheading
		{
			get
			{
				return this.sw_subheadingField;
			}
			set
			{
				this.sw_subheadingField = value;
				base.RaisePropertyChanged("sw_subheading");
			}
		}
		[XmlElement(Order = 37)]
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
		[XmlElement(Order = 38)]
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
