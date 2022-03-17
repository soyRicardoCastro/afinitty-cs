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
    public partial class LiquiDos : Page
    {
        string tasa;
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = Conection.ConexLine;
            string query = "select Monto from Cierres where Empresa='" + Request.Cookies["emprecobnom"].Value + "' AND Tipo='VENTA' AND Estado <> 'LIQUIDADO' AND Mes='" + Request.Cookies["emprecobmes"].Value + "'";


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
                            Label33.Text = Request.Cookies["emprecobmes"].Value;
                            Text5.Value = tasa;
                            Double neto = Double.Parse(tasa.ToString()) / 1.04;
                            Correo.Value = neto.ToString();
                            
                            Text5.Disabled = true;
                            Text3.Disabled = true;
                            Text1.Disabled = true;
                            Text4.Disabled = true;
                            Correo.Disabled = true;


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

            Text1.Value = "15%";

        }

        protected void PAGAR(object sender, EventArgs e)
        {
            using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
            {

                string saveStaff = "UPDATE Cierres SET  Diferencia = @Diferencia, Comision=@Comision, FechaRec=@FechaRec, FechaPre=@FechaPre, PrimaNetaAseg=@PrimaNetaAseg, PrimaNeta=@PrimaNeta, Estado=(Case When Estado='VIGENTE' Then 'ABONADO' Else 'LIQUIDADO' End) WHERE Mes=@MesFacturacion AND Empresa=@RazonSocial";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
                    querySaveStaff.Parameters.Add("@Diferencia", SqlDbType.Money).Value = Decimal.Parse(Text3.Value);
                    querySaveStaff.Parameters.Add("@Comision", SqlDbType.Money).Value = Decimal.Parse(Text4.Value);
                    querySaveStaff.Parameters.Add("@FechaRec", SqlDbType.DateTime).Value = DateTime.Parse(Text6.Value);
                    querySaveStaff.Parameters.Add("@FechaPre", SqlDbType.DateTime).Value = DateTime.Parse(Text7.Value);
                    querySaveStaff.Parameters.Add("@PrimaNeta", SqlDbType.Money).Value = Decimal.Parse(Correo.Value);
                    querySaveStaff.Parameters.Add("@PrimaNetaAseg", SqlDbType.Money).Value = Decimal.Parse(Text2.Value);
                    querySaveStaff.Parameters.Add("@MesFacturacion", SqlDbType.VarChar).Value = Label33.Text;
                    querySaveStaff.Parameters.Add("@RazonSocial", SqlDbType.VarChar).Value = Request.Cookies["emprecobnom"].Value;
                    try
                    {
                        openCon.Open();
                        querySaveStaff.ExecuteNonQuery();
                        openCon.Close();
                        Page.RegisterStartupScript("LoadFunction", "<script type='text/javascript'>alert('REGISTRO COMPLETADO CON EXITO');window.location='Liquidaciones.aspx'</script>");
                    }
                    catch (SqlException ex)
                    {
                        Response.Write("Error" + ex);
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

            Response.Redirect("Liquidaciones.aspx");
        }
        protected void calc(object sender, EventArgs e)
        {
            double cheque;
            if (Text2.Value == "")
            {
                cheque = 0;
            }
            else
            {
                cheque = Double.Parse(Text2.Value);

            }
            Double comi = Double.Parse(Text2.Value) * 0.15;
            Text4.Value = comi.ToString();
            double cobrar = Double.Parse(Correo.Value) - cheque;
            string cadena = cobrar.ToString();
            Text3 .Value = cadena;
        }
        protected void calcdos(object sender, EventArgs e)
        {
            //double cheque;
            //if (Text14.Value == "")
            //{
            //    cheque = 0;
            //}
            //else
            //{
            //    cheque = Double.Parse(Text14.Value);
            //}
            //double transf;
            //if (Text20.Value == "")
            //{
            //    transf = 0;
            //}
            //else
            //{
            //    transf = Double.Parse(Text20.Value);
            //}
            //double debito;
            //if (Text21.Value == "")
            //{
            //    debito = 0;
            //}
            //else
            //{
            //    debito = Double.Parse(Text21.Value);
            //}
            //double comision;
            //if (Text7.Value == "")
            //{
            //    comision = 0;
            //}
            //else
            //{
            //    comision = Double.Parse(Text7.Value);
            //}
            //double reten;
            //if (Text8.Value == "")
            //{
            //    reten = 0;
            //}
            //else
            //{
            //    reten = Double.Parse(Text8.Value);
            //}
            //double retenemp;
            //if (Text10.Value == "")
            //{
            //    retenemp = 0;
            //}
            //else
            //{
            //    retenemp = Double.Parse(Text10.Value);
            //}
            //double cobrar = Double.Parse(Text5.Value);            
            //double totalcobro = cobrar - (cheque + transf + debito + comision - reten + retenemp);
            //double pago = cheque + transf + debito + comision - reten + retenemp;
            //Label29.Text = totalcobro.ToString();
            //Label31.Text = pago.ToString();
            //double deuda = cobrar - totalcobro;
        }
    }
}