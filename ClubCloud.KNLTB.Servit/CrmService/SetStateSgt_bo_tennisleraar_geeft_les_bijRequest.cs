using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_bo_tennisleraar_geeft_les_bijRequest : Request
	{
		private Guid entityIdField;
		private Sgt_bo_tennisleraar_geeft_les_bijState sgt_bo_tennisleraar_geeft_les_bijStateField;
		private int sgt_bo_tennisleraar_geeft_les_bijStatusField;
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
		public Sgt_bo_tennisleraar_geeft_les_bijState Sgt_bo_tennisleraar_geeft_les_bijState
		{
			get
			{
				return this.sgt_bo_tennisleraar_geeft_les_bijStateField;
			}
			set
			{
				this.sgt_bo_tennisleraar_geeft_les_bijStateField = value;
			}
		}
		public int Sgt_bo_tennisleraar_geeft_les_bijStatus
		{
			get
			{
				return this.sgt_bo_tennisleraar_geeft_les_bijStatusField;
			}
			set
			{
				this.sgt_bo_tennisleraar_geeft_les_bijStatusField = value;
			}
		}
	}
}