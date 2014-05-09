using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_dss_partijresultaatRequest : Request
	{
		private Guid entityIdField;
		private Sgt_dss_partijresultaatState sgt_dss_partijresultaatStateField;
		private int sgt_dss_partijresultaatStatusField;
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
		public Sgt_dss_partijresultaatState Sgt_dss_partijresultaatState
		{
			get
			{
				return this.sgt_dss_partijresultaatStateField;
			}
			set
			{
				this.sgt_dss_partijresultaatStateField = value;
				base.RaisePropertyChanged("Sgt_dss_partijresultaatState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_dss_partijresultaatStatus
		{
			get
			{
				return this.sgt_dss_partijresultaatStatusField;
			}
			set
			{
				this.sgt_dss_partijresultaatStatusField = value;
				base.RaisePropertyChanged("Sgt_dss_partijresultaatStatus");
			}
		}
	}
}
