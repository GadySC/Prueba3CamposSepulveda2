using Prueba3CamposSepulvedaModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba3CamposSepulvedaModel.DAL
{
    public interface IMedidorDAL
    {
        List<Medidor> ObtenerMedidores();

        void AgregarMedidor(Medidor medidor);
        List<Medidor> FiltrarMedidores(int tipo);

        List<Medidor> FiltrarValidacion(string num_medidor);
    }
}
