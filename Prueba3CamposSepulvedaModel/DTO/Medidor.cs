using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba3CamposSepulvedaModel.DTO
{
    public class Medidor
    {
        private string num_medidor;
        private string tipo;

        public Medidor(string num_medidor, string tipo)
        {

            this.num_medidor = num_medidor;
            this.tipo = tipo;
        }
        
        public string Num_Medidor { get => num_medidor; set => num_medidor = value; }
        public string Tipo { get => tipo; set => tipo = value; }
    }
}
