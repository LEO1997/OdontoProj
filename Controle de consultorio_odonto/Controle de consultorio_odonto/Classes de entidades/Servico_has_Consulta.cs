using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controle_de_consultorio_odonto.Classes_de_entidades
{
    class Servico_has_Consulta
    {
        private string horaConsulta;
        private string descServ;

        public string HoraConsulta
        {
            get
            {
                return horaConsulta;
            }
            set
            {
                horaConsulta = value;
            }
        }

        //
        public string DescServico
        {
            get
            {
                return descServ;
            }
            set
            {
                descServ = value;
            }
        }
    }
}
