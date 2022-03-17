using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using ClosedXML.Excel;
using System.Configuration;

namespace ReachSystem
{
    public partial class ProcesoIngresado : Page
    {
        DateTime FECHA;
        DateTime FIN;
        string VENDEDOR;
        string ESTADO;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Text1.Value = "" + DateTime.Now.Year + "-" + DateTime.Now.Month.ToString("00") + "-" + DateTime.Now.Day.ToString("00") + "";
            //Text1.Disabled = true;
            //if (Request.Cookies["ParamIni"] != null)
            //{
            //    //Decimal total;
            //    FECHA = DateTime.Parse(Request.Cookies["paramIni"].Value);
                
            //    FIN = DateTime.Parse(Request.Cookies["paramFin"].Value);
            //    //Correo.Value = "" + FIN.Year + "-" + FIN.Month.ToString("00") + "-" + FIN.Day.ToString("00") + "";
            //    VENDEDOR = Request.Cookies["paramVEN"].Value;
          
            //    //DropDownList1.SelectedValue = VENDEDOR;
               
            //    HttpCookie fecha2S = new HttpCookie("paramIniDos");
            //    fecha2S.Value = FECHA.ToString();
            //    fecha2S.Expires = DateTime.Now.AddDays(30);
            //    Response.Cookies.Add(fecha2S);

            //    HttpCookie fecha2Sx = new HttpCookie("paramFinDos");
            //    fecha2Sx.Value = FIN.ToString();
            //    fecha2Sx.Expires = DateTime.Now.AddDays(30);
            //    Response.Cookies.Add(fecha2Sx);

            //    HttpCookie fecha2SxY = new HttpCookie("paramVENDos");
            //    fecha2SxY.Value = VENDEDOR.ToString();
            //    fecha2SxY.Expires = DateTime.Now.AddDays(30);
            //    Response.Cookies.Add(fecha2SxY);


                //decimal total;
                //string connectionString = "workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB";
                //string query = "Select SUM(TotalCobrar) from ASEGURADOS where (NumeroCertificado IS NOT NULL) AND  NombreComercial=@Vent AND FechaVigencia BETWEEN @Fecha AND @Fin AND Estado='VENTA'";


                //using (SqlConnection con = new SqlConnection(connectionString))
                //using (SqlCommand cmd = new SqlCommand(query, con))
                //{
                //    cmd.Parameters.Add("@Fecha", SqlDbType.DateTime, 50).Value = FECHA;
                //    cmd.Parameters.Add("@Fin", SqlDbType.DateTime, 50).Value = FIN;
                //    cmd.Parameters.Add("@Vent", SqlDbType.VarChar, 50).Value = VENDEDOR;

                //    con.Open();


                //    using (SqlDataReader dr = cmd.ExecuteReader())
                //    {

                //        if (dr.Read())
                //        {
                //            if (dr.IsDBNull(0))
                //            {

                //                total = 0;
                //                Label5.Text = "hola";

                //            }
                //            else
                //            {
                //                total = dr.GetFieldValue<decimal>(0);
                //                Label5.Text = "TOTAL LISTADO: " + total.ToString() + "";

                //            }


                //        }
                //        else
                //        {
                //            total = 0;


                //        }



                //        dr.Close();
                //    }

                //    con.Close();
                //}
            //    Response.Cookies["paramIni"].Expires = DateTime.Now.AddDays(-1);
            //    Response.Cookies["paramFin"].Expires = DateTime.Now.AddDays(-1);
            //    Response.Cookies["paramVEN"].Expires = DateTime.Now.AddDays(-1);
           
            //}
            //else
            //{

            //}

        }


        protected void Unnamed_Click1(object sender, EventArgs e)
        {
            using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
            {

                string saveStaff = "DELETE FROM Asegurados WHERE NumeroCertificado IS NULL";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
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
            using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
            {

                string saveStaff = "DELETE FROM Dependientes WHERE NumeroCertificado IS NULL";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
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

           




            Response.Redirect("EliminarGen.aspx");
        }
        protected void descarga1(object sender, EventArgs e)
        {
            string connectionString2 = Conection.ConexLine;
            string query2 = "select  NombreComercial, NumeroCertificado, Nombre, Cedula, FechaVenta, Ejecutivo, Digitador from Asegurados where Proceso='INGRESADO' AND NumeroCertificado is not null"; 


            using (SqlConnection con2 = new SqlConnection(connectionString2))
            using (SqlCommand cmd2 = new SqlCommand(query2, con2))
            using (SqlDataAdapter sda2 = new SqlDataAdapter())
            using (DataTable dt2 = new DataTable())
            {
                
                
                sda2.SelectCommand = cmd2;
                sda2.Fill(dt2);
                con2.Open();


                using (SqlDataReader dr2 = cmd2.ExecuteReader())
                {

                    if (dr2.Read())
                    {
                        if (dr2.IsDBNull(0))
                        {

                           

                        }
                        else
                        {
                            using (XLWorkbook wb = new XLWorkbook())
                            {
                                wb.Worksheets.Add(dt2, "Reporte");

                                Response.Clear();
                                Response.Buffer = true;
                                Response.Charset = "";
                                Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                                Response.AddHeader("content-disposition", "attachment;filename=CertificadosIngresados.xlsx");
                                using (MemoryStream MyMemoryStream = new MemoryStream())
                                {
                                    wb.SaveAs(MyMemoryStream);
                                    MyMemoryStream.WriteTo(Response.OutputStream);
                                    Response.Flush();
                                    Response.End();
                                }
                            }





                        }


                    }
                    else
                    {
                        


                    }



                    dr2.Close();
                }

                con2.Close();
            }
            //Response.Cookies["paramIniDos"].Expires = DateTime.Now.AddDays(-1);
            //Response.Cookies["paramFinDos"].Expires = DateTime.Now.AddDays(-1);
            //Response.Cookies["paramVENDos"].Expires = DateTime.Now.AddDays(-1);
      

        }
        protected void Unnamed_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

    }
    
}