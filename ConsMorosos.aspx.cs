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
    public partial class ConsMorosos : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            
        }
        
        protected void fijarempresa(object sender, EventArgs e)
        {
            
            HttpCookie nombretomS = new HttpCookie("empresaadC");
            nombretomS.Value = DropDownList3.SelectedValue;
            nombretomS.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(nombretomS);

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void Unnamed_Click1(object sender, EventArgs e)
        {
            HttpCookie nombretomS = new HttpCookie("empresaadC");
            nombretomS.Value = DropDownList3.SelectedValue;
            nombretomS.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(nombretomS);
            Response.Redirect("ConsMorososDos.aspx");
        }
    }
}