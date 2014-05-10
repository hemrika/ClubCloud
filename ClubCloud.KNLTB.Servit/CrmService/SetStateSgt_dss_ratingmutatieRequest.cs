using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_dss_ratingmutatieRequest : Request
	{
		private Guid entityIdField;
		private Sgt_dss_ratingmutatieState sgt_dss_ratingmutatieStateField;
		private int sgt_dss_ratingmutatieStatusField;
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
		public Sgt_dss_ratingmutatieState Sgt_dss_ratingmutatieState
		{
			get
			{
				return this.sgt_dss_ratingmutatieStateField;
			}
			set
			{
				this.sgt_dss_ratingmutatieStateField = value;
			}
		}
		public int Sgt_dss_ratingmutatieStatus
		{
			get
			{
				return this.sgt_dss_ratingmutatieStatusField;
			}
			set
			{
				this.sgt_dss_ratingmutatieStatusField = value;
			}
		}
	}
}
