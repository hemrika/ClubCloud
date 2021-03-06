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
	public class bulkdeletefailure : BusinessEntity
	{
		private Lookup asyncoperationidField;

		private Key bulkdeletefailureidField;

		private Lookup bulkdeleteoperationidField;

		private string errordescriptionField;

		private CrmNumber errornumberField;

		private CrmNumber orderedqueryindexField;

		private UniqueIdentifier owningbusinessunitField;

		private UniqueIdentifier owninguserField;

		private Lookup regardingobjectidField;

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
		public Key bulkdeletefailureid
		{
			get
			{
				return this.bulkdeletefailureidField;
			}
			set
			{
				this.bulkdeletefailureidField = value;
				base.RaisePropertyChanged("bulkdeletefailureid");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public Lookup bulkdeleteoperationid
		{
			get
			{
				return this.bulkdeleteoperationidField;
			}
			set
			{
				this.bulkdeleteoperationidField = value;
				base.RaisePropertyChanged("bulkdeleteoperationid");
			}
		}

		[XmlElement] //[XmlElement(Order=3)]
		public string errordescription
		{
			get
			{
				return this.errordescriptionField;
			}
			set
			{
				this.errordescriptionField = value;
				base.RaisePropertyChanged("errordescription");
			}
		}

		[XmlElement] //[XmlElement(Order=4)]
		public CrmNumber errornumber
		{
			get
			{
				return this.errornumberField;
			}
			set
			{
				this.errornumberField = value;
				base.RaisePropertyChanged("errornumber");
			}
		}

		[XmlElement] //[XmlElement(Order=5)]
		public CrmNumber orderedqueryindex
		{
			get
			{
				return this.orderedqueryindexField;
			}
			set
			{
				this.orderedqueryindexField = value;
				base.RaisePropertyChanged("orderedqueryindex");
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

		[XmlElement] //[XmlElement(Order=8)]
		public Lookup regardingobjectid
		{
			get
			{
				return this.regardingobjectidField;
			}
			set
			{
				this.regardingobjectidField = value;
				base.RaisePropertyChanged("regardingobjectid");
			}
		}

		public bulkdeletefailure()
		{
		}
	}
}