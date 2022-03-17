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
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["PerfilC"].Value == "VENTA")
            {                
                paleta1.Attributes.Add("style", "display:none");
                GridView4.Attributes.Add("style", "display:none");
                Label14.Attributes.Add("style", "display:none");
                GridView5.Attributes.Add("style", "display:none");
                Label16.Attributes.Add("style", "display:none");
                GridView6.Attributes.Add("style", "display:none");
                Label17.Attributes.Add("style", "display:none");
                GridView7.Attributes.Add("style", "display:none");
                Label18.Attributes.Add("style", "display:none");
            }
            else if (Request.Cookies["PerfilC"].Value == "ADMIN")
            {

            }
            else if (Request.Cookies["PerfilC"].Value == "COBRANZA")
            {
                paleta1.Attributes.Add("style", "display:none");
                paleta2.Attributes.Add("style", "display:none");
                paleta3.Attributes.Add("style", "display:none");
                GridView1.Attributes.Add("style", "display:none");
                Label12.Attributes.Add("style", "display:none");
                GridView3.Attributes.Add("style", "display:none");
                Label13.Attributes.Add("style", "display:none");
                GridView5.Attributes.Add("style", "display:none");
                Label16.Attributes.Add("style", "display:none");
                GridView6.Attributes.Add("style", "display:none");
                Label17.Attributes.Add("style", "display:none");
                GridView7.Attributes.Add("style", "display:none");
                Label18.Attributes.Add("style", "display:none");
            }
            else if (Request.Cookies["PerfilC"].Value == "DIRECVEN")
            {
                GridView4.Attributes.Add("style", "display:none");
                Label14.Attributes.Add("style", "display:none");
                
            }
            else if (Request.Cookies["PerfilC"].Value == "SERVICIO")
            {
                paleta1.Attributes.Add("style", "display:none");
                paleta2.Attributes.Add("style", "display:none");
                GridView1.Attributes.Add("style", "display:none");
                Label12.Attributes.Add("style", "display:none");
                GridView3.Attributes.Add("style", "display:none");
                Label13.Attributes.Add("style", "display:none");
                GridView4.Attributes.Add("style", "display:none");
                Label14.Attributes.Add("style", "display:none");

            }
            else if (Request.Cookies["PerfilC"].Value == "OPERACIONES")
            {
                paleta1.Attributes.Add("style", "display:none");
                paleta2.Attributes.Add("style", "display:none");
                paleta3.Attributes.Add("style", "display:none");
                GridView1.Attributes.Add("style", "display:none");
                Label12.Attributes.Add("style", "display:none");
                GridView3.Attributes.Add("style", "display:none");
                Label13.Attributes.Add("style", "display:none");
                GridView6.Attributes.Add("style", "display:none");
                Label17.Attributes.Add("style", "display:none");
                GridView7.Attributes.Add("style", "display:none");
                Label18.Attributes.Add("style", "display:none");
            }
            else if (Request.Cookies["PerfilC"].Value == "SUPEROP")
            {
                paleta1.Attributes.Add("style", "display:none");
                paleta2.Attributes.Add("style", "display:none");
                GridView1.Attributes.Add("style", "display:none");
                Label12.Attributes.Add("style", "display:none");

            }
            else if (Request.Cookies["PerfilC"].Value == "SUPERVEN")
            {
                GridView4.Attributes.Add("style", "display:none");
                Label14.Attributes.Add("style", "display:none");
            }
        }

       
    }
}