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
	public class sgt_toe_afwijkende_verdeling_geboortejaar : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private Lookup organizationidField;

		private CrmDateTime overriddencreatedonField;

		private Lookup sgt__automatische_acceptatieidField;

		private CrmNumber sgt_aantal_deelnemersField;

		private string sgt_geboortejaarField;

		private Lookup sgt_ranglijst_logboekidField;

		private Lookup sgt_ranglijstidField;

		private Key sgt_toe_afwijkende_verdeling_geboortejaaridField;

		private string sgt_toe_nameField;

		private Sgt_toe_afwijkende_verdeling_geboortejaarStateInfo statecodeField;

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
		public Lookup organizationid
		{
			get
			{
				return this.organizationidField;
			}
			set
			{
				this.organizationidField = value;
				base.RaisePropertyChanged("organizationid");
			}
		}

		[XmlElement] //[XmlElement(Order=6)]
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

		[XmlElement] //[XmlElement(Order=7)]
		public Lookup sgt__automatische_acceptatieid
		{
			get
			{
				return this.sgt__automatische_acceptatieidField;
			}
			set
			{
				this.sgt__automatische_acceptatieidField = value;
				base.RaisePropertyChanged("sgt__automatische_acceptatieid");
			}
		}

		[XmlElement] //[XmlElement(Order=8)]
		public CrmNumber sgt_aantal_deelnemers
		{
			get
			{
				return this.sgt_aantal_deelnemersField;
			}
			set
			{
				this.sgt_aantal_deelnemersField = value;
				base.RaisePropertyChanged("sgt_aantal_deelnemers");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public string sgt_geboortejaar
		{
			get
			{
				return this.sgt_geboortejaarField;
			}
			set
			{
				this.sgt_geboortejaarField = value;
				base.RaisePropertyChanged("sgt_geboortejaar");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public Lookup sgt_ranglijst_logboekid
		{
			get
			{
				return this.sgt_ranglijst_logboekidField;
			}
			set
			{
				this.sgt_ranglijst_logboekidField = value;
				base.RaisePropertyChanged("sgt_ranglijst_logboekid");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public Lookup sgt_ranglijstid
		{
			get
			{
				return this.sgt_ranglijstidField;
			}
			set
			{
				this.sgt_ranglijstidField = value;
				base.RaisePropertyChanged("sgt_ranglijstid");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public Key sgt_toe_afwijkende_verdeling_geboortejaarid
		{
			get
			{
				return this.sgt_toe_afwijkende_verdeling_geboortejaaridField;
			}
			set
			{
				this.sgt_toe_afwijkende_verdeling_geboortejaaridField = value;
				base.RaisePropertyChanged("sgt_toe_afwijkende_verdeling_geboortejaarid");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public string sgt_toe_name
		{
			get
			{
				return this.sgt_toe_nameField;
			}
			set
			{
				this.sgt_toe_nameField = value;
				base.RaisePropertyChanged("sgt_toe_name");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public Sgt_toe_afwijkende_verdeling_geboortejaarStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=15)]
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

		[XmlElement] //[XmlElement(Order=16)]
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

		[XmlElement] //[XmlElement(Order=17)]
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

		public sgt_toe_afwijkende_verdeling_geboortejaar()
		{
		}
	}
}