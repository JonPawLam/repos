using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBindingVM
{
    class Model : INotifyPropertyChanged
    {
        private string _name;


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public Model()
        {
            _name = "Det virker";
        }

        
        public string Name
        {
            get { return _name;}
            set { OnPropertyChanged ("Name");}
        }

        
        

    }
}
