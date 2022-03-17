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
    public partial class CierreExclu : Page
    {
        DateTime FechaIni;
        DateTime FechaFin;
        protected void Page_Load(object sender, EventArgs e)
        {
            string tasa;
            Label2.Text = "EL CIERRE CORRESPONDE A LA FACTURACION DE: " + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString() + "";
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

            //mes = DateTime.Now.Month;
            //year = DateTime.Now.Year;

            if (DateTime.Now.Month == 12)
            {
                mes = 1;
                year = DateTime.Now.Year + 1;
            }
            else
            {
                mes = DateTime.Now.Month + 1;
                year = DateTime.Now.Year;
            }
            DateTime fechafindos = DateTime.Parse(Text5.Value);
            DateTime fechainidos = DateTime.Parse(Label1.Text);
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(Conection.ConexLine))
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT a.NombreComercial, SUM(a.TotalCobrar) AS Total, b.Ciudad FROM Asegurados a FULL JOIN Usuario b ON a.Ejecutivo = b.Nombre Where a.Estado = 'EXCLUIDO' AND a.FechaRet BETWEEN @fechaini AND @fechafin GROUP BY a.NombreComercial, b.Ciudad", con);
                sda.SelectCommand.Parameters.AddWithValue("@fechaini", fechainidos);
                sda.SelectCommand.Parameters.AddWithValue("@fechafin", fechafindos);
                sda.Fill(dt);
                
                

            }                                              
            int cierre = dt.Rows.Count;
            for (int i = 0; i < cierre; i++)
            {
                using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
                {
                    string saveStaff = "INSERT into Cierres (Empresa, Fecha, Ciudad, Monto, Tipo, Estado, Mes) VALUES (@Empresa, @Fecha, @Ciudad, @Monto, 'EXCLUSION', 'VIGENTE', @Mes)";

                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = openCon;
                        querySaveStaff.Parameters.Add("@Empresa", SqlDbType.VarChar).Value = dt.Rows[i][0].ToString();
                        querySaveStaff.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = fechafindos;
                        querySaveStaff.Parameters.Add("@Ciudad", SqlDbType.VarChar).Value = dt.Rows[i][2].ToString();
                        querySaveStaff.Parameters.Add("@Monto", SqlDbType.Money).Value = Decimal.Parse(dt.Rows[i][1].ToString());
                        querySaveStaff.Parameters.Add("@Mes", SqlDbType.VarChar).Value = "" + mes + "-" + year + "";
                        
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

            }
            Response.Write("<script>alert('CIERRE DE EXCLUSIONES GENERADO CORRECTAMENTE')</script>");


        }
        protected void Unnamed2_Click1(object sender, EventArgs e)
        {

            Response.Redirect("Default.aspx");

        }
    }
}

        
    
