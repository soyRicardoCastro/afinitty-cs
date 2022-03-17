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
    public partial class ReporteLiquidaciones : Page
    {
        DateTime FECHA;
        DateTime FIN;
        //string VENDEDOR;
        //string ESTADO;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["ParamIni"] != null)
            {
                //Decimal total;
                FECHA = DateTime.Parse(Request.Cookies["paramIni"].Value);
                Text1.Value = "" + FECHA.Year + "-" + FECHA.Month.ToString("00") + "-" + FECHA.Day.ToString("00") + "";
                FIN = DateTime.Parse(Request.Cookies["paramFin"].Value);
                Correo.Value = "" + FIN.Year + "-" + FIN.Month.ToString("00") + "-" + FIN.Day.ToString("00") + "";
                //VENDEDOR = Request.Cookies["paramVEN"].Value;
                //ESTADO = Request.Cookies["paramEstado"].Value;
                //DropDownList1.SelectedValue = ESTADO;
                //DropDownList2.SelectedValue = VENDEDOR;
                HttpCookie fecha2S = new HttpCookie("paramIniDos");
                fecha2S.Value = FECHA.ToString();
                fecha2S.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(fecha2S);

                HttpCookie fecha2Sx = new HttpCookie("paramFinDos");
                fecha2Sx.Value = FIN.ToString();
                fecha2Sx.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(fecha2Sx);

                //HttpCookie fecha2SxY = new HttpCookie("paramVENDos");
                //fecha2SxY.Value = VENDEDOR.ToString();
                //fecha2SxY.Expires = DateTime.Now.AddDays(30);
                //Response.Cookies.Add(fecha2SxY);


                //HttpCookie fecha2SxY1 = new HttpCookie("paramEstDos");
                //fecha2SxY1.Value = ESTADO;
                //fecha2SxY1.Expires = DateTime.Now.AddDays(30);
                //Response.Cookies.Add(fecha2SxY1);

                //string connectionString = "workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB";
                //string query = "Select SUM(TotalCobrar) from ASEGURADOS where (NumeroCertificado IS NOT NULL) AND  Ejecutivo=@Vent AND FechaVenta BETWEEN @Fecha AND @Fin"; 


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
                //                Label5.Text = "TOTAL: " + total.ToString() + "";

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
                Response.Cookies["paramIni"].Expires = DateTime.Now.AddDays(-1);
                Response.Cookies["paramFin"].Expires = DateTime.Now.AddDays(-1);
                //Response.Cookies["paramVEN"].Expires = DateTime.Now.AddDays(-1);
                //Response.Cookies["paramEstado"].Expires = DateTime.Now.AddDays(-1);
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

            //HttpCookie fecha2SxY = new HttpCookie("paramVEN");
            //fecha2SxY.Value = DropDownList2.SelectedValue;
            //fecha2SxY.Expires = DateTime.Now.AddDays(30);
            //Response.Cookies.Add(fecha2SxY);

            //HttpCookie fecha2SxY1 = new HttpCookie("paramEstado");
            //fecha2SxY1.Value = DropDownList1.SelectedValue;
            //fecha2SxY1.Expires = DateTime.Now.AddDays(30);
            //Response.Cookies.Add(fecha2SxY1);



            Response.Redirect("ReporteLiquidaciones.aspx");
        }
        protected void descarga1(object sender, EventArgs e)
        {
            string connectionString2 = Conection.ConexLine;
            string query2 = "select a.empresa, b.Clase, b.Poliza, a.Mes, a.Monto, a.PrimaNeta, a.PrimaNetaAseg, a.Comision, a.Diferencia, a.FechaRec, a.FechaPre, a.Estado from cierres a join Empresa b on a.Empresa = b.NombreComercial where a.Fecha BETWEEN @fechaini AND @fechafin and a.PrimaNetaAseg <> '' AND a.Tipo = 'VENTA'"; 


            using (SqlConnection con2 = new SqlConnection(connectionString2))
            using (SqlCommand cmd2 = new SqlCommand(query2, con2))
            using (SqlDataAdapter sda2 = new SqlDataAdapter())
            using (DataTable dt2 = new DataTable())
            {
                
                cmd2.Parameters.Add("@fechaini", SqlDbType.DateTime, 50).Value = DateTime.Parse(Request.Cookies["paramIniDos"].Value);
                cmd2.Parameters.Add("@fechafin", SqlDbType.DateTime, 50).Value = DateTime.Parse(Request.Cookies["paramFinDos"].Value);
                //cmd2.Parameters.Add("@ven", SqlDbType.VarChar, 50).Value = Request.Cookies["paramVENDos"].Value;
                //cmd2.Parameters.Add("@est", SqlDbType.VarChar, 50).Value = Request.Cookies["paramEstDos"].Value;
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
                                Response.AddHeader("content-disposition", "attachment;filename=ReporteLiquidaciones.xlsx");
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
            //Response.Cookies["paramVENDos"].Expires = DateTime.Now.AddDays(-1);
            //Response.Cookies["paramEstDos"].Expires = DateTime.Now.AddDays(-1);

        }
        protected void Unnamed_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

    }
    
}