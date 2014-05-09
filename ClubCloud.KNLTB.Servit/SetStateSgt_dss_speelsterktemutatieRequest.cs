using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_dss_speelsterktemutatieRequest : Request
	{
		private Guid entityIdField;
		private Sgt_dss_speelsterktemutatieState sgt_dss_speelsterktemutatieStateField;
		private int sgt_dss_speelsterktemutatieStatusField;
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
		public Sgt_dss_speelsterktemutatieState Sgt_dss_speelsterktemutatieState
		{
			get
			{
				return this.sgt_dss_speelsterktemutatieStateField;
			}
			set
			{
				this.sgt_dss_speelsterktemutatieStateField = value;
				base.RaisePropertyChanged("Sgt_dss_speelsterktemutatieState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_dss_speelsterktemutatieStatus
		{
			get
			{
				return this.sgt_dss_speelsterktemutatieStatusField;
			}
			set
			{
				this.sgt_dss_speelsterktemutatieStatusField = value;
				base.RaisePropertyChanged("Sgt_dss_speelsterktemutatieStatus");
			}
		}
	}
}
