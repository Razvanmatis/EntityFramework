using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EntityFramework.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void SetValue<T>(ref T source, T target, string name)
        {
            source = target;
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
