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
    public partial class EmpDetalleUno : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }
        protected void Unnamed_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {            

            
        }
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            HttpCookie nombreS = new HttpCookie("empdetalleC");
            nombreS.Value = DropDownList4.SelectedValue;
            nombreS.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(nombreS);

            HttpCookie nombreS2 = new HttpCookie("indexempC");
            nombreS2.Value = "3";
            nombreS2.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(nombreS2);

            Response.Redirect("EmpresaDetalleDos.aspx");
        }
    }
}