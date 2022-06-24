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
    public partial class Default : System.Web.UI.Page
    {
        private IMedidorDAL medidorDAL = new MedidorDALObjetos();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void FiltrarValidar(string num_medidor) {

            List<Medidor> filtrada = medidorDAL.FiltrarValidacion(num_medidor);

            if (filtrada.Count == 0) {
                this.mensajeLbl.Text = "No se encuentra ningun medidor en la lista.";
            }
        }

        protected void agregarBtn_Click(object sender, EventArgs e)
        {
            string num_medidor = this.numMedTxt.Text.Trim();

            int tipo = Convert.ToInt32(this.tipoRbl.SelectedValue);

            Medidor medidor = new Medidor()
            {
                Num_Medidor = num_medidor,
                Tipo = tipo,
            };

            medidorDAL.AgregarMedidor(medidor);

            this.mensajeLbl.Text = "Medidor Ingresado Exitosamente !!!";
            Response.Redirect("VerMedidores.aspx");
        }
    }
}