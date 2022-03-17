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
    public partial class RecDos : Page
    {
        string tasa;
        protected void Page_Load(object sender, EventArgs e)
        {
            Label2.Text = Request.Cookies["emprecobnom"].Value;
            Label33.Text = Request.Cookies["emprecobmes"].Value;
            

        }

        protected void PAGAR(object sender, EventArgs e)
        {
            using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
            {

                string saveStaff = "UPDATE Cierres SET  Documentos = @Documentos WHERE Mes=@MesFacturacion AND Empresa=@RazonSocial";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
                    querySaveStaff.Parameters.Add("@Documentos", SqlDbType.VarChar).Value = "RECIBIDO";
                    
                    querySaveStaff.Parameters.Add("@MesFacturacion", SqlDbType.VarChar).Value = Label33.Text;
                    querySaveStaff.Parameters.Add("@RazonSocial", SqlDbType.VarChar).Value = Request.Cookies["emprecobnom"].Value;
                    try
                    {
                        openCon.Open();
                        querySaveStaff.ExecuteNonQuery();
                        openCon.Close();
                        Page.RegisterStartupScript("LoadFunction", "<script type='text/javascript'>alert('REGISTRO COMPLETADO CON EXITO');window.location='Recepcion.aspx'</script>");
                    }
                    catch (SqlException ex)
                    {
                        Response.Write("Error" + ex);
                    }
                }


            }







        }
        protected void PAGARDOS(object sender, EventArgs e)
        {
            using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
            {

                string saveStaff = "UPDATE Cierres SET  Listado = @Listado WHERE Mes=@MesFacturacion AND Empresa=@RazonSocial";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
                    querySaveStaff.Parameters.Add("@Listado", SqlDbType.VarChar).Value = "RECIBIDO";

                    querySaveStaff.Parameters.Add("@MesFacturacion", SqlDbType.VarChar).Value = Label33.Text;
                    querySaveStaff.Parameters.Add("@RazonSocial", SqlDbType.VarChar).Value = Request.Cookies["emprecobnom"].Value;
                    try
                    {
                        openCon.Open();
                        querySaveStaff.ExecuteNonQuery();
                        openCon.Close();
                        Page.RegisterStartupScript("LoadFunction", "<script type='text/javascript'>alert('REGISTRO COMPLETADO CON EXITO');window.location='Recepcion.aspx'</script>");
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

            Response.Redirect("Recepcion.aspx");
        }
        protected void calc(object sender, EventArgs e)
        {
            //double cheque;
            //if (Text2.Value == "")
            //{
            //    cheque = 0;
            //}
            //else
            //{
            //    cheque = Double.Parse(Text2.Value);
            //}
            //double cobrar = Double.Parse(Correo.Value) - cheque;
            //string cadena = cobrar.ToString();
            //Text3 .Value = cadena;
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