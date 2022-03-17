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
    public partial class ReporteuSUARIOS : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }


        protected void Unnamed_Click1(object sender, EventArgs e)
        {
            int i = GridView1.SelectedIndex;
            using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
            {

                string saveStaff = "UPDATE uSUARIO SET Estado=@Estado where Usu=@Usu";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
                    querySaveStaff.Parameters.Add("@Estado", SqlDbType.VarChar).Value = "INACTIVO";
                    querySaveStaff.Parameters.Add("@Usu", SqlDbType.VarChar).Value = GridView1.Rows[i].Cells[4].Text;

                    try
                    {
                        openCon.Open();
                        querySaveStaff.ExecuteNonQuery();
                        Response.Write("<script>alert('USUARIO DESACTIVADO')</script>");

                        openCon.Close();

                    }

                    catch (SqlException ex)
                    {
                        Response.Write("Error" + ex);
                    }
                }


            }

        }
        protected void Unnamed_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
    
}