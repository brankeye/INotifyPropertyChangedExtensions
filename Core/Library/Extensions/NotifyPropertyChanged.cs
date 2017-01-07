using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace inpce.core.Library.Extensions
{
    public static class NotifyPropertyChanged
    {
        /// <summary>
        /// Invokes PropertyChanged event if the property value has changed.
        /// </summary>
        public static bool SetProperty<T>(
            this INotifyPropertyChanged notifier,
            ref T backingStore, 
            T value,
            PropertyChangedEventHandler handler,
            [CallerMemberName]string propertyName = "",
            Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;
            return SetPropertyAlways(notifier, ref backingStore, value, handler, propertyName);
        }

        /// <summary>
        /// Invokes PropertyChanged event always (even if the property value has not changed).
        /// </summary>
        public static bool SetPropertyAlways<T>(
            this INotifyPropertyChanged notifier,
            ref T backingStore,
            T value,
            PropertyChangedEventHandler handler,
            [CallerMemberName]string propertyName = "",
            Action onChanged = null)
        {
            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(notifier, handler, propertyName);
            return true;
        }

        /// <summary>
        /// Invokes PropertyChanged event on the given property name.
        /// </summary>
        public static void OnPropertyChanged(this INotifyPropertyChanged notifier, PropertyChangedEventHandler propertyChanged, [CallerMemberName] string propertyName = @"")
        {
            propertyChanged?.Invoke(notifier, new PropertyChangedEventArgs(propertyName));
        }
    }
}
