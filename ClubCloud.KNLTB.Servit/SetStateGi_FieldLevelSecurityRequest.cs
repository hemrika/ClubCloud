using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateGi_FieldLevelSecurityRequest : Request
	{
		private Guid entityIdField;
		private Gi_FieldLevelSecurityState gi_FieldLevelSecurityStateField;
		private int gi_FieldLevelSecurityStatusField;
		[XmlElement(Order = 0)]
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
		[XmlElement(Order = 1)]
		public Gi_FieldLevelSecurityState Gi_FieldLevelSecurityState
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
		[XmlElement(Order = 2)]
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
	}
}
