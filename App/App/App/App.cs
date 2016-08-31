using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application

            var navigation = new NavigationPage();
            navigation.PushAsync(new Page1());
            MainPage = navigation;

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
