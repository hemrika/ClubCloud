using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_kvk_brancheRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_kvk_brancheState sgt_alg_kvk_brancheStateField;
		private int sgt_alg_kvk_brancheStatusField;
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
		public Sgt_alg_kvk_brancheState Sgt_alg_kvk_brancheState
		{
			get
			{
				return this.sgt_alg_kvk_brancheStateField;
			}
			set
			{
				this.sgt_alg_kvk_brancheStateField = value;
				base.RaisePropertyChanged("Sgt_alg_kvk_brancheState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_alg_kvk_brancheStatus
		{
			get
			{
				return this.sgt_alg_kvk_brancheStatusField;
			}
			set
			{
				this.sgt_alg_kvk_brancheStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_kvk_brancheStatus");
			}
		}
	}
}
