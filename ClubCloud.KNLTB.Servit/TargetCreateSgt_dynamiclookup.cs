using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_dynamiclookup : TargetCreate
	{
		private sgt_dynamiclookup sgt_dynamiclookupField;
		[XmlElement(Order = 0)]
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
	}
}
