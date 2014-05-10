using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_alg_inschrijf_functie_gebeurtenistype : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private CrmDateTime overriddencreatedonField;
		private Key sgt_alg_inschrijf_functie_gebeurtenistypeidField;
		private string sgt_alg_nameField;
		private CrmBoolean sgt_andere_personen_inschrijvenField;
		private Lookup sgt_functie_idField;
		private Lookup sgt_gebeurtenistype_idField;
		private Picklist sgt_vereniging_of_iedereenField;
		private Sgt_alg_inschrijf_functie_gebeurtenistypeStateInfo statecodeField;
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
		public Lookup organizationid
		{
			get
			{
				return this.organizationidField;
			}
			set
			{
				this.organizationidField = value;
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
		public Key sgt_alg_inschrijf_functie_gebeurtenistypeid
		{
			get
			{
				return this.sgt_alg_inschrijf_functie_gebeurtenistypeidField;
			}
			set
			{
				this.sgt_alg_inschrijf_functie_gebeurtenistypeidField = value;
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
		public CrmBoolean sgt_andere_personen_inschrijven
		{
			get
			{
				return this.sgt_andere_personen_inschrijvenField;
			}
			set
			{
				this.sgt_andere_personen_inschrijvenField = value;
			}
		}
		public Lookup sgt_functie_id
		{
			get
			{
				return this.sgt_functie_idField;
			}
			set
			{
				this.sgt_functie_idField = value;
			}
		}
		public Lookup sgt_gebeurtenistype_id
		{
			get
			{
				return this.sgt_gebeurtenistype_idField;
			}
			set
			{
				this.sgt_gebeurtenistype_idField = value;
			}
		}
		public Picklist sgt_vereniging_of_iedereen
		{
			get
			{
				return this.sgt_vereniging_of_iedereenField;
			}
			set
			{
				this.sgt_vereniging_of_iedereenField = value;
			}
		}
		public Sgt_alg_inschrijf_functie_gebeurtenistypeStateInfo statecode
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
