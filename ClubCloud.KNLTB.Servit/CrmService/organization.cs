using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
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
		public Lookup acknowledgementtemplateid
		{
			get
			{
				return this.acknowledgementtemplateidField;
			}
			set
			{
				this.acknowledgementtemplateidField = value;
			}
		}
		public CrmBoolean allowaddressbooksyncs
		{
			get
			{
				return this.allowaddressbooksyncsField;
			}
			set
			{
				this.allowaddressbooksyncsField = value;
			}
		}
		public CrmBoolean allowautoresponsecreation
		{
			get
			{
				return this.allowautoresponsecreationField;
			}
			set
			{
				this.allowautoresponsecreationField = value;
			}
		}
		public CrmBoolean allowautounsubscribe
		{
			get
			{
				return this.allowautounsubscribeField;
			}
			set
			{
				this.allowautounsubscribeField = value;
			}
		}
		public CrmBoolean allowautounsubscribeacknowledgement
		{
			get
			{
				return this.allowautounsubscribeacknowledgementField;
			}
			set
			{
				this.allowautounsubscribeacknowledgementField = value;
			}
		}
		public CrmBoolean allowmarketingemailexecution
		{
			get
			{
				return this.allowmarketingemailexecutionField;
			}
			set
			{
				this.allowmarketingemailexecutionField = value;
			}
		}
		public CrmBoolean allowofflinescheduledsyncs
		{
			get
			{
				return this.allowofflinescheduledsyncsField;
			}
			set
			{
				this.allowofflinescheduledsyncsField = value;
			}
		}
		public CrmBoolean allowoutlookscheduledsyncs
		{
			get
			{
				return this.allowoutlookscheduledsyncsField;
			}
			set
			{
				this.allowoutlookscheduledsyncsField = value;
			}
		}
		public CrmBoolean allowunresolvedpartiesonemailsend
		{
			get
			{
				return this.allowunresolvedpartiesonemailsendField;
			}
			set
			{
				this.allowunresolvedpartiesonemailsendField = value;
			}
		}
		public CrmBoolean allowwebexcelexport
		{
			get
			{
				return this.allowwebexcelexportField;
			}
			set
			{
				this.allowwebexcelexportField = value;
			}
		}
		public string amdesignator
		{
			get
			{
				return this.amdesignatorField;
			}
			set
			{
				this.amdesignatorField = value;
			}
		}
		public Lookup basecurrencyid
		{
			get
			{
				return this.basecurrencyidField;
			}
			set
			{
				this.basecurrencyidField = value;
			}
		}
		public string blockedattachments
		{
			get
			{
				return this.blockedattachmentsField;
			}
			set
			{
				this.blockedattachmentsField = value;
			}
		}
		public string bulkoperationprefix
		{
			get
			{
				return this.bulkoperationprefixField;
			}
			set
			{
				this.bulkoperationprefixField = value;
			}
		}
		public UniqueIdentifier businessclosurecalendarid
		{
			get
			{
				return this.businessclosurecalendaridField;
			}
			set
			{
				this.businessclosurecalendaridField = value;
			}
		}
		public CrmNumber calendartype
		{
			get
			{
				return this.calendartypeField;
			}
			set
			{
				this.calendartypeField = value;
			}
		}
		public string campaignprefix
		{
			get
			{
				return this.campaignprefixField;
			}
			set
			{
				this.campaignprefixField = value;
			}
		}
		public string caseprefix
		{
			get
			{
				return this.caseprefixField;
			}
			set
			{
				this.caseprefixField = value;
			}
		}
		public string contractprefix
		{
			get
			{
				return this.contractprefixField;
			}
			set
			{
				this.contractprefixField = value;
			}
		}
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
		public CrmNumber currencydecimalprecision
		{
			get
			{
				return this.currencydecimalprecisionField;
			}
			set
			{
				this.currencydecimalprecisionField = value;
			}
		}
		public Picklist currencydisplayoption
		{
			get
			{
				return this.currencydisplayoptionField;
			}
			set
			{
				this.currencydisplayoptionField = value;
			}
		}
		public Picklist currencyformatcode
		{
			get
			{
				return this.currencyformatcodeField;
			}
			set
			{
				this.currencyformatcodeField = value;
			}
		}
		public string currencysymbol
		{
			get
			{
				return this.currencysymbolField;
			}
			set
			{
				this.currencysymbolField = value;
			}
		}
		public CrmNumber currentbulkoperationnumber
		{
			get
			{
				return this.currentbulkoperationnumberField;
			}
			set
			{
				this.currentbulkoperationnumberField = value;
			}
		}
		public CrmNumber currentcampaignnumber
		{
			get
			{
				return this.currentcampaignnumberField;
			}
			set
			{
				this.currentcampaignnumberField = value;
			}
		}
		public CrmNumber currentcasenumber
		{
			get
			{
				return this.currentcasenumberField;
			}
			set
			{
				this.currentcasenumberField = value;
			}
		}
		public CrmNumber currentcontractnumber
		{
			get
			{
				return this.currentcontractnumberField;
			}
			set
			{
				this.currentcontractnumberField = value;
			}
		}
		public CrmNumber currentimportsequencenumber
		{
			get
			{
				return this.currentimportsequencenumberField;
			}
			set
			{
				this.currentimportsequencenumberField = value;
			}
		}
		public CrmNumber currentinvoicenumber
		{
			get
			{
				return this.currentinvoicenumberField;
			}
			set
			{
				this.currentinvoicenumberField = value;
			}
		}
		public CrmNumber currentkbnumber
		{
			get
			{
				return this.currentkbnumberField;
			}
			set
			{
				this.currentkbnumberField = value;
			}
		}
		public CrmNumber currentordernumber
		{
			get
			{
				return this.currentordernumberField;
			}
			set
			{
				this.currentordernumberField = value;
			}
		}
		public CrmNumber currentparsedtablenumber
		{
			get
			{
				return this.currentparsedtablenumberField;
			}
			set
			{
				this.currentparsedtablenumberField = value;
			}
		}
		public CrmNumber currentquotenumber
		{
			get
			{
				return this.currentquotenumberField;
			}
			set
			{
				this.currentquotenumberField = value;
			}
		}
		public Picklist dateformatcode
		{
			get
			{
				return this.dateformatcodeField;
			}
			set
			{
				this.dateformatcodeField = value;
			}
		}
		public string dateformatstring
		{
			get
			{
				return this.dateformatstringField;
			}
			set
			{
				this.dateformatstringField = value;
			}
		}
		public string dateseparator
		{
			get
			{
				return this.dateseparatorField;
			}
			set
			{
				this.dateseparatorField = value;
			}
		}
		public string decimalsymbol
		{
			get
			{
				return this.decimalsymbolField;
			}
			set
			{
				this.decimalsymbolField = value;
			}
		}
		public string disabledreason
		{
			get
			{
				return this.disabledreasonField;
			}
			set
			{
				this.disabledreasonField = value;
			}
		}
		public CrmNumber emailsendpollingperiod
		{
			get
			{
				return this.emailsendpollingperiodField;
			}
			set
			{
				this.emailsendpollingperiodField = value;
			}
		}
		public CrmBoolean enablepricingoncreate
		{
			get
			{
				return this.enablepricingoncreateField;
			}
			set
			{
				this.enablepricingoncreateField = value;
			}
		}
		public string featureset
		{
			get
			{
				return this.featuresetField;
			}
			set
			{
				this.featuresetField = value;
			}
		}
		public CrmDateTime fiscalcalendarstart
		{
			get
			{
				return this.fiscalcalendarstartField;
			}
			set
			{
				this.fiscalcalendarstartField = value;
			}
		}
		public string fiscalperiodformat
		{
			get
			{
				return this.fiscalperiodformatField;
			}
			set
			{
				this.fiscalperiodformatField = value;
			}
		}
		public CrmNumber fiscalperiodtype
		{
			get
			{
				return this.fiscalperiodtypeField;
			}
			set
			{
				this.fiscalperiodtypeField = value;
			}
		}
		public CrmBoolean fiscalsettingsupdated
		{
			get
			{
				return this.fiscalsettingsupdatedField;
			}
			set
			{
				this.fiscalsettingsupdatedField = value;
			}
		}
		public CrmNumber fiscalyeardisplaycode
		{
			get
			{
				return this.fiscalyeardisplaycodeField;
			}
			set
			{
				this.fiscalyeardisplaycodeField = value;
			}
		}
		public string fiscalyearformat
		{
			get
			{
				return this.fiscalyearformatField;
			}
			set
			{
				this.fiscalyearformatField = value;
			}
		}
		public string fiscalyearperiodconnect
		{
			get
			{
				return this.fiscalyearperiodconnectField;
			}
			set
			{
				this.fiscalyearperiodconnectField = value;
			}
		}
		public Picklist fullnameconventioncode
		{
			get
			{
				return this.fullnameconventioncodeField;
			}
			set
			{
				this.fullnameconventioncodeField = value;
			}
		}
		public CrmBoolean grantaccesstonetworkservice
		{
			get
			{
				return this.grantaccesstonetworkserviceField;
			}
			set
			{
				this.grantaccesstonetworkserviceField = value;
			}
		}
		public CrmBoolean ignoreinternalemail
		{
			get
			{
				return this.ignoreinternalemailField;
			}
			set
			{
				this.ignoreinternalemailField = value;
			}
		}
		public UniqueIdentifier integrationuserid
		{
			get
			{
				return this.integrationuseridField;
			}
			set
			{
				this.integrationuseridField = value;
			}
		}
		public string invoiceprefix
		{
			get
			{
				return this.invoiceprefixField;
			}
			set
			{
				this.invoiceprefixField = value;
			}
		}
		public CrmBoolean isappmode
		{
			get
			{
				return this.isappmodeField;
			}
			set
			{
				this.isappmodeField = value;
			}
		}
		public CrmBoolean isdisabled
		{
			get
			{
				return this.isdisabledField;
			}
			set
			{
				this.isdisabledField = value;
			}
		}
		public CrmBoolean isduplicatedetectionenabled
		{
			get
			{
				return this.isduplicatedetectionenabledField;
			}
			set
			{
				this.isduplicatedetectionenabledField = value;
			}
		}
		public CrmBoolean isduplicatedetectionenabledforimport
		{
			get
			{
				return this.isduplicatedetectionenabledforimportField;
			}
			set
			{
				this.isduplicatedetectionenabledforimportField = value;
			}
		}
		public CrmBoolean isduplicatedetectionenabledforofflinesync
		{
			get
			{
				return this.isduplicatedetectionenabledforofflinesyncField;
			}
			set
			{
				this.isduplicatedetectionenabledforofflinesyncField = value;
			}
		}
		public CrmBoolean isduplicatedetectionenabledforonlinecreateupdate
		{
			get
			{
				return this.isduplicatedetectionenabledforonlinecreateupdateField;
			}
			set
			{
				this.isduplicatedetectionenabledforonlinecreateupdateField = value;
			}
		}
		public CrmBoolean isfiscalperiodmonthbased
		{
			get
			{
				return this.isfiscalperiodmonthbasedField;
			}
			set
			{
				this.isfiscalperiodmonthbasedField = value;
			}
		}
		public CrmBoolean ispresenceenabled
		{
			get
			{
				return this.ispresenceenabledField;
			}
			set
			{
				this.ispresenceenabledField = value;
			}
		}
		public CrmBoolean isregistered
		{
			get
			{
				return this.isregisteredField;
			}
			set
			{
				this.isregisteredField = value;
			}
		}
		public CrmBoolean issopintegrationenabled
		{
			get
			{
				return this.issopintegrationenabledField;
			}
			set
			{
				this.issopintegrationenabledField = value;
			}
		}
		public Picklist isvintegrationcode
		{
			get
			{
				return this.isvintegrationcodeField;
			}
			set
			{
				this.isvintegrationcodeField = value;
			}
		}
		public string kbprefix
		{
			get
			{
				return this.kbprefixField;
			}
			set
			{
				this.kbprefixField = value;
			}
		}
		public CrmNumber languagecode
		{
			get
			{
				return this.languagecodeField;
			}
			set
			{
				this.languagecodeField = value;
			}
		}
		public CrmNumber localeid
		{
			get
			{
				return this.localeidField;
			}
			set
			{
				this.localeidField = value;
			}
		}
		public CrmNumber longdateformatcode
		{
			get
			{
				return this.longdateformatcodeField;
			}
			set
			{
				this.longdateformatcodeField = value;
			}
		}
		public CrmNumber maxappointmentdurationdays
		{
			get
			{
				return this.maxappointmentdurationdaysField;
			}
			set
			{
				this.maxappointmentdurationdaysField = value;
			}
		}
		public CrmNumber maximumtrackingnumber
		{
			get
			{
				return this.maximumtrackingnumberField;
			}
			set
			{
				this.maximumtrackingnumberField = value;
			}
		}
		public CrmNumber maxrecordsforexporttoexcel
		{
			get
			{
				return this.maxrecordsforexporttoexcelField;
			}
			set
			{
				this.maxrecordsforexporttoexcelField = value;
			}
		}
		public CrmNumber maxuploadfilesize
		{
			get
			{
				return this.maxuploadfilesizeField;
			}
			set
			{
				this.maxuploadfilesizeField = value;
			}
		}
		public CrmNumber minaddressbooksyncinterval
		{
			get
			{
				return this.minaddressbooksyncintervalField;
			}
			set
			{
				this.minaddressbooksyncintervalField = value;
			}
		}
		public CrmNumber minofflinesyncinterval
		{
			get
			{
				return this.minofflinesyncintervalField;
			}
			set
			{
				this.minofflinesyncintervalField = value;
			}
		}
		public CrmNumber minoutlooksyncinterval
		{
			get
			{
				return this.minoutlooksyncintervalField;
			}
			set
			{
				this.minoutlooksyncintervalField = value;
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
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}
		public CrmNumber negativecurrencyformatcode
		{
			get
			{
				return this.negativecurrencyformatcodeField;
			}
			set
			{
				this.negativecurrencyformatcodeField = value;
			}
		}
		public Picklist negativeformatcode
		{
			get
			{
				return this.negativeformatcodeField;
			}
			set
			{
				this.negativeformatcodeField = value;
			}
		}
		public CrmNumber nexttrackingnumber
		{
			get
			{
				return this.nexttrackingnumberField;
			}
			set
			{
				this.nexttrackingnumberField = value;
			}
		}
		public string numberformat
		{
			get
			{
				return this.numberformatField;
			}
			set
			{
				this.numberformatField = value;
			}
		}
		public string numbergroupformat
		{
			get
			{
				return this.numbergroupformatField;
			}
			set
			{
				this.numbergroupformatField = value;
			}
		}
		public string numberseparator
		{
			get
			{
				return this.numberseparatorField;
			}
			set
			{
				this.numberseparatorField = value;
			}
		}
		public string orderprefix
		{
			get
			{
				return this.orderprefixField;
			}
			set
			{
				this.orderprefixField = value;
			}
		}
		public Key organizationid
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
		public string orgdborgsettings
		{
			get
			{
				return this.orgdborgsettingsField;
			}
			set
			{
				this.orgdborgsettingsField = value;
			}
		}
		public string parsedtablecolumnprefix
		{
			get
			{
				return this.parsedtablecolumnprefixField;
			}
			set
			{
				this.parsedtablecolumnprefixField = value;
			}
		}
		public string parsedtableprefix
		{
			get
			{
				return this.parsedtableprefixField;
			}
			set
			{
				this.parsedtableprefixField = value;
			}
		}
		public string picture
		{
			get
			{
				return this.pictureField;
			}
			set
			{
				this.pictureField = value;
			}
		}
		public string pmdesignator
		{
			get
			{
				return this.pmdesignatorField;
			}
			set
			{
				this.pmdesignatorField = value;
			}
		}
		public CrmNumber pricingdecimalprecision
		{
			get
			{
				return this.pricingdecimalprecisionField;
			}
			set
			{
				this.pricingdecimalprecisionField = value;
			}
		}
		public UniqueIdentifier privilegeusergroupid
		{
			get
			{
				return this.privilegeusergroupidField;
			}
			set
			{
				this.privilegeusergroupidField = value;
			}
		}
		public UniqueIdentifier privreportinggroupid
		{
			get
			{
				return this.privreportinggroupidField;
			}
			set
			{
				this.privreportinggroupidField = value;
			}
		}
		public string privreportinggroupname
		{
			get
			{
				return this.privreportinggroupnameField;
			}
			set
			{
				this.privreportinggroupnameField = value;
			}
		}
		public string quoteprefix
		{
			get
			{
				return this.quoteprefixField;
			}
			set
			{
				this.quoteprefixField = value;
			}
		}
		public string referencesitemapxml
		{
			get
			{
				return this.referencesitemapxmlField;
			}
			set
			{
				this.referencesitemapxmlField = value;
			}
		}
		public CrmBoolean rendersecureiframeforemail
		{
			get
			{
				return this.rendersecureiframeforemailField;
			}
			set
			{
				this.rendersecureiframeforemailField = value;
			}
		}
		public UniqueIdentifier reportinggroupid
		{
			get
			{
				return this.reportinggroupidField;
			}
			set
			{
				this.reportinggroupidField = value;
			}
		}
		public string reportinggroupname
		{
			get
			{
				return this.reportinggroupnameField;
			}
			set
			{
				this.reportinggroupnameField = value;
			}
		}
		public string schemanameprefix
		{
			get
			{
				return this.schemanameprefixField;
			}
			set
			{
				this.schemanameprefixField = value;
			}
		}
		public CrmBoolean sharetopreviousowneronassign
		{
			get
			{
				return this.sharetopreviousowneronassignField;
			}
			set
			{
				this.sharetopreviousowneronassignField = value;
			}
		}
		public CrmBoolean showweeknumber
		{
			get
			{
				return this.showweeknumberField;
			}
			set
			{
				this.showweeknumberField = value;
			}
		}
		public string sitemapxml
		{
			get
			{
				return this.sitemapxmlField;
			}
			set
			{
				this.sitemapxmlField = value;
			}
		}
		public CrmNumber sortid
		{
			get
			{
				return this.sortidField;
			}
			set
			{
				this.sortidField = value;
			}
		}
		public UniqueIdentifier sqlaccessgroupid
		{
			get
			{
				return this.sqlaccessgroupidField;
			}
			set
			{
				this.sqlaccessgroupidField = value;
			}
		}
		public string sqlaccessgroupname
		{
			get
			{
				return this.sqlaccessgroupnameField;
			}
			set
			{
				this.sqlaccessgroupnameField = value;
			}
		}
		public CrmBoolean sqmenabled
		{
			get
			{
				return this.sqmenabledField;
			}
			set
			{
				this.sqmenabledField = value;
			}
		}
		public UniqueIdentifier supportuserid
		{
			get
			{
				return this.supportuseridField;
			}
			set
			{
				this.supportuseridField = value;
			}
		}
		public UniqueIdentifier systemuserid
		{
			get
			{
				return this.systemuseridField;
			}
			set
			{
				this.systemuseridField = value;
			}
		}
		public CrmNumber tagmaxaggressivecycles
		{
			get
			{
				return this.tagmaxaggressivecyclesField;
			}
			set
			{
				this.tagmaxaggressivecyclesField = value;
			}
		}
		public CrmNumber tagpollingperiod
		{
			get
			{
				return this.tagpollingperiodField;
			}
			set
			{
				this.tagpollingperiodField = value;
			}
		}
		public Picklist timeformatcode
		{
			get
			{
				return this.timeformatcodeField;
			}
			set
			{
				this.timeformatcodeField = value;
			}
		}
		public string timeformatstring
		{
			get
			{
				return this.timeformatstringField;
			}
			set
			{
				this.timeformatstringField = value;
			}
		}
		public string timeseparator
		{
			get
			{
				return this.timeseparatorField;
			}
			set
			{
				this.timeseparatorField = value;
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
		public CrmNumber tokenexpiry
		{
			get
			{
				return this.tokenexpiryField;
			}
			set
			{
				this.tokenexpiryField = value;
			}
		}
		public string tokenkey
		{
			get
			{
				return this.tokenkeyField;
			}
			set
			{
				this.tokenkeyField = value;
			}
		}
		public string trackingprefix
		{
			get
			{
				return this.trackingprefixField;
			}
			set
			{
				this.trackingprefixField = value;
			}
		}
		public CrmNumber trackingtokenidbase
		{
			get
			{
				return this.trackingtokenidbaseField;
			}
			set
			{
				this.trackingtokenidbaseField = value;
			}
		}
		public CrmNumber trackingtokeniddigits
		{
			get
			{
				return this.trackingtokeniddigitsField;
			}
			set
			{
				this.trackingtokeniddigitsField = value;
			}
		}
		public CrmNumber uniquespecifierlength
		{
			get
			{
				return this.uniquespecifierlengthField;
			}
			set
			{
				this.uniquespecifierlengthField = value;
			}
		}
		public UniqueIdentifier usergroupid
		{
			get
			{
				return this.usergroupidField;
			}
			set
			{
				this.usergroupidField = value;
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
		public string v3calloutconfighash
		{
			get
			{
				return this.v3calloutconfighashField;
			}
			set
			{
				this.v3calloutconfighashField = value;
			}
		}
		public Picklist weekstartdaycode
		{
			get
			{
				return this.weekstartdaycodeField;
			}
			set
			{
				this.weekstartdaycodeField = value;
			}
		}
		public CrmNumber yearstartweekcode
		{
			get
			{
				return this.yearstartweekcodeField;
			}
			set
			{
				this.yearstartweekcodeField = value;
			}
		}
	}
}
