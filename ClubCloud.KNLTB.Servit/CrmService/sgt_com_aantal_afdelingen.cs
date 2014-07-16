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
	public class sgt_com_aantal_afdelingen : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private Lookup organizationidField;

		private CrmDateTime overriddencreatedonField;

		private CrmNumber sgt_aantal_afdelingen3Field;

		private CrmNumber sgt_aantal_afdelingen4Field;

		private CrmNumber sgt_aantal_afdelingen5Field;

		private CrmNumber sgt_aantal_afdelingen6Field;

		private CrmNumber sgt_aantal_afdelingen7Field;

		private CrmNumber sgt_aantal_afdelingen8Field;

		private CrmNumber sgt_aantal_inschrijvingenField;

		private Key sgt_com_aantal_afdelingenidField;

		private CrmNumber sgt_maximum_aantal_ploegenField;

		private string sgt_nameField;

		private Sgt_com_aantal_afdelingenStateInfo statecodeField;

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
		public CrmNumber sgt_aantal_afdelingen3
		{
			get
			{
				return this.sgt_aantal_afdelingen3Field;
			}
			set
			{
				this.sgt_aantal_afdelingen3Field = value;
				base.RaisePropertyChanged("sgt_aantal_afdelingen3");
			}
		}

		[XmlElement] //[XmlElement(Order=8)]
		public CrmNumber sgt_aantal_afdelingen4
		{
			get
			{
				return this.sgt_aantal_afdelingen4Field;
			}
			set
			{
				this.sgt_aantal_afdelingen4Field = value;
				base.RaisePropertyChanged("sgt_aantal_afdelingen4");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public CrmNumber sgt_aantal_afdelingen5
		{
			get
			{
				return this.sgt_aantal_afdelingen5Field;
			}
			set
			{
				this.sgt_aantal_afdelingen5Field = value;
				base.RaisePropertyChanged("sgt_aantal_afdelingen5");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public CrmNumber sgt_aantal_afdelingen6
		{
			get
			{
				return this.sgt_aantal_afdelingen6Field;
			}
			set
			{
				this.sgt_aantal_afdelingen6Field = value;
				base.RaisePropertyChanged("sgt_aantal_afdelingen6");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public CrmNumber sgt_aantal_afdelingen7
		{
			get
			{
				return this.sgt_aantal_afdelingen7Field;
			}
			set
			{
				this.sgt_aantal_afdelingen7Field = value;
				base.RaisePropertyChanged("sgt_aantal_afdelingen7");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public CrmNumber sgt_aantal_afdelingen8
		{
			get
			{
				return this.sgt_aantal_afdelingen8Field;
			}
			set
			{
				this.sgt_aantal_afdelingen8Field = value;
				base.RaisePropertyChanged("sgt_aantal_afdelingen8");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public CrmNumber sgt_aantal_inschrijvingen
		{
			get
			{
				return this.sgt_aantal_inschrijvingenField;
			}
			set
			{
				this.sgt_aantal_inschrijvingenField = value;
				base.RaisePropertyChanged("sgt_aantal_inschrijvingen");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public Key sgt_com_aantal_afdelingenid
		{
			get
			{
				return this.sgt_com_aantal_afdelingenidField;
			}
			set
			{
				this.sgt_com_aantal_afdelingenidField = value;
				base.RaisePropertyChanged("sgt_com_aantal_afdelingenid");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public CrmNumber sgt_maximum_aantal_ploegen
		{
			get
			{
				return this.sgt_maximum_aantal_ploegenField;
			}
			set
			{
				this.sgt_maximum_aantal_ploegenField = value;
				base.RaisePropertyChanged("sgt_maximum_aantal_ploegen");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public string sgt_name
		{
			get
			{
				return this.sgt_nameField;
			}
			set
			{
				this.sgt_nameField = value;
				base.RaisePropertyChanged("sgt_name");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public Sgt_com_aantal_afdelingenStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=18)]
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

		[XmlElement] //[XmlElement(Order=19)]
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

		[XmlElement] //[XmlElement(Order=20)]
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

		public sgt_com_aantal_afdelingen()
		{
		}
	}
}