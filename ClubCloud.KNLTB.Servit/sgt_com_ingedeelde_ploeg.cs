using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_com_ingedeelde_ploeg : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private CrmNumber sgt_aantal_wedstrijden_gespeeldField;
		private Lookup sgt_afdelingidField;
		private Lookup sgt_basisorganisatieidField;
		private string sgt_com_ingedeelde_ploeg1Field;
		private Key sgt_com_ingedeelde_ploegidField;
		private Lookup sgt_competitieidField;
		private Lookup sgt_klassegroepidField;
		private Lookup sgt_piramideidField;
		private Lookup sgt_ploegidField;
		private CrmNumber sgt_positie_in_standField;
		private Picklist sgt_status_in_standField;
		private CrmNumber sgt_volgnummerField;
		private CrmNumber sgt_wedstrijden_gelijkField;
		private CrmNumber sgt_wedstrijden_gewonnenField;
		private CrmNumber sgt_wedstrijdenverlorenField;
		private CrmNumber sgt_wedstrijdpunten_tegenField;
		private CrmNumber sgt_wedstrijdpunten_voorField;
		private Sgt_com_ingedeelde_ploegStateInfo statecodeField;
		private Status statuscodeField;
		private CrmNumber timezoneruleversionnumberField;
		private CrmNumber utcconversiontimezonecodeField;
		[XmlElement(Order = 0)]
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
		[XmlElement(Order = 1)]
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
		[XmlElement(Order = 2)]
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
		[XmlElement(Order = 3)]
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
		[XmlElement(Order = 4)]
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
		[XmlElement(Order = 5)]
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
		[XmlElement(Order = 6)]
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
		[XmlElement(Order = 7)]
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
		[XmlElement(Order = 8)]
		public CrmNumber sgt_aantal_wedstrijden_gespeeld
		{
			get
			{
				return this.sgt_aantal_wedstrijden_gespeeldField;
			}
			set
			{
				this.sgt_aantal_wedstrijden_gespeeldField = value;
				base.RaisePropertyChanged("sgt_aantal_wedstrijden_gespeeld");
			}
		}
		[XmlElement(Order = 9)]
		public Lookup sgt_afdelingid
		{
			get
			{
				return this.sgt_afdelingidField;
			}
			set
			{
				this.sgt_afdelingidField = value;
				base.RaisePropertyChanged("sgt_afdelingid");
			}
		}
		[XmlElement(Order = 10)]
		public Lookup sgt_basisorganisatieid
		{
			get
			{
				return this.sgt_basisorganisatieidField;
			}
			set
			{
				this.sgt_basisorganisatieidField = value;
				base.RaisePropertyChanged("sgt_basisorganisatieid");
			}
		}
		[XmlElement("sgt_com_ingedeelde_ploeg", Order = 11)]
		public string sgt_com_ingedeelde_ploeg1
		{
			get
			{
				return this.sgt_com_ingedeelde_ploeg1Field;
			}
			set
			{
				this.sgt_com_ingedeelde_ploeg1Field = value;
				base.RaisePropertyChanged("sgt_com_ingedeelde_ploeg1");
			}
		}
		[XmlElement(Order = 12)]
		public Key sgt_com_ingedeelde_ploegid
		{
			get
			{
				return this.sgt_com_ingedeelde_ploegidField;
			}
			set
			{
				this.sgt_com_ingedeelde_ploegidField = value;
				base.RaisePropertyChanged("sgt_com_ingedeelde_ploegid");
			}
		}
		[XmlElement(Order = 13)]
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
		[XmlElement(Order = 14)]
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
		[XmlElement(Order = 15)]
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
		[XmlElement(Order = 16)]
		public Lookup sgt_ploegid
		{
			get
			{
				return this.sgt_ploegidField;
			}
			set
			{
				this.sgt_ploegidField = value;
				base.RaisePropertyChanged("sgt_ploegid");
			}
		}
		[XmlElement(Order = 17)]
		public CrmNumber sgt_positie_in_stand
		{
			get
			{
				return this.sgt_positie_in_standField;
			}
			set
			{
				this.sgt_positie_in_standField = value;
				base.RaisePropertyChanged("sgt_positie_in_stand");
			}
		}
		[XmlElement(Order = 18)]
		public Picklist sgt_status_in_stand
		{
			get
			{
				return this.sgt_status_in_standField;
			}
			set
			{
				this.sgt_status_in_standField = value;
				base.RaisePropertyChanged("sgt_status_in_stand");
			}
		}
		[XmlElement(Order = 19)]
		public CrmNumber sgt_volgnummer
		{
			get
			{
				return this.sgt_volgnummerField;
			}
			set
			{
				this.sgt_volgnummerField = value;
				base.RaisePropertyChanged("sgt_volgnummer");
			}
		}
		[XmlElement(Order = 20)]
		public CrmNumber sgt_wedstrijden_gelijk
		{
			get
			{
				return this.sgt_wedstrijden_gelijkField;
			}
			set
			{
				this.sgt_wedstrijden_gelijkField = value;
				base.RaisePropertyChanged("sgt_wedstrijden_gelijk");
			}
		}
		[XmlElement(Order = 21)]
		public CrmNumber sgt_wedstrijden_gewonnen
		{
			get
			{
				return this.sgt_wedstrijden_gewonnenField;
			}
			set
			{
				this.sgt_wedstrijden_gewonnenField = value;
				base.RaisePropertyChanged("sgt_wedstrijden_gewonnen");
			}
		}
		[XmlElement(Order = 22)]
		public CrmNumber sgt_wedstrijdenverloren
		{
			get
			{
				return this.sgt_wedstrijdenverlorenField;
			}
			set
			{
				this.sgt_wedstrijdenverlorenField = value;
				base.RaisePropertyChanged("sgt_wedstrijdenverloren");
			}
		}
		[XmlElement(Order = 23)]
		public CrmNumber sgt_wedstrijdpunten_tegen
		{
			get
			{
				return this.sgt_wedstrijdpunten_tegenField;
			}
			set
			{
				this.sgt_wedstrijdpunten_tegenField = value;
				base.RaisePropertyChanged("sgt_wedstrijdpunten_tegen");
			}
		}
		[XmlElement(Order = 24)]
		public CrmNumber sgt_wedstrijdpunten_voor
		{
			get
			{
				return this.sgt_wedstrijdpunten_voorField;
			}
			set
			{
				this.sgt_wedstrijdpunten_voorField = value;
				base.RaisePropertyChanged("sgt_wedstrijdpunten_voor");
			}
		}
		[XmlElement(Order = 25)]
		public Sgt_com_ingedeelde_ploegStateInfo statecode
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
		[XmlElement(Order = 26)]
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
		[XmlElement(Order = 27)]
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
		[XmlElement(Order = 28)]
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
	}
}
