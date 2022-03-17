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
    public partial class ReporteDebitosCTA : Page
    {
        DateTime FECHA;
        DateTime FIN;
        string VENDEDOR;
        string ESTADO;
        protected void Page_Load(object sender, EventArgs e)
        {
            Text1.Value = "2008-08-08";
            Text1.Disabled = true;
            if (Request.Cookies["ParamIni"] != null)
            {
                //Decimal total;
                FECHA = DateTime.Parse(Request.Cookies["paramIni"].Value);
                Text1.Value = "" + FECHA.Year + "-" + FECHA.Month.ToString("00") + "-" + FECHA.Day.ToString("00") + "";
                FIN = DateTime.Parse(Request.Cookies["paramFin"].Value);
                Correo.Value = "" + FIN.Year + "-" + FIN.Month.ToString("00") + "-" + FIN.Day.ToString("00") + "";
                VENDEDOR = Request.Cookies["paramVEN"].Value;
          
                DropDownList1.SelectedValue = VENDEDOR;
               
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


                //decimal total;
                //string connectionString = "workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB";
                //string query = "Select Select b.Poliza, a.Nombre, a.Vencimiento, a.NumeroTar, SUM(a.TotalCobrar) OVER(PARTITION BY a.Cedula) as Total, a.CodigoSeguridad, a.Tarjeta, a.banco from Asegurados a Join Empresa b on a.NombreComercial = b.NombreComercial WHERE a.FechaVigencia BETWEEN @fechaini AND @fechafin AND a.Estado = 'VENTA' AND a.NombreComercial = @ven group by a.Nombre, b.poliza, a.numerotar, a.cedula, a.totalcobrar, a.codigoseguridad, a.tarjeta, a.banco";


                //using (SqlConnection con = new SqlConnection(connectionString))
                //using (SqlCommand cmd = new SqlCommand(query, con))
                //{
                //    cmd.Parameters.Add("@fechaini", SqlDbType.DateTime, 50).Value = FECHA;
                //    cmd.Parameters.Add("@fechafin", SqlDbType.DateTime, 50).Value = FIN;
                //    cmd.Parameters.Add("@ven", SqlDbType.VarChar, 50).Value = VENDEDOR;

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

   



            Response.Redirect("ReporteDebitosCTA.aspx");
        }
        protected void descarga1(object sender, EventArgs e)
        {
            string connectionString2 = Conection.ConexLine;
            string query2 = "Select distinct b.Poliza, b.Clase, a.Nombre, a.NombreComercial, a.Cuenta, a.TipoCuenta, SUM(a.TotalCobrar) OVER(PARTITION BY a.Cedula) as Total, a.Cedula, a.banco from Asegurados a Join Empresa b on a.NombreComercial = b.NombreComercial WHERE a.FechaVigencia BETWEEN @fechaini AND @fechafin AND a.Estado = 'VENTA' AND a.NombreComercial = @ven AND a.Cuenta <> ''"; 


            using (SqlConnection con2 = new SqlConnection(connectionString2))
            using (SqlCommand cmd2 = new SqlCommand(query2, con2))
            using (SqlDataAdapter sda2 = new SqlDataAdapter())
            using (DataTable dt2 = new DataTable())
            {
                
                cmd2.Parameters.Add("@fechaini", SqlDbType.DateTime, 50).Value = DateTime.Parse(Request.Cookies["paramIniDos"].Value);
                cmd2.Parameters.Add("@fechafin", SqlDbType.DateTime, 50).Value = DateTime.Parse(Request.Cookies["paramFinDos"].Value);
                cmd2.Parameters.Add("@ven", SqlDbType.VarChar, 50).Value = Request.Cookies["paramVENDos"].Value;
                //cmd2.Parameters.Add("@Est", SqlDbType.VarChar, 50).Value = Request.Cookies["paramEstDos"].Value;
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
                                Response.AddHeader("content-disposition", "attachment;filename=ReporteDebitosCTA.xlsx");
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