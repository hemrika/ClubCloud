using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_pb_mutaute_inschrijfcontrole_ver : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Picklist sgt__import_exportField;
		private CrmDateTime sgt_datum_mutatie_verwerktField;
		private string sgt_districtscodeField;
		private string sgt_districtsnaamField;
		private Lookup sgt_pb_itf_log_toernooien_idField;
		private Key sgt_toe_pb_mutaute_inschrijfcontrole_veridField;
		private string sgt_toe_volgnummerField;
		private string sgt_verenigingsnaamField;
		private string sgt_verenigingsnummerField;
		private string sgt_zoeknaam_verenigingField;
		private Sgt_toe_pb_mutaute_inschrijfcontrole_verStateInfo statecodeField;
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
		public Picklist sgt__import_export
		{
			get
			{
				return this.sgt__import_exportField;
			}
			set
			{
				this.sgt__import_exportField = value;
			}
		}
		public CrmDateTime sgt_datum_mutatie_verwerkt
		{
			get
			{
				return this.sgt_datum_mutatie_verwerktField;
			}
			set
			{
				this.sgt_datum_mutatie_verwerktField = value;
			}
		}
		public string sgt_districtscode
		{
			get
			{
				return this.sgt_districtscodeField;
			}
			set
			{
				this.sgt_districtscodeField = value;
			}
		}
		public string sgt_districtsnaam
		{
			get
			{
				return this.sgt_districtsnaamField;
			}
			set
			{
				this.sgt_districtsnaamField = value;
			}
		}
		public Lookup sgt_pb_itf_log_toernooien_id
		{
			get
			{
				return this.sgt_pb_itf_log_toernooien_idField;
			}
			set
			{
				this.sgt_pb_itf_log_toernooien_idField = value;
			}
		}
		public Key sgt_toe_pb_mutaute_inschrijfcontrole_verid
		{
			get
			{
				return this.sgt_toe_pb_mutaute_inschrijfcontrole_veridField;
			}
			set
			{
				this.sgt_toe_pb_mutaute_inschrijfcontrole_veridField = value;
			}
		}
		public string sgt_toe_volgnummer
		{
			get
			{
				return this.sgt_toe_volgnummerField;
			}
			set
			{
				this.sgt_toe_volgnummerField = value;
			}
		}
		public string sgt_verenigingsnaam
		{
			get
			{
				return this.sgt_verenigingsnaamField;
			}
			set
			{
				this.sgt_verenigingsnaamField = value;
			}
		}
		public string sgt_verenigingsnummer
		{
			get
			{
				return this.sgt_verenigingsnummerField;
			}
			set
			{
				this.sgt_verenigingsnummerField = value;
			}
		}
		public string sgt_zoeknaam_vereniging
		{
			get
			{
				return this.sgt_zoeknaam_verenigingField;
			}
			set
			{
				this.sgt_zoeknaam_verenigingField = value;
			}
		}
		public Sgt_toe_pb_mutaute_inschrijfcontrole_verStateInfo statecode
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
