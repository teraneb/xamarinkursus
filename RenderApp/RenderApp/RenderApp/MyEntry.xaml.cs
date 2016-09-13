using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MyEntry
{
    public partial class MyEntry : ContentPage
    {
        public MyEntry()
        {
            InitializeComponent();
        }
    }
}

public class MainPage : ContentPage
{
    public MainPage()
    {
        Content = new StackLayout
        {
            Children = {
        new Label {
          Text = "Hello, Custom Renderer !",
        },
        new MyEntry {
          Text = "In Shared Code",
        }
      },
            VerticalOptions = LayoutOptions.CenterAndExpand,
            HorizontalOptions = LayoutOptions.CenterAndExpand,
        };
    }
}