using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_baan_keuringRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_baan_keuringState sgt_alg_baan_keuringStateField;
		private int sgt_alg_baan_keuringStatusField;
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
		public Sgt_alg_baan_keuringState Sgt_alg_baan_keuringState
		{
			get
			{
				return this.sgt_alg_baan_keuringStateField;
			}
			set
			{
				this.sgt_alg_baan_keuringStateField = value;
				base.RaisePropertyChanged("Sgt_alg_baan_keuringState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_alg_baan_keuringStatus
		{
			get
			{
				return this.sgt_alg_baan_keuringStatusField;
			}
			set
			{
				this.sgt_alg_baan_keuringStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_baan_keuringStatus");
			}
		}
	}
}
