using System;
using System.ComponentModel;
using Xamarin.Forms;
using NotifyProject.Extensions;

namespace NotifyProject.ViewModels.Pages
{
    public class Main
    {
        public Main()
        {
            CarModel = new Models.Car
            {
                Name = "Audi"
            };

            Device.StartTimer(TimeSpan.FromSeconds(5), () =>
            {
                CarModel.Name = "BMW";
                return false;
            });
        }

        public Models.Car CarModel { get; set; }
    }
}
