using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroComplexo
{
    class Complexo
    {
        public double partereal { get; }
        public double parteimaginaria{ get; }
        public double modulo { get; }
        public double angulo { get; }
        public Complexo()
        {
            partereal = 0;
            parteimaginaria = 0;
        }
        public Complexo(double partereal, double parteimaginaria)
        {
            this.partereal = partereal;
            this.parteimaginaria = parteimaginaria;
            modulo = Convert.ToSingle(Math.Sqrt((parteimaginaria * parteimaginaria)+ (partereal * partereal)));
            if (parteimaginaria > 0)
            {
                angulo = ((Math.Acos(partereal/modulo))*180)/Math.PI;
            }
            else
            {
                angulo = (((Math.Acos(-partereal / modulo)) * 180) / Math.PI) + 180;
            }
        }
        public void exibe()
        {
            Console.WriteLine(" Numero real é "+ partereal +
                "\n Numero imaginario é "+ parteimaginaria +
                "\n O modulo é "+modulo+
                "\n O angulo é "+angulo);
        }
        public void exibeFormatado1()
        {
            Console.WriteLine(partereal + "+" +parteimaginaria+ "j");
        }
        public void exibeFormatado2()
        {
            Console.WriteLine("cos("+angulo+ ")+jsen(" + angulo + ")");
        }
        public void exibeFormatado3()
        {
            Console.WriteLine(modulo+"e^j"+angulo);
            
        }
        public void exibeconjugado()
        {
            if(parteimaginaria>0)
                Console.WriteLine(partereal + "-" + (parteimaginaria) + "j");
            else
                Console.WriteLine(partereal + "+" + (parteimaginaria*-1) + "j");
        }
    }           
}
