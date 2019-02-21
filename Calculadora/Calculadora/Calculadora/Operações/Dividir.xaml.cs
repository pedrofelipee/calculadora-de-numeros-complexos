using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Calculadora
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Dividir : ContentPage
	{
		public Dividir ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            var real1 = entry1.Text;
            var img1 = entry2.Text;
            var real2 = entry3.Text;
            var img2 = entry4.Text;


            var resultadoreal =(((Convert.ToDouble(real1) * Convert.ToDouble(real2)) + (Convert.ToDouble(img1) * Convert.ToDouble(img2)))/
                ((Convert.ToDouble(img2) * Convert.ToDouble(img2)) + (Convert.ToDouble(real2) * Convert.ToDouble(real2))));

            var resultadoimag = -1*(((Convert.ToDouble(real1) * Convert.ToDouble(img2)) - (Convert.ToDouble(img1) * Convert.ToDouble(real2))) /
                ((Convert.ToDouble(img2) * Convert.ToDouble(img2)) + (Convert.ToDouble(real2) * Convert.ToDouble(real2))));

            if (resultadoimag >= 0)
                label1.Text = "O resultado é: " + resultadoreal + "+" + resultadoimag + "i";
            else
                label1.Text = "O resultado é: " + resultadoreal + "" + resultadoimag + "i";
        }
    }
}