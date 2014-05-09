using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_schemagrootte : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private CrmDateTime overriddencreatedonField;
		private CrmNumber sgt_aantal_kwalificantenField;
		private CrmNumber sgt_aantal_special_exemptsField;
		private CrmNumber sgt_aantal_te_accepterenField;
		private CrmNumber sgt_aantal_wildcardsField;
		private CrmBoolean sgt_afvalsysteemField;
		private string sgt_beschrijvingField;
		private CrmBoolean sgt_hoofdtoernooiField;
		private CrmBoolean sgt_kwalificatietoernooiField;
		private CrmNumber sgt_max_spelers_per_pouleField;
		private string sgt_omschrijvingField;
		private CrmBoolean sgt_partnerwisselsysteemField;
		private CrmBoolean sgt_poulesysteemField;
		private CrmBoolean sgt_rouleersysteemField;
		private string sgt_toe_schemagrootte1Field;
		private Key sgt_toe_schemagrootteidField;
		private Lookup sgt_toernooisoortidField;
		private string sgt_verkorte_codeField;
		private Sgt_toe_schemagrootteStateInfo statecodeField;
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
		[XmlElement(Order = 6)]
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
		[XmlElement(Order = 7)]
		public CrmNumber sgt_aantal_kwalificanten
		{
			get
			{
				return this.sgt_aantal_kwalificantenField;
			}
			set
			{
				this.sgt_aantal_kwalificantenField = value;
				base.RaisePropertyChanged("sgt_aantal_kwalificanten");
			}
		}
		[XmlElement(Order = 8)]
		public CrmNumber sgt_aantal_special_exempts
		{
			get
			{
				return this.sgt_aantal_special_exemptsField;
			}
			set
			{
				this.sgt_aantal_special_exemptsField = value;
				base.RaisePropertyChanged("sgt_aantal_special_exempts");
			}
		}
		[XmlElement(Order = 9)]
		public CrmNumber sgt_aantal_te_accepteren
		{
			get
			{
				return this.sgt_aantal_te_accepterenField;
			}
			set
			{
				this.sgt_aantal_te_accepterenField = value;
				base.RaisePropertyChanged("sgt_aantal_te_accepteren");
			}
		}
		[XmlElement(Order = 10)]
		public CrmNumber sgt_aantal_wildcards
		{
			get
			{
				return this.sgt_aantal_wildcardsField;
			}
			set
			{
				this.sgt_aantal_wildcardsField = value;
				base.RaisePropertyChanged("sgt_aantal_wildcards");
			}
		}
		[XmlElement(Order = 11)]
		public CrmBoolean sgt_afvalsysteem
		{
			get
			{
				return this.sgt_afvalsysteemField;
			}
			set
			{
				this.sgt_afvalsysteemField = value;
				base.RaisePropertyChanged("sgt_afvalsysteem");
			}
		}
		[XmlElement(Order = 12)]
		public string sgt_beschrijving
		{
			get
			{
				return this.sgt_beschrijvingField;
			}
			set
			{
				this.sgt_beschrijvingField = value;
				base.RaisePropertyChanged("sgt_beschrijving");
			}
		}
		[XmlElement(Order = 13)]
		public CrmBoolean sgt_hoofdtoernooi
		{
			get
			{
				return this.sgt_hoofdtoernooiField;
			}
			set
			{
				this.sgt_hoofdtoernooiField = value;
				base.RaisePropertyChanged("sgt_hoofdtoernooi");
			}
		}
		[XmlElement(Order = 14)]
		public CrmBoolean sgt_kwalificatietoernooi
		{
			get
			{
				return this.sgt_kwalificatietoernooiField;
			}
			set
			{
				this.sgt_kwalificatietoernooiField = value;
				base.RaisePropertyChanged("sgt_kwalificatietoernooi");
			}
		}
		[XmlElement(Order = 15)]
		public CrmNumber sgt_max_spelers_per_poule
		{
			get
			{
				return this.sgt_max_spelers_per_pouleField;
			}
			set
			{
				this.sgt_max_spelers_per_pouleField = value;
				base.RaisePropertyChanged("sgt_max_spelers_per_poule");
			}
		}
		[XmlElement(Order = 16)]
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
		[XmlElement(Order = 17)]
		public CrmBoolean sgt_partnerwisselsysteem
		{
			get
			{
				return this.sgt_partnerwisselsysteemField;
			}
			set
			{
				this.sgt_partnerwisselsysteemField = value;
				base.RaisePropertyChanged("sgt_partnerwisselsysteem");
			}
		}
		[XmlElement(Order = 18)]
		public CrmBoolean sgt_poulesysteem
		{
			get
			{
				return this.sgt_poulesysteemField;
			}
			set
			{
				this.sgt_poulesysteemField = value;
				base.RaisePropertyChanged("sgt_poulesysteem");
			}
		}
		[XmlElement(Order = 19)]
		public CrmBoolean sgt_rouleersysteem
		{
			get
			{
				return this.sgt_rouleersysteemField;
			}
			set
			{
				this.sgt_rouleersysteemField = value;
				base.RaisePropertyChanged("sgt_rouleersysteem");
			}
		}
		[XmlElement("sgt_toe_schemagrootte", Order = 20)]
		public string sgt_toe_schemagrootte1
		{
			get
			{
				return this.sgt_toe_schemagrootte1Field;
			}
			set
			{
				this.sgt_toe_schemagrootte1Field = value;
				base.RaisePropertyChanged("sgt_toe_schemagrootte1");
			}
		}
		[XmlElement(Order = 21)]
		public Key sgt_toe_schemagrootteid
		{
			get
			{
				return this.sgt_toe_schemagrootteidField;
			}
			set
			{
				this.sgt_toe_schemagrootteidField = value;
				base.RaisePropertyChanged("sgt_toe_schemagrootteid");
			}
		}
		[XmlElement(Order = 22)]
		public Lookup sgt_toernooisoortid
		{
			get
			{
				return this.sgt_toernooisoortidField;
			}
			set
			{
				this.sgt_toernooisoortidField = value;
				base.RaisePropertyChanged("sgt_toernooisoortid");
			}
		}
		[XmlElement(Order = 23)]
		public string sgt_verkorte_code
		{
			get
			{
				return this.sgt_verkorte_codeField;
			}
			set
			{
				this.sgt_verkorte_codeField = value;
				base.RaisePropertyChanged("sgt_verkorte_code");
			}
		}
		[XmlElement(Order = 24)]
		public Sgt_toe_schemagrootteStateInfo statecode
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
		[XmlElement(Order = 25)]
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
		[XmlElement(Order = 26)]
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
		[XmlElement(Order = 27)]
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
