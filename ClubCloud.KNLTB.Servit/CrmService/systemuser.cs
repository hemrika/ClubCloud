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

		[XmlElement] //[XmlElement(Order=0)]
		public Picklist accessmode
		{
			get
			{
				return this.accessmodeField;
			}
			set
			{
				this.accessmodeField = value;
				base.RaisePropertyChanged("accessmode");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
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

		[XmlElement] //[XmlElement(Order=2)]
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

		[XmlElement] //[XmlElement(Order=3)]
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

		[XmlElement] //[XmlElement(Order=4)]
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

		[XmlElement] //[XmlElement(Order=5)]
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

		[XmlElement] //[XmlElement(Order=6)]
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

		[XmlElement] //[XmlElement(Order=7)]
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

		[XmlElement] //[XmlElement(Order=8)]
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

		[XmlElement] //[XmlElement(Order=9)]
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

		[XmlElement] //[XmlElement(Order=10)]
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

		[XmlElement] //[XmlElement(Order=11)]
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

		[XmlElement] //[XmlElement(Order=12)]
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

		[XmlElement] //[XmlElement(Order=13)]
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

		[XmlElement] //[XmlElement(Order=14)]
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

		[XmlElement] //[XmlElement(Order=15)]
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

		[XmlElement] //[XmlElement(Order=16)]
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

		[XmlElement] //[XmlElement(Order=17)]
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

		[XmlElement] //[XmlElement(Order=18)]
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

		[XmlElement] //[XmlElement(Order=19)]
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

		[XmlElement] //[XmlElement(Order=20)]
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

		[XmlElement] //[XmlElement(Order=21)]
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

		[XmlElement] //[XmlElement(Order=22)]
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

		[XmlElement] //[XmlElement(Order=23)]
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

		[XmlElement] //[XmlElement(Order=24)]
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

		[XmlElement] //[XmlElement(Order=25)]
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

		[XmlElement] //[XmlElement(Order=26)]
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

		[XmlElement] //[XmlElement(Order=27)]
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

		[XmlElement] //[XmlElement(Order=28)]
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

		[XmlElement] //[XmlElement(Order=29)]
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

		[XmlElement] //[XmlElement(Order=30)]
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

		[XmlElement] //[XmlElement(Order=31)]
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

		[XmlElement] //[XmlElement(Order=32)]
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

		[XmlElement] //[XmlElement(Order=33)]
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

		[XmlElement] //[XmlElement(Order=34)]
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

		[XmlElement] //[XmlElement(Order=35)]
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

		[XmlElement] //[XmlElement(Order=36)]
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

		[XmlElement] //[XmlElement(Order=37)]
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

		[XmlElement] //[XmlElement(Order=38)]
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

		[XmlElement] //[XmlElement(Order=39)]
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

		[XmlElement] //[XmlElement(Order=40)]
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

		[XmlElement] //[XmlElement(Order=41)]
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

		[XmlElement] //[XmlElement(Order=42)]
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

		[XmlElement] //[XmlElement(Order=43)]
		public Lookup businessunitid
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

		[XmlElement] //[XmlElement(Order=44)]
		public Lookup calendarid
		{
			get
			{
				return this.calendaridField;
			}
			set
			{
				this.calendaridField = value;
				base.RaisePropertyChanged("calendarid");
			}
		}

		[XmlElement] //[XmlElement(Order=45)]
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

		[XmlElement] //[XmlElement(Order=46)]
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

		[XmlElement] //[XmlElement(Order=47)]
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

		[XmlElement] //[XmlElement(Order=48)]
		public CrmBoolean displayinserviceviews
		{
			get
			{
				return this.displayinserviceviewsField;
			}
			set
			{
				this.displayinserviceviewsField = value;
				base.RaisePropertyChanged("displayinserviceviews");
			}
		}

		[XmlElement] //[XmlElement(Order=49)]
		public string domainname
		{
			get
			{
				return this.domainnameField;
			}
			set
			{
				this.domainnameField = value;
				base.RaisePropertyChanged("domainname");
			}
		}

		[XmlElement] //[XmlElement(Order=50)]
		public string employeeid
		{
			get
			{
				return this.employeeidField;
			}
			set
			{
				this.employeeidField = value;
				base.RaisePropertyChanged("employeeid");
			}
		}

		[XmlElement] //[XmlElement(Order=51)]
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

		[XmlElement] //[XmlElement(Order=52)]
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

		[XmlElement] //[XmlElement(Order=53)]
		public string governmentid
		{
			get
			{
				return this.governmentidField;
			}
			set
			{
				this.governmentidField = value;
				base.RaisePropertyChanged("governmentid");
			}
		}

		[XmlElement] //[XmlElement(Order=54)]
		public string homephone
		{
			get
			{
				return this.homephoneField;
			}
			set
			{
				this.homephoneField = value;
				base.RaisePropertyChanged("homephone");
			}
		}

		[XmlElement] //[XmlElement(Order=55)]
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

		[XmlElement] //[XmlElement(Order=56)]
		public Picklist incomingemaildeliverymethod
		{
			get
			{
				return this.incomingemaildeliverymethodField;
			}
			set
			{
				this.incomingemaildeliverymethodField = value;
				base.RaisePropertyChanged("incomingemaildeliverymethod");
			}
		}

		[XmlElement] //[XmlElement(Order=57)]
		public string internalemailaddress
		{
			get
			{
				return this.internalemailaddressField;
			}
			set
			{
				this.internalemailaddressField = value;
				base.RaisePropertyChanged("internalemailaddress");
			}
		}

		[XmlElement] //[XmlElement(Order=58)]
		public Picklist invitestatuscode
		{
			get
			{
				return this.invitestatuscodeField;
			}
			set
			{
				this.invitestatuscodeField = value;
				base.RaisePropertyChanged("invitestatuscode");
			}
		}

		[XmlElement] //[XmlElement(Order=59)]
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

		[XmlElement] //[XmlElement(Order=60)]
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

		[XmlElement] //[XmlElement(Order=61)]
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

		[XmlElement] //[XmlElement(Order=62)]
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

		[XmlElement] //[XmlElement(Order=63)]
		public string mobilealertemail
		{
			get
			{
				return this.mobilealertemailField;
			}
			set
			{
				this.mobilealertemailField = value;
				base.RaisePropertyChanged("mobilealertemail");
			}
		}

		[XmlElement] //[XmlElement(Order=64)]
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

		[XmlElement] //[XmlElement(Order=65)]
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

		[XmlElement] //[XmlElement(Order=66)]
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

		[XmlElement] //[XmlElement(Order=67)]
		public string nickname
		{
			get
			{
				return this.nicknameField;
			}
			set
			{
				this.nicknameField = value;
				base.RaisePropertyChanged("nickname");
			}
		}

		[XmlElement] //[XmlElement(Order=68)]
		public UniqueIdentifier organizationid
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

		[XmlElement] //[XmlElement(Order=69)]
		public Picklist outgoingemaildeliverymethod
		{
			get
			{
				return this.outgoingemaildeliverymethodField;
			}
			set
			{
				this.outgoingemaildeliverymethodField = value;
				base.RaisePropertyChanged("outgoingemaildeliverymethod");
			}
		}

		[XmlElement] //[XmlElement(Order=70)]
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

		[XmlElement] //[XmlElement(Order=71)]
		public Lookup parentsystemuserid
		{
			get
			{
				return this.parentsystemuseridField;
			}
			set
			{
				this.parentsystemuseridField = value;
				base.RaisePropertyChanged("parentsystemuserid");
			}
		}

		[XmlElement] //[XmlElement(Order=72)]
		public CrmNumber passporthi
		{
			get
			{
				return this.passporthiField;
			}
			set
			{
				this.passporthiField = value;
				base.RaisePropertyChanged("passporthi");
			}
		}

		[XmlElement] //[XmlElement(Order=73)]
		public CrmNumber passportlo
		{
			get
			{
				return this.passportloField;
			}
			set
			{
				this.passportloField = value;
				base.RaisePropertyChanged("passportlo");
			}
		}

		[XmlElement] //[XmlElement(Order=74)]
		public string personalemailaddress
		{
			get
			{
				return this.personalemailaddressField;
			}
			set
			{
				this.personalemailaddressField = value;
				base.RaisePropertyChanged("personalemailaddress");
			}
		}

		[XmlElement] //[XmlElement(Order=75)]
		public string photourl
		{
			get
			{
				return this.photourlField;
			}
			set
			{
				this.photourlField = value;
				base.RaisePropertyChanged("photourl");
			}
		}

		[XmlElement] //[XmlElement(Order=76)]
		public Picklist preferredaddresscode
		{
			get
			{
				return this.preferredaddresscodeField;
			}
			set
			{
				this.preferredaddresscodeField = value;
				base.RaisePropertyChanged("preferredaddresscode");
			}
		}

		[XmlElement] //[XmlElement(Order=77)]
		public Picklist preferredemailcode
		{
			get
			{
				return this.preferredemailcodeField;
			}
			set
			{
				this.preferredemailcodeField = value;
				base.RaisePropertyChanged("preferredemailcode");
			}
		}

		[XmlElement] //[XmlElement(Order=78)]
		public Picklist preferredphonecode
		{
			get
			{
				return this.preferredphonecodeField;
			}
			set
			{
				this.preferredphonecodeField = value;
				base.RaisePropertyChanged("preferredphonecode");
			}
		}

		[XmlElement] //[XmlElement(Order=79)]
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

		[XmlElement] //[XmlElement(Order=80)]
		public CrmBoolean setupuser
		{
			get
			{
				return this.setupuserField;
			}
			set
			{
				this.setupuserField = value;
				base.RaisePropertyChanged("setupuser");
			}
		}

		[XmlElement] //[XmlElement(Order=81)]
		public string sgt_bondsnummer
		{
			get
			{
				return this.sgt_bondsnummerField;
			}
			set
			{
				this.sgt_bondsnummerField = value;
				base.RaisePropertyChanged("sgt_bondsnummer");
			}
		}

		[XmlElement] //[XmlElement(Order=82)]
		public Lookup sgt_persoonid
		{
			get
			{
				return this.sgt_persoonidField;
			}
			set
			{
				this.sgt_persoonidField = value;
				base.RaisePropertyChanged("sgt_persoonid");
			}
		}

		[XmlElement] //[XmlElement(Order=83)]
		public Lookup siteid
		{
			get
			{
				return this.siteidField;
			}
			set
			{
				this.siteidField = value;
				base.RaisePropertyChanged("siteid");
			}
		}

		[XmlElement] //[XmlElement(Order=84)]
		public string skills
		{
			get
			{
				return this.skillsField;
			}
			set
			{
				this.skillsField = value;
				base.RaisePropertyChanged("skills");
			}
		}

		[XmlElement] //[XmlElement(Order=85)]
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

		[XmlElement] //[XmlElement(Order=86)]
		public Lookup territoryid
		{
			get
			{
				return this.territoryidField;
			}
			set
			{
				this.territoryidField = value;
				base.RaisePropertyChanged("territoryid");
			}
		}

		[XmlElement] //[XmlElement(Order=87)]
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

		[XmlElement] //[XmlElement(Order=88)]
		public string title
		{
			get
			{
				return this.titleField;
			}
			set
			{
				this.titleField = value;
				base.RaisePropertyChanged("title");
			}
		}

		[XmlElement] //[XmlElement(Order=89)]
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

		[XmlElement] //[XmlElement(Order=90)]
		public string windowsliveid
		{
			get
			{
				return this.windowsliveidField;
			}
			set
			{
				this.windowsliveidField = value;
				base.RaisePropertyChanged("windowsliveid");
			}
		}

		[XmlElement] //[XmlElement(Order=91)]
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

		[XmlElement] //[XmlElement(Order=92)]
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

		[XmlElement] //[XmlElement(Order=93)]
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

		[XmlElement] //[XmlElement(Order=94)]
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

		public systemuser()
		{
		}
	}
}