using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_com_competitiegedelegeerdeRequest : Request
	{
		private Guid entityIdField;
		private Sgt_com_competitiegedelegeerdeState sgt_com_competitiegedelegeerdeStateField;
		private int sgt_com_competitiegedelegeerdeStatusField;
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
		public Sgt_com_competitiegedelegeerdeState Sgt_com_competitiegedelegeerdeState
		{
			get
			{
				return this.sgt_com_competitiegedelegeerdeStateField;
			}
			set
			{
				this.sgt_com_competitiegedelegeerdeStateField = value;
				base.RaisePropertyChanged("Sgt_com_competitiegedelegeerdeState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_com_competitiegedelegeerdeStatus
		{
			get
			{
				return this.sgt_com_competitiegedelegeerdeStatusField;
			}
			set
			{
				this.sgt_com_competitiegedelegeerdeStatusField = value;
				base.RaisePropertyChanged("Sgt_com_competitiegedelegeerdeStatus");
			}
		}
	}
}
