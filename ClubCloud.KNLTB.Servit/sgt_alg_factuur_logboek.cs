using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_alg_factuur_logboek : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Lookup sgt_administratieidField;
		private Key sgt_alg_factuur_logboekidField;
		private string sgt_alg_lognummerField;
		private CrmBoolean sgt_automatisch_gestartField;
		private CrmDateTime sgt_betalingen_vanafField;
		private Picklist sgt_debiteuren_exportField;
		private CrmDateTime sgt_exporteren_tm_datumField;
		private CrmDateTime sgt_exporteren_vanaf_datumField;
		private string sgt_omschrijvingField;
		private Picklist sgt_soortField;
		private Picklist sgt_statusField;
		private Sgt_alg_factuur_logboekStateInfo statecodeField;
		private Status statuscodeField;
		private CrmNumber timezoneruleversionnumberField;
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
		[XmlElement(Order = 3)]
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
		[XmlElement(Order = 4)]
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
		[XmlElement(Order = 5)]
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
		[XmlElement(Order = 6)]
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
		[XmlElement(Order = 7)]
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
		[XmlElement(Order = 8)]
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
		[XmlElement(Order = 9)]
		public Key sgt_alg_factuur_logboekid
		{
			get
			{
				return this.sgt_alg_factuur_logboekidField;
			}
			set
			{
				this.sgt_alg_factuur_logboekidField = value;
				base.RaisePropertyChanged("sgt_alg_factuur_logboekid");
			}
		}
		[XmlElement(Order = 10)]
		public string sgt_alg_lognummer
		{
			get
			{
				return this.sgt_alg_lognummerField;
			}
			set
			{
				this.sgt_alg_lognummerField = value;
				base.RaisePropertyChanged("sgt_alg_lognummer");
			}
		}
		[XmlElement(Order = 11)]
		public CrmBoolean sgt_automatisch_gestart
		{
			get
			{
				return this.sgt_automatisch_gestartField;
			}
			set
			{
				this.sgt_automatisch_gestartField = value;
				base.RaisePropertyChanged("sgt_automatisch_gestart");
			}
		}
		[XmlElement(Order = 12)]
		public CrmDateTime sgt_betalingen_vanaf
		{
			get
			{
				return this.sgt_betalingen_vanafField;
			}
			set
			{
				this.sgt_betalingen_vanafField = value;
				base.RaisePropertyChanged("sgt_betalingen_vanaf");
			}
		}
		[XmlElement(Order = 13)]
		public Picklist sgt_debiteuren_export
		{
			get
			{
				return this.sgt_debiteuren_exportField;
			}
			set
			{
				this.sgt_debiteuren_exportField = value;
				base.RaisePropertyChanged("sgt_debiteuren_export");
			}
		}
		[XmlElement(Order = 14)]
		public CrmDateTime sgt_exporteren_tm_datum
		{
			get
			{
				return this.sgt_exporteren_tm_datumField;
			}
			set
			{
				this.sgt_exporteren_tm_datumField = value;
				base.RaisePropertyChanged("sgt_exporteren_tm_datum");
			}
		}
		[XmlElement(Order = 15)]
		public CrmDateTime sgt_exporteren_vanaf_datum
		{
			get
			{
				return this.sgt_exporteren_vanaf_datumField;
			}
			set
			{
				this.sgt_exporteren_vanaf_datumField = value;
				base.RaisePropertyChanged("sgt_exporteren_vanaf_datum");
			}
		}
		[XmlElement(Order = 16)]
		public string sgt_omschrijving
		{
			get
			{
				return this.sgt_omschrijvingField;
			}
			set
			{
				this.sgt_omschrijvingField = value;
				base.RaisePropertyChanged("sgt_omschrijving");
			}
		}
		[XmlElement(Order = 17)]
		public Picklist sgt_soort
		{
			get
			{
				return this.sgt_soortField;
			}
			set
			{
				this.sgt_soortField = value;
				base.RaisePropertyChanged("sgt_soort");
			}
		}
		[XmlElement(Order = 18)]
		public Picklist sgt_status
		{
			get
			{
				return this.sgt_statusField;
			}
			set
			{
				this.sgt_statusField = value;
				base.RaisePropertyChanged("sgt_status");
			}
		}
		[XmlElement(Order = 19)]
		public Sgt_alg_factuur_logboekStateInfo statecode
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
		[XmlElement(Order = 20)]
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
		[XmlElement(Order = 21)]
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
		[XmlElement(Order = 22)]
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
