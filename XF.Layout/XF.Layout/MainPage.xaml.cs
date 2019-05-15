using Android.Content.Res;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF.Layout
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void ButtonStackClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.StackLayoutPage());
        }

        private void ButtonAbsoluteClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.AbsoluteLayoutPage());
        }

        private void ButtonRelativeClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.RelativeLayoutPage());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.Grid());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.Calculadora());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.FLEXLAYOUT());
        }
    }
}
