using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class gi_fieldlevelsecurity : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private Picklist gi_appliestoField;
		private string gi_businessunitField;
		private string gi_businessunitnameField;
		private string gi_entityField;
		private string gi_entitycodeField;
		private string gi_entitynameField;
		private string gi_errfatalscript1Field;
		private string gi_errfatalscript2Field;
		private string gi_errfatalscript3Field;
		private string gi_errlineField;
		private string gi_errmessageField;
		private string gi_errurlField;
		private string gi_fieldbyexistingField;
		private Key gi_fieldlevelsecurityidField;
		private string gi_lblcodesettingsField;
		private string gi_lblentityinfoField;
		private string gi_lblentityscriptField;
		private string gi_lblexistingsettingsField;
		private string gi_lblfieldinfoField;
		private string gi_lblinlinetoolbarField;
		private string gi_lblothersettingsField;
		private string gi_lblsecurityinfoField;
		private string gi_lblxmlsettingsField;
		private string gi_msgalltabsField;
		private string gi_msgalltypesField;
		private string gi_msgbtnconfigField;
		private string gi_msgbtnpublishField;
		private string gi_msgbtnshowscriptField;
		private string gi_msgbtnunpublishField;
		private string gi_msgbulkcloseField;
		private string gi_msgbulkeditField;
		private string gi_msgcollapelayoutField;
		private string gi_msgdefField;
		private string gi_msgdirtyformcantpublish1Field;
		private string gi_msgdirtyformcantpublish2Field;
		private string gi_msgdisField;
		private string gi_msgdupfoundField;
		private string gi_msgenbField;
		private string gi_msgfailretrieveentityattributesField;
		private string gi_msgfailretrieveentitylistField;
		private string gi_msgfailretrieveflsformField;
		private string gi_msgfailsaveField;
		private string gi_msgfailsetpublishstateField;
		private string gi_msgfetchbufailField;
		private string gi_msgfetchdupfailField;
		private string gi_msgfetchrolefailField;
		private string gi_msgfetchuserfailField;
		private string gi_msgffailinjectscriptField;
		private string gi_msgfieldbysectionsField;
		private string gi_msgfieldplacementField;
		private string gi_msgfieldtabsField;
		private string gi_msgfilterbyField;
		private string gi_msgfldactionField;
		private string gi_msgfldnameField;
		private string gi_msgfldtypeField;
		private string gi_msghidField;
		private string gi_msginstallfailField;
		private string gi_msginstallokField;
		private string gi_msgkeeplayoutField;
		private string gi_msgloadingField;
		private string gi_msgloadingviewField;
		private string gi_msgmatchflsfailField;
		private string gi_msgmisField;
		private string gi_msgmissingentityField;
		private string gi_msgonformField;
		private string gi_msgoutformField;
		private string gi_msgpendingflsformField;
		private string gi_msgpendingform1Field;
		private string gi_msgpendingform2Field;
		private string gi_msgpendingform3Field;
		private string gi_msgpopupheadertextField;
		private string gi_msgpublishfailField;
		private string gi_msgpublishingField;
		private string gi_msgpubscripterr1Field;
		private string gi_msgpubscripterr2Field;
		private string gi_msgpubscripterr3Field;
		private string gi_msgsavingField;
		private string gi_msgscriptcopyField;
		private string gi_msgtogglepublishfailField;
		private string gi_msgundefinedField;
		private string gi_msgunpublishingField;
		private string gi_msgwaitField;
		private string gi_plhtoolbarField;
		private CrmBoolean gi_publishstateField;
		private string gi_roleField;
		private string gi_rolenameField;
		private string gi_userField;
		private string gi_usernameField;
		private string gi_xmlsettingsField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Gi_FieldLevelSecurityStateInfo statecodeField;
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
		public Picklist gi_appliesto
		{
			get
			{
				return this.gi_appliestoField;
			}
			set
			{
				this.gi_appliestoField = value;
			}
		}
		public string gi_businessunit
		{
			get
			{
				return this.gi_businessunitField;
			}
			set
			{
				this.gi_businessunitField = value;
			}
		}
		public string gi_businessunitname
		{
			get
			{
				return this.gi_businessunitnameField;
			}
			set
			{
				this.gi_businessunitnameField = value;
			}
		}
		public string gi_entity
		{
			get
			{
				return this.gi_entityField;
			}
			set
			{
				this.gi_entityField = value;
			}
		}
		public string gi_entitycode
		{
			get
			{
				return this.gi_entitycodeField;
			}
			set
			{
				this.gi_entitycodeField = value;
			}
		}
		public string gi_entityname
		{
			get
			{
				return this.gi_entitynameField;
			}
			set
			{
				this.gi_entitynameField = value;
			}
		}
		public string gi_errfatalscript1
		{
			get
			{
				return this.gi_errfatalscript1Field;
			}
			set
			{
				this.gi_errfatalscript1Field = value;
			}
		}
		public string gi_errfatalscript2
		{
			get
			{
				return this.gi_errfatalscript2Field;
			}
			set
			{
				this.gi_errfatalscript2Field = value;
			}
		}
		public string gi_errfatalscript3
		{
			get
			{
				return this.gi_errfatalscript3Field;
			}
			set
			{
				this.gi_errfatalscript3Field = value;
			}
		}
		public string gi_errline
		{
			get
			{
				return this.gi_errlineField;
			}
			set
			{
				this.gi_errlineField = value;
			}
		}
		public string gi_errmessage
		{
			get
			{
				return this.gi_errmessageField;
			}
			set
			{
				this.gi_errmessageField = value;
			}
		}
		public string gi_errurl
		{
			get
			{
				return this.gi_errurlField;
			}
			set
			{
				this.gi_errurlField = value;
			}
		}
		public string gi_fieldbyexisting
		{
			get
			{
				return this.gi_fieldbyexistingField;
			}
			set
			{
				this.gi_fieldbyexistingField = value;
			}
		}
		public Key gi_fieldlevelsecurityid
		{
			get
			{
				return this.gi_fieldlevelsecurityidField;
			}
			set
			{
				this.gi_fieldlevelsecurityidField = value;
			}
		}
		public string gi_lblcodesettings
		{
			get
			{
				return this.gi_lblcodesettingsField;
			}
			set
			{
				this.gi_lblcodesettingsField = value;
			}
		}
		public string gi_lblentityinfo
		{
			get
			{
				return this.gi_lblentityinfoField;
			}
			set
			{
				this.gi_lblentityinfoField = value;
			}
		}
		public string gi_lblentityscript
		{
			get
			{
				return this.gi_lblentityscriptField;
			}
			set
			{
				this.gi_lblentityscriptField = value;
			}
		}
		public string gi_lblexistingsettings
		{
			get
			{
				return this.gi_lblexistingsettingsField;
			}
			set
			{
				this.gi_lblexistingsettingsField = value;
			}
		}
		public string gi_lblfieldinfo
		{
			get
			{
				return this.gi_lblfieldinfoField;
			}
			set
			{
				this.gi_lblfieldinfoField = value;
			}
		}
		public string gi_lblinlinetoolbar
		{
			get
			{
				return this.gi_lblinlinetoolbarField;
			}
			set
			{
				this.gi_lblinlinetoolbarField = value;
			}
		}
		public string gi_lblothersettings
		{
			get
			{
				return this.gi_lblothersettingsField;
			}
			set
			{
				this.gi_lblothersettingsField = value;
			}
		}
		public string gi_lblsecurityinfo
		{
			get
			{
				return this.gi_lblsecurityinfoField;
			}
			set
			{
				this.gi_lblsecurityinfoField = value;
			}
		}
		public string gi_lblxmlsettings
		{
			get
			{
				return this.gi_lblxmlsettingsField;
			}
			set
			{
				this.gi_lblxmlsettingsField = value;
			}
		}
		public string gi_msgalltabs
		{
			get
			{
				return this.gi_msgalltabsField;
			}
			set
			{
				this.gi_msgalltabsField = value;
			}
		}
		public string gi_msgalltypes
		{
			get
			{
				return this.gi_msgalltypesField;
			}
			set
			{
				this.gi_msgalltypesField = value;
			}
		}
		public string gi_msgbtnconfig
		{
			get
			{
				return this.gi_msgbtnconfigField;
			}
			set
			{
				this.gi_msgbtnconfigField = value;
			}
		}
		public string gi_msgbtnpublish
		{
			get
			{
				return this.gi_msgbtnpublishField;
			}
			set
			{
				this.gi_msgbtnpublishField = value;
			}
		}
		public string gi_msgbtnshowscript
		{
			get
			{
				return this.gi_msgbtnshowscriptField;
			}
			set
			{
				this.gi_msgbtnshowscriptField = value;
			}
		}
		public string gi_msgbtnunpublish
		{
			get
			{
				return this.gi_msgbtnunpublishField;
			}
			set
			{
				this.gi_msgbtnunpublishField = value;
			}
		}
		public string gi_msgbulkclose
		{
			get
			{
				return this.gi_msgbulkcloseField;
			}
			set
			{
				this.gi_msgbulkcloseField = value;
			}
		}
		public string gi_msgbulkedit
		{
			get
			{
				return this.gi_msgbulkeditField;
			}
			set
			{
				this.gi_msgbulkeditField = value;
			}
		}
		public string gi_msgcollapelayout
		{
			get
			{
				return this.gi_msgcollapelayoutField;
			}
			set
			{
				this.gi_msgcollapelayoutField = value;
			}
		}
		public string gi_msgdef
		{
			get
			{
				return this.gi_msgdefField;
			}
			set
			{
				this.gi_msgdefField = value;
			}
		}
		public string gi_msgdirtyformcantpublish1
		{
			get
			{
				return this.gi_msgdirtyformcantpublish1Field;
			}
			set
			{
				this.gi_msgdirtyformcantpublish1Field = value;
			}
		}
		public string gi_msgdirtyformcantpublish2
		{
			get
			{
				return this.gi_msgdirtyformcantpublish2Field;
			}
			set
			{
				this.gi_msgdirtyformcantpublish2Field = value;
			}
		}
		public string gi_msgdis
		{
			get
			{
				return this.gi_msgdisField;
			}
			set
			{
				this.gi_msgdisField = value;
			}
		}
		public string gi_msgdupfound
		{
			get
			{
				return this.gi_msgdupfoundField;
			}
			set
			{
				this.gi_msgdupfoundField = value;
			}
		}
		public string gi_msgenb
		{
			get
			{
				return this.gi_msgenbField;
			}
			set
			{
				this.gi_msgenbField = value;
			}
		}
		public string gi_msgfailretrieveentityattributes
		{
			get
			{
				return this.gi_msgfailretrieveentityattributesField;
			}
			set
			{
				this.gi_msgfailretrieveentityattributesField = value;
			}
		}
		public string gi_msgfailretrieveentitylist
		{
			get
			{
				return this.gi_msgfailretrieveentitylistField;
			}
			set
			{
				this.gi_msgfailretrieveentitylistField = value;
			}
		}
		public string gi_msgfailretrieveflsform
		{
			get
			{
				return this.gi_msgfailretrieveflsformField;
			}
			set
			{
				this.gi_msgfailretrieveflsformField = value;
			}
		}
		public string gi_msgfailsave
		{
			get
			{
				return this.gi_msgfailsaveField;
			}
			set
			{
				this.gi_msgfailsaveField = value;
			}
		}
		public string gi_msgfailsetpublishstate
		{
			get
			{
				return this.gi_msgfailsetpublishstateField;
			}
			set
			{
				this.gi_msgfailsetpublishstateField = value;
			}
		}
		public string gi_msgfetchbufail
		{
			get
			{
				return this.gi_msgfetchbufailField;
			}
			set
			{
				this.gi_msgfetchbufailField = value;
			}
		}
		public string gi_msgfetchdupfail
		{
			get
			{
				return this.gi_msgfetchdupfailField;
			}
			set
			{
				this.gi_msgfetchdupfailField = value;
			}
		}
		public string gi_msgfetchrolefail
		{
			get
			{
				return this.gi_msgfetchrolefailField;
			}
			set
			{
				this.gi_msgfetchrolefailField = value;
			}
		}
		public string gi_msgfetchuserfail
		{
			get
			{
				return this.gi_msgfetchuserfailField;
			}
			set
			{
				this.gi_msgfetchuserfailField = value;
			}
		}
		public string gi_msgffailinjectscript
		{
			get
			{
				return this.gi_msgffailinjectscriptField;
			}
			set
			{
				this.gi_msgffailinjectscriptField = value;
			}
		}
		public string gi_msgfieldbysections
		{
			get
			{
				return this.gi_msgfieldbysectionsField;
			}
			set
			{
				this.gi_msgfieldbysectionsField = value;
			}
		}
		public string gi_msgfieldplacement
		{
			get
			{
				return this.gi_msgfieldplacementField;
			}
			set
			{
				this.gi_msgfieldplacementField = value;
			}
		}
		public string gi_msgfieldtabs
		{
			get
			{
				return this.gi_msgfieldtabsField;
			}
			set
			{
				this.gi_msgfieldtabsField = value;
			}
		}
		public string gi_msgfilterby
		{
			get
			{
				return this.gi_msgfilterbyField;
			}
			set
			{
				this.gi_msgfilterbyField = value;
			}
		}
		public string gi_msgfldaction
		{
			get
			{
				return this.gi_msgfldactionField;
			}
			set
			{
				this.gi_msgfldactionField = value;
			}
		}
		public string gi_msgfldname
		{
			get
			{
				return this.gi_msgfldnameField;
			}
			set
			{
				this.gi_msgfldnameField = value;
			}
		}
		public string gi_msgfldtype
		{
			get
			{
				return this.gi_msgfldtypeField;
			}
			set
			{
				this.gi_msgfldtypeField = value;
			}
		}
		public string gi_msghid
		{
			get
			{
				return this.gi_msghidField;
			}
			set
			{
				this.gi_msghidField = value;
			}
		}
		public string gi_msginstallfail
		{
			get
			{
				return this.gi_msginstallfailField;
			}
			set
			{
				this.gi_msginstallfailField = value;
			}
		}
		public string gi_msginstallok
		{
			get
			{
				return this.gi_msginstallokField;
			}
			set
			{
				this.gi_msginstallokField = value;
			}
		}
		public string gi_msgkeeplayout
		{
			get
			{
				return this.gi_msgkeeplayoutField;
			}
			set
			{
				this.gi_msgkeeplayoutField = value;
			}
		}
		public string gi_msgloading
		{
			get
			{
				return this.gi_msgloadingField;
			}
			set
			{
				this.gi_msgloadingField = value;
			}
		}
		public string gi_msgloadingview
		{
			get
			{
				return this.gi_msgloadingviewField;
			}
			set
			{
				this.gi_msgloadingviewField = value;
			}
		}
		public string gi_msgmatchflsfail
		{
			get
			{
				return this.gi_msgmatchflsfailField;
			}
			set
			{
				this.gi_msgmatchflsfailField = value;
			}
		}
		public string gi_msgmis
		{
			get
			{
				return this.gi_msgmisField;
			}
			set
			{
				this.gi_msgmisField = value;
			}
		}
		public string gi_msgmissingentity
		{
			get
			{
				return this.gi_msgmissingentityField;
			}
			set
			{
				this.gi_msgmissingentityField = value;
			}
		}
		public string gi_msgonform
		{
			get
			{
				return this.gi_msgonformField;
			}
			set
			{
				this.gi_msgonformField = value;
			}
		}
		public string gi_msgoutform
		{
			get
			{
				return this.gi_msgoutformField;
			}
			set
			{
				this.gi_msgoutformField = value;
			}
		}
		public string gi_msgpendingflsform
		{
			get
			{
				return this.gi_msgpendingflsformField;
			}
			set
			{
				this.gi_msgpendingflsformField = value;
			}
		}
		public string gi_msgpendingform1
		{
			get
			{
				return this.gi_msgpendingform1Field;
			}
			set
			{
				this.gi_msgpendingform1Field = value;
			}
		}
		public string gi_msgpendingform2
		{
			get
			{
				return this.gi_msgpendingform2Field;
			}
			set
			{
				this.gi_msgpendingform2Field = value;
			}
		}
		public string gi_msgpendingform3
		{
			get
			{
				return this.gi_msgpendingform3Field;
			}
			set
			{
				this.gi_msgpendingform3Field = value;
			}
		}
		public string gi_msgpopupheadertext
		{
			get
			{
				return this.gi_msgpopupheadertextField;
			}
			set
			{
				this.gi_msgpopupheadertextField = value;
			}
		}
		public string gi_msgpublishfail
		{
			get
			{
				return this.gi_msgpublishfailField;
			}
			set
			{
				this.gi_msgpublishfailField = value;
			}
		}
		public string gi_msgpublishing
		{
			get
			{
				return this.gi_msgpublishingField;
			}
			set
			{
				this.gi_msgpublishingField = value;
			}
		}
		public string gi_msgpubscripterr1
		{
			get
			{
				return this.gi_msgpubscripterr1Field;
			}
			set
			{
				this.gi_msgpubscripterr1Field = value;
			}
		}
		public string gi_msgpubscripterr2
		{
			get
			{
				return this.gi_msgpubscripterr2Field;
			}
			set
			{
				this.gi_msgpubscripterr2Field = value;
			}
		}
		public string gi_msgpubscripterr3
		{
			get
			{
				return this.gi_msgpubscripterr3Field;
			}
			set
			{
				this.gi_msgpubscripterr3Field = value;
			}
		}
		public string gi_msgsaving
		{
			get
			{
				return this.gi_msgsavingField;
			}
			set
			{
				this.gi_msgsavingField = value;
			}
		}
		public string gi_msgscriptcopy
		{
			get
			{
				return this.gi_msgscriptcopyField;
			}
			set
			{
				this.gi_msgscriptcopyField = value;
			}
		}
		public string gi_msgtogglepublishfail
		{
			get
			{
				return this.gi_msgtogglepublishfailField;
			}
			set
			{
				this.gi_msgtogglepublishfailField = value;
			}
		}
		public string gi_msgundefined
		{
			get
			{
				return this.gi_msgundefinedField;
			}
			set
			{
				this.gi_msgundefinedField = value;
			}
		}
		public string gi_msgunpublishing
		{
			get
			{
				return this.gi_msgunpublishingField;
			}
			set
			{
				this.gi_msgunpublishingField = value;
			}
		}
		public string gi_msgwait
		{
			get
			{
				return this.gi_msgwaitField;
			}
			set
			{
				this.gi_msgwaitField = value;
			}
		}
		public string gi_plhtoolbar
		{
			get
			{
				return this.gi_plhtoolbarField;
			}
			set
			{
				this.gi_plhtoolbarField = value;
			}
		}
		public CrmBoolean gi_publishstate
		{
			get
			{
				return this.gi_publishstateField;
			}
			set
			{
				this.gi_publishstateField = value;
			}
		}
		public string gi_role
		{
			get
			{
				return this.gi_roleField;
			}
			set
			{
				this.gi_roleField = value;
			}
		}
		public string gi_rolename
		{
			get
			{
				return this.gi_rolenameField;
			}
			set
			{
				this.gi_rolenameField = value;
			}
		}
		public string gi_user
		{
			get
			{
				return this.gi_userField;
			}
			set
			{
				this.gi_userField = value;
			}
		}
		public string gi_username
		{
			get
			{
				return this.gi_usernameField;
			}
			set
			{
				this.gi_usernameField = value;
			}
		}
		public string gi_xmlsettings
		{
			get
			{
				return this.gi_xmlsettingsField;
			}
			set
			{
				this.gi_xmlsettingsField = value;
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
		public Gi_FieldLevelSecurityStateInfo statecode
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
