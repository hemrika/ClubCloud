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
	public class TargetUpdateSgt_com_beslissingswedstrijd : TargetUpdate
	{
		private sgt_com_beslissingswedstrijd sgt_com_beslissingswedstrijdField;

		[XmlElement] //[XmlElement(Order=0)]
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

		public TargetUpdateSgt_com_beslissingswedstrijd()
		{
		}
	}
}