using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_circuitpunten_toernooiresultaat : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private CrmDecimal sgt_bonus_puntenField;
		private Lookup sgt_circuitidField;
		private CrmNumber sgt_circuitpuntenField;
		private Lookup sgt_speler_1idField;
		private Lookup sgt_speler_2idField;
		private CrmNumber sgt_strafpuntenField;
		private string sgt_toe_circuitpunten_toernooiresultaat1Field;
		private Key sgt_toe_circuitpunten_toernooiresultaatidField;
		private Lookup sgt_toernooi_afhandelingidField;
		private Lookup sgt_toernooionderdeelidField;
		private Lookup sgt_toernooiresultaatidField;
		private Sgt_toe_circuitpunten_toernooiresultaatStateInfo statecodeField;
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
		public CrmDecimal sgt_bonus_punten
		{
			get
			{
				return this.sgt_bonus_puntenField;
			}
			set
			{
				this.sgt_bonus_puntenField = value;
			}
		}
		public Lookup sgt_circuitid
		{
			get
			{
				return this.sgt_circuitidField;
			}
			set
			{
				this.sgt_circuitidField = value;
			}
		}
		public CrmNumber sgt_circuitpunten
		{
			get
			{
				return this.sgt_circuitpuntenField;
			}
			set
			{
				this.sgt_circuitpuntenField = value;
			}
		}
		public Lookup sgt_speler_1id
		{
			get
			{
				return this.sgt_speler_1idField;
			}
			set
			{
				this.sgt_speler_1idField = value;
			}
		}
		public Lookup sgt_speler_2id
		{
			get
			{
				return this.sgt_speler_2idField;
			}
			set
			{
				this.sgt_speler_2idField = value;
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
		[XmlElement("sgt_toe_circuitpunten_toernooiresultaat")]
		public string sgt_toe_circuitpunten_toernooiresultaat1
		{
			get
			{
				return this.sgt_toe_circuitpunten_toernooiresultaat1Field;
			}
			set
			{
				this.sgt_toe_circuitpunten_toernooiresultaat1Field = value;
			}
		}
		public Key sgt_toe_circuitpunten_toernooiresultaatid
		{
			get
			{
				return this.sgt_toe_circuitpunten_toernooiresultaatidField;
			}
			set
			{
				this.sgt_toe_circuitpunten_toernooiresultaatidField = value;
			}
		}
		public Lookup sgt_toernooi_afhandelingid
		{
			get
			{
				return this.sgt_toernooi_afhandelingidField;
			}
			set
			{
				this.sgt_toernooi_afhandelingidField = value;
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
		public Sgt_toe_circuitpunten_toernooiresultaatStateInfo statecode
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
