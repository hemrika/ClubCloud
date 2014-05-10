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
		public Lookup organizationid
		{
			get
			{
				return this.organizationidField;
			}
			set
			{
				this.organizationidField = value;
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
		public Sw_lookuplabelsStateInfo statecode
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
		public string sw_cancel
		{
			get
			{
				return this.sw_cancelField;
			}
			set
			{
				this.sw_cancelField = value;
			}
		}
		public string sw_canceltooltip
		{
			get
			{
				return this.sw_canceltooltipField;
			}
			set
			{
				this.sw_canceltooltipField = value;
			}
		}
		public string sw_dialogtitle
		{
			get
			{
				return this.sw_dialogtitleField;
			}
			set
			{
				this.sw_dialogtitleField = value;
			}
		}
		public string sw_findbuttontooltip
		{
			get
			{
				return this.sw_findbuttontooltipField;
			}
			set
			{
				this.sw_findbuttontooltipField = value;
			}
		}
		public string sw_heading
		{
			get
			{
				return this.sw_headingField;
			}
			set
			{
				this.sw_headingField = value;
			}
		}
		public CrmNumber sw_language
		{
			get
			{
				return this.sw_languageField;
			}
			set
			{
				this.sw_languageField = value;
			}
		}
		public string sw_loadfirstpage
		{
			get
			{
				return this.sw_loadfirstpageField;
			}
			set
			{
				this.sw_loadfirstpageField = value;
			}
		}
		public string sw_loadnextpage
		{
			get
			{
				return this.sw_loadnextpageField;
			}
			set
			{
				this.sw_loadnextpageField = value;
			}
		}
		public string sw_loadpreviouspage
		{
			get
			{
				return this.sw_loadpreviouspageField;
			}
			set
			{
				this.sw_loadpreviouspageField = value;
			}
		}
		public string sw_lookfor
		{
			get
			{
				return this.sw_lookforField;
			}
			set
			{
				this.sw_lookforField = value;
			}
		}
		public Key sw_lookuplabelsid
		{
			get
			{
				return this.sw_lookuplabelsidField;
			}
			set
			{
				this.sw_lookuplabelsidField = value;
			}
		}
		public string sw_name
		{
			get
			{
				return this.sw_nameField;
			}
			set
			{
				this.sw_nameField = value;
			}
		}
		public string sw_new
		{
			get
			{
				return this.sw_newField;
			}
			set
			{
				this.sw_newField = value;
			}
		}
		public string sw_newtooltip
		{
			get
			{
				return this.sw_newtooltipField;
			}
			set
			{
				this.sw_newtooltipField = value;
			}
		}
		public string sw_ok
		{
			get
			{
				return this.sw_okField;
			}
			set
			{
				this.sw_okField = value;
			}
		}
		public string sw_oktooltip
		{
			get
			{
				return this.sw_oktooltipField;
			}
			set
			{
				this.sw_oktooltipField = value;
			}
		}
		public string sw_page
		{
			get
			{
				return this.sw_pageField;
			}
			set
			{
				this.sw_pageField = value;
			}
		}
		public string sw_properties
		{
			get
			{
				return this.sw_propertiesField;
			}
			set
			{
				this.sw_propertiesField = value;
			}
		}
		public string sw_propertiestooltip
		{
			get
			{
				return this.sw_propertiestooltipField;
			}
			set
			{
				this.sw_propertiestooltipField = value;
			}
		}
		public string sw_refreshtooltip
		{
			get
			{
				return this.sw_refreshtooltipField;
			}
			set
			{
				this.sw_refreshtooltipField = value;
			}
		}
		public string sw_remove
		{
			get
			{
				return this.sw_removeField;
			}
			set
			{
				this.sw_removeField = value;
			}
		}
		public string sw_removetooltip
		{
			get
			{
				return this.sw_removetooltipField;
			}
			set
			{
				this.sw_removetooltipField = value;
			}
		}
		public string sw_rtl_of
		{
			get
			{
				return this.sw_rtl_ofField;
			}
			set
			{
				this.sw_rtl_ofField = value;
			}
		}
		public string sw_rtl_selected
		{
			get
			{
				return this.sw_rtl_selectedField;
			}
			set
			{
				this.sw_rtl_selectedField = value;
			}
		}
		public string sw_searchforrecords
		{
			get
			{
				return this.sw_searchforrecordsField;
			}
			set
			{
				this.sw_searchforrecordsField = value;
			}
		}
		public string sw_selectedrecords
		{
			get
			{
				return this.sw_selectedrecordsField;
			}
			set
			{
				this.sw_selectedrecordsField = value;
			}
		}
		public string sw_selection
		{
			get
			{
				return this.sw_selectionField;
			}
			set
			{
				this.sw_selectionField = value;
			}
		}
		public string sw_subheading
		{
			get
			{
				return this.sw_subheadingField;
			}
			set
			{
				this.sw_subheadingField = value;
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
