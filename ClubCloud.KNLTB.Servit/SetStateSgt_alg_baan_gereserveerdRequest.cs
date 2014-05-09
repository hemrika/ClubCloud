using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_baan_gereserveerdRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_baan_gereserveerdState sgt_alg_baan_gereserveerdStateField;
		private int sgt_alg_baan_gereserveerdStatusField;
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
		public Sgt_alg_baan_gereserveerdState Sgt_alg_baan_gereserveerdState
		{
			get
			{
				return this.sgt_alg_baan_gereserveerdStateField;
			}
			set
			{
				this.sgt_alg_baan_gereserveerdStateField = value;
				base.RaisePropertyChanged("Sgt_alg_baan_gereserveerdState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_alg_baan_gereserveerdStatus
		{
			get
			{
				return this.sgt_alg_baan_gereserveerdStatusField;
			}
			set
			{
				this.sgt_alg_baan_gereserveerdStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_baan_gereserveerdStatus");
			}
		}
	}
}
