using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controle_de_consultorio_odonto.Classes_de_entidades
{
    class Tratamento
    {        
        string laudo;
        string titulo;
        string paciente;
        private double precoIntegral;     

        public string Laudo
        {
            get
            {
                return this.laudo;
            }
            set
            {
                this.laudo = value;
            }
        }

        public string Titulo
        {
            get
            {
                return this.titulo;
            }
            set
            {
                this.titulo = value;
            }
        }

        public string Paciente
        {
            get
            {
                return this.paciente;
            }
            set
            {
                this.paciente = value;
            }
        }

    }
}
