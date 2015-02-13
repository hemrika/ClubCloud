using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Model
{
    [Serializable]
    [DataContract(IsReference = true)]
    public abstract class BeheerBaseModel : INotifyPropertyChanged, IDataErrorInfo, INotifyDataErrorInfo
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        private Dictionary<string, string> _errors = new Dictionary<string, string>();

        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] String propertyName = null)
        {
            if (object.Equals(storage, value)) return false;

            try
            {
                storage = value;
                this.OnPropertyChanged(propertyName);
                return true;
            }
            catch (Exception ex)
            {
                _errors.Add(propertyName, ex.Message);
                return false;
            }
            
        }


        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var eventHandler = this.PropertyChanged;
            if (eventHandler != null)
            {
                eventHandler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public string Error
        {
            get
            {
                return string.Empty;
            }
        }

        public string this[string columnName]
        {
            get
            {
                if (_errors.ContainsKey(columnName))
                    return _errors[columnName];
                return string.Empty;
            }
        }

        

        public System.Collections.IEnumerable GetErrors(string propertyName)
        {
            return _errors[propertyName];
        }

        public bool HasErrors
        {
            get { return (_errors.Count > 0); }
        }
    }
}
