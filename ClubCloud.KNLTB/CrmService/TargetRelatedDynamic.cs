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
	public class TargetRelatedDynamic : TargetRelated
	{
		private string entity1NameField;

		private Guid entity1IdField;

		private string entity2NameField;

		private Guid entity2IdField;

		[XmlElement] //[XmlElement(Order=1)]
		public Guid Entity1Id
		{
			get
			{
				return this.entity1IdField;
			}
			set
			{
				this.entity1IdField = value;
				base.RaisePropertyChanged("Entity1Id");
			}
		}

		[XmlElement] //[XmlElement(Order=0)]
		public string Entity1Name
		{
			get
			{
				return this.entity1NameField;
			}
			set
			{
				this.entity1NameField = value;
				base.RaisePropertyChanged("Entity1Name");
			}
		}

		[XmlElement] //[XmlElement(Order=3)]
		public Guid Entity2Id
		{
			get
			{
				return this.entity2IdField;
			}
			set
			{
				this.entity2IdField = value;
				base.RaisePropertyChanged("Entity2Id");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public string Entity2Name
		{
			get
			{
				return this.entity2NameField;
			}
			set
			{
				this.entity2NameField = value;
				base.RaisePropertyChanged("Entity2Name");
			}
		}

		public TargetRelatedDynamic()
		{
		}
	}
}