using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_pb_mutatie_verenigingsinformatieRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_pb_mutatie_verenigingsinformatieState sgt_alg_pb_mutatie_verenigingsinformatieStateField;
		private int sgt_alg_pb_mutatie_verenigingsinformatieStatusField;
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
		public Sgt_alg_pb_mutatie_verenigingsinformatieState Sgt_alg_pb_mutatie_verenigingsinformatieState
		{
			get
			{
				return this.sgt_alg_pb_mutatie_verenigingsinformatieStateField;
			}
			set
			{
				this.sgt_alg_pb_mutatie_verenigingsinformatieStateField = value;
			}
		}
		public int Sgt_alg_pb_mutatie_verenigingsinformatieStatus
		{
			get
			{
				return this.sgt_alg_pb_mutatie_verenigingsinformatieStatusField;
			}
			set
			{
				this.sgt_alg_pb_mutatie_verenigingsinformatieStatusField = value;
			}
		}
	}
}