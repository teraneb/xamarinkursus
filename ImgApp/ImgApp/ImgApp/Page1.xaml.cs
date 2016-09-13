using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ImgApp
{
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();

            var beachImage = new Image { Aspect = Aspect.AspectFit };
            beachImage.Source = ImageSource.FromFile("waterfront.jpg");
        }

    }
}
