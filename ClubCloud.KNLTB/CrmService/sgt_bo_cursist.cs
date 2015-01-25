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

		private CrmBoolean sgt_email_her_inschr_cur_wachtlijst_verstuurdField;

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
		public Lookup sgt_administratieid
		{
			get
			{
				return this.sgt_administratieidField;
			}
			set
			{
				this.sgt_administratieidField = value;
				base.RaisePropertyChanged("sgt_administratieid");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public CrmBoolean sgt_afhankeliijk_vanov
		{
			get
			{
				return this.sgt_afhankeliijk_vanovField;
			}
			set
			{
				this.sgt_afhankeliijk_vanovField = value;
				base.RaisePropertyChanged("sgt_afhankeliijk_vanov");
			}
		}

		[XmlElement("sgt_bo_cursist")] //, Order=10)]
		public string sgt_bo_cursist1
		{
			get
			{
				return this.sgt_bo_cursist1Field;
			}
			set
			{
				this.sgt_bo_cursist1Field = value;
				base.RaisePropertyChanged("sgt_bo_cursist1");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public Key sgt_bo_cursistid
		{
			get
			{
				return this.sgt_bo_cursistidField;
			}
			set
			{
				this.sgt_bo_cursistidField = value;
				base.RaisePropertyChanged("sgt_bo_cursistid");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
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

		[XmlElement] //[XmlElement(Order=13)]
		public Lookup sgt_cursistid
		{
			get
			{
				return this.sgt_cursistidField;
			}
			set
			{
				this.sgt_cursistidField = value;
				base.RaisePropertyChanged("sgt_cursistid");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public CrmDateTime sgt_datum_betaling_opleiding
		{
			get
			{
				return this.sgt_datum_betaling_opleidingField;
			}
			set
			{
				this.sgt_datum_betaling_opleidingField = value;
				base.RaisePropertyChanged("sgt_datum_betaling_opleiding");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public CrmDateTime sgt_datum_betaling_testdag
		{
			get
			{
				return this.sgt_datum_betaling_testdagField;
			}
			set
			{
				this.sgt_datum_betaling_testdagField = value;
				base.RaisePropertyChanged("sgt_datum_betaling_testdag");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public CrmDateTime sgt_datum_geslaagd
		{
			get
			{
				return this.sgt_datum_geslaagdField;
			}
			set
			{
				this.sgt_datum_geslaagdField = value;
				base.RaisePropertyChanged("sgt_datum_geslaagd");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public CrmDateTime sgt_datum_tijd_aanmelding
		{
			get
			{
				return this.sgt_datum_tijd_aanmeldingField;
			}
			set
			{
				this.sgt_datum_tijd_aanmeldingField = value;
				base.RaisePropertyChanged("sgt_datum_tijd_aanmelding");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public CrmBoolean sgt_email_her_inschr_cur_wachtlijst_verstuurd
		{
			get
			{
				return this.sgt_email_her_inschr_cur_wachtlijst_verstuurdField;
			}
			set
			{
				this.sgt_email_her_inschr_cur_wachtlijst_verstuurdField = value;
				base.RaisePropertyChanged("sgt_email_her_inschr_cur_wachtlijst_verstuurd");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public CrmBoolean sgt_ervaring_met_lesgeven
		{
			get
			{
				return this.sgt_ervaring_met_lesgevenField;
			}
			set
			{
				this.sgt_ervaring_met_lesgevenField = value;
				base.RaisePropertyChanged("sgt_ervaring_met_lesgeven");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public Picklist sgt_factuur
		{
			get
			{
				return this.sgt_factuurField;
			}
			set
			{
				this.sgt_factuurField = value;
				base.RaisePropertyChanged("sgt_factuur");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public Lookup sgt_factuuradres
		{
			get
			{
				return this.sgt_factuuradresField;
			}
			set
			{
				this.sgt_factuuradresField = value;
				base.RaisePropertyChanged("sgt_factuuradres");
			}
		}

		[XmlElement] //[XmlElement(Order=22)]
		public string sgt_graag_samen_met
		{
			get
			{
				return this.sgt_graag_samen_metField;
			}
			set
			{
				this.sgt_graag_samen_metField = value;
				base.RaisePropertyChanged("sgt_graag_samen_met");
			}
		}

		[XmlElement] //[XmlElement(Order=23)]
		public CrmBoolean sgt_heeft_betaald
		{
			get
			{
				return this.sgt_heeft_betaaldField;
			}
			set
			{
				this.sgt_heeft_betaaldField = value;
				base.RaisePropertyChanged("sgt_heeft_betaald");
			}
		}

		[XmlElement] //[XmlElement(Order=24)]
		public CrmBoolean sgt_heeft_reanimatiediploma
		{
			get
			{
				return this.sgt_heeft_reanimatiediplomaField;
			}
			set
			{
				this.sgt_heeft_reanimatiediplomaField = value;
				base.RaisePropertyChanged("sgt_heeft_reanimatiediploma");
			}
		}

		[XmlElement] //[XmlElement(Order=25)]
		public CrmBoolean sgt_heeft_testdag_betaald
		{
			get
			{
				return this.sgt_heeft_testdag_betaaldField;
			}
			set
			{
				this.sgt_heeft_testdag_betaaldField = value;
				base.RaisePropertyChanged("sgt_heeft_testdag_betaald");
			}
		}

		[XmlElement] //[XmlElement(Order=26)]
		public Lookup sgt_inschrijfformulier_testdag
		{
			get
			{
				return this.sgt_inschrijfformulier_testdagField;
			}
			set
			{
				this.sgt_inschrijfformulier_testdagField = value;
				base.RaisePropertyChanged("sgt_inschrijfformulier_testdag");
			}
		}

		[XmlElement] //[XmlElement(Order=27)]
		public CrmBoolean sgt_kan_alleen_in_het_weekend
		{
			get
			{
				return this.sgt_kan_alleen_in_het_weekendField;
			}
			set
			{
				this.sgt_kan_alleen_in_het_weekendField = value;
				base.RaisePropertyChanged("sgt_kan_alleen_in_het_weekend");
			}
		}

		[XmlElement] //[XmlElement(Order=28)]
		public Lookup sgt_opleidingid
		{
			get
			{
				return this.sgt_opleidingidField;
			}
			set
			{
				this.sgt_opleidingidField = value;
				base.RaisePropertyChanged("sgt_opleidingid");
			}
		}

		[XmlElement] //[XmlElement(Order=29)]
		public Lookup sgt_opleidingsgroepid
		{
			get
			{
				return this.sgt_opleidingsgroepidField;
			}
			set
			{
				this.sgt_opleidingsgroepidField = value;
				base.RaisePropertyChanged("sgt_opleidingsgroepid");
			}
		}

		[XmlElement] //[XmlElement(Order=30)]
		public string sgt_opmerking_opleiding_betaald
		{
			get
			{
				return this.sgt_opmerking_opleiding_betaaldField;
			}
			set
			{
				this.sgt_opmerking_opleiding_betaaldField = value;
				base.RaisePropertyChanged("sgt_opmerking_opleiding_betaald");
			}
		}

		[XmlElement] //[XmlElement(Order=31)]
		public string sgt_opmerking_testdag_betaald
		{
			get
			{
				return this.sgt_opmerking_testdag_betaaldField;
			}
			set
			{
				this.sgt_opmerking_testdag_betaaldField = value;
				base.RaisePropertyChanged("sgt_opmerking_testdag_betaald");
			}
		}

		[XmlElement] //[XmlElement(Order=32)]
		public string sgt_overige_bijzonderheden
		{
			get
			{
				return this.sgt_overige_bijzonderhedenField;
			}
			set
			{
				this.sgt_overige_bijzonderhedenField = value;
				base.RaisePropertyChanged("sgt_overige_bijzonderheden");
			}
		}

		[XmlElement] //[XmlElement(Order=33)]
		public Picklist sgt_status_opleiding
		{
			get
			{
				return this.sgt_status_opleidingField;
			}
			set
			{
				this.sgt_status_opleidingField = value;
				base.RaisePropertyChanged("sgt_status_opleiding");
			}
		}

		[XmlElement] //[XmlElement(Order=34)]
		public Picklist sgt_status_testdag
		{
			get
			{
				return this.sgt_status_testdagField;
			}
			set
			{
				this.sgt_status_testdagField = value;
				base.RaisePropertyChanged("sgt_status_testdag");
			}
		}

		[XmlElement] //[XmlElement(Order=35)]
		public Lookup sgt_testdagid
		{
			get
			{
				return this.sgt_testdagidField;
			}
			set
			{
				this.sgt_testdagidField = value;
				base.RaisePropertyChanged("sgt_testdagid");
			}
		}

		[XmlElement] //[XmlElement(Order=36)]
		public CrmBoolean sgt_uwv_reintegratietraject
		{
			get
			{
				return this.sgt_uwv_reintegratietrajectField;
			}
			set
			{
				this.sgt_uwv_reintegratietrajectField = value;
				base.RaisePropertyChanged("sgt_uwv_reintegratietraject");
			}
		}

		[XmlElement] //[XmlElement(Order=37)]
		public CrmBoolean sgt_volgt_nog_een_andere_studie
		{
			get
			{
				return this.sgt_volgt_nog_een_andere_studieField;
			}
			set
			{
				this.sgt_volgt_nog_een_andere_studieField = value;
				base.RaisePropertyChanged("sgt_volgt_nog_een_andere_studie");
			}
		}

		[XmlElement] //[XmlElement(Order=38)]
		public Lookup sgt_voorkeur_opleidingsgroepid
		{
			get
			{
				return this.sgt_voorkeur_opleidingsgroepidField;
			}
			set
			{
				this.sgt_voorkeur_opleidingsgroepidField = value;
				base.RaisePropertyChanged("sgt_voorkeur_opleidingsgroepid");
			}
		}

		[XmlElement] //[XmlElement(Order=39)]
		public Lookup sgt_voorkeur_testdagid
		{
			get
			{
				return this.sgt_voorkeur_testdagidField;
			}
			set
			{
				this.sgt_voorkeur_testdagidField = value;
				base.RaisePropertyChanged("sgt_voorkeur_testdagid");
			}
		}

		[XmlElement] //[XmlElement(Order=40)]
		public CrmBoolean sgt_wachtlijst
		{
			get
			{
				return this.sgt_wachtlijstField;
			}
			set
			{
				this.sgt_wachtlijstField = value;
				base.RaisePropertyChanged("sgt_wachtlijst");
			}
		}

		[XmlElement] //[XmlElement(Order=41)]
		public CrmBoolean sgt_werk_op_zaterdag
		{
			get
			{
				return this.sgt_werk_op_zaterdagField;
			}
			set
			{
				this.sgt_werk_op_zaterdagField = value;
				base.RaisePropertyChanged("sgt_werk_op_zaterdag");
			}
		}

		[XmlElement] //[XmlElement(Order=42)]
		public string sgt_wt_cursuscode
		{
			get
			{
				return this.sgt_wt_cursuscodeField;
			}
			set
			{
				this.sgt_wt_cursuscodeField = value;
				base.RaisePropertyChanged("sgt_wt_cursuscode");
			}
		}

		[XmlElement] //[XmlElement(Order=43)]
		public string sgt_wt_cursusfase
		{
			get
			{
				return this.sgt_wt_cursusfaseField;
			}
			set
			{
				this.sgt_wt_cursusfaseField = value;
				base.RaisePropertyChanged("sgt_wt_cursusfase");
			}
		}

		[XmlElement] //[XmlElement(Order=44)]
		public CrmDateTime sgt_wt_toegangsdatum_totenmet
		{
			get
			{
				return this.sgt_wt_toegangsdatum_totenmetField;
			}
			set
			{
				this.sgt_wt_toegangsdatum_totenmetField = value;
				base.RaisePropertyChanged("sgt_wt_toegangsdatum_totenmet");
			}
		}

		[XmlElement] //[XmlElement(Order=45)]
		public CrmDateTime sgt_wt_toegangsdatum_vanaf
		{
			get
			{
				return this.sgt_wt_toegangsdatum_vanafField;
			}
			set
			{
				this.sgt_wt_toegangsdatum_vanafField = value;
				base.RaisePropertyChanged("sgt_wt_toegangsdatum_vanaf");
			}
		}

		[XmlElement] //[XmlElement(Order=46)]
		public Sgt_bo_cursistStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=47)]
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

		[XmlElement] //[XmlElement(Order=48)]
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

		[XmlElement] //[XmlElement(Order=49)]
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

		public sgt_bo_cursist()
		{
		}
	}
}