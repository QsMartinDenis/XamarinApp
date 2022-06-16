using FrsApp.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using FrsApp.Models;
using System.Runtime.CompilerServices;
using FrsApp.Services;
using Xamarin.Forms;

namespace FrsApp.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public IDataStore<User> DataStore => DependencyService.Get<IDataStore<User>>();

        protected bool SetProperty<T>(ref T backingStore, T value,
            [CallerMemberName] string propertyName = "",
            Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            RaisePropertyChanged(propertyName);

            return true;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
