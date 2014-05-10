using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class customeraddress : BusinessEntity
	{
		private CrmNumber addressnumberField;
		private Picklist addresstypecodeField;
		private string cityField;
		private string countryField;
		private string countyField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private Key customeraddressidField;
		private string faxField;
		private Picklist freighttermscodeField;
		private CrmNumber importsequencenumberField;
		private CrmFloat latitudeField;
		private string line1Field;
		private string line2Field;
		private string line3Field;
		private CrmFloat longitudeField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private string nameField;
		private EntityNameReference objecttypecodeField;
		private CrmDateTime overriddencreatedonField;
		private Lookup owningbusinessunitField;
		private Lookup owninguserField;
		private Lookup parentidField;
		private string postalcodeField;
		private string postofficeboxField;
		private string primarycontactnameField;
		private CrmBoolean sgt_gebruik_afwijkende_naamField;
		private string sgt_landcodeidField;
		private Picklist shippingmethodcodeField;
		private string stateorprovinceField;
		private string telephone1Field;
		private string telephone2Field;
		private string telephone3Field;
		private CrmNumber timezoneruleversionnumberField;
		private string upszoneField;
		private CrmNumber utcconversiontimezonecodeField;
		private CrmNumber utcoffsetField;
		public CrmNumber addressnumber
		{
			get
			{
				return this.addressnumberField;
			}
			set
			{
				this.addressnumberField = value;
			}
		}
		public Picklist addresstypecode
		{
			get
			{
				return this.addresstypecodeField;
			}
			set
			{
				this.addresstypecodeField = value;
			}
		}
		public string city
		{
			get
			{
				return this.cityField;
			}
			set
			{
				this.cityField = value;
			}
		}
		public string country
		{
			get
			{
				return this.countryField;
			}
			set
			{
				this.countryField = value;
			}
		}
		public string county
		{
			get
			{
				return this.countyField;
			}
			set
			{
				this.countyField = value;
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
		public Key customeraddressid
		{
			get
			{
				return this.customeraddressidField;
			}
			set
			{
				this.customeraddressidField = value;
			}
		}
		public string fax
		{
			get
			{
				return this.faxField;
			}
			set
			{
				this.faxField = value;
			}
		}
		public Picklist freighttermscode
		{
			get
			{
				return this.freighttermscodeField;
			}
			set
			{
				this.freighttermscodeField = value;
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
		public CrmFloat latitude
		{
			get
			{
				return this.latitudeField;
			}
			set
			{
				this.latitudeField = value;
			}
		}
		public string line1
		{
			get
			{
				return this.line1Field;
			}
			set
			{
				this.line1Field = value;
			}
		}
		public string line2
		{
			get
			{
				return this.line2Field;
			}
			set
			{
				this.line2Field = value;
			}
		}
		public string line3
		{
			get
			{
				return this.line3Field;
			}
			set
			{
				this.line3Field = value;
			}
		}
		public CrmFloat longitude
		{
			get
			{
				return this.longitudeField;
			}
			set
			{
				this.longitudeField = value;
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
		public EntityNameReference objecttypecode
		{
			get
			{
				return this.objecttypecodeField;
			}
			set
			{
				this.objecttypecodeField = value;
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
		public Lookup owninguser
		{
			get
			{
				return this.owninguserField;
			}
			set
			{
				this.owninguserField = value;
			}
		}
		public Lookup parentid
		{
			get
			{
				return this.parentidField;
			}
			set
			{
				this.parentidField = value;
			}
		}
		public string postalcode
		{
			get
			{
				return this.postalcodeField;
			}
			set
			{
				this.postalcodeField = value;
			}
		}
		public string postofficebox
		{
			get
			{
				return this.postofficeboxField;
			}
			set
			{
				this.postofficeboxField = value;
			}
		}
		public string primarycontactname
		{
			get
			{
				return this.primarycontactnameField;
			}
			set
			{
				this.primarycontactnameField = value;
			}
		}
		public CrmBoolean sgt_gebruik_afwijkende_naam
		{
			get
			{
				return this.sgt_gebruik_afwijkende_naamField;
			}
			set
			{
				this.sgt_gebruik_afwijkende_naamField = value;
			}
		}
		public string sgt_landcodeid
		{
			get
			{
				return this.sgt_landcodeidField;
			}
			set
			{
				this.sgt_landcodeidField = value;
			}
		}
		public Picklist shippingmethodcode
		{
			get
			{
				return this.shippingmethodcodeField;
			}
			set
			{
				this.shippingmethodcodeField = value;
			}
		}
		public string stateorprovince
		{
			get
			{
				return this.stateorprovinceField;
			}
			set
			{
				this.stateorprovinceField = value;
			}
		}
		public string telephone1
		{
			get
			{
				return this.telephone1Field;
			}
			set
			{
				this.telephone1Field = value;
			}
		}
		public string telephone2
		{
			get
			{
				return this.telephone2Field;
			}
			set
			{
				this.telephone2Field = value;
			}
		}
		public string telephone3
		{
			get
			{
				return this.telephone3Field;
			}
			set
			{
				this.telephone3Field = value;
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
		public string upszone
		{
			get
			{
				return this.upszoneField;
			}
			set
			{
				this.upszoneField = value;
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
		public CrmNumber utcoffset
		{
			get
			{
				return this.utcoffsetField;
			}
			set
			{
				this.utcoffsetField = value;
			}
		}
	}
}
