using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ImgApp
{
    public partial class FarverPage : ContentPage
    {
        public FarverPage()
        {
            InitializeComponent();

            var red = new Label { Text = "Red", BackgroundColor = Color.Red };
            var orange = new Label { Text = "Orange", BackgroundColor = Color.FromHex("FF6A00") };
            var yellow = new Label { Text = "Yellow", BackgroundColor = Color.FromHsla(0.167, 1.0, 0.5, 1.0) };
            var green = new Label { Text = "Green", BackgroundColor = Color.FromRgb(38, 127, 0) };
            var blue = new Label { Text = "Blue", BackgroundColor = Color.FromRgba(0, 38, 255, 255) };
            var indigo = new Label { Text = "Indigo", BackgroundColor = Color.FromRgb(0, 72, 255) };
            var violet = new Label { Text = "Violet", BackgroundColor = Color.FromHsla(0.82, 1, 0.25, 1) };

            var transparent = new Label { Text = "Transparent", BackgroundColor = Color.Transparent };
            var @default = new Label { Text = "Default", BackgroundColor = Color.Default };
            var accent = new Label { Text = "Accent", BackgroundColor = Color.Accent };
        }
    }
}
