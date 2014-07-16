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
	public class RollupRequest : Request
	{
		private TargetRollup targetField;

		private ClubCloud.KNLTB.ServIt.CrmService.RollupType rollupTypeField;

		private bool returnDynamicEntitiesField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.RollupType RollupType
		{
			get
			{
				return this.rollupTypeField;
			}
			set
			{
				this.rollupTypeField = value;
				base.RaisePropertyChanged("RollupType");
			}
		}

		[XmlElement] //[XmlElement(Order=0)]
		public TargetRollup Target
		{
			get
			{
				return this.targetField;
			}
			set
			{
				this.targetField = value;
				base.RaisePropertyChanged("Target");
			}
		}

		public RollupRequest()
		{
		}
	}
}