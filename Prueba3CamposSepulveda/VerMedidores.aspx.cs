using Prueba3CamposSepulvedaModel.DAL;
using Prueba3CamposSepulvedaModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prueba3CamposSepulveda
{
    public partial class VerMedidores : System.Web.UI.Page
    {
        private IMedidorDAL medidorDAL = new MedidorDALObjetos();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargaGrilla();
            }
        }

        private void cargaGrilla()
        {
            List<Medidor> medidores = medidorDAL.ObtenerMedidores();
            this.grillaMedidores.DataSource = medidores;
            this.grillaMedidores.DataBind();
        }
        private void cargaGrilla(List<Medidor> filtrada)
        {
            List<Medidor> medidores = medidorDAL.ObtenerMedidores();
            this.grillaMedidores.DataSource = filtrada;
            this.grillaMedidores.DataBind();
        }

        protected void tipoDdl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tipoDdl.SelectedItem != null)
            {
                int tipo = Convert.ToInt32(this.tipoDdl.SelectedItem.Value);
                //filtrar por nivel
                List<Medidor> filtrada = medidorDAL.FiltrarMedidores(tipo);
                cargaGrilla(filtrada);
            }
        }
    }
}