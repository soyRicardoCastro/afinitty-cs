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
    public partial class ReporteTomFinal : Page
    {
        DateTime FECHA;
        DateTime FIN;
        string VENDEDOR;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["ParamIni"] != null)
            {
                Decimal total;
                FECHA = DateTime.Parse(Request.Cookies["paramIni"].Value);
                Text1.Value = "" + FECHA.Year + "-" + FECHA.Month.ToString("00") + "-" + FECHA.Day.ToString("00") + "";
                FIN = DateTime.Parse(Request.Cookies["paramFin"].Value);
                Correo.Value = "" + FIN.Year + "-" + FIN.Month.ToString("00") + "-" + FIN.Day.ToString("00") + "";
                VENDEDOR = Request.Cookies["paramVEN"].Value;
                HttpCookie fecha2S = new HttpCookie("paramIniDos");
                fecha2S.Value = FECHA.ToString();
                fecha2S.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(fecha2S);

                HttpCookie fecha2Sx = new HttpCookie("paramFinDos");
                fecha2Sx.Value = FIN.ToString();
                fecha2Sx.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(fecha2Sx);

                HttpCookie fecha2SxY = new HttpCookie("paramVENDos");
                fecha2SxY.Value = VENDEDOR.ToString();
                fecha2SxY.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(fecha2SxY);


                string connectionString = Conection.ConexLine;
                string query = "Select SUM(TotalCobrar) from ASEGURADOS where (NumeroCertificado IS NOT NULL) AND  procesoWSM=@Vent AND FechaVenta BETWEEN @Fecha AND @Fin AND Estado = 'VENTA'"; 


                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@Fecha", SqlDbType.DateTime, 50).Value = FECHA;
                    cmd.Parameters.Add("@Fin", SqlDbType.DateTime, 50).Value = FIN;
                    cmd.Parameters.Add("@Vent", SqlDbType.VarChar, 50).Value = VENDEDOR;

                    con.Open();


                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        if (dr.Read())
                        {
                            if (dr.IsDBNull(0))
                            {

                                total = 0;
                                Label5.Text = "";

                            }
                            else
                            {
                                total = dr.GetFieldValue<decimal>(0);
                                Label5.Text = "TOTAL: " + total.ToString() + "";

                            }


                        }
                        else
                        {
                            total = 0;
                            

                        }



                        dr.Close();
                    }

                    con.Close();
                }
                Response.Cookies["paramIni"].Expires = DateTime.Now.AddDays(-1);
                Response.Cookies["paramFin"].Expires = DateTime.Now.AddDays(-1);
                Response.Cookies["paramVEN"].Expires = DateTime.Now.AddDays(-1);
            }
            else
            {

            }

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

            HttpCookie fecha2SxY = new HttpCookie("paramVEN");
            fecha2SxY.Value = DropDownList1.SelectedValue;
            fecha2SxY.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(fecha2SxY);



            Response.Redirect("ReporteTomFinal.aspx");
        }
        protected void descarga1(object sender, EventArgs e)
        {
            string connectionString2 = Conection.ConexLine;
            string query2 = "Select Ejecutivo, COUNT(NumeroCertificado) as Tomadores, SUM(TotalCobrar) as Primas from ASEGURADOS WHERE ([NumeroCertificado] IS NOT NULL) AND fechaventa BETWEEN @Fecha AND @Fin AND procesoWSM = @Vent AND Estado = 'VENTA' group by Ejecutivo"; 


            using (SqlConnection con2 = new SqlConnection(connectionString2))
            using (SqlCommand cmd2 = new SqlCommand(query2, con2))
            using (SqlDataAdapter sda2 = new SqlDataAdapter())
            using (DataTable dt2 = new DataTable())
            {
                
                cmd2.Parameters.Add("@Fecha", SqlDbType.DateTime, 50).Value = DateTime.Parse(Request.Cookies["paramIniDos"].Value);
                cmd2.Parameters.Add("@Fin", SqlDbType.DateTime, 50).Value = DateTime.Parse(Request.Cookies["paramFinDos"].Value);
                cmd2.Parameters.Add("@Vent", SqlDbType.VarChar, 50).Value = Request.Cookies["paramVENDos"].Value;
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
                                Response.AddHeader("content-disposition", "attachment;filename=ReporteTomadores.xlsx");
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
            Response.Cookies["paramIniDos"].Expires = DateTime.Now.AddDays(-1);
            Response.Cookies["paramFinDos"].Expires = DateTime.Now.AddDays(-1);
            Response.Cookies["paramVENDos"].Expires = DateTime.Now.AddDays(-1);

        }
        protected void Unnamed_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

    }
    
}