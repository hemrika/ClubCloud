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
		[XmlElement(Order = 0)]
		public Lookup asyncoperationid
		{
			get
			{
				return this.asyncoperationidField;
			}
			set
			{
				this.asyncoperationidField = value;
				base.RaisePropertyChanged("asyncoperationid");
			}
		}
		[XmlElement(Order = 1)]
		public Key bulkdeleteoperationid
		{
			get
			{
				return this.bulkdeleteoperationidField;
			}
			set
			{
				this.bulkdeleteoperationidField = value;
				base.RaisePropertyChanged("bulkdeleteoperationid");
			}
		}
		[XmlElement(Order = 2)]
		public Lookup createdby
		{
			get
			{
				return this.createdbyField;
			}
			set
			{
				this.createdbyField = value;
				base.RaisePropertyChanged("createdby");
			}
		}
		[XmlElement(Order = 3)]
		public CrmDateTime createdon
		{
			get
			{
				return this.createdonField;
			}
			set
			{
				this.createdonField = value;
				base.RaisePropertyChanged("createdon");
			}
		}
		[XmlElement(Order = 4)]
		public CrmNumber failurecount
		{
			get
			{
				return this.failurecountField;
			}
			set
			{
				this.failurecountField = value;
				base.RaisePropertyChanged("failurecount");
			}
		}
		[XmlElement(Order = 5)]
		public CrmBoolean isrecurring
		{
			get
			{
				return this.isrecurringField;
			}
			set
			{
				this.isrecurringField = value;
				base.RaisePropertyChanged("isrecurring");
			}
		}
		[XmlElement(Order = 6)]
		public Lookup modifiedby
		{
			get
			{
				return this.modifiedbyField;
			}
			set
			{
				this.modifiedbyField = value;
				base.RaisePropertyChanged("modifiedby");
			}
		}
		[XmlElement(Order = 7)]
		public CrmDateTime modifiedon
		{
			get
			{
				return this.modifiedonField;
			}
			set
			{
				this.modifiedonField = value;
				base.RaisePropertyChanged("modifiedon");
			}
		}
		[XmlElement(Order = 8)]
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				base.RaisePropertyChanged("name");
			}
		}
		[XmlElement(Order = 9)]
		public CrmDateTime nextrun
		{
			get
			{
				return this.nextrunField;
			}
			set
			{
				this.nextrunField = value;
				base.RaisePropertyChanged("nextrun");
			}
		}
		[XmlElement(Order = 10)]
		public string orderedquerysetxml
		{
			get
			{
				return this.orderedquerysetxmlField;
			}
			set
			{
				this.orderedquerysetxmlField = value;
				base.RaisePropertyChanged("orderedquerysetxml");
			}
		}
		[XmlElement(Order = 11)]
		public Lookup owningbusinessunit
		{
			get
			{
				return this.owningbusinessunitField;
			}
			set
			{
				this.owningbusinessunitField = value;
				base.RaisePropertyChanged("owningbusinessunit");
			}
		}
		[XmlElement(Order = 12)]
		public Lookup owninguser
		{
			get
			{
				return this.owninguserField;
			}
			set
			{
				this.owninguserField = value;
				base.RaisePropertyChanged("owninguser");
			}
		}
		[XmlElement(Order = 13)]
		public CrmNumber processingqeindex
		{
			get
			{
				return this.processingqeindexField;
			}
			set
			{
				this.processingqeindexField = value;
				base.RaisePropertyChanged("processingqeindex");
			}
		}
		[XmlElement(Order = 14)]
		public BulkDeleteOperationStateInfo statecode
		{
			get
			{
				return this.statecodeField;
			}
			set
			{
				this.statecodeField = value;
				base.RaisePropertyChanged("statecode");
			}
		}
		[XmlElement(Order = 15)]
		public Status statuscode
		{
			get
			{
				return this.statuscodeField;
			}
			set
			{
				this.statuscodeField = value;
				base.RaisePropertyChanged("statuscode");
			}
		}
		[XmlElement(Order = 16)]
		public CrmNumber successcount
		{
			get
			{
				return this.successcountField;
			}
			set
			{
				this.successcountField = value;
				base.RaisePropertyChanged("successcount");
			}
		}
		[XmlElement(Order = 17)]
		public CrmNumber timezoneruleversionnumber
		{
			get
			{
				return this.timezoneruleversionnumberField;
			}
			set
			{
				this.timezoneruleversionnumberField = value;
				base.RaisePropertyChanged("timezoneruleversionnumber");
			}
		}
		[XmlElement(Order = 18)]
		public CrmNumber utcconversiontimezonecode
		{
			get
			{
				return this.utcconversiontimezonecodeField;
			}
			set
			{
				this.utcconversiontimezonecodeField = value;
				base.RaisePropertyChanged("utcconversiontimezonecode");
			}
		}
	}
}
