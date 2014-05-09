using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateKbArticleRequest : Request
	{
		private Guid entityIdField;
		private KbArticleState kbArticleStateField;
		private int kbArticleStatusField;
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
		public KbArticleState KbArticleState
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
		[XmlElement(Order = 2)]
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
	}
}
