using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace NotifyProject.Views.Pages
{
    public partial class Main : ContentPage
    {
        public ViewModels.Pages.Main ViewModel => _vm ?? (_vm = BindingContext as ViewModels.Pages.Main);
        private ViewModels.Pages.Main _vm;

        public Main()
        {
            InitializeComponent();
            BindingContext = new ViewModels.Pages.Main();
        }
    }
}
