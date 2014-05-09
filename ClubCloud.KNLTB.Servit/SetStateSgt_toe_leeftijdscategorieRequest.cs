using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_leeftijdscategorieRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_leeftijdscategorieState sgt_toe_leeftijdscategorieStateField;
		private int sgt_toe_leeftijdscategorieStatusField;
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
		public Sgt_toe_leeftijdscategorieState Sgt_toe_leeftijdscategorieState
		{
			get
			{
				return this.sgt_toe_leeftijdscategorieStateField;
			}
			set
			{
				this.sgt_toe_leeftijdscategorieStateField = value;
				base.RaisePropertyChanged("Sgt_toe_leeftijdscategorieState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_toe_leeftijdscategorieStatus
		{
			get
			{
				return this.sgt_toe_leeftijdscategorieStatusField;
			}
			set
			{
				this.sgt_toe_leeftijdscategorieStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_leeftijdscategorieStatus");
			}
		}
	}
}
