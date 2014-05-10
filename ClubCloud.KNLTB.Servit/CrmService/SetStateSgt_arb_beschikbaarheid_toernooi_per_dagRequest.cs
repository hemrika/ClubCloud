using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_arb_beschikbaarheid_toernooi_per_dagRequest : Request
	{
		private Guid entityIdField;
		private Sgt_arb_beschikbaarheid_toernooi_per_dagState sgt_arb_beschikbaarheid_toernooi_per_dagStateField;
		private int sgt_arb_beschikbaarheid_toernooi_per_dagStatusField;
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
		public Sgt_arb_beschikbaarheid_toernooi_per_dagState Sgt_arb_beschikbaarheid_toernooi_per_dagState
		{
			get
			{
				return this.sgt_arb_beschikbaarheid_toernooi_per_dagStateField;
			}
			set
			{
				this.sgt_arb_beschikbaarheid_toernooi_per_dagStateField = value;
			}
		}
		public int Sgt_arb_beschikbaarheid_toernooi_per_dagStatus
		{
			get
			{
				return this.sgt_arb_beschikbaarheid_toernooi_per_dagStatusField;
			}
			set
			{
				this.sgt_arb_beschikbaarheid_toernooi_per_dagStatusField = value;
			}
		}
	}
}
