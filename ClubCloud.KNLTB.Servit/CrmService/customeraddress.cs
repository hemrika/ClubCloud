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

		[XmlElement] //[XmlElement(Order=0)]
		public CrmNumber addressnumber
		{
			get
			{
				return this.addressnumberField;
			}
			set
			{
				this.addressnumberField = value;
				base.RaisePropertyChanged("addressnumber");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public Picklist addresstypecode
		{
			get
			{
				return this.addresstypecodeField;
			}
			set
			{
				this.addresstypecodeField = value;
				base.RaisePropertyChanged("addresstypecode");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public string city
		{
			get
			{
				return this.cityField;
			}
			set
			{
				this.cityField = value;
				base.RaisePropertyChanged("city");
			}
		}

		[XmlElement] //[XmlElement(Order=3)]
		public string country
		{
			get
			{
				return this.countryField;
			}
			set
			{
				this.countryField = value;
				base.RaisePropertyChanged("country");
			}
		}

		[XmlElement] //[XmlElement(Order=4)]
		public string county
		{
			get
			{
				return this.countyField;
			}
			set
			{
				this.countyField = value;
				base.RaisePropertyChanged("county");
			}
		}

		[XmlElement] //[XmlElement(Order=5)]
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

		[XmlElement] //[XmlElement(Order=6)]
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

		[XmlElement] //[XmlElement(Order=7)]
		public Key customeraddressid
		{
			get
			{
				return this.customeraddressidField;
			}
			set
			{
				this.customeraddressidField = value;
				base.RaisePropertyChanged("customeraddressid");
			}
		}

		[XmlElement] //[XmlElement(Order=8)]
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

		[XmlElement] //[XmlElement(Order=9)]
		public Picklist freighttermscode
		{
			get
			{
				return this.freighttermscodeField;
			}
			set
			{
				this.freighttermscodeField = value;
				base.RaisePropertyChanged("freighttermscode");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
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

		[XmlElement] //[XmlElement(Order=11)]
		public CrmFloat latitude
		{
			get
			{
				return this.latitudeField;
			}
			set
			{
				this.latitudeField = value;
				base.RaisePropertyChanged("latitude");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public string line1
		{
			get
			{
				return this.line1Field;
			}
			set
			{
				this.line1Field = value;
				base.RaisePropertyChanged("line1");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public string line2
		{
			get
			{
				return this.line2Field;
			}
			set
			{
				this.line2Field = value;
				base.RaisePropertyChanged("line2");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public string line3
		{
			get
			{
				return this.line3Field;
			}
			set
			{
				this.line3Field = value;
				base.RaisePropertyChanged("line3");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public CrmFloat longitude
		{
			get
			{
				return this.longitudeField;
			}
			set
			{
				this.longitudeField = value;
				base.RaisePropertyChanged("longitude");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
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

		[XmlElement] //[XmlElement(Order=17)]
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

		[XmlElement] //[XmlElement(Order=18)]
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

		[XmlElement] //[XmlElement(Order=19)]
		public EntityNameReference objecttypecode
		{
			get
			{
				return this.objecttypecodeField;
			}
			set
			{
				this.objecttypecodeField = value;
				base.RaisePropertyChanged("objecttypecode");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
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

		[XmlElement] //[XmlElement(Order=21)]
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

		[XmlElement] //[XmlElement(Order=22)]
		public Lookup owninguser
		{
			get
			{
				return this.owninguserField;
			}
			set
			{
				this.owninguserField = value;
				base.RaisePropertyChanged("owninguser");
			}
		}

		[XmlElement] //[XmlElement(Order=23)]
		public Lookup parentid
		{
			get
			{
				return this.parentidField;
			}
			set
			{
				this.parentidField = value;
				base.RaisePropertyChanged("parentid");
			}
		}

		[XmlElement] //[XmlElement(Order=24)]
		public string postalcode
		{
			get
			{
				return this.postalcodeField;
			}
			set
			{
				this.postalcodeField = value;
				base.RaisePropertyChanged("postalcode");
			}
		}

		[XmlElement] //[XmlElement(Order=25)]
		public string postofficebox
		{
			get
			{
				return this.postofficeboxField;
			}
			set
			{
				this.postofficeboxField = value;
				base.RaisePropertyChanged("postofficebox");
			}
		}

		[XmlElement] //[XmlElement(Order=26)]
		public string primarycontactname
		{
			get
			{
				return this.primarycontactnameField;
			}
			set
			{
				this.primarycontactnameField = value;
				base.RaisePropertyChanged("primarycontactname");
			}
		}

		[XmlElement] //[XmlElement(Order=27)]
		public CrmBoolean sgt_gebruik_afwijkende_naam
		{
			get
			{
				return this.sgt_gebruik_afwijkende_naamField;
			}
			set
			{
				this.sgt_gebruik_afwijkende_naamField = value;
				base.RaisePropertyChanged("sgt_gebruik_afwijkende_naam");
			}
		}

		[XmlElement] //[XmlElement(Order=28)]
		public string sgt_landcodeid
		{
			get
			{
				return this.sgt_landcodeidField;
			}
			set
			{
				this.sgt_landcodeidField = value;
				base.RaisePropertyChanged("sgt_landcodeid");
			}
		}

		[XmlElement] //[XmlElement(Order=29)]
		public Picklist shippingmethodcode
		{
			get
			{
				return this.shippingmethodcodeField;
			}
			set
			{
				this.shippingmethodcodeField = value;
				base.RaisePropertyChanged("shippingmethodcode");
			}
		}

		[XmlElement] //[XmlElement(Order=30)]
		public string stateorprovince
		{
			get
			{
				return this.stateorprovinceField;
			}
			set
			{
				this.stateorprovinceField = value;
				base.RaisePropertyChanged("stateorprovince");
			}
		}

		[XmlElement] //[XmlElement(Order=31)]
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

		[XmlElement] //[XmlElement(Order=32)]
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

		[XmlElement] //[XmlElement(Order=33)]
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

		[XmlElement] //[XmlElement(Order=34)]
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

		[XmlElement] //[XmlElement(Order=35)]
		public string upszone
		{
			get
			{
				return this.upszoneField;
			}
			set
			{
				this.upszoneField = value;
				base.RaisePropertyChanged("upszone");
			}
		}

		[XmlElement] //[XmlElement(Order=36)]
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

		[XmlElement] //[XmlElement(Order=37)]
		public CrmNumber utcoffset
		{
			get
			{
				return this.utcoffsetField;
			}
			set
			{
				this.utcoffsetField = value;
				base.RaisePropertyChanged("utcoffset");
			}
		}

		public customeraddress()
		{
		}
	}
}