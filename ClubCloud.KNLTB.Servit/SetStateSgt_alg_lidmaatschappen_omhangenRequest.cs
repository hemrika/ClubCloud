using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_lidmaatschappen_omhangenRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_lidmaatschappen_omhangenState sgt_alg_lidmaatschappen_omhangenStateField;
		private int sgt_alg_lidmaatschappen_omhangenStatusField;
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
		public Sgt_alg_lidmaatschappen_omhangenState Sgt_alg_lidmaatschappen_omhangenState
		{
			get
			{
				return this.sgt_alg_lidmaatschappen_omhangenStateField;
			}
			set
			{
				this.sgt_alg_lidmaatschappen_omhangenStateField = value;
				base.RaisePropertyChanged("Sgt_alg_lidmaatschappen_omhangenState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_alg_lidmaatschappen_omhangenStatus
		{
			get
			{
				return this.sgt_alg_lidmaatschappen_omhangenStatusField;
			}
			set
			{
				this.sgt_alg_lidmaatschappen_omhangenStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_lidmaatschappen_omhangenStatus");
			}
		}
	}
}
