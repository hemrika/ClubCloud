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
	public class sgt_alg_functionele_log : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private Key sgt_alg_functionele_logidField;

		private string sgt_boodschapField;

		private CrmDateTime sgt_datum_tijdField;

		private string sgt_entiteit_idField;

		private string sgt_entiteit_naamField;

		private string sgt_extra_informatieField;

		private string sgt_functie_naamField;

		private Picklist sgt_levelField;

		private string sgt_proces_idField;

		private string sgt_volgnummerField;

		private Sgt_alg_functionele_logStateInfo statecodeField;

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

		[XmlElement] //[XmlElement(Order=8)]
		public Key sgt_alg_functionele_logid
		{
			get
			{
				return this.sgt_alg_functionele_logidField;
			}
			set
			{
				this.sgt_alg_functionele_logidField = value;
				base.RaisePropertyChanged("sgt_alg_functionele_logid");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public string sgt_boodschap
		{
			get
			{
				return this.sgt_boodschapField;
			}
			set
			{
				this.sgt_boodschapField = value;
				base.RaisePropertyChanged("sgt_boodschap");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public CrmDateTime sgt_datum_tijd
		{
			get
			{
				return this.sgt_datum_tijdField;
			}
			set
			{
				this.sgt_datum_tijdField = value;
				base.RaisePropertyChanged("sgt_datum_tijd");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public string sgt_entiteit_id
		{
			get
			{
				return this.sgt_entiteit_idField;
			}
			set
			{
				this.sgt_entiteit_idField = value;
				base.RaisePropertyChanged("sgt_entiteit_id");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public string sgt_entiteit_naam
		{
			get
			{
				return this.sgt_entiteit_naamField;
			}
			set
			{
				this.sgt_entiteit_naamField = value;
				base.RaisePropertyChanged("sgt_entiteit_naam");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public string sgt_extra_informatie
		{
			get
			{
				return this.sgt_extra_informatieField;
			}
			set
			{
				this.sgt_extra_informatieField = value;
				base.RaisePropertyChanged("sgt_extra_informatie");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public string sgt_functie_naam
		{
			get
			{
				return this.sgt_functie_naamField;
			}
			set
			{
				this.sgt_functie_naamField = value;
				base.RaisePropertyChanged("sgt_functie_naam");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public Picklist sgt_level
		{
			get
			{
				return this.sgt_levelField;
			}
			set
			{
				this.sgt_levelField = value;
				base.RaisePropertyChanged("sgt_level");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public string sgt_proces_id
		{
			get
			{
				return this.sgt_proces_idField;
			}
			set
			{
				this.sgt_proces_idField = value;
				base.RaisePropertyChanged("sgt_proces_id");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public string sgt_volgnummer
		{
			get
			{
				return this.sgt_volgnummerField;
			}
			set
			{
				this.sgt_volgnummerField = value;
				base.RaisePropertyChanged("sgt_volgnummer");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public Sgt_alg_functionele_logStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=19)]
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

		[XmlElement] //[XmlElement(Order=20)]
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

		[XmlElement] //[XmlElement(Order=21)]
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

		public sgt_alg_functionele_log()
		{
		}
	}
}