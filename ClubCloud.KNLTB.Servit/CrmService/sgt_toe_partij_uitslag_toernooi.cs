using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
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
		public string sgt_baan
		{
			get
			{
				return this.sgt_baanField;
			}
			set
			{
				this.sgt_baanField = value;
			}
		}
		public string sgt_basisschema_partij_speler_1
		{
			get
			{
				return this.sgt_basisschema_partij_speler_1Field;
			}
			set
			{
				this.sgt_basisschema_partij_speler_1Field = value;
			}
		}
		public string sgt_basisschema_partij_speler_2
		{
			get
			{
				return this.sgt_basisschema_partij_speler_2Field;
			}
			set
			{
				this.sgt_basisschema_partij_speler_2Field = value;
			}
		}
		public string sgt_basisschema_partij_speler_3
		{
			get
			{
				return this.sgt_basisschema_partij_speler_3Field;
			}
			set
			{
				this.sgt_basisschema_partij_speler_3Field = value;
			}
		}
		public string sgt_basisschema_partij_speler_4
		{
			get
			{
				return this.sgt_basisschema_partij_speler_4Field;
			}
			set
			{
				this.sgt_basisschema_partij_speler_4Field = value;
			}
		}
		public CrmDecimal sgt_einduitslag_thuis
		{
			get
			{
				return this.sgt_einduitslag_thuisField;
			}
			set
			{
				this.sgt_einduitslag_thuisField = value;
			}
		}
		public CrmDecimal sgt_einduitslag_uit
		{
			get
			{
				return this.sgt_einduitslag_uitField;
			}
			set
			{
				this.sgt_einduitslag_uitField = value;
			}
		}
		public CrmBoolean sgt_opgave_tijdens_wedstrijd
		{
			get
			{
				return this.sgt_opgave_tijdens_wedstrijdField;
			}
			set
			{
				this.sgt_opgave_tijdens_wedstrijdField = value;
			}
		}
		public CrmDateTime sgt_partij_datum
		{
			get
			{
				return this.sgt_partij_datumField;
			}
			set
			{
				this.sgt_partij_datumField = value;
			}
		}
		public string sgt_partij_nummer
		{
			get
			{
				return this.sgt_partij_nummerField;
			}
			set
			{
				this.sgt_partij_nummerField = value;
			}
		}
		public Picklist sgt_partij_status
		{
			get
			{
				return this.sgt_partij_statusField;
			}
			set
			{
				this.sgt_partij_statusField = value;
			}
		}
		public CrmNumber sgt_partijpunten_speler1
		{
			get
			{
				return this.sgt_partijpunten_speler1Field;
			}
			set
			{
				this.sgt_partijpunten_speler1Field = value;
			}
		}
		public CrmNumber sgt_partijpunten_speler2
		{
			get
			{
				return this.sgt_partijpunten_speler2Field;
			}
			set
			{
				this.sgt_partijpunten_speler2Field = value;
			}
		}
		public Lookup sgt_rondepouleid
		{
			get
			{
				return this.sgt_rondepouleidField;
			}
			set
			{
				this.sgt_rondepouleidField = value;
			}
		}
		public Lookup sgt_speelschemaid
		{
			get
			{
				return this.sgt_speelschemaidField;
			}
			set
			{
				this.sgt_speelschemaidField = value;
			}
		}
		public Picklist sgt_spelsoort
		{
			get
			{
				return this.sgt_spelsoortField;
			}
			set
			{
				this.sgt_spelsoortField = value;
			}
		}
		public CrmNumber sgt_thuis_set1
		{
			get
			{
				return this.sgt_thuis_set1Field;
			}
			set
			{
				this.sgt_thuis_set1Field = value;
			}
		}
		public CrmNumber sgt_thuis_set2
		{
			get
			{
				return this.sgt_thuis_set2Field;
			}
			set
			{
				this.sgt_thuis_set2Field = value;
			}
		}
		public CrmNumber sgt_thuis_set3
		{
			get
			{
				return this.sgt_thuis_set3Field;
			}
			set
			{
				this.sgt_thuis_set3Field = value;
			}
		}
		public CrmNumber sgt_thuis_set4
		{
			get
			{
				return this.sgt_thuis_set4Field;
			}
			set
			{
				this.sgt_thuis_set4Field = value;
			}
		}
		public CrmNumber sgt_thuis_set5
		{
			get
			{
				return this.sgt_thuis_set5Field;
			}
			set
			{
				this.sgt_thuis_set5Field = value;
			}
		}
		public string sgt_thuis_speler1
		{
			get
			{
				return this.sgt_thuis_speler1Field;
			}
			set
			{
				this.sgt_thuis_speler1Field = value;
			}
		}
		public Lookup sgt_thuis_speler1_nationaliteit_id
		{
			get
			{
				return this.sgt_thuis_speler1_nationaliteit_idField;
			}
			set
			{
				this.sgt_thuis_speler1_nationaliteit_idField = value;
			}
		}
		public string sgt_thuis_speler2
		{
			get
			{
				return this.sgt_thuis_speler2Field;
			}
			set
			{
				this.sgt_thuis_speler2Field = value;
			}
		}
		public Lookup sgt_thuis_speler2_nationaliteit_id
		{
			get
			{
				return this.sgt_thuis_speler2_nationaliteit_idField;
			}
			set
			{
				this.sgt_thuis_speler2_nationaliteit_idField = value;
			}
		}
		[XmlElement("sgt_toe_partij_uitslag_toernooi")]
		public string sgt_toe_partij_uitslag_toernooi1
		{
			get
			{
				return this.sgt_toe_partij_uitslag_toernooi1Field;
			}
			set
			{
				this.sgt_toe_partij_uitslag_toernooi1Field = value;
			}
		}
		public Key sgt_toe_partij_uitslag_toernooiid
		{
			get
			{
				return this.sgt_toe_partij_uitslag_toernooiidField;
			}
			set
			{
				this.sgt_toe_partij_uitslag_toernooiidField = value;
			}
		}
		public Lookup sgt_toernooiid
		{
			get
			{
				return this.sgt_toernooiidField;
			}
			set
			{
				this.sgt_toernooiidField = value;
			}
		}
		public Lookup sgt_toernooionderdeelid
		{
			get
			{
				return this.sgt_toernooionderdeelidField;
			}
			set
			{
				this.sgt_toernooionderdeelidField = value;
			}
		}
		public Lookup sgt_toernooispeler
		{
			get
			{
				return this.sgt_toernooispelerField;
			}
			set
			{
				this.sgt_toernooispelerField = value;
			}
		}
		public Lookup sgt_toernooispeler_thuis_wissel_id
		{
			get
			{
				return this.sgt_toernooispeler_thuis_wissel_idField;
			}
			set
			{
				this.sgt_toernooispeler_thuis_wissel_idField = value;
			}
		}
		public Lookup sgt_toernooispeler_uit_wissel_id
		{
			get
			{
				return this.sgt_toernooispeler_uit_wissel_idField;
			}
			set
			{
				this.sgt_toernooispeler_uit_wissel_idField = value;
			}
		}
		public Lookup sgt_toernooispeler_uitid
		{
			get
			{
				return this.sgt_toernooispeler_uitidField;
			}
			set
			{
				this.sgt_toernooispeler_uitidField = value;
			}
		}
		public CrmNumber sgt_uit_set1
		{
			get
			{
				return this.sgt_uit_set1Field;
			}
			set
			{
				this.sgt_uit_set1Field = value;
			}
		}
		public CrmNumber sgt_uit_set2
		{
			get
			{
				return this.sgt_uit_set2Field;
			}
			set
			{
				this.sgt_uit_set2Field = value;
			}
		}
		public CrmNumber sgt_uit_set3
		{
			get
			{
				return this.sgt_uit_set3Field;
			}
			set
			{
				this.sgt_uit_set3Field = value;
			}
		}
		public CrmNumber sgt_uit_set4
		{
			get
			{
				return this.sgt_uit_set4Field;
			}
			set
			{
				this.sgt_uit_set4Field = value;
			}
		}
		public CrmNumber sgt_uit_set5
		{
			get
			{
				return this.sgt_uit_set5Field;
			}
			set
			{
				this.sgt_uit_set5Field = value;
			}
		}
		public string sgt_uit_speler1
		{
			get
			{
				return this.sgt_uit_speler1Field;
			}
			set
			{
				this.sgt_uit_speler1Field = value;
			}
		}
		public Lookup sgt_uit_speler1_nationaliteit_id
		{
			get
			{
				return this.sgt_uit_speler1_nationaliteit_idField;
			}
			set
			{
				this.sgt_uit_speler1_nationaliteit_idField = value;
			}
		}
		public string sgt_uit_speler2
		{
			get
			{
				return this.sgt_uit_speler2Field;
			}
			set
			{
				this.sgt_uit_speler2Field = value;
			}
		}
		public Lookup sgt_uit_speler2_nationaliteit_id
		{
			get
			{
				return this.sgt_uit_speler2_nationaliteit_idField;
			}
			set
			{
				this.sgt_uit_speler2_nationaliteit_idField = value;
			}
		}
		public Sgt_toe_partij_uitslag_toernooiStateInfo statecode
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
