using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace WeatherApp
{
    public partial class WeatherPage : ContentPage
    {
        public WeatherPage()
        {
          
            WeatherPage weatherPage;
            Color myColor = Color.FromRgba(255, 255, 255, 0.2);

        {
            this.weatherViewModel = weatherViewModel;
            BindingContext = weatherViewModel;
            InitializeComponent();
            MyLabel.BackgroundColor = this.myColor;
            
        }

    }
}
