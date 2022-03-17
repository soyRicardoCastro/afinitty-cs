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
    public partial class ProReten : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["paramCedula"] != null)
            {
                if (GridView1.Rows.Count == 0)
                {
                    Label1.Attributes.Add("style", "display:inline, font-weight: bold; font-size: 18px;");
                    
                    Label1.Text = "REGISTRO NO ENCONTRADO";
                    Correo.Value = Request.Cookies["paramCedula"].Value;
                    Response.Cookies["paramCedula"].Expires = DateTime.Now.AddDays(-1);

                }
                else
                {
                    Label1.Attributes.Add("style", "display:none");
                    
                    Correo.Value = Request.Cookies["paramCedula"].Value;
                    Response.Cookies["paramCedula"].Expires = DateTime.Now.AddDays(-1);
                }
            }
            else
            {

            }

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = GridView1.SelectedIndex;
            
            HttpCookie codigoS = new HttpCookie("paramCert");
            codigoS.Value = GridView1.Rows[i].Cells[0].Text;
            codigoS.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(codigoS);

            HttpCookie codigoS1 = new HttpCookie("Indext");
            codigoS1.Value = "1";
            codigoS1.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(codigoS1);

            Response.Redirect("RetenFin.aspx");

        }
        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = GridView2.SelectedIndex;

            HttpCookie codigoS = new HttpCookie("paramCert");
            codigoS.Value = GridView2.Rows[i].Cells[3].Text;
            codigoS.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(codigoS);

            HttpCookie codigoS1 = new HttpCookie("Indext");
            codigoS1.Value = "1";
            codigoS1.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(codigoS1);

            Response.Redirect("RetenFin.aspx");

        }
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            
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
            Response.Redirect("Proreten.aspx");

        }


        protected void Unnamed_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        
    }
}