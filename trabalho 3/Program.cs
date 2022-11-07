using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using trabalho_3;

namespace trabalho_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            double soma = 0;
            
            Funcionario[] funci = {new Funcionario("Enzo", 143234, 2543.32),
            new Funcionario("Carlos", 143243, 2764.76),
            new Funcionario("Erick", 324534, 2349.54),
            new Funcionario("Denise", 945326, 2951.43)
            };

            for(i = 0; i < 4; i++)
            {
                soma = soma + funci[i].Salario;
            }

            double media = soma / i;

            for (i = 0; i < 4; i++)
            {
                if (funci[i].Salario > media)
                {
                    Console.WriteLine(funci[i].Nome + " " + funci[i].Matricula);
                    Console.WriteLine("");
                }
            }
        }
    }
}
