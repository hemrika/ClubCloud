using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_postcode_importRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_postcode_importState sgt_alg_postcode_importStateField;
		private int sgt_alg_postcode_importStatusField;
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
		public Sgt_alg_postcode_importState Sgt_alg_postcode_importState
		{
			get
			{
				return this.sgt_alg_postcode_importStateField;
			}
			set
			{
				this.sgt_alg_postcode_importStateField = value;
				base.RaisePropertyChanged("Sgt_alg_postcode_importState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_alg_postcode_importStatus
		{
			get
			{
				return this.sgt_alg_postcode_importStatusField;
			}
			set
			{
				this.sgt_alg_postcode_importStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_postcode_importStatus");
			}
		}
	}
}
