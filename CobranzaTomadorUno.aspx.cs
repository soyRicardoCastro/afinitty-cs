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
    public partial class CobranzaTomadorUno : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            
        }
        
        protected void fijarempresa(object sender, EventArgs e)
        {
            
            //HttpCookie nombretomS = new HttpCookie("empresaadC");
            //nombretomS.Value = DropDownList3.SelectedValue;
            //nombretomS.Expires = DateTime.Now.AddDays(30);
            //Response.Cookies.Add(nombretomS);

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = GridView3.SelectedIndex;
            HttpCookie nombretomS = new HttpCookie("empresaadC");
            nombretomS.Value = GridView3.Rows[i].Cells[0].Text;
            nombretomS.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(nombretomS);
            HttpCookie nombretomS2 = new HttpCookie("empresmesC");
            nombretomS2.Value = GridView3.Rows[i].Cells[1].Text;
            nombretomS2.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(nombretomS2);
            HttpCookie nombretomS3 = new HttpCookie("empresmesguiaC");
            nombretomS3.Value = GridView3.Rows[i].Cells[2].Text;
            nombretomS3.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(nombretomS3);
            Response.Redirect("CobranzaTomadorDos.aspx");
        }
    }
}