using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidade
{
    class Aluno
    {
        private string nome;
        private string turma;
        private string modalidade;
        private string email;
        private string telefone;

        public string Nome
        {
            get 
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }

        public String Turma
        {
            get
            {
                return turma;
            }
            set
            {
                turma = value;
            }
        }

        public string Modalidade
        {
            get
            {
                return modalidade;
            }
            set
            {
                modalidade = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public string Telefone
        {
            get
            {
                return telefone;
            }
            set 
            {
                telefone = value;
            }
        }

    }
}
