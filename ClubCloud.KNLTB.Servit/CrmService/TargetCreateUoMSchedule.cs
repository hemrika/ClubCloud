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
	public class TargetCreateUoMSchedule : TargetCreate
	{
		private uomschedule uoMScheduleField;

		[XmlElement] //[XmlElement(Order=0)]
		public uomschedule UoMSchedule
		{
			get
			{
				return this.uoMScheduleField;
			}
			set
			{
				this.uoMScheduleField = value;
				base.RaisePropertyChanged("UoMSchedule");
			}
		}

		public TargetCreateUoMSchedule()
		{
		}
	}
}