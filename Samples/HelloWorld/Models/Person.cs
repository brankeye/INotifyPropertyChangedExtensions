using System.ComponentModel;
using inpce.core.Library.Extensions;

namespace inpce.samples.helloworld.App.Models
{
    public class Person : INotifyPropertyChanged
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
