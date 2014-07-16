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
	public class SetStateGi_FieldLevelSecurityRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Gi_FieldLevelSecurityState gi_FieldLevelSecurityStateField;

		private int gi_FieldLevelSecurityStatusField;

		[XmlElement] //[XmlElement(Order=0)]
		public Guid EntityId
		{
			get
			{
				return this.entityIdField;
			}
			set
			{
				this.entityIdField = value;
				base.RaisePropertyChanged("EntityId");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public ClubCloud.KNLTB.ServIt.CrmService.Gi_FieldLevelSecurityState Gi_FieldLevelSecurityState
		{
			get
			{
				return this.gi_FieldLevelSecurityStateField;
			}
			set
			{
				this.gi_FieldLevelSecurityStateField = value;
				base.RaisePropertyChanged("Gi_FieldLevelSecurityState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Gi_FieldLevelSecurityStatus
		{
			get
			{
				return this.gi_FieldLevelSecurityStatusField;
			}
			set
			{
				this.gi_FieldLevelSecurityStatusField = value;
				base.RaisePropertyChanged("Gi_FieldLevelSecurityStatus");
			}
		}

		public SetStateGi_FieldLevelSecurityRequest()
		{
		}
	}
}