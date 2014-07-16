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
	public class FindParentResourceGroupRequest : Request
	{
		private Guid parentIdField;

		private Guid[] childrenIdsField;

		[XmlArray] //[XmlArray(Order=1)]
		public Guid[] ChildrenIds
		{
			get
			{
				return this.childrenIdsField;
			}
			set
			{
				this.childrenIdsField = value;
				base.RaisePropertyChanged("ChildrenIds");
			}
		}

		[XmlElement] //[XmlElement(Order=0)]
		public Guid ParentId
		{
			get
			{
				return this.parentIdField;
			}
			set
			{
				this.parentIdField = value;
				base.RaisePropertyChanged("ParentId");
			}
		}

		public FindParentResourceGroupRequest()
		{
		}
	}
}