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
	public class sgt_toe_toernooi_resultaten : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private string sgt_bondsnummer_speler1Field;

		private string sgt_bondsnummer_speler2Field;

		private Lookup sgt_kwalificatiecode_idField;

		private string sgt_speler1Field;

		private string sgt_speler2Field;

		private Picklist sgt_spelsoortField;

		private string sgt_toe_toernooi_resultaatField;

		private Key sgt_toe_toernooi_resultatenidField;

		private Lookup sgt_toernooiidField;

		private Lookup sgt_toernooionderdeelField;

		private Lookup sgt_toernooispelerField;

		private CrmNumber sgt_tot_en_met_plaatsField;

		private CrmNumber sgt_vanaf_plaatsField;

		private Sgt_toe_toernooi_resultatenStateInfo statecodeField;

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
		public string sgt_bondsnummer_speler1
		{
			get
			{
				return this.sgt_bondsnummer_speler1Field;
			}
			set
			{
				this.sgt_bondsnummer_speler1Field = value;
				base.RaisePropertyChanged("sgt_bondsnummer_speler1");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public string sgt_bondsnummer_speler2
		{
			get
			{
				return this.sgt_bondsnummer_speler2Field;
			}
			set
			{
				this.sgt_bondsnummer_speler2Field = value;
				base.RaisePropertyChanged("sgt_bondsnummer_speler2");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public Lookup sgt_kwalificatiecode_id
		{
			get
			{
				return this.sgt_kwalificatiecode_idField;
			}
			set
			{
				this.sgt_kwalificatiecode_idField = value;
				base.RaisePropertyChanged("sgt_kwalificatiecode_id");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public string sgt_speler1
		{
			get
			{
				return this.sgt_speler1Field;
			}
			set
			{
				this.sgt_speler1Field = value;
				base.RaisePropertyChanged("sgt_speler1");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public string sgt_speler2
		{
			get
			{
				return this.sgt_speler2Field;
			}
			set
			{
				this.sgt_speler2Field = value;
				base.RaisePropertyChanged("sgt_speler2");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public Picklist sgt_spelsoort
		{
			get
			{
				return this.sgt_spelsoortField;
			}
			set
			{
				this.sgt_spelsoortField = value;
				base.RaisePropertyChanged("sgt_spelsoort");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public string sgt_toe_toernooi_resultaat
		{
			get
			{
				return this.sgt_toe_toernooi_resultaatField;
			}
			set
			{
				this.sgt_toe_toernooi_resultaatField = value;
				base.RaisePropertyChanged("sgt_toe_toernooi_resultaat");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public Key sgt_toe_toernooi_resultatenid
		{
			get
			{
				return this.sgt_toe_toernooi_resultatenidField;
			}
			set
			{
				this.sgt_toe_toernooi_resultatenidField = value;
				base.RaisePropertyChanged("sgt_toe_toernooi_resultatenid");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public Lookup sgt_toernooiid
		{
			get
			{
				return this.sgt_toernooiidField;
			}
			set
			{
				this.sgt_toernooiidField = value;
				base.RaisePropertyChanged("sgt_toernooiid");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public Lookup sgt_toernooionderdeel
		{
			get
			{
				return this.sgt_toernooionderdeelField;
			}
			set
			{
				this.sgt_toernooionderdeelField = value;
				base.RaisePropertyChanged("sgt_toernooionderdeel");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public Lookup sgt_toernooispeler
		{
			get
			{
				return this.sgt_toernooispelerField;
			}
			set
			{
				this.sgt_toernooispelerField = value;
				base.RaisePropertyChanged("sgt_toernooispeler");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public CrmNumber sgt_tot_en_met_plaats
		{
			get
			{
				return this.sgt_tot_en_met_plaatsField;
			}
			set
			{
				this.sgt_tot_en_met_plaatsField = value;
				base.RaisePropertyChanged("sgt_tot_en_met_plaats");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public CrmNumber sgt_vanaf_plaats
		{
			get
			{
				return this.sgt_vanaf_plaatsField;
			}
			set
			{
				this.sgt_vanaf_plaatsField = value;
				base.RaisePropertyChanged("sgt_vanaf_plaats");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public Sgt_toe_toernooi_resultatenStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=22)]
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

		[XmlElement] //[XmlElement(Order=23)]
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

		[XmlElement] //[XmlElement(Order=24)]
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

		public sgt_toe_toernooi_resultaten()
		{
		}
	}
}