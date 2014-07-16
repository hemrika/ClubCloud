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
	public class InitializeFromRequest : Request
	{
		private Moniker entityMonikerField;

		private string targetEntityNameField;

		private ClubCloud.KNLTB.ServIt.CrmService.TargetFieldType targetFieldTypeField;

		private bool returnDynamicEntitiesField;

		[XmlElement] //[XmlElement(Order=0)]
		public Moniker EntityMoniker
		{
			get
			{
				return this.entityMonikerField;
			}
			set
			{
				this.entityMonikerField = value;
				base.RaisePropertyChanged("EntityMoniker");
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

		[XmlElement] //[XmlElement(Order=1)]
		public string TargetEntityName
		{
			get
			{
				return this.targetEntityNameField;
			}
			set
			{
				this.targetEntityNameField = value;
				base.RaisePropertyChanged("TargetEntityName");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public ClubCloud.KNLTB.ServIt.CrmService.TargetFieldType TargetFieldType
		{
			get
			{
				return this.targetFieldTypeField;
			}
			set
			{
				this.targetFieldTypeField = value;
				base.RaisePropertyChanged("TargetFieldType");
			}
		}

		public InitializeFromRequest()
		{
		}
	}
}