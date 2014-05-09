using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateLetterRequest : Request
	{
		private Guid entityIdField;
		private LetterState letterStateField;
		private int letterStatusField;
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
		public LetterState LetterState
		{
			get
			{
				return this.letterStateField;
			}
			set
			{
				this.letterStateField = value;
				base.RaisePropertyChanged("LetterState");
			}
		}
		[XmlElement(Order = 2)]
		public int LetterStatus
		{
			get
			{
				return this.letterStatusField;
			}
			set
			{
				this.letterStatusField = value;
				base.RaisePropertyChanged("LetterStatus");
			}
		}
	}
}
