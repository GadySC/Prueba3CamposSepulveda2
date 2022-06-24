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

        public bool FiltrarValidar(string num_medidor) {

            List<Medidor> filtrada = medidorDAL.FiltrarValidacion(num_medidor);
            

            if (filtrada.Count == 0)
            {
                this.mensajeLbl.Text = "No se encuentra ningun medidor en la lista.";
                return false;
            }
            else {
                return true;
            }
        }

        protected void agregarBtn_Click(object sender, EventArgs e)
        {
            string num_medidor = this.numMedTxt.Text.Trim();

            if (!num_medidor.Equals(""))
            {
                int tipo = Convert.ToInt32(this.tipoRbl.SelectedValue);
                if (!FiltrarValidar(num_medidor))
                {
                    Medidor medidor = new Medidor()
                    {
                        Num_Medidor = num_medidor,
                        Tipo = tipo,
                    };

                    medidorDAL.AgregarMedidor(medidor);

                    this.mensajeLbl.Text = "Medidor Ingresado Exitosamente !!!";
                    Response.Redirect("VerMedidores.aspx");

                }
                else
                {
                    this.mensajeLbl.Text = "Ya se encuentra registrado el medidor que ingreso, por favor ingrese otro.";

                }
            }
            else {
                this.mensajeLbl.Text = "Por favor ingrese un numero del medidor.";

            }   
        }
    }
}