using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlInclude(typeof(OfflineDataOptionalParameter)), XmlInclude(typeof(RequestIdOptionalParameter)), XmlInclude(typeof(RegardingObjectIdOptionalParameter)), XmlInclude(typeof(PersistInSyncOptionalParameter)), XmlInclude(typeof(CreateDuplicatesOptionalParameter)), XmlInclude(typeof(ExportIdsOptionalParameter)), XmlInclude(typeof(CallPriorityOptionalParameter)), XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public abstract class OptionalParameter : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
