using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Appointments.DataProvider;
using Windows.UI.Xaml;

namespace SimpleBindingVM1
{
    class Model : INotifyPropertyChanged
    {
        private string _name;

        #region PropertyChangeSupport
        public event PropertyChangedEventHandler PropertyChanged;
        // Create the OnPropertyChanged method to raise the event
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            { handler(this, new PropertyChangedEventArgs(name)); }
        }
        #endregion
        
        public String Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(_name);
            }
        }
        
        public Model()
        {
            
            _name = "Det Virker!!! :D";
        }
    }
}