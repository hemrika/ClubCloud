using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class picklistmapping : BusinessEntity
	{
		private Lookup columnmappingidField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Key picklistmappingidField;
		private Picklist processcodeField;
		private string sourcevalueField;
		private PickListMappingStateInfo statecodeField;
		private Status statuscodeField;
		private CrmNumber targetvalueField;
		public Lookup columnmappingid
		{
			get
			{
				return this.columnmappingidField;
			}
			set
			{
				this.columnmappingidField = value;
			}
		}
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
		public Key picklistmappingid
		{
			get
			{
				return this.picklistmappingidField;
			}
			set
			{
				this.picklistmappingidField = value;
			}
		}
		public Picklist processcode
		{
			get
			{
				return this.processcodeField;
			}
			set
			{
				this.processcodeField = value;
			}
		}
		public string sourcevalue
		{
			get
			{
				return this.sourcevalueField;
			}
			set
			{
				this.sourcevalueField = value;
			}
		}
		public PickListMappingStateInfo statecode
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
		public CrmNumber targetvalue
		{
			get
			{
				return this.targetvalueField;
			}
			set
			{
				this.targetvalueField = value;
			}
		}
	}
}
