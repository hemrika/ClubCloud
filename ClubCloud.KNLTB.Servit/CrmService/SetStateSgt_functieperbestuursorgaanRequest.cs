using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_functieperbestuursorgaanRequest : Request
	{
		private Guid entityIdField;
		private Sgt_functieperbestuursorgaanState sgt_functieperbestuursorgaanStateField;
		private int sgt_functieperbestuursorgaanStatusField;
		public Guid EntityId
		{
			get
			{
				return this.entityIdField;
			}
			set
			{
				this.entityIdField = value;
			}
		}
		public Sgt_functieperbestuursorgaanState Sgt_functieperbestuursorgaanState
		{
			get
			{
				return this.sgt_functieperbestuursorgaanStateField;
			}
			set
			{
				this.sgt_functieperbestuursorgaanStateField = value;
			}
		}
		public int Sgt_functieperbestuursorgaanStatus
		{
			get
			{
				return this.sgt_functieperbestuursorgaanStatusField;
			}
			set
			{
				this.sgt_functieperbestuursorgaanStatusField = value;
			}
		}
	}
}
