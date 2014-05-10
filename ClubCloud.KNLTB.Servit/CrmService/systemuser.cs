using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class systemuser : BusinessEntity
	{
		private Picklist accessmodeField;
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
		private Lookup businessunitidField;
		private Lookup calendaridField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private string disabledreasonField;
		private CrmBoolean displayinserviceviewsField;
		private string domainnameField;
		private string employeeidField;
		private string firstnameField;
		private string fullnameField;
		private string governmentidField;
		private string homephoneField;
		private CrmNumber importsequencenumberField;
		private Picklist incomingemaildeliverymethodField;
		private string internalemailaddressField;
		private Picklist invitestatuscodeField;
		private CrmBoolean isdisabledField;
		private string jobtitleField;
		private string lastnameField;
		private string middlenameField;
		private string mobilealertemailField;
		private string mobilephoneField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private string nicknameField;
		private UniqueIdentifier organizationidField;
		private Picklist outgoingemaildeliverymethodField;
		private CrmDateTime overriddencreatedonField;
		private Lookup parentsystemuseridField;
		private CrmNumber passporthiField;
		private CrmNumber passportloField;
		private string personalemailaddressField;
		private string photourlField;
		private Picklist preferredaddresscodeField;
		private Picklist preferredemailcodeField;
		private Picklist preferredphonecodeField;
		private string salutationField;
		private CrmBoolean setupuserField;
		private string sgt_bondsnummerField;
		private Lookup sgt_persoonidField;
		private Lookup siteidField;
		private string skillsField;
		private Key systemuseridField;
		private Lookup territoryidField;
		private CrmNumber timezoneruleversionnumberField;
		private string titleField;
		private CrmNumber utcconversiontimezonecodeField;
		private string windowsliveidField;
		private string yomifirstnameField;
		private string yomifullnameField;
		private string yomilastnameField;
		private string yomimiddlenameField;
		public Picklist accessmode
		{
			get
			{
				return this.accessmodeField;
			}
			set
			{
				this.accessmodeField = value;
			}
		}
		public Key address1_addressid
		{
			get
			{
				return this.address1_addressidField;
			}
			set
			{
				this.address1_addressidField = value;
			}
		}
		public Picklist address1_addresstypecode
		{
			get
			{
				return this.address1_addresstypecodeField;
			}
			set
			{
				this.address1_addresstypecodeField = value;
			}
		}
		public string address1_city
		{
			get
			{
				return this.address1_cityField;
			}
			set
			{
				this.address1_cityField = value;
			}
		}
		public string address1_country
		{
			get
			{
				return this.address1_countryField;
			}
			set
			{
				this.address1_countryField = value;
			}
		}
		public string address1_county
		{
			get
			{
				return this.address1_countyField;
			}
			set
			{
				this.address1_countyField = value;
			}
		}
		public string address1_fax
		{
			get
			{
				return this.address1_faxField;
			}
			set
			{
				this.address1_faxField = value;
			}
		}
		public CrmFloat address1_latitude
		{
			get
			{
				return this.address1_latitudeField;
			}
			set
			{
				this.address1_latitudeField = value;
			}
		}
		public string address1_line1
		{
			get
			{
				return this.address1_line1Field;
			}
			set
			{
				this.address1_line1Field = value;
			}
		}
		public string address1_line2
		{
			get
			{
				return this.address1_line2Field;
			}
			set
			{
				this.address1_line2Field = value;
			}
		}
		public string address1_line3
		{
			get
			{
				return this.address1_line3Field;
			}
			set
			{
				this.address1_line3Field = value;
			}
		}
		public CrmFloat address1_longitude
		{
			get
			{
				return this.address1_longitudeField;
			}
			set
			{
				this.address1_longitudeField = value;
			}
		}
		public string address1_name
		{
			get
			{
				return this.address1_nameField;
			}
			set
			{
				this.address1_nameField = value;
			}
		}
		public string address1_postalcode
		{
			get
			{
				return this.address1_postalcodeField;
			}
			set
			{
				this.address1_postalcodeField = value;
			}
		}
		public string address1_postofficebox
		{
			get
			{
				return this.address1_postofficeboxField;
			}
			set
			{
				this.address1_postofficeboxField = value;
			}
		}
		public Picklist address1_shippingmethodcode
		{
			get
			{
				return this.address1_shippingmethodcodeField;
			}
			set
			{
				this.address1_shippingmethodcodeField = value;
			}
		}
		public string address1_stateorprovince
		{
			get
			{
				return this.address1_stateorprovinceField;
			}
			set
			{
				this.address1_stateorprovinceField = value;
			}
		}
		public string address1_telephone1
		{
			get
			{
				return this.address1_telephone1Field;
			}
			set
			{
				this.address1_telephone1Field = value;
			}
		}
		public string address1_telephone2
		{
			get
			{
				return this.address1_telephone2Field;
			}
			set
			{
				this.address1_telephone2Field = value;
			}
		}
		public string address1_telephone3
		{
			get
			{
				return this.address1_telephone3Field;
			}
			set
			{
				this.address1_telephone3Field = value;
			}
		}
		public string address1_upszone
		{
			get
			{
				return this.address1_upszoneField;
			}
			set
			{
				this.address1_upszoneField = value;
			}
		}
		public CrmNumber address1_utcoffset
		{
			get
			{
				return this.address1_utcoffsetField;
			}
			set
			{
				this.address1_utcoffsetField = value;
			}
		}
		public Key address2_addressid
		{
			get
			{
				return this.address2_addressidField;
			}
			set
			{
				this.address2_addressidField = value;
			}
		}
		public Picklist address2_addresstypecode
		{
			get
			{
				return this.address2_addresstypecodeField;
			}
			set
			{
				this.address2_addresstypecodeField = value;
			}
		}
		public string address2_city
		{
			get
			{
				return this.address2_cityField;
			}
			set
			{
				this.address2_cityField = value;
			}
		}
		public string address2_country
		{
			get
			{
				return this.address2_countryField;
			}
			set
			{
				this.address2_countryField = value;
			}
		}
		public string address2_county
		{
			get
			{
				return this.address2_countyField;
			}
			set
			{
				this.address2_countyField = value;
			}
		}
		public string address2_fax
		{
			get
			{
				return this.address2_faxField;
			}
			set
			{
				this.address2_faxField = value;
			}
		}
		public CrmFloat address2_latitude
		{
			get
			{
				return this.address2_latitudeField;
			}
			set
			{
				this.address2_latitudeField = value;
			}
		}
		public string address2_line1
		{
			get
			{
				return this.address2_line1Field;
			}
			set
			{
				this.address2_line1Field = value;
			}
		}
		public string address2_line2
		{
			get
			{
				return this.address2_line2Field;
			}
			set
			{
				this.address2_line2Field = value;
			}
		}
		public string address2_line3
		{
			get
			{
				return this.address2_line3Field;
			}
			set
			{
				this.address2_line3Field = value;
			}
		}
		public CrmFloat address2_longitude
		{
			get
			{
				return this.address2_longitudeField;
			}
			set
			{
				this.address2_longitudeField = value;
			}
		}
		public string address2_name
		{
			get
			{
				return this.address2_nameField;
			}
			set
			{
				this.address2_nameField = value;
			}
		}
		public string address2_postalcode
		{
			get
			{
				return this.address2_postalcodeField;
			}
			set
			{
				this.address2_postalcodeField = value;
			}
		}
		public string address2_postofficebox
		{
			get
			{
				return this.address2_postofficeboxField;
			}
			set
			{
				this.address2_postofficeboxField = value;
			}
		}
		public Picklist address2_shippingmethodcode
		{
			get
			{
				return this.address2_shippingmethodcodeField;
			}
			set
			{
				this.address2_shippingmethodcodeField = value;
			}
		}
		public string address2_stateorprovince
		{
			get
			{
				return this.address2_stateorprovinceField;
			}
			set
			{
				this.address2_stateorprovinceField = value;
			}
		}
		public string address2_telephone1
		{
			get
			{
				return this.address2_telephone1Field;
			}
			set
			{
				this.address2_telephone1Field = value;
			}
		}
		public string address2_telephone2
		{
			get
			{
				return this.address2_telephone2Field;
			}
			set
			{
				this.address2_telephone2Field = value;
			}
		}
		public string address2_telephone3
		{
			get
			{
				return this.address2_telephone3Field;
			}
			set
			{
				this.address2_telephone3Field = value;
			}
		}
		public string address2_upszone
		{
			get
			{
				return this.address2_upszoneField;
			}
			set
			{
				this.address2_upszoneField = value;
			}
		}
		public CrmNumber address2_utcoffset
		{
			get
			{
				return this.address2_utcoffsetField;
			}
			set
			{
				this.address2_utcoffsetField = value;
			}
		}
		public Lookup businessunitid
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
		public Lookup calendarid
		{
			get
			{
				return this.calendaridField;
			}
			set
			{
				this.calendaridField = value;
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
		public CrmBoolean displayinserviceviews
		{
			get
			{
				return this.displayinserviceviewsField;
			}
			set
			{
				this.displayinserviceviewsField = value;
			}
		}
		public string domainname
		{
			get
			{
				return this.domainnameField;
			}
			set
			{
				this.domainnameField = value;
			}
		}
		public string employeeid
		{
			get
			{
				return this.employeeidField;
			}
			set
			{
				this.employeeidField = value;
			}
		}
		public string firstname
		{
			get
			{
				return this.firstnameField;
			}
			set
			{
				this.firstnameField = value;
			}
		}
		public string fullname
		{
			get
			{
				return this.fullnameField;
			}
			set
			{
				this.fullnameField = value;
			}
		}
		public string governmentid
		{
			get
			{
				return this.governmentidField;
			}
			set
			{
				this.governmentidField = value;
			}
		}
		public string homephone
		{
			get
			{
				return this.homephoneField;
			}
			set
			{
				this.homephoneField = value;
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
		public Picklist incomingemaildeliverymethod
		{
			get
			{
				return this.incomingemaildeliverymethodField;
			}
			set
			{
				this.incomingemaildeliverymethodField = value;
			}
		}
		public string internalemailaddress
		{
			get
			{
				return this.internalemailaddressField;
			}
			set
			{
				this.internalemailaddressField = value;
			}
		}
		public Picklist invitestatuscode
		{
			get
			{
				return this.invitestatuscodeField;
			}
			set
			{
				this.invitestatuscodeField = value;
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
		public string jobtitle
		{
			get
			{
				return this.jobtitleField;
			}
			set
			{
				this.jobtitleField = value;
			}
		}
		public string lastname
		{
			get
			{
				return this.lastnameField;
			}
			set
			{
				this.lastnameField = value;
			}
		}
		public string middlename
		{
			get
			{
				return this.middlenameField;
			}
			set
			{
				this.middlenameField = value;
			}
		}
		public string mobilealertemail
		{
			get
			{
				return this.mobilealertemailField;
			}
			set
			{
				this.mobilealertemailField = value;
			}
		}
		public string mobilephone
		{
			get
			{
				return this.mobilephoneField;
			}
			set
			{
				this.mobilephoneField = value;
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
		public string nickname
		{
			get
			{
				return this.nicknameField;
			}
			set
			{
				this.nicknameField = value;
			}
		}
		public UniqueIdentifier organizationid
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
		public Picklist outgoingemaildeliverymethod
		{
			get
			{
				return this.outgoingemaildeliverymethodField;
			}
			set
			{
				this.outgoingemaildeliverymethodField = value;
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
		public Lookup parentsystemuserid
		{
			get
			{
				return this.parentsystemuseridField;
			}
			set
			{
				this.parentsystemuseridField = value;
			}
		}
		public CrmNumber passporthi
		{
			get
			{
				return this.passporthiField;
			}
			set
			{
				this.passporthiField = value;
			}
		}
		public CrmNumber passportlo
		{
			get
			{
				return this.passportloField;
			}
			set
			{
				this.passportloField = value;
			}
		}
		public string personalemailaddress
		{
			get
			{
				return this.personalemailaddressField;
			}
			set
			{
				this.personalemailaddressField = value;
			}
		}
		public string photourl
		{
			get
			{
				return this.photourlField;
			}
			set
			{
				this.photourlField = value;
			}
		}
		public Picklist preferredaddresscode
		{
			get
			{
				return this.preferredaddresscodeField;
			}
			set
			{
				this.preferredaddresscodeField = value;
			}
		}
		public Picklist preferredemailcode
		{
			get
			{
				return this.preferredemailcodeField;
			}
			set
			{
				this.preferredemailcodeField = value;
			}
		}
		public Picklist preferredphonecode
		{
			get
			{
				return this.preferredphonecodeField;
			}
			set
			{
				this.preferredphonecodeField = value;
			}
		}
		public string salutation
		{
			get
			{
				return this.salutationField;
			}
			set
			{
				this.salutationField = value;
			}
		}
		public CrmBoolean setupuser
		{
			get
			{
				return this.setupuserField;
			}
			set
			{
				this.setupuserField = value;
			}
		}
		public string sgt_bondsnummer
		{
			get
			{
				return this.sgt_bondsnummerField;
			}
			set
			{
				this.sgt_bondsnummerField = value;
			}
		}
		public Lookup sgt_persoonid
		{
			get
			{
				return this.sgt_persoonidField;
			}
			set
			{
				this.sgt_persoonidField = value;
			}
		}
		public Lookup siteid
		{
			get
			{
				return this.siteidField;
			}
			set
			{
				this.siteidField = value;
			}
		}
		public string skills
		{
			get
			{
				return this.skillsField;
			}
			set
			{
				this.skillsField = value;
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
		public Lookup territoryid
		{
			get
			{
				return this.territoryidField;
			}
			set
			{
				this.territoryidField = value;
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
		public string title
		{
			get
			{
				return this.titleField;
			}
			set
			{
				this.titleField = value;
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
		public string windowsliveid
		{
			get
			{
				return this.windowsliveidField;
			}
			set
			{
				this.windowsliveidField = value;
			}
		}
		public string yomifirstname
		{
			get
			{
				return this.yomifirstnameField;
			}
			set
			{
				this.yomifirstnameField = value;
			}
		}
		public string yomifullname
		{
			get
			{
				return this.yomifullnameField;
			}
			set
			{
				this.yomifullnameField = value;
			}
		}
		public string yomilastname
		{
			get
			{
				return this.yomilastnameField;
			}
			set
			{
				this.yomilastnameField = value;
			}
		}
		public string yomimiddlename
		{
			get
			{
				return this.yomimiddlenameField;
			}
			set
			{
				this.yomimiddlenameField = value;
			}
		}
	}
}
