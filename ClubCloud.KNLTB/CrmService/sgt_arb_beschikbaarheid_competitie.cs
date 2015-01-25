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
	public class sgt_arb_beschikbaarheid_competitie : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private string sgt_arb_arbitragebeschikbaarheid_competitieField;

		private Key sgt_arb_beschikbaarheid_competitieidField;

		private Lookup sgt_arbiteridField;

		private Lookup sgt_arbitragefunctieidField;

		private Lookup sgt_comptetitieidField;

		private Lookup sgt_klassengroepidField;

		private string sgt_opmerkingField;

		private Lookup sgt_piramideidField;

		private Picklist sgt_statusField;

		private CrmDateTime sgt_wedstrijddagField;

		private Sgt_arb_beschikbaarheid_competitieStateInfo statecodeField;

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
		public string sgt_arb_arbitragebeschikbaarheid_competitie
		{
			get
			{
				return this.sgt_arb_arbitragebeschikbaarheid_competitieField;
			}
			set
			{
				this.sgt_arb_arbitragebeschikbaarheid_competitieField = value;
				base.RaisePropertyChanged("sgt_arb_arbitragebeschikbaarheid_competitie");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public Key sgt_arb_beschikbaarheid_competitieid
		{
			get
			{
				return this.sgt_arb_beschikbaarheid_competitieidField;
			}
			set
			{
				this.sgt_arb_beschikbaarheid_competitieidField = value;
				base.RaisePropertyChanged("sgt_arb_beschikbaarheid_competitieid");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public Lookup sgt_arbiterid
		{
			get
			{
				return this.sgt_arbiteridField;
			}
			set
			{
				this.sgt_arbiteridField = value;
				base.RaisePropertyChanged("sgt_arbiterid");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public Lookup sgt_arbitragefunctieid
		{
			get
			{
				return this.sgt_arbitragefunctieidField;
			}
			set
			{
				this.sgt_arbitragefunctieidField = value;
				base.RaisePropertyChanged("sgt_arbitragefunctieid");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public Lookup sgt_comptetitieid
		{
			get
			{
				return this.sgt_comptetitieidField;
			}
			set
			{
				this.sgt_comptetitieidField = value;
				base.RaisePropertyChanged("sgt_comptetitieid");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public Lookup sgt_klassengroepid
		{
			get
			{
				return this.sgt_klassengroepidField;
			}
			set
			{
				this.sgt_klassengroepidField = value;
				base.RaisePropertyChanged("sgt_klassengroepid");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public string sgt_opmerking
		{
			get
			{
				return this.sgt_opmerkingField;
			}
			set
			{
				this.sgt_opmerkingField = value;
				base.RaisePropertyChanged("sgt_opmerking");
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

		[XmlElement] //[XmlElement(Order=17)]
		public CrmDateTime sgt_wedstrijddag
		{
			get
			{
				return this.sgt_wedstrijddagField;
			}
			set
			{
				this.sgt_wedstrijddagField = value;
				base.RaisePropertyChanged("sgt_wedstrijddag");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public Sgt_arb_beschikbaarheid_competitieStateInfo statecode
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

		public sgt_arb_beschikbaarheid_competitie()
		{
		}
	}
}