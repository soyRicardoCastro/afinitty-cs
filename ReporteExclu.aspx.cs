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
    public partial class ReporteExclu : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }


        protected void Unnamed_Click1(object sender, EventArgs e)
        {

            HttpCookie fecha2S = new HttpCookie("paramIni");
            fecha2S.Value = Text1.Value;
            fecha2S.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(fecha2S);

            HttpCookie fecha2Sx = new HttpCookie("paramFin");
            fecha2Sx.Value = Correo.Value;
            fecha2Sx.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(fecha2Sx);

            //HttpCookie fecha2SxY = new HttpCookie("paramEST");
            //fecha2SxY.Value = DropDownList1.SelectedValue;
            //fecha2SxY.Expires = DateTime.Now.AddDays(30);
            //Response.Cookies.Add(fecha2SxY);



            Response.Redirect("ReporteExclu.aspx");
        }

    }
    
}