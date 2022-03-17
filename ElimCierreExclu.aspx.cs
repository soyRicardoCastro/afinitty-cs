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
    public partial class ElimCierreExclu : Page
    {
        DateTime FechaIni;
        DateTime FechaFin;
        protected void Page_Load(object sender, EventArgs e)
        {
            string tasa;
            Label2.Text = "EL CIERRE CORRESPONDE A LA FACTURACION DE: ";
            string connectionString = Conection.ConexLine;
            string query = "SELECT TOP 1 fecha FROM cierres where tipo = 'EXCLUSION' ORDER BY fecha DESC";


            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {

                con.Open();


                using (SqlDataReader dr = cmd.ExecuteReader())
                {

                    if (dr.Read())
                    {
                        if (dr.IsDBNull(0))
                        {

                            tasa = "0";

                        }
                        else
                        {
                            tasa = dr.GetFieldValue<DateTime>(0).ToString();
                            Label1.Text = tasa;
                            FechaIni = DateTime.Parse(Label1.Text);
                            FechaFin = DateTime.Now;

                        }


                    }
                    else
                    {
                        tasa = "0";

                    }



                    dr.Close();
                }

                con.Close();
            }
            

        }


        protected void Unnamed_Click1(object sender, EventArgs e)
        {
            int mes = DateTime.Parse(Text5.Value).Month;
            int year = DateTime.Parse(Text5.Value).Year;

            using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
            {
                string saveStaff = "Delete From Cierres where Mes=@Mes and tipo='EXCLUSION'";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
                    querySaveStaff.Parameters.Add("@Mes", SqlDbType.VarChar).Value = "" + mes + "-" + year + "";
                    try
                    {
                        openCon.Open();
                        querySaveStaff.ExecuteNonQuery();
                        openCon.Close();
                        Response.Write("<script>alert('CIERRE DE EXCLUSIONES ELIMINADO CORRECTAMENTE')</script>");

                    }
                    catch (SqlException ex)
                    {
                        Response.Write("Error" + ex);
                    }
                }


            }
        }
        protected void Unnamed2_Click1(object sender, EventArgs e)
        {

            Response.Redirect("Default.aspx");

        }
    }
}

        
    
