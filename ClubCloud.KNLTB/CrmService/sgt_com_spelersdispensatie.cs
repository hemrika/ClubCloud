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
	public class sgt_com_spelersdispensatie : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private Lookup sgt_aangevraagd_door_idField;

		private Lookup sgt_behandeld_door_idField;

		private string sgt_bondsnummerField;

		private Key sgt_com_spelersdispensatieidField;

		private Lookup sgt_competitie_a_idField;

		private Lookup sgt_competitie_b_idField;

		private Picklist sgt_dag_1Field;

		private Picklist sgt_dag_2Field;

		private Picklist sgt_dagdeel_1Field;

		private Picklist sgt_dagdeel_2Field;

		private CrmDateTime sgt_datum_aangevraagdField;

		private CrmDateTime sgt_datum_afgehandeldField;

		private Picklist sgt_dispensatietypeField;

		private CrmDateTime sgt_geboortedatumField;

		private Picklist sgt_geslachtField;

		private Lookup sgt_klassegroep_1_idField;

		private Lookup sgt_klassegroep_2_idField;

		private string sgt_nameField;

		private Lookup sgt_piramide_a_idField;

		private Lookup sgt_piramide_b_idField;

		private Lookup sgt_ploeg_a_idField;

		private Lookup sgt_ploeg_b_idField;

		private Lookup sgt_reden_afgekeurd_idField;

		private CrmNumber sgt_speelsterkte_dubbelField;

		private CrmNumber sgt_speelsterkte_enkelField;

		private Lookup sgt_speler_idField;

		private Lookup sgt_vereniging_a_idField;

		private Lookup sgt_vereniging_b_idField;

		private Sgt_com_spelersdispensatieStateInfo statecodeField;

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
		public Lookup sgt_aangevraagd_door_id
		{
			get
			{
				return this.sgt_aangevraagd_door_idField;
			}
			set
			{
				this.sgt_aangevraagd_door_idField = value;
				base.RaisePropertyChanged("sgt_aangevraagd_door_id");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public Lookup sgt_behandeld_door_id
		{
			get
			{
				return this.sgt_behandeld_door_idField;
			}
			set
			{
				this.sgt_behandeld_door_idField = value;
				base.RaisePropertyChanged("sgt_behandeld_door_id");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public string sgt_bondsnummer
		{
			get
			{
				return this.sgt_bondsnummerField;
			}
			set
			{
				this.sgt_bondsnummerField = value;
				base.RaisePropertyChanged("sgt_bondsnummer");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public Key sgt_com_spelersdispensatieid
		{
			get
			{
				return this.sgt_com_spelersdispensatieidField;
			}
			set
			{
				this.sgt_com_spelersdispensatieidField = value;
				base.RaisePropertyChanged("sgt_com_spelersdispensatieid");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public Lookup sgt_competitie_a_id
		{
			get
			{
				return this.sgt_competitie_a_idField;
			}
			set
			{
				this.sgt_competitie_a_idField = value;
				base.RaisePropertyChanged("sgt_competitie_a_id");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public Lookup sgt_competitie_b_id
		{
			get
			{
				return this.sgt_competitie_b_idField;
			}
			set
			{
				this.sgt_competitie_b_idField = value;
				base.RaisePropertyChanged("sgt_competitie_b_id");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public Picklist sgt_dag_1
		{
			get
			{
				return this.sgt_dag_1Field;
			}
			set
			{
				this.sgt_dag_1Field = value;
				base.RaisePropertyChanged("sgt_dag_1");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public Picklist sgt_dag_2
		{
			get
			{
				return this.sgt_dag_2Field;
			}
			set
			{
				this.sgt_dag_2Field = value;
				base.RaisePropertyChanged("sgt_dag_2");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public Picklist sgt_dagdeel_1
		{
			get
			{
				return this.sgt_dagdeel_1Field;
			}
			set
			{
				this.sgt_dagdeel_1Field = value;
				base.RaisePropertyChanged("sgt_dagdeel_1");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public Picklist sgt_dagdeel_2
		{
			get
			{
				return this.sgt_dagdeel_2Field;
			}
			set
			{
				this.sgt_dagdeel_2Field = value;
				base.RaisePropertyChanged("sgt_dagdeel_2");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public CrmDateTime sgt_datum_aangevraagd
		{
			get
			{
				return this.sgt_datum_aangevraagdField;
			}
			set
			{
				this.sgt_datum_aangevraagdField = value;
				base.RaisePropertyChanged("sgt_datum_aangevraagd");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public CrmDateTime sgt_datum_afgehandeld
		{
			get
			{
				return this.sgt_datum_afgehandeldField;
			}
			set
			{
				this.sgt_datum_afgehandeldField = value;
				base.RaisePropertyChanged("sgt_datum_afgehandeld");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public Picklist sgt_dispensatietype
		{
			get
			{
				return this.sgt_dispensatietypeField;
			}
			set
			{
				this.sgt_dispensatietypeField = value;
				base.RaisePropertyChanged("sgt_dispensatietype");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public CrmDateTime sgt_geboortedatum
		{
			get
			{
				return this.sgt_geboortedatumField;
			}
			set
			{
				this.sgt_geboortedatumField = value;
				base.RaisePropertyChanged("sgt_geboortedatum");
			}
		}

		[XmlElement] //[XmlElement(Order=22)]
		public Picklist sgt_geslacht
		{
			get
			{
				return this.sgt_geslachtField;
			}
			set
			{
				this.sgt_geslachtField = value;
				base.RaisePropertyChanged("sgt_geslacht");
			}
		}

		[XmlElement] //[XmlElement(Order=23)]
		public Lookup sgt_klassegroep_1_id
		{
			get
			{
				return this.sgt_klassegroep_1_idField;
			}
			set
			{
				this.sgt_klassegroep_1_idField = value;
				base.RaisePropertyChanged("sgt_klassegroep_1_id");
			}
		}

		[XmlElement] //[XmlElement(Order=24)]
		public Lookup sgt_klassegroep_2_id
		{
			get
			{
				return this.sgt_klassegroep_2_idField;
			}
			set
			{
				this.sgt_klassegroep_2_idField = value;
				base.RaisePropertyChanged("sgt_klassegroep_2_id");
			}
		}

		[XmlElement] //[XmlElement(Order=25)]
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

		[XmlElement] //[XmlElement(Order=26)]
		public Lookup sgt_piramide_a_id
		{
			get
			{
				return this.sgt_piramide_a_idField;
			}
			set
			{
				this.sgt_piramide_a_idField = value;
				base.RaisePropertyChanged("sgt_piramide_a_id");
			}
		}

		[XmlElement] //[XmlElement(Order=27)]
		public Lookup sgt_piramide_b_id
		{
			get
			{
				return this.sgt_piramide_b_idField;
			}
			set
			{
				this.sgt_piramide_b_idField = value;
				base.RaisePropertyChanged("sgt_piramide_b_id");
			}
		}

		[XmlElement] //[XmlElement(Order=28)]
		public Lookup sgt_ploeg_a_id
		{
			get
			{
				return this.sgt_ploeg_a_idField;
			}
			set
			{
				this.sgt_ploeg_a_idField = value;
				base.RaisePropertyChanged("sgt_ploeg_a_id");
			}
		}

		[XmlElement] //[XmlElement(Order=29)]
		public Lookup sgt_ploeg_b_id
		{
			get
			{
				return this.sgt_ploeg_b_idField;
			}
			set
			{
				this.sgt_ploeg_b_idField = value;
				base.RaisePropertyChanged("sgt_ploeg_b_id");
			}
		}

		[XmlElement] //[XmlElement(Order=30)]
		public Lookup sgt_reden_afgekeurd_id
		{
			get
			{
				return this.sgt_reden_afgekeurd_idField;
			}
			set
			{
				this.sgt_reden_afgekeurd_idField = value;
				base.RaisePropertyChanged("sgt_reden_afgekeurd_id");
			}
		}

		[XmlElement] //[XmlElement(Order=31)]
		public CrmNumber sgt_speelsterkte_dubbel
		{
			get
			{
				return this.sgt_speelsterkte_dubbelField;
			}
			set
			{
				this.sgt_speelsterkte_dubbelField = value;
				base.RaisePropertyChanged("sgt_speelsterkte_dubbel");
			}
		}

		[XmlElement] //[XmlElement(Order=32)]
		public CrmNumber sgt_speelsterkte_enkel
		{
			get
			{
				return this.sgt_speelsterkte_enkelField;
			}
			set
			{
				this.sgt_speelsterkte_enkelField = value;
				base.RaisePropertyChanged("sgt_speelsterkte_enkel");
			}
		}

		[XmlElement] //[XmlElement(Order=33)]
		public Lookup sgt_speler_id
		{
			get
			{
				return this.sgt_speler_idField;
			}
			set
			{
				this.sgt_speler_idField = value;
				base.RaisePropertyChanged("sgt_speler_id");
			}
		}

		[XmlElement] //[XmlElement(Order=34)]
		public Lookup sgt_vereniging_a_id
		{
			get
			{
				return this.sgt_vereniging_a_idField;
			}
			set
			{
				this.sgt_vereniging_a_idField = value;
				base.RaisePropertyChanged("sgt_vereniging_a_id");
			}
		}

		[XmlElement] //[XmlElement(Order=35)]
		public Lookup sgt_vereniging_b_id
		{
			get
			{
				return this.sgt_vereniging_b_idField;
			}
			set
			{
				this.sgt_vereniging_b_idField = value;
				base.RaisePropertyChanged("sgt_vereniging_b_id");
			}
		}

		[XmlElement] //[XmlElement(Order=36)]
		public Sgt_com_spelersdispensatieStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=37)]
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

		[XmlElement] //[XmlElement(Order=38)]
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

		[XmlElement] //[XmlElement(Order=39)]
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

		public sgt_com_spelersdispensatie()
		{
		}
	}
}