using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ImgApp
{
    public partial class TeraneVeiw : StackLayout
    {
        //public static BindableProperty FirstNameProperty = BindableProperty.Create();

        public TeraneVeiw()
        {
            InitializeComponent();
            firstName.Text = "Terane";
            lastName.Text = "Bananijarskaja";
        }
    }
}
