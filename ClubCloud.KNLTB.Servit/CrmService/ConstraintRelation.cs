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
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2006/Scheduling")]
	public class ConstraintRelation : INotifyPropertyChanged
	{
		private Guid objectIdField;

		private string constraintTypeField;

		private string constraintsField;

		[XmlElement] //[XmlElement(Order=2)]
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

		[XmlElement] //[XmlElement(Order=1)]
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

		[XmlElement] //[XmlElement(Order=0)]
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

		public ConstraintRelation()
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