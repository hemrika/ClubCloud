using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class lead : BusinessEntity
	{
		private Key address1_addressidField;
		private Picklist address1_addresstypecodeField;
		private string address1_cityField;
		private string address1_countryField;
		private string address1_countyField;
		private string address1_faxField;
		private CrmFloat address1_latitudeField;
		private string address1_line1Field;
		private string address1_line2Field;
		private string address1_line3Field;
		private CrmFloat address1_longitudeField;
		private string address1_nameField;
		private string address1_postalcodeField;
		private string address1_postofficeboxField;
		private Picklist address1_shippingmethodcodeField;
		private string address1_stateorprovinceField;
		private string address1_telephone1Field;
		private string address1_telephone2Field;
		private string address1_telephone3Field;
		private string address1_upszoneField;
		private CrmNumber address1_utcoffsetField;
		private Key address2_addressidField;
		private Picklist address2_addresstypecodeField;
		private string address2_cityField;
		private string address2_countryField;
		private string address2_countyField;
		private string address2_faxField;
		private CrmFloat address2_latitudeField;
		private string address2_line1Field;
		private string address2_line2Field;
		private string address2_line3Field;
		private CrmFloat address2_longitudeField;
		private string address2_nameField;
		private string address2_postalcodeField;
		private string address2_postofficeboxField;
		private Picklist address2_shippingmethodcodeField;
		private string address2_stateorprovinceField;
		private string address2_telephone1Field;
		private string address2_telephone2Field;
		private string address2_telephone3Field;
		private string address2_upszoneField;
		private CrmNumber address2_utcoffsetField;
		private Lookup campaignidField;
		private string companynameField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private Customer customeridField;
		private string descriptionField;
		private CrmBoolean donotbulkemailField;
		private CrmBoolean donotemailField;
		private CrmBoolean donotfaxField;
		private CrmBoolean donotphoneField;
		private CrmBoolean donotpostalmailField;
		private CrmBoolean donotsendmmField;
		private string emailaddress1Field;
		private string emailaddress2Field;
		private string emailaddress3Field;
		private CrmMoney estimatedamountField;
		private CrmMoney estimatedamount_baseField;
		private CrmDateTime estimatedclosedateField;
		private CrmFloat estimatedvalueField;
		private CrmDecimal exchangerateField;
		private string faxField;
		private string firstnameField;
		private string fullnameField;
		private CrmNumber importsequencenumberField;
		private Picklist industrycodeField;
		private string jobtitleField;
		private string lastnameField;
		private CrmDateTime lastusedincampaignField;
		private Key leadidField;
		private Picklist leadqualitycodeField;
		private Picklist leadsourcecodeField;
		private Lookup masteridField;
		private CrmBoolean mergedField;
		private string middlenameField;
		private string mobilephoneField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmNumber numberofemployeesField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private string pagerField;
		private CrmBoolean participatesinworkflowField;
		private Picklist preferredcontactmethodcodeField;
		private Picklist prioritycodeField;
		private CrmMoney revenueField;
		private CrmMoney revenue_baseField;
		private Picklist salesstagecodeField;
		private string salutationField;
		private string sicField;
		private LeadStateInfo statecodeField;
		private Status statuscodeField;
		private string subjectField;
		private string telephone1Field;
		private string telephone2Field;
		private string telephone3Field;
		private CrmNumber timezoneruleversionnumberField;
		private Lookup transactioncurrencyidField;
		private CrmNumber utcconversiontimezonecodeField;
		private string websiteurlField;
		private string yomicompanynameField;
		private string yomifirstnameField;
		private string yomifullnameField;
		private string yomilastnameField;
		private string yomimiddlenameField;
		[XmlElement(Order = 0)]
		public Key address1_addressid
		{
			get
			{
				return this.address1_addressidField;
			}
			set
			{
				this.address1_addressidField = value;
				base.RaisePropertyChanged("address1_addressid");
			}
		}
		[XmlElement(Order = 1)]
		public Picklist address1_addresstypecode
		{
			get
			{
				return this.address1_addresstypecodeField;
			}
			set
			{
				this.address1_addresstypecodeField = value;
				base.RaisePropertyChanged("address1_addresstypecode");
			}
		}
		[XmlElement(Order = 2)]
		public string address1_city
		{
			get
			{
				return this.address1_cityField;
			}
			set
			{
				this.address1_cityField = value;
				base.RaisePropertyChanged("address1_city");
			}
		}
		[XmlElement(Order = 3)]
		public string address1_country
		{
			get
			{
				return this.address1_countryField;
			}
			set
			{
				this.address1_countryField = value;
				base.RaisePropertyChanged("address1_country");
			}
		}
		[XmlElement(Order = 4)]
		public string address1_county
		{
			get
			{
				return this.address1_countyField;
			}
			set
			{
				this.address1_countyField = value;
				base.RaisePropertyChanged("address1_county");
			}
		}
		[XmlElement(Order = 5)]
		public string address1_fax
		{
			get
			{
				return this.address1_faxField;
			}
			set
			{
				this.address1_faxField = value;
				base.RaisePropertyChanged("address1_fax");
			}
		}
		[XmlElement(Order = 6)]
		public CrmFloat address1_latitude
		{
			get
			{
				return this.address1_latitudeField;
			}
			set
			{
				this.address1_latitudeField = value;
				base.RaisePropertyChanged("address1_latitude");
			}
		}
		[XmlElement(Order = 7)]
		public string address1_line1
		{
			get
			{
				return this.address1_line1Field;
			}
			set
			{
				this.address1_line1Field = value;
				base.RaisePropertyChanged("address1_line1");
			}
		}
		[XmlElement(Order = 8)]
		public string address1_line2
		{
			get
			{
				return this.address1_line2Field;
			}
			set
			{
				this.address1_line2Field = value;
				base.RaisePropertyChanged("address1_line2");
			}
		}
		[XmlElement(Order = 9)]
		public string address1_line3
		{
			get
			{
				return this.address1_line3Field;
			}
			set
			{
				this.address1_line3Field = value;
				base.RaisePropertyChanged("address1_line3");
			}
		}
		[XmlElement(Order = 10)]
		public CrmFloat address1_longitude
		{
			get
			{
				return this.address1_longitudeField;
			}
			set
			{
				this.address1_longitudeField = value;
				base.RaisePropertyChanged("address1_longitude");
			}
		}
		[XmlElement(Order = 11)]
		public string address1_name
		{
			get
			{
				return this.address1_nameField;
			}
			set
			{
				this.address1_nameField = value;
				base.RaisePropertyChanged("address1_name");
			}
		}
		[XmlElement(Order = 12)]
		public string address1_postalcode
		{
			get
			{
				return this.address1_postalcodeField;
			}
			set
			{
				this.address1_postalcodeField = value;
				base.RaisePropertyChanged("address1_postalcode");
			}
		}
		[XmlElement(Order = 13)]
		public string address1_postofficebox
		{
			get
			{
				return this.address1_postofficeboxField;
			}
			set
			{
				this.address1_postofficeboxField = value;
				base.RaisePropertyChanged("address1_postofficebox");
			}
		}
		[XmlElement(Order = 14)]
		public Picklist address1_shippingmethodcode
		{
			get
			{
				return this.address1_shippingmethodcodeField;
			}
			set
			{
				this.address1_shippingmethodcodeField = value;
				base.RaisePropertyChanged("address1_shippingmethodcode");
			}
		}
		[XmlElement(Order = 15)]
		public string address1_stateorprovince
		{
			get
			{
				return this.address1_stateorprovinceField;
			}
			set
			{
				this.address1_stateorprovinceField = value;
				base.RaisePropertyChanged("address1_stateorprovince");
			}
		}
		[XmlElement(Order = 16)]
		public string address1_telephone1
		{
			get
			{
				return this.address1_telephone1Field;
			}
			set
			{
				this.address1_telephone1Field = value;
				base.RaisePropertyChanged("address1_telephone1");
			}
		}
		[XmlElement(Order = 17)]
		public string address1_telephone2
		{
			get
			{
				return this.address1_telephone2Field;
			}
			set
			{
				this.address1_telephone2Field = value;
				base.RaisePropertyChanged("address1_telephone2");
			}
		}
		[XmlElement(Order = 18)]
		public string address1_telephone3
		{
			get
			{
				return this.address1_telephone3Field;
			}
			set
			{
				this.address1_telephone3Field = value;
				base.RaisePropertyChanged("address1_telephone3");
			}
		}
		[XmlElement(Order = 19)]
		public string address1_upszone
		{
			get
			{
				return this.address1_upszoneField;
			}
			set
			{
				this.address1_upszoneField = value;
				base.RaisePropertyChanged("address1_upszone");
			}
		}
		[XmlElement(Order = 20)]
		public CrmNumber address1_utcoffset
		{
			get
			{
				return this.address1_utcoffsetField;
			}
			set
			{
				this.address1_utcoffsetField = value;
				base.RaisePropertyChanged("address1_utcoffset");
			}
		}
		[XmlElement(Order = 21)]
		public Key address2_addressid
		{
			get
			{
				return this.address2_addressidField;
			}
			set
			{
				this.address2_addressidField = value;
				base.RaisePropertyChanged("address2_addressid");
			}
		}
		[XmlElement(Order = 22)]
		public Picklist address2_addresstypecode
		{
			get
			{
				return this.address2_addresstypecodeField;
			}
			set
			{
				this.address2_addresstypecodeField = value;
				base.RaisePropertyChanged("address2_addresstypecode");
			}
		}
		[XmlElement(Order = 23)]
		public string address2_city
		{
			get
			{
				return this.address2_cityField;
			}
			set
			{
				this.address2_cityField = value;
				base.RaisePropertyChanged("address2_city");
			}
		}
		[XmlElement(Order = 24)]
		public string address2_country
		{
			get
			{
				return this.address2_countryField;
			}
			set
			{
				this.address2_countryField = value;
				base.RaisePropertyChanged("address2_country");
			}
		}
		[XmlElement(Order = 25)]
		public string address2_county
		{
			get
			{
				return this.address2_countyField;
			}
			set
			{
				this.address2_countyField = value;
				base.RaisePropertyChanged("address2_county");
			}
		}
		[XmlElement(Order = 26)]
		public string address2_fax
		{
			get
			{
				return this.address2_faxField;
			}
			set
			{
				this.address2_faxField = value;
				base.RaisePropertyChanged("address2_fax");
			}
		}
		[XmlElement(Order = 27)]
		public CrmFloat address2_latitude
		{
			get
			{
				return this.address2_latitudeField;
			}
			set
			{
				this.address2_latitudeField = value;
				base.RaisePropertyChanged("address2_latitude");
			}
		}
		[XmlElement(Order = 28)]
		public string address2_line1
		{
			get
			{
				return this.address2_line1Field;
			}
			set
			{
				this.address2_line1Field = value;
				base.RaisePropertyChanged("address2_line1");
			}
		}
		[XmlElement(Order = 29)]
		public string address2_line2
		{
			get
			{
				return this.address2_line2Field;
			}
			set
			{
				this.address2_line2Field = value;
				base.RaisePropertyChanged("address2_line2");
			}
		}
		[XmlElement(Order = 30)]
		public string address2_line3
		{
			get
			{
				return this.address2_line3Field;
			}
			set
			{
				this.address2_line3Field = value;
				base.RaisePropertyChanged("address2_line3");
			}
		}
		[XmlElement(Order = 31)]
		public CrmFloat address2_longitude
		{
			get
			{
				return this.address2_longitudeField;
			}
			set
			{
				this.address2_longitudeField = value;
				base.RaisePropertyChanged("address2_longitude");
			}
		}
		[XmlElement(Order = 32)]
		public string address2_name
		{
			get
			{
				return this.address2_nameField;
			}
			set
			{
				this.address2_nameField = value;
				base.RaisePropertyChanged("address2_name");
			}
		}
		[XmlElement(Order = 33)]
		public string address2_postalcode
		{
			get
			{
				return this.address2_postalcodeField;
			}
			set
			{
				this.address2_postalcodeField = value;
				base.RaisePropertyChanged("address2_postalcode");
			}
		}
		[XmlElement(Order = 34)]
		public string address2_postofficebox
		{
			get
			{
				return this.address2_postofficeboxField;
			}
			set
			{
				this.address2_postofficeboxField = value;
				base.RaisePropertyChanged("address2_postofficebox");
			}
		}
		[XmlElement(Order = 35)]
		public Picklist address2_shippingmethodcode
		{
			get
			{
				return this.address2_shippingmethodcodeField;
			}
			set
			{
				this.address2_shippingmethodcodeField = value;
				base.RaisePropertyChanged("address2_shippingmethodcode");
			}
		}
		[XmlElement(Order = 36)]
		public string address2_stateorprovince
		{
			get
			{
				return this.address2_stateorprovinceField;
			}
			set
			{
				this.address2_stateorprovinceField = value;
				base.RaisePropertyChanged("address2_stateorprovince");
			}
		}
		[XmlElement(Order = 37)]
		public string address2_telephone1
		{
			get
			{
				return this.address2_telephone1Field;
			}
			set
			{
				this.address2_telephone1Field = value;
				base.RaisePropertyChanged("address2_telephone1");
			}
		}
		[XmlElement(Order = 38)]
		public string address2_telephone2
		{
			get
			{
				return this.address2_telephone2Field;
			}
			set
			{
				this.address2_telephone2Field = value;
				base.RaisePropertyChanged("address2_telephone2");
			}
		}
		[XmlElement(Order = 39)]
		public string address2_telephone3
		{
			get
			{
				return this.address2_telephone3Field;
			}
			set
			{
				this.address2_telephone3Field = value;
				base.RaisePropertyChanged("address2_telephone3");
			}
		}
		[XmlElement(Order = 40)]
		public string address2_upszone
		{
			get
			{
				return this.address2_upszoneField;
			}
			set
			{
				this.address2_upszoneField = value;
				base.RaisePropertyChanged("address2_upszone");
			}
		}
		[XmlElement(Order = 41)]
		public CrmNumber address2_utcoffset
		{
			get
			{
				return this.address2_utcoffsetField;
			}
			set
			{
				this.address2_utcoffsetField = value;
				base.RaisePropertyChanged("address2_utcoffset");
			}
		}
		[XmlElement(Order = 42)]
		public Lookup campaignid
		{
			get
			{
				return this.campaignidField;
			}
			set
			{
				this.campaignidField = value;
				base.RaisePropertyChanged("campaignid");
			}
		}
		[XmlElement(Order = 43)]
		public string companyname
		{
			get
			{
				return this.companynameField;
			}
			set
			{
				this.companynameField = value;
				base.RaisePropertyChanged("companyname");
			}
		}
		[XmlElement(Order = 44)]
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
		[XmlElement(Order = 45)]
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
		[XmlElement(Order = 46)]
		public Customer customerid
		{
			get
			{
				return this.customeridField;
			}
			set
			{
				this.customeridField = value;
				base.RaisePropertyChanged("customerid");
			}
		}
		[XmlElement(Order = 47)]
		public string description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				base.RaisePropertyChanged("description");
			}
		}
		[XmlElement(Order = 48)]
		public CrmBoolean donotbulkemail
		{
			get
			{
				return this.donotbulkemailField;
			}
			set
			{
				this.donotbulkemailField = value;
				base.RaisePropertyChanged("donotbulkemail");
			}
		}
		[XmlElement(Order = 49)]
		public CrmBoolean donotemail
		{
			get
			{
				return this.donotemailField;
			}
			set
			{
				this.donotemailField = value;
				base.RaisePropertyChanged("donotemail");
			}
		}
		[XmlElement(Order = 50)]
		public CrmBoolean donotfax
		{
			get
			{
				return this.donotfaxField;
			}
			set
			{
				this.donotfaxField = value;
				base.RaisePropertyChanged("donotfax");
			}
		}
		[XmlElement(Order = 51)]
		public CrmBoolean donotphone
		{
			get
			{
				return this.donotphoneField;
			}
			set
			{
				this.donotphoneField = value;
				base.RaisePropertyChanged("donotphone");
			}
		}
		[XmlElement(Order = 52)]
		public CrmBoolean donotpostalmail
		{
			get
			{
				return this.donotpostalmailField;
			}
			set
			{
				this.donotpostalmailField = value;
				base.RaisePropertyChanged("donotpostalmail");
			}
		}
		[XmlElement(Order = 53)]
		public CrmBoolean donotsendmm
		{
			get
			{
				return this.donotsendmmField;
			}
			set
			{
				this.donotsendmmField = value;
				base.RaisePropertyChanged("donotsendmm");
			}
		}
		[XmlElement(Order = 54)]
		public string emailaddress1
		{
			get
			{
				return this.emailaddress1Field;
			}
			set
			{
				this.emailaddress1Field = value;
				base.RaisePropertyChanged("emailaddress1");
			}
		}
		[XmlElement(Order = 55)]
		public string emailaddress2
		{
			get
			{
				return this.emailaddress2Field;
			}
			set
			{
				this.emailaddress2Field = value;
				base.RaisePropertyChanged("emailaddress2");
			}
		}
		[XmlElement(Order = 56)]
		public string emailaddress3
		{
			get
			{
				return this.emailaddress3Field;
			}
			set
			{
				this.emailaddress3Field = value;
				base.RaisePropertyChanged("emailaddress3");
			}
		}
		[XmlElement(Order = 57)]
		public CrmMoney estimatedamount
		{
			get
			{
				return this.estimatedamountField;
			}
			set
			{
				this.estimatedamountField = value;
				base.RaisePropertyChanged("estimatedamount");
			}
		}
		[XmlElement(Order = 58)]
		public CrmMoney estimatedamount_base
		{
			get
			{
				return this.estimatedamount_baseField;
			}
			set
			{
				this.estimatedamount_baseField = value;
				base.RaisePropertyChanged("estimatedamount_base");
			}
		}
		[XmlElement(Order = 59)]
		public CrmDateTime estimatedclosedate
		{
			get
			{
				return this.estimatedclosedateField;
			}
			set
			{
				this.estimatedclosedateField = value;
				base.RaisePropertyChanged("estimatedclosedate");
			}
		}
		[XmlElement(Order = 60)]
		public CrmFloat estimatedvalue
		{
			get
			{
				return this.estimatedvalueField;
			}
			set
			{
				this.estimatedvalueField = value;
				base.RaisePropertyChanged("estimatedvalue");
			}
		}
		[XmlElement(Order = 61)]
		public CrmDecimal exchangerate
		{
			get
			{
				return this.exchangerateField;
			}
			set
			{
				this.exchangerateField = value;
				base.RaisePropertyChanged("exchangerate");
			}
		}
		[XmlElement(Order = 62)]
		public string fax
		{
			get
			{
				return this.faxField;
			}
			set
			{
				this.faxField = value;
				base.RaisePropertyChanged("fax");
			}
		}
		[XmlElement(Order = 63)]
		public string firstname
		{
			get
			{
				return this.firstnameField;
			}
			set
			{
				this.firstnameField = value;
				base.RaisePropertyChanged("firstname");
			}
		}
		[XmlElement(Order = 64)]
		public string fullname
		{
			get
			{
				return this.fullnameField;
			}
			set
			{
				this.fullnameField = value;
				base.RaisePropertyChanged("fullname");
			}
		}
		[XmlElement(Order = 65)]
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
		[XmlElement(Order = 66)]
		public Picklist industrycode
		{
			get
			{
				return this.industrycodeField;
			}
			set
			{
				this.industrycodeField = value;
				base.RaisePropertyChanged("industrycode");
			}
		}
		[XmlElement(Order = 67)]
		public string jobtitle
		{
			get
			{
				return this.jobtitleField;
			}
			set
			{
				this.jobtitleField = value;
				base.RaisePropertyChanged("jobtitle");
			}
		}
		[XmlElement(Order = 68)]
		public string lastname
		{
			get
			{
				return this.lastnameField;
			}
			set
			{
				this.lastnameField = value;
				base.RaisePropertyChanged("lastname");
			}
		}
		[XmlElement(Order = 69)]
		public CrmDateTime lastusedincampaign
		{
			get
			{
				return this.lastusedincampaignField;
			}
			set
			{
				this.lastusedincampaignField = value;
				base.RaisePropertyChanged("lastusedincampaign");
			}
		}
		[XmlElement(Order = 70)]
		public Key leadid
		{
			get
			{
				return this.leadidField;
			}
			set
			{
				this.leadidField = value;
				base.RaisePropertyChanged("leadid");
			}
		}
		[XmlElement(Order = 71)]
		public Picklist leadqualitycode
		{
			get
			{
				return this.leadqualitycodeField;
			}
			set
			{
				this.leadqualitycodeField = value;
				base.RaisePropertyChanged("leadqualitycode");
			}
		}
		[XmlElement(Order = 72)]
		public Picklist leadsourcecode
		{
			get
			{
				return this.leadsourcecodeField;
			}
			set
			{
				this.leadsourcecodeField = value;
				base.RaisePropertyChanged("leadsourcecode");
			}
		}
		[XmlElement(Order = 73)]
		public Lookup masterid
		{
			get
			{
				return this.masteridField;
			}
			set
			{
				this.masteridField = value;
				base.RaisePropertyChanged("masterid");
			}
		}
		[XmlElement(Order = 74)]
		public CrmBoolean merged
		{
			get
			{
				return this.mergedField;
			}
			set
			{
				this.mergedField = value;
				base.RaisePropertyChanged("merged");
			}
		}
		[XmlElement(Order = 75)]
		public string middlename
		{
			get
			{
				return this.middlenameField;
			}
			set
			{
				this.middlenameField = value;
				base.RaisePropertyChanged("middlename");
			}
		}
		[XmlElement(Order = 76)]
		public string mobilephone
		{
			get
			{
				return this.mobilephoneField;
			}
			set
			{
				this.mobilephoneField = value;
				base.RaisePropertyChanged("mobilephone");
			}
		}
		[XmlElement(Order = 77)]
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
		[XmlElement(Order = 78)]
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
		[XmlElement(Order = 79)]
		public CrmNumber numberofemployees
		{
			get
			{
				return this.numberofemployeesField;
			}
			set
			{
				this.numberofemployeesField = value;
				base.RaisePropertyChanged("numberofemployees");
			}
		}
		[XmlElement(Order = 80)]
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
		[XmlElement(Order = 81)]
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
		[XmlElement(Order = 82)]
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
		[XmlElement(Order = 83)]
		public string pager
		{
			get
			{
				return this.pagerField;
			}
			set
			{
				this.pagerField = value;
				base.RaisePropertyChanged("pager");
			}
		}
		[XmlElement(Order = 84)]
		public CrmBoolean participatesinworkflow
		{
			get
			{
				return this.participatesinworkflowField;
			}
			set
			{
				this.participatesinworkflowField = value;
				base.RaisePropertyChanged("participatesinworkflow");
			}
		}
		[XmlElement(Order = 85)]
		public Picklist preferredcontactmethodcode
		{
			get
			{
				return this.preferredcontactmethodcodeField;
			}
			set
			{
				this.preferredcontactmethodcodeField = value;
				base.RaisePropertyChanged("preferredcontactmethodcode");
			}
		}
		[XmlElement(Order = 86)]
		public Picklist prioritycode
		{
			get
			{
				return this.prioritycodeField;
			}
			set
			{
				this.prioritycodeField = value;
				base.RaisePropertyChanged("prioritycode");
			}
		}
		[XmlElement(Order = 87)]
		public CrmMoney revenue
		{
			get
			{
				return this.revenueField;
			}
			set
			{
				this.revenueField = value;
				base.RaisePropertyChanged("revenue");
			}
		}
		[XmlElement(Order = 88)]
		public CrmMoney revenue_base
		{
			get
			{
				return this.revenue_baseField;
			}
			set
			{
				this.revenue_baseField = value;
				base.RaisePropertyChanged("revenue_base");
			}
		}
		[XmlElement(Order = 89)]
		public Picklist salesstagecode
		{
			get
			{
				return this.salesstagecodeField;
			}
			set
			{
				this.salesstagecodeField = value;
				base.RaisePropertyChanged("salesstagecode");
			}
		}
		[XmlElement(Order = 90)]
		public string salutation
		{
			get
			{
				return this.salutationField;
			}
			set
			{
				this.salutationField = value;
				base.RaisePropertyChanged("salutation");
			}
		}
		[XmlElement(Order = 91)]
		public string sic
		{
			get
			{
				return this.sicField;
			}
			set
			{
				this.sicField = value;
				base.RaisePropertyChanged("sic");
			}
		}
		[XmlElement(Order = 92)]
		public LeadStateInfo statecode
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
		[XmlElement(Order = 93)]
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
		[XmlElement(Order = 94)]
		public string subject
		{
			get
			{
				return this.subjectField;
			}
			set
			{
				this.subjectField = value;
				base.RaisePropertyChanged("subject");
			}
		}
		[XmlElement(Order = 95)]
		public string telephone1
		{
			get
			{
				return this.telephone1Field;
			}
			set
			{
				this.telephone1Field = value;
				base.RaisePropertyChanged("telephone1");
			}
		}
		[XmlElement(Order = 96)]
		public string telephone2
		{
			get
			{
				return this.telephone2Field;
			}
			set
			{
				this.telephone2Field = value;
				base.RaisePropertyChanged("telephone2");
			}
		}
		[XmlElement(Order = 97)]
		public string telephone3
		{
			get
			{
				return this.telephone3Field;
			}
			set
			{
				this.telephone3Field = value;
				base.RaisePropertyChanged("telephone3");
			}
		}
		[XmlElement(Order = 98)]
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
		[XmlElement(Order = 99)]
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
		[XmlElement(Order = 100)]
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
		[XmlElement(Order = 101)]
		public string websiteurl
		{
			get
			{
				return this.websiteurlField;
			}
			set
			{
				this.websiteurlField = value;
				base.RaisePropertyChanged("websiteurl");
			}
		}
		[XmlElement(Order = 102)]
		public string yomicompanyname
		{
			get
			{
				return this.yomicompanynameField;
			}
			set
			{
				this.yomicompanynameField = value;
				base.RaisePropertyChanged("yomicompanyname");
			}
		}
		[XmlElement(Order = 103)]
		public string yomifirstname
		{
			get
			{
				return this.yomifirstnameField;
			}
			set
			{
				this.yomifirstnameField = value;
				base.RaisePropertyChanged("yomifirstname");
			}
		}
		[XmlElement(Order = 104)]
		public string yomifullname
		{
			get
			{
				return this.yomifullnameField;
			}
			set
			{
				this.yomifullnameField = value;
				base.RaisePropertyChanged("yomifullname");
			}
		}
		[XmlElement(Order = 105)]
		public string yomilastname
		{
			get
			{
				return this.yomilastnameField;
			}
			set
			{
				this.yomilastnameField = value;
				base.RaisePropertyChanged("yomilastname");
			}
		}
		[XmlElement(Order = 106)]
		public string yomimiddlename
		{
			get
			{
				return this.yomimiddlenameField;
			}
			set
			{
				this.yomimiddlenameField = value;
				base.RaisePropertyChanged("yomimiddlename");
			}
		}
	}
}
