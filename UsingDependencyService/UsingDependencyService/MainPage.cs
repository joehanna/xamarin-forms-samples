using System;
using System.Collections.Generic;
using UsingDependencyService;
using Xamarin.Forms;

namespace UsingDependencyService
{
  public class MainPage : ContentPage
  {
    public MainPage()
    {
      var cars = new List<Car>();
      cars.Add(new Car("Toyota", "Corolla", 4));
      cars.Add(new Car("Toyota", "Kluguer", 5));
      cars.Add(new Car("Toyota", "86", 2));
      cars.Add(new Car("Ford", "Ranger", 2));
      cars.Add(new Car("Ford", "Ranger WildPak", 4));
      cars.Add(new Car("Ford", "Mustang", 2));


      var speak = new Button
      {
        Text = "Hello, Forms !",
        VerticalOptions = LayoutOptions.CenterAndExpand,
        HorizontalOptions = LayoutOptions.CenterAndExpand,
      };
      speak.Clicked += (sender, e) =>
      {
        //DependencyService.Get<ITextToSpeech>().Speak("Hello from Xamarin Forms");

        var json = DependencyService.Get<IJSONSerialise>().Serialise(cars);

        System.Diagnostics.Debug.WriteLine("_______________________________");
        System.Diagnostics.Debug.WriteLine(json);
        System.Diagnostics.Debug.WriteLine("_______________________________");

        var xobj = DependencyService.Get<IJSONSerialise>().Deserialise(json);

        if (xobj != null)
        {
          System.Diagnostics.Debug.WriteLine("Deserialisation worked");
        }

      };
      Content = speak;
    }
  }
}

