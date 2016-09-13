using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ImgApp
{
    public partial class LabelPage : ContentPage
    {
        public LabelPage()
        {
            InitializeComponent();
            someStackLayout.Children.Add(new TeraneVeiw());

        }
    }
}
