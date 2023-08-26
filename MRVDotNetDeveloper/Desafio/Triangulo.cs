using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRVDotNetDeveloper.Desafio
{
    public class Triangulo
    {
        public void Resultado()
        {
            double a, b, c, perimetro, area;
            string[] valor = Console.ReadLine().Split();
            a = Convert.ToDouble(valor[0]);
            b = Convert.ToDouble(valor[1]);
            c = Convert.ToDouble(valor[2]);

            if (a + b > c && b + c > a && a + c > b)
            {
                // verifica se os valores formam um triângulo
                perimetro = a + b + c;
                Console.WriteLine($"Perimetro = {perimetro:F1}");
            }
            else
            {
                // se não forma um triângulo, calcula a área do trapézio
                area = ((a + b) * c) / 2.0;
                Console.WriteLine($"Area = {area:F1}");
            }
 
         }
    }
}
