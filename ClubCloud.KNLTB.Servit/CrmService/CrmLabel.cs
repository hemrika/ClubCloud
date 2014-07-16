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
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2007/WebServices")]
	public class CrmLabel : INotifyPropertyChanged
	{
		private LocLabel[] locLabelsField;

		private LocLabel userLocLabelField;

		[XmlArray] //[XmlArray(Order=0)]
		public LocLabel[] LocLabels
		{
			get
			{
				return this.locLabelsField;
			}
			set
			{
				this.locLabelsField = value;
				this.RaisePropertyChanged("LocLabels");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public LocLabel UserLocLabel
		{
			get
			{
				return this.userLocLabelField;
			}
			set
			{
				this.userLocLabelField = value;
				this.RaisePropertyChanged("UserLocLabel");
			}
		}

		public CrmLabel()
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