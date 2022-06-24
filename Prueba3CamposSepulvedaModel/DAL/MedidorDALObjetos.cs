using Prueba3CamposSepulvedaModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba3CamposSepulvedaModel.DAL
{
    public class MedidorDALObjetos : IMedidorDAL
    {
        private static List<Medidor> medidores = new List<Medidor>();
        public void AgregarMedidor(Medidor medidor)
        {
            medidores.Add(medidor);

        }
   

        public List<Medidor> FiltrarMedidores(int tipo)
        {
            return medidores.FindAll(c => c.Tipo == tipo);
        }

        public List<Medidor> FiltrarValidacion(string num_medidor)
        {
 

            return medidores.FindAll(c => c.Num_Medidor == num_medidor);
        }

        public List<Medidor> ObtenerMedidores()
        {
            return medidores;
        }
        
    }
}
