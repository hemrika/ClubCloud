using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_bo_cursist : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Lookup sgt_administratieidField;
		private CrmBoolean sgt_afhankeliijk_vanovField;
		private string sgt_bo_cursist1Field;
		private Key sgt_bo_cursistidField;
		private string sgt_bondsnummerField;
		private Lookup sgt_cursistidField;
		private CrmDateTime sgt_datum_betaling_opleidingField;
		private CrmDateTime sgt_datum_betaling_testdagField;
		private CrmDateTime sgt_datum_geslaagdField;
		private CrmDateTime sgt_datum_tijd_aanmeldingField;
		private CrmBoolean sgt_ervaring_met_lesgevenField;
		private Picklist sgt_factuurField;
		private Lookup sgt_factuuradresField;
		private string sgt_graag_samen_metField;
		private CrmBoolean sgt_heeft_betaaldField;
		private CrmBoolean sgt_heeft_reanimatiediplomaField;
		private CrmBoolean sgt_heeft_testdag_betaaldField;
		private Lookup sgt_inschrijfformulier_testdagField;
		private CrmBoolean sgt_kan_alleen_in_het_weekendField;
		private Lookup sgt_opleidingidField;
		private Lookup sgt_opleidingsgroepidField;
		private string sgt_opmerking_opleiding_betaaldField;
		private string sgt_opmerking_testdag_betaaldField;
		private string sgt_overige_bijzonderhedenField;
		private Picklist sgt_status_opleidingField;
		private Picklist sgt_status_testdagField;
		private Lookup sgt_testdagidField;
		private CrmBoolean sgt_uwv_reintegratietrajectField;
		private CrmBoolean sgt_volgt_nog_een_andere_studieField;
		private Lookup sgt_voorkeur_opleidingsgroepidField;
		private Lookup sgt_voorkeur_testdagidField;
		private CrmBoolean sgt_wachtlijstField;
		private CrmBoolean sgt_werk_op_zaterdagField;
		private string sgt_wt_cursuscodeField;
		private string sgt_wt_cursusfaseField;
		private CrmDateTime sgt_wt_toegangsdatum_totenmetField;
		private CrmDateTime sgt_wt_toegangsdatum_vanafField;
		private Sgt_bo_cursistStateInfo statecodeField;
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
		public Lookup sgt_administratieid
		{
			get
			{
				return this.sgt_administratieidField;
			}
			set
			{
				this.sgt_administratieidField = value;
			}
		}
		public CrmBoolean sgt_afhankeliijk_vanov
		{
			get
			{
				return this.sgt_afhankeliijk_vanovField;
			}
			set
			{
				this.sgt_afhankeliijk_vanovField = value;
			}
		}
		[XmlElement("sgt_bo_cursist")]
		public string sgt_bo_cursist1
		{
			get
			{
				return this.sgt_bo_cursist1Field;
			}
			set
			{
				this.sgt_bo_cursist1Field = value;
			}
		}
		public Key sgt_bo_cursistid
		{
			get
			{
				return this.sgt_bo_cursistidField;
			}
			set
			{
				this.sgt_bo_cursistidField = value;
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
		public Lookup sgt_cursistid
		{
			get
			{
				return this.sgt_cursistidField;
			}
			set
			{
				this.sgt_cursistidField = value;
			}
		}
		public CrmDateTime sgt_datum_betaling_opleiding
		{
			get
			{
				return this.sgt_datum_betaling_opleidingField;
			}
			set
			{
				this.sgt_datum_betaling_opleidingField = value;
			}
		}
		public CrmDateTime sgt_datum_betaling_testdag
		{
			get
			{
				return this.sgt_datum_betaling_testdagField;
			}
			set
			{
				this.sgt_datum_betaling_testdagField = value;
			}
		}
		public CrmDateTime sgt_datum_geslaagd
		{
			get
			{
				return this.sgt_datum_geslaagdField;
			}
			set
			{
				this.sgt_datum_geslaagdField = value;
			}
		}
		public CrmDateTime sgt_datum_tijd_aanmelding
		{
			get
			{
				return this.sgt_datum_tijd_aanmeldingField;
			}
			set
			{
				this.sgt_datum_tijd_aanmeldingField = value;
			}
		}
		public CrmBoolean sgt_ervaring_met_lesgeven
		{
			get
			{
				return this.sgt_ervaring_met_lesgevenField;
			}
			set
			{
				this.sgt_ervaring_met_lesgevenField = value;
			}
		}
		public Picklist sgt_factuur
		{
			get
			{
				return this.sgt_factuurField;
			}
			set
			{
				this.sgt_factuurField = value;
			}
		}
		public Lookup sgt_factuuradres
		{
			get
			{
				return this.sgt_factuuradresField;
			}
			set
			{
				this.sgt_factuuradresField = value;
			}
		}
		public string sgt_graag_samen_met
		{
			get
			{
				return this.sgt_graag_samen_metField;
			}
			set
			{
				this.sgt_graag_samen_metField = value;
			}
		}
		public CrmBoolean sgt_heeft_betaald
		{
			get
			{
				return this.sgt_heeft_betaaldField;
			}
			set
			{
				this.sgt_heeft_betaaldField = value;
			}
		}
		public CrmBoolean sgt_heeft_reanimatiediploma
		{
			get
			{
				return this.sgt_heeft_reanimatiediplomaField;
			}
			set
			{
				this.sgt_heeft_reanimatiediplomaField = value;
			}
		}
		public CrmBoolean sgt_heeft_testdag_betaald
		{
			get
			{
				return this.sgt_heeft_testdag_betaaldField;
			}
			set
			{
				this.sgt_heeft_testdag_betaaldField = value;
			}
		}
		public Lookup sgt_inschrijfformulier_testdag
		{
			get
			{
				return this.sgt_inschrijfformulier_testdagField;
			}
			set
			{
				this.sgt_inschrijfformulier_testdagField = value;
			}
		}
		public CrmBoolean sgt_kan_alleen_in_het_weekend
		{
			get
			{
				return this.sgt_kan_alleen_in_het_weekendField;
			}
			set
			{
				this.sgt_kan_alleen_in_het_weekendField = value;
			}
		}
		public Lookup sgt_opleidingid
		{
			get
			{
				return this.sgt_opleidingidField;
			}
			set
			{
				this.sgt_opleidingidField = value;
			}
		}
		public Lookup sgt_opleidingsgroepid
		{
			get
			{
				return this.sgt_opleidingsgroepidField;
			}
			set
			{
				this.sgt_opleidingsgroepidField = value;
			}
		}
		public string sgt_opmerking_opleiding_betaald
		{
			get
			{
				return this.sgt_opmerking_opleiding_betaaldField;
			}
			set
			{
				this.sgt_opmerking_opleiding_betaaldField = value;
			}
		}
		public string sgt_opmerking_testdag_betaald
		{
			get
			{
				return this.sgt_opmerking_testdag_betaaldField;
			}
			set
			{
				this.sgt_opmerking_testdag_betaaldField = value;
			}
		}
		public string sgt_overige_bijzonderheden
		{
			get
			{
				return this.sgt_overige_bijzonderhedenField;
			}
			set
			{
				this.sgt_overige_bijzonderhedenField = value;
			}
		}
		public Picklist sgt_status_opleiding
		{
			get
			{
				return this.sgt_status_opleidingField;
			}
			set
			{
				this.sgt_status_opleidingField = value;
			}
		}
		public Picklist sgt_status_testdag
		{
			get
			{
				return this.sgt_status_testdagField;
			}
			set
			{
				this.sgt_status_testdagField = value;
			}
		}
		public Lookup sgt_testdagid
		{
			get
			{
				return this.sgt_testdagidField;
			}
			set
			{
				this.sgt_testdagidField = value;
			}
		}
		public CrmBoolean sgt_uwv_reintegratietraject
		{
			get
			{
				return this.sgt_uwv_reintegratietrajectField;
			}
			set
			{
				this.sgt_uwv_reintegratietrajectField = value;
			}
		}
		public CrmBoolean sgt_volgt_nog_een_andere_studie
		{
			get
			{
				return this.sgt_volgt_nog_een_andere_studieField;
			}
			set
			{
				this.sgt_volgt_nog_een_andere_studieField = value;
			}
		}
		public Lookup sgt_voorkeur_opleidingsgroepid
		{
			get
			{
				return this.sgt_voorkeur_opleidingsgroepidField;
			}
			set
			{
				this.sgt_voorkeur_opleidingsgroepidField = value;
			}
		}
		public Lookup sgt_voorkeur_testdagid
		{
			get
			{
				return this.sgt_voorkeur_testdagidField;
			}
			set
			{
				this.sgt_voorkeur_testdagidField = value;
			}
		}
		public CrmBoolean sgt_wachtlijst
		{
			get
			{
				return this.sgt_wachtlijstField;
			}
			set
			{
				this.sgt_wachtlijstField = value;
			}
		}
		public CrmBoolean sgt_werk_op_zaterdag
		{
			get
			{
				return this.sgt_werk_op_zaterdagField;
			}
			set
			{
				this.sgt_werk_op_zaterdagField = value;
			}
		}
		public string sgt_wt_cursuscode
		{
			get
			{
				return this.sgt_wt_cursuscodeField;
			}
			set
			{
				this.sgt_wt_cursuscodeField = value;
			}
		}
		public string sgt_wt_cursusfase
		{
			get
			{
				return this.sgt_wt_cursusfaseField;
			}
			set
			{
				this.sgt_wt_cursusfaseField = value;
			}
		}
		public CrmDateTime sgt_wt_toegangsdatum_totenmet
		{
			get
			{
				return this.sgt_wt_toegangsdatum_totenmetField;
			}
			set
			{
				this.sgt_wt_toegangsdatum_totenmetField = value;
			}
		}
		public CrmDateTime sgt_wt_toegangsdatum_vanaf
		{
			get
			{
				return this.sgt_wt_toegangsdatum_vanafField;
			}
			set
			{
				this.sgt_wt_toegangsdatum_vanafField = value;
			}
		}
		public Sgt_bo_cursistStateInfo statecode
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
