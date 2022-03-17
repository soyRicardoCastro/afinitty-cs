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
    public partial class EditarUsuario : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView2.Attributes.Add("style", "display:none");
            if (Request.Cookies["buscarC"] != null)
            {
                if (GridView1.Rows.Count == 0)
                {
                    Label1.Attributes.Add("style", "display:inline, font-weight: bold; font-size: 18px;");
                    GridView1.Attributes.Add("style", "display:none");
                    //Label1.Text = "EL REGISTRO NO EXISTE EN NUESTRA BASE DE DATOS ¿QUE DESEA HACER?";
                    Correo.Value = Request.Cookies["buscarC"].Value;
                    Response.Cookies["buscarC"].Expires = DateTime.Now.AddDays(-1);

                }
                else
                {
                    Label1.Attributes.Add("style", "display:none");
                    GridView2.Attributes.Add("style", "display:none");
                    Correo.Value = Request.Cookies["buscarC"].Value;
                    Response.Cookies["buscarC"].Expires = DateTime.Now.AddDays(-1);
                }
            }
            else
            {

            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GridView1.Rows.Count == 0)
            {
                int i = GridView2.SelectedIndex;
                HttpCookie buscarS = new HttpCookie("idusuC");
                buscarS.Value = GridView2.Rows[i].Cells[0].Text;
                buscarS.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(buscarS);

                Response.Redirect("EditarUsuarioDos.aspx");
                
            }
            else
            {
                int i = GridView1.SelectedIndex;
                HttpCookie buscarS = new HttpCookie("idusuC");
                buscarS.Value = GridView1.Rows[i].Cells[0].Text;
                buscarS.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(buscarS);

                Response.Redirect("EditarUsuarioDos.aspx");

            }

        }
        protected void Unnamed1_Click(object sender, EventArgs e)
        {

            GridView1.DataSource = null;
            SqlDataSource1.DataBind();
            string buscar = Correo.Value;
            HttpCookie buscarS = new HttpCookie("buscarC");
            buscarS.Value = buscar;
            buscarS.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(buscarS);
            
            Response.Redirect("EditarUsuario.aspx");

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