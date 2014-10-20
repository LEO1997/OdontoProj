using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controle_de_consultorio_odonto.Classes_de_entidades
{
    class Profissional
    {
        private string cro;
        private string nome;
        private string telefone;
        private string especializacao;

        public string Cro
        {
            get
            {
                return cro;
            }
            set
            {
                cro = value;
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

        //
        public string Especializacao
        {
            get
            {
                return especializacao;
            }
            set
            {
                especializacao = value;
            }
        }
    }
}
