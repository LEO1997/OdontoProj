using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controle_de_consultorio_odonto.Classes_de_entidades
{
    class Paciente
    {
        private string cpf;
        private string nome;
        private string nascimento;
        private string endereco;
        private string telefone;

        public string Cpf
        {
            get
            {
                return cpf;
            }
            set
            {
                cpf = value;
            }
        }

        //
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

        //
        public string Nascimento
        {
            get
            {
                return nascimento;
            }
            set
            {
                nascimento = value;
            }
        }

        //
        public string Endereco
        {
            get
            {
                return endereco;
            }
            set
            {
                endereco = value;
            }
        }

        //
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
