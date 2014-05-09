using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_top_groep_deelnemers : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmDecimal exchangerateField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private CrmMoney sgt_bijdrageField;
		private CrmMoney sgt_bijdrage_baseField;
		private CrmMoney sgt_bijdrage_incl_kortingField;
		private CrmMoney sgt_bijdrage_incl_korting_baseField;
		private Lookup sgt_bondsorganisatieidField;
		private CrmDateTime sgt_datum_tmField;
		private CrmDateTime sgt_datum_vanafField;
		private Lookup sgt_districtidField;
		private Lookup sgt_geselecteerdtennisseridField;
		private Lookup sgt_groepidField;
		private CrmMoney sgt_kortingField;
		private CrmMoney sgt_korting_baseField;
		private CrmBoolean sgt_mag_gefactureerd_wordenField;
		private string sgt_omschrijving_factuurField;
		private Lookup sgt_predicaat_idField;
		private Lookup sgt_predicaatidField;
		private Lookup sgt_productidField;
		private string sgt_reden_kortingField;
		private string sgt_top_groep_deelnemers1Field;
		private Key sgt_top_groep_deelnemersidField;
		private Sgt_top_groep_deelnemersStateInfo statecodeField;
		private Status statuscodeField;
		private CrmNumber timezoneruleversionnumberField;
		private Lookup transactioncurrencyidField;
		private CrmNumber utcconversiontimezonecodeField;
		[XmlElement(Order = 0)]
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
		[XmlElement(Order = 1)]
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
		[XmlElement(Order = 2)]
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
		[XmlElement(Order = 3)]
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
		[XmlElement(Order = 4)]
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
		[XmlElement(Order = 5)]
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
		[XmlElement(Order = 6)]
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
		[XmlElement(Order = 7)]
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
		[XmlElement(Order = 8)]
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
		[XmlElement(Order = 9)]
		public CrmMoney sgt_bijdrage
		{
			get
			{
				return this.sgt_bijdrageField;
			}
			set
			{
				this.sgt_bijdrageField = value;
				base.RaisePropertyChanged("sgt_bijdrage");
			}
		}
		[XmlElement(Order = 10)]
		public CrmMoney sgt_bijdrage_base
		{
			get
			{
				return this.sgt_bijdrage_baseField;
			}
			set
			{
				this.sgt_bijdrage_baseField = value;
				base.RaisePropertyChanged("sgt_bijdrage_base");
			}
		}
		[XmlElement(Order = 11)]
		public CrmMoney sgt_bijdrage_incl_korting
		{
			get
			{
				return this.sgt_bijdrage_incl_kortingField;
			}
			set
			{
				this.sgt_bijdrage_incl_kortingField = value;
				base.RaisePropertyChanged("sgt_bijdrage_incl_korting");
			}
		}
		[XmlElement(Order = 12)]
		public CrmMoney sgt_bijdrage_incl_korting_base
		{
			get
			{
				return this.sgt_bijdrage_incl_korting_baseField;
			}
			set
			{
				this.sgt_bijdrage_incl_korting_baseField = value;
				base.RaisePropertyChanged("sgt_bijdrage_incl_korting_base");
			}
		}
		[XmlElement(Order = 13)]
		public Lookup sgt_bondsorganisatieid
		{
			get
			{
				return this.sgt_bondsorganisatieidField;
			}
			set
			{
				this.sgt_bondsorganisatieidField = value;
				base.RaisePropertyChanged("sgt_bondsorganisatieid");
			}
		}
		[XmlElement(Order = 14)]
		public CrmDateTime sgt_datum_tm
		{
			get
			{
				return this.sgt_datum_tmField;
			}
			set
			{
				this.sgt_datum_tmField = value;
				base.RaisePropertyChanged("sgt_datum_tm");
			}
		}
		[XmlElement(Order = 15)]
		public CrmDateTime sgt_datum_vanaf
		{
			get
			{
				return this.sgt_datum_vanafField;
			}
			set
			{
				this.sgt_datum_vanafField = value;
				base.RaisePropertyChanged("sgt_datum_vanaf");
			}
		}
		[XmlElement(Order = 16)]
		public Lookup sgt_districtid
		{
			get
			{
				return this.sgt_districtidField;
			}
			set
			{
				this.sgt_districtidField = value;
				base.RaisePropertyChanged("sgt_districtid");
			}
		}
		[XmlElement(Order = 17)]
		public Lookup sgt_geselecteerdtennisserid
		{
			get
			{
				return this.sgt_geselecteerdtennisseridField;
			}
			set
			{
				this.sgt_geselecteerdtennisseridField = value;
				base.RaisePropertyChanged("sgt_geselecteerdtennisserid");
			}
		}
		[XmlElement(Order = 18)]
		public Lookup sgt_groepid
		{
			get
			{
				return this.sgt_groepidField;
			}
			set
			{
				this.sgt_groepidField = value;
				base.RaisePropertyChanged("sgt_groepid");
			}
		}
		[XmlElement(Order = 19)]
		public CrmMoney sgt_korting
		{
			get
			{
				return this.sgt_kortingField;
			}
			set
			{
				this.sgt_kortingField = value;
				base.RaisePropertyChanged("sgt_korting");
			}
		}
		[XmlElement(Order = 20)]
		public CrmMoney sgt_korting_base
		{
			get
			{
				return this.sgt_korting_baseField;
			}
			set
			{
				this.sgt_korting_baseField = value;
				base.RaisePropertyChanged("sgt_korting_base");
			}
		}
		[XmlElement(Order = 21)]
		public CrmBoolean sgt_mag_gefactureerd_worden
		{
			get
			{
				return this.sgt_mag_gefactureerd_wordenField;
			}
			set
			{
				this.sgt_mag_gefactureerd_wordenField = value;
				base.RaisePropertyChanged("sgt_mag_gefactureerd_worden");
			}
		}
		[XmlElement(Order = 22)]
		public string sgt_omschrijving_factuur
		{
			get
			{
				return this.sgt_omschrijving_factuurField;
			}
			set
			{
				this.sgt_omschrijving_factuurField = value;
				base.RaisePropertyChanged("sgt_omschrijving_factuur");
			}
		}
		[XmlElement(Order = 23)]
		public Lookup sgt_predicaat_id
		{
			get
			{
				return this.sgt_predicaat_idField;
			}
			set
			{
				this.sgt_predicaat_idField = value;
				base.RaisePropertyChanged("sgt_predicaat_id");
			}
		}
		[XmlElement(Order = 24)]
		public Lookup sgt_predicaatid
		{
			get
			{
				return this.sgt_predicaatidField;
			}
			set
			{
				this.sgt_predicaatidField = value;
				base.RaisePropertyChanged("sgt_predicaatid");
			}
		}
		[XmlElement(Order = 25)]
		public Lookup sgt_productid
		{
			get
			{
				return this.sgt_productidField;
			}
			set
			{
				this.sgt_productidField = value;
				base.RaisePropertyChanged("sgt_productid");
			}
		}
		[XmlElement(Order = 26)]
		public string sgt_reden_korting
		{
			get
			{
				return this.sgt_reden_kortingField;
			}
			set
			{
				this.sgt_reden_kortingField = value;
				base.RaisePropertyChanged("sgt_reden_korting");
			}
		}
		[XmlElement("sgt_top_groep_deelnemers", Order = 27)]
		public string sgt_top_groep_deelnemers1
		{
			get
			{
				return this.sgt_top_groep_deelnemers1Field;
			}
			set
			{
				this.sgt_top_groep_deelnemers1Field = value;
				base.RaisePropertyChanged("sgt_top_groep_deelnemers1");
			}
		}
		[XmlElement(Order = 28)]
		public Key sgt_top_groep_deelnemersid
		{
			get
			{
				return this.sgt_top_groep_deelnemersidField;
			}
			set
			{
				this.sgt_top_groep_deelnemersidField = value;
				base.RaisePropertyChanged("sgt_top_groep_deelnemersid");
			}
		}
		[XmlElement(Order = 29)]
		public Sgt_top_groep_deelnemersStateInfo statecode
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
		[XmlElement(Order = 30)]
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
		[XmlElement(Order = 31)]
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
		[XmlElement(Order = 32)]
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
		[XmlElement(Order = 33)]
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
	}
}
