using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ContentPageLearning
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            SubmitButton.Clicked += SubmitButton_Clicked;

        }

        private void SubmitButton_Clicked(object sender, EventArgs e)
        {
            LblMessage.Text = "Hi " + txtName.Text;
            LblMessage.FontSize = 24;
            LblMessage.TextColor = Color.Blue;
        }
    }
}
