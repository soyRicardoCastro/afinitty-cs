using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReachSystem
{
    public partial class ProdListaEdicB : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
      

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = GridView1.SelectedIndex;
            HttpCookie claseS = new HttpCookie("paramprod");
            claseS.Value = GridView1.Rows[i].Cells[0].Text;
            claseS.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(claseS);

            HttpCookie codigoS = new HttpCookie("paramplan");
            codigoS.Value = GridView1.Rows[i].Cells[1].Text;
            codigoS.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(codigoS);

            HttpCookie clase1S = new HttpCookie("parammin");
            clase1S.Value = GridView1.Rows[i].Cells[2].Text;
            clase1S.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(clase1S);

            HttpCookie codigo1S = new HttpCookie("parammax");
            codigo1S.Value = GridView1.Rows[i].Cells[3].Text;
            codigo1S.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(codigo1S);

            HttpCookie clase2S = new HttpCookie("paramren");
            clase2S.Value = GridView1.Rows[i].Cells[4].Text;
            clase2S.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(clase2S);

            HttpCookie codigo3S = new HttpCookie("paramapli");
            codigo3S.Value = GridView1.Rows[i].Cells[5].Text;
            codigo3S.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(codigo3S);

            HttpCookie clase4S = new HttpCookie("paramval");
            clase4S.Value = GridView1.Rows[i].Cells[7].Text;
            clase4S.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(clase4S);

            HttpCookie clase6S = new HttpCookie("paramcob");
            clase6S.Value = GridView1.Rows[i].Cells[6].Text;
            clase6S.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(clase6S);

            HttpCookie clase5S = new HttpCookie("indexprod");
            clase5S.Value = "1";
            clase5S.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(clase5S);

            HttpCookie clase5S7 = new HttpCookie("paramCausa");
            clase5S7.Value = GridView1.Rows[i].Cells[8].Text;
            clase5S7.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(clase5S7);

            HttpCookie clase5S72 = new HttpCookie("paramRow");
            clase5S72.Value = GridView1.Rows[i].Cells[9].Text;
            clase5S72.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(clase5S72);

            Response.Redirect("ProdCreacionB.aspx");
        }
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProdListaEdicB.aspx");
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