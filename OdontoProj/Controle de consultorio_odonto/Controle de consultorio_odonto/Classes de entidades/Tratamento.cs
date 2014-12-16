using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controle_de_consultorio_odonto.Classes_de_entidades
{
    class Tratamento
    {
        int codigo;
        string laudo;
        string title;
        private double precoIntegral;

        public Tratamento(String ld)
        {
            this.laudo = ld;
        }

        public string Title
        {
            get
            {
                return this.Title;
            }
            set
            {
                this.Title = value;
            }
        }

    }
}
