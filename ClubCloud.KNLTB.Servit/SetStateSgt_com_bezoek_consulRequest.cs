using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_com_bezoek_consulRequest : Request
	{
		private Guid entityIdField;
		private Sgt_com_bezoek_consulState sgt_com_bezoek_consulStateField;
		private int sgt_com_bezoek_consulStatusField;
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
		public Sgt_com_bezoek_consulState Sgt_com_bezoek_consulState
		{
			get
			{
				return this.sgt_com_bezoek_consulStateField;
			}
			set
			{
				this.sgt_com_bezoek_consulStateField = value;
				base.RaisePropertyChanged("Sgt_com_bezoek_consulState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_com_bezoek_consulStatus
		{
			get
			{
				return this.sgt_com_bezoek_consulStatusField;
			}
			set
			{
				this.sgt_com_bezoek_consulStatusField = value;
				base.RaisePropertyChanged("Sgt_com_bezoek_consulStatus");
			}
		}
	}
}
