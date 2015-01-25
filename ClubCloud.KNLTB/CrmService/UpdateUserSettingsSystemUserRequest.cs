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
	public class UpdateUserSettingsSystemUserRequest : Request
	{
		private Guid userIdField;

		private BusinessEntity settingsField;

		[XmlElement] //[XmlElement(Order=1)]
		public BusinessEntity Settings
		{
			get
			{
				return this.settingsField;
			}
			set
			{
				this.settingsField = value;
				base.RaisePropertyChanged("Settings");
			}
		}

		[XmlElement] //[XmlElement(Order=0)]
		public Guid UserId
		{
			get
			{
				return this.userIdField;
			}
			set
			{
				this.userIdField = value;
				base.RaisePropertyChanged("UserId");
			}
		}

		public UpdateUserSettingsSystemUserRequest()
		{
		}
	}
}