using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_postcodeRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_postcodeState sgt_alg_postcodeStateField;
		private int sgt_alg_postcodeStatusField;
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
		public Sgt_alg_postcodeState Sgt_alg_postcodeState
		{
			get
			{
				return this.sgt_alg_postcodeStateField;
			}
			set
			{
				this.sgt_alg_postcodeStateField = value;
				base.RaisePropertyChanged("Sgt_alg_postcodeState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_alg_postcodeStatus
		{
			get
			{
				return this.sgt_alg_postcodeStatusField;
			}
			set
			{
				this.sgt_alg_postcodeStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_postcodeStatus");
			}
		}
	}
}
