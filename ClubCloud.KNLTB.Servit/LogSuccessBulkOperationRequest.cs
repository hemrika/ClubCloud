using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class LogSuccessBulkOperationRequest : Request
	{
		private Guid bulkOperationIdField;
		private Guid regardingObjectIdField;
		private int regardingObjectTypeCodeField;
		private Guid createdObjectIdField;
		private int createdObjectTypeCodeField;
		private string additionalInfoField;
		[XmlElement(Order = 0)]
		public Guid BulkOperationId
		{
			get
			{
				return this.bulkOperationIdField;
			}
			set
			{
				this.bulkOperationIdField = value;
				base.RaisePropertyChanged("BulkOperationId");
			}
		}
		[XmlElement(Order = 1)]
		public Guid RegardingObjectId
		{
			get
			{
				return this.regardingObjectIdField;
			}
			set
			{
				this.regardingObjectIdField = value;
				base.RaisePropertyChanged("RegardingObjectId");
			}
		}
		[XmlElement(Order = 2)]
		public int RegardingObjectTypeCode
		{
			get
			{
				return this.regardingObjectTypeCodeField;
			}
			set
			{
				this.regardingObjectTypeCodeField = value;
				base.RaisePropertyChanged("RegardingObjectTypeCode");
			}
		}
		[XmlElement(Order = 3)]
		public Guid CreatedObjectId
		{
			get
			{
				return this.createdObjectIdField;
			}
			set
			{
				this.createdObjectIdField = value;
				base.RaisePropertyChanged("CreatedObjectId");
			}
		}
		[XmlElement(Order = 4)]
		public int CreatedObjectTypeCode
		{
			get
			{
				return this.createdObjectTypeCodeField;
			}
			set
			{
				this.createdObjectTypeCodeField = value;
				base.RaisePropertyChanged("CreatedObjectTypeCode");
			}
		}
		[XmlElement(Order = 5)]
		public string AdditionalInfo
		{
			get
			{
				return this.additionalInfoField;
			}
			set
			{
				this.additionalInfoField = value;
				base.RaisePropertyChanged("AdditionalInfo");
			}
		}
	}
}
