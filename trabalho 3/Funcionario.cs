using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_3
{
    class Funcionario
    {
        private string nome;
        private int matricula;
        private double salario;

        public Funcionario(string nome, int matricula, double salario)
        {
            this.Nome = nome;
            this.Matricula = matricula;
            this.Salario = salario;

        }

        public Funcionario()
        {

        }

        public Funcionario(string nome)
        {
            this.nome = nome;
        }


        public string Nome
        {
            set
            {
                nome = value;
            }
            get
            {
                return nome;
            }

        }

        public int Matricula
        {
            set
            {
                matricula = value;
            }
            get
            {
                return matricula;
            }
        }

        public double Salario
        {
            set
            {
                salario = value;
            }
            get
            {
                return salario;
            }   
        }
    }
}
