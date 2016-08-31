using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App1
{
    public partial class MyXamlPage : ContentPage
    {
        public MyXamlPage()
        {
            InitializeComponent();           
        }

        private void MyButton_Clicked(object sender, EventArgs e)
        {
            yellowLabel.Text ="Jeg glemmer hele tiden...";
        }
    }
}
