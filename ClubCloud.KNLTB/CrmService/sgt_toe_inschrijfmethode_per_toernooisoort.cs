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
	public class sgt_toe_inschrijfmethode_per_toernooisoort : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private Lookup organizationidField;

		private CrmDateTime overriddencreatedonField;

		private CrmBoolean sgt_1e_keus_1Field;

		private CrmBoolean sgt_1e_keus_2Field;

		private CrmBoolean sgt_1e_keus_3Field;

		private CrmBoolean sgt_1e_keus_iField;

		private CrmBoolean sgt_2e_keus_1Field;

		private CrmBoolean sgt_2e_keus_2Field;

		private CrmBoolean sgt_2e_keus_3Field;

		private CrmBoolean sgt_2e_keus_iField;

		private CrmBoolean sgt_3e_keus_1Field;

		private CrmBoolean sgt_3e_keus_2Field;

		private CrmBoolean sgt_3e_keus_3Field;

		private CrmBoolean sgt_3e_keus_iField;

		private string sgt_beschrijvingField;

		private Lookup sgt_bij_inschrijving_opidField;

		private CrmBoolean sgt_controle_gelijke_keuzeField;

		private CrmBoolean sgt_inschrijving_1Field;

		private CrmBoolean sgt_inschrijving_2Field;

		private CrmBoolean sgt_inschrijving_3Field;

		private CrmBoolean sgt_inschrijving_iField;

		private string sgt_omschrijvingField;

		private CrmBoolean sgt_periode_moet_gelijk_zijnField;

		private string sgt_toe_inschrijfmethodeField;

		private Key sgt_toe_inschrijfmethode_per_toernooisoortidField;

		private CrmBoolean sgt_toernooiorganisatie_moet_gelijk_zijnField;

		private Lookup sgt_toernooisoortidField;

		private Sgt_toe_inschrijfmethode_per_toernooisoortStateInfo statecodeField;

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
		public CrmBoolean sgt_1e_keus_1
		{
			get
			{
				return this.sgt_1e_keus_1Field;
			}
			set
			{
				this.sgt_1e_keus_1Field = value;
				base.RaisePropertyChanged("sgt_1e_keus_1");
			}
		}

		[XmlElement] //[XmlElement(Order=8)]
		public CrmBoolean sgt_1e_keus_2
		{
			get
			{
				return this.sgt_1e_keus_2Field;
			}
			set
			{
				this.sgt_1e_keus_2Field = value;
				base.RaisePropertyChanged("sgt_1e_keus_2");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public CrmBoolean sgt_1e_keus_3
		{
			get
			{
				return this.sgt_1e_keus_3Field;
			}
			set
			{
				this.sgt_1e_keus_3Field = value;
				base.RaisePropertyChanged("sgt_1e_keus_3");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public CrmBoolean sgt_1e_keus_i
		{
			get
			{
				return this.sgt_1e_keus_iField;
			}
			set
			{
				this.sgt_1e_keus_iField = value;
				base.RaisePropertyChanged("sgt_1e_keus_i");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public CrmBoolean sgt_2e_keus_1
		{
			get
			{
				return this.sgt_2e_keus_1Field;
			}
			set
			{
				this.sgt_2e_keus_1Field = value;
				base.RaisePropertyChanged("sgt_2e_keus_1");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public CrmBoolean sgt_2e_keus_2
		{
			get
			{
				return this.sgt_2e_keus_2Field;
			}
			set
			{
				this.sgt_2e_keus_2Field = value;
				base.RaisePropertyChanged("sgt_2e_keus_2");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public CrmBoolean sgt_2e_keus_3
		{
			get
			{
				return this.sgt_2e_keus_3Field;
			}
			set
			{
				this.sgt_2e_keus_3Field = value;
				base.RaisePropertyChanged("sgt_2e_keus_3");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public CrmBoolean sgt_2e_keus_i
		{
			get
			{
				return this.sgt_2e_keus_iField;
			}
			set
			{
				this.sgt_2e_keus_iField = value;
				base.RaisePropertyChanged("sgt_2e_keus_i");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public CrmBoolean sgt_3e_keus_1
		{
			get
			{
				return this.sgt_3e_keus_1Field;
			}
			set
			{
				this.sgt_3e_keus_1Field = value;
				base.RaisePropertyChanged("sgt_3e_keus_1");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public CrmBoolean sgt_3e_keus_2
		{
			get
			{
				return this.sgt_3e_keus_2Field;
			}
			set
			{
				this.sgt_3e_keus_2Field = value;
				base.RaisePropertyChanged("sgt_3e_keus_2");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public CrmBoolean sgt_3e_keus_3
		{
			get
			{
				return this.sgt_3e_keus_3Field;
			}
			set
			{
				this.sgt_3e_keus_3Field = value;
				base.RaisePropertyChanged("sgt_3e_keus_3");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public CrmBoolean sgt_3e_keus_i
		{
			get
			{
				return this.sgt_3e_keus_iField;
			}
			set
			{
				this.sgt_3e_keus_iField = value;
				base.RaisePropertyChanged("sgt_3e_keus_i");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
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

		[XmlElement] //[XmlElement(Order=20)]
		public Lookup sgt_bij_inschrijving_opid
		{
			get
			{
				return this.sgt_bij_inschrijving_opidField;
			}
			set
			{
				this.sgt_bij_inschrijving_opidField = value;
				base.RaisePropertyChanged("sgt_bij_inschrijving_opid");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public CrmBoolean sgt_controle_gelijke_keuze
		{
			get
			{
				return this.sgt_controle_gelijke_keuzeField;
			}
			set
			{
				this.sgt_controle_gelijke_keuzeField = value;
				base.RaisePropertyChanged("sgt_controle_gelijke_keuze");
			}
		}

		[XmlElement] //[XmlElement(Order=22)]
		public CrmBoolean sgt_inschrijving_1
		{
			get
			{
				return this.sgt_inschrijving_1Field;
			}
			set
			{
				this.sgt_inschrijving_1Field = value;
				base.RaisePropertyChanged("sgt_inschrijving_1");
			}
		}

		[XmlElement] //[XmlElement(Order=23)]
		public CrmBoolean sgt_inschrijving_2
		{
			get
			{
				return this.sgt_inschrijving_2Field;
			}
			set
			{
				this.sgt_inschrijving_2Field = value;
				base.RaisePropertyChanged("sgt_inschrijving_2");
			}
		}

		[XmlElement] //[XmlElement(Order=24)]
		public CrmBoolean sgt_inschrijving_3
		{
			get
			{
				return this.sgt_inschrijving_3Field;
			}
			set
			{
				this.sgt_inschrijving_3Field = value;
				base.RaisePropertyChanged("sgt_inschrijving_3");
			}
		}

		[XmlElement] //[XmlElement(Order=25)]
		public CrmBoolean sgt_inschrijving_i
		{
			get
			{
				return this.sgt_inschrijving_iField;
			}
			set
			{
				this.sgt_inschrijving_iField = value;
				base.RaisePropertyChanged("sgt_inschrijving_i");
			}
		}

		[XmlElement] //[XmlElement(Order=26)]
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

		[XmlElement] //[XmlElement(Order=27)]
		public CrmBoolean sgt_periode_moet_gelijk_zijn
		{
			get
			{
				return this.sgt_periode_moet_gelijk_zijnField;
			}
			set
			{
				this.sgt_periode_moet_gelijk_zijnField = value;
				base.RaisePropertyChanged("sgt_periode_moet_gelijk_zijn");
			}
		}

		[XmlElement] //[XmlElement(Order=28)]
		public string sgt_toe_inschrijfmethode
		{
			get
			{
				return this.sgt_toe_inschrijfmethodeField;
			}
			set
			{
				this.sgt_toe_inschrijfmethodeField = value;
				base.RaisePropertyChanged("sgt_toe_inschrijfmethode");
			}
		}

		[XmlElement] //[XmlElement(Order=29)]
		public Key sgt_toe_inschrijfmethode_per_toernooisoortid
		{
			get
			{
				return this.sgt_toe_inschrijfmethode_per_toernooisoortidField;
			}
			set
			{
				this.sgt_toe_inschrijfmethode_per_toernooisoortidField = value;
				base.RaisePropertyChanged("sgt_toe_inschrijfmethode_per_toernooisoortid");
			}
		}

		[XmlElement] //[XmlElement(Order=30)]
		public CrmBoolean sgt_toernooiorganisatie_moet_gelijk_zijn
		{
			get
			{
				return this.sgt_toernooiorganisatie_moet_gelijk_zijnField;
			}
			set
			{
				this.sgt_toernooiorganisatie_moet_gelijk_zijnField = value;
				base.RaisePropertyChanged("sgt_toernooiorganisatie_moet_gelijk_zijn");
			}
		}

		[XmlElement] //[XmlElement(Order=31)]
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

		[XmlElement] //[XmlElement(Order=32)]
		public Sgt_toe_inschrijfmethode_per_toernooisoortStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=33)]
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

		[XmlElement] //[XmlElement(Order=34)]
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

		[XmlElement] //[XmlElement(Order=35)]
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

		public sgt_toe_inschrijfmethode_per_toernooisoort()
		{
		}
	}
}