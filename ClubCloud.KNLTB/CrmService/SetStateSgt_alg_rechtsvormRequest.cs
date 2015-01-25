using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("System.Xml", "4.0.30319.33440")]
	[Serializable]
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2007/WebServices")]
	public class SetStateSgt_alg_rechtsvormRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_rechtsvormState sgt_alg_rechtsvormStateField;

		private int sgt_alg_rechtsvormStatusField;

		[XmlElement] //[XmlElement(Order=0)]
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

		[XmlElement] //[XmlElement(Order=1)]
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_rechtsvormState Sgt_alg_rechtsvormState
		{
			get
			{
				return this.sgt_alg_rechtsvormStateField;
			}
			set
			{
				this.sgt_alg_rechtsvormStateField = value;
				base.RaisePropertyChanged("Sgt_alg_rechtsvormState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_alg_rechtsvormStatus
		{
			get
			{
				return this.sgt_alg_rechtsvormStatusField;
			}
			set
			{
				this.sgt_alg_rechtsvormStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_rechtsvormStatus");
			}
		}

		public SetStateSgt_alg_rechtsvormRequest()
		{
		}
	}
}