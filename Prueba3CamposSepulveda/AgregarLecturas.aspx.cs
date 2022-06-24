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
    public partial class AgregarLecturas : System.Web.UI.Page
    {
        private IMedidorDAL medidoresDAL = new MedidorDALObjetos();
        private ILecturaDAL lecturaDAL = new LecturaDALObjetos();
        Lectura lectura = new Lectura();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                List<Medidor> medidores = medidoresDAL.ObtenerMedidores();
                this.medTxt.DataSource = medidores;
                this.medTxt.DataValueField = "Tipo";
                this.medTxt.DataTextField = "Num_Medidor";              
                this.medTxt.DataBind();
                this.medTxt.Items.Insert(0, new ListItem("Seleccione un medidor..", "0"));
            }
        }

        protected void agregarLecturaBtn_Click(object sender, EventArgs e)
        {
            
            string numero_medidor = this.medTxt.SelectedValue;
            string fechaCalendario = this.calendario.ToString();
            string horaLectura = this.horaLectura.Text.Trim() + ":" + this.minutoLectura.Text.Trim();
            double consumo = Convert.ToDouble(this.valorConsumo.Text.Trim());
            double total_total = consumo + lectura.Total_consumo; 
            Medidor medidorsito = new Medidor(numero_medidor);
            new Lectura()
            {
                Medidor = medidorsito,
                Fecha = fechaCalendario,
                Hora = horaLectura,
                Consumo = consumo,
                Total_consumo = total_total

            };

            lecturaDAL.AgregarLectura(lectura);

            this.mensajeLbl.Text = "Lectura Ingresada Exitosamente !!!";
            Response.Redirect("VerLecturas.aspx");
        }
    }
}