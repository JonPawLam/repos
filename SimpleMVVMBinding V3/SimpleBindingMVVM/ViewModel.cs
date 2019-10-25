using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using SimpleBindingMVVM.Annotations;

namespace SimpleBindingMVVM
{
    class ViewModel : INotifyPropertyChanged
    {
        //feels
        private ObservableCollection<Model> _models;
        public event PropertyChangedEventHandler PropertyChanged;

        //Construktor

        public ViewModel()
        {
            ObservableCollection<Model> overObservableCollection = new ObservableCollection<Model>();
        }
        
        //Metoder

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        

        public ObservableCollection<Model> Models
        {
            get { return  _models;}
            set { _models = value;}
        }


    }
}
