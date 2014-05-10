using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_circuit_bonuspunten : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private CrmDateTime overriddencreatedonField;
		private CrmNumber sgt_bonuspuntenField;
		private Lookup sgt_circuitidField;
		private CrmNumber sgt_plaats_tmField;
		private CrmNumber sgt_plaats_vanafField;
		private string sgt_toe_circuit_bonuspunten1Field;
		private Key sgt_toe_circuit_bonuspuntenidField;
		private Sgt_toe_circuit_bonuspuntenStateInfo statecodeField;
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
		public CrmNumber sgt_bonuspunten
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
		public CrmNumber sgt_plaats_tm
		{
			get
			{
				return this.sgt_plaats_tmField;
			}
			set
			{
				this.sgt_plaats_tmField = value;
			}
		}
		public CrmNumber sgt_plaats_vanaf
		{
			get
			{
				return this.sgt_plaats_vanafField;
			}
			set
			{
				this.sgt_plaats_vanafField = value;
			}
		}
		[XmlElement("sgt_toe_circuit_bonuspunten")]
		public string sgt_toe_circuit_bonuspunten1
		{
			get
			{
				return this.sgt_toe_circuit_bonuspunten1Field;
			}
			set
			{
				this.sgt_toe_circuit_bonuspunten1Field = value;
			}
		}
		public Key sgt_toe_circuit_bonuspuntenid
		{
			get
			{
				return this.sgt_toe_circuit_bonuspuntenidField;
			}
			set
			{
				this.sgt_toe_circuit_bonuspuntenidField = value;
			}
		}
		public Sgt_toe_circuit_bonuspuntenStateInfo statecode
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
