using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("System.Xml", "4.0.30319.33440")]
	[Serializable]
	[XmlInclude(typeof(CallPriorityOptionalParameter))]
	[XmlInclude(typeof(CreateDuplicatesOptionalParameter))]
	[XmlInclude(typeof(ExportIdsOptionalParameter))]
	[XmlInclude(typeof(OfflineDataOptionalParameter))]
	[XmlInclude(typeof(PersistInSyncOptionalParameter))]
	[XmlInclude(typeof(RegardingObjectIdOptionalParameter))]
	[XmlInclude(typeof(RequestIdOptionalParameter))]
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2007/WebServices")]
	public abstract class OptionalParameter : INotifyPropertyChanged
	{
		protected OptionalParameter()
		{
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}
}