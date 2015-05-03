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
    /*
	[XmlInclude(typeof(TargetMergeAccount))]
	[XmlInclude(typeof(TargetMergeContact))]
	[XmlInclude(typeof(TargetMergeDynamic))]
	[XmlInclude(typeof(TargetMergeLead))]
    */
    [XmlSerializerAssembly(AssemblyName = "ClubCloud.KNLTB.XmlSerializers")]
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2007/WebServices")]
	public abstract class TargetMerge : INotifyPropertyChanged
	{
		protected TargetMerge()
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