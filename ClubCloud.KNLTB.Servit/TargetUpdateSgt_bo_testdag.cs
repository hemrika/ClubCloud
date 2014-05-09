using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_bo_testdag : TargetUpdate
	{
		private sgt_bo_testdag sgt_bo_testdagField;
		[XmlElement(Order = 0)]
		public sgt_bo_testdag Sgt_bo_testdag
		{
			get
			{
				return this.sgt_bo_testdagField;
			}
			set
			{
				this.sgt_bo_testdagField = value;
				base.RaisePropertyChanged("Sgt_bo_testdag");
			}
		}
	}
}
