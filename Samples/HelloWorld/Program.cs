using System;
using System.ComponentModel;

namespace inpce.samples.helloworld.App
{
    public class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Models.Person
            {
                Name = "Jim"
            };
            Console.WriteLine("Name is " + person1.Name + ".");
            LogPropertyChanged(person1);
            person1.Name = "Bob";

            Console.ReadLine();
        }

        public static void LogPropertyChanged<T>(T model)
            where T : class, INotifyPropertyChanged
        {
            model.PropertyChanged += (sender, eventArgs) =>
            {
                var currentModel = (T)sender;
                var propertyValue = currentModel.GetType().GetProperty(eventArgs.PropertyName).GetValue(currentModel);
                Console.WriteLine(eventArgs.PropertyName + " has changed to " + propertyValue + ".");
            };
        }
    }
}
