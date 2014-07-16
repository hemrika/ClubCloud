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
	public class sgt_com_ploeginschrijving : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private CrmNumber sgt_aantal_ploegen_inschrijvenField;

		private CrmNumber sgt_aantal_ploegen_met_rechtenField;

		private string sgt_com_naamField;

		private Key sgt_com_ploeginschrijvingidField;

		private Lookup sgt_competitieidField;

		private Lookup sgt_competitieinschrijvingidField;

		private Lookup sgt_klassegroepidField;

		private Lookup sgt_piramideidField;

		private Lookup sgt_verenigingidField;

		private string sgt_verenigingsnummerField;

		private Sgt_com_ploeginschrijvingStateInfo statecodeField;

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
		public CrmNumber sgt_aantal_ploegen_inschrijven
		{
			get
			{
				return this.sgt_aantal_ploegen_inschrijvenField;
			}
			set
			{
				this.sgt_aantal_ploegen_inschrijvenField = value;
				base.RaisePropertyChanged("sgt_aantal_ploegen_inschrijven");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public CrmNumber sgt_aantal_ploegen_met_rechten
		{
			get
			{
				return this.sgt_aantal_ploegen_met_rechtenField;
			}
			set
			{
				this.sgt_aantal_ploegen_met_rechtenField = value;
				base.RaisePropertyChanged("sgt_aantal_ploegen_met_rechten");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public string sgt_com_naam
		{
			get
			{
				return this.sgt_com_naamField;
			}
			set
			{
				this.sgt_com_naamField = value;
				base.RaisePropertyChanged("sgt_com_naam");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public Key sgt_com_ploeginschrijvingid
		{
			get
			{
				return this.sgt_com_ploeginschrijvingidField;
			}
			set
			{
				this.sgt_com_ploeginschrijvingidField = value;
				base.RaisePropertyChanged("sgt_com_ploeginschrijvingid");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public Lookup sgt_competitieid
		{
			get
			{
				return this.sgt_competitieidField;
			}
			set
			{
				this.sgt_competitieidField = value;
				base.RaisePropertyChanged("sgt_competitieid");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public Lookup sgt_competitieinschrijvingid
		{
			get
			{
				return this.sgt_competitieinschrijvingidField;
			}
			set
			{
				this.sgt_competitieinschrijvingidField = value;
				base.RaisePropertyChanged("sgt_competitieinschrijvingid");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public Lookup sgt_klassegroepid
		{
			get
			{
				return this.sgt_klassegroepidField;
			}
			set
			{
				this.sgt_klassegroepidField = value;
				base.RaisePropertyChanged("sgt_klassegroepid");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public Lookup sgt_piramideid
		{
			get
			{
				return this.sgt_piramideidField;
			}
			set
			{
				this.sgt_piramideidField = value;
				base.RaisePropertyChanged("sgt_piramideid");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public Lookup sgt_verenigingid
		{
			get
			{
				return this.sgt_verenigingidField;
			}
			set
			{
				this.sgt_verenigingidField = value;
				base.RaisePropertyChanged("sgt_verenigingid");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public string sgt_verenigingsnummer
		{
			get
			{
				return this.sgt_verenigingsnummerField;
			}
			set
			{
				this.sgt_verenigingsnummerField = value;
				base.RaisePropertyChanged("sgt_verenigingsnummer");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public Sgt_com_ploeginschrijvingStateInfo statecode
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

		public sgt_com_ploeginschrijving()
		{
		}
	}
}