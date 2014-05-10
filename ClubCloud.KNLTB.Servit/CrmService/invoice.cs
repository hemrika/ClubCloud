using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
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
		public string billto_city
		{
			get
			{
				return this.billto_cityField;
			}
			set
			{
				this.billto_cityField = value;
			}
		}
		public string billto_country
		{
			get
			{
				return this.billto_countryField;
			}
			set
			{
				this.billto_countryField = value;
			}
		}
		public string billto_fax
		{
			get
			{
				return this.billto_faxField;
			}
			set
			{
				this.billto_faxField = value;
			}
		}
		public string billto_line1
		{
			get
			{
				return this.billto_line1Field;
			}
			set
			{
				this.billto_line1Field = value;
			}
		}
		public string billto_line2
		{
			get
			{
				return this.billto_line2Field;
			}
			set
			{
				this.billto_line2Field = value;
			}
		}
		public string billto_line3
		{
			get
			{
				return this.billto_line3Field;
			}
			set
			{
				this.billto_line3Field = value;
			}
		}
		public string billto_name
		{
			get
			{
				return this.billto_nameField;
			}
			set
			{
				this.billto_nameField = value;
			}
		}
		public string billto_postalcode
		{
			get
			{
				return this.billto_postalcodeField;
			}
			set
			{
				this.billto_postalcodeField = value;
			}
		}
		public string billto_stateorprovince
		{
			get
			{
				return this.billto_stateorprovinceField;
			}
			set
			{
				this.billto_stateorprovinceField = value;
			}
		}
		public string billto_telephone
		{
			get
			{
				return this.billto_telephoneField;
			}
			set
			{
				this.billto_telephoneField = value;
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
		public Customer customerid
		{
			get
			{
				return this.customeridField;
			}
			set
			{
				this.customeridField = value;
			}
		}
		public CrmDateTime datedelivered
		{
			get
			{
				return this.datedeliveredField;
			}
			set
			{
				this.datedeliveredField = value;
			}
		}
		public string description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
			}
		}
		public CrmMoney discountamount
		{
			get
			{
				return this.discountamountField;
			}
			set
			{
				this.discountamountField = value;
			}
		}
		public CrmMoney discountamount_base
		{
			get
			{
				return this.discountamount_baseField;
			}
			set
			{
				this.discountamount_baseField = value;
			}
		}
		public CrmDecimal discountpercentage
		{
			get
			{
				return this.discountpercentageField;
			}
			set
			{
				this.discountpercentageField = value;
			}
		}
		public CrmDateTime duedate
		{
			get
			{
				return this.duedateField;
			}
			set
			{
				this.duedateField = value;
			}
		}
		public CrmDecimal exchangerate
		{
			get
			{
				return this.exchangerateField;
			}
			set
			{
				this.exchangerateField = value;
			}
		}
		public CrmMoney freightamount
		{
			get
			{
				return this.freightamountField;
			}
			set
			{
				this.freightamountField = value;
			}
		}
		public CrmMoney freightamount_base
		{
			get
			{
				return this.freightamount_baseField;
			}
			set
			{
				this.freightamount_baseField = value;
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
		public Key invoiceid
		{
			get
			{
				return this.invoiceidField;
			}
			set
			{
				this.invoiceidField = value;
			}
		}
		public string invoicenumber
		{
			get
			{
				return this.invoicenumberField;
			}
			set
			{
				this.invoicenumberField = value;
			}
		}
		public CrmBoolean ispricelocked
		{
			get
			{
				return this.ispricelockedField;
			}
			set
			{
				this.ispricelockedField = value;
			}
		}
		public CrmDateTime lastbackofficesubmit
		{
			get
			{
				return this.lastbackofficesubmitField;
			}
			set
			{
				this.lastbackofficesubmitField = value;
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
		public Lookup opportunityid
		{
			get
			{
				return this.opportunityidField;
			}
			set
			{
				this.opportunityidField = value;
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
		public Owner ownerid
		{
			get
			{
				return this.owneridField;
			}
			set
			{
				this.owneridField = value;
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
		public Picklist paymenttermscode
		{
			get
			{
				return this.paymenttermscodeField;
			}
			set
			{
				this.paymenttermscodeField = value;
			}
		}
		public Lookup pricelevelid
		{
			get
			{
				return this.pricelevelidField;
			}
			set
			{
				this.pricelevelidField = value;
			}
		}
		public Picklist pricingerrorcode
		{
			get
			{
				return this.pricingerrorcodeField;
			}
			set
			{
				this.pricingerrorcodeField = value;
			}
		}
		public Picklist prioritycode
		{
			get
			{
				return this.prioritycodeField;
			}
			set
			{
				this.prioritycodeField = value;
			}
		}
		public Lookup salesorderid
		{
			get
			{
				return this.salesorderidField;
			}
			set
			{
				this.salesorderidField = value;
			}
		}
		public Lookup sgt_administratieid
		{
			get
			{
				return this.sgt_administratieidField;
			}
			set
			{
				this.sgt_administratieidField = value;
			}
		}
		public CrmDateTime sgt_afas_exportdatum
		{
			get
			{
				return this.sgt_afas_exportdatumField;
			}
			set
			{
				this.sgt_afas_exportdatumField = value;
			}
		}
		public Picklist sgt_afas_exportstatus
		{
			get
			{
				return this.sgt_afas_exportstatusField;
			}
			set
			{
				this.sgt_afas_exportstatusField = value;
			}
		}
		public string sgt_afasnummer
		{
			get
			{
				return this.sgt_afasnummerField;
			}
			set
			{
				this.sgt_afasnummerField = value;
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
		public string sgt_bovenschrift_factuur
		{
			get
			{
				return this.sgt_bovenschrift_factuurField;
			}
			set
			{
				this.sgt_bovenschrift_factuurField = value;
			}
		}
		public Lookup sgt_campagneid
		{
			get
			{
				return this.sgt_campagneidField;
			}
			set
			{
				this.sgt_campagneidField = value;
			}
		}
		public CrmBoolean sgt_creditfactuur
		{
			get
			{
				return this.sgt_creditfactuurField;
			}
			set
			{
				this.sgt_creditfactuurField = value;
			}
		}
		public CrmDateTime sgt_factuur_datum
		{
			get
			{
				return this.sgt_factuur_datumField;
			}
			set
			{
				this.sgt_factuur_datumField = value;
			}
		}
		public Picklist sgt_factuurtype
		{
			get
			{
				return this.sgt_factuurtypeField;
			}
			set
			{
				this.sgt_factuurtypeField = value;
			}
		}
		public Lookup sgt_factuurverzamelingid
		{
			get
			{
				return this.sgt_factuurverzamelingidField;
			}
			set
			{
				this.sgt_factuurverzamelingidField = value;
			}
		}
		public Lookup sgt_logboek_fact_export_facturenid
		{
			get
			{
				return this.sgt_logboek_fact_export_facturenidField;
			}
			set
			{
				this.sgt_logboek_fact_export_facturenidField = value;
			}
		}
		public Lookup sgt_logboek_fact_import_betalingenid
		{
			get
			{
				return this.sgt_logboek_fact_import_betalingenidField;
			}
			set
			{
				this.sgt_logboek_fact_import_betalingenidField = value;
			}
		}
		public string sgt_onderschrift_factuur
		{
			get
			{
				return this.sgt_onderschrift_factuurField;
			}
			set
			{
				this.sgt_onderschrift_factuurField = value;
			}
		}
		public string sgt_organisatienummer
		{
			get
			{
				return this.sgt_organisatienummerField;
			}
			set
			{
				this.sgt_organisatienummerField = value;
			}
		}
		public Lookup sgt_orgfactuurid
		{
			get
			{
				return this.sgt_orgfactuuridField;
			}
			set
			{
				this.sgt_orgfactuuridField = value;
			}
		}
		public Picklist sgt_periode_jaar
		{
			get
			{
				return this.sgt_periode_jaarField;
			}
			set
			{
				this.sgt_periode_jaarField = value;
			}
		}
		public Picklist sgt_periode_kwartaal
		{
			get
			{
				return this.sgt_periode_kwartaalField;
			}
			set
			{
				this.sgt_periode_kwartaalField = value;
			}
		}
		public Picklist sgt_periode_maand
		{
			get
			{
				return this.sgt_periode_maandField;
			}
			set
			{
				this.sgt_periode_maandField = value;
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
		public string shipto_city
		{
			get
			{
				return this.shipto_cityField;
			}
			set
			{
				this.shipto_cityField = value;
			}
		}
		public string shipto_country
		{
			get
			{
				return this.shipto_countryField;
			}
			set
			{
				this.shipto_countryField = value;
			}
		}
		public string shipto_fax
		{
			get
			{
				return this.shipto_faxField;
			}
			set
			{
				this.shipto_faxField = value;
			}
		}
		public Picklist shipto_freighttermscode
		{
			get
			{
				return this.shipto_freighttermscodeField;
			}
			set
			{
				this.shipto_freighttermscodeField = value;
			}
		}
		public string shipto_line1
		{
			get
			{
				return this.shipto_line1Field;
			}
			set
			{
				this.shipto_line1Field = value;
			}
		}
		public string shipto_line2
		{
			get
			{
				return this.shipto_line2Field;
			}
			set
			{
				this.shipto_line2Field = value;
			}
		}
		public string shipto_line3
		{
			get
			{
				return this.shipto_line3Field;
			}
			set
			{
				this.shipto_line3Field = value;
			}
		}
		public string shipto_name
		{
			get
			{
				return this.shipto_nameField;
			}
			set
			{
				this.shipto_nameField = value;
			}
		}
		public string shipto_postalcode
		{
			get
			{
				return this.shipto_postalcodeField;
			}
			set
			{
				this.shipto_postalcodeField = value;
			}
		}
		public string shipto_stateorprovince
		{
			get
			{
				return this.shipto_stateorprovinceField;
			}
			set
			{
				this.shipto_stateorprovinceField = value;
			}
		}
		public string shipto_telephone
		{
			get
			{
				return this.shipto_telephoneField;
			}
			set
			{
				this.shipto_telephoneField = value;
			}
		}
		public InvoiceStateInfo statecode
		{
			get
			{
				return this.statecodeField;
			}
			set
			{
				this.statecodeField = value;
			}
		}
		public Status statuscode
		{
			get
			{
				return this.statuscodeField;
			}
			set
			{
				this.statuscodeField = value;
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
		public CrmMoney totalamount
		{
			get
			{
				return this.totalamountField;
			}
			set
			{
				this.totalamountField = value;
			}
		}
		public CrmMoney totalamount_base
		{
			get
			{
				return this.totalamount_baseField;
			}
			set
			{
				this.totalamount_baseField = value;
			}
		}
		public CrmMoney totalamountlessfreight
		{
			get
			{
				return this.totalamountlessfreightField;
			}
			set
			{
				this.totalamountlessfreightField = value;
			}
		}
		public CrmMoney totalamountlessfreight_base
		{
			get
			{
				return this.totalamountlessfreight_baseField;
			}
			set
			{
				this.totalamountlessfreight_baseField = value;
			}
		}
		public CrmMoney totaldiscountamount
		{
			get
			{
				return this.totaldiscountamountField;
			}
			set
			{
				this.totaldiscountamountField = value;
			}
		}
		public CrmMoney totaldiscountamount_base
		{
			get
			{
				return this.totaldiscountamount_baseField;
			}
			set
			{
				this.totaldiscountamount_baseField = value;
			}
		}
		public CrmMoney totallineitemamount
		{
			get
			{
				return this.totallineitemamountField;
			}
			set
			{
				this.totallineitemamountField = value;
			}
		}
		public CrmMoney totallineitemamount_base
		{
			get
			{
				return this.totallineitemamount_baseField;
			}
			set
			{
				this.totallineitemamount_baseField = value;
			}
		}
		public CrmMoney totallineitemdiscountamount
		{
			get
			{
				return this.totallineitemdiscountamountField;
			}
			set
			{
				this.totallineitemdiscountamountField = value;
			}
		}
		public CrmMoney totallineitemdiscountamount_base
		{
			get
			{
				return this.totallineitemdiscountamount_baseField;
			}
			set
			{
				this.totallineitemdiscountamount_baseField = value;
			}
		}
		public CrmMoney totaltax
		{
			get
			{
				return this.totaltaxField;
			}
			set
			{
				this.totaltaxField = value;
			}
		}
		public CrmMoney totaltax_base
		{
			get
			{
				return this.totaltax_baseField;
			}
			set
			{
				this.totaltax_baseField = value;
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
		public CrmBoolean willcall
		{
			get
			{
				return this.willcallField;
			}
			set
			{
				this.willcallField = value;
			}
		}
	}
}
