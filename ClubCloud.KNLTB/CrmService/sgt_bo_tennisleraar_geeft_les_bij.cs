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
	public class sgt_bo_tennisleraar_geeft_les_bij : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private string sgt_bo_tennisleraar_geeft_les_bij1Field;

		private Key sgt_bo_tennisleraar_geeft_les_bijidField;

		private CrmDateTime sgt_datum_tot_en_metField;

		private CrmDateTime sgt_datum_vanafField;

		private string sgt_functieField;

		private Lookup sgt_inschrijfformulier_testdagidField;

		private Lookup sgt_organisatieidField;

		private Lookup sgt_tennisleraaridField;

		private Sgt_bo_tennisleraar_geeft_les_bijStateInfo statecodeField;

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

		[XmlElement("sgt_bo_tennisleraar_geeft_les_bij")] //, Order=8)]
		public string sgt_bo_tennisleraar_geeft_les_bij1
		{
			get
			{
				return this.sgt_bo_tennisleraar_geeft_les_bij1Field;
			}
			set
			{
				this.sgt_bo_tennisleraar_geeft_les_bij1Field = value;
				base.RaisePropertyChanged("sgt_bo_tennisleraar_geeft_les_bij1");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public Key sgt_bo_tennisleraar_geeft_les_bijid
		{
			get
			{
				return this.sgt_bo_tennisleraar_geeft_les_bijidField;
			}
			set
			{
				this.sgt_bo_tennisleraar_geeft_les_bijidField = value;
				base.RaisePropertyChanged("sgt_bo_tennisleraar_geeft_les_bijid");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public CrmDateTime sgt_datum_tot_en_met
		{
			get
			{
				return this.sgt_datum_tot_en_metField;
			}
			set
			{
				this.sgt_datum_tot_en_metField = value;
				base.RaisePropertyChanged("sgt_datum_tot_en_met");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
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

		[XmlElement] //[XmlElement(Order=12)]
		public string sgt_functie
		{
			get
			{
				return this.sgt_functieField;
			}
			set
			{
				this.sgt_functieField = value;
				base.RaisePropertyChanged("sgt_functie");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public Lookup sgt_inschrijfformulier_testdagid
		{
			get
			{
				return this.sgt_inschrijfformulier_testdagidField;
			}
			set
			{
				this.sgt_inschrijfformulier_testdagidField = value;
				base.RaisePropertyChanged("sgt_inschrijfformulier_testdagid");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public Lookup sgt_organisatieid
		{
			get
			{
				return this.sgt_organisatieidField;
			}
			set
			{
				this.sgt_organisatieidField = value;
				base.RaisePropertyChanged("sgt_organisatieid");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public Lookup sgt_tennisleraarid
		{
			get
			{
				return this.sgt_tennisleraaridField;
			}
			set
			{
				this.sgt_tennisleraaridField = value;
				base.RaisePropertyChanged("sgt_tennisleraarid");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public Sgt_bo_tennisleraar_geeft_les_bijStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=17)]
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

		[XmlElement] //[XmlElement(Order=18)]
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

		[XmlElement] //[XmlElement(Order=19)]
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

		public sgt_bo_tennisleraar_geeft_les_bij()
		{
		}
	}
}