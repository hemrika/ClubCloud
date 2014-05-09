using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_com_beslissingswedstrijd : TargetCreate
	{
		private sgt_com_beslissingswedstrijd sgt_com_beslissingswedstrijdField;
		[XmlElement(Order = 0)]
		public sgt_com_beslissingswedstrijd Sgt_com_beslissingswedstrijd
		{
			get
			{
				return this.sgt_com_beslissingswedstrijdField;
			}
			set
			{
				this.sgt_com_beslissingswedstrijdField = value;
				base.RaisePropertyChanged("Sgt_com_beslissingswedstrijd");
			}
		}
	}
}
