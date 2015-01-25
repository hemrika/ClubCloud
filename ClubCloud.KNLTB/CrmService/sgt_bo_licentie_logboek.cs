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
	public class sgt_bo_licentie_logboek : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private string sgt_bo_licentie_logboek1Field;

		private Key sgt_bo_licentie_logboekidField;

		private CrmDateTime sgt_datum_exportField;

		private CrmBoolean sgt_export_aanmakenField;

		private string sgt_extra_info_exporterenField;

		private string sgt_licentie_geldig_tmField;

		private string sgt_licentie_geldig_vanafField;

		private Lookup sgt_licentieidField;

		private string sgt_lognummerField;

		private CrmBoolean sgt_opnieuwField;

		private Picklist sgt_status_exportenField;

		private Sgt_bo_licentie_logboekStateInfo statecodeField;

		private Status statuscodeField;

		private CrmNumber timezoneruleversionnumberField;

		private CrmNumber utcconversiontimezonecodeField;

		[XmlElement] //[XmlElement(Order=0)]
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

		[XmlElement] //[XmlElement(Order=1)]
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

		[XmlElement] //[XmlElement(Order=2)]
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

		[XmlElement] //[XmlElement(Order=3)]
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

		[XmlElement] //[XmlElement(Order=4)]
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

		[XmlElement] //[XmlElement(Order=5)]
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

		[XmlElement] //[XmlElement(Order=6)]
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

		[XmlElement] //[XmlElement(Order=7)]
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

		[XmlElement("sgt_bo_licentie_logboek")] //, Order=8)]
		public string sgt_bo_licentie_logboek1
		{
			get
			{
				return this.sgt_bo_licentie_logboek1Field;
			}
			set
			{
				this.sgt_bo_licentie_logboek1Field = value;
				base.RaisePropertyChanged("sgt_bo_licentie_logboek1");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public Key sgt_bo_licentie_logboekid
		{
			get
			{
				return this.sgt_bo_licentie_logboekidField;
			}
			set
			{
				this.sgt_bo_licentie_logboekidField = value;
				base.RaisePropertyChanged("sgt_bo_licentie_logboekid");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public CrmDateTime sgt_datum_export
		{
			get
			{
				return this.sgt_datum_exportField;
			}
			set
			{
				this.sgt_datum_exportField = value;
				base.RaisePropertyChanged("sgt_datum_export");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public CrmBoolean sgt_export_aanmaken
		{
			get
			{
				return this.sgt_export_aanmakenField;
			}
			set
			{
				this.sgt_export_aanmakenField = value;
				base.RaisePropertyChanged("sgt_export_aanmaken");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public string sgt_extra_info_exporteren
		{
			get
			{
				return this.sgt_extra_info_exporterenField;
			}
			set
			{
				this.sgt_extra_info_exporterenField = value;
				base.RaisePropertyChanged("sgt_extra_info_exporteren");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public string sgt_licentie_geldig_tm
		{
			get
			{
				return this.sgt_licentie_geldig_tmField;
			}
			set
			{
				this.sgt_licentie_geldig_tmField = value;
				base.RaisePropertyChanged("sgt_licentie_geldig_tm");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public string sgt_licentie_geldig_vanaf
		{
			get
			{
				return this.sgt_licentie_geldig_vanafField;
			}
			set
			{
				this.sgt_licentie_geldig_vanafField = value;
				base.RaisePropertyChanged("sgt_licentie_geldig_vanaf");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public Lookup sgt_licentieid
		{
			get
			{
				return this.sgt_licentieidField;
			}
			set
			{
				this.sgt_licentieidField = value;
				base.RaisePropertyChanged("sgt_licentieid");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public string sgt_lognummer
		{
			get
			{
				return this.sgt_lognummerField;
			}
			set
			{
				this.sgt_lognummerField = value;
				base.RaisePropertyChanged("sgt_lognummer");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public CrmBoolean sgt_opnieuw
		{
			get
			{
				return this.sgt_opnieuwField;
			}
			set
			{
				this.sgt_opnieuwField = value;
				base.RaisePropertyChanged("sgt_opnieuw");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public Picklist sgt_status_exporten
		{
			get
			{
				return this.sgt_status_exportenField;
			}
			set
			{
				this.sgt_status_exportenField = value;
				base.RaisePropertyChanged("sgt_status_exporten");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public Sgt_bo_licentie_logboekStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=20)]
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

		[XmlElement] //[XmlElement(Order=21)]
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

		[XmlElement] //[XmlElement(Order=22)]
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

		public sgt_bo_licentie_logboek()
		{
		}
	}
}