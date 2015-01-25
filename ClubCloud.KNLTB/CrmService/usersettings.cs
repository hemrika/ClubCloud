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

		[XmlElement] //[XmlElement(Order=0)]
		public CrmNumber addressbooksyncinterval
		{
			get
			{
				return this.addressbooksyncintervalField;
			}
			set
			{
				this.addressbooksyncintervalField = value;
				base.RaisePropertyChanged("addressbooksyncinterval");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public CrmNumber advancedfindstartupmode
		{
			get
			{
				return this.advancedfindstartupmodeField;
			}
			set
			{
				this.advancedfindstartupmodeField = value;
				base.RaisePropertyChanged("advancedfindstartupmode");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public CrmBoolean allowemailcredentials
		{
			get
			{
				return this.allowemailcredentialsField;
			}
			set
			{
				this.allowemailcredentialsField = value;
				base.RaisePropertyChanged("allowemailcredentials");
			}
		}

		[XmlElement] //[XmlElement(Order=3)]
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

		[XmlElement] //[XmlElement(Order=4)]
		public UniqueIdentifier businessunitid
		{
			get
			{
				return this.businessunitidField;
			}
			set
			{
				this.businessunitidField = value;
				base.RaisePropertyChanged("businessunitid");
			}
		}

		[XmlElement] //[XmlElement(Order=5)]
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

		[XmlElement] //[XmlElement(Order=6)]
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

		[XmlElement] //[XmlElement(Order=7)]
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

		[XmlElement] //[XmlElement(Order=8)]
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

		[XmlElement] //[XmlElement(Order=9)]
		public CrmNumber currencyformatcode
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

		[XmlElement] //[XmlElement(Order=10)]
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

		[XmlElement] //[XmlElement(Order=11)]
		public CrmNumber dateformatcode
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

		[XmlElement] //[XmlElement(Order=12)]
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

		[XmlElement] //[XmlElement(Order=13)]
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

		[XmlElement] //[XmlElement(Order=14)]
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

		[XmlElement] //[XmlElement(Order=15)]
		public CrmNumber defaultcalendarview
		{
			get
			{
				return this.defaultcalendarviewField;
			}
			set
			{
				this.defaultcalendarviewField = value;
				base.RaisePropertyChanged("defaultcalendarview");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public string emailpassword
		{
			get
			{
				return this.emailpasswordField;
			}
			set
			{
				this.emailpasswordField = value;
				base.RaisePropertyChanged("emailpassword");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public string emailusername
		{
			get
			{
				return this.emailusernameField;
			}
			set
			{
				this.emailusernameField = value;
				base.RaisePropertyChanged("emailusername");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public CrmNumber fullnameconventioncode
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

		[XmlElement] //[XmlElement(Order=19)]
		public CrmNumber helplanguageid
		{
			get
			{
				return this.helplanguageidField;
			}
			set
			{
				this.helplanguageidField = value;
				base.RaisePropertyChanged("helplanguageid");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public string homepagearea
		{
			get
			{
				return this.homepageareaField;
			}
			set
			{
				this.homepageareaField = value;
				base.RaisePropertyChanged("homepagearea");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public string homepagesubarea
		{
			get
			{
				return this.homepagesubareaField;
			}
			set
			{
				this.homepagesubareaField = value;
				base.RaisePropertyChanged("homepagesubarea");
			}
		}

		[XmlElement] //[XmlElement(Order=22)]
		public CrmBoolean ignoreunsolicitedemail
		{
			get
			{
				return this.ignoreunsolicitedemailField;
			}
			set
			{
				this.ignoreunsolicitedemailField = value;
				base.RaisePropertyChanged("ignoreunsolicitedemail");
			}
		}

		[XmlElement] //[XmlElement(Order=23)]
		public Picklist incomingemailfilteringmethod
		{
			get
			{
				return this.incomingemailfilteringmethodField;
			}
			set
			{
				this.incomingemailfilteringmethodField = value;
				base.RaisePropertyChanged("incomingemailfilteringmethod");
			}
		}

		[XmlElement] //[XmlElement(Order=24)]
		public CrmBoolean isduplicatedetectionenabledwhengoingonline
		{
			get
			{
				return this.isduplicatedetectionenabledwhengoingonlineField;
			}
			set
			{
				this.isduplicatedetectionenabledwhengoingonlineField = value;
				base.RaisePropertyChanged("isduplicatedetectionenabledwhengoingonline");
			}
		}

		[XmlElement] //[XmlElement(Order=25)]
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

		[XmlElement] //[XmlElement(Order=26)]
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

		[XmlElement] //[XmlElement(Order=27)]
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

		[XmlElement] //[XmlElement(Order=28)]
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

		[XmlElement] //[XmlElement(Order=29)]
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

		[XmlElement] //[XmlElement(Order=30)]
		public CrmNumber negativeformatcode
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

		[XmlElement] //[XmlElement(Order=31)]
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

		[XmlElement] //[XmlElement(Order=32)]
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

		[XmlElement] //[XmlElement(Order=33)]
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

		[XmlElement] //[XmlElement(Order=34)]
		public CrmNumber offlinesyncinterval
		{
			get
			{
				return this.offlinesyncintervalField;
			}
			set
			{
				this.offlinesyncintervalField = value;
				base.RaisePropertyChanged("offlinesyncinterval");
			}
		}

		[XmlElement] //[XmlElement(Order=35)]
		public CrmNumber outlooksyncinterval
		{
			get
			{
				return this.outlooksyncintervalField;
			}
			set
			{
				this.outlooksyncintervalField = value;
				base.RaisePropertyChanged("outlooksyncinterval");
			}
		}

		[XmlElement] //[XmlElement(Order=36)]
		public CrmNumber paginglimit
		{
			get
			{
				return this.paginglimitField;
			}
			set
			{
				this.paginglimitField = value;
				base.RaisePropertyChanged("paginglimit");
			}
		}

		[XmlElement] //[XmlElement(Order=37)]
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

		[XmlElement] //[XmlElement(Order=38)]
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

		[XmlElement] //[XmlElement(Order=39)]
		public Picklist reportscripterrors
		{
			get
			{
				return this.reportscripterrorsField;
			}
			set
			{
				this.reportscripterrorsField = value;
				base.RaisePropertyChanged("reportscripterrors");
			}
		}

		[XmlElement] //[XmlElement(Order=40)]
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

		[XmlElement] //[XmlElement(Order=41)]
		public CrmBoolean synccontactcompany
		{
			get
			{
				return this.synccontactcompanyField;
			}
			set
			{
				this.synccontactcompanyField = value;
				base.RaisePropertyChanged("synccontactcompany");
			}
		}

		[XmlElement] //[XmlElement(Order=42)]
		public Key systemuserid
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

		[XmlElement] //[XmlElement(Order=43)]
		public CrmNumber timeformatcode
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

		[XmlElement] //[XmlElement(Order=44)]
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

		[XmlElement] //[XmlElement(Order=45)]
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

		[XmlElement] //[XmlElement(Order=46)]
		public CrmNumber timezonebias
		{
			get
			{
				return this.timezonebiasField;
			}
			set
			{
				this.timezonebiasField = value;
				base.RaisePropertyChanged("timezonebias");
			}
		}

		[XmlElement] //[XmlElement(Order=47)]
		public CrmNumber timezonecode
		{
			get
			{
				return this.timezonecodeField;
			}
			set
			{
				this.timezonecodeField = value;
				base.RaisePropertyChanged("timezonecode");
			}
		}

		[XmlElement] //[XmlElement(Order=48)]
		public CrmNumber timezonedaylightbias
		{
			get
			{
				return this.timezonedaylightbiasField;
			}
			set
			{
				this.timezonedaylightbiasField = value;
				base.RaisePropertyChanged("timezonedaylightbias");
			}
		}

		[XmlElement] //[XmlElement(Order=49)]
		public CrmNumber timezonedaylightday
		{
			get
			{
				return this.timezonedaylightdayField;
			}
			set
			{
				this.timezonedaylightdayField = value;
				base.RaisePropertyChanged("timezonedaylightday");
			}
		}

		[XmlElement] //[XmlElement(Order=50)]
		public CrmNumber timezonedaylightdayofweek
		{
			get
			{
				return this.timezonedaylightdayofweekField;
			}
			set
			{
				this.timezonedaylightdayofweekField = value;
				base.RaisePropertyChanged("timezonedaylightdayofweek");
			}
		}

		[XmlElement] //[XmlElement(Order=51)]
		public CrmNumber timezonedaylighthour
		{
			get
			{
				return this.timezonedaylighthourField;
			}
			set
			{
				this.timezonedaylighthourField = value;
				base.RaisePropertyChanged("timezonedaylighthour");
			}
		}

		[XmlElement] //[XmlElement(Order=52)]
		public CrmNumber timezonedaylightminute
		{
			get
			{
				return this.timezonedaylightminuteField;
			}
			set
			{
				this.timezonedaylightminuteField = value;
				base.RaisePropertyChanged("timezonedaylightminute");
			}
		}

		[XmlElement] //[XmlElement(Order=53)]
		public CrmNumber timezonedaylightmonth
		{
			get
			{
				return this.timezonedaylightmonthField;
			}
			set
			{
				this.timezonedaylightmonthField = value;
				base.RaisePropertyChanged("timezonedaylightmonth");
			}
		}

		[XmlElement] //[XmlElement(Order=54)]
		public CrmNumber timezonedaylightsecond
		{
			get
			{
				return this.timezonedaylightsecondField;
			}
			set
			{
				this.timezonedaylightsecondField = value;
				base.RaisePropertyChanged("timezonedaylightsecond");
			}
		}

		[XmlElement] //[XmlElement(Order=55)]
		public CrmNumber timezonedaylightyear
		{
			get
			{
				return this.timezonedaylightyearField;
			}
			set
			{
				this.timezonedaylightyearField = value;
				base.RaisePropertyChanged("timezonedaylightyear");
			}
		}

		[XmlElement] //[XmlElement(Order=56)]
		public CrmNumber timezonestandardbias
		{
			get
			{
				return this.timezonestandardbiasField;
			}
			set
			{
				this.timezonestandardbiasField = value;
				base.RaisePropertyChanged("timezonestandardbias");
			}
		}

		[XmlElement] //[XmlElement(Order=57)]
		public CrmNumber timezonestandardday
		{
			get
			{
				return this.timezonestandarddayField;
			}
			set
			{
				this.timezonestandarddayField = value;
				base.RaisePropertyChanged("timezonestandardday");
			}
		}

		[XmlElement] //[XmlElement(Order=58)]
		public CrmNumber timezonestandarddayofweek
		{
			get
			{
				return this.timezonestandarddayofweekField;
			}
			set
			{
				this.timezonestandarddayofweekField = value;
				base.RaisePropertyChanged("timezonestandarddayofweek");
			}
		}

		[XmlElement] //[XmlElement(Order=59)]
		public CrmNumber timezonestandardhour
		{
			get
			{
				return this.timezonestandardhourField;
			}
			set
			{
				this.timezonestandardhourField = value;
				base.RaisePropertyChanged("timezonestandardhour");
			}
		}

		[XmlElement] //[XmlElement(Order=60)]
		public CrmNumber timezonestandardminute
		{
			get
			{
				return this.timezonestandardminuteField;
			}
			set
			{
				this.timezonestandardminuteField = value;
				base.RaisePropertyChanged("timezonestandardminute");
			}
		}

		[XmlElement] //[XmlElement(Order=61)]
		public CrmNumber timezonestandardmonth
		{
			get
			{
				return this.timezonestandardmonthField;
			}
			set
			{
				this.timezonestandardmonthField = value;
				base.RaisePropertyChanged("timezonestandardmonth");
			}
		}

		[XmlElement] //[XmlElement(Order=62)]
		public CrmNumber timezonestandardsecond
		{
			get
			{
				return this.timezonestandardsecondField;
			}
			set
			{
				this.timezonestandardsecondField = value;
				base.RaisePropertyChanged("timezonestandardsecond");
			}
		}

		[XmlElement] //[XmlElement(Order=63)]
		public CrmNumber timezonestandardyear
		{
			get
			{
				return this.timezonestandardyearField;
			}
			set
			{
				this.timezonestandardyearField = value;
				base.RaisePropertyChanged("timezonestandardyear");
			}
		}

		[XmlElement] //[XmlElement(Order=64)]
		public CrmNumber trackingtokenid
		{
			get
			{
				return this.trackingtokenidField;
			}
			set
			{
				this.trackingtokenidField = value;
				base.RaisePropertyChanged("trackingtokenid");
			}
		}

		[XmlElement] //[XmlElement(Order=65)]
		public Lookup transactioncurrencyid
		{
			get
			{
				return this.transactioncurrencyidField;
			}
			set
			{
				this.transactioncurrencyidField = value;
				base.RaisePropertyChanged("transactioncurrencyid");
			}
		}

		[XmlElement] //[XmlElement(Order=66)]
		public CrmNumber uilanguageid
		{
			get
			{
				return this.uilanguageidField;
			}
			set
			{
				this.uilanguageidField = value;
				base.RaisePropertyChanged("uilanguageid");
			}
		}

		[XmlElement] //[XmlElement(Order=67)]
		public CrmBoolean usecrmformforappointment
		{
			get
			{
				return this.usecrmformforappointmentField;
			}
			set
			{
				this.usecrmformforappointmentField = value;
				base.RaisePropertyChanged("usecrmformforappointment");
			}
		}

		[XmlElement] //[XmlElement(Order=68)]
		public CrmBoolean usecrmformforcontact
		{
			get
			{
				return this.usecrmformforcontactField;
			}
			set
			{
				this.usecrmformforcontactField = value;
				base.RaisePropertyChanged("usecrmformforcontact");
			}
		}

		[XmlElement] //[XmlElement(Order=69)]
		public CrmBoolean usecrmformforemail
		{
			get
			{
				return this.usecrmformforemailField;
			}
			set
			{
				this.usecrmformforemailField = value;
				base.RaisePropertyChanged("usecrmformforemail");
			}
		}

		[XmlElement] //[XmlElement(Order=70)]
		public CrmBoolean usecrmformfortask
		{
			get
			{
				return this.usecrmformfortaskField;
			}
			set
			{
				this.usecrmformfortaskField = value;
				base.RaisePropertyChanged("usecrmformfortask");
			}
		}

		[XmlElement] //[XmlElement(Order=71)]
		public CrmBoolean useimagestrips
		{
			get
			{
				return this.useimagestripsField;
			}
			set
			{
				this.useimagestripsField = value;
				base.RaisePropertyChanged("useimagestrips");
			}
		}

		[XmlElement] //[XmlElement(Order=72)]
		public string userprofile
		{
			get
			{
				return this.userprofileField;
			}
			set
			{
				this.userprofileField = value;
				base.RaisePropertyChanged("userprofile");
			}
		}

		[XmlElement] //[XmlElement(Order=73)]
		public string workdaystarttime
		{
			get
			{
				return this.workdaystarttimeField;
			}
			set
			{
				this.workdaystarttimeField = value;
				base.RaisePropertyChanged("workdaystarttime");
			}
		}

		[XmlElement] //[XmlElement(Order=74)]
		public string workdaystoptime
		{
			get
			{
				return this.workdaystoptimeField;
			}
			set
			{
				this.workdaystoptimeField = value;
				base.RaisePropertyChanged("workdaystoptime");
			}
		}

		public usersettings()
		{
		}
	}
}