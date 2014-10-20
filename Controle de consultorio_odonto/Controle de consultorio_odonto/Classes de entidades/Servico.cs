using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controle_de_consultorio_odonto.Classes_de_entidades
{
    class Servico
    {
        private int codigo;
        private string descricao;
        private double preco;

        public int Codigo
        {
            get
            {
                return codigo;
            }
            set
            {
                codigo = value;
            }
        }

        //
        public string Descricao
        {
            get
            {
                return descricao;
            }
            set
            {
                descricao = value;
            }
        }

        //
        public double Preco
        {
            get
            {
                return preco;
            }
            set
            {
                preco = value;
            }
        }
    }
}
