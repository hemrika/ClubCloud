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
		public CrmDecimal sgt_bonuspunten
		{
			get
			{
				return this.sgt_bonuspuntenField;
			}
			set
			{
				this.sgt_bonuspuntenField = value;
			}
		}
		public Lookup sgt_ranglijstid
		{
			get
			{
				return this.sgt_ranglijstidField;
			}
			set
			{
				this.sgt_ranglijstidField = value;
			}
		}
		public CrmNumber sgt_ranglijstpunten
		{
			get
			{
				return this.sgt_ranglijstpuntenField;
			}
			set
			{
				this.sgt_ranglijstpuntenField = value;
			}
		}
		public Lookup sgt_speler1_id
		{
			get
			{
				return this.sgt_speler1_idField;
			}
			set
			{
				this.sgt_speler1_idField = value;
			}
		}
		public Lookup sgt_speler2_id
		{
			get
			{
				return this.sgt_speler2_idField;
			}
			set
			{
				this.sgt_speler2_idField = value;
			}
		}
		public CrmNumber sgt_strafpunten
		{
			get
			{
				return this.sgt_strafpuntenField;
			}
			set
			{
				this.sgt_strafpuntenField = value;
			}
		}
		public CrmBoolean sgt_telt_mee_voor_speler_1
		{
			get
			{
				return this.sgt_telt_mee_voor_speler_1Field;
			}
			set
			{
				this.sgt_telt_mee_voor_speler_1Field = value;
			}
		}
		public CrmBoolean sgt_telt_mee_voor_speler_2
		{
			get
			{
				return this.sgt_telt_mee_voor_speler_2Field;
			}
			set
			{
				this.sgt_telt_mee_voor_speler_2Field = value;
			}
		}
		public string sgt_toe_ranglijspunten_toernooiresultaat
		{
			get
			{
				return this.sgt_toe_ranglijspunten_toernooiresultaatField;
			}
			set
			{
				this.sgt_toe_ranglijspunten_toernooiresultaatField = value;
			}
		}
		public Key sgt_toe_ranglijstpunten_toernooiresultaatid
		{
			get
			{
				return this.sgt_toe_ranglijstpunten_toernooiresultaatidField;
			}
			set
			{
				this.sgt_toe_ranglijstpunten_toernooiresultaatidField = value;
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
		public Lookup sgt_toernooiresultaatid
		{
			get
			{
				return this.sgt_toernooiresultaatidField;
			}
			set
			{
				this.sgt_toernooiresultaatidField = value;
			}
		}
		public Sgt_toe_ranglijstpunten_toernooiresultaatStateInfo statecode
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
