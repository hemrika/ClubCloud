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
		public Lookup createdby
		{
			get
			{
				return this.createdbyField;
			}
			set
			{
				this.createdbyField = value;
			}
		}
		public CrmDateTime createdon
		{
			get
			{
				return this.createdonField;
			}
			set
			{
				this.createdonField = value;
			}
		}
		public CrmNumber importsequencenumber
		{
			get
			{
				return this.importsequencenumberField;
			}
			set
			{
				this.importsequencenumberField = value;
			}
		}
		public Lookup modifiedby
		{
			get
			{
				return this.modifiedbyField;
			}
			set
			{
				this.modifiedbyField = value;
			}
		}
		public CrmDateTime modifiedon
		{
			get
			{
				return this.modifiedonField;
			}
			set
			{
				this.modifiedonField = value;
			}
		}
		public CrmDateTime overriddencreatedon
		{
			get
			{
				return this.overriddencreatedonField;
			}
			set
			{
				this.overriddencreatedonField = value;
			}
		}
		public Owner ownerid
		{
			get
			{
				return this.owneridField;
			}
			set
			{
				this.owneridField = value;
			}
		}
		public Lookup owningbusinessunit
		{
			get
			{
				return this.owningbusinessunitField;
			}
			set
			{
				this.owningbusinessunitField = value;
			}
		}
		public CrmNumber sgt_aantal_wedstrijden_gespeeld
		{
			get
			{
				return this.sgt_aantal_wedstrijden_gespeeldField;
			}
			set
			{
				this.sgt_aantal_wedstrijden_gespeeldField = value;
			}
		}
		public Lookup sgt_afdelingid
		{
			get
			{
				return this.sgt_afdelingidField;
			}
			set
			{
				this.sgt_afdelingidField = value;
			}
		}
		public Lookup sgt_basisorganisatieid
		{
			get
			{
				return this.sgt_basisorganisatieidField;
			}
			set
			{
				this.sgt_basisorganisatieidField = value;
			}
		}
		[XmlElement("sgt_com_ingedeelde_ploeg")]
		public string sgt_com_ingedeelde_ploeg1
		{
			get
			{
				return this.sgt_com_ingedeelde_ploeg1Field;
			}
			set
			{
				this.sgt_com_ingedeelde_ploeg1Field = value;
			}
		}
		public Key sgt_com_ingedeelde_ploegid
		{
			get
			{
				return this.sgt_com_ingedeelde_ploegidField;
			}
			set
			{
				this.sgt_com_ingedeelde_ploegidField = value;
			}
		}
		public Lookup sgt_competitieid
		{
			get
			{
				return this.sgt_competitieidField;
			}
			set
			{
				this.sgt_competitieidField = value;
			}
		}
		public Lookup sgt_klassegroepid
		{
			get
			{
				return this.sgt_klassegroepidField;
			}
			set
			{
				this.sgt_klassegroepidField = value;
			}
		}
		public Lookup sgt_piramideid
		{
			get
			{
				return this.sgt_piramideidField;
			}
			set
			{
				this.sgt_piramideidField = value;
			}
		}
		public Lookup sgt_ploegid
		{
			get
			{
				return this.sgt_ploegidField;
			}
			set
			{
				this.sgt_ploegidField = value;
			}
		}
		public CrmNumber sgt_positie_in_stand
		{
			get
			{
				return this.sgt_positie_in_standField;
			}
			set
			{
				this.sgt_positie_in_standField = value;
			}
		}
		public Picklist sgt_status_in_stand
		{
			get
			{
				return this.sgt_status_in_standField;
			}
			set
			{
				this.sgt_status_in_standField = value;
			}
		}
		public CrmNumber sgt_volgnummer
		{
			get
			{
				return this.sgt_volgnummerField;
			}
			set
			{
				this.sgt_volgnummerField = value;
			}
		}
		public CrmNumber sgt_wedstrijden_gelijk
		{
			get
			{
				return this.sgt_wedstrijden_gelijkField;
			}
			set
			{
				this.sgt_wedstrijden_gelijkField = value;
			}
		}
		public CrmNumber sgt_wedstrijden_gewonnen
		{
			get
			{
				return this.sgt_wedstrijden_gewonnenField;
			}
			set
			{
				this.sgt_wedstrijden_gewonnenField = value;
			}
		}
		public CrmNumber sgt_wedstrijdenverloren
		{
			get
			{
				return this.sgt_wedstrijdenverlorenField;
			}
			set
			{
				this.sgt_wedstrijdenverlorenField = value;
			}
		}
		public CrmNumber sgt_wedstrijdpunten_tegen
		{
			get
			{
				return this.sgt_wedstrijdpunten_tegenField;
			}
			set
			{
				this.sgt_wedstrijdpunten_tegenField = value;
			}
		}
		public CrmNumber sgt_wedstrijdpunten_voor
		{
			get
			{
				return this.sgt_wedstrijdpunten_voorField;
			}
			set
			{
				this.sgt_wedstrijdpunten_voorField = value;
			}
		}
		public Sgt_com_ingedeelde_ploegStateInfo statecode
		{
			get
			{
				return this.statecodeField;
			}
			set
			{
				this.statecodeField = value;
			}
		}
		public Status statuscode
		{
			get
			{
				return this.statuscodeField;
			}
			set
			{
				this.statuscodeField = value;
			}
		}
		public CrmNumber timezoneruleversionnumber
		{
			get
			{
				return this.timezoneruleversionnumberField;
			}
			set
			{
				this.timezoneruleversionnumberField = value;
			}
		}
		public CrmNumber utcconversiontimezonecode
		{
			get
			{
				return this.utcconversiontimezonecodeField;
			}
			set
			{
				this.utcconversiontimezonecodeField = value;
			}
		}
	}
}
