using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_partij_uitslag_toernooi : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private string sgt_baanField;
		private string sgt_basisschema_partij_speler_1Field;
		private string sgt_basisschema_partij_speler_2Field;
		private string sgt_basisschema_partij_speler_3Field;
		private string sgt_basisschema_partij_speler_4Field;
		private CrmDecimal sgt_einduitslag_thuisField;
		private CrmDecimal sgt_einduitslag_uitField;
		private CrmBoolean sgt_opgave_tijdens_wedstrijdField;
		private CrmDateTime sgt_partij_datumField;
		private string sgt_partij_nummerField;
		private Picklist sgt_partij_statusField;
		private CrmNumber sgt_partijpunten_speler1Field;
		private CrmNumber sgt_partijpunten_speler2Field;
		private Lookup sgt_rondepouleidField;
		private Lookup sgt_speelschemaidField;
		private Picklist sgt_spelsoortField;
		private CrmNumber sgt_thuis_set1Field;
		private CrmNumber sgt_thuis_set2Field;
		private CrmNumber sgt_thuis_set3Field;
		private CrmNumber sgt_thuis_set4Field;
		private CrmNumber sgt_thuis_set5Field;
		private string sgt_thuis_speler1Field;
		private Lookup sgt_thuis_speler1_nationaliteit_idField;
		private string sgt_thuis_speler2Field;
		private Lookup sgt_thuis_speler2_nationaliteit_idField;
		private string sgt_toe_partij_uitslag_toernooi1Field;
		private Key sgt_toe_partij_uitslag_toernooiidField;
		private Lookup sgt_toernooiidField;
		private Lookup sgt_toernooionderdeelidField;
		private Lookup sgt_toernooispelerField;
		private Lookup sgt_toernooispeler_thuis_wissel_idField;
		private Lookup sgt_toernooispeler_uit_wissel_idField;
		private Lookup sgt_toernooispeler_uitidField;
		private CrmNumber sgt_uit_set1Field;
		private CrmNumber sgt_uit_set2Field;
		private CrmNumber sgt_uit_set3Field;
		private CrmNumber sgt_uit_set4Field;
		private CrmNumber sgt_uit_set5Field;
		private string sgt_uit_speler1Field;
		private Lookup sgt_uit_speler1_nationaliteit_idField;
		private string sgt_uit_speler2Field;
		private Lookup sgt_uit_speler2_nationaliteit_idField;
		private Sgt_toe_partij_uitslag_toernooiStateInfo statecodeField;
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
		public string sgt_baan
		{
			get
			{
				return this.sgt_baanField;
			}
			set
			{
				this.sgt_baanField = value;
				base.RaisePropertyChanged("sgt_baan");
			}
		}
		[XmlElement(Order = 9)]
		public string sgt_basisschema_partij_speler_1
		{
			get
			{
				return this.sgt_basisschema_partij_speler_1Field;
			}
			set
			{
				this.sgt_basisschema_partij_speler_1Field = value;
				base.RaisePropertyChanged("sgt_basisschema_partij_speler_1");
			}
		}
		[XmlElement(Order = 10)]
		public string sgt_basisschema_partij_speler_2
		{
			get
			{
				return this.sgt_basisschema_partij_speler_2Field;
			}
			set
			{
				this.sgt_basisschema_partij_speler_2Field = value;
				base.RaisePropertyChanged("sgt_basisschema_partij_speler_2");
			}
		}
		[XmlElement(Order = 11)]
		public string sgt_basisschema_partij_speler_3
		{
			get
			{
				return this.sgt_basisschema_partij_speler_3Field;
			}
			set
			{
				this.sgt_basisschema_partij_speler_3Field = value;
				base.RaisePropertyChanged("sgt_basisschema_partij_speler_3");
			}
		}
		[XmlElement(Order = 12)]
		public string sgt_basisschema_partij_speler_4
		{
			get
			{
				return this.sgt_basisschema_partij_speler_4Field;
			}
			set
			{
				this.sgt_basisschema_partij_speler_4Field = value;
				base.RaisePropertyChanged("sgt_basisschema_partij_speler_4");
			}
		}
		[XmlElement(Order = 13)]
		public CrmDecimal sgt_einduitslag_thuis
		{
			get
			{
				return this.sgt_einduitslag_thuisField;
			}
			set
			{
				this.sgt_einduitslag_thuisField = value;
				base.RaisePropertyChanged("sgt_einduitslag_thuis");
			}
		}
		[XmlElement(Order = 14)]
		public CrmDecimal sgt_einduitslag_uit
		{
			get
			{
				return this.sgt_einduitslag_uitField;
			}
			set
			{
				this.sgt_einduitslag_uitField = value;
				base.RaisePropertyChanged("sgt_einduitslag_uit");
			}
		}
		[XmlElement(Order = 15)]
		public CrmBoolean sgt_opgave_tijdens_wedstrijd
		{
			get
			{
				return this.sgt_opgave_tijdens_wedstrijdField;
			}
			set
			{
				this.sgt_opgave_tijdens_wedstrijdField = value;
				base.RaisePropertyChanged("sgt_opgave_tijdens_wedstrijd");
			}
		}
		[XmlElement(Order = 16)]
		public CrmDateTime sgt_partij_datum
		{
			get
			{
				return this.sgt_partij_datumField;
			}
			set
			{
				this.sgt_partij_datumField = value;
				base.RaisePropertyChanged("sgt_partij_datum");
			}
		}
		[XmlElement(Order = 17)]
		public string sgt_partij_nummer
		{
			get
			{
				return this.sgt_partij_nummerField;
			}
			set
			{
				this.sgt_partij_nummerField = value;
				base.RaisePropertyChanged("sgt_partij_nummer");
			}
		}
		[XmlElement(Order = 18)]
		public Picklist sgt_partij_status
		{
			get
			{
				return this.sgt_partij_statusField;
			}
			set
			{
				this.sgt_partij_statusField = value;
				base.RaisePropertyChanged("sgt_partij_status");
			}
		}
		[XmlElement(Order = 19)]
		public CrmNumber sgt_partijpunten_speler1
		{
			get
			{
				return this.sgt_partijpunten_speler1Field;
			}
			set
			{
				this.sgt_partijpunten_speler1Field = value;
				base.RaisePropertyChanged("sgt_partijpunten_speler1");
			}
		}
		[XmlElement(Order = 20)]
		public CrmNumber sgt_partijpunten_speler2
		{
			get
			{
				return this.sgt_partijpunten_speler2Field;
			}
			set
			{
				this.sgt_partijpunten_speler2Field = value;
				base.RaisePropertyChanged("sgt_partijpunten_speler2");
			}
		}
		[XmlElement(Order = 21)]
		public Lookup sgt_rondepouleid
		{
			get
			{
				return this.sgt_rondepouleidField;
			}
			set
			{
				this.sgt_rondepouleidField = value;
				base.RaisePropertyChanged("sgt_rondepouleid");
			}
		}
		[XmlElement(Order = 22)]
		public Lookup sgt_speelschemaid
		{
			get
			{
				return this.sgt_speelschemaidField;
			}
			set
			{
				this.sgt_speelschemaidField = value;
				base.RaisePropertyChanged("sgt_speelschemaid");
			}
		}
		[XmlElement(Order = 23)]
		public Picklist sgt_spelsoort
		{
			get
			{
				return this.sgt_spelsoortField;
			}
			set
			{
				this.sgt_spelsoortField = value;
				base.RaisePropertyChanged("sgt_spelsoort");
			}
		}
		[XmlElement(Order = 24)]
		public CrmNumber sgt_thuis_set1
		{
			get
			{
				return this.sgt_thuis_set1Field;
			}
			set
			{
				this.sgt_thuis_set1Field = value;
				base.RaisePropertyChanged("sgt_thuis_set1");
			}
		}
		[XmlElement(Order = 25)]
		public CrmNumber sgt_thuis_set2
		{
			get
			{
				return this.sgt_thuis_set2Field;
			}
			set
			{
				this.sgt_thuis_set2Field = value;
				base.RaisePropertyChanged("sgt_thuis_set2");
			}
		}
		[XmlElement(Order = 26)]
		public CrmNumber sgt_thuis_set3
		{
			get
			{
				return this.sgt_thuis_set3Field;
			}
			set
			{
				this.sgt_thuis_set3Field = value;
				base.RaisePropertyChanged("sgt_thuis_set3");
			}
		}
		[XmlElement(Order = 27)]
		public CrmNumber sgt_thuis_set4
		{
			get
			{
				return this.sgt_thuis_set4Field;
			}
			set
			{
				this.sgt_thuis_set4Field = value;
				base.RaisePropertyChanged("sgt_thuis_set4");
			}
		}
		[XmlElement(Order = 28)]
		public CrmNumber sgt_thuis_set5
		{
			get
			{
				return this.sgt_thuis_set5Field;
			}
			set
			{
				this.sgt_thuis_set5Field = value;
				base.RaisePropertyChanged("sgt_thuis_set5");
			}
		}
		[XmlElement(Order = 29)]
		public string sgt_thuis_speler1
		{
			get
			{
				return this.sgt_thuis_speler1Field;
			}
			set
			{
				this.sgt_thuis_speler1Field = value;
				base.RaisePropertyChanged("sgt_thuis_speler1");
			}
		}
		[XmlElement(Order = 30)]
		public Lookup sgt_thuis_speler1_nationaliteit_id
		{
			get
			{
				return this.sgt_thuis_speler1_nationaliteit_idField;
			}
			set
			{
				this.sgt_thuis_speler1_nationaliteit_idField = value;
				base.RaisePropertyChanged("sgt_thuis_speler1_nationaliteit_id");
			}
		}
		[XmlElement(Order = 31)]
		public string sgt_thuis_speler2
		{
			get
			{
				return this.sgt_thuis_speler2Field;
			}
			set
			{
				this.sgt_thuis_speler2Field = value;
				base.RaisePropertyChanged("sgt_thuis_speler2");
			}
		}
		[XmlElement(Order = 32)]
		public Lookup sgt_thuis_speler2_nationaliteit_id
		{
			get
			{
				return this.sgt_thuis_speler2_nationaliteit_idField;
			}
			set
			{
				this.sgt_thuis_speler2_nationaliteit_idField = value;
				base.RaisePropertyChanged("sgt_thuis_speler2_nationaliteit_id");
			}
		}
		[XmlElement("sgt_toe_partij_uitslag_toernooi", Order = 33)]
		public string sgt_toe_partij_uitslag_toernooi1
		{
			get
			{
				return this.sgt_toe_partij_uitslag_toernooi1Field;
			}
			set
			{
				this.sgt_toe_partij_uitslag_toernooi1Field = value;
				base.RaisePropertyChanged("sgt_toe_partij_uitslag_toernooi1");
			}
		}
		[XmlElement(Order = 34)]
		public Key sgt_toe_partij_uitslag_toernooiid
		{
			get
			{
				return this.sgt_toe_partij_uitslag_toernooiidField;
			}
			set
			{
				this.sgt_toe_partij_uitslag_toernooiidField = value;
				base.RaisePropertyChanged("sgt_toe_partij_uitslag_toernooiid");
			}
		}
		[XmlElement(Order = 35)]
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
		[XmlElement(Order = 36)]
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
		[XmlElement(Order = 37)]
		public Lookup sgt_toernooispeler
		{
			get
			{
				return this.sgt_toernooispelerField;
			}
			set
			{
				this.sgt_toernooispelerField = value;
				base.RaisePropertyChanged("sgt_toernooispeler");
			}
		}
		[XmlElement(Order = 38)]
		public Lookup sgt_toernooispeler_thuis_wissel_id
		{
			get
			{
				return this.sgt_toernooispeler_thuis_wissel_idField;
			}
			set
			{
				this.sgt_toernooispeler_thuis_wissel_idField = value;
				base.RaisePropertyChanged("sgt_toernooispeler_thuis_wissel_id");
			}
		}
		[XmlElement(Order = 39)]
		public Lookup sgt_toernooispeler_uit_wissel_id
		{
			get
			{
				return this.sgt_toernooispeler_uit_wissel_idField;
			}
			set
			{
				this.sgt_toernooispeler_uit_wissel_idField = value;
				base.RaisePropertyChanged("sgt_toernooispeler_uit_wissel_id");
			}
		}
		[XmlElement(Order = 40)]
		public Lookup sgt_toernooispeler_uitid
		{
			get
			{
				return this.sgt_toernooispeler_uitidField;
			}
			set
			{
				this.sgt_toernooispeler_uitidField = value;
				base.RaisePropertyChanged("sgt_toernooispeler_uitid");
			}
		}
		[XmlElement(Order = 41)]
		public CrmNumber sgt_uit_set1
		{
			get
			{
				return this.sgt_uit_set1Field;
			}
			set
			{
				this.sgt_uit_set1Field = value;
				base.RaisePropertyChanged("sgt_uit_set1");
			}
		}
		[XmlElement(Order = 42)]
		public CrmNumber sgt_uit_set2
		{
			get
			{
				return this.sgt_uit_set2Field;
			}
			set
			{
				this.sgt_uit_set2Field = value;
				base.RaisePropertyChanged("sgt_uit_set2");
			}
		}
		[XmlElement(Order = 43)]
		public CrmNumber sgt_uit_set3
		{
			get
			{
				return this.sgt_uit_set3Field;
			}
			set
			{
				this.sgt_uit_set3Field = value;
				base.RaisePropertyChanged("sgt_uit_set3");
			}
		}
		[XmlElement(Order = 44)]
		public CrmNumber sgt_uit_set4
		{
			get
			{
				return this.sgt_uit_set4Field;
			}
			set
			{
				this.sgt_uit_set4Field = value;
				base.RaisePropertyChanged("sgt_uit_set4");
			}
		}
		[XmlElement(Order = 45)]
		public CrmNumber sgt_uit_set5
		{
			get
			{
				return this.sgt_uit_set5Field;
			}
			set
			{
				this.sgt_uit_set5Field = value;
				base.RaisePropertyChanged("sgt_uit_set5");
			}
		}
		[XmlElement(Order = 46)]
		public string sgt_uit_speler1
		{
			get
			{
				return this.sgt_uit_speler1Field;
			}
			set
			{
				this.sgt_uit_speler1Field = value;
				base.RaisePropertyChanged("sgt_uit_speler1");
			}
		}
		[XmlElement(Order = 47)]
		public Lookup sgt_uit_speler1_nationaliteit_id
		{
			get
			{
				return this.sgt_uit_speler1_nationaliteit_idField;
			}
			set
			{
				this.sgt_uit_speler1_nationaliteit_idField = value;
				base.RaisePropertyChanged("sgt_uit_speler1_nationaliteit_id");
			}
		}
		[XmlElement(Order = 48)]
		public string sgt_uit_speler2
		{
			get
			{
				return this.sgt_uit_speler2Field;
			}
			set
			{
				this.sgt_uit_speler2Field = value;
				base.RaisePropertyChanged("sgt_uit_speler2");
			}
		}
		[XmlElement(Order = 49)]
		public Lookup sgt_uit_speler2_nationaliteit_id
		{
			get
			{
				return this.sgt_uit_speler2_nationaliteit_idField;
			}
			set
			{
				this.sgt_uit_speler2_nationaliteit_idField = value;
				base.RaisePropertyChanged("sgt_uit_speler2_nationaliteit_id");
			}
		}
		[XmlElement(Order = 50)]
		public Sgt_toe_partij_uitslag_toernooiStateInfo statecode
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
		[XmlElement(Order = 51)]
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
		[XmlElement(Order = 52)]
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
		[XmlElement(Order = 53)]
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
