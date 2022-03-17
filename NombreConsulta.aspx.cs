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
    public partial class NombreConsulta : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {         
            if (Request.Cookies["paramConsNom"] != null)
            {
                if (GridView1.Rows.Count == 0)
                {
                    Label1.Attributes.Add("style", "display:inline, font-weight: bold; font-size: 18px;");
                    INCLU.Attributes.Add("style", "display:inline");
                    Label1.Text = "EL REGISTRO NO APARECE EN NUESTRA BASE DE DATOS ¿QUE DESEA HACER?";

                }
                else
                {
                    Label1.Attributes.Add("style", "display:none");
                    INCLU.Attributes.Add("style", "display:none");
                }
            }
            else
            {
                Label1.Attributes.Add("style", "display:none");
                INCLU.Attributes.Add("style", "display:none");
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int i = GridView1.SelectedIndex;
            //HttpCookie claseS = new HttpCookie("paramCedula");
            //claseS.Value = GridView1.Rows[i].Cells[0].Text;
            //claseS.Expires = DateTime.Now.AddDays(30);
            //Response.Cookies.Add(claseS);

            HttpCookie codigoS = new HttpCookie("paramCedula");
            codigoS.Value = GridView1.Rows[i].Cells[2].Text;
            codigoS.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(codigoS);

            Response.Redirect("Busqueda.aspx");

        }
        protected void Unnamed1_Click(object sender, EventArgs e)
        {

            GridView1.DataSource = null;
            SqlDataSource1.DataBind();
            string buscar = Correo.Value;
            HttpCookie buscarS = new HttpCookie("paramConsNom");
            buscarS.Value = buscar;
            buscarS.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(buscarS);
            DateTime FECHA = DateTime.Now;
            HttpCookie fechaS = new HttpCookie("fechaC");
            fechaS.Value = FECHA.ToString();
            fechaS.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(fechaS);
            Response.Redirect("NombreConsulta.aspx");

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
            Response.Redirect("Default.aspx");
        }
    }
}