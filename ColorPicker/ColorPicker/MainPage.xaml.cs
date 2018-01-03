using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

// This is a practice app to get started with Xamarin and using LivePlayer
//    following steps as described at https://aka.ms/get-started for the contest
//    as detailed in this blog post https://blog.xamarin.com/contest-get-started-xamarin/
//    This app was done as a bonus to above contest and won the contest.

namespace ColorPicker
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            sliderRed.Value = 127;
            sliderGreen.Value = 127;
            sliderBlue.Value = 127;
		}

        private void sliderRed_ValueChanged(Object sender, EventArgs e)
        {
            Slider red = (Slider)sender;

            lblRedValue.Text = Convert.ToInt16(red.Value).ToString();
            SetSelectedColor();
        }

        private void sliderGreen_ValueChanged(Object sender, EventArgs e)
        {
            Slider Green = (Slider)sender;

            lblGreenValue.Text = Convert.ToInt16(Green.Value).ToString();
            SetSelectedColor();
        }

        private void sliderBlue_ValueChanged(Object sender, EventArgs e)
        {
            Slider Blue = (Slider)sender;

            lblBlueValue.Text = Convert.ToInt16(Blue.Value).ToString();
            SetSelectedColor();
        }

        private void SetSelectedColor()
        {
            lblSelectedColor.BackgroundColor
                = Color.FromRgb(Convert.ToInt16(sliderRed.Value)
                , Convert.ToInt16(sliderGreen.Value)
                , Convert.ToInt16(sliderBlue.Value));
        }

    }
}
