using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_com_controle_dispensatie_logboekRequest : Request
	{
		private Guid entityIdField;
		private Sgt_com_controle_dispensatie_logboekState sgt_com_controle_dispensatie_logboekStateField;
		private int sgt_com_controle_dispensatie_logboekStatusField;
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
		public Sgt_com_controle_dispensatie_logboekState Sgt_com_controle_dispensatie_logboekState
		{
			get
			{
				return this.sgt_com_controle_dispensatie_logboekStateField;
			}
			set
			{
				this.sgt_com_controle_dispensatie_logboekStateField = value;
				base.RaisePropertyChanged("Sgt_com_controle_dispensatie_logboekState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_com_controle_dispensatie_logboekStatus
		{
			get
			{
				return this.sgt_com_controle_dispensatie_logboekStatusField;
			}
			set
			{
				this.sgt_com_controle_dispensatie_logboekStatusField = value;
				base.RaisePropertyChanged("Sgt_com_controle_dispensatie_logboekStatus");
			}
		}
	}
}
