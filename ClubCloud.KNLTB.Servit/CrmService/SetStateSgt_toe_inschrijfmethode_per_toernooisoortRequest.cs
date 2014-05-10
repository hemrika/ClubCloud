using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_inschrijfmethode_per_toernooisoortRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_inschrijfmethode_per_toernooisoortState sgt_toe_inschrijfmethode_per_toernooisoortStateField;
		private int sgt_toe_inschrijfmethode_per_toernooisoortStatusField;
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
		public Sgt_toe_inschrijfmethode_per_toernooisoortState Sgt_toe_inschrijfmethode_per_toernooisoortState
		{
			get
			{
				return this.sgt_toe_inschrijfmethode_per_toernooisoortStateField;
			}
			set
			{
				this.sgt_toe_inschrijfmethode_per_toernooisoortStateField = value;
			}
		}
		public int Sgt_toe_inschrijfmethode_per_toernooisoortStatus
		{
			get
			{
				return this.sgt_toe_inschrijfmethode_per_toernooisoortStatusField;
			}
			set
			{
				this.sgt_toe_inschrijfmethode_per_toernooisoortStatusField = value;
			}
		}
	}
}
