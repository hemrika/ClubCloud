using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_com_inschrijfbijdrageRequest : Request
	{
		private Guid entityIdField;
		private Sgt_com_inschrijfbijdrageState sgt_com_inschrijfbijdrageStateField;
		private int sgt_com_inschrijfbijdrageStatusField;
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
		public Sgt_com_inschrijfbijdrageState Sgt_com_inschrijfbijdrageState
		{
			get
			{
				return this.sgt_com_inschrijfbijdrageStateField;
			}
			set
			{
				this.sgt_com_inschrijfbijdrageStateField = value;
				base.RaisePropertyChanged("Sgt_com_inschrijfbijdrageState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_com_inschrijfbijdrageStatus
		{
			get
			{
				return this.sgt_com_inschrijfbijdrageStatusField;
			}
			set
			{
				this.sgt_com_inschrijfbijdrageStatusField = value;
				base.RaisePropertyChanged("Sgt_com_inschrijfbijdrageStatus");
			}
		}
	}
}
