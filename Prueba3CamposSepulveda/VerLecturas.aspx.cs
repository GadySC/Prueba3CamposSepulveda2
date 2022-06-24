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
    public partial class VerLecturas : System.Web.UI.Page
    {
        private IMedidorDAL medidoresDAL = new MedidorDALObjetos();
        private ILecturaDAL lecturasDAL = new LecturaDALObjetos();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                List<Medidor> medidores = medidoresDAL.ObtenerMedidores();
                this.lecturaDdl.DataSource = medidores;
                this.lecturaDdl.DataValueField = "Tipo";
                this.lecturaDdl.DataTextField = "Num_Medidor";
                this.lecturaDdl.DataBind();
                this.lecturaDdl.Items.Insert(0, new ListItem("Seleccione un medidor..", "0"));
            }
        }

        protected void lecturaDdl_SelectedIndexChanged(object sender, EventArgs e)
        {
            string num_medidors = this.lecturaDdl.SelectedItem.Text;
            List<Lectura> lecturas2 = lecturasDAL.ObtenerLecturas();
            Lectura lectura1 = new Lectura();
            
            for (int i = 0; i <= lecturas2.Count; i++) {
                if (lecturas2[i].Medidor.Num_Medidor == num_medidors) { 
                    lectura1 = lecturas2[i];
                    grafico.Series["lecturas"].Points.AddXY("lecturas", lectura1.Consumo);
                }
            }
        }
        

        protected void actualizarBtn_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect(Page.Request.Url.ToString(), true);
        }
    }
}