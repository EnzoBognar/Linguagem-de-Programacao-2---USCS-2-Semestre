using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Trabalho_4
{
    class Aluno
    {
        private string nome;
        private int matricula;
        private string email;
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
        public string Email
        {
            set
            {

                email = value;
            }
            get
            {
                return email;
            }
        }
        public Aluno()
        {
        }
        public Aluno(string nome)
        {
            this.nome = nome;
        }
        public Aluno(string nome, int matricula, string email)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.email = email;
        }
        public void imprimir()
        {
            Console.WriteLine(this.nome + " " + this.matricula + " " + this.email);
        }
    }

}