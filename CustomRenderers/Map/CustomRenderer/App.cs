﻿using Xamarin.Forms;

namespace CustomRenderer
{
  public class App : Application
  {
    public static double ScreenHeight;
    public static double ScreenWidth;

    public App()
    {
      MainPage = new NavigationPage(new MapPage());

    }

    protected override void OnStart()
    {
      // Handle when your app starts
    }

    protected override void OnSleep()
    {
      // Handle when your app sleeps
    }

    protected override void OnResume()
    {
      // Handle when your app resumes
    }
  }
}

