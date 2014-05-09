using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_com_verenigingsdispensatieRequest : Request
	{
		private Guid entityIdField;
		private Sgt_com_verenigingsdispensatieState sgt_com_verenigingsdispensatieStateField;
		private int sgt_com_verenigingsdispensatieStatusField;
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
		public Sgt_com_verenigingsdispensatieState Sgt_com_verenigingsdispensatieState
		{
			get
			{
				return this.sgt_com_verenigingsdispensatieStateField;
			}
			set
			{
				this.sgt_com_verenigingsdispensatieStateField = value;
				base.RaisePropertyChanged("Sgt_com_verenigingsdispensatieState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_com_verenigingsdispensatieStatus
		{
			get
			{
				return this.sgt_com_verenigingsdispensatieStatusField;
			}
			set
			{
				this.sgt_com_verenigingsdispensatieStatusField = value;
				base.RaisePropertyChanged("Sgt_com_verenigingsdispensatieStatus");
			}
		}
	}
}
