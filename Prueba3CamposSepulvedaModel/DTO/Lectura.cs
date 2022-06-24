using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba3CamposSepulvedaModel.DTO
{
    public class Lectura
    {
        private Medidor medidor;
        private DateTime fecha;
        private double consumo;
   

        public Lectura() { 
        
        }

        public Lectura(Medidor medidor, DateTime fecha, double consumo)
        {

            this.Medidor = medidor;
            this.Fecha = fecha;
            this.Consumo = consumo;
  
        }

        public Medidor Medidor { get => medidor; set => medidor = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public double Consumo { get => consumo; set => consumo = value; }
    }

}
