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
        private string fecha;
        private string hora;
        private double consumo=0;
        private double total_consumo=0;

        public Lectura() { 
        
        }
        public Lectura(Medidor medidor, string fecha, string hora, double consumo, double total_consumo)
        {
            this.medidor = medidor;
            this.fecha = fecha;
            this.hora = hora;
            this.consumo = 0;
            this.total_consumo = 0;
        }

        public Medidor Medidor { get => medidor; set => medidor = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Hora { get => hora; set => hora = value; }
        public double Consumo { get => consumo; set => consumo = value; }
        public double Total_consumo { get => total_consumo; set => total_consumo = value; }
    }

}
