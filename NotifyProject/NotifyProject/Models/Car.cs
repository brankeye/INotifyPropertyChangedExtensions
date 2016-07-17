using System.ComponentModel;
using NotifyProject.Extensions;

namespace NotifyProject.Models
{
    public class Car : INotifyPropertyChanged
    {
        public string Name
        {
            get { return _name; }
            set { this.SetProperty(ref _name, value, PropertyChanged); }
        }
        private string _name;

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
