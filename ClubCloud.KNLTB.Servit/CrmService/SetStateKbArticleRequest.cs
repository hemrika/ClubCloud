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
	public class SetStateKbArticleRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.KbArticleState kbArticleStateField;

		private int kbArticleStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.KbArticleState KbArticleState
		{
			get
			{
				return this.kbArticleStateField;
			}
			set
			{
				this.kbArticleStateField = value;
				base.RaisePropertyChanged("KbArticleState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int KbArticleStatus
		{
			get
			{
				return this.kbArticleStatusField;
			}
			set
			{
				this.kbArticleStatusField = value;
				base.RaisePropertyChanged("KbArticleStatus");
			}
		}

		public SetStateKbArticleRequest()
		{
		}
	}
}