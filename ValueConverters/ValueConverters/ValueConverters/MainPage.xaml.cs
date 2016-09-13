using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ValueConverters
{
    public partial class MainPage : ContentPage
    {
        private DateTime someDate = DateTime.Now;
        private DateValueConverter myValueConverter = new DateValueConverter();



        public DateTime SomeDate
        {
            get
            {
                return someDate;
            }
            set
            {
                someDate = value;
            }
        }

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
            MyLabel.SetBinding(Label.TextProperty, "SomeDate", BindingMode.OneWay, myValueConverter);            
        }
    }
}
