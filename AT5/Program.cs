using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace AT5
{
    class Program
    {
        static void Main(string[] args)
        {
            Departamento vendas = new Departamento();
            vendas.nome = "vendas";
            vendas.adicionaFuncionario("maria", 123, "6765657");
            vendas.adicionaFuncionario("pedro", 789, "2213438");
            vendas.imprimeDepartamento();
        }
    }
}