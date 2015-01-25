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
	public class sgt_bo_cursist_examen : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private CrmBoolean sgt_betaaldField;

		private Key sgt_bo_cursist_examenidField;

		private string sgt_cursist_examenField;

		private Lookup sgt_cursistidField;

		private CrmDateTime sgt_datum_betalingField;

		private Lookup sgt_examenidField;

		private Lookup sgt_opleidingidField;

		private string sgt_opmerking_betalingField;

		private Lookup sgt_soortexamenidField;

		private Picklist sgt_status_examenField;

		private Sgt_bo_cursist_examenStateInfo statecodeField;

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
		public CrmBoolean sgt_betaald
		{
			get
			{
				return this.sgt_betaaldField;
			}
			set
			{
				this.sgt_betaaldField = value;
				base.RaisePropertyChanged("sgt_betaald");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public Key sgt_bo_cursist_examenid
		{
			get
			{
				return this.sgt_bo_cursist_examenidField;
			}
			set
			{
				this.sgt_bo_cursist_examenidField = value;
				base.RaisePropertyChanged("sgt_bo_cursist_examenid");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public string sgt_cursist_examen
		{
			get
			{
				return this.sgt_cursist_examenField;
			}
			set
			{
				this.sgt_cursist_examenField = value;
				base.RaisePropertyChanged("sgt_cursist_examen");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public Lookup sgt_cursistid
		{
			get
			{
				return this.sgt_cursistidField;
			}
			set
			{
				this.sgt_cursistidField = value;
				base.RaisePropertyChanged("sgt_cursistid");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public CrmDateTime sgt_datum_betaling
		{
			get
			{
				return this.sgt_datum_betalingField;
			}
			set
			{
				this.sgt_datum_betalingField = value;
				base.RaisePropertyChanged("sgt_datum_betaling");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public Lookup sgt_examenid
		{
			get
			{
				return this.sgt_examenidField;
			}
			set
			{
				this.sgt_examenidField = value;
				base.RaisePropertyChanged("sgt_examenid");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public Lookup sgt_opleidingid
		{
			get
			{
				return this.sgt_opleidingidField;
			}
			set
			{
				this.sgt_opleidingidField = value;
				base.RaisePropertyChanged("sgt_opleidingid");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public string sgt_opmerking_betaling
		{
			get
			{
				return this.sgt_opmerking_betalingField;
			}
			set
			{
				this.sgt_opmerking_betalingField = value;
				base.RaisePropertyChanged("sgt_opmerking_betaling");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public Lookup sgt_soortexamenid
		{
			get
			{
				return this.sgt_soortexamenidField;
			}
			set
			{
				this.sgt_soortexamenidField = value;
				base.RaisePropertyChanged("sgt_soortexamenid");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public Picklist sgt_status_examen
		{
			get
			{
				return this.sgt_status_examenField;
			}
			set
			{
				this.sgt_status_examenField = value;
				base.RaisePropertyChanged("sgt_status_examen");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public Sgt_bo_cursist_examenStateInfo statecode
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

		public sgt_bo_cursist_examen()
		{
		}
	}
}