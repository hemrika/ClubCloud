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
	public class TargetCreateSgt_dynamiclookup : TargetCreate
	{
		private sgt_dynamiclookup sgt_dynamiclookupField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_dynamiclookup Sgt_dynamiclookup
		{
			get
			{
				return this.sgt_dynamiclookupField;
			}
			set
			{
				this.sgt_dynamiclookupField = value;
				base.RaisePropertyChanged("Sgt_dynamiclookup");
			}
		}

		public TargetCreateSgt_dynamiclookup()
		{
		}
	}
}