using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controle_de_consultorio_odonto.Classes_de_entidades
{
    class Consulta
    {
        private int codigo;
        private string dtahora;
        private int sala;
        private string pac;
        private string prof;
        private string serv;

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
        public string Dtahora
        {
            get
            {
                return dtahora;
            }
            set
            {
                dtahora = value;
            }
        }

        //
        public int Sala
        {
            get
            {
                return sala;
            }
            set
            {
                sala = value;
            }
        }

        //
        public string Pac
        {
            get
            {
                return pac;
            }
            set
            {
                pac = value;
            }
        }

        //
        public string Prof
        {
            get
            {
                return prof;
            }
            set
            {
                prof = value;
            }
        }

        //
        public string Serv
        {
            get
            {
                return serv;
            }
            set
            {
                serv = value;
            }
        }
    }
}
