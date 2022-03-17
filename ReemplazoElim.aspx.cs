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
    public partial class ReemplazoElim : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (GridView1.Rows.Count >= 1)
            {
                Label1.Attributes.Add("style", "display:none");
                INCLU.Attributes.Add("style", "display:none");
            }
            else
            {
                ADIC.Attributes.Add("style", "display:none");
            }
            

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i =GridView1.SelectedIndex;
            

            using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
            {

                string saveStaff = "UPDATE Dependientes SET Estado='EXCLUIDO', procesoWSM=@procesoWSM WHERE Row=@Row";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
                    querySaveStaff.Parameters.Add("@Row", SqlDbType.Int).Value = Int32.Parse(GridView1.Rows[i].Cells[0].Text);
                    querySaveStaff.Parameters.Add("@procesoWSM", SqlDbType.VarChar).Value = "REEMPLAZO";


                    try
                    {
                        openCon.Open();
                        querySaveStaff.ExecuteNonQuery();
                        openCon.Close();
                        

                    }
                    catch (SqlException ex)
                    {
                        Response.Write("Error" + ex);
                    }
                }
            }

            Response.Redirect("ReemplazoElim.aspx");
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
            HttpCookie fecha2S = new HttpCookie("indexC");
            fecha2S.Value = "30";
            fecha2S.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(fecha2S);
            Response.Redirect("AdicionSeleccion.aspx");
        }
    }
}