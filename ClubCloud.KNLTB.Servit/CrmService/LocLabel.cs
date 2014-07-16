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
	public class LocLabel : INotifyPropertyChanged
	{
		private string labelField;

		private CrmNumber languageCodeField;

		[XmlElement] //[XmlElement(Order=0)]
		public string Label
		{
			get
			{
				return this.labelField;
			}
			set
			{
				this.labelField = value;
				this.RaisePropertyChanged("Label");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public CrmNumber LanguageCode
		{
			get
			{
				return this.languageCodeField;
			}
			set
			{
				this.languageCodeField = value;
				this.RaisePropertyChanged("LanguageCode");
			}
		}

		public LocLabel()
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