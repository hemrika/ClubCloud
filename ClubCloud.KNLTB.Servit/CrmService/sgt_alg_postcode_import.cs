using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_alg_postcode_import : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private string sgt_afsluitrecordField;
		private string sgt_alg_nameField;
		private Key sgt_alg_postcode_importidField;
		private string sgt_extra_informatieField;
		private string sgt_jaarField;
		private string sgt_lognummerField;
		private Picklist sgt_maandField;
		private string sgt_opvolgende_importField;
		private Picklist sgt_soortField;
		private Picklist sgt_statusField;
		private CrmDateTime sgt_verwerkingsdatumField;
		private Sgt_alg_postcode_importStateInfo statecodeField;
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
		public string sgt_afsluitrecord
		{
			get
			{
				return this.sgt_afsluitrecordField;
			}
			set
			{
				this.sgt_afsluitrecordField = value;
			}
		}
		public string sgt_alg_name
		{
			get
			{
				return this.sgt_alg_nameField;
			}
			set
			{
				this.sgt_alg_nameField = value;
			}
		}
		public Key sgt_alg_postcode_importid
		{
			get
			{
				return this.sgt_alg_postcode_importidField;
			}
			set
			{
				this.sgt_alg_postcode_importidField = value;
			}
		}
		public string sgt_extra_informatie
		{
			get
			{
				return this.sgt_extra_informatieField;
			}
			set
			{
				this.sgt_extra_informatieField = value;
			}
		}
		public string sgt_jaar
		{
			get
			{
				return this.sgt_jaarField;
			}
			set
			{
				this.sgt_jaarField = value;
			}
		}
		public string sgt_lognummer
		{
			get
			{
				return this.sgt_lognummerField;
			}
			set
			{
				this.sgt_lognummerField = value;
			}
		}
		public Picklist sgt_maand
		{
			get
			{
				return this.sgt_maandField;
			}
			set
			{
				this.sgt_maandField = value;
			}
		}
		public string sgt_opvolgende_import
		{
			get
			{
				return this.sgt_opvolgende_importField;
			}
			set
			{
				this.sgt_opvolgende_importField = value;
			}
		}
		public Picklist sgt_soort
		{
			get
			{
				return this.sgt_soortField;
			}
			set
			{
				this.sgt_soortField = value;
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
		public CrmDateTime sgt_verwerkingsdatum
		{
			get
			{
				return this.sgt_verwerkingsdatumField;
			}
			set
			{
				this.sgt_verwerkingsdatumField = value;
			}
		}
		public Sgt_alg_postcode_importStateInfo statecode
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
