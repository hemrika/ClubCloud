using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_alg_lidmaatschap : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private string sgt_alg_bondsnummerField;
		private Key sgt_alg_lidmaatschapidField;
		private CrmBoolean sgt_autorisatie_gezetField;
		private CrmDateTime sgt_datum_laatste_noodpasField;
		private CrmDateTime sgt_datum_laatste_pasField;
		private CrmDateTime sgt_datum_opgezegdField;
		private string sgt_fusie_informatieField;
		private Lookup sgt_inschrijfformulier_testdagidField;
		private Lookup sgt_lididField;
		private CrmDateTime sgt_lidmaatschap_beeindigdField;
		private CrmDateTime sgt_lidmaatschap_vanafField;
		private string sgt_lidnummer_bij_verenigingField;
		private CrmBoolean sgt_nieuwe_pas_nodigField;
		private CrmBoolean sgt_noodpas_nodigField;
		private Lookup sgt_pastypeidField;
		private Lookup sgt_pb_mutatie_ledenidField;
		private Lookup sgt_soort_lidmaatschapidField;
		private CrmNumber sgt_speelsterkte_dubbelField;
		private CrmNumber sgt_speelsterkte_dubbel_aangevraagdField;
		private CrmNumber sgt_speelsterkte_enkelField;
		private CrmNumber sgt_speelsterkte_enkel_aangevraagdField;
		private Picklist sgt_statusField;
		private Lookup sgt_toernooiorganisatieidField;
		private Lookup sgt_verenigingidField;
		private string sgt_volgnummer_pasField;
		private CrmBoolean sgt_wedstrijdpasField;
		private Sgt_alg_lidmaatschapStateInfo statecodeField;
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
		public string sgt_alg_bondsnummer
		{
			get
			{
				return this.sgt_alg_bondsnummerField;
			}
			set
			{
				this.sgt_alg_bondsnummerField = value;
			}
		}
		public Key sgt_alg_lidmaatschapid
		{
			get
			{
				return this.sgt_alg_lidmaatschapidField;
			}
			set
			{
				this.sgt_alg_lidmaatschapidField = value;
			}
		}
		public CrmBoolean sgt_autorisatie_gezet
		{
			get
			{
				return this.sgt_autorisatie_gezetField;
			}
			set
			{
				this.sgt_autorisatie_gezetField = value;
			}
		}
		public CrmDateTime sgt_datum_laatste_noodpas
		{
			get
			{
				return this.sgt_datum_laatste_noodpasField;
			}
			set
			{
				this.sgt_datum_laatste_noodpasField = value;
			}
		}
		public CrmDateTime sgt_datum_laatste_pas
		{
			get
			{
				return this.sgt_datum_laatste_pasField;
			}
			set
			{
				this.sgt_datum_laatste_pasField = value;
			}
		}
		public CrmDateTime sgt_datum_opgezegd
		{
			get
			{
				return this.sgt_datum_opgezegdField;
			}
			set
			{
				this.sgt_datum_opgezegdField = value;
			}
		}
		public string sgt_fusie_informatie
		{
			get
			{
				return this.sgt_fusie_informatieField;
			}
			set
			{
				this.sgt_fusie_informatieField = value;
			}
		}
		public Lookup sgt_inschrijfformulier_testdagid
		{
			get
			{
				return this.sgt_inschrijfformulier_testdagidField;
			}
			set
			{
				this.sgt_inschrijfformulier_testdagidField = value;
			}
		}
		public Lookup sgt_lidid
		{
			get
			{
				return this.sgt_lididField;
			}
			set
			{
				this.sgt_lididField = value;
			}
		}
		public CrmDateTime sgt_lidmaatschap_beeindigd
		{
			get
			{
				return this.sgt_lidmaatschap_beeindigdField;
			}
			set
			{
				this.sgt_lidmaatschap_beeindigdField = value;
			}
		}
		public CrmDateTime sgt_lidmaatschap_vanaf
		{
			get
			{
				return this.sgt_lidmaatschap_vanafField;
			}
			set
			{
				this.sgt_lidmaatschap_vanafField = value;
			}
		}
		public string sgt_lidnummer_bij_vereniging
		{
			get
			{
				return this.sgt_lidnummer_bij_verenigingField;
			}
			set
			{
				this.sgt_lidnummer_bij_verenigingField = value;
			}
		}
		public CrmBoolean sgt_nieuwe_pas_nodig
		{
			get
			{
				return this.sgt_nieuwe_pas_nodigField;
			}
			set
			{
				this.sgt_nieuwe_pas_nodigField = value;
			}
		}
		public CrmBoolean sgt_noodpas_nodig
		{
			get
			{
				return this.sgt_noodpas_nodigField;
			}
			set
			{
				this.sgt_noodpas_nodigField = value;
			}
		}
		public Lookup sgt_pastypeid
		{
			get
			{
				return this.sgt_pastypeidField;
			}
			set
			{
				this.sgt_pastypeidField = value;
			}
		}
		public Lookup sgt_pb_mutatie_ledenid
		{
			get
			{
				return this.sgt_pb_mutatie_ledenidField;
			}
			set
			{
				this.sgt_pb_mutatie_ledenidField = value;
			}
		}
		public Lookup sgt_soort_lidmaatschapid
		{
			get
			{
				return this.sgt_soort_lidmaatschapidField;
			}
			set
			{
				this.sgt_soort_lidmaatschapidField = value;
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
		public CrmNumber sgt_speelsterkte_dubbel_aangevraagd
		{
			get
			{
				return this.sgt_speelsterkte_dubbel_aangevraagdField;
			}
			set
			{
				this.sgt_speelsterkte_dubbel_aangevraagdField = value;
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
		public CrmNumber sgt_speelsterkte_enkel_aangevraagd
		{
			get
			{
				return this.sgt_speelsterkte_enkel_aangevraagdField;
			}
			set
			{
				this.sgt_speelsterkte_enkel_aangevraagdField = value;
			}
		}
		public Picklist sgt_status
		{
			get
			{
				return this.sgt_statusField;
			}
			set
			{
				this.sgt_statusField = value;
			}
		}
		public Lookup sgt_toernooiorganisatieid
		{
			get
			{
				return this.sgt_toernooiorganisatieidField;
			}
			set
			{
				this.sgt_toernooiorganisatieidField = value;
			}
		}
		public Lookup sgt_verenigingid
		{
			get
			{
				return this.sgt_verenigingidField;
			}
			set
			{
				this.sgt_verenigingidField = value;
			}
		}
		public string sgt_volgnummer_pas
		{
			get
			{
				return this.sgt_volgnummer_pasField;
			}
			set
			{
				this.sgt_volgnummer_pasField = value;
			}
		}
		public CrmBoolean sgt_wedstrijdpas
		{
			get
			{
				return this.sgt_wedstrijdpasField;
			}
			set
			{
				this.sgt_wedstrijdpasField = value;
			}
		}
		public Sgt_alg_lidmaatschapStateInfo statecode
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
