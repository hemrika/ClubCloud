using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2006/Scheduling")]
	[Serializable]
	public class ConstraintRelation : INotifyPropertyChanged
	{
		private Guid objectIdField;
		private string constraintTypeField;
		private string constraintsField;
		public event PropertyChangedEventHandler PropertyChanged;
		[XmlElement(Order = 0)]
		public Guid ObjectId
		{
			get
			{
				return this.objectIdField;
			}
			set
			{
				this.objectIdField = value;
				this.RaisePropertyChanged("ObjectId");
			}
		}
		[XmlElement(Order = 1)]
		public string ConstraintType
		{
			get
			{
				return this.constraintTypeField;
			}
			set
			{
				this.constraintTypeField = value;
				this.RaisePropertyChanged("ConstraintType");
			}
		}
		[XmlElement(Order = 2)]
		public string Constraints
		{
			get
			{
				return this.constraintsField;
			}
			set
			{
				this.constraintsField = value;
				this.RaisePropertyChanged("Constraints");
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
