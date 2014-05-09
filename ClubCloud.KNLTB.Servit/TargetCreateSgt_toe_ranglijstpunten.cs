using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_toe_ranglijstpunten : TargetCreate
	{
		private sgt_toe_ranglijstpunten sgt_toe_ranglijstpuntenField;
		[XmlElement(Order = 0)]
		public sgt_toe_ranglijstpunten Sgt_toe_ranglijstpunten
		{
			get
			{
				return this.sgt_toe_ranglijstpuntenField;
			}
			set
			{
				this.sgt_toe_ranglijstpuntenField = value;
				base.RaisePropertyChanged("Sgt_toe_ranglijstpunten");
			}
		}
	}
}
