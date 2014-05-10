using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class usersettings : BusinessEntity
	{
		private CrmNumber addressbooksyncintervalField;
		private CrmNumber advancedfindstartupmodeField;
		private CrmBoolean allowemailcredentialsField;
		private string amdesignatorField;
		private UniqueIdentifier businessunitidField;
		private CrmNumber calendartypeField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber currencydecimalprecisionField;
		private CrmNumber currencyformatcodeField;
		private string currencysymbolField;
		private CrmNumber dateformatcodeField;
		private string dateformatstringField;
		private string dateseparatorField;
		private string decimalsymbolField;
		private CrmNumber defaultcalendarviewField;
		private string emailpasswordField;
		private string emailusernameField;
		private CrmNumber fullnameconventioncodeField;
		private CrmNumber helplanguageidField;
		private string homepageareaField;
		private string homepagesubareaField;
		private CrmBoolean ignoreunsolicitedemailField;
		private Picklist incomingemailfilteringmethodField;
		private CrmBoolean isduplicatedetectionenabledwhengoingonlineField;
		private CrmNumber localeidField;
		private CrmNumber longdateformatcodeField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmNumber negativecurrencyformatcodeField;
		private CrmNumber negativeformatcodeField;
		private CrmNumber nexttrackingnumberField;
		private string numbergroupformatField;
		private string numberseparatorField;
		private CrmNumber offlinesyncintervalField;
		private CrmNumber outlooksyncintervalField;
		private CrmNumber paginglimitField;
		private string pmdesignatorField;
		private CrmNumber pricingdecimalprecisionField;
		private Picklist reportscripterrorsField;
		private CrmBoolean showweeknumberField;
		private CrmBoolean synccontactcompanyField;
		private Key systemuseridField;
		private CrmNumber timeformatcodeField;
		private string timeformatstringField;
		private string timeseparatorField;
		private CrmNumber timezonebiasField;
		private CrmNumber timezonecodeField;
		private CrmNumber timezonedaylightbiasField;
		private CrmNumber timezonedaylightdayField;
		private CrmNumber timezonedaylightdayofweekField;
		private CrmNumber timezonedaylighthourField;
		private CrmNumber timezonedaylightminuteField;
		private CrmNumber timezonedaylightmonthField;
		private CrmNumber timezonedaylightsecondField;
		private CrmNumber timezonedaylightyearField;
		private CrmNumber timezonestandardbiasField;
		private CrmNumber timezonestandarddayField;
		private CrmNumber timezonestandarddayofweekField;
		private CrmNumber timezonestandardhourField;
		private CrmNumber timezonestandardminuteField;
		private CrmNumber timezonestandardmonthField;
		private CrmNumber timezonestandardsecondField;
		private CrmNumber timezonestandardyearField;
		private CrmNumber trackingtokenidField;
		private Lookup transactioncurrencyidField;
		private CrmNumber uilanguageidField;
		private CrmBoolean usecrmformforappointmentField;
		private CrmBoolean usecrmformforcontactField;
		private CrmBoolean usecrmformforemailField;
		private CrmBoolean usecrmformfortaskField;
		private CrmBoolean useimagestripsField;
		private string userprofileField;
		private string workdaystarttimeField;
		private string workdaystoptimeField;
		public CrmNumber addressbooksyncinterval
		{
			get
			{
				return this.addressbooksyncintervalField;
			}
			set
			{
				this.addressbooksyncintervalField = value;
			}
		}
		public CrmNumber advancedfindstartupmode
		{
			get
			{
				return this.advancedfindstartupmodeField;
			}
			set
			{
				this.advancedfindstartupmodeField = value;
			}
		}
		public CrmBoolean allowemailcredentials
		{
			get
			{
				return this.allowemailcredentialsField;
			}
			set
			{
				this.allowemailcredentialsField = value;
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
		public UniqueIdentifier businessunitid
		{
			get
			{
				return this.businessunitidField;
			}
			set
			{
				this.businessunitidField = value;
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
		public CrmNumber currencyformatcode
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
		public CrmNumber dateformatcode
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
		public CrmNumber defaultcalendarview
		{
			get
			{
				return this.defaultcalendarviewField;
			}
			set
			{
				this.defaultcalendarviewField = value;
			}
		}
		public string emailpassword
		{
			get
			{
				return this.emailpasswordField;
			}
			set
			{
				this.emailpasswordField = value;
			}
		}
		public string emailusername
		{
			get
			{
				return this.emailusernameField;
			}
			set
			{
				this.emailusernameField = value;
			}
		}
		public CrmNumber fullnameconventioncode
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
		public CrmNumber helplanguageid
		{
			get
			{
				return this.helplanguageidField;
			}
			set
			{
				this.helplanguageidField = value;
			}
		}
		public string homepagearea
		{
			get
			{
				return this.homepageareaField;
			}
			set
			{
				this.homepageareaField = value;
			}
		}
		public string homepagesubarea
		{
			get
			{
				return this.homepagesubareaField;
			}
			set
			{
				this.homepagesubareaField = value;
			}
		}
		public CrmBoolean ignoreunsolicitedemail
		{
			get
			{
				return this.ignoreunsolicitedemailField;
			}
			set
			{
				this.ignoreunsolicitedemailField = value;
			}
		}
		public Picklist incomingemailfilteringmethod
		{
			get
			{
				return this.incomingemailfilteringmethodField;
			}
			set
			{
				this.incomingemailfilteringmethodField = value;
			}
		}
		public CrmBoolean isduplicatedetectionenabledwhengoingonline
		{
			get
			{
				return this.isduplicatedetectionenabledwhengoingonlineField;
			}
			set
			{
				this.isduplicatedetectionenabledwhengoingonlineField = value;
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
		public CrmNumber negativeformatcode
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
		public CrmNumber offlinesyncinterval
		{
			get
			{
				return this.offlinesyncintervalField;
			}
			set
			{
				this.offlinesyncintervalField = value;
			}
		}
		public CrmNumber outlooksyncinterval
		{
			get
			{
				return this.outlooksyncintervalField;
			}
			set
			{
				this.outlooksyncintervalField = value;
			}
		}
		public CrmNumber paginglimit
		{
			get
			{
				return this.paginglimitField;
			}
			set
			{
				this.paginglimitField = value;
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
		public Picklist reportscripterrors
		{
			get
			{
				return this.reportscripterrorsField;
			}
			set
			{
				this.reportscripterrorsField = value;
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
		public CrmBoolean synccontactcompany
		{
			get
			{
				return this.synccontactcompanyField;
			}
			set
			{
				this.synccontactcompanyField = value;
			}
		}
		public Key systemuserid
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
		public CrmNumber timeformatcode
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
		public CrmNumber timezonebias
		{
			get
			{
				return this.timezonebiasField;
			}
			set
			{
				this.timezonebiasField = value;
			}
		}
		public CrmNumber timezonecode
		{
			get
			{
				return this.timezonecodeField;
			}
			set
			{
				this.timezonecodeField = value;
			}
		}
		public CrmNumber timezonedaylightbias
		{
			get
			{
				return this.timezonedaylightbiasField;
			}
			set
			{
				this.timezonedaylightbiasField = value;
			}
		}
		public CrmNumber timezonedaylightday
		{
			get
			{
				return this.timezonedaylightdayField;
			}
			set
			{
				this.timezonedaylightdayField = value;
			}
		}
		public CrmNumber timezonedaylightdayofweek
		{
			get
			{
				return this.timezonedaylightdayofweekField;
			}
			set
			{
				this.timezonedaylightdayofweekField = value;
			}
		}
		public CrmNumber timezonedaylighthour
		{
			get
			{
				return this.timezonedaylighthourField;
			}
			set
			{
				this.timezonedaylighthourField = value;
			}
		}
		public CrmNumber timezonedaylightminute
		{
			get
			{
				return this.timezonedaylightminuteField;
			}
			set
			{
				this.timezonedaylightminuteField = value;
			}
		}
		public CrmNumber timezonedaylightmonth
		{
			get
			{
				return this.timezonedaylightmonthField;
			}
			set
			{
				this.timezonedaylightmonthField = value;
			}
		}
		public CrmNumber timezonedaylightsecond
		{
			get
			{
				return this.timezonedaylightsecondField;
			}
			set
			{
				this.timezonedaylightsecondField = value;
			}
		}
		public CrmNumber timezonedaylightyear
		{
			get
			{
				return this.timezonedaylightyearField;
			}
			set
			{
				this.timezonedaylightyearField = value;
			}
		}
		public CrmNumber timezonestandardbias
		{
			get
			{
				return this.timezonestandardbiasField;
			}
			set
			{
				this.timezonestandardbiasField = value;
			}
		}
		public CrmNumber timezonestandardday
		{
			get
			{
				return this.timezonestandarddayField;
			}
			set
			{
				this.timezonestandarddayField = value;
			}
		}
		public CrmNumber timezonestandarddayofweek
		{
			get
			{
				return this.timezonestandarddayofweekField;
			}
			set
			{
				this.timezonestandarddayofweekField = value;
			}
		}
		public CrmNumber timezonestandardhour
		{
			get
			{
				return this.timezonestandardhourField;
			}
			set
			{
				this.timezonestandardhourField = value;
			}
		}
		public CrmNumber timezonestandardminute
		{
			get
			{
				return this.timezonestandardminuteField;
			}
			set
			{
				this.timezonestandardminuteField = value;
			}
		}
		public CrmNumber timezonestandardmonth
		{
			get
			{
				return this.timezonestandardmonthField;
			}
			set
			{
				this.timezonestandardmonthField = value;
			}
		}
		public CrmNumber timezonestandardsecond
		{
			get
			{
				return this.timezonestandardsecondField;
			}
			set
			{
				this.timezonestandardsecondField = value;
			}
		}
		public CrmNumber timezonestandardyear
		{
			get
			{
				return this.timezonestandardyearField;
			}
			set
			{
				this.timezonestandardyearField = value;
			}
		}
		public CrmNumber trackingtokenid
		{
			get
			{
				return this.trackingtokenidField;
			}
			set
			{
				this.trackingtokenidField = value;
			}
		}
		public Lookup transactioncurrencyid
		{
			get
			{
				return this.transactioncurrencyidField;
			}
			set
			{
				this.transactioncurrencyidField = value;
			}
		}
		public CrmNumber uilanguageid
		{
			get
			{
				return this.uilanguageidField;
			}
			set
			{
				this.uilanguageidField = value;
			}
		}
		public CrmBoolean usecrmformforappointment
		{
			get
			{
				return this.usecrmformforappointmentField;
			}
			set
			{
				this.usecrmformforappointmentField = value;
			}
		}
		public CrmBoolean usecrmformforcontact
		{
			get
			{
				return this.usecrmformforcontactField;
			}
			set
			{
				this.usecrmformforcontactField = value;
			}
		}
		public CrmBoolean usecrmformforemail
		{
			get
			{
				return this.usecrmformforemailField;
			}
			set
			{
				this.usecrmformforemailField = value;
			}
		}
		public CrmBoolean usecrmformfortask
		{
			get
			{
				return this.usecrmformfortaskField;
			}
			set
			{
				this.usecrmformfortaskField = value;
			}
		}
		public CrmBoolean useimagestrips
		{
			get
			{
				return this.useimagestripsField;
			}
			set
			{
				this.useimagestripsField = value;
			}
		}
		public string userprofile
		{
			get
			{
				return this.userprofileField;
			}
			set
			{
				this.userprofileField = value;
			}
		}
		public string workdaystarttime
		{
			get
			{
				return this.workdaystarttimeField;
			}
			set
			{
				this.workdaystarttimeField = value;
			}
		}
		public string workdaystoptime
		{
			get
			{
				return this.workdaystoptimeField;
			}
			set
			{
				this.workdaystoptimeField = value;
			}
		}
	}
}
