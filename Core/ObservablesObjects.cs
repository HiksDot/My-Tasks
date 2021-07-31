using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace My_Tasks.Core
{
    class ObservablesObjects : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
