using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_com_thuis_thuis_schemaRequest : Request
	{
		private Guid entityIdField;
		private Sgt_com_thuis_thuis_schemaState sgt_com_thuis_thuis_schemaStateField;
		private int sgt_com_thuis_thuis_schemaStatusField;
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
		public Sgt_com_thuis_thuis_schemaState Sgt_com_thuis_thuis_schemaState
		{
			get
			{
				return this.sgt_com_thuis_thuis_schemaStateField;
			}
			set
			{
				this.sgt_com_thuis_thuis_schemaStateField = value;
				base.RaisePropertyChanged("Sgt_com_thuis_thuis_schemaState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_com_thuis_thuis_schemaStatus
		{
			get
			{
				return this.sgt_com_thuis_thuis_schemaStatusField;
			}
			set
			{
				this.sgt_com_thuis_thuis_schemaStatusField = value;
				base.RaisePropertyChanged("Sgt_com_thuis_thuis_schemaStatus");
			}
		}
	}
}
