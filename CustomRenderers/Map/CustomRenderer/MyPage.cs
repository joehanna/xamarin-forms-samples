using System;

using Xamarin.Forms;

namespace CustomRenderer
{
  public class MyPage : ContentPage
  {
    public MyPage()
    {
      Content = new StackLayout
      {
        Children = {
          new Label { Text = "Hello ContentPage" }
        }
      };
    }
  }
}


