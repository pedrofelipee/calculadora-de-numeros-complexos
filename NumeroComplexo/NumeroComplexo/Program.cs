using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroComplexo
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2;
            int tipo;

            Console.WriteLine("     Valores para o Numero 1");
            Console.WriteLine("Escreva o valor real do numero");
            x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o valor imaginario do numero");
            x2 = double.Parse(Console.ReadLine());
            Complexo c1 = new Complexo(x1, x2);

            Console.WriteLine("\n\n     Valores para o Numero 2");
            Console.WriteLine("Escreva o valor real do numero");
            y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o valor imaginario do numero");
            y2 = double.Parse(Console.ReadLine());
            Complexo c2 = new Complexo(y1, y2);
            Calculadora conta = new Calculadora(x1, x2, y1, y2);

            do
            {
                Console.WriteLine("\n\n\n\nQual operação será realizada" +
                    "\n1-Soma:" +
                    "\n2-Subtração" +
                    "\n3-Divisão" +
                    "\n4-Multiplicação" +
                    "\n5-Retornar numeros na forma a+jb" +
                    "\n6-Retornar numeros na forma pe" +
                    "\n7-Retornar numeros na forma cos(x)+jsen(x)" +
                    "\n8-retorno dos seus conjulgados" +
                    "\n9-sair");
                tipo = int.Parse(Console.ReadLine());
                Console.WriteLine("\n\n\n\n\nResultado:");
                if(tipo==1)
                {
                    conta.soma();
                }
                else if (tipo == 2)
                {
                    conta.subtracao();
                }
                else if (tipo == 3)
                {
                    conta.divisao();
                }
                else if (tipo == 4)
                {
                    conta.multiplicacao();
                }
                else if (tipo == 5)
                {
                    c1.exibeFormatado1();
                    c2.exibeFormatado1();
                }
                else if (tipo == 7)
                {
                    c1.exibeFormatado2();
                    c2.exibeFormatado2();
                }
                else if (tipo == 6)
                {
                    c1.exibeFormatado3();
                    c2.exibeFormatado3();
                }
                else if (tipo == 8)
                {
                    c1.exibeconjugado();
                    c2.exibeconjugado();
                }
                else
                {
                    Console.WriteLine("Até a proxima :P");
                }
            } while (tipo != 9);
            Console.Read();
        }
    }
}