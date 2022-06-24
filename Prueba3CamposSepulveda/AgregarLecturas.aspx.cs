using Prueba3CamposSepulvedaModel.DAL;
using Prueba3CamposSepulvedaModel.DTO;
using System;
using System.Collections.Generic;
using System.Globalization;
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
            
            


            if ((!(medTxt.Text.Trim().Equals("")) && !(valorConsumo.Text.Trim().Equals(""))) && !(horaLectura.Text.Trim().Equals("")) && !(minutoLectura.Text.Trim().Equals("")))
            {
                if ((Convert.ToInt32(horaLectura.Text.Trim()) > 0) && ((Convert.ToInt32(horaLectura.Text.Trim()) <= 23)))
                {
                    if ((Convert.ToInt32(minutoLectura.Text.Trim()) > 0) && ((Convert.ToInt32(minutoLectura.Text.Trim()) <= 59)))
                    {
                        DateTime fecha = Convert.ToDateTime(calendario.SelectedDate.ToString("dd/MM/yyyy") + " " + horaLectura.Text.Trim() + ":" + minutoLectura.Text.Trim());
                        double consumo = Convert.ToDouble(this.valorConsumo.Text.Trim());
                        string numero_medidor = this.medTxt.SelectedValue;

                        if ((consumo > 0) && (consumo <= 600))
                        {
                            Medidor medidorsito = new Medidor(numero_medidor);
                            new Lectura()
                            {
                                Medidor = medidorsito,
                                Fecha = fecha,
                                Consumo = consumo,

                            };

                            lecturaDAL.AgregarLectura(lectura);

                            this.mensajeLbl.Text = "Lectura Ingresada Exitosamente !!!";
                            Response.Redirect("VerLecturas.aspx");
                        }
                        else
                        {
                            this.mensajeLbl.Text = "Consumo fuera de rango.";
                        }
                    }
                    else
                    {
                        this.mensajeLbl.Text = "Minutos ingresados no validos.";
                    }
                }
                else
                {
                    this.mensajeLbl.Text = "Hora ingresada no valida.";
                }
            }
            else {
                this.mensajeLbl.Text = "Por favor complete todos los campos.";
            }
            
        }
    }
}