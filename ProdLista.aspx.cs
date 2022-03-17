using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReachSystem
{
    public partial class ProdLista : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (GridView1.Rows.Count >= 1)
            //{
            //    Label1.Attributes.Add("style", "display:none");
            //    INCLU.Attributes.Add("style", "display:none");
            //}
            //else
            //{
            //    ADIC.Attributes.Add("style", "display:none");
            //}
            

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int i =GridView1.SelectedIndex;
            //HttpCookie claseS = new HttpCookie("paramCedula");
            //claseS.Value = GridView1.Rows[i].Cells[0].Text;
            //claseS.Expires = DateTime.Now.AddDays(30);
            //Response.Cookies.Add(claseS);

            //HttpCookie codigoS = new HttpCookie("paramCert");
            //codigoS.Value = GridView1.Rows[i].Cells[2].Text;
            //codigoS.Expires = DateTime.Now.AddDays(30);
            //Response.Cookies.Add(codigoS);

            //Response.Redirect("Certificados.aspx");
        }
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            Response.Redirect("InclusionTomador.aspx");
        }

        protected void CANCEL_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void ADIC_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdicionConsulta.aspx");
        }
    }
}