using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace TabelaFuncionarios
{

    public class Funcionario
    {
        private string Nome;
        private string Matricula;
        private double Salario;

        public Funcionario(string Nome, string Matricula, double Salario)
        {
            this.Nome = Nome;
            this.Matricula = Matricula;
            this.Salario = Salario;

        }


        public string getNome()
        {
            return this.Nome;
        }
        public string getMatricula()
        {
            return this.Matricula;
        }
        public double getSalario()
        {
            return this.Salario;
        }


        public void setNome(string Nome)
        {
            this.Nome = Nome;
        }
        public void setMatricula(string Matricula)
        {
            this.Matricula = Matricula;
        }
        public void setSalario(double Salario)
        {
            this.Salario = Salario;
        }

        
        
    }
}
