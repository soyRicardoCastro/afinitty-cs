using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReachSystem
{
    public partial class ReclamoRespCons : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (GridView1.Rows.Count >= 1)
            {
                GridView2.Attributes.Add("style", "display:none");

            }
            else
            {
                GridView1.Attributes.Add("style", "display:none");
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GridView1.SelectedIndex >= 0)
            {
                int i = GridView1.SelectedIndex;


                HttpCookie fecha2S = new HttpCookie("casorecC");
                fecha2S.Value = GridView1.Rows[i].Cells[1].Text;
                fecha2S.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(fecha2S);

                HttpCookie fecha2Sx = new HttpCookie("fechainicC");
                fecha2Sx.Value = GridView1.Rows[i].Cells[0].Text;
                fecha2Sx.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(fecha2Sx);

                Response.Redirect("ReclamosResponder.aspx");
            }
            else
            {
                int i = GridView2.SelectedIndex;


                HttpCookie fecha2S = new HttpCookie("casorecC");
                fecha2S.Value = GridView2.Rows[i].Cells[1].Text;
                fecha2S.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(fecha2S);

                HttpCookie fecha2Sx = new HttpCookie("fechainicC");
                fecha2Sx.Value = GridView2.Rows[i].Cells[0].Text;
                fecha2Sx.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(fecha2Sx);

                Response.Redirect("ReclamosResponder.aspx");
            }

        }
        protected void Unnamed1_Click(object sender, EventArgs e)
        {

            GridView1.DataSource = null;
            SqlDataSource1.DataBind();
            string buscar = Correo.Value;
            HttpCookie buscarS = new HttpCookie("paramCedula");
            buscarS.Value = buscar;
            buscarS.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(buscarS);
            DateTime FECHA = DateTime.Now;
            HttpCookie fechaS = new HttpCookie("fechaC");
            fechaS.Value = FECHA.ToString();
            fechaS.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(fechaS);
            Response.Redirect("ReclamoRespCons.aspx");

        }
        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            Response.Redirect("InclusionTomador.aspx");

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void Unnamed_Click1(object sender, EventArgs e)
        {
            string url = "https://srienlinea.sri.gob.ec/sri-en-linea/SriDeclaracionesWeb/ConsultaImpuestoRenta/Consultas/consultaImpuestoRenta";
            Response.Write("<script> window.open('" + url + "','_blank'); </script>");
        }
    }
}