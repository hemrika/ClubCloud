using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_nummerreeksRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_nummerreeksState sgt_alg_nummerreeksStateField;
		private int sgt_alg_nummerreeksStatusField;
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
		public Sgt_alg_nummerreeksState Sgt_alg_nummerreeksState
		{
			get
			{
				return this.sgt_alg_nummerreeksStateField;
			}
			set
			{
				this.sgt_alg_nummerreeksStateField = value;
				base.RaisePropertyChanged("Sgt_alg_nummerreeksState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_alg_nummerreeksStatus
		{
			get
			{
				return this.sgt_alg_nummerreeksStatusField;
			}
			set
			{
				this.sgt_alg_nummerreeksStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_nummerreeksStatus");
			}
		}
	}
}
