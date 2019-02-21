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
	public partial class Variasformatações : ContentPage
	{
		public Variasformatações ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            var partereal = entry1.Text;
            var parteimg = entry2.Text;

            double modulo = Convert.ToSingle(Math.Sqrt((Convert.ToDouble(parteimg) * Convert.ToDouble(parteimg)) + 
                (Convert.ToDouble(partereal) * Convert.ToDouble(partereal))));
            double angulo;

            if (Convert.ToDouble(parteimg) > 0)
                angulo = ((Math.Acos(Convert.ToDouble(partereal) / modulo)) * 180) / Math.PI;
            else
                angulo = (((Math.Acos(-Convert.ToDouble(partereal) / modulo)) * 180) / Math.PI) + 180;

            if (Convert.ToDouble(parteimg) >= 0)
                label1.Text = "Primeira formatação: " + Convert.ToDouble(partereal) + "+" + Convert.ToDouble(parteimg) + "i";
            else
                label1.Text = "Primeira formatação: " + Convert.ToDouble(partereal) + "" + Convert.ToDouble(parteimg) + "i";

            label2.Text = "Segunda formatação: cos(" + angulo + ")+jsen(" + angulo + ")";

            label3.Text = "terceira formatação: "+ modulo + "e^j" + angulo;

            if (Convert.ToDouble(parteimg) >= 0)
                label4.Text = "O conjugado é: " + Convert.ToDouble(partereal) + "-" + (Convert.ToDouble(parteimg)) + "i";
            else
                label4.Text = "O conjugado é: " + Convert.ToDouble(partereal) + "+" + ((Convert.ToDouble(parteimg)) *-1)+ "i";

            label5.Text = "O angulo é " + angulo;
        }
    }
}