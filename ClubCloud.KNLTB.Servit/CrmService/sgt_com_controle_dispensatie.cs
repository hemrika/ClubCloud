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
	public class sgt_com_controle_dispensatie : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private Key sgt_com_controle_dispensatieidField;

		private string sgt_com_naamField;

		private Lookup sgt_competitie_aidField;

		private Lookup sgt_competitie_bidField;

		private Lookup sgt_controle_dispensatie_logboekidField;

		private string sgt_extra_informatieField;

		private Lookup sgt_piramide_aidField;

		private Lookup sgt_piramide_bidField;

		private Lookup sgt_ploeg_aidField;

		private Lookup sgt_ploeg_bidField;

		private Picklist sgt_redenField;

		private Lookup sgt_speleridField;

		private Lookup sgt_spelersdispensatieidField;

		private Lookup sgt_vereniging_aidField;

		private Lookup sgt_vereniging_bidField;

		private Sgt_com_controle_dispensatieStateInfo statecodeField;

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
		public Key sgt_com_controle_dispensatieid
		{
			get
			{
				return this.sgt_com_controle_dispensatieidField;
			}
			set
			{
				this.sgt_com_controle_dispensatieidField = value;
				base.RaisePropertyChanged("sgt_com_controle_dispensatieid");
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
		public Lookup sgt_competitie_aid
		{
			get
			{
				return this.sgt_competitie_aidField;
			}
			set
			{
				this.sgt_competitie_aidField = value;
				base.RaisePropertyChanged("sgt_competitie_aid");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public Lookup sgt_competitie_bid
		{
			get
			{
				return this.sgt_competitie_bidField;
			}
			set
			{
				this.sgt_competitie_bidField = value;
				base.RaisePropertyChanged("sgt_competitie_bid");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public Lookup sgt_controle_dispensatie_logboekid
		{
			get
			{
				return this.sgt_controle_dispensatie_logboekidField;
			}
			set
			{
				this.sgt_controle_dispensatie_logboekidField = value;
				base.RaisePropertyChanged("sgt_controle_dispensatie_logboekid");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
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

		[XmlElement] //[XmlElement(Order=14)]
		public Lookup sgt_piramide_aid
		{
			get
			{
				return this.sgt_piramide_aidField;
			}
			set
			{
				this.sgt_piramide_aidField = value;
				base.RaisePropertyChanged("sgt_piramide_aid");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public Lookup sgt_piramide_bid
		{
			get
			{
				return this.sgt_piramide_bidField;
			}
			set
			{
				this.sgt_piramide_bidField = value;
				base.RaisePropertyChanged("sgt_piramide_bid");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public Lookup sgt_ploeg_aid
		{
			get
			{
				return this.sgt_ploeg_aidField;
			}
			set
			{
				this.sgt_ploeg_aidField = value;
				base.RaisePropertyChanged("sgt_ploeg_aid");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public Lookup sgt_ploeg_bid
		{
			get
			{
				return this.sgt_ploeg_bidField;
			}
			set
			{
				this.sgt_ploeg_bidField = value;
				base.RaisePropertyChanged("sgt_ploeg_bid");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public Picklist sgt_reden
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

		[XmlElement] //[XmlElement(Order=19)]
		public Lookup sgt_spelerid
		{
			get
			{
				return this.sgt_speleridField;
			}
			set
			{
				this.sgt_speleridField = value;
				base.RaisePropertyChanged("sgt_spelerid");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public Lookup sgt_spelersdispensatieid
		{
			get
			{
				return this.sgt_spelersdispensatieidField;
			}
			set
			{
				this.sgt_spelersdispensatieidField = value;
				base.RaisePropertyChanged("sgt_spelersdispensatieid");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public Lookup sgt_vereniging_aid
		{
			get
			{
				return this.sgt_vereniging_aidField;
			}
			set
			{
				this.sgt_vereniging_aidField = value;
				base.RaisePropertyChanged("sgt_vereniging_aid");
			}
		}

		[XmlElement] //[XmlElement(Order=22)]
		public Lookup sgt_vereniging_bid
		{
			get
			{
				return this.sgt_vereniging_bidField;
			}
			set
			{
				this.sgt_vereniging_bidField = value;
				base.RaisePropertyChanged("sgt_vereniging_bid");
			}
		}

		[XmlElement] //[XmlElement(Order=23)]
		public Sgt_com_controle_dispensatieStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=24)]
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

		[XmlElement] //[XmlElement(Order=25)]
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

		[XmlElement] //[XmlElement(Order=26)]
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

		public sgt_com_controle_dispensatie()
		{
		}
	}
}