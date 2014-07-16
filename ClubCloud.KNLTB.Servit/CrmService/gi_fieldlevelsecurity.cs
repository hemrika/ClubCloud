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
		public Picklist gi_appliesto
		{
			get
			{
				return this.gi_appliestoField;
			}
			set
			{
				this.gi_appliestoField = value;
				base.RaisePropertyChanged("gi_appliesto");
			}
		}

		[XmlElement] //[XmlElement(Order=3)]
		public string gi_businessunit
		{
			get
			{
				return this.gi_businessunitField;
			}
			set
			{
				this.gi_businessunitField = value;
				base.RaisePropertyChanged("gi_businessunit");
			}
		}

		[XmlElement] //[XmlElement(Order=4)]
		public string gi_businessunitname
		{
			get
			{
				return this.gi_businessunitnameField;
			}
			set
			{
				this.gi_businessunitnameField = value;
				base.RaisePropertyChanged("gi_businessunitname");
			}
		}

		[XmlElement] //[XmlElement(Order=5)]
		public string gi_entity
		{
			get
			{
				return this.gi_entityField;
			}
			set
			{
				this.gi_entityField = value;
				base.RaisePropertyChanged("gi_entity");
			}
		}

		[XmlElement] //[XmlElement(Order=6)]
		public string gi_entitycode
		{
			get
			{
				return this.gi_entitycodeField;
			}
			set
			{
				this.gi_entitycodeField = value;
				base.RaisePropertyChanged("gi_entitycode");
			}
		}

		[XmlElement] //[XmlElement(Order=7)]
		public string gi_entityname
		{
			get
			{
				return this.gi_entitynameField;
			}
			set
			{
				this.gi_entitynameField = value;
				base.RaisePropertyChanged("gi_entityname");
			}
		}

		[XmlElement] //[XmlElement(Order=8)]
		public string gi_errfatalscript1
		{
			get
			{
				return this.gi_errfatalscript1Field;
			}
			set
			{
				this.gi_errfatalscript1Field = value;
				base.RaisePropertyChanged("gi_errfatalscript1");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public string gi_errfatalscript2
		{
			get
			{
				return this.gi_errfatalscript2Field;
			}
			set
			{
				this.gi_errfatalscript2Field = value;
				base.RaisePropertyChanged("gi_errfatalscript2");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public string gi_errfatalscript3
		{
			get
			{
				return this.gi_errfatalscript3Field;
			}
			set
			{
				this.gi_errfatalscript3Field = value;
				base.RaisePropertyChanged("gi_errfatalscript3");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public string gi_errline
		{
			get
			{
				return this.gi_errlineField;
			}
			set
			{
				this.gi_errlineField = value;
				base.RaisePropertyChanged("gi_errline");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public string gi_errmessage
		{
			get
			{
				return this.gi_errmessageField;
			}
			set
			{
				this.gi_errmessageField = value;
				base.RaisePropertyChanged("gi_errmessage");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public string gi_errurl
		{
			get
			{
				return this.gi_errurlField;
			}
			set
			{
				this.gi_errurlField = value;
				base.RaisePropertyChanged("gi_errurl");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public string gi_fieldbyexisting
		{
			get
			{
				return this.gi_fieldbyexistingField;
			}
			set
			{
				this.gi_fieldbyexistingField = value;
				base.RaisePropertyChanged("gi_fieldbyexisting");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public Key gi_fieldlevelsecurityid
		{
			get
			{
				return this.gi_fieldlevelsecurityidField;
			}
			set
			{
				this.gi_fieldlevelsecurityidField = value;
				base.RaisePropertyChanged("gi_fieldlevelsecurityid");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public string gi_lblcodesettings
		{
			get
			{
				return this.gi_lblcodesettingsField;
			}
			set
			{
				this.gi_lblcodesettingsField = value;
				base.RaisePropertyChanged("gi_lblcodesettings");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public string gi_lblentityinfo
		{
			get
			{
				return this.gi_lblentityinfoField;
			}
			set
			{
				this.gi_lblentityinfoField = value;
				base.RaisePropertyChanged("gi_lblentityinfo");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public string gi_lblentityscript
		{
			get
			{
				return this.gi_lblentityscriptField;
			}
			set
			{
				this.gi_lblentityscriptField = value;
				base.RaisePropertyChanged("gi_lblentityscript");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public string gi_lblexistingsettings
		{
			get
			{
				return this.gi_lblexistingsettingsField;
			}
			set
			{
				this.gi_lblexistingsettingsField = value;
				base.RaisePropertyChanged("gi_lblexistingsettings");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public string gi_lblfieldinfo
		{
			get
			{
				return this.gi_lblfieldinfoField;
			}
			set
			{
				this.gi_lblfieldinfoField = value;
				base.RaisePropertyChanged("gi_lblfieldinfo");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public string gi_lblinlinetoolbar
		{
			get
			{
				return this.gi_lblinlinetoolbarField;
			}
			set
			{
				this.gi_lblinlinetoolbarField = value;
				base.RaisePropertyChanged("gi_lblinlinetoolbar");
			}
		}

		[XmlElement] //[XmlElement(Order=22)]
		public string gi_lblothersettings
		{
			get
			{
				return this.gi_lblothersettingsField;
			}
			set
			{
				this.gi_lblothersettingsField = value;
				base.RaisePropertyChanged("gi_lblothersettings");
			}
		}

		[XmlElement] //[XmlElement(Order=23)]
		public string gi_lblsecurityinfo
		{
			get
			{
				return this.gi_lblsecurityinfoField;
			}
			set
			{
				this.gi_lblsecurityinfoField = value;
				base.RaisePropertyChanged("gi_lblsecurityinfo");
			}
		}

		[XmlElement] //[XmlElement(Order=24)]
		public string gi_lblxmlsettings
		{
			get
			{
				return this.gi_lblxmlsettingsField;
			}
			set
			{
				this.gi_lblxmlsettingsField = value;
				base.RaisePropertyChanged("gi_lblxmlsettings");
			}
		}

		[XmlElement] //[XmlElement(Order=25)]
		public string gi_msgalltabs
		{
			get
			{
				return this.gi_msgalltabsField;
			}
			set
			{
				this.gi_msgalltabsField = value;
				base.RaisePropertyChanged("gi_msgalltabs");
			}
		}

		[XmlElement] //[XmlElement(Order=26)]
		public string gi_msgalltypes
		{
			get
			{
				return this.gi_msgalltypesField;
			}
			set
			{
				this.gi_msgalltypesField = value;
				base.RaisePropertyChanged("gi_msgalltypes");
			}
		}

		[XmlElement] //[XmlElement(Order=27)]
		public string gi_msgbtnconfig
		{
			get
			{
				return this.gi_msgbtnconfigField;
			}
			set
			{
				this.gi_msgbtnconfigField = value;
				base.RaisePropertyChanged("gi_msgbtnconfig");
			}
		}

		[XmlElement] //[XmlElement(Order=28)]
		public string gi_msgbtnpublish
		{
			get
			{
				return this.gi_msgbtnpublishField;
			}
			set
			{
				this.gi_msgbtnpublishField = value;
				base.RaisePropertyChanged("gi_msgbtnpublish");
			}
		}

		[XmlElement] //[XmlElement(Order=29)]
		public string gi_msgbtnshowscript
		{
			get
			{
				return this.gi_msgbtnshowscriptField;
			}
			set
			{
				this.gi_msgbtnshowscriptField = value;
				base.RaisePropertyChanged("gi_msgbtnshowscript");
			}
		}

		[XmlElement] //[XmlElement(Order=30)]
		public string gi_msgbtnunpublish
		{
			get
			{
				return this.gi_msgbtnunpublishField;
			}
			set
			{
				this.gi_msgbtnunpublishField = value;
				base.RaisePropertyChanged("gi_msgbtnunpublish");
			}
		}

		[XmlElement] //[XmlElement(Order=31)]
		public string gi_msgbulkclose
		{
			get
			{
				return this.gi_msgbulkcloseField;
			}
			set
			{
				this.gi_msgbulkcloseField = value;
				base.RaisePropertyChanged("gi_msgbulkclose");
			}
		}

		[XmlElement] //[XmlElement(Order=32)]
		public string gi_msgbulkedit
		{
			get
			{
				return this.gi_msgbulkeditField;
			}
			set
			{
				this.gi_msgbulkeditField = value;
				base.RaisePropertyChanged("gi_msgbulkedit");
			}
		}

		[XmlElement] //[XmlElement(Order=33)]
		public string gi_msgcollapelayout
		{
			get
			{
				return this.gi_msgcollapelayoutField;
			}
			set
			{
				this.gi_msgcollapelayoutField = value;
				base.RaisePropertyChanged("gi_msgcollapelayout");
			}
		}

		[XmlElement] //[XmlElement(Order=34)]
		public string gi_msgdef
		{
			get
			{
				return this.gi_msgdefField;
			}
			set
			{
				this.gi_msgdefField = value;
				base.RaisePropertyChanged("gi_msgdef");
			}
		}

		[XmlElement] //[XmlElement(Order=35)]
		public string gi_msgdirtyformcantpublish1
		{
			get
			{
				return this.gi_msgdirtyformcantpublish1Field;
			}
			set
			{
				this.gi_msgdirtyformcantpublish1Field = value;
				base.RaisePropertyChanged("gi_msgdirtyformcantpublish1");
			}
		}

		[XmlElement] //[XmlElement(Order=36)]
		public string gi_msgdirtyformcantpublish2
		{
			get
			{
				return this.gi_msgdirtyformcantpublish2Field;
			}
			set
			{
				this.gi_msgdirtyformcantpublish2Field = value;
				base.RaisePropertyChanged("gi_msgdirtyformcantpublish2");
			}
		}

		[XmlElement] //[XmlElement(Order=37)]
		public string gi_msgdis
		{
			get
			{
				return this.gi_msgdisField;
			}
			set
			{
				this.gi_msgdisField = value;
				base.RaisePropertyChanged("gi_msgdis");
			}
		}

		[XmlElement] //[XmlElement(Order=38)]
		public string gi_msgdupfound
		{
			get
			{
				return this.gi_msgdupfoundField;
			}
			set
			{
				this.gi_msgdupfoundField = value;
				base.RaisePropertyChanged("gi_msgdupfound");
			}
		}

		[XmlElement] //[XmlElement(Order=39)]
		public string gi_msgenb
		{
			get
			{
				return this.gi_msgenbField;
			}
			set
			{
				this.gi_msgenbField = value;
				base.RaisePropertyChanged("gi_msgenb");
			}
		}

		[XmlElement] //[XmlElement(Order=40)]
		public string gi_msgfailretrieveentityattributes
		{
			get
			{
				return this.gi_msgfailretrieveentityattributesField;
			}
			set
			{
				this.gi_msgfailretrieveentityattributesField = value;
				base.RaisePropertyChanged("gi_msgfailretrieveentityattributes");
			}
		}

		[XmlElement] //[XmlElement(Order=41)]
		public string gi_msgfailretrieveentitylist
		{
			get
			{
				return this.gi_msgfailretrieveentitylistField;
			}
			set
			{
				this.gi_msgfailretrieveentitylistField = value;
				base.RaisePropertyChanged("gi_msgfailretrieveentitylist");
			}
		}

		[XmlElement] //[XmlElement(Order=42)]
		public string gi_msgfailretrieveflsform
		{
			get
			{
				return this.gi_msgfailretrieveflsformField;
			}
			set
			{
				this.gi_msgfailretrieveflsformField = value;
				base.RaisePropertyChanged("gi_msgfailretrieveflsform");
			}
		}

		[XmlElement] //[XmlElement(Order=43)]
		public string gi_msgfailsave
		{
			get
			{
				return this.gi_msgfailsaveField;
			}
			set
			{
				this.gi_msgfailsaveField = value;
				base.RaisePropertyChanged("gi_msgfailsave");
			}
		}

		[XmlElement] //[XmlElement(Order=44)]
		public string gi_msgfailsetpublishstate
		{
			get
			{
				return this.gi_msgfailsetpublishstateField;
			}
			set
			{
				this.gi_msgfailsetpublishstateField = value;
				base.RaisePropertyChanged("gi_msgfailsetpublishstate");
			}
		}

		[XmlElement] //[XmlElement(Order=45)]
		public string gi_msgfetchbufail
		{
			get
			{
				return this.gi_msgfetchbufailField;
			}
			set
			{
				this.gi_msgfetchbufailField = value;
				base.RaisePropertyChanged("gi_msgfetchbufail");
			}
		}

		[XmlElement] //[XmlElement(Order=46)]
		public string gi_msgfetchdupfail
		{
			get
			{
				return this.gi_msgfetchdupfailField;
			}
			set
			{
				this.gi_msgfetchdupfailField = value;
				base.RaisePropertyChanged("gi_msgfetchdupfail");
			}
		}

		[XmlElement] //[XmlElement(Order=47)]
		public string gi_msgfetchrolefail
		{
			get
			{
				return this.gi_msgfetchrolefailField;
			}
			set
			{
				this.gi_msgfetchrolefailField = value;
				base.RaisePropertyChanged("gi_msgfetchrolefail");
			}
		}

		[XmlElement] //[XmlElement(Order=48)]
		public string gi_msgfetchuserfail
		{
			get
			{
				return this.gi_msgfetchuserfailField;
			}
			set
			{
				this.gi_msgfetchuserfailField = value;
				base.RaisePropertyChanged("gi_msgfetchuserfail");
			}
		}

		[XmlElement] //[XmlElement(Order=49)]
		public string gi_msgffailinjectscript
		{
			get
			{
				return this.gi_msgffailinjectscriptField;
			}
			set
			{
				this.gi_msgffailinjectscriptField = value;
				base.RaisePropertyChanged("gi_msgffailinjectscript");
			}
		}

		[XmlElement] //[XmlElement(Order=50)]
		public string gi_msgfieldbysections
		{
			get
			{
				return this.gi_msgfieldbysectionsField;
			}
			set
			{
				this.gi_msgfieldbysectionsField = value;
				base.RaisePropertyChanged("gi_msgfieldbysections");
			}
		}

		[XmlElement] //[XmlElement(Order=51)]
		public string gi_msgfieldplacement
		{
			get
			{
				return this.gi_msgfieldplacementField;
			}
			set
			{
				this.gi_msgfieldplacementField = value;
				base.RaisePropertyChanged("gi_msgfieldplacement");
			}
		}

		[XmlElement] //[XmlElement(Order=52)]
		public string gi_msgfieldtabs
		{
			get
			{
				return this.gi_msgfieldtabsField;
			}
			set
			{
				this.gi_msgfieldtabsField = value;
				base.RaisePropertyChanged("gi_msgfieldtabs");
			}
		}

		[XmlElement] //[XmlElement(Order=53)]
		public string gi_msgfilterby
		{
			get
			{
				return this.gi_msgfilterbyField;
			}
			set
			{
				this.gi_msgfilterbyField = value;
				base.RaisePropertyChanged("gi_msgfilterby");
			}
		}

		[XmlElement] //[XmlElement(Order=54)]
		public string gi_msgfldaction
		{
			get
			{
				return this.gi_msgfldactionField;
			}
			set
			{
				this.gi_msgfldactionField = value;
				base.RaisePropertyChanged("gi_msgfldaction");
			}
		}

		[XmlElement] //[XmlElement(Order=55)]
		public string gi_msgfldname
		{
			get
			{
				return this.gi_msgfldnameField;
			}
			set
			{
				this.gi_msgfldnameField = value;
				base.RaisePropertyChanged("gi_msgfldname");
			}
		}

		[XmlElement] //[XmlElement(Order=56)]
		public string gi_msgfldtype
		{
			get
			{
				return this.gi_msgfldtypeField;
			}
			set
			{
				this.gi_msgfldtypeField = value;
				base.RaisePropertyChanged("gi_msgfldtype");
			}
		}

		[XmlElement] //[XmlElement(Order=57)]
		public string gi_msghid
		{
			get
			{
				return this.gi_msghidField;
			}
			set
			{
				this.gi_msghidField = value;
				base.RaisePropertyChanged("gi_msghid");
			}
		}

		[XmlElement] //[XmlElement(Order=58)]
		public string gi_msginstallfail
		{
			get
			{
				return this.gi_msginstallfailField;
			}
			set
			{
				this.gi_msginstallfailField = value;
				base.RaisePropertyChanged("gi_msginstallfail");
			}
		}

		[XmlElement] //[XmlElement(Order=59)]
		public string gi_msginstallok
		{
			get
			{
				return this.gi_msginstallokField;
			}
			set
			{
				this.gi_msginstallokField = value;
				base.RaisePropertyChanged("gi_msginstallok");
			}
		}

		[XmlElement] //[XmlElement(Order=60)]
		public string gi_msgkeeplayout
		{
			get
			{
				return this.gi_msgkeeplayoutField;
			}
			set
			{
				this.gi_msgkeeplayoutField = value;
				base.RaisePropertyChanged("gi_msgkeeplayout");
			}
		}

		[XmlElement] //[XmlElement(Order=61)]
		public string gi_msgloading
		{
			get
			{
				return this.gi_msgloadingField;
			}
			set
			{
				this.gi_msgloadingField = value;
				base.RaisePropertyChanged("gi_msgloading");
			}
		}

		[XmlElement] //[XmlElement(Order=62)]
		public string gi_msgloadingview
		{
			get
			{
				return this.gi_msgloadingviewField;
			}
			set
			{
				this.gi_msgloadingviewField = value;
				base.RaisePropertyChanged("gi_msgloadingview");
			}
		}

		[XmlElement] //[XmlElement(Order=63)]
		public string gi_msgmatchflsfail
		{
			get
			{
				return this.gi_msgmatchflsfailField;
			}
			set
			{
				this.gi_msgmatchflsfailField = value;
				base.RaisePropertyChanged("gi_msgmatchflsfail");
			}
		}

		[XmlElement] //[XmlElement(Order=64)]
		public string gi_msgmis
		{
			get
			{
				return this.gi_msgmisField;
			}
			set
			{
				this.gi_msgmisField = value;
				base.RaisePropertyChanged("gi_msgmis");
			}
		}

		[XmlElement] //[XmlElement(Order=65)]
		public string gi_msgmissingentity
		{
			get
			{
				return this.gi_msgmissingentityField;
			}
			set
			{
				this.gi_msgmissingentityField = value;
				base.RaisePropertyChanged("gi_msgmissingentity");
			}
		}

		[XmlElement] //[XmlElement(Order=66)]
		public string gi_msgonform
		{
			get
			{
				return this.gi_msgonformField;
			}
			set
			{
				this.gi_msgonformField = value;
				base.RaisePropertyChanged("gi_msgonform");
			}
		}

		[XmlElement] //[XmlElement(Order=67)]
		public string gi_msgoutform
		{
			get
			{
				return this.gi_msgoutformField;
			}
			set
			{
				this.gi_msgoutformField = value;
				base.RaisePropertyChanged("gi_msgoutform");
			}
		}

		[XmlElement] //[XmlElement(Order=68)]
		public string gi_msgpendingflsform
		{
			get
			{
				return this.gi_msgpendingflsformField;
			}
			set
			{
				this.gi_msgpendingflsformField = value;
				base.RaisePropertyChanged("gi_msgpendingflsform");
			}
		}

		[XmlElement] //[XmlElement(Order=69)]
		public string gi_msgpendingform1
		{
			get
			{
				return this.gi_msgpendingform1Field;
			}
			set
			{
				this.gi_msgpendingform1Field = value;
				base.RaisePropertyChanged("gi_msgpendingform1");
			}
		}

		[XmlElement] //[XmlElement(Order=70)]
		public string gi_msgpendingform2
		{
			get
			{
				return this.gi_msgpendingform2Field;
			}
			set
			{
				this.gi_msgpendingform2Field = value;
				base.RaisePropertyChanged("gi_msgpendingform2");
			}
		}

		[XmlElement] //[XmlElement(Order=71)]
		public string gi_msgpendingform3
		{
			get
			{
				return this.gi_msgpendingform3Field;
			}
			set
			{
				this.gi_msgpendingform3Field = value;
				base.RaisePropertyChanged("gi_msgpendingform3");
			}
		}

		[XmlElement] //[XmlElement(Order=72)]
		public string gi_msgpopupheadertext
		{
			get
			{
				return this.gi_msgpopupheadertextField;
			}
			set
			{
				this.gi_msgpopupheadertextField = value;
				base.RaisePropertyChanged("gi_msgpopupheadertext");
			}
		}

		[XmlElement] //[XmlElement(Order=73)]
		public string gi_msgpublishfail
		{
			get
			{
				return this.gi_msgpublishfailField;
			}
			set
			{
				this.gi_msgpublishfailField = value;
				base.RaisePropertyChanged("gi_msgpublishfail");
			}
		}

		[XmlElement] //[XmlElement(Order=74)]
		public string gi_msgpublishing
		{
			get
			{
				return this.gi_msgpublishingField;
			}
			set
			{
				this.gi_msgpublishingField = value;
				base.RaisePropertyChanged("gi_msgpublishing");
			}
		}

		[XmlElement] //[XmlElement(Order=75)]
		public string gi_msgpubscripterr1
		{
			get
			{
				return this.gi_msgpubscripterr1Field;
			}
			set
			{
				this.gi_msgpubscripterr1Field = value;
				base.RaisePropertyChanged("gi_msgpubscripterr1");
			}
		}

		[XmlElement] //[XmlElement(Order=76)]
		public string gi_msgpubscripterr2
		{
			get
			{
				return this.gi_msgpubscripterr2Field;
			}
			set
			{
				this.gi_msgpubscripterr2Field = value;
				base.RaisePropertyChanged("gi_msgpubscripterr2");
			}
		}

		[XmlElement] //[XmlElement(Order=77)]
		public string gi_msgpubscripterr3
		{
			get
			{
				return this.gi_msgpubscripterr3Field;
			}
			set
			{
				this.gi_msgpubscripterr3Field = value;
				base.RaisePropertyChanged("gi_msgpubscripterr3");
			}
		}

		[XmlElement] //[XmlElement(Order=78)]
		public string gi_msgsaving
		{
			get
			{
				return this.gi_msgsavingField;
			}
			set
			{
				this.gi_msgsavingField = value;
				base.RaisePropertyChanged("gi_msgsaving");
			}
		}

		[XmlElement] //[XmlElement(Order=79)]
		public string gi_msgscriptcopy
		{
			get
			{
				return this.gi_msgscriptcopyField;
			}
			set
			{
				this.gi_msgscriptcopyField = value;
				base.RaisePropertyChanged("gi_msgscriptcopy");
			}
		}

		[XmlElement] //[XmlElement(Order=80)]
		public string gi_msgtogglepublishfail
		{
			get
			{
				return this.gi_msgtogglepublishfailField;
			}
			set
			{
				this.gi_msgtogglepublishfailField = value;
				base.RaisePropertyChanged("gi_msgtogglepublishfail");
			}
		}

		[XmlElement] //[XmlElement(Order=81)]
		public string gi_msgundefined
		{
			get
			{
				return this.gi_msgundefinedField;
			}
			set
			{
				this.gi_msgundefinedField = value;
				base.RaisePropertyChanged("gi_msgundefined");
			}
		}

		[XmlElement] //[XmlElement(Order=82)]
		public string gi_msgunpublishing
		{
			get
			{
				return this.gi_msgunpublishingField;
			}
			set
			{
				this.gi_msgunpublishingField = value;
				base.RaisePropertyChanged("gi_msgunpublishing");
			}
		}

		[XmlElement] //[XmlElement(Order=83)]
		public string gi_msgwait
		{
			get
			{
				return this.gi_msgwaitField;
			}
			set
			{
				this.gi_msgwaitField = value;
				base.RaisePropertyChanged("gi_msgwait");
			}
		}

		[XmlElement] //[XmlElement(Order=84)]
		public string gi_plhtoolbar
		{
			get
			{
				return this.gi_plhtoolbarField;
			}
			set
			{
				this.gi_plhtoolbarField = value;
				base.RaisePropertyChanged("gi_plhtoolbar");
			}
		}

		[XmlElement] //[XmlElement(Order=85)]
		public CrmBoolean gi_publishstate
		{
			get
			{
				return this.gi_publishstateField;
			}
			set
			{
				this.gi_publishstateField = value;
				base.RaisePropertyChanged("gi_publishstate");
			}
		}

		[XmlElement] //[XmlElement(Order=86)]
		public string gi_role
		{
			get
			{
				return this.gi_roleField;
			}
			set
			{
				this.gi_roleField = value;
				base.RaisePropertyChanged("gi_role");
			}
		}

		[XmlElement] //[XmlElement(Order=87)]
		public string gi_rolename
		{
			get
			{
				return this.gi_rolenameField;
			}
			set
			{
				this.gi_rolenameField = value;
				base.RaisePropertyChanged("gi_rolename");
			}
		}

		[XmlElement] //[XmlElement(Order=88)]
		public string gi_user
		{
			get
			{
				return this.gi_userField;
			}
			set
			{
				this.gi_userField = value;
				base.RaisePropertyChanged("gi_user");
			}
		}

		[XmlElement] //[XmlElement(Order=89)]
		public string gi_username
		{
			get
			{
				return this.gi_usernameField;
			}
			set
			{
				this.gi_usernameField = value;
				base.RaisePropertyChanged("gi_username");
			}
		}

		[XmlElement] //[XmlElement(Order=90)]
		public string gi_xmlsettings
		{
			get
			{
				return this.gi_xmlsettingsField;
			}
			set
			{
				this.gi_xmlsettingsField = value;
				base.RaisePropertyChanged("gi_xmlsettings");
			}
		}

		[XmlElement] //[XmlElement(Order=91)]
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

		[XmlElement] //[XmlElement(Order=92)]
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

		[XmlElement] //[XmlElement(Order=93)]
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

		[XmlElement] //[XmlElement(Order=94)]
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

		[XmlElement] //[XmlElement(Order=95)]
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

		[XmlElement] //[XmlElement(Order=96)]
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

		[XmlElement] //[XmlElement(Order=97)]
		public Gi_FieldLevelSecurityStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=98)]
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

		[XmlElement] //[XmlElement(Order=99)]
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

		[XmlElement] //[XmlElement(Order=100)]
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

		public gi_fieldlevelsecurity()
		{
		}
	}
}