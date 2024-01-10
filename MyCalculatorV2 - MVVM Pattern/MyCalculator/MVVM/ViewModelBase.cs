﻿
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MyCalculator.ViewModels
{
    internal class ViewModelBase:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
