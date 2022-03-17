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
    public partial class Certificados : Page
    {
        int CERTIFICADO;
        long CEDULA;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.Cookies["paramCert"] != null)
            {
                CERTIFICADO = Int32.Parse(Request.Cookies["paramCert"].Value);
                CEDULA = Int64.Parse(Request.Cookies["paramCedula"].Value);
                HttpCookie nombreS2 = new HttpCookie("CERT2");
                nombreS2.Value = CERTIFICADO.ToString();
                nombreS2.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(nombreS2);

                HttpCookie nombreS2X = new HttpCookie("CED2");
                nombreS2X.Value = CEDULA.ToString();
                nombreS2X.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(nombreS2X);
                Response.Cookies["paramCedula"].Expires = DateTime.Now.AddDays(-1);
                Response.Cookies["paramCert"].Expires = DateTime.Now.AddDays(-1);
            }
            else
            {

            }
            

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {            

           
        }
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
            

        }
        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdicionConsulta.aspx");
        }
        protected void Unnamed3_Click(object sender, EventArgs e)
        {
            Response.Redirect("ReemplazoCons.aspx");
        }
        protected void descarga1(object sender, EventArgs e)
        {
            
            using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
            {
                string saveStaff = "SELECT Archivo1 FROM Asegurados WHERE NumeroCertificado=@NumeroCertificado";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
                    querySaveStaff.Parameters.Add("@NumeroCertificado", SqlDbType.Int).Value = GridView1.Rows[0].Cells[1].Text;
                    

                    try
                    {
                        openCon.Open();
                        using (SqlDataReader dr = querySaveStaff.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                string archivo = dr.GetFieldValue<string>(0);
                                var transporte = Convert.FromBase64String(archivo);
                                Response.Clear();
                                Response.ClearHeaders();
                                Response.ContentType = "application/pdf";
                                Response.AddHeader("content-disposition", "attachment; filename=" + "CERTIFICADO NUMERO " + GridView1.Rows[0].Cells[1].Text + ".pdf");
                                Response.BufferOutput = true; ;
                                Response.OutputStream.Write(transporte, 0, transporte.Length);
                                Response.End();

                            }
                            else
                            {

                            }

                            dr.Close();
                        }
                        openCon.Close();


                    }
                    catch (SqlException ex)
                    {
                        Response.Write("Error" + ex);
                    }
                }
            }
        }
        protected void descarga2(object sender, EventArgs e)
        {
            
            using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
            {
                string saveStaff = "SELECT Archivo2 FROM Asegurados WHERE NumeroCertificado=@NumeroCertificado";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
                    querySaveStaff.Parameters.Add("@NumeroCertificado", SqlDbType.Int).Value = GridView1.Rows[0].Cells[1].Text; ;


                    try
                    {
                        openCon.Open();
                        using (SqlDataReader dr = querySaveStaff.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                string archivo = dr.GetFieldValue<string>(0);
                                var transporte = Convert.FromBase64String(archivo);
                                Response.Clear();
                                Response.ClearHeaders();
                                Response.ContentType = "application/pdf";
                                Response.AddHeader("content-disposition", "attachment; filename="+"DESCARGA 2 CERTIFICADO NUMERO "+ GridView1.Rows[0].Cells[1].Text + ".pdf");
                                Response.BufferOutput = true; ;
                                Response.OutputStream.Write(transporte, 0, transporte.Length);
                                Response.End();

                            }
                            else
                            {

                            }

                            dr.Close();
                        }
                        openCon.Close();


                    }
                    catch (SqlException ex)
                    {
                        Response.Write("Error" + ex);
                    }
                }
            }
        }
        protected void descarga3(object sender, EventArgs e)
        {
            
            using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
            {
                string saveStaff = "SELECT Archivo3 FROM Asegurados WHERE NumeroCertificado=@NumeroCertificado";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
                    querySaveStaff.Parameters.Add("@NumeroCertificado", SqlDbType.Int).Value = GridView1.Rows[0].Cells[1].Text; 


                    try
                    {
                        openCon.Open();
                        using (SqlDataReader dr = querySaveStaff.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                string archivo = dr.GetFieldValue<string>(0);
                                var transporte = Convert.FromBase64String(archivo);
                                Response.Clear();
                                Response.ClearHeaders();
                                Response.ContentType = "application/pdf";
                                Response.AddHeader("content-disposition", "attachment; filename=" + "DESCARGA 3 CERTIFICADO NUMERO " + GridView1.Rows[0].Cells[1].Text + ".pdf");
                                Response.BufferOutput = true; ;
                                Response.OutputStream.Write(transporte, 0, transporte.Length);
                                Response.End();

                            }
                            else
                            {

                            }

                            dr.Close();
                        }
                        openCon.Close();


                    }
                    catch (SqlException ex)
                    {
                        Response.Write("Error" + ex);
                    }
                }
            }
        }
    }
}