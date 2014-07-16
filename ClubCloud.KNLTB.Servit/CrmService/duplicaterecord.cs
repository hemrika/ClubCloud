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
	public class duplicaterecord : BusinessEntity
	{
		private Lookup asyncoperationidField;

		private Lookup baserecordidField;

		private CrmDateTime createdonField;

		private Key duplicateidField;

		private Lookup duplicaterecordidField;

		private Lookup duplicateruleidField;

		private UniqueIdentifier owningbusinessunitField;

		private UniqueIdentifier owninguserField;

		[XmlElement] //[XmlElement(Order=0)]
		public Lookup asyncoperationid
		{
			get
			{
				return this.asyncoperationidField;
			}
			set
			{
				this.asyncoperationidField = value;
				base.RaisePropertyChanged("asyncoperationid");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public Lookup baserecordid
		{
			get
			{
				return this.baserecordidField;
			}
			set
			{
				this.baserecordidField = value;
				base.RaisePropertyChanged("baserecordid");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public CrmDateTime createdon
		{
			get
			{
				return this.createdonField;
			}
			set
			{
				this.createdonField = value;
				base.RaisePropertyChanged("createdon");
			}
		}

		[XmlElement] //[XmlElement(Order=3)]
		public Key duplicateid
		{
			get
			{
				return this.duplicateidField;
			}
			set
			{
				this.duplicateidField = value;
				base.RaisePropertyChanged("duplicateid");
			}
		}

		[XmlElement] //[XmlElement(Order=4)]
		public Lookup duplicaterecordid
		{
			get
			{
				return this.duplicaterecordidField;
			}
			set
			{
				this.duplicaterecordidField = value;
				base.RaisePropertyChanged("duplicaterecordid");
			}
		}

		[XmlElement] //[XmlElement(Order=5)]
		public Lookup duplicateruleid
		{
			get
			{
				return this.duplicateruleidField;
			}
			set
			{
				this.duplicateruleidField = value;
				base.RaisePropertyChanged("duplicateruleid");
			}
		}

		[XmlElement] //[XmlElement(Order=6)]
		public UniqueIdentifier owningbusinessunit
		{
			get
			{
				return this.owningbusinessunitField;
			}
			set
			{
				this.owningbusinessunitField = value;
				base.RaisePropertyChanged("owningbusinessunit");
			}
		}

		[XmlElement] //[XmlElement(Order=7)]
		public UniqueIdentifier owninguser
		{
			get
			{
				return this.owninguserField;
			}
			set
			{
				this.owninguserField = value;
				base.RaisePropertyChanged("owninguser");
			}
		}

		public duplicaterecord()
		{
		}
	}
}