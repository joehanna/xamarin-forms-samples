using System;
using Xamarin.Forms;

namespace Native2Forms
{
  /// <summary>
  /// This Xamarin.Forms page will be opened from within a 'native' app on iOS and Android
  /// </summary>
  public class MySecondPage : ContentPage
  {
    public MySecondPage()
    {
      var label = new Label
      {
        Text = "This is the Xamarin.Forms page",
        Font = Font.SystemFontOfSize(36),
      };


      var grid = new Grid()
      {
        BackgroundColor = Color.Accent,
        RowDefinitions =
        {
          new RowDefinition { Height = GridLength.Auto },
          new RowDefinition { Height = GridLength.Auto },
          new RowDefinition { Height = GridLength.Auto }
        //},
        //ColumnDefinitions =
        //{
        //  new ColumnDefinition { Width = GridLength.Auto },
        //  new ColumnDefinition { Width = GridLength.Auto }
        }
      };

      var cell1 = new Entry()
      {
        Placeholder = "Enter your email address",
        Keyboard = Keyboard.Email
      };
      grid.Children.Add(cell1, 0, 2, 0, 1);

      var cell2 = new DatePicker()
      {
        BackgroundColor = Color.Yellow,
        Date = DateTime.Parse("1972-06-05")
      };
      grid.Children.Add(cell2, 1, 1);

      var cell3 = new Label()
      {
        Text = "lorem ipsum...",
        BackgroundColor = Color.Olive,
        TextColor = Color.White
      };
      grid.Children.Add(cell3, 0, 2);

      var cell4 = new Switch()
      {
        IsToggled = true
      };
      cell4.PropertyChanged += (object sender, System.ComponentModel.PropertyChangedEventArgs e) =>
      {
        if (e.PropertyName == "IsToggled")
        {
          var switchc = (Switch)sender;
          if (switchc.IsToggled)
          {
            cell3.Text = "Nuclear power ON";
            cell3.BackgroundColor = Color.Green;
          }
          else {
            cell3.Text = "We're out";
            cell3.BackgroundColor = Color.Gray;
          }
        }
      };
      grid.Children.Add(cell4, 1, 2);



      Content = new StackLayout
      {
        Spacing = 30,
        VerticalOptions = LayoutOptions.Start,
        Children = {
          label,
          grid
        }
      };
    }
  }
}
