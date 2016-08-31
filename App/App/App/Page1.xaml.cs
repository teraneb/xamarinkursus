using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App
{
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        public async void OnClickStackLayoutOpgave(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new CalculatorPage());
        }

        public async void OnClickGridlayoutOpgave(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new GridLayoutPage());
        }
    }
}
