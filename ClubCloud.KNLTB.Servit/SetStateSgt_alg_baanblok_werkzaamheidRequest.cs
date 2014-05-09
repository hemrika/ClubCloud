using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_baanblok_werkzaamheidRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_baanblok_werkzaamheidState sgt_alg_baanblok_werkzaamheidStateField;
		private int sgt_alg_baanblok_werkzaamheidStatusField;
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
		public Sgt_alg_baanblok_werkzaamheidState Sgt_alg_baanblok_werkzaamheidState
		{
			get
			{
				return this.sgt_alg_baanblok_werkzaamheidStateField;
			}
			set
			{
				this.sgt_alg_baanblok_werkzaamheidStateField = value;
				base.RaisePropertyChanged("Sgt_alg_baanblok_werkzaamheidState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_alg_baanblok_werkzaamheidStatus
		{
			get
			{
				return this.sgt_alg_baanblok_werkzaamheidStatusField;
			}
			set
			{
				this.sgt_alg_baanblok_werkzaamheidStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_baanblok_werkzaamheidStatus");
			}
		}
	}
}
