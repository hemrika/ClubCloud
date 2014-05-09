using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_ranglijstpunten_toernooiresultaat : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private CrmDecimal sgt_bonuspuntenField;
		private Lookup sgt_ranglijstidField;
		private CrmNumber sgt_ranglijstpuntenField;
		private Lookup sgt_speler1_idField;
		private Lookup sgt_speler2_idField;
		private CrmNumber sgt_strafpuntenField;
		private CrmBoolean sgt_telt_mee_voor_speler_1Field;
		private CrmBoolean sgt_telt_mee_voor_speler_2Field;
		private string sgt_toe_ranglijspunten_toernooiresultaatField;
		private Key sgt_toe_ranglijstpunten_toernooiresultaatidField;
		private Lookup sgt_toernooiidField;
		private Lookup sgt_toernooionderdeelidField;
		private Lookup sgt_toernooiresultaatidField;
		private Sgt_toe_ranglijstpunten_toernooiresultaatStateInfo statecodeField;
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
		public CrmDecimal sgt_bonuspunten
		{
			get
			{
				return this.sgt_bonuspuntenField;
			}
			set
			{
				this.sgt_bonuspuntenField = value;
				base.RaisePropertyChanged("sgt_bonuspunten");
			}
		}
		[XmlElement(Order = 9)]
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
		[XmlElement(Order = 10)]
		public CrmNumber sgt_ranglijstpunten
		{
			get
			{
				return this.sgt_ranglijstpuntenField;
			}
			set
			{
				this.sgt_ranglijstpuntenField = value;
				base.RaisePropertyChanged("sgt_ranglijstpunten");
			}
		}
		[XmlElement(Order = 11)]
		public Lookup sgt_speler1_id
		{
			get
			{
				return this.sgt_speler1_idField;
			}
			set
			{
				this.sgt_speler1_idField = value;
				base.RaisePropertyChanged("sgt_speler1_id");
			}
		}
		[XmlElement(Order = 12)]
		public Lookup sgt_speler2_id
		{
			get
			{
				return this.sgt_speler2_idField;
			}
			set
			{
				this.sgt_speler2_idField = value;
				base.RaisePropertyChanged("sgt_speler2_id");
			}
		}
		[XmlElement(Order = 13)]
		public CrmNumber sgt_strafpunten
		{
			get
			{
				return this.sgt_strafpuntenField;
			}
			set
			{
				this.sgt_strafpuntenField = value;
				base.RaisePropertyChanged("sgt_strafpunten");
			}
		}
		[XmlElement(Order = 14)]
		public CrmBoolean sgt_telt_mee_voor_speler_1
		{
			get
			{
				return this.sgt_telt_mee_voor_speler_1Field;
			}
			set
			{
				this.sgt_telt_mee_voor_speler_1Field = value;
				base.RaisePropertyChanged("sgt_telt_mee_voor_speler_1");
			}
		}
		[XmlElement(Order = 15)]
		public CrmBoolean sgt_telt_mee_voor_speler_2
		{
			get
			{
				return this.sgt_telt_mee_voor_speler_2Field;
			}
			set
			{
				this.sgt_telt_mee_voor_speler_2Field = value;
				base.RaisePropertyChanged("sgt_telt_mee_voor_speler_2");
			}
		}
		[XmlElement(Order = 16)]
		public string sgt_toe_ranglijspunten_toernooiresultaat
		{
			get
			{
				return this.sgt_toe_ranglijspunten_toernooiresultaatField;
			}
			set
			{
				this.sgt_toe_ranglijspunten_toernooiresultaatField = value;
				base.RaisePropertyChanged("sgt_toe_ranglijspunten_toernooiresultaat");
			}
		}
		[XmlElement(Order = 17)]
		public Key sgt_toe_ranglijstpunten_toernooiresultaatid
		{
			get
			{
				return this.sgt_toe_ranglijstpunten_toernooiresultaatidField;
			}
			set
			{
				this.sgt_toe_ranglijstpunten_toernooiresultaatidField = value;
				base.RaisePropertyChanged("sgt_toe_ranglijstpunten_toernooiresultaatid");
			}
		}
		[XmlElement(Order = 18)]
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
		[XmlElement(Order = 19)]
		public Lookup sgt_toernooionderdeelid
		{
			get
			{
				return this.sgt_toernooionderdeelidField;
			}
			set
			{
				this.sgt_toernooionderdeelidField = value;
				base.RaisePropertyChanged("sgt_toernooionderdeelid");
			}
		}
		[XmlElement(Order = 20)]
		public Lookup sgt_toernooiresultaatid
		{
			get
			{
				return this.sgt_toernooiresultaatidField;
			}
			set
			{
				this.sgt_toernooiresultaatidField = value;
				base.RaisePropertyChanged("sgt_toernooiresultaatid");
			}
		}
		[XmlElement(Order = 21)]
		public Sgt_toe_ranglijstpunten_toernooiresultaatStateInfo statecode
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
		[XmlElement(Order = 22)]
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
		[XmlElement(Order = 23)]
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
		[XmlElement(Order = 24)]
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
