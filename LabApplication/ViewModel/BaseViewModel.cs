using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LabApplication.ViewModel
{
    /// <summary>
    /// Реализация интерфейса INotifyPropertyChanged.
    /// </summary>
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        // Стандартная реализация
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // Расширеная реализация, для упрощения работы со свойствами.
        protected virtual bool SetPropertyChanged<T>(ref T source, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(source, value))
                return false;
            source = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}