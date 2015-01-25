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
	public class sgt_toe_toernooikalender : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private Picklist sgt_afdelingField;

		private CrmDateTime sgt_begindatumField;

		private Lookup sgt_bondsorganisatieidField;

		private Lookup sgt_districtidField;

		private CrmDateTime sgt_einddatumField;

		private CrmDateTime sgt_einde_beschikbaarheid_bgdField;

		private CrmBoolean sgt_email_her_bsb_bondgedelegeerde_verstuurdField;

		private CrmNumber sgt_herinnering_aantal_dagenField;

		private string sgt_omschrijvingField;

		private CrmDateTime sgt_start_beschikbaarheid_bgdField;

		private Picklist sgt_statusField;

		private string sgt_toe_toernooikalender1Field;

		private Key sgt_toe_toernooikalenderidField;

		private Picklist sgt_type_kalenderField;

		private Picklist sgt_type_toernooikalenderField;

		private Sgt_toe_toernooikalenderStateInfo statecodeField;

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
		public Picklist sgt_afdeling
		{
			get
			{
				return this.sgt_afdelingField;
			}
			set
			{
				this.sgt_afdelingField = value;
				base.RaisePropertyChanged("sgt_afdeling");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public CrmDateTime sgt_begindatum
		{
			get
			{
				return this.sgt_begindatumField;
			}
			set
			{
				this.sgt_begindatumField = value;
				base.RaisePropertyChanged("sgt_begindatum");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public Lookup sgt_bondsorganisatieid
		{
			get
			{
				return this.sgt_bondsorganisatieidField;
			}
			set
			{
				this.sgt_bondsorganisatieidField = value;
				base.RaisePropertyChanged("sgt_bondsorganisatieid");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public Lookup sgt_districtid
		{
			get
			{
				return this.sgt_districtidField;
			}
			set
			{
				this.sgt_districtidField = value;
				base.RaisePropertyChanged("sgt_districtid");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public CrmDateTime sgt_einddatum
		{
			get
			{
				return this.sgt_einddatumField;
			}
			set
			{
				this.sgt_einddatumField = value;
				base.RaisePropertyChanged("sgt_einddatum");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public CrmDateTime sgt_einde_beschikbaarheid_bgd
		{
			get
			{
				return this.sgt_einde_beschikbaarheid_bgdField;
			}
			set
			{
				this.sgt_einde_beschikbaarheid_bgdField = value;
				base.RaisePropertyChanged("sgt_einde_beschikbaarheid_bgd");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public CrmBoolean sgt_email_her_bsb_bondgedelegeerde_verstuurd
		{
			get
			{
				return this.sgt_email_her_bsb_bondgedelegeerde_verstuurdField;
			}
			set
			{
				this.sgt_email_her_bsb_bondgedelegeerde_verstuurdField = value;
				base.RaisePropertyChanged("sgt_email_her_bsb_bondgedelegeerde_verstuurd");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public CrmNumber sgt_herinnering_aantal_dagen
		{
			get
			{
				return this.sgt_herinnering_aantal_dagenField;
			}
			set
			{
				this.sgt_herinnering_aantal_dagenField = value;
				base.RaisePropertyChanged("sgt_herinnering_aantal_dagen");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public string sgt_omschrijving
		{
			get
			{
				return this.sgt_omschrijvingField;
			}
			set
			{
				this.sgt_omschrijvingField = value;
				base.RaisePropertyChanged("sgt_omschrijving");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public CrmDateTime sgt_start_beschikbaarheid_bgd
		{
			get
			{
				return this.sgt_start_beschikbaarheid_bgdField;
			}
			set
			{
				this.sgt_start_beschikbaarheid_bgdField = value;
				base.RaisePropertyChanged("sgt_start_beschikbaarheid_bgd");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
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

		[XmlElement("sgt_toe_toernooikalender")] //, Order=19)]
		public string sgt_toe_toernooikalender1
		{
			get
			{
				return this.sgt_toe_toernooikalender1Field;
			}
			set
			{
				this.sgt_toe_toernooikalender1Field = value;
				base.RaisePropertyChanged("sgt_toe_toernooikalender1");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public Key sgt_toe_toernooikalenderid
		{
			get
			{
				return this.sgt_toe_toernooikalenderidField;
			}
			set
			{
				this.sgt_toe_toernooikalenderidField = value;
				base.RaisePropertyChanged("sgt_toe_toernooikalenderid");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public Picklist sgt_type_kalender
		{
			get
			{
				return this.sgt_type_kalenderField;
			}
			set
			{
				this.sgt_type_kalenderField = value;
				base.RaisePropertyChanged("sgt_type_kalender");
			}
		}

		[XmlElement] //[XmlElement(Order=22)]
		public Picklist sgt_type_toernooikalender
		{
			get
			{
				return this.sgt_type_toernooikalenderField;
			}
			set
			{
				this.sgt_type_toernooikalenderField = value;
				base.RaisePropertyChanged("sgt_type_toernooikalender");
			}
		}

		[XmlElement] //[XmlElement(Order=23)]
		public Sgt_toe_toernooikalenderStateInfo statecode
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

		public sgt_toe_toernooikalender()
		{
		}
	}
}