using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReachSystem
{
    public partial class AsistenciaLista : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
  
            HttpCookie claseS = new HttpCookie("asistnombre");
            claseS.Value = DropDownList4.SelectedValue;
            claseS.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(claseS);
            

            Response.Redirect("AsistFin.aspx");
        }
        //protected void Unnamed1_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("InclusionTomador.aspx");
        //}

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