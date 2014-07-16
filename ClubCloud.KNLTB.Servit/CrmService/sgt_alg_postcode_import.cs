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
	public class sgt_alg_postcode_import : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private string sgt_afsluitrecordField;

		private string sgt_alg_nameField;

		private Key sgt_alg_postcode_importidField;

		private string sgt_extra_informatieField;

		private string sgt_jaarField;

		private string sgt_lognummerField;

		private Picklist sgt_maandField;

		private string sgt_opvolgende_importField;

		private Picklist sgt_soortField;

		private Picklist sgt_statusField;

		private CrmDateTime sgt_verwerkingsdatumField;

		private Sgt_alg_postcode_importStateInfo statecodeField;

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
		public string sgt_afsluitrecord
		{
			get
			{
				return this.sgt_afsluitrecordField;
			}
			set
			{
				this.sgt_afsluitrecordField = value;
				base.RaisePropertyChanged("sgt_afsluitrecord");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public string sgt_alg_name
		{
			get
			{
				return this.sgt_alg_nameField;
			}
			set
			{
				this.sgt_alg_nameField = value;
				base.RaisePropertyChanged("sgt_alg_name");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public Key sgt_alg_postcode_importid
		{
			get
			{
				return this.sgt_alg_postcode_importidField;
			}
			set
			{
				this.sgt_alg_postcode_importidField = value;
				base.RaisePropertyChanged("sgt_alg_postcode_importid");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
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

		[XmlElement] //[XmlElement(Order=12)]
		public string sgt_jaar
		{
			get
			{
				return this.sgt_jaarField;
			}
			set
			{
				this.sgt_jaarField = value;
				base.RaisePropertyChanged("sgt_jaar");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
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

		[XmlElement] //[XmlElement(Order=14)]
		public Picklist sgt_maand
		{
			get
			{
				return this.sgt_maandField;
			}
			set
			{
				this.sgt_maandField = value;
				base.RaisePropertyChanged("sgt_maand");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public string sgt_opvolgende_import
		{
			get
			{
				return this.sgt_opvolgende_importField;
			}
			set
			{
				this.sgt_opvolgende_importField = value;
				base.RaisePropertyChanged("sgt_opvolgende_import");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
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

		[XmlElement] //[XmlElement(Order=17)]
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

		[XmlElement] //[XmlElement(Order=18)]
		public CrmDateTime sgt_verwerkingsdatum
		{
			get
			{
				return this.sgt_verwerkingsdatumField;
			}
			set
			{
				this.sgt_verwerkingsdatumField = value;
				base.RaisePropertyChanged("sgt_verwerkingsdatum");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public Sgt_alg_postcode_importStateInfo statecode
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

		public sgt_alg_postcode_import()
		{
		}
	}
}