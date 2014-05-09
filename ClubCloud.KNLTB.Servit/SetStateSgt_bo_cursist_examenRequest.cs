using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_bo_cursist_examenRequest : Request
	{
		private Guid entityIdField;
		private Sgt_bo_cursist_examenState sgt_bo_cursist_examenStateField;
		private int sgt_bo_cursist_examenStatusField;
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
		public Sgt_bo_cursist_examenState Sgt_bo_cursist_examenState
		{
			get
			{
				return this.sgt_bo_cursist_examenStateField;
			}
			set
			{
				this.sgt_bo_cursist_examenStateField = value;
				base.RaisePropertyChanged("Sgt_bo_cursist_examenState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_bo_cursist_examenStatus
		{
			get
			{
				return this.sgt_bo_cursist_examenStatusField;
			}
			set
			{
				this.sgt_bo_cursist_examenStatusField = value;
				base.RaisePropertyChanged("Sgt_bo_cursist_examenStatus");
			}
		}
	}
}
