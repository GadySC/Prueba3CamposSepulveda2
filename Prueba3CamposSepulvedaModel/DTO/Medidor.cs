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
        private int tipo;


        public Medidor() { 
        
        }

        public Medidor(string num_medidor)
        {
            this.Num_Medidor = num_medidor;
        }

        public Medidor(string num_medidor, int tipo)
        {

            this.num_medidor = num_medidor;
            this.tipo = tipo;
        }
        public string TipoTxt
        {
            get
            {
                string tipoTxt = "";
                switch (tipo)
                {
                    case 1:
                        tipoTxt = "Electronico";
                        break;
                    case 2:
                        tipoTxt = "Mecanico";
                        break;
                }
                return tipoTxt;
            }
        }

        public string Num_Medidor { get => num_medidor; set => num_medidor = value; }
        public int Tipo { get => tipo; set => tipo = value; }
    }
}
