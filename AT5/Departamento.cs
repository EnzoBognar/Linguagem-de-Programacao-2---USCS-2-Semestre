using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace AT5
{
    public class Departamento
    {
        public string nome;
        ArrayList funcionario = new ArrayList();
        public void adicionaFuncionario(string nome, int matricula, string cpf)
        {
            Funcionario f = new Funcionario(nome, matricula, cpf);
            this.funcionario.Add(f);
        }
        public void imprimeDepartamento()
        {

            foreach (Funcionario f in funcionario)
            {
                f.imprimeFuncionario();
            }
        }

    }
}