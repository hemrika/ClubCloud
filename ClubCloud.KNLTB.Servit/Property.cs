using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlInclude(typeof(DynamicEntityArrayProperty)), XmlInclude(typeof(UniqueIdentifierProperty)), XmlInclude(typeof(StringProperty)), XmlInclude(typeof(StatusProperty)), XmlInclude(typeof(StateProperty)), XmlInclude(typeof(PicklistProperty)), XmlInclude(typeof(OwnerProperty)), XmlInclude(typeof(LookupProperty)), XmlInclude(typeof(KeyProperty)), XmlInclude(typeof(EntityNameReferenceProperty)), XmlInclude(typeof(CustomerProperty)), XmlInclude(typeof(CrmMoneyProperty)), XmlInclude(typeof(CrmFloatProperty)), XmlInclude(typeof(CrmDecimalProperty)), XmlInclude(typeof(CrmDateTimeProperty)), XmlInclude(typeof(CrmBooleanProperty)), XmlInclude(typeof(CrmNumberProperty)), XmlType(Namespace = "http://schemas.microsoft.com/crm/2006/WebServices")]
	[Serializable]
	public abstract class Property : INotifyPropertyChanged
	{
		private string nameField;
		public event PropertyChangedEventHandler PropertyChanged;
		[XmlAttribute]
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				this.RaisePropertyChanged("Name");
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
