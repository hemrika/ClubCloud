using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("System.Xml", "4.0.30319.33440")]
	[Serializable]
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2007/WebServices")]
	public class wfprocess : BusinessEntity
	{
		private Lookup businessunitidField;

		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private string descriptionField;

		private string entitytypeField;

		private Picklist eventtypecodeField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private string nameField;

		private CrmNumber priorityField;

		private Picklist processcodeField;

		private Key processidField;

		private Picklist processtypecodeField;

		private CrmNumber processtypeversionField;

		private WFProcessStateInfo statecodeField;

		private Lookup usercontextField;

		[XmlElement] //[XmlElement(Order=0)]
		public Lookup businessunitid
		{
			get
			{
				return this.businessunitidField;
			}
			set
			{
				this.businessunitidField = value;
				base.RaisePropertyChanged("businessunitid");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
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

		[XmlElement] //[XmlElement(Order=2)]
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

		[XmlElement] //[XmlElement(Order=3)]
		public string description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				base.RaisePropertyChanged("description");
			}
		}

		[XmlElement] //[XmlElement(Order=4)]
		public string entitytype
		{
			get
			{
				return this.entitytypeField;
			}
			set
			{
				this.entitytypeField = value;
				base.RaisePropertyChanged("entitytype");
			}
		}

		[XmlElement] //[XmlElement(Order=5)]
		public Picklist eventtypecode
		{
			get
			{
				return this.eventtypecodeField;
			}
			set
			{
				this.eventtypecodeField = value;
				base.RaisePropertyChanged("eventtypecode");
			}
		}

		[XmlElement] //[XmlElement(Order=6)]
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

		[XmlElement] //[XmlElement(Order=7)]
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

		[XmlElement] //[XmlElement(Order=8)]
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

		[XmlElement] //[XmlElement(Order=9)]
		public CrmNumber priority
		{
			get
			{
				return this.priorityField;
			}
			set
			{
				this.priorityField = value;
				base.RaisePropertyChanged("priority");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public Picklist processcode
		{
			get
			{
				return this.processcodeField;
			}
			set
			{
				this.processcodeField = value;
				base.RaisePropertyChanged("processcode");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public Key processid
		{
			get
			{
				return this.processidField;
			}
			set
			{
				this.processidField = value;
				base.RaisePropertyChanged("processid");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public Picklist processtypecode
		{
			get
			{
				return this.processtypecodeField;
			}
			set
			{
				this.processtypecodeField = value;
				base.RaisePropertyChanged("processtypecode");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public CrmNumber processtypeversion
		{
			get
			{
				return this.processtypeversionField;
			}
			set
			{
				this.processtypeversionField = value;
				base.RaisePropertyChanged("processtypeversion");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public WFProcessStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=15)]
		public Lookup usercontext
		{
			get
			{
				return this.usercontextField;
			}
			set
			{
				this.usercontextField = value;
				base.RaisePropertyChanged("usercontext");
			}
		}

		public wfprocess()
		{
		}
	}
}