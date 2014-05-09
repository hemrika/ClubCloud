using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_toe_administratieve_overtr_strafbepalng : TargetUpdate
	{
		private sgt_toe_administratieve_overtr_strafbepalng sgt_toe_administratieve_overtr_strafbepalngField;
		[XmlElement(Order = 0)]
		public sgt_toe_administratieve_overtr_strafbepalng Sgt_toe_administratieve_overtr_strafbepalng
		{
			get
			{
				return this.sgt_toe_administratieve_overtr_strafbepalngField;
			}
			set
			{
				this.sgt_toe_administratieve_overtr_strafbepalngField = value;
				base.RaisePropertyChanged("Sgt_toe_administratieve_overtr_strafbepalng");
			}
		}
	}
}
