using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class invoice : BusinessEntity
	{
		private string billto_cityField;
		private string billto_countryField;
		private string billto_faxField;
		private string billto_line1Field;
		private string billto_line2Field;
		private string billto_line3Field;
		private string billto_nameField;
		private string billto_postalcodeField;
		private string billto_stateorprovinceField;
		private string billto_telephoneField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private Customer customeridField;
		private CrmDateTime datedeliveredField;
		private string descriptionField;
		private CrmMoney discountamountField;
		private CrmMoney discountamount_baseField;
		private CrmDecimal discountpercentageField;
		private CrmDateTime duedateField;
		private CrmDecimal exchangerateField;
		private CrmMoney freightamountField;
		private CrmMoney freightamount_baseField;
		private CrmNumber importsequencenumberField;
		private Key invoiceidField;
		private string invoicenumberField;
		private CrmBoolean ispricelockedField;
		private CrmDateTime lastbackofficesubmitField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private string nameField;
		private Lookup opportunityidField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Picklist paymenttermscodeField;
		private Lookup pricelevelidField;
		private Picklist pricingerrorcodeField;
		private Picklist prioritycodeField;
		private Lookup salesorderidField;
		private Lookup sgt_administratieidField;
		private CrmDateTime sgt_afas_exportdatumField;
		private Picklist sgt_afas_exportstatusField;
		private string sgt_afasnummerField;
		private string sgt_bondsnummerField;
		private string sgt_bovenschrift_factuurField;
		private Lookup sgt_campagneidField;
		private CrmBoolean sgt_creditfactuurField;
		private CrmDateTime sgt_factuur_datumField;
		private Picklist sgt_factuurtypeField;
		private Lookup sgt_factuurverzamelingidField;
		private Lookup sgt_logboek_fact_export_facturenidField;
		private Lookup sgt_logboek_fact_import_betalingenidField;
		private string sgt_onderschrift_factuurField;
		private string sgt_organisatienummerField;
		private Lookup sgt_orgfactuuridField;
		private Picklist sgt_periode_jaarField;
		private Picklist sgt_periode_kwartaalField;
		private Picklist sgt_periode_maandField;
		private Picklist shippingmethodcodeField;
		private string shipto_cityField;
		private string shipto_countryField;
		private string shipto_faxField;
		private Picklist shipto_freighttermscodeField;
		private string shipto_line1Field;
		private string shipto_line2Field;
		private string shipto_line3Field;
		private string shipto_nameField;
		private string shipto_postalcodeField;
		private string shipto_stateorprovinceField;
		private string shipto_telephoneField;
		private InvoiceStateInfo statecodeField;
		private Status statuscodeField;
		private CrmNumber timezoneruleversionnumberField;
		private CrmMoney totalamountField;
		private CrmMoney totalamount_baseField;
		private CrmMoney totalamountlessfreightField;
		private CrmMoney totalamountlessfreight_baseField;
		private CrmMoney totaldiscountamountField;
		private CrmMoney totaldiscountamount_baseField;
		private CrmMoney totallineitemamountField;
		private CrmMoney totallineitemamount_baseField;
		private CrmMoney totallineitemdiscountamountField;
		private CrmMoney totallineitemdiscountamount_baseField;
		private CrmMoney totaltaxField;
		private CrmMoney totaltax_baseField;
		private Lookup transactioncurrencyidField;
		private CrmNumber utcconversiontimezonecodeField;
		private CrmBoolean willcallField;
		[XmlElement(Order = 0)]
		public string billto_city
		{
			get
			{
				return this.billto_cityField;
			}
			set
			{
				this.billto_cityField = value;
				base.RaisePropertyChanged("billto_city");
			}
		}
		[XmlElement(Order = 1)]
		public string billto_country
		{
			get
			{
				return this.billto_countryField;
			}
			set
			{
				this.billto_countryField = value;
				base.RaisePropertyChanged("billto_country");
			}
		}
		[XmlElement(Order = 2)]
		public string billto_fax
		{
			get
			{
				return this.billto_faxField;
			}
			set
			{
				this.billto_faxField = value;
				base.RaisePropertyChanged("billto_fax");
			}
		}
		[XmlElement(Order = 3)]
		public string billto_line1
		{
			get
			{
				return this.billto_line1Field;
			}
			set
			{
				this.billto_line1Field = value;
				base.RaisePropertyChanged("billto_line1");
			}
		}
		[XmlElement(Order = 4)]
		public string billto_line2
		{
			get
			{
				return this.billto_line2Field;
			}
			set
			{
				this.billto_line2Field = value;
				base.RaisePropertyChanged("billto_line2");
			}
		}
		[XmlElement(Order = 5)]
		public string billto_line3
		{
			get
			{
				return this.billto_line3Field;
			}
			set
			{
				this.billto_line3Field = value;
				base.RaisePropertyChanged("billto_line3");
			}
		}
		[XmlElement(Order = 6)]
		public string billto_name
		{
			get
			{
				return this.billto_nameField;
			}
			set
			{
				this.billto_nameField = value;
				base.RaisePropertyChanged("billto_name");
			}
		}
		[XmlElement(Order = 7)]
		public string billto_postalcode
		{
			get
			{
				return this.billto_postalcodeField;
			}
			set
			{
				this.billto_postalcodeField = value;
				base.RaisePropertyChanged("billto_postalcode");
			}
		}
		[XmlElement(Order = 8)]
		public string billto_stateorprovince
		{
			get
			{
				return this.billto_stateorprovinceField;
			}
			set
			{
				this.billto_stateorprovinceField = value;
				base.RaisePropertyChanged("billto_stateorprovince");
			}
		}
		[XmlElement(Order = 9)]
		public string billto_telephone
		{
			get
			{
				return this.billto_telephoneField;
			}
			set
			{
				this.billto_telephoneField = value;
				base.RaisePropertyChanged("billto_telephone");
			}
		}
		[XmlElement(Order = 10)]
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
		[XmlElement(Order = 11)]
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
		[XmlElement(Order = 12)]
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
		[XmlElement(Order = 13)]
		public CrmDateTime datedelivered
		{
			get
			{
				return this.datedeliveredField;
			}
			set
			{
				this.datedeliveredField = value;
				base.RaisePropertyChanged("datedelivered");
			}
		}
		[XmlElement(Order = 14)]
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
		[XmlElement(Order = 15)]
		public CrmMoney discountamount
		{
			get
			{
				return this.discountamountField;
			}
			set
			{
				this.discountamountField = value;
				base.RaisePropertyChanged("discountamount");
			}
		}
		[XmlElement(Order = 16)]
		public CrmMoney discountamount_base
		{
			get
			{
				return this.discountamount_baseField;
			}
			set
			{
				this.discountamount_baseField = value;
				base.RaisePropertyChanged("discountamount_base");
			}
		}
		[XmlElement(Order = 17)]
		public CrmDecimal discountpercentage
		{
			get
			{
				return this.discountpercentageField;
			}
			set
			{
				this.discountpercentageField = value;
				base.RaisePropertyChanged("discountpercentage");
			}
		}
		[XmlElement(Order = 18)]
		public CrmDateTime duedate
		{
			get
			{
				return this.duedateField;
			}
			set
			{
				this.duedateField = value;
				base.RaisePropertyChanged("duedate");
			}
		}
		[XmlElement(Order = 19)]
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
		[XmlElement(Order = 20)]
		public CrmMoney freightamount
		{
			get
			{
				return this.freightamountField;
			}
			set
			{
				this.freightamountField = value;
				base.RaisePropertyChanged("freightamount");
			}
		}
		[XmlElement(Order = 21)]
		public CrmMoney freightamount_base
		{
			get
			{
				return this.freightamount_baseField;
			}
			set
			{
				this.freightamount_baseField = value;
				base.RaisePropertyChanged("freightamount_base");
			}
		}
		[XmlElement(Order = 22)]
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
		[XmlElement(Order = 23)]
		public Key invoiceid
		{
			get
			{
				return this.invoiceidField;
			}
			set
			{
				this.invoiceidField = value;
				base.RaisePropertyChanged("invoiceid");
			}
		}
		[XmlElement(Order = 24)]
		public string invoicenumber
		{
			get
			{
				return this.invoicenumberField;
			}
			set
			{
				this.invoicenumberField = value;
				base.RaisePropertyChanged("invoicenumber");
			}
		}
		[XmlElement(Order = 25)]
		public CrmBoolean ispricelocked
		{
			get
			{
				return this.ispricelockedField;
			}
			set
			{
				this.ispricelockedField = value;
				base.RaisePropertyChanged("ispricelocked");
			}
		}
		[XmlElement(Order = 26)]
		public CrmDateTime lastbackofficesubmit
		{
			get
			{
				return this.lastbackofficesubmitField;
			}
			set
			{
				this.lastbackofficesubmitField = value;
				base.RaisePropertyChanged("lastbackofficesubmit");
			}
		}
		[XmlElement(Order = 27)]
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
		[XmlElement(Order = 28)]
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
		[XmlElement(Order = 29)]
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
		[XmlElement(Order = 30)]
		public Lookup opportunityid
		{
			get
			{
				return this.opportunityidField;
			}
			set
			{
				this.opportunityidField = value;
				base.RaisePropertyChanged("opportunityid");
			}
		}
		[XmlElement(Order = 31)]
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
		[XmlElement(Order = 32)]
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
		[XmlElement(Order = 33)]
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
		[XmlElement(Order = 34)]
		public Picklist paymenttermscode
		{
			get
			{
				return this.paymenttermscodeField;
			}
			set
			{
				this.paymenttermscodeField = value;
				base.RaisePropertyChanged("paymenttermscode");
			}
		}
		[XmlElement(Order = 35)]
		public Lookup pricelevelid
		{
			get
			{
				return this.pricelevelidField;
			}
			set
			{
				this.pricelevelidField = value;
				base.RaisePropertyChanged("pricelevelid");
			}
		}
		[XmlElement(Order = 36)]
		public Picklist pricingerrorcode
		{
			get
			{
				return this.pricingerrorcodeField;
			}
			set
			{
				this.pricingerrorcodeField = value;
				base.RaisePropertyChanged("pricingerrorcode");
			}
		}
		[XmlElement(Order = 37)]
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
		[XmlElement(Order = 38)]
		public Lookup salesorderid
		{
			get
			{
				return this.salesorderidField;
			}
			set
			{
				this.salesorderidField = value;
				base.RaisePropertyChanged("salesorderid");
			}
		}
		[XmlElement(Order = 39)]
		public Lookup sgt_administratieid
		{
			get
			{
				return this.sgt_administratieidField;
			}
			set
			{
				this.sgt_administratieidField = value;
				base.RaisePropertyChanged("sgt_administratieid");
			}
		}
		[XmlElement(Order = 40)]
		public CrmDateTime sgt_afas_exportdatum
		{
			get
			{
				return this.sgt_afas_exportdatumField;
			}
			set
			{
				this.sgt_afas_exportdatumField = value;
				base.RaisePropertyChanged("sgt_afas_exportdatum");
			}
		}
		[XmlElement(Order = 41)]
		public Picklist sgt_afas_exportstatus
		{
			get
			{
				return this.sgt_afas_exportstatusField;
			}
			set
			{
				this.sgt_afas_exportstatusField = value;
				base.RaisePropertyChanged("sgt_afas_exportstatus");
			}
		}
		[XmlElement(Order = 42)]
		public string sgt_afasnummer
		{
			get
			{
				return this.sgt_afasnummerField;
			}
			set
			{
				this.sgt_afasnummerField = value;
				base.RaisePropertyChanged("sgt_afasnummer");
			}
		}
		[XmlElement(Order = 43)]
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
		[XmlElement(Order = 44)]
		public string sgt_bovenschrift_factuur
		{
			get
			{
				return this.sgt_bovenschrift_factuurField;
			}
			set
			{
				this.sgt_bovenschrift_factuurField = value;
				base.RaisePropertyChanged("sgt_bovenschrift_factuur");
			}
		}
		[XmlElement(Order = 45)]
		public Lookup sgt_campagneid
		{
			get
			{
				return this.sgt_campagneidField;
			}
			set
			{
				this.sgt_campagneidField = value;
				base.RaisePropertyChanged("sgt_campagneid");
			}
		}
		[XmlElement(Order = 46)]
		public CrmBoolean sgt_creditfactuur
		{
			get
			{
				return this.sgt_creditfactuurField;
			}
			set
			{
				this.sgt_creditfactuurField = value;
				base.RaisePropertyChanged("sgt_creditfactuur");
			}
		}
		[XmlElement(Order = 47)]
		public CrmDateTime sgt_factuur_datum
		{
			get
			{
				return this.sgt_factuur_datumField;
			}
			set
			{
				this.sgt_factuur_datumField = value;
				base.RaisePropertyChanged("sgt_factuur_datum");
			}
		}
		[XmlElement(Order = 48)]
		public Picklist sgt_factuurtype
		{
			get
			{
				return this.sgt_factuurtypeField;
			}
			set
			{
				this.sgt_factuurtypeField = value;
				base.RaisePropertyChanged("sgt_factuurtype");
			}
		}
		[XmlElement(Order = 49)]
		public Lookup sgt_factuurverzamelingid
		{
			get
			{
				return this.sgt_factuurverzamelingidField;
			}
			set
			{
				this.sgt_factuurverzamelingidField = value;
				base.RaisePropertyChanged("sgt_factuurverzamelingid");
			}
		}
		[XmlElement(Order = 50)]
		public Lookup sgt_logboek_fact_export_facturenid
		{
			get
			{
				return this.sgt_logboek_fact_export_facturenidField;
			}
			set
			{
				this.sgt_logboek_fact_export_facturenidField = value;
				base.RaisePropertyChanged("sgt_logboek_fact_export_facturenid");
			}
		}
		[XmlElement(Order = 51)]
		public Lookup sgt_logboek_fact_import_betalingenid
		{
			get
			{
				return this.sgt_logboek_fact_import_betalingenidField;
			}
			set
			{
				this.sgt_logboek_fact_import_betalingenidField = value;
				base.RaisePropertyChanged("sgt_logboek_fact_import_betalingenid");
			}
		}
		[XmlElement(Order = 52)]
		public string sgt_onderschrift_factuur
		{
			get
			{
				return this.sgt_onderschrift_factuurField;
			}
			set
			{
				this.sgt_onderschrift_factuurField = value;
				base.RaisePropertyChanged("sgt_onderschrift_factuur");
			}
		}
		[XmlElement(Order = 53)]
		public string sgt_organisatienummer
		{
			get
			{
				return this.sgt_organisatienummerField;
			}
			set
			{
				this.sgt_organisatienummerField = value;
				base.RaisePropertyChanged("sgt_organisatienummer");
			}
		}
		[XmlElement(Order = 54)]
		public Lookup sgt_orgfactuurid
		{
			get
			{
				return this.sgt_orgfactuuridField;
			}
			set
			{
				this.sgt_orgfactuuridField = value;
				base.RaisePropertyChanged("sgt_orgfactuurid");
			}
		}
		[XmlElement(Order = 55)]
		public Picklist sgt_periode_jaar
		{
			get
			{
				return this.sgt_periode_jaarField;
			}
			set
			{
				this.sgt_periode_jaarField = value;
				base.RaisePropertyChanged("sgt_periode_jaar");
			}
		}
		[XmlElement(Order = 56)]
		public Picklist sgt_periode_kwartaal
		{
			get
			{
				return this.sgt_periode_kwartaalField;
			}
			set
			{
				this.sgt_periode_kwartaalField = value;
				base.RaisePropertyChanged("sgt_periode_kwartaal");
			}
		}
		[XmlElement(Order = 57)]
		public Picklist sgt_periode_maand
		{
			get
			{
				return this.sgt_periode_maandField;
			}
			set
			{
				this.sgt_periode_maandField = value;
				base.RaisePropertyChanged("sgt_periode_maand");
			}
		}
		[XmlElement(Order = 58)]
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
		[XmlElement(Order = 59)]
		public string shipto_city
		{
			get
			{
				return this.shipto_cityField;
			}
			set
			{
				this.shipto_cityField = value;
				base.RaisePropertyChanged("shipto_city");
			}
		}
		[XmlElement(Order = 60)]
		public string shipto_country
		{
			get
			{
				return this.shipto_countryField;
			}
			set
			{
				this.shipto_countryField = value;
				base.RaisePropertyChanged("shipto_country");
			}
		}
		[XmlElement(Order = 61)]
		public string shipto_fax
		{
			get
			{
				return this.shipto_faxField;
			}
			set
			{
				this.shipto_faxField = value;
				base.RaisePropertyChanged("shipto_fax");
			}
		}
		[XmlElement(Order = 62)]
		public Picklist shipto_freighttermscode
		{
			get
			{
				return this.shipto_freighttermscodeField;
			}
			set
			{
				this.shipto_freighttermscodeField = value;
				base.RaisePropertyChanged("shipto_freighttermscode");
			}
		}
		[XmlElement(Order = 63)]
		public string shipto_line1
		{
			get
			{
				return this.shipto_line1Field;
			}
			set
			{
				this.shipto_line1Field = value;
				base.RaisePropertyChanged("shipto_line1");
			}
		}
		[XmlElement(Order = 64)]
		public string shipto_line2
		{
			get
			{
				return this.shipto_line2Field;
			}
			set
			{
				this.shipto_line2Field = value;
				base.RaisePropertyChanged("shipto_line2");
			}
		}
		[XmlElement(Order = 65)]
		public string shipto_line3
		{
			get
			{
				return this.shipto_line3Field;
			}
			set
			{
				this.shipto_line3Field = value;
				base.RaisePropertyChanged("shipto_line3");
			}
		}
		[XmlElement(Order = 66)]
		public string shipto_name
		{
			get
			{
				return this.shipto_nameField;
			}
			set
			{
				this.shipto_nameField = value;
				base.RaisePropertyChanged("shipto_name");
			}
		}
		[XmlElement(Order = 67)]
		public string shipto_postalcode
		{
			get
			{
				return this.shipto_postalcodeField;
			}
			set
			{
				this.shipto_postalcodeField = value;
				base.RaisePropertyChanged("shipto_postalcode");
			}
		}
		[XmlElement(Order = 68)]
		public string shipto_stateorprovince
		{
			get
			{
				return this.shipto_stateorprovinceField;
			}
			set
			{
				this.shipto_stateorprovinceField = value;
				base.RaisePropertyChanged("shipto_stateorprovince");
			}
		}
		[XmlElement(Order = 69)]
		public string shipto_telephone
		{
			get
			{
				return this.shipto_telephoneField;
			}
			set
			{
				this.shipto_telephoneField = value;
				base.RaisePropertyChanged("shipto_telephone");
			}
		}
		[XmlElement(Order = 70)]
		public InvoiceStateInfo statecode
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
		[XmlElement(Order = 71)]
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
		[XmlElement(Order = 72)]
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
		[XmlElement(Order = 73)]
		public CrmMoney totalamount
		{
			get
			{
				return this.totalamountField;
			}
			set
			{
				this.totalamountField = value;
				base.RaisePropertyChanged("totalamount");
			}
		}
		[XmlElement(Order = 74)]
		public CrmMoney totalamount_base
		{
			get
			{
				return this.totalamount_baseField;
			}
			set
			{
				this.totalamount_baseField = value;
				base.RaisePropertyChanged("totalamount_base");
			}
		}
		[XmlElement(Order = 75)]
		public CrmMoney totalamountlessfreight
		{
			get
			{
				return this.totalamountlessfreightField;
			}
			set
			{
				this.totalamountlessfreightField = value;
				base.RaisePropertyChanged("totalamountlessfreight");
			}
		}
		[XmlElement(Order = 76)]
		public CrmMoney totalamountlessfreight_base
		{
			get
			{
				return this.totalamountlessfreight_baseField;
			}
			set
			{
				this.totalamountlessfreight_baseField = value;
				base.RaisePropertyChanged("totalamountlessfreight_base");
			}
		}
		[XmlElement(Order = 77)]
		public CrmMoney totaldiscountamount
		{
			get
			{
				return this.totaldiscountamountField;
			}
			set
			{
				this.totaldiscountamountField = value;
				base.RaisePropertyChanged("totaldiscountamount");
			}
		}
		[XmlElement(Order = 78)]
		public CrmMoney totaldiscountamount_base
		{
			get
			{
				return this.totaldiscountamount_baseField;
			}
			set
			{
				this.totaldiscountamount_baseField = value;
				base.RaisePropertyChanged("totaldiscountamount_base");
			}
		}
		[XmlElement(Order = 79)]
		public CrmMoney totallineitemamount
		{
			get
			{
				return this.totallineitemamountField;
			}
			set
			{
				this.totallineitemamountField = value;
				base.RaisePropertyChanged("totallineitemamount");
			}
		}
		[XmlElement(Order = 80)]
		public CrmMoney totallineitemamount_base
		{
			get
			{
				return this.totallineitemamount_baseField;
			}
			set
			{
				this.totallineitemamount_baseField = value;
				base.RaisePropertyChanged("totallineitemamount_base");
			}
		}
		[XmlElement(Order = 81)]
		public CrmMoney totallineitemdiscountamount
		{
			get
			{
				return this.totallineitemdiscountamountField;
			}
			set
			{
				this.totallineitemdiscountamountField = value;
				base.RaisePropertyChanged("totallineitemdiscountamount");
			}
		}
		[XmlElement(Order = 82)]
		public CrmMoney totallineitemdiscountamount_base
		{
			get
			{
				return this.totallineitemdiscountamount_baseField;
			}
			set
			{
				this.totallineitemdiscountamount_baseField = value;
				base.RaisePropertyChanged("totallineitemdiscountamount_base");
			}
		}
		[XmlElement(Order = 83)]
		public CrmMoney totaltax
		{
			get
			{
				return this.totaltaxField;
			}
			set
			{
				this.totaltaxField = value;
				base.RaisePropertyChanged("totaltax");
			}
		}
		[XmlElement(Order = 84)]
		public CrmMoney totaltax_base
		{
			get
			{
				return this.totaltax_baseField;
			}
			set
			{
				this.totaltax_baseField = value;
				base.RaisePropertyChanged("totaltax_base");
			}
		}
		[XmlElement(Order = 85)]
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
		[XmlElement(Order = 86)]
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
		[XmlElement(Order = 87)]
		public CrmBoolean willcall
		{
			get
			{
				return this.willcallField;
			}
			set
			{
				this.willcallField = value;
				base.RaisePropertyChanged("willcall");
			}
		}
	}
}
