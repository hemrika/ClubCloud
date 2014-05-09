using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_custom_configRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_custom_configState sgt_alg_custom_configStateField;
		private int sgt_alg_custom_configStatusField;
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
		public Sgt_alg_custom_configState Sgt_alg_custom_configState
		{
			get
			{
				return this.sgt_alg_custom_configStateField;
			}
			set
			{
				this.sgt_alg_custom_configStateField = value;
				base.RaisePropertyChanged("Sgt_alg_custom_configState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_alg_custom_configStatus
		{
			get
			{
				return this.sgt_alg_custom_configStatusField;
			}
			set
			{
				this.sgt_alg_custom_configStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_custom_configStatus");
			}
		}
	}
}
