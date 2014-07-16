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
	public class sgt_com_controle_dispensatie_logboek : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private Key sgt_com_controle_dispensatie_logboekidField;

		private string sgt_com_naamField;

		private CrmDateTime sgt_controle_tmField;

		private CrmDateTime sgt_controle_vanafField;

		private CrmNumber sgt_min_aantal_wedstrijdenField;

		private Picklist sgt_soort_controleField;

		private Picklist sgt_statusField;

		private Sgt_com_controle_dispensatie_logboekStateInfo statecodeField;

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
		public Key sgt_com_controle_dispensatie_logboekid
		{
			get
			{
				return this.sgt_com_controle_dispensatie_logboekidField;
			}
			set
			{
				this.sgt_com_controle_dispensatie_logboekidField = value;
				base.RaisePropertyChanged("sgt_com_controle_dispensatie_logboekid");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
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

		[XmlElement] //[XmlElement(Order=10)]
		public CrmDateTime sgt_controle_tm
		{
			get
			{
				return this.sgt_controle_tmField;
			}
			set
			{
				this.sgt_controle_tmField = value;
				base.RaisePropertyChanged("sgt_controle_tm");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public CrmDateTime sgt_controle_vanaf
		{
			get
			{
				return this.sgt_controle_vanafField;
			}
			set
			{
				this.sgt_controle_vanafField = value;
				base.RaisePropertyChanged("sgt_controle_vanaf");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public CrmNumber sgt_min_aantal_wedstrijden
		{
			get
			{
				return this.sgt_min_aantal_wedstrijdenField;
			}
			set
			{
				this.sgt_min_aantal_wedstrijdenField = value;
				base.RaisePropertyChanged("sgt_min_aantal_wedstrijden");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public Picklist sgt_soort_controle
		{
			get
			{
				return this.sgt_soort_controleField;
			}
			set
			{
				this.sgt_soort_controleField = value;
				base.RaisePropertyChanged("sgt_soort_controle");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
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

		[XmlElement] //[XmlElement(Order=15)]
		public Sgt_com_controle_dispensatie_logboekStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=16)]
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

		[XmlElement] //[XmlElement(Order=17)]
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

		[XmlElement] //[XmlElement(Order=18)]
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

		public sgt_com_controle_dispensatie_logboek()
		{
		}
	}
}