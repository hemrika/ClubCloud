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
	public class TargetCreateSgt_bo_inschrijfformulier_testdag : TargetCreate
	{
		private sgt_bo_inschrijfformulier_testdag sgt_bo_inschrijfformulier_testdagField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_bo_inschrijfformulier_testdag Sgt_bo_inschrijfformulier_testdag
		{
			get
			{
				return this.sgt_bo_inschrijfformulier_testdagField;
			}
			set
			{
				this.sgt_bo_inschrijfformulier_testdagField = value;
				base.RaisePropertyChanged("Sgt_bo_inschrijfformulier_testdag");
			}
		}

		public TargetCreateSgt_bo_inschrijfformulier_testdag()
		{
		}
	}
}