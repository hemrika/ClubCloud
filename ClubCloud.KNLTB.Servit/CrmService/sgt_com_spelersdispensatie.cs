using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
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
		public Lookup sgt_aangevraagd_door_id
		{
			get
			{
				return this.sgt_aangevraagd_door_idField;
			}
			set
			{
				this.sgt_aangevraagd_door_idField = value;
			}
		}
		public Lookup sgt_behandeld_door_id
		{
			get
			{
				return this.sgt_behandeld_door_idField;
			}
			set
			{
				this.sgt_behandeld_door_idField = value;
			}
		}
		public string sgt_bondsnummer
		{
			get
			{
				return this.sgt_bondsnummerField;
			}
			set
			{
				this.sgt_bondsnummerField = value;
			}
		}
		public Key sgt_com_spelersdispensatieid
		{
			get
			{
				return this.sgt_com_spelersdispensatieidField;
			}
			set
			{
				this.sgt_com_spelersdispensatieidField = value;
			}
		}
		public Lookup sgt_competitie_a_id
		{
			get
			{
				return this.sgt_competitie_a_idField;
			}
			set
			{
				this.sgt_competitie_a_idField = value;
			}
		}
		public Lookup sgt_competitie_b_id
		{
			get
			{
				return this.sgt_competitie_b_idField;
			}
			set
			{
				this.sgt_competitie_b_idField = value;
			}
		}
		public Picklist sgt_dag_1
		{
			get
			{
				return this.sgt_dag_1Field;
			}
			set
			{
				this.sgt_dag_1Field = value;
			}
		}
		public Picklist sgt_dag_2
		{
			get
			{
				return this.sgt_dag_2Field;
			}
			set
			{
				this.sgt_dag_2Field = value;
			}
		}
		public Picklist sgt_dagdeel_1
		{
			get
			{
				return this.sgt_dagdeel_1Field;
			}
			set
			{
				this.sgt_dagdeel_1Field = value;
			}
		}
		public Picklist sgt_dagdeel_2
		{
			get
			{
				return this.sgt_dagdeel_2Field;
			}
			set
			{
				this.sgt_dagdeel_2Field = value;
			}
		}
		public CrmDateTime sgt_datum_aangevraagd
		{
			get
			{
				return this.sgt_datum_aangevraagdField;
			}
			set
			{
				this.sgt_datum_aangevraagdField = value;
			}
		}
		public CrmDateTime sgt_datum_afgehandeld
		{
			get
			{
				return this.sgt_datum_afgehandeldField;
			}
			set
			{
				this.sgt_datum_afgehandeldField = value;
			}
		}
		public Picklist sgt_dispensatietype
		{
			get
			{
				return this.sgt_dispensatietypeField;
			}
			set
			{
				this.sgt_dispensatietypeField = value;
			}
		}
		public CrmDateTime sgt_geboortedatum
		{
			get
			{
				return this.sgt_geboortedatumField;
			}
			set
			{
				this.sgt_geboortedatumField = value;
			}
		}
		public Picklist sgt_geslacht
		{
			get
			{
				return this.sgt_geslachtField;
			}
			set
			{
				this.sgt_geslachtField = value;
			}
		}
		public Lookup sgt_klassegroep_1_id
		{
			get
			{
				return this.sgt_klassegroep_1_idField;
			}
			set
			{
				this.sgt_klassegroep_1_idField = value;
			}
		}
		public Lookup sgt_klassegroep_2_id
		{
			get
			{
				return this.sgt_klassegroep_2_idField;
			}
			set
			{
				this.sgt_klassegroep_2_idField = value;
			}
		}
		public string sgt_name
		{
			get
			{
				return this.sgt_nameField;
			}
			set
			{
				this.sgt_nameField = value;
			}
		}
		public Lookup sgt_piramide_a_id
		{
			get
			{
				return this.sgt_piramide_a_idField;
			}
			set
			{
				this.sgt_piramide_a_idField = value;
			}
		}
		public Lookup sgt_piramide_b_id
		{
			get
			{
				return this.sgt_piramide_b_idField;
			}
			set
			{
				this.sgt_piramide_b_idField = value;
			}
		}
		public Lookup sgt_ploeg_a_id
		{
			get
			{
				return this.sgt_ploeg_a_idField;
			}
			set
			{
				this.sgt_ploeg_a_idField = value;
			}
		}
		public Lookup sgt_ploeg_b_id
		{
			get
			{
				return this.sgt_ploeg_b_idField;
			}
			set
			{
				this.sgt_ploeg_b_idField = value;
			}
		}
		public Lookup sgt_reden_afgekeurd_id
		{
			get
			{
				return this.sgt_reden_afgekeurd_idField;
			}
			set
			{
				this.sgt_reden_afgekeurd_idField = value;
			}
		}
		public CrmNumber sgt_speelsterkte_dubbel
		{
			get
			{
				return this.sgt_speelsterkte_dubbelField;
			}
			set
			{
				this.sgt_speelsterkte_dubbelField = value;
			}
		}
		public CrmNumber sgt_speelsterkte_enkel
		{
			get
			{
				return this.sgt_speelsterkte_enkelField;
			}
			set
			{
				this.sgt_speelsterkte_enkelField = value;
			}
		}
		public Lookup sgt_speler_id
		{
			get
			{
				return this.sgt_speler_idField;
			}
			set
			{
				this.sgt_speler_idField = value;
			}
		}
		public Lookup sgt_vereniging_a_id
		{
			get
			{
				return this.sgt_vereniging_a_idField;
			}
			set
			{
				this.sgt_vereniging_a_idField = value;
			}
		}
		public Lookup sgt_vereniging_b_id
		{
			get
			{
				return this.sgt_vereniging_b_idField;
			}
			set
			{
				this.sgt_vereniging_b_idField = value;
			}
		}
		public Sgt_com_spelersdispensatieStateInfo statecode
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
