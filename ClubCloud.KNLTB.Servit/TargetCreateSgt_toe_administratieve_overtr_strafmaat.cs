using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_toe_administratieve_overtr_strafmaat : TargetCreate
	{
		private sgt_toe_administratieve_overtr_strafmaat sgt_toe_administratieve_overtr_strafmaatField;
		[XmlElement(Order = 0)]
		public sgt_toe_administratieve_overtr_strafmaat Sgt_toe_administratieve_overtr_strafmaat
		{
			get
			{
				return this.sgt_toe_administratieve_overtr_strafmaatField;
			}
			set
			{
				this.sgt_toe_administratieve_overtr_strafmaatField = value;
				base.RaisePropertyChanged("Sgt_toe_administratieve_overtr_strafmaat");
			}
		}
	}
}
