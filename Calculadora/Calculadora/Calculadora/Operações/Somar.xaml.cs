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
	public partial class Somar : ContentPage
	{
		public Somar ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            var x1 = entry1.Text;
            var x2 = entry2.Text;
            var y1 = entry3.Text;
            var y2 = entry4.Text;

            var resultadoreal = Convert.ToDouble(x1) +Convert.ToDouble(y1);
            var resultadoimag = Convert.ToDouble(x2) + Convert.ToDouble(y2);

            if(resultadoimag>0)
                label1.Text = "O resultado é " + resultadoreal + "+" + resultadoimag + "i";
            else
                label1.Text = "O resultado é " + resultadoreal + "" + resultadoimag + "i";
        }
    }
}