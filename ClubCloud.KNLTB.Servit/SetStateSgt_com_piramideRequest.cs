using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_com_piramideRequest : Request
	{
		private Guid entityIdField;
		private Sgt_com_piramideState sgt_com_piramideStateField;
		private int sgt_com_piramideStatusField;
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
		public Sgt_com_piramideState Sgt_com_piramideState
		{
			get
			{
				return this.sgt_com_piramideStateField;
			}
			set
			{
				this.sgt_com_piramideStateField = value;
				base.RaisePropertyChanged("Sgt_com_piramideState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_com_piramideStatus
		{
			get
			{
				return this.sgt_com_piramideStatusField;
			}
			set
			{
				this.sgt_com_piramideStatusField = value;
				base.RaisePropertyChanged("Sgt_com_piramideStatus");
			}
		}
	}
}
