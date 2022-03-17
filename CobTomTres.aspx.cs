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
    public partial class CobTomTres : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string tasa;
            string tasa2;
            string tasa3;
            string connectionString = Conection.ConexLine;
            string query = "select SUM(TotalCobrar) from Asegurados where Cedula='" + Request.Cookies["cedulacobC"].Value + "' AND Estado='VENTA' ";


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
                            tasa = dr.GetFieldValue<decimal>(0).ToString();
                            Label37.Text = tasa;
                            
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
            //string connectionString2 = "workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB";
            //string query2 = "select Monto from Cierres where Empresa='" + Request.Cookies["emprecobnom"].Value + "' AND Tipo='EXCLUSION' AND Estado='VIGENTE' AND MONTH(Fecha)='" + Request.Cookies["emprecobmes"].Value + "'";


            //using (SqlConnection con2 = new SqlConnection(connectionString2))
            //using (SqlCommand cmd2 = new SqlCommand(query2, con2))
            //{

            //    con2.Open();


            //    using (SqlDataReader dr2 = cmd2.ExecuteReader())
            //    {

            //        if (dr2.Read())
            //        {
            //            if (dr2.IsDBNull(0))
            //            {

            //                tasa2 = "0";

            //            }
            //            else
            //            {
            //                tasa2 = dr2.GetFieldValue<decimal>(0).ToString();
            //                Label38.Text = tasa2;

            //            }


            //        }
            //        else
            //        {
            //            tasa2 = "0";

            //        }



            //        dr2.Close();
            //    }

            //    con2.Close();
            //}
            string connectionString3 = Conection.ConexLine;
            string query3 = "select SUM(ValorDebito) from Pagos where RazonSocial='" + Request.Cookies["emprecobnom"].Value + "' AND Status='VIGENTE' AND MesFacturacion='" + Request.Cookies["emprecobmes"].Value + "' AND Observaciones='" + Request.Cookies["cedulacobC"].Value + "'";


            using (SqlConnection con3 = new SqlConnection(connectionString3))
            using (SqlCommand cmd3 = new SqlCommand(query3, con3))
            {

                con3.Open();


                using (SqlDataReader dr3 = cmd3.ExecuteReader())
                {

                    if (dr3.Read())
                    {
                        if (dr3.IsDBNull(0))
                        {

                            tasa3 = "0";

                        }
                        else
                        {
                            tasa3 = dr3.GetFieldValue<decimal>(0).ToString();
                            Label39.Text = tasa3;

                        }


                    }
                    else
                    {
                        tasa3 = "0";

                    }



                    dr3.Close();
                }

                con3.Close();
            }
            Decimal tasafinal = Decimal.Parse(tasa)  - Decimal.Parse(tasa3);
            Correo.Value = tasafinal.ToString();
            Double neto = Double.Parse(tasafinal.ToString()) + (0.12 * Double.Parse(tasafinal.ToString()));
            Text1.Value = neto.ToString();
            Label33.Text = Request.Cookies["emprecobmes"].Value;


        }

        protected void PAGAR(object sender, EventArgs e)
        {
            int mes = Int32.Parse(Label33.Text) + 1;
            string empresa = Request.Cookies["emprecobnom"].Value;
            double deuda = Double.Parse(Label29.Text);
            if (deuda > 0)
            {
                using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
                {

                    string saveStaff = "INSERT INTO Pagos (RazonSocial, FormaPago, MesFacturacion, NumeroFactura, ValorFactura, ValorNotaCred, NumeroFactComi, ValorFactComi, ValorReten, NumeroReten, ValorRetenEmp, Banco, Cuenta, FechaTransf, Comprobante, ValorTransf, ValorDebito, NumeroNotaCred, Deuda, Status, Observaciones, TipoOperacion) VALUES (@RazonSocial, @FormaPago, @MesFacturacion, @NumeroFactura, @ValorFactura, @ValorNotaCred, @NumeroFactComi, @ValorFactComi, @ValorReten, @NumeroReten, @ValorRetenEmp, @Banco, @Cuenta, @FechaTransf, @Comprobante, @ValorTransf, @ValorDebito, @NumeroNotaCred, @Deuda, 'VIGENTE', @Observaciones, 'ABONO')";

                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = openCon;
                        querySaveStaff.Parameters.Add("@MesFacturacion", SqlDbType.VarChar).Value = Label33.Text;
                        querySaveStaff.Parameters.Add("@Observaciones", SqlDbType.VarChar).Value = Request.Cookies["cedulacobC"].Value;                        
                        querySaveStaff.Parameters.Add("@FormaPago", SqlDbType.VarChar).Value = Correo.Value;
                        querySaveStaff.Parameters.Add("@Deuda", SqlDbType.Money).Value = Decimal.Parse(Label29.Text);
                        querySaveStaff.Parameters.Add("@NumeroFactura", SqlDbType.VarChar).Value = "";
                        querySaveStaff.Parameters.Add("@ValorFactura", SqlDbType.VarChar).Value = Text1.Value;
                        querySaveStaff.Parameters.Add("@ValorNotaCred", SqlDbType.Money).Value = 0;
                        querySaveStaff.Parameters.Add("@NumeroFactComi", SqlDbType.VarChar).Value = "";
                        querySaveStaff.Parameters.Add("@ValorReten", SqlDbType.Money).Value = 0;
                        querySaveStaff.Parameters.Add("@NumeroReten", SqlDbType.VarChar).Value = "";
                        querySaveStaff.Parameters.Add("@ValorRetenEmp", SqlDbType.VarChar).Value = "";
                        querySaveStaff.Parameters.Add("@Banco", SqlDbType.VarChar).Value = "";
                        querySaveStaff.Parameters.Add("@Cuenta", SqlDbType.VarChar).Value = "";
                        querySaveStaff.Parameters.Add("@FechaTransf", SqlDbType.DateTime).Value = DateTime.Now;
                        querySaveStaff.Parameters.Add("@Comprobante", SqlDbType.VarChar).Value = "";
                        querySaveStaff.Parameters.Add("@ValorTransf", SqlDbType.Money).Value = Decimal.Parse(Label31.Text);
                        querySaveStaff.Parameters.Add("@ValorDebito", SqlDbType.Money).Value = Decimal.Parse(Label31.Text);
                        querySaveStaff.Parameters.Add("@ValorFactComi", SqlDbType.Money).Value = 0;
                        querySaveStaff.Parameters.Add("@NumeroNotaCred", SqlDbType.VarChar).Value = "";                         
                        querySaveStaff.Parameters.Add("@RazonSocial", SqlDbType.VarChar).Value = Request.Cookies["emprecobnom"].Value;                        
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
            else
            {
                using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
                {

                    string saveStaff = "INSERT INTO Pagos (RazonSocial, FormaPago, MesFacturacion, NumeroFactura, ValorFactura, ValorNotaCred, NumeroFactComi, ValorFactComi, ValorReten, NumeroReten, ValorRetenEmp, Banco, Cuenta, FechaTransf, Comprobante, ValorTransf, ValorDebito, NumeroNotaCred, Deuda, Status, Observaciones, TipoOperacion) VALUES (@RazonSocial, @FormaPago, @MesFacturacion, @NumeroFactura, @ValorFactura, @ValorNotaCred, @NumeroFactComi, @ValorFactComi, @ValorReten, @NumeroReten, @ValorRetenEmp, @Banco, @Cuenta, @FechaTransf, @Comprobante, @ValorTransf, @ValorDebito, @NumeroNotaCred, @Deuda, 'VIGENTE', @Observaciones, 'ABONO')";

                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = openCon;
                        querySaveStaff.Parameters.Add("@MesFacturacion", SqlDbType.VarChar).Value = Label33.Text;
                        querySaveStaff.Parameters.Add("@Observaciones", SqlDbType.VarChar).Value = Request.Cookies["cedulacobC"].Value;
                        querySaveStaff.Parameters.Add("@FormaPago", SqlDbType.VarChar).Value = Correo.Value;
                        querySaveStaff.Parameters.Add("@Deuda", SqlDbType.Money).Value = Decimal.Parse(Label29.Text);
                        querySaveStaff.Parameters.Add("@NumeroFactura", SqlDbType.VarChar).Value = "";
                        querySaveStaff.Parameters.Add("@ValorFactura", SqlDbType.VarChar).Value = Text1.Value;
                        querySaveStaff.Parameters.Add("@ValorNotaCred", SqlDbType.Money).Value = 0;
                        querySaveStaff.Parameters.Add("@NumeroFactComi", SqlDbType.VarChar).Value = "";
                        querySaveStaff.Parameters.Add("@ValorReten", SqlDbType.Money).Value = 0;
                        querySaveStaff.Parameters.Add("@NumeroReten", SqlDbType.VarChar).Value = "";
                        querySaveStaff.Parameters.Add("@ValorRetenEmp", SqlDbType.VarChar).Value = "";
                        querySaveStaff.Parameters.Add("@Banco", SqlDbType.VarChar).Value = "";
                        querySaveStaff.Parameters.Add("@Cuenta", SqlDbType.VarChar).Value = "";
                        querySaveStaff.Parameters.Add("@FechaTransf", SqlDbType.DateTime).Value = DateTime.Now;
                        querySaveStaff.Parameters.Add("@Comprobante", SqlDbType.VarChar).Value = "";
                        querySaveStaff.Parameters.Add("@ValorTransf", SqlDbType.Money).Value = Decimal.Parse(Label31.Text);
                        querySaveStaff.Parameters.Add("@ValorDebito", SqlDbType.Money).Value = Decimal.Parse(Label31.Text);
                        querySaveStaff.Parameters.Add("@ValorFactComi", SqlDbType.Money).Value = 0;
                        querySaveStaff.Parameters.Add("@NumeroNotaCred", SqlDbType.VarChar).Value = "";
                        querySaveStaff.Parameters.Add("@RazonSocial", SqlDbType.VarChar).Value = Request.Cookies["emprecobnom"].Value;
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
                //using (SqlConnection openCon = new SqlConnection("workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB"))
                //{

                //    string saveStaff = "UPDATE Cierres SET Estado = 'SALDADO' WHERE MONTH(Fecha)=@MesFacturacion AND Empresa=@RazonSocial";

                //    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                //    {
                //        querySaveStaff.Connection = openCon;
                //        querySaveStaff.Parameters.Add("@MesFacturacion", SqlDbType.VarChar).Value = Label33.Text;                        
                //        querySaveStaff.Parameters.Add("@RazonSocial", SqlDbType.VarChar).Value = Request.Cookies["emprecobnom"].Value;
                //        try
                //        {
                //            openCon.Open();
                //            querySaveStaff.ExecuteNonQuery();
                //            openCon.Close();
                //        }
                //        catch (SqlException ex)
                //        {
                //            Response.Write("Error" + ex);
                //        }
                //    }


                //}
                using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
                {

                    string saveStaff = "UPDATE Pagos SET TipoOperacion = 'SALDADO' WHERE MesFacturacion=@MesFacturacion AND Observaciones=@RazonSocial";

                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = openCon;
                        querySaveStaff.Parameters.Add("@MesFacturacion", SqlDbType.VarChar).Value = Label33.Text;
                        querySaveStaff.Parameters.Add("@RazonSocial", SqlDbType.VarChar).Value = Request.Cookies["cedulacobC"].Value;
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

        }     
        
        protected void siguiclick(object sender, EventArgs e)
        {            

            Response.Redirect("Default.aspx");
        }
        protected void siguiclickDOS(object sender, EventArgs e)
        {

            Response.Redirect("CobranzaEmpUno.aspx");
        }
        protected void calc(object sender, EventArgs e)
        {
            double cheque;
            cheque = 0;
            //if (Text3.Value == "")
            //{
            //    
            //}
            //else
            //{
            //    cheque = Double.Parse(Text3.Value);
            //}
            double cobrar = Double.Parse(Text1.Value) - cheque;
            string cadena = cobrar.ToString();
            //Text5.Value = cadena;
        }
        protected void calcdos(object sender, EventArgs e)
        {
            double cheque;
            //if (Text14.Value == "")
            //{
            //    cheque = 0;
            //}
            //else
            //{
            //    cheque = Double.Parse(Text14.Value);
            //}
            double transf;
            //if (Text20.Value == "")
            //{
            //    transf = 0;
            //}
            //else
            //{
            //    transf = Double.Parse(Text20.Value);
            //}
            double debito;
            if (Text21.Value == "")
            {
                debito = 0;
            }
            else
            {
                debito = Double.Parse(Text21.Value);
            }
            double cobrar = Double.Parse(Text1.Value);            
            double totalcobro = cobrar -  debito;
            double pago =  debito;
            Label29.Text = totalcobro.ToString();
            Label31.Text = pago.ToString();
            double deuda = cobrar - totalcobro;
        }
    }
}