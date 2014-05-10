using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_rol_verbergen_tabbladen_secties : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private string sgt_naam_entiteitField;
		private string sgt_naam_sectieField;
		private string sgt_naam_tabbladField;
		private string sgt_nameField;
		private Lookup sgt_primaire_rolidField;
		private Lookup sgt_rol_verbergen_entiteitidField;
		private Key sgt_rol_verbergen_tabbladen_sectiesidField;
		private Lookup sgt_rolnaamidField;
		private Sgt_rol_verbergen_tabbladen_sectiesStateInfo statecodeField;
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
		public string sgt_naam_entiteit
		{
			get
			{
				return this.sgt_naam_entiteitField;
			}
			set
			{
				this.sgt_naam_entiteitField = value;
			}
		}
		public string sgt_naam_sectie
		{
			get
			{
				return this.sgt_naam_sectieField;
			}
			set
			{
				this.sgt_naam_sectieField = value;
			}
		}
		public string sgt_naam_tabblad
		{
			get
			{
				return this.sgt_naam_tabbladField;
			}
			set
			{
				this.sgt_naam_tabbladField = value;
			}
		}
		public string sgt_name
		{
			get
			{
				return this.sgt_nameField;
			}
			set
			{
				this.sgt_nameField = value;
			}
		}
		public Lookup sgt_primaire_rolid
		{
			get
			{
				return this.sgt_primaire_rolidField;
			}
			set
			{
				this.sgt_primaire_rolidField = value;
			}
		}
		public Lookup sgt_rol_verbergen_entiteitid
		{
			get
			{
				return this.sgt_rol_verbergen_entiteitidField;
			}
			set
			{
				this.sgt_rol_verbergen_entiteitidField = value;
			}
		}
		public Key sgt_rol_verbergen_tabbladen_sectiesid
		{
			get
			{
				return this.sgt_rol_verbergen_tabbladen_sectiesidField;
			}
			set
			{
				this.sgt_rol_verbergen_tabbladen_sectiesidField = value;
			}
		}
		public Lookup sgt_rolnaamid
		{
			get
			{
				return this.sgt_rolnaamidField;
			}
			set
			{
				this.sgt_rolnaamidField = value;
			}
		}
		public Sgt_rol_verbergen_tabbladen_sectiesStateInfo statecode
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
