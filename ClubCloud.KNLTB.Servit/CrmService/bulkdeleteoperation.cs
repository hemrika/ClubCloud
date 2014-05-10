using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class bulkdeleteoperation : BusinessEntity
	{
		private Lookup asyncoperationidField;
		private Key bulkdeleteoperationidField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber failurecountField;
		private CrmBoolean isrecurringField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private string nameField;
		private CrmDateTime nextrunField;
		private string orderedquerysetxmlField;
		private Lookup owningbusinessunitField;
		private Lookup owninguserField;
		private CrmNumber processingqeindexField;
		private BulkDeleteOperationStateInfo statecodeField;
		private Status statuscodeField;
		private CrmNumber successcountField;
		private CrmNumber timezoneruleversionnumberField;
		private CrmNumber utcconversiontimezonecodeField;
		public Lookup asyncoperationid
		{
			get
			{
				return this.asyncoperationidField;
			}
			set
			{
				this.asyncoperationidField = value;
			}
		}
		public Key bulkdeleteoperationid
		{
			get
			{
				return this.bulkdeleteoperationidField;
			}
			set
			{
				this.bulkdeleteoperationidField = value;
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
		public CrmNumber failurecount
		{
			get
			{
				return this.failurecountField;
			}
			set
			{
				this.failurecountField = value;
			}
		}
		public CrmBoolean isrecurring
		{
			get
			{
				return this.isrecurringField;
			}
			set
			{
				this.isrecurringField = value;
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
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}
		public CrmDateTime nextrun
		{
			get
			{
				return this.nextrunField;
			}
			set
			{
				this.nextrunField = value;
			}
		}
		public string orderedquerysetxml
		{
			get
			{
				return this.orderedquerysetxmlField;
			}
			set
			{
				this.orderedquerysetxmlField = value;
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
		public Lookup owninguser
		{
			get
			{
				return this.owninguserField;
			}
			set
			{
				this.owninguserField = value;
			}
		}
		public CrmNumber processingqeindex
		{
			get
			{
				return this.processingqeindexField;
			}
			set
			{
				this.processingqeindexField = value;
			}
		}
		public BulkDeleteOperationStateInfo statecode
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
		public CrmNumber successcount
		{
			get
			{
				return this.successcountField;
			}
			set
			{
				this.successcountField = value;
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
