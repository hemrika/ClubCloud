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
	public class sgt_alg_baan_keuring : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private Lookup sgt_accommodatie_idField;

		private Key sgt_alg_baan_keuringidField;

		private string sgt_alg_nameField;

		private Lookup sgt_baanblokidField;

		private Lookup sgt_baanidField;

		private CrmDateTime sgt_datum_keuringField;

		private Lookup sgt_gekeurd_door_organisatieidField;

		private Lookup sgt_gekeurddooridField;

		private string sgt_redenField;

		private Picklist sgt_status_keuringField;

		private Sgt_alg_baan_keuringStateInfo statecodeField;

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
		public Lookup sgt_accommodatie_id
		{
			get
			{
				return this.sgt_accommodatie_idField;
			}
			set
			{
				this.sgt_accommodatie_idField = value;
				base.RaisePropertyChanged("sgt_accommodatie_id");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public Key sgt_alg_baan_keuringid
		{
			get
			{
				return this.sgt_alg_baan_keuringidField;
			}
			set
			{
				this.sgt_alg_baan_keuringidField = value;
				base.RaisePropertyChanged("sgt_alg_baan_keuringid");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
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

		[XmlElement] //[XmlElement(Order=11)]
		public Lookup sgt_baanblokid
		{
			get
			{
				return this.sgt_baanblokidField;
			}
			set
			{
				this.sgt_baanblokidField = value;
				base.RaisePropertyChanged("sgt_baanblokid");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public Lookup sgt_baanid
		{
			get
			{
				return this.sgt_baanidField;
			}
			set
			{
				this.sgt_baanidField = value;
				base.RaisePropertyChanged("sgt_baanid");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public CrmDateTime sgt_datum_keuring
		{
			get
			{
				return this.sgt_datum_keuringField;
			}
			set
			{
				this.sgt_datum_keuringField = value;
				base.RaisePropertyChanged("sgt_datum_keuring");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public Lookup sgt_gekeurd_door_organisatieid
		{
			get
			{
				return this.sgt_gekeurd_door_organisatieidField;
			}
			set
			{
				this.sgt_gekeurd_door_organisatieidField = value;
				base.RaisePropertyChanged("sgt_gekeurd_door_organisatieid");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public Lookup sgt_gekeurddoorid
		{
			get
			{
				return this.sgt_gekeurddooridField;
			}
			set
			{
				this.sgt_gekeurddooridField = value;
				base.RaisePropertyChanged("sgt_gekeurddoorid");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public string sgt_reden
		{
			get
			{
				return this.sgt_redenField;
			}
			set
			{
				this.sgt_redenField = value;
				base.RaisePropertyChanged("sgt_reden");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public Picklist sgt_status_keuring
		{
			get
			{
				return this.sgt_status_keuringField;
			}
			set
			{
				this.sgt_status_keuringField = value;
				base.RaisePropertyChanged("sgt_status_keuring");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public Sgt_alg_baan_keuringStateInfo statecode
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

		public sgt_alg_baan_keuring()
		{
		}
	}
}