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
    public partial class CobranzaEmpDos : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string numfact;
            string numnot;
            string tasa;
            string tasa2;
            string tasa3;
            string tasa4;
            string connectionString = Conection.ConexLine;
            string query = "select Monto from Cierres where Empresa='" + Request.Cookies["emprecobnom"].Value + "' AND Tipo='VENTA' AND Estado='VIGENTE' AND Mes='" + Request.Cookies["emprecobmes"].Value + "'";


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
            string connectionString2 = Conection.ConexLine;
            string query2 = "select Monto from Cierres where Empresa='" + Request.Cookies["emprecobnom"].Value + "' AND Tipo='EXCLUSION' AND Estado='VIGENTE' AND Mes ='" + Request.Cookies["emprecobmes"].Value + "'";


            using (SqlConnection con2 = new SqlConnection(connectionString2))
            using (SqlCommand cmd2 = new SqlCommand(query2, con2))
            {

                con2.Open();


                using (SqlDataReader dr2 = cmd2.ExecuteReader())
                {

                    if (dr2.Read())
                    {
                        if (dr2.IsDBNull(0))
                        {

                            tasa2 = "0";

                        }
                        else
                        {
                            tasa2 = dr2.GetFieldValue<decimal>(0).ToString();
                            

                        }


                    }
                    else
                    {
                        tasa2 = "0";

                    }



                    dr2.Close();
                }

                con2.Close();
            }
            string connectionString3 = Conection.ConexLine;
            string query3 = "select SUM(ValorDebito), ValorNotaCred, NumeroFactura, NumeroNotaCred from Pagos where RazonSocial='" + Request.Cookies["emprecobnom"].Value + "' AND Status='VIGENTE' AND MesFacturacion='" + Request.Cookies["emprecobmes"].Value + "' group by ValorNotaCred, NumeroFactura, NumeroNotaCred";


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
                            

                        }
                        if (dr3.IsDBNull(1))
                        {

                            
                            tasa4 = "0";

                        }
                        else
                        {
                            tasa4 = dr3.GetFieldValue<decimal>(1).ToString();


                        }
                        if (dr3.IsDBNull(2))
                        {


                            numfact = "";

                        }
                        else
                        {
                            numfact = dr3.GetFieldValue<int>(2).ToString();


                        }
                        if (dr3.IsDBNull(3))
                        {

                            numnot = "";
                            
                        }
                        else
                        {
                            numnot = dr3.GetFieldValue<string>(3);


                        }


                    }
                    else
                    {
                        tasa3 = "0";
                        tasa4 = "0";
                        numfact = "";
                        numnot = "";

                    }



                    dr3.Close();
                }

                con3.Close();
            }

            Label37.Text = (Double.Parse(tasa) + Double.Parse(tasa2)).ToString();
            Label38.Text = tasa2;
            double tasapantalla = double.Parse(Label37.Text);
            double deudapantalla = Double.Parse(tasa)  - Double.Parse(tasa3) - Double.Parse(tasa4);/* +Double.Parse(tasa2)*/
            Label39.Text = deudapantalla.ToString();
            Decimal tasafinal = Decimal.Parse(tasa); /*-Decimal.Parse(tasa2)*/
            Text1.Value = tasafinal.ToString();
            Double neto = Double.Parse(tasafinal.ToString())/1.04;
            Correo.Value = neto.ToString();
            Label33.Text = Request.Cookies["emprecobmes"].Value;
            Correo.Disabled = true;
            Text1.Disabled = true;
            Text5.Disabled = true;
            if (tasapantalla !=  deudapantalla)
            {
                Text2.Value = numfact;
                Text4.Value = numnot;
                Text3.Value = tasa4;
            }

        }

        protected void PAGAR(object sender, EventArgs e)
        {
            decimal a;
            if (Text3.Value == "")
            {
                a = 0;
            }
            else
            {
                a = Decimal.Parse(Text3.Value);
            }
            decimal b;
            if (Text8.Value == "")
            {
                b = 0;
            }
            else
            {
                b = Decimal.Parse(Text8.Value);
            }
            decimal c;
            if (Text7.Value == "")
            {
                c = 0;
            }
            else
            {
                c = Decimal.Parse(Text7.Value);
            }
            decimal d;
            if (Text20.Value == "")
            {
                d = 0;
            }
            else
            {
                d = Decimal.Parse(Text20.Value);
            }
            decimal x;
            if (Text14.Value == "")
            {
                x = 0;
            }
            else
            {
                x = Decimal.Parse(Text14.Value);
            }
            DateTime f;
            if (Text18.Value == "")
            {
                f = DateTime.Parse("01-01-2000");
            }
            else
            {
                f = DateTime.Parse(Text18.Value);
            }
            //int mes = Int32.Parse(Label33.Text) + 1;
            string empresa = Request.Cookies["emprecobnom"].Value;
            double deuda = Double.Parse(Label29.Text);
            if (deuda > 0)
            {
                using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
                {

                    string saveStaff = "INSERT INTO Pagos (RazonSocial, FormaPago, MesFacturacion, NumeroFactura, ValorFactura, ValorNotaCred, NumeroFactComi, ValorFactComi, ValorReten, NumeroReten, ValorRetenEmp, Banco, Cuenta, FechaTransf, Comprobante, ValorTransf, ValorDebito, NumeroNotaCred, Deuda, Status, NumCheque, ValorCheque, Fecha) VALUES (@RazonSocial, @FormaPago, @MesFacturacion, @NumeroFactura, @ValorFactura, @ValorNotaCred, @NumeroFactComi, @ValorFactComi, @ValorReten, @NumeroReten, @ValorRetenEmp, @Banco, @Cuenta, @FechaTransf, @Comprobante, @ValorTransf, @ValorDebito, @NumeroNotaCred, @Deuda, 'VIGENTE', @NumCheque, @ValorCheque, GETDATE())";

                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = openCon;
                        querySaveStaff.Parameters.Add("@MesFacturacion", SqlDbType.VarChar).Value = Label33.Text;
                        querySaveStaff.Parameters.Add("@FormaPago", SqlDbType.VarChar).Value = Correo.Value;
                        querySaveStaff.Parameters.Add("@Deuda", SqlDbType.Money).Value = Decimal.Parse(Label29.Text.ToString());
                        querySaveStaff.Parameters.Add("@NumeroFactura", SqlDbType.VarChar).Value = Text2.Value;
                        querySaveStaff.Parameters.Add("@ValorFactura", SqlDbType.VarChar).Value = Text1.Value;
                        querySaveStaff.Parameters.Add("@ValorNotaCred", SqlDbType.Money).Value = a;
                        querySaveStaff.Parameters.Add("@NumeroFactComi", SqlDbType.VarChar).Value = Text6.Value;
                        querySaveStaff.Parameters.Add("@ValorReten", SqlDbType.Money).Value = b;
                        querySaveStaff.Parameters.Add("@NumeroReten", SqlDbType.VarChar).Value = Text9.Value;
                        querySaveStaff.Parameters.Add("@ValorRetenEmp", SqlDbType.VarChar).Value = Text10.Value;
                        querySaveStaff.Parameters.Add("@Banco", SqlDbType.VarChar).Value = "" + Text11.Value + " " + Text16.Value + "";
                        querySaveStaff.Parameters.Add("@Cuenta", SqlDbType.VarChar).Value = ""+Text12.Value+" "+Text17.Value+"";
                        querySaveStaff.Parameters.Add("@FechaTransf", SqlDbType.DateTime).Value = f;
                        querySaveStaff.Parameters.Add("@Comprobante", SqlDbType.VarChar).Value = Text19.Value;
                        querySaveStaff.Parameters.Add("@ValorTransf", SqlDbType.Money).Value = d;
                        querySaveStaff.Parameters.Add("@ValorCheque", SqlDbType.Money).Value =  x;
                        querySaveStaff.Parameters.Add("@ValorDebito", SqlDbType.Money).Value = Decimal.Parse(Label31.Text.ToString());
                        querySaveStaff.Parameters.Add("@ValorFactComi", SqlDbType.Money).Value = c;
                        querySaveStaff.Parameters.Add("@NumCheque", SqlDbType.VarChar).Value = Text13.Value;
                        querySaveStaff.Parameters.Add("@NumeroNotaCred", SqlDbType.VarChar).Value = Text4.Value;                         
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
                using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
                {

                    string saveStaff = "UPDATE Cierres SET  Observaciones = @Observaciones WHERE Mes=@MesFacturacion AND Empresa=@RazonSocial";

                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = openCon;
                        querySaveStaff.Parameters.Add("@Observaciones", SqlDbType.VarChar).Value = Text15.Value;
                        querySaveStaff.Parameters.Add("@MesFacturacion", SqlDbType.VarChar).Value = Label33.Text;
                        querySaveStaff.Parameters.Add("@RazonSocial", SqlDbType.VarChar).Value = Request.Cookies["emprecobnom"].Value;
                        try
                        {
                            openCon.Open();
                            querySaveStaff.ExecuteNonQuery();
                            openCon.Close();
                            Response.Redirect("CobranzaEmpUno.aspx");
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

                    string saveStaff = "INSERT INTO Pagos (RazonSocial, FormaPago, MesFacturacion, NumeroFactura, ValorFactura, ValorNotaCred, NumeroFactComi, ValorFactComi, ValorReten, NumeroReten, ValorRetenEmp, Banco, Cuenta, FechaTransf, Comprobante, ValorTransf, ValorDebito, NumeroNotaCred, Deuda, Status, NumCheque, ValorCheque, Fecha) VALUES (@RazonSocial, @FormaPago, @MesFacturacion, @NumeroFactura, @ValorFactura, @ValorNotaCred, @NumeroFactComi, @ValorFactComi, @ValorReten, @NumeroReten, @ValorRetenEmp, @Banco, @Cuenta, @FechaTransf, @Comprobante, @ValorTransf, @ValorDebito, @NumeroNotaCred, @Deuda, 'VIGENTE', @NumCheque, @ValorCheque, GETDATE())";

                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = openCon;
                        querySaveStaff.Parameters.Add("@MesFacturacion", SqlDbType.VarChar).Value = Label33.Text;
                        querySaveStaff.Parameters.Add("@FormaPago", SqlDbType.VarChar).Value = Correo.Value;
                        querySaveStaff.Parameters.Add("@Deuda", SqlDbType.Money).Value = Decimal.Parse(Label29.Text.ToString());
                        querySaveStaff.Parameters.Add("@NumeroFactura", SqlDbType.VarChar).Value = Text2.Value;
                        querySaveStaff.Parameters.Add("@ValorFactura", SqlDbType.VarChar).Value = Text1.Value;
                        querySaveStaff.Parameters.Add("@ValorNotaCred", SqlDbType.Money).Value = a;
                        querySaveStaff.Parameters.Add("@NumeroFactComi", SqlDbType.VarChar).Value = Text6.Value;
                        querySaveStaff.Parameters.Add("@ValorReten", SqlDbType.Money).Value = b;
                        querySaveStaff.Parameters.Add("@NumeroReten", SqlDbType.VarChar).Value = Text9.Value;
                        querySaveStaff.Parameters.Add("@ValorRetenEmp", SqlDbType.VarChar).Value = Text10.Value;
                        querySaveStaff.Parameters.Add("@Banco", SqlDbType.VarChar).Value = "" + Text11.Value + " " + Text16.Value + "";
                        querySaveStaff.Parameters.Add("@Cuenta", SqlDbType.VarChar).Value = "" + Text12.Value + " " + Text17.Value + "";
                        querySaveStaff.Parameters.Add("@FechaTransf", SqlDbType.DateTime).Value = f;
                        querySaveStaff.Parameters.Add("@Comprobante", SqlDbType.VarChar).Value = Text19.Value;
                        querySaveStaff.Parameters.Add("@ValorTransf", SqlDbType.Money).Value = d;
                        querySaveStaff.Parameters.Add("@ValorCheque", SqlDbType.Money).Value = x;
                        querySaveStaff.Parameters.Add("@ValorDebito", SqlDbType.Money).Value = Decimal.Parse(Label31.Text.ToString());
                        querySaveStaff.Parameters.Add("@ValorFactComi", SqlDbType.Money).Value = c;
                        querySaveStaff.Parameters.Add("@NumCheque", SqlDbType.VarChar).Value = Text13.Value;
                        querySaveStaff.Parameters.Add("@NumeroNotaCred", SqlDbType.VarChar).Value = Text4.Value;
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
                using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
                {

                    string saveStaff = "UPDATE Cierres SET Estado = (Case When Estado='ABONADO' Then 'LIQUIDADO' Else 'SALDADO' End),  Observaciones = @Observaciones WHERE Mes=@MesFacturacion AND Empresa=@RazonSocial";

                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = openCon;
                        querySaveStaff.Parameters.Add("@Observaciones", SqlDbType.VarChar).Value = Text15.Value;
                        querySaveStaff.Parameters.Add("@MesFacturacion", SqlDbType.VarChar).Value = Label33.Text;                        
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
                using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
                {

                    string saveStaff = "UPDATE Pagos SET Status = 'SALDADO' WHERE MesFacturacion=@MesFacturacion AND RazonSocial=@RazonSocial";

                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = openCon;
                        querySaveStaff.Parameters.Add("@MesFacturacion", SqlDbType.VarChar).Value = Label33.Text;
                        querySaveStaff.Parameters.Add("@RazonSocial", SqlDbType.VarChar).Value = Request.Cookies["emprecobnom"].Value;
                        try
                        {
                            openCon.Open();
                            querySaveStaff.ExecuteNonQuery();
                            openCon.Close();
                            Response.Redirect("CobranzaEmpUno.aspx");
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
            double tasapantalla = double.Parse(Label37.Text);
            double deudapantalla = double.Parse(Label39.Text);
            if (tasapantalla != deudapantalla)
            {
                double cheque;
                double deuda;

                double cobrar = Double.Parse(Label39.Text);
                string cadena = cobrar.ToString();
                deuda = double.Parse(Label39.Text);
                Label39.Text = (deuda).ToString();
                Text5.Value = cadena.ToString();
            }
            else
            {
                double cheque;
                double deuda;
                if (Text3.Value == "")
                {
                    cheque = 0;
                }
                else
                {
                    cheque = Double.Parse(Text3.Value);
                }
                double cobrar = Double.Parse(Label39.Text) - cheque;
                string cadena = cobrar.ToString();
                deuda = double.Parse(Label39.Text);
                Label39.Text = (deuda - cheque).ToString();
                Text5.Value = cadena.ToString();
            }
               
        }
        protected void calcdos(object sender, EventArgs e)
        {
            double cheque;
            if (Text14.Value == "")
            {
                cheque = 0;
            }
            else
            {
                cheque = Double.Parse(Text14.Value);
            }
            double transf;
            if (Text20.Value == "")
            {
                transf = 0;
            }
            else
            {
                transf = Double.Parse(Text20.Value);
            }
            double debito;
            if (Text21.Value == "")
            {
                debito = 0;
            }
            else
            {
                debito = Double.Parse(Text21.Value);
            }
            double comision;
            if (Text7.Value == "")
            {
                comision = 0;
            }
            else
            {
                comision = Double.Parse(Text7.Value);
            }
            double reten;
            if (Text8.Value == "")
            {
                reten = 0;
            }
            else
            {
                reten = Double.Parse(Text8.Value);
            }
            double retenemp;
            if (Text10.Value == "")
            {
                retenemp = 0;
            }
            else
            {
                retenemp = Double.Parse(Text10.Value);
            }
            double cobrar = Double.Parse(Text5.Value);            
            double totalcobro = cobrar - (cheque + transf + debito + comision - reten + retenemp);
            double pago = cheque + transf + debito + comision - reten + retenemp;
            Label29.Text = totalcobro.ToString();
            Label31.Text = pago.ToString();
            double deuda = cobrar - totalcobro;
        }
    }
}