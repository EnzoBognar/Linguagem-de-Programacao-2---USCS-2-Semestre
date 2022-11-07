using System;
using System.Net.Http.Headers;
using TabelaFuncionarios;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario[] funci = {
            new Funcionario("José", "1432559", 1500.4),
            new Funcionario("Enzo", "8123357", 1950.3),
            new Funcionario("Erick", "8732432", 2300.2),
            new Funcionario("Carlos", "3254331", 1300.5)
        };

            double Media = 1762.85;



           for(int i = 0; i < 4; i++)
            {
                if ((funci[i].getSalario()) > Media)
                {
                    Console.WriteLine(funci[i].getNome());
                    Console.WriteLine(funci[i].getMatricula());
                    Console.WriteLine("");
                }
            }
           



            Console.ReadKey();
            
        }
    }
}