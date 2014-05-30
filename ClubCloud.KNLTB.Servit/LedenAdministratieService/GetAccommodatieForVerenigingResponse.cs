using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.LedenAdministratieService
{
	[DataContract(Name="GetAccommodatieForVerenigingResponse", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class GetAccommodatieForVerenigingResponse : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		private string AccommodatieNaamField;

		private Adres BezoekAdresField;

		private string MinibanenField;

		private string OefenmurenField;

		private string OndergrondField;

		private string PlaygroundsField;

		private Adres PostAdresField;

		private string SpeeltoestellenField;

		private string TelefoonNummerField;

		private string TenniskidshuisstijlField;

		[DataMember(IsRequired=true)]
		public string AccommodatieNaam
		{
			get
			{
				return this.AccommodatieNaamField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AccommodatieNaamField, value))
				{
					this.AccommodatieNaamField = value;
					this.RaisePropertyChanged("AccommodatieNaam");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public Adres BezoekAdres
		{
			get
			{
				return this.BezoekAdresField;
			}
			set
			{
				if (!object.ReferenceEquals(this.BezoekAdresField, value))
				{
					this.BezoekAdresField = value;
					this.RaisePropertyChanged("BezoekAdres");
				}
			}
		}

		[Browsable(false)]
		public ExtensionDataObject ExtensionData
		{
			get
			{
				return this.extensionDataField;
			}
			set
			{
				this.extensionDataField = value;
			}
		}

		[DataMember(IsRequired=true)]
		public string Minibanen
		{
			get
			{
				return this.MinibanenField;
			}
			set
			{
				if (!object.ReferenceEquals(this.MinibanenField, value))
				{
					this.MinibanenField = value;
					this.RaisePropertyChanged("Minibanen");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Oefenmuren
		{
			get
			{
				return this.OefenmurenField;
			}
			set
			{
				if (!object.ReferenceEquals(this.OefenmurenField, value))
				{
					this.OefenmurenField = value;
					this.RaisePropertyChanged("Oefenmuren");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Ondergrond
		{
			get
			{
				return this.OndergrondField;
			}
			set
			{
				if (!object.ReferenceEquals(this.OndergrondField, value))
				{
					this.OndergrondField = value;
					this.RaisePropertyChanged("Ondergrond");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Playgrounds
		{
			get
			{
				return this.PlaygroundsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PlaygroundsField, value))
				{
					this.PlaygroundsField = value;
					this.RaisePropertyChanged("Playgrounds");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public Adres PostAdres
		{
			get
			{
				return this.PostAdresField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PostAdresField, value))
				{
					this.PostAdresField = value;
					this.RaisePropertyChanged("PostAdres");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Speeltoestellen
		{
			get
			{
				return this.SpeeltoestellenField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SpeeltoestellenField, value))
				{
					this.SpeeltoestellenField = value;
					this.RaisePropertyChanged("Speeltoestellen");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string TelefoonNummer
		{
			get
			{
				return this.TelefoonNummerField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TelefoonNummerField, value))
				{
					this.TelefoonNummerField = value;
					this.RaisePropertyChanged("TelefoonNummer");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Tenniskidshuisstijl
		{
			get
			{
				return this.TenniskidshuisstijlField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TenniskidshuisstijlField, value))
				{
					this.TenniskidshuisstijlField = value;
					this.RaisePropertyChanged("Tenniskidshuisstijl");
				}
			}
		}

		public GetAccommodatieForVerenigingResponse()
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