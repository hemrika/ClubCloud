using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_com_ploegmutatieRequest : Request
	{
		private Guid entityIdField;
		private Sgt_com_ploegmutatieState sgt_com_ploegmutatieStateField;
		private int sgt_com_ploegmutatieStatusField;
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
		public Sgt_com_ploegmutatieState Sgt_com_ploegmutatieState
		{
			get
			{
				return this.sgt_com_ploegmutatieStateField;
			}
			set
			{
				this.sgt_com_ploegmutatieStateField = value;
			}
		}
		public int Sgt_com_ploegmutatieStatus
		{
			get
			{
				return this.sgt_com_ploegmutatieStatusField;
			}
			set
			{
				this.sgt_com_ploegmutatieStatusField = value;
			}
		}
	}
}
