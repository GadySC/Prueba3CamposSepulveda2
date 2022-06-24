using Prueba3CamposSepulvedaModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba3CamposSepulvedaModel.DAL
{
    public interface ILecturaDAL
    {
        List<Lectura> ObtenerLecturas();
        void AgregarLectura(Lectura lectura);


    }
}
