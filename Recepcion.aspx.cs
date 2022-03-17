using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReachSystem
{
    public partial class Recepcion : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
      

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = GridView1.SelectedIndex;
            string fecha = GridView1.Rows[i].Cells[1].Text;
            //int mes = fecha.Month;

            HttpCookie fechavigS = new HttpCookie("emprecobnom");
            fechavigS.Value = GridView1.Rows[i].Cells[0].Text;
            fechavigS.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(fechavigS);

            HttpCookie fechavig2S = new HttpCookie("emprecobmes");
            fechavig2S.Value = fecha;
            fechavig2S.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(fechavig2S);

            Response.Redirect("RecDos.aspx");
        }
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProdListaEdic.aspx");
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