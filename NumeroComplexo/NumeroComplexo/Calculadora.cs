using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroComplexo
{
    class Calculadora
    {
        public double real1;
        public double real2;
        public double img1;
        public double img2;
        public Calculadora(double real1, double real2, double img1,double img2)
        {
            this.real1 = real1;
            this.real2 = real2;
            this.img1 = img1;
            this.img2 = img2;
        }
        public void soma()
        {
            if((img1+img2)>=0)
                Console.WriteLine((real1+real2) + "+" + (real1+real2) + "j");
            else
                Console.WriteLine((real1 + real2) + "" + (real1 + real2) + "j");
        }
        public void subtracao()
        {
            if((img1-img2)>=0)
                Console.WriteLine((real1 - real2) + "+" + (img1 - img2) + "j");
            else
                Console.WriteLine((real1 - real2) + "" + (img1 - img2) + "j");
        }
        public void divisao()
        {
            double resultadopartereal, resultadoparteimaginaria;

            resultadopartereal = (((real1 * real2) + (img1 * img2))
                        / ((img2 * img2) + (real2 * real2)));
            resultadoparteimaginaria = (((real1 * img2) - (img1 * real2))
                        / ((img2 * img2) + (real2 * real2)));

            if (resultadoparteimaginaria >= 0)
                Console.WriteLine(resultadopartereal + "+" + resultadoparteimaginaria + "j");
            else
                Console.WriteLine(resultadopartereal + "" + resultadoparteimaginaria + "j");
        }
        public void multiplicacao()
        {
            double resultadopartereal, resultadoparteimaginaria;

            resultadopartereal = ((real1 * real2) - (img1 * img2));
            resultadoparteimaginaria = ((real1 * img2) + (img1 * real2));

            if (resultadoparteimaginaria >= 0)
                Console.WriteLine(resultadopartereal + "+" + resultadoparteimaginaria + "j");
            else
                Console.WriteLine(resultadopartereal + "" + resultadoparteimaginaria + "j");
        }
    }
}