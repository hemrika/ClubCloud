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
	public class InstantiateTemplateRequest : Request
	{
		private Guid templateIdField;

		private string objectTypeField;

		private Guid objectIdField;

		private bool returnDynamicEntitiesField;

		[XmlElement] //[XmlElement(Order=2)]
		public Guid ObjectId
		{
			get
			{
				return this.objectIdField;
			}
			set
			{
				this.objectIdField = value;
				base.RaisePropertyChanged("ObjectId");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public string ObjectType
		{
			get
			{
				return this.objectTypeField;
			}
			set
			{
				this.objectTypeField = value;
				base.RaisePropertyChanged("ObjectType");
			}
		}

		[XmlAttribute]
		public bool ReturnDynamicEntities
		{
			get
			{
				return this.returnDynamicEntitiesField;
			}
			set
			{
				this.returnDynamicEntitiesField = value;
				base.RaisePropertyChanged("ReturnDynamicEntities");
			}
		}

		[XmlElement] //[XmlElement(Order=0)]
		public Guid TemplateId
		{
			get
			{
				return this.templateIdField;
			}
			set
			{
				this.templateIdField = value;
				base.RaisePropertyChanged("TemplateId");
			}
		}

		public InstantiateTemplateRequest()
		{
		}
	}
}