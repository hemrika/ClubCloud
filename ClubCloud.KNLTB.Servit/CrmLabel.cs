using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class CrmLabel : INotifyPropertyChanged
	{
		private LocLabel[] locLabelsField;
		private LocLabel userLocLabelField;
		public event PropertyChangedEventHandler PropertyChanged;
		[XmlArray(Order = 0)]
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
		[XmlElement(Order = 1)]
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
