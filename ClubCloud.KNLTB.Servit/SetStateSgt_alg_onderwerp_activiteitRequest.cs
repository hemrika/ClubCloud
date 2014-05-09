using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_onderwerp_activiteitRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_onderwerp_activiteitState sgt_alg_onderwerp_activiteitStateField;
		private int sgt_alg_onderwerp_activiteitStatusField;
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
		public Sgt_alg_onderwerp_activiteitState Sgt_alg_onderwerp_activiteitState
		{
			get
			{
				return this.sgt_alg_onderwerp_activiteitStateField;
			}
			set
			{
				this.sgt_alg_onderwerp_activiteitStateField = value;
				base.RaisePropertyChanged("Sgt_alg_onderwerp_activiteitState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_alg_onderwerp_activiteitStatus
		{
			get
			{
				return this.sgt_alg_onderwerp_activiteitStatusField;
			}
			set
			{
				this.sgt_alg_onderwerp_activiteitStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_onderwerp_activiteitStatus");
			}
		}
	}
}
