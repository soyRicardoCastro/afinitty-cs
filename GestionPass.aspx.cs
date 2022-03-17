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
    public partial class GestionPass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            text1.Value = Request.Cookies["usupassC"].Value;
            text1.Disabled = true;
        }
        protected void Unnamed1_Click1(object sender, EventArgs e)
        {

            if (text2.Value == text3.Value)
            {

                string connectionString = Conection.ConexLine;
                string query = "UPDATE Usuario SET Pass=@Pass WHERE Usu=@Correo";


                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {

                    cmd.Parameters.Add("@Pass", SqlDbType.VarChar, 50).Value = text2.Value;
                    cmd.Parameters.Add("@Correo", SqlDbType.VarChar, 50).Value = text1.Value;


                    // open connection
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                    }
                    finally
                    {
                        con.Close();
                        Response.Write("<script>alert('PASSWORD ACTUALIZADO')</script>");
                        
                    }

                }
            }
            else
            {
                Response.Write("<script>alert('Las Contrasenas no coinciden')</script>");
            }
        }
    }
}