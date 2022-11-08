using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace AT5
{
    public class Funcionario
    {
        private string nome;
        private int matricula;
        private string cpf;
        public string getNome()
        {
            return this.nome;
        }
        public int getMatricula()
        {
            return this.matricula;
        }
        public string getcpf()
        {
            return this.cpf;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public void setMatricula(int matricula)
        {
            this.matricula = matricula;
        }
        public void setMatricula(string cpf)
        {

            this.cpf = cpf;
        }
        public Funcionario(string nome, int matricula, string cpf)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.cpf = cpf;
        }
        public Funcionario()
        {
        }
        public Funcionario(string nome)
        {
            this.nome = nome;
        }
        public void imprimeFuncionario()
        {
            Console.WriteLine(this.nome + "" + this.matricula + "" + this.cpf);
        }
    }
}