using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
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
		public Lookup asyncoperationid
		{
			get
			{
				return this.asyncoperationidField;
			}
			set
			{
				this.asyncoperationidField = value;
			}
		}
		public Lookup baserecordid
		{
			get
			{
				return this.baserecordidField;
			}
			set
			{
				this.baserecordidField = value;
			}
		}
		public CrmDateTime createdon
		{
			get
			{
				return this.createdonField;
			}
			set
			{
				this.createdonField = value;
			}
		}
		public Key duplicateid
		{
			get
			{
				return this.duplicateidField;
			}
			set
			{
				this.duplicateidField = value;
			}
		}
		public Lookup duplicaterecordid
		{
			get
			{
				return this.duplicaterecordidField;
			}
			set
			{
				this.duplicaterecordidField = value;
			}
		}
		public Lookup duplicateruleid
		{
			get
			{
				return this.duplicateruleidField;
			}
			set
			{
				this.duplicateruleidField = value;
			}
		}
		public UniqueIdentifier owningbusinessunit
		{
			get
			{
				return this.owningbusinessunitField;
			}
			set
			{
				this.owningbusinessunitField = value;
			}
		}
		public UniqueIdentifier owninguser
		{
			get
			{
				return this.owninguserField;
			}
			set
			{
				this.owninguserField = value;
			}
		}
	}
}
