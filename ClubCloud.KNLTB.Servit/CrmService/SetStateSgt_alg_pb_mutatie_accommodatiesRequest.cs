using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_pb_mutatie_accommodatiesRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_pb_mutatie_accommodatiesState sgt_alg_pb_mutatie_accommodatiesStateField;
		private int sgt_alg_pb_mutatie_accommodatiesStatusField;
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
		public Sgt_alg_pb_mutatie_accommodatiesState Sgt_alg_pb_mutatie_accommodatiesState
		{
			get
			{
				return this.sgt_alg_pb_mutatie_accommodatiesStateField;
			}
			set
			{
				this.sgt_alg_pb_mutatie_accommodatiesStateField = value;
			}
		}
		public int Sgt_alg_pb_mutatie_accommodatiesStatus
		{
			get
			{
				return this.sgt_alg_pb_mutatie_accommodatiesStatusField;
			}
			set
			{
				this.sgt_alg_pb_mutatie_accommodatiesStatusField = value;
			}
		}
	}
}
