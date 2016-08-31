using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace App1
{
    public class MyBasicUI : ContentPage
    {
        public MyBasicUI()
        {
            var red = new Label
            {
                Text = "Stop",
                BackgroundColor = Color.Red,
                FontSize = 20
            };

            var yellow = new Label
            {
                Text = "Slow down",
                BackgroundColor = Color.Yellow,
                FontSize = 20
            };

            var green = new Label
            {
                Text = "Go",
                BackgroundColor = Color.Green,
                FontSize = 20
            };

            Content = new StackLayout
            {
                Spacing = 10,
                Children = { red, yellow, green }
            };
        }
    }
}
