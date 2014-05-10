using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_bo_cursist_examen : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private CrmBoolean sgt_betaaldField;
		private Key sgt_bo_cursist_examenidField;
		private string sgt_cursist_examenField;
		private Lookup sgt_cursistidField;
		private CrmDateTime sgt_datum_betalingField;
		private Lookup sgt_examenidField;
		private Lookup sgt_opleidingidField;
		private string sgt_opmerking_betalingField;
		private Lookup sgt_soortexamenidField;
		private Picklist sgt_status_examenField;
		private Sgt_bo_cursist_examenStateInfo statecodeField;
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
		public CrmBoolean sgt_betaald
		{
			get
			{
				return this.sgt_betaaldField;
			}
			set
			{
				this.sgt_betaaldField = value;
			}
		}
		public Key sgt_bo_cursist_examenid
		{
			get
			{
				return this.sgt_bo_cursist_examenidField;
			}
			set
			{
				this.sgt_bo_cursist_examenidField = value;
			}
		}
		public string sgt_cursist_examen
		{
			get
			{
				return this.sgt_cursist_examenField;
			}
			set
			{
				this.sgt_cursist_examenField = value;
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
		public CrmDateTime sgt_datum_betaling
		{
			get
			{
				return this.sgt_datum_betalingField;
			}
			set
			{
				this.sgt_datum_betalingField = value;
			}
		}
		public Lookup sgt_examenid
		{
			get
			{
				return this.sgt_examenidField;
			}
			set
			{
				this.sgt_examenidField = value;
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
		public string sgt_opmerking_betaling
		{
			get
			{
				return this.sgt_opmerking_betalingField;
			}
			set
			{
				this.sgt_opmerking_betalingField = value;
			}
		}
		public Lookup sgt_soortexamenid
		{
			get
			{
				return this.sgt_soortexamenidField;
			}
			set
			{
				this.sgt_soortexamenidField = value;
			}
		}
		public Picklist sgt_status_examen
		{
			get
			{
				return this.sgt_status_examenField;
			}
			set
			{
				this.sgt_status_examenField = value;
			}
		}
		public Sgt_bo_cursist_examenStateInfo statecode
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
