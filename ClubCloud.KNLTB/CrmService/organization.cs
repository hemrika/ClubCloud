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
	public class organization : BusinessEntity
	{
		private Lookup acknowledgementtemplateidField;

		private CrmBoolean allowaddressbooksyncsField;

		private CrmBoolean allowautoresponsecreationField;

		private CrmBoolean allowautounsubscribeField;

		private CrmBoolean allowautounsubscribeacknowledgementField;

		private CrmBoolean allowmarketingemailexecutionField;

		private CrmBoolean allowofflinescheduledsyncsField;

		private CrmBoolean allowoutlookscheduledsyncsField;

		private CrmBoolean allowunresolvedpartiesonemailsendField;

		private CrmBoolean allowwebexcelexportField;

		private string amdesignatorField;

		private Lookup basecurrencyidField;

		private string blockedattachmentsField;

		private string bulkoperationprefixField;

		private UniqueIdentifier businessclosurecalendaridField;

		private CrmNumber calendartypeField;

		private string campaignprefixField;

		private string caseprefixField;

		private string contractprefixField;

		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber currencydecimalprecisionField;

		private Picklist currencydisplayoptionField;

		private Picklist currencyformatcodeField;

		private string currencysymbolField;

		private CrmNumber currentbulkoperationnumberField;

		private CrmNumber currentcampaignnumberField;

		private CrmNumber currentcasenumberField;

		private CrmNumber currentcontractnumberField;

		private CrmNumber currentimportsequencenumberField;

		private CrmNumber currentinvoicenumberField;

		private CrmNumber currentkbnumberField;

		private CrmNumber currentordernumberField;

		private CrmNumber currentparsedtablenumberField;

		private CrmNumber currentquotenumberField;

		private Picklist dateformatcodeField;

		private string dateformatstringField;

		private string dateseparatorField;

		private string decimalsymbolField;

		private string disabledreasonField;

		private CrmNumber emailsendpollingperiodField;

		private CrmBoolean enablepricingoncreateField;

		private string featuresetField;

		private CrmDateTime fiscalcalendarstartField;

		private string fiscalperiodformatField;

		private CrmNumber fiscalperiodtypeField;

		private CrmBoolean fiscalsettingsupdatedField;

		private CrmNumber fiscalyeardisplaycodeField;

		private string fiscalyearformatField;

		private string fiscalyearperiodconnectField;

		private Picklist fullnameconventioncodeField;

		private CrmBoolean grantaccesstonetworkserviceField;

		private CrmBoolean ignoreinternalemailField;

		private UniqueIdentifier integrationuseridField;

		private string invoiceprefixField;

		private CrmBoolean isappmodeField;

		private CrmBoolean isdisabledField;

		private CrmBoolean isduplicatedetectionenabledField;

		private CrmBoolean isduplicatedetectionenabledforimportField;

		private CrmBoolean isduplicatedetectionenabledforofflinesyncField;

		private CrmBoolean isduplicatedetectionenabledforonlinecreateupdateField;

		private CrmBoolean isfiscalperiodmonthbasedField;

		private CrmBoolean ispresenceenabledField;

		private CrmBoolean isregisteredField;

		private CrmBoolean issopintegrationenabledField;

		private Picklist isvintegrationcodeField;

		private string kbprefixField;

		private CrmNumber languagecodeField;

		private CrmNumber localeidField;

		private CrmNumber longdateformatcodeField;

		private CrmNumber maxappointmentdurationdaysField;

		private CrmNumber maximumtrackingnumberField;

		private CrmNumber maxrecordsforexporttoexcelField;

		private CrmNumber maxuploadfilesizeField;

		private CrmNumber minaddressbooksyncintervalField;

		private CrmNumber minofflinesyncintervalField;

		private CrmNumber minoutlooksyncintervalField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private string nameField;

		private CrmNumber negativecurrencyformatcodeField;

		private Picklist negativeformatcodeField;

		private CrmNumber nexttrackingnumberField;

		private string numberformatField;

		private string numbergroupformatField;

		private string numberseparatorField;

		private string orderprefixField;

		private Key organizationidField;

		private string orgdborgsettingsField;

		private string parsedtablecolumnprefixField;

		private string parsedtableprefixField;

		private string pictureField;

		private string pmdesignatorField;

		private CrmNumber pricingdecimalprecisionField;

		private UniqueIdentifier privilegeusergroupidField;

		private UniqueIdentifier privreportinggroupidField;

		private string privreportinggroupnameField;

		private string quoteprefixField;

		private string referencesitemapxmlField;

		private CrmBoolean rendersecureiframeforemailField;

		private UniqueIdentifier reportinggroupidField;

		private string reportinggroupnameField;

		private string schemanameprefixField;

		private CrmBoolean sharetopreviousowneronassignField;

		private CrmBoolean showweeknumberField;

		private string sitemapxmlField;

		private CrmNumber sortidField;

		private UniqueIdentifier sqlaccessgroupidField;

		private string sqlaccessgroupnameField;

		private CrmBoolean sqmenabledField;

		private UniqueIdentifier supportuseridField;

		private UniqueIdentifier systemuseridField;

		private CrmNumber tagmaxaggressivecyclesField;

		private CrmNumber tagpollingperiodField;

		private Picklist timeformatcodeField;

		private string timeformatstringField;

		private string timeseparatorField;

		private CrmNumber timezoneruleversionnumberField;

		private CrmNumber tokenexpiryField;

		private string tokenkeyField;

		private string trackingprefixField;

		private CrmNumber trackingtokenidbaseField;

		private CrmNumber trackingtokeniddigitsField;

		private CrmNumber uniquespecifierlengthField;

		private UniqueIdentifier usergroupidField;

		private CrmNumber utcconversiontimezonecodeField;

		private string v3calloutconfighashField;

		private Picklist weekstartdaycodeField;

		private CrmNumber yearstartweekcodeField;

		[XmlElement] //[XmlElement(Order=0)]
		public Lookup acknowledgementtemplateid
		{
			get
			{
				return this.acknowledgementtemplateidField;
			}
			set
			{
				this.acknowledgementtemplateidField = value;
				base.RaisePropertyChanged("acknowledgementtemplateid");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public CrmBoolean allowaddressbooksyncs
		{
			get
			{
				return this.allowaddressbooksyncsField;
			}
			set
			{
				this.allowaddressbooksyncsField = value;
				base.RaisePropertyChanged("allowaddressbooksyncs");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public CrmBoolean allowautoresponsecreation
		{
			get
			{
				return this.allowautoresponsecreationField;
			}
			set
			{
				this.allowautoresponsecreationField = value;
				base.RaisePropertyChanged("allowautoresponsecreation");
			}
		}

		[XmlElement] //[XmlElement(Order=3)]
		public CrmBoolean allowautounsubscribe
		{
			get
			{
				return this.allowautounsubscribeField;
			}
			set
			{
				this.allowautounsubscribeField = value;
				base.RaisePropertyChanged("allowautounsubscribe");
			}
		}

		[XmlElement] //[XmlElement(Order=4)]
		public CrmBoolean allowautounsubscribeacknowledgement
		{
			get
			{
				return this.allowautounsubscribeacknowledgementField;
			}
			set
			{
				this.allowautounsubscribeacknowledgementField = value;
				base.RaisePropertyChanged("allowautounsubscribeacknowledgement");
			}
		}

		[XmlElement] //[XmlElement(Order=5)]
		public CrmBoolean allowmarketingemailexecution
		{
			get
			{
				return this.allowmarketingemailexecutionField;
			}
			set
			{
				this.allowmarketingemailexecutionField = value;
				base.RaisePropertyChanged("allowmarketingemailexecution");
			}
		}

		[XmlElement] //[XmlElement(Order=6)]
		public CrmBoolean allowofflinescheduledsyncs
		{
			get
			{
				return this.allowofflinescheduledsyncsField;
			}
			set
			{
				this.allowofflinescheduledsyncsField = value;
				base.RaisePropertyChanged("allowofflinescheduledsyncs");
			}
		}

		[XmlElement] //[XmlElement(Order=7)]
		public CrmBoolean allowoutlookscheduledsyncs
		{
			get
			{
				return this.allowoutlookscheduledsyncsField;
			}
			set
			{
				this.allowoutlookscheduledsyncsField = value;
				base.RaisePropertyChanged("allowoutlookscheduledsyncs");
			}
		}

		[XmlElement] //[XmlElement(Order=8)]
		public CrmBoolean allowunresolvedpartiesonemailsend
		{
			get
			{
				return this.allowunresolvedpartiesonemailsendField;
			}
			set
			{
				this.allowunresolvedpartiesonemailsendField = value;
				base.RaisePropertyChanged("allowunresolvedpartiesonemailsend");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public CrmBoolean allowwebexcelexport
		{
			get
			{
				return this.allowwebexcelexportField;
			}
			set
			{
				this.allowwebexcelexportField = value;
				base.RaisePropertyChanged("allowwebexcelexport");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public string amdesignator
		{
			get
			{
				return this.amdesignatorField;
			}
			set
			{
				this.amdesignatorField = value;
				base.RaisePropertyChanged("amdesignator");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public Lookup basecurrencyid
		{
			get
			{
				return this.basecurrencyidField;
			}
			set
			{
				this.basecurrencyidField = value;
				base.RaisePropertyChanged("basecurrencyid");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public string blockedattachments
		{
			get
			{
				return this.blockedattachmentsField;
			}
			set
			{
				this.blockedattachmentsField = value;
				base.RaisePropertyChanged("blockedattachments");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public string bulkoperationprefix
		{
			get
			{
				return this.bulkoperationprefixField;
			}
			set
			{
				this.bulkoperationprefixField = value;
				base.RaisePropertyChanged("bulkoperationprefix");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public UniqueIdentifier businessclosurecalendarid
		{
			get
			{
				return this.businessclosurecalendaridField;
			}
			set
			{
				this.businessclosurecalendaridField = value;
				base.RaisePropertyChanged("businessclosurecalendarid");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public CrmNumber calendartype
		{
			get
			{
				return this.calendartypeField;
			}
			set
			{
				this.calendartypeField = value;
				base.RaisePropertyChanged("calendartype");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public string campaignprefix
		{
			get
			{
				return this.campaignprefixField;
			}
			set
			{
				this.campaignprefixField = value;
				base.RaisePropertyChanged("campaignprefix");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public string caseprefix
		{
			get
			{
				return this.caseprefixField;
			}
			set
			{
				this.caseprefixField = value;
				base.RaisePropertyChanged("caseprefix");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public string contractprefix
		{
			get
			{
				return this.contractprefixField;
			}
			set
			{
				this.contractprefixField = value;
				base.RaisePropertyChanged("contractprefix");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
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

		[XmlElement] //[XmlElement(Order=20)]
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

		[XmlElement] //[XmlElement(Order=21)]
		public CrmNumber currencydecimalprecision
		{
			get
			{
				return this.currencydecimalprecisionField;
			}
			set
			{
				this.currencydecimalprecisionField = value;
				base.RaisePropertyChanged("currencydecimalprecision");
			}
		}

		[XmlElement] //[XmlElement(Order=22)]
		public Picklist currencydisplayoption
		{
			get
			{
				return this.currencydisplayoptionField;
			}
			set
			{
				this.currencydisplayoptionField = value;
				base.RaisePropertyChanged("currencydisplayoption");
			}
		}

		[XmlElement] //[XmlElement(Order=23)]
		public Picklist currencyformatcode
		{
			get
			{
				return this.currencyformatcodeField;
			}
			set
			{
				this.currencyformatcodeField = value;
				base.RaisePropertyChanged("currencyformatcode");
			}
		}

		[XmlElement] //[XmlElement(Order=24)]
		public string currencysymbol
		{
			get
			{
				return this.currencysymbolField;
			}
			set
			{
				this.currencysymbolField = value;
				base.RaisePropertyChanged("currencysymbol");
			}
		}

		[XmlElement] //[XmlElement(Order=25)]
		public CrmNumber currentbulkoperationnumber
		{
			get
			{
				return this.currentbulkoperationnumberField;
			}
			set
			{
				this.currentbulkoperationnumberField = value;
				base.RaisePropertyChanged("currentbulkoperationnumber");
			}
		}

		[XmlElement] //[XmlElement(Order=26)]
		public CrmNumber currentcampaignnumber
		{
			get
			{
				return this.currentcampaignnumberField;
			}
			set
			{
				this.currentcampaignnumberField = value;
				base.RaisePropertyChanged("currentcampaignnumber");
			}
		}

		[XmlElement] //[XmlElement(Order=27)]
		public CrmNumber currentcasenumber
		{
			get
			{
				return this.currentcasenumberField;
			}
			set
			{
				this.currentcasenumberField = value;
				base.RaisePropertyChanged("currentcasenumber");
			}
		}

		[XmlElement] //[XmlElement(Order=28)]
		public CrmNumber currentcontractnumber
		{
			get
			{
				return this.currentcontractnumberField;
			}
			set
			{
				this.currentcontractnumberField = value;
				base.RaisePropertyChanged("currentcontractnumber");
			}
		}

		[XmlElement] //[XmlElement(Order=29)]
		public CrmNumber currentimportsequencenumber
		{
			get
			{
				return this.currentimportsequencenumberField;
			}
			set
			{
				this.currentimportsequencenumberField = value;
				base.RaisePropertyChanged("currentimportsequencenumber");
			}
		}

		[XmlElement] //[XmlElement(Order=30)]
		public CrmNumber currentinvoicenumber
		{
			get
			{
				return this.currentinvoicenumberField;
			}
			set
			{
				this.currentinvoicenumberField = value;
				base.RaisePropertyChanged("currentinvoicenumber");
			}
		}

		[XmlElement] //[XmlElement(Order=31)]
		public CrmNumber currentkbnumber
		{
			get
			{
				return this.currentkbnumberField;
			}
			set
			{
				this.currentkbnumberField = value;
				base.RaisePropertyChanged("currentkbnumber");
			}
		}

		[XmlElement] //[XmlElement(Order=32)]
		public CrmNumber currentordernumber
		{
			get
			{
				return this.currentordernumberField;
			}
			set
			{
				this.currentordernumberField = value;
				base.RaisePropertyChanged("currentordernumber");
			}
		}

		[XmlElement] //[XmlElement(Order=33)]
		public CrmNumber currentparsedtablenumber
		{
			get
			{
				return this.currentparsedtablenumberField;
			}
			set
			{
				this.currentparsedtablenumberField = value;
				base.RaisePropertyChanged("currentparsedtablenumber");
			}
		}

		[XmlElement] //[XmlElement(Order=34)]
		public CrmNumber currentquotenumber
		{
			get
			{
				return this.currentquotenumberField;
			}
			set
			{
				this.currentquotenumberField = value;
				base.RaisePropertyChanged("currentquotenumber");
			}
		}

		[XmlElement] //[XmlElement(Order=35)]
		public Picklist dateformatcode
		{
			get
			{
				return this.dateformatcodeField;
			}
			set
			{
				this.dateformatcodeField = value;
				base.RaisePropertyChanged("dateformatcode");
			}
		}

		[XmlElement] //[XmlElement(Order=36)]
		public string dateformatstring
		{
			get
			{
				return this.dateformatstringField;
			}
			set
			{
				this.dateformatstringField = value;
				base.RaisePropertyChanged("dateformatstring");
			}
		}

		[XmlElement] //[XmlElement(Order=37)]
		public string dateseparator
		{
			get
			{
				return this.dateseparatorField;
			}
			set
			{
				this.dateseparatorField = value;
				base.RaisePropertyChanged("dateseparator");
			}
		}

		[XmlElement] //[XmlElement(Order=38)]
		public string decimalsymbol
		{
			get
			{
				return this.decimalsymbolField;
			}
			set
			{
				this.decimalsymbolField = value;
				base.RaisePropertyChanged("decimalsymbol");
			}
		}

		[XmlElement] //[XmlElement(Order=39)]
		public string disabledreason
		{
			get
			{
				return this.disabledreasonField;
			}
			set
			{
				this.disabledreasonField = value;
				base.RaisePropertyChanged("disabledreason");
			}
		}

		[XmlElement] //[XmlElement(Order=40)]
		public CrmNumber emailsendpollingperiod
		{
			get
			{
				return this.emailsendpollingperiodField;
			}
			set
			{
				this.emailsendpollingperiodField = value;
				base.RaisePropertyChanged("emailsendpollingperiod");
			}
		}

		[XmlElement] //[XmlElement(Order=41)]
		public CrmBoolean enablepricingoncreate
		{
			get
			{
				return this.enablepricingoncreateField;
			}
			set
			{
				this.enablepricingoncreateField = value;
				base.RaisePropertyChanged("enablepricingoncreate");
			}
		}

		[XmlElement] //[XmlElement(Order=42)]
		public string featureset
		{
			get
			{
				return this.featuresetField;
			}
			set
			{
				this.featuresetField = value;
				base.RaisePropertyChanged("featureset");
			}
		}

		[XmlElement] //[XmlElement(Order=43)]
		public CrmDateTime fiscalcalendarstart
		{
			get
			{
				return this.fiscalcalendarstartField;
			}
			set
			{
				this.fiscalcalendarstartField = value;
				base.RaisePropertyChanged("fiscalcalendarstart");
			}
		}

		[XmlElement] //[XmlElement(Order=44)]
		public string fiscalperiodformat
		{
			get
			{
				return this.fiscalperiodformatField;
			}
			set
			{
				this.fiscalperiodformatField = value;
				base.RaisePropertyChanged("fiscalperiodformat");
			}
		}

		[XmlElement] //[XmlElement(Order=45)]
		public CrmNumber fiscalperiodtype
		{
			get
			{
				return this.fiscalperiodtypeField;
			}
			set
			{
				this.fiscalperiodtypeField = value;
				base.RaisePropertyChanged("fiscalperiodtype");
			}
		}

		[XmlElement] //[XmlElement(Order=46)]
		public CrmBoolean fiscalsettingsupdated
		{
			get
			{
				return this.fiscalsettingsupdatedField;
			}
			set
			{
				this.fiscalsettingsupdatedField = value;
				base.RaisePropertyChanged("fiscalsettingsupdated");
			}
		}

		[XmlElement] //[XmlElement(Order=47)]
		public CrmNumber fiscalyeardisplaycode
		{
			get
			{
				return this.fiscalyeardisplaycodeField;
			}
			set
			{
				this.fiscalyeardisplaycodeField = value;
				base.RaisePropertyChanged("fiscalyeardisplaycode");
			}
		}

		[XmlElement] //[XmlElement(Order=48)]
		public string fiscalyearformat
		{
			get
			{
				return this.fiscalyearformatField;
			}
			set
			{
				this.fiscalyearformatField = value;
				base.RaisePropertyChanged("fiscalyearformat");
			}
		}

		[XmlElement] //[XmlElement(Order=49)]
		public string fiscalyearperiodconnect
		{
			get
			{
				return this.fiscalyearperiodconnectField;
			}
			set
			{
				this.fiscalyearperiodconnectField = value;
				base.RaisePropertyChanged("fiscalyearperiodconnect");
			}
		}

		[XmlElement] //[XmlElement(Order=50)]
		public Picklist fullnameconventioncode
		{
			get
			{
				return this.fullnameconventioncodeField;
			}
			set
			{
				this.fullnameconventioncodeField = value;
				base.RaisePropertyChanged("fullnameconventioncode");
			}
		}

		[XmlElement] //[XmlElement(Order=51)]
		public CrmBoolean grantaccesstonetworkservice
		{
			get
			{
				return this.grantaccesstonetworkserviceField;
			}
			set
			{
				this.grantaccesstonetworkserviceField = value;
				base.RaisePropertyChanged("grantaccesstonetworkservice");
			}
		}

		[XmlElement] //[XmlElement(Order=52)]
		public CrmBoolean ignoreinternalemail
		{
			get
			{
				return this.ignoreinternalemailField;
			}
			set
			{
				this.ignoreinternalemailField = value;
				base.RaisePropertyChanged("ignoreinternalemail");
			}
		}

		[XmlElement] //[XmlElement(Order=53)]
		public UniqueIdentifier integrationuserid
		{
			get
			{
				return this.integrationuseridField;
			}
			set
			{
				this.integrationuseridField = value;
				base.RaisePropertyChanged("integrationuserid");
			}
		}

		[XmlElement] //[XmlElement(Order=54)]
		public string invoiceprefix
		{
			get
			{
				return this.invoiceprefixField;
			}
			set
			{
				this.invoiceprefixField = value;
				base.RaisePropertyChanged("invoiceprefix");
			}
		}

		[XmlElement] //[XmlElement(Order=55)]
		public CrmBoolean isappmode
		{
			get
			{
				return this.isappmodeField;
			}
			set
			{
				this.isappmodeField = value;
				base.RaisePropertyChanged("isappmode");
			}
		}

		[XmlElement] //[XmlElement(Order=56)]
		public CrmBoolean isdisabled
		{
			get
			{
				return this.isdisabledField;
			}
			set
			{
				this.isdisabledField = value;
				base.RaisePropertyChanged("isdisabled");
			}
		}

		[XmlElement] //[XmlElement(Order=57)]
		public CrmBoolean isduplicatedetectionenabled
		{
			get
			{
				return this.isduplicatedetectionenabledField;
			}
			set
			{
				this.isduplicatedetectionenabledField = value;
				base.RaisePropertyChanged("isduplicatedetectionenabled");
			}
		}

		[XmlElement] //[XmlElement(Order=58)]
		public CrmBoolean isduplicatedetectionenabledforimport
		{
			get
			{
				return this.isduplicatedetectionenabledforimportField;
			}
			set
			{
				this.isduplicatedetectionenabledforimportField = value;
				base.RaisePropertyChanged("isduplicatedetectionenabledforimport");
			}
		}

		[XmlElement] //[XmlElement(Order=59)]
		public CrmBoolean isduplicatedetectionenabledforofflinesync
		{
			get
			{
				return this.isduplicatedetectionenabledforofflinesyncField;
			}
			set
			{
				this.isduplicatedetectionenabledforofflinesyncField = value;
				base.RaisePropertyChanged("isduplicatedetectionenabledforofflinesync");
			}
		}

		[XmlElement] //[XmlElement(Order=60)]
		public CrmBoolean isduplicatedetectionenabledforonlinecreateupdate
		{
			get
			{
				return this.isduplicatedetectionenabledforonlinecreateupdateField;
			}
			set
			{
				this.isduplicatedetectionenabledforonlinecreateupdateField = value;
				base.RaisePropertyChanged("isduplicatedetectionenabledforonlinecreateupdate");
			}
		}

		[XmlElement] //[XmlElement(Order=61)]
		public CrmBoolean isfiscalperiodmonthbased
		{
			get
			{
				return this.isfiscalperiodmonthbasedField;
			}
			set
			{
				this.isfiscalperiodmonthbasedField = value;
				base.RaisePropertyChanged("isfiscalperiodmonthbased");
			}
		}

		[XmlElement] //[XmlElement(Order=62)]
		public CrmBoolean ispresenceenabled
		{
			get
			{
				return this.ispresenceenabledField;
			}
			set
			{
				this.ispresenceenabledField = value;
				base.RaisePropertyChanged("ispresenceenabled");
			}
		}

		[XmlElement] //[XmlElement(Order=63)]
		public CrmBoolean isregistered
		{
			get
			{
				return this.isregisteredField;
			}
			set
			{
				this.isregisteredField = value;
				base.RaisePropertyChanged("isregistered");
			}
		}

		[XmlElement] //[XmlElement(Order=64)]
		public CrmBoolean issopintegrationenabled
		{
			get
			{
				return this.issopintegrationenabledField;
			}
			set
			{
				this.issopintegrationenabledField = value;
				base.RaisePropertyChanged("issopintegrationenabled");
			}
		}

		[XmlElement] //[XmlElement(Order=65)]
		public Picklist isvintegrationcode
		{
			get
			{
				return this.isvintegrationcodeField;
			}
			set
			{
				this.isvintegrationcodeField = value;
				base.RaisePropertyChanged("isvintegrationcode");
			}
		}

		[XmlElement] //[XmlElement(Order=66)]
		public string kbprefix
		{
			get
			{
				return this.kbprefixField;
			}
			set
			{
				this.kbprefixField = value;
				base.RaisePropertyChanged("kbprefix");
			}
		}

		[XmlElement] //[XmlElement(Order=67)]
		public CrmNumber languagecode
		{
			get
			{
				return this.languagecodeField;
			}
			set
			{
				this.languagecodeField = value;
				base.RaisePropertyChanged("languagecode");
			}
		}

		[XmlElement] //[XmlElement(Order=68)]
		public CrmNumber localeid
		{
			get
			{
				return this.localeidField;
			}
			set
			{
				this.localeidField = value;
				base.RaisePropertyChanged("localeid");
			}
		}

		[XmlElement] //[XmlElement(Order=69)]
		public CrmNumber longdateformatcode
		{
			get
			{
				return this.longdateformatcodeField;
			}
			set
			{
				this.longdateformatcodeField = value;
				base.RaisePropertyChanged("longdateformatcode");
			}
		}

		[XmlElement] //[XmlElement(Order=70)]
		public CrmNumber maxappointmentdurationdays
		{
			get
			{
				return this.maxappointmentdurationdaysField;
			}
			set
			{
				this.maxappointmentdurationdaysField = value;
				base.RaisePropertyChanged("maxappointmentdurationdays");
			}
		}

		[XmlElement] //[XmlElement(Order=71)]
		public CrmNumber maximumtrackingnumber
		{
			get
			{
				return this.maximumtrackingnumberField;
			}
			set
			{
				this.maximumtrackingnumberField = value;
				base.RaisePropertyChanged("maximumtrackingnumber");
			}
		}

		[XmlElement] //[XmlElement(Order=72)]
		public CrmNumber maxrecordsforexporttoexcel
		{
			get
			{
				return this.maxrecordsforexporttoexcelField;
			}
			set
			{
				this.maxrecordsforexporttoexcelField = value;
				base.RaisePropertyChanged("maxrecordsforexporttoexcel");
			}
		}

		[XmlElement] //[XmlElement(Order=73)]
		public CrmNumber maxuploadfilesize
		{
			get
			{
				return this.maxuploadfilesizeField;
			}
			set
			{
				this.maxuploadfilesizeField = value;
				base.RaisePropertyChanged("maxuploadfilesize");
			}
		}

		[XmlElement] //[XmlElement(Order=74)]
		public CrmNumber minaddressbooksyncinterval
		{
			get
			{
				return this.minaddressbooksyncintervalField;
			}
			set
			{
				this.minaddressbooksyncintervalField = value;
				base.RaisePropertyChanged("minaddressbooksyncinterval");
			}
		}

		[XmlElement] //[XmlElement(Order=75)]
		public CrmNumber minofflinesyncinterval
		{
			get
			{
				return this.minofflinesyncintervalField;
			}
			set
			{
				this.minofflinesyncintervalField = value;
				base.RaisePropertyChanged("minofflinesyncinterval");
			}
		}

		[XmlElement] //[XmlElement(Order=76)]
		public CrmNumber minoutlooksyncinterval
		{
			get
			{
				return this.minoutlooksyncintervalField;
			}
			set
			{
				this.minoutlooksyncintervalField = value;
				base.RaisePropertyChanged("minoutlooksyncinterval");
			}
		}

		[XmlElement] //[XmlElement(Order=77)]
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

		[XmlElement] //[XmlElement(Order=78)]
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

		[XmlElement] //[XmlElement(Order=79)]
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				base.RaisePropertyChanged("name");
			}
		}

		[XmlElement] //[XmlElement(Order=80)]
		public CrmNumber negativecurrencyformatcode
		{
			get
			{
				return this.negativecurrencyformatcodeField;
			}
			set
			{
				this.negativecurrencyformatcodeField = value;
				base.RaisePropertyChanged("negativecurrencyformatcode");
			}
		}

		[XmlElement] //[XmlElement(Order=81)]
		public Picklist negativeformatcode
		{
			get
			{
				return this.negativeformatcodeField;
			}
			set
			{
				this.negativeformatcodeField = value;
				base.RaisePropertyChanged("negativeformatcode");
			}
		}

		[XmlElement] //[XmlElement(Order=82)]
		public CrmNumber nexttrackingnumber
		{
			get
			{
				return this.nexttrackingnumberField;
			}
			set
			{
				this.nexttrackingnumberField = value;
				base.RaisePropertyChanged("nexttrackingnumber");
			}
		}

		[XmlElement] //[XmlElement(Order=83)]
		public string numberformat
		{
			get
			{
				return this.numberformatField;
			}
			set
			{
				this.numberformatField = value;
				base.RaisePropertyChanged("numberformat");
			}
		}

		[XmlElement] //[XmlElement(Order=84)]
		public string numbergroupformat
		{
			get
			{
				return this.numbergroupformatField;
			}
			set
			{
				this.numbergroupformatField = value;
				base.RaisePropertyChanged("numbergroupformat");
			}
		}

		[XmlElement] //[XmlElement(Order=85)]
		public string numberseparator
		{
			get
			{
				return this.numberseparatorField;
			}
			set
			{
				this.numberseparatorField = value;
				base.RaisePropertyChanged("numberseparator");
			}
		}

		[XmlElement] //[XmlElement(Order=86)]
		public string orderprefix
		{
			get
			{
				return this.orderprefixField;
			}
			set
			{
				this.orderprefixField = value;
				base.RaisePropertyChanged("orderprefix");
			}
		}

		[XmlElement] //[XmlElement(Order=87)]
		public Key organizationid
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

		[XmlElement] //[XmlElement(Order=88)]
		public string orgdborgsettings
		{
			get
			{
				return this.orgdborgsettingsField;
			}
			set
			{
				this.orgdborgsettingsField = value;
				base.RaisePropertyChanged("orgdborgsettings");
			}
		}

		[XmlElement] //[XmlElement(Order=89)]
		public string parsedtablecolumnprefix
		{
			get
			{
				return this.parsedtablecolumnprefixField;
			}
			set
			{
				this.parsedtablecolumnprefixField = value;
				base.RaisePropertyChanged("parsedtablecolumnprefix");
			}
		}

		[XmlElement] //[XmlElement(Order=90)]
		public string parsedtableprefix
		{
			get
			{
				return this.parsedtableprefixField;
			}
			set
			{
				this.parsedtableprefixField = value;
				base.RaisePropertyChanged("parsedtableprefix");
			}
		}

		[XmlElement] //[XmlElement(Order=91)]
		public string picture
		{
			get
			{
				return this.pictureField;
			}
			set
			{
				this.pictureField = value;
				base.RaisePropertyChanged("picture");
			}
		}

		[XmlElement] //[XmlElement(Order=92)]
		public string pmdesignator
		{
			get
			{
				return this.pmdesignatorField;
			}
			set
			{
				this.pmdesignatorField = value;
				base.RaisePropertyChanged("pmdesignator");
			}
		}

		[XmlElement] //[XmlElement(Order=93)]
		public CrmNumber pricingdecimalprecision
		{
			get
			{
				return this.pricingdecimalprecisionField;
			}
			set
			{
				this.pricingdecimalprecisionField = value;
				base.RaisePropertyChanged("pricingdecimalprecision");
			}
		}

		[XmlElement] //[XmlElement(Order=94)]
		public UniqueIdentifier privilegeusergroupid
		{
			get
			{
				return this.privilegeusergroupidField;
			}
			set
			{
				this.privilegeusergroupidField = value;
				base.RaisePropertyChanged("privilegeusergroupid");
			}
		}

		[XmlElement] //[XmlElement(Order=95)]
		public UniqueIdentifier privreportinggroupid
		{
			get
			{
				return this.privreportinggroupidField;
			}
			set
			{
				this.privreportinggroupidField = value;
				base.RaisePropertyChanged("privreportinggroupid");
			}
		}

		[XmlElement] //[XmlElement(Order=96)]
		public string privreportinggroupname
		{
			get
			{
				return this.privreportinggroupnameField;
			}
			set
			{
				this.privreportinggroupnameField = value;
				base.RaisePropertyChanged("privreportinggroupname");
			}
		}

		[XmlElement] //[XmlElement(Order=97)]
		public string quoteprefix
		{
			get
			{
				return this.quoteprefixField;
			}
			set
			{
				this.quoteprefixField = value;
				base.RaisePropertyChanged("quoteprefix");
			}
		}

		[XmlElement] //[XmlElement(Order=98)]
		public string referencesitemapxml
		{
			get
			{
				return this.referencesitemapxmlField;
			}
			set
			{
				this.referencesitemapxmlField = value;
				base.RaisePropertyChanged("referencesitemapxml");
			}
		}

		[XmlElement] //[XmlElement(Order=99)]
		public CrmBoolean rendersecureiframeforemail
		{
			get
			{
				return this.rendersecureiframeforemailField;
			}
			set
			{
				this.rendersecureiframeforemailField = value;
				base.RaisePropertyChanged("rendersecureiframeforemail");
			}
		}

		[XmlElement] //[XmlElement(Order=100)]
		public UniqueIdentifier reportinggroupid
		{
			get
			{
				return this.reportinggroupidField;
			}
			set
			{
				this.reportinggroupidField = value;
				base.RaisePropertyChanged("reportinggroupid");
			}
		}

		[XmlElement] //[XmlElement(Order=101)]
		public string reportinggroupname
		{
			get
			{
				return this.reportinggroupnameField;
			}
			set
			{
				this.reportinggroupnameField = value;
				base.RaisePropertyChanged("reportinggroupname");
			}
		}

		[XmlElement] //[XmlElement(Order=102)]
		public string schemanameprefix
		{
			get
			{
				return this.schemanameprefixField;
			}
			set
			{
				this.schemanameprefixField = value;
				base.RaisePropertyChanged("schemanameprefix");
			}
		}

		[XmlElement] //[XmlElement(Order=103)]
		public CrmBoolean sharetopreviousowneronassign
		{
			get
			{
				return this.sharetopreviousowneronassignField;
			}
			set
			{
				this.sharetopreviousowneronassignField = value;
				base.RaisePropertyChanged("sharetopreviousowneronassign");
			}
		}

		[XmlElement] //[XmlElement(Order=104)]
		public CrmBoolean showweeknumber
		{
			get
			{
				return this.showweeknumberField;
			}
			set
			{
				this.showweeknumberField = value;
				base.RaisePropertyChanged("showweeknumber");
			}
		}

		[XmlElement] //[XmlElement(Order=105)]
		public string sitemapxml
		{
			get
			{
				return this.sitemapxmlField;
			}
			set
			{
				this.sitemapxmlField = value;
				base.RaisePropertyChanged("sitemapxml");
			}
		}

		[XmlElement] //[XmlElement(Order=106)]
		public CrmNumber sortid
		{
			get
			{
				return this.sortidField;
			}
			set
			{
				this.sortidField = value;
				base.RaisePropertyChanged("sortid");
			}
		}

		[XmlElement] //[XmlElement(Order=107)]
		public UniqueIdentifier sqlaccessgroupid
		{
			get
			{
				return this.sqlaccessgroupidField;
			}
			set
			{
				this.sqlaccessgroupidField = value;
				base.RaisePropertyChanged("sqlaccessgroupid");
			}
		}

		[XmlElement] //[XmlElement(Order=108)]
		public string sqlaccessgroupname
		{
			get
			{
				return this.sqlaccessgroupnameField;
			}
			set
			{
				this.sqlaccessgroupnameField = value;
				base.RaisePropertyChanged("sqlaccessgroupname");
			}
		}

		[XmlElement] //[XmlElement(Order=109)]
		public CrmBoolean sqmenabled
		{
			get
			{
				return this.sqmenabledField;
			}
			set
			{
				this.sqmenabledField = value;
				base.RaisePropertyChanged("sqmenabled");
			}
		}

		[XmlElement] //[XmlElement(Order=110)]
		public UniqueIdentifier supportuserid
		{
			get
			{
				return this.supportuseridField;
			}
			set
			{
				this.supportuseridField = value;
				base.RaisePropertyChanged("supportuserid");
			}
		}

		[XmlElement] //[XmlElement(Order=111)]
		public UniqueIdentifier systemuserid
		{
			get
			{
				return this.systemuseridField;
			}
			set
			{
				this.systemuseridField = value;
				base.RaisePropertyChanged("systemuserid");
			}
		}

		[XmlElement] //[XmlElement(Order=112)]
		public CrmNumber tagmaxaggressivecycles
		{
			get
			{
				return this.tagmaxaggressivecyclesField;
			}
			set
			{
				this.tagmaxaggressivecyclesField = value;
				base.RaisePropertyChanged("tagmaxaggressivecycles");
			}
		}

		[XmlElement] //[XmlElement(Order=113)]
		public CrmNumber tagpollingperiod
		{
			get
			{
				return this.tagpollingperiodField;
			}
			set
			{
				this.tagpollingperiodField = value;
				base.RaisePropertyChanged("tagpollingperiod");
			}
		}

		[XmlElement] //[XmlElement(Order=114)]
		public Picklist timeformatcode
		{
			get
			{
				return this.timeformatcodeField;
			}
			set
			{
				this.timeformatcodeField = value;
				base.RaisePropertyChanged("timeformatcode");
			}
		}

		[XmlElement] //[XmlElement(Order=115)]
		public string timeformatstring
		{
			get
			{
				return this.timeformatstringField;
			}
			set
			{
				this.timeformatstringField = value;
				base.RaisePropertyChanged("timeformatstring");
			}
		}

		[XmlElement] //[XmlElement(Order=116)]
		public string timeseparator
		{
			get
			{
				return this.timeseparatorField;
			}
			set
			{
				this.timeseparatorField = value;
				base.RaisePropertyChanged("timeseparator");
			}
		}

		[XmlElement] //[XmlElement(Order=117)]
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

		[XmlElement] //[XmlElement(Order=118)]
		public CrmNumber tokenexpiry
		{
			get
			{
				return this.tokenexpiryField;
			}
			set
			{
				this.tokenexpiryField = value;
				base.RaisePropertyChanged("tokenexpiry");
			}
		}

		[XmlElement] //[XmlElement(Order=119)]
		public string tokenkey
		{
			get
			{
				return this.tokenkeyField;
			}
			set
			{
				this.tokenkeyField = value;
				base.RaisePropertyChanged("tokenkey");
			}
		}

		[XmlElement] //[XmlElement(Order=120)]
		public string trackingprefix
		{
			get
			{
				return this.trackingprefixField;
			}
			set
			{
				this.trackingprefixField = value;
				base.RaisePropertyChanged("trackingprefix");
			}
		}

		[XmlElement] //[XmlElement(Order=121)]
		public CrmNumber trackingtokenidbase
		{
			get
			{
				return this.trackingtokenidbaseField;
			}
			set
			{
				this.trackingtokenidbaseField = value;
				base.RaisePropertyChanged("trackingtokenidbase");
			}
		}

		[XmlElement] //[XmlElement(Order=122)]
		public CrmNumber trackingtokeniddigits
		{
			get
			{
				return this.trackingtokeniddigitsField;
			}
			set
			{
				this.trackingtokeniddigitsField = value;
				base.RaisePropertyChanged("trackingtokeniddigits");
			}
		}

		[XmlElement] //[XmlElement(Order=123)]
		public CrmNumber uniquespecifierlength
		{
			get
			{
				return this.uniquespecifierlengthField;
			}
			set
			{
				this.uniquespecifierlengthField = value;
				base.RaisePropertyChanged("uniquespecifierlength");
			}
		}

		[XmlElement] //[XmlElement(Order=124)]
		public UniqueIdentifier usergroupid
		{
			get
			{
				return this.usergroupidField;
			}
			set
			{
				this.usergroupidField = value;
				base.RaisePropertyChanged("usergroupid");
			}
		}

		[XmlElement] //[XmlElement(Order=125)]
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

		[XmlElement] //[XmlElement(Order=126)]
		public string v3calloutconfighash
		{
			get
			{
				return this.v3calloutconfighashField;
			}
			set
			{
				this.v3calloutconfighashField = value;
				base.RaisePropertyChanged("v3calloutconfighash");
			}
		}

		[XmlElement] //[XmlElement(Order=127)]
		public Picklist weekstartdaycode
		{
			get
			{
				return this.weekstartdaycodeField;
			}
			set
			{
				this.weekstartdaycodeField = value;
				base.RaisePropertyChanged("weekstartdaycode");
			}
		}

		[XmlElement] //[XmlElement(Order=128)]
		public CrmNumber yearstartweekcode
		{
			get
			{
				return this.yearstartweekcodeField;
			}
			set
			{
				this.yearstartweekcodeField = value;
				base.RaisePropertyChanged("yearstartweekcode");
			}
		}

		public organization()
		{
		}
	}
}