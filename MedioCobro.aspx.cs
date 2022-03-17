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
    public partial class MedioCobro : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["indexC"] != null)
            {
                if (Request.Cookies["indexC"].Value == "9")
                {
                    prefifin.Text = Request.Cookies["paramTotalCert"].Value;
                    string connectionString = Conection.ConexLine;
                    string query = "Select NombreComercial, MedioDeCobro, Banco, Cuenta, Tarjeta, TipoCuenta, Vencimiento, CodigoSeguridad, NumeroTar from Asegurados where  NumeroCertificado = " + Request.Cookies["paramCert"].Value + "";


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



                                }
                                else
                                {
                                    HttpCookie indexSe = new HttpCookie("paramEmp");
                                    indexSe.Value = dr.GetFieldValue<string>(0);
                                    indexSe.Expires = DateTime.Now.AddDays(30);
                                    Response.Cookies.Add(indexSe);
                                    DropDownList1.DataBind();
                                    DropDownList1.SelectedValue = dr.GetFieldValue<string>(1);
                                    if (dr.GetFieldValue<string>(1) == "TARJETA DE CREDITO")
                                    {
                                        Label5.Attributes.Add("style", "display");
                                        Text1.Attributes.Add("style", "display");
                                        Label15.Attributes.Add("style", "display");
                                        Radio1.Attributes.Add("style", "display");
                                        Radio2.Attributes.Add("style", "display");
                                        Label7.Attributes.Add("style", "display");
                                        Text4.Attributes.Add("style", "display");
                                        Label1.Attributes.Add("style", "display");
                                        Text2.Attributes.Add("style", "display");
                                        Label2.Attributes.Add("style", "display");
                                        Text8.Attributes.Add("style", "display");
                                        Label3.Attributes.Add("style", "display");
                                        Text10.Attributes.Add("style", "display");
                                        Label8.Attributes.Add("style", "display");
                                        Text11.Attributes.Add("style", "display");
                                        if (dr.IsDBNull(2))
                                        {

                                        }
                                        else
                                        {
                                            Text1.Value = dr.GetFieldValue<string>(2);
                                        }
                                        if (dr.IsDBNull(3))
                                        {

                                        }
                                        else
                                        {
                                            Text4.Value = dr.GetFieldValue<string>(3);
                                        }
                                        if (dr.IsDBNull(4))
                                        {

                                        }
                                        else
                                        {
                                            Text2.Value = dr.GetFieldValue<string>(4);
                                        }
                                        if (dr.IsDBNull(5))
                                        {

                                        }
                                        else
                                        {
                                            if (dr.GetFieldValue<string>(5) == "AHORROS")
                                            {
                                                Radio1.Checked = true;
                                            }
                                            else
                                            {
                                                Radio2.Checked = true;
                                            }
                                        }
                                        if (dr.IsDBNull(6))
                                        {

                                        }
                                        else
                                        {
                                            Text10.Value = dr.GetFieldValue<string>(6);
                                        }
                                        if (dr.IsDBNull(7))
                                        {

                                        }
                                        else
                                        {
                                            Text11.Value = dr.GetFieldValue<string>(7);
                                        }
                                        if (dr.IsDBNull(8))
                                        {

                                        }
                                        else
                                        {
                                            Text8.Value = dr.GetFieldValue<long>(8).ToString();
                                        }
                                    }
                                    else if (dr.GetFieldValue<string>(1) == "ROL DE PAGOS")
                                    {
                                        Label5.Attributes.Add("style", "display:none");
                                        Text1.Attributes.Add("style", "display:none");
                                        Label15.Attributes.Add("style", "display:none");
                                        Radio1.Attributes.Add("style", "display:none");
                                        Radio2.Attributes.Add("style", "display:none");
                                        Label7.Attributes.Add("style", "display:none");
                                        Text4.Attributes.Add("style", "display:none");
                                        Label1.Attributes.Add("style", "display:none");
                                        Text2.Attributes.Add("style", "display:none");
                                        Label2.Attributes.Add("style", "display:none");
                                        Text8.Attributes.Add("style", "display:none");
                                        Label3.Attributes.Add("style", "display:none");
                                        Text10.Attributes.Add("style", "display:none");
                                        Label8.Attributes.Add("style", "display:none");
                                        Text11.Attributes.Add("style", "display:none");

                                    }

                             
                                }
                                


                            }
                            else
                            {


                            }



                            dr.Close();
                        }

                        con.Close();
                    }
                    Response.Cookies["indexC"].Expires = DateTime.Now.AddDays(-1);
                }
                else if (Request.Cookies["indexC"].Value == "8")
                {
                    prefifin.Text = Request.Cookies["paramTotalCert"].Value;
                    string connectionString = Conection.ConexLine;
                    string query = "Select NombreComercial, MedioDeCobro, Banco, Cuenta, Tarjeta, TipoCuenta, Vencimiento, CodigoSeguridad from Asegurados where  NumeroCertificado = " + Request.Cookies["paramCert"].Value + "";


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



                                }
                                else
                                {
                                    HttpCookie indexSe = new HttpCookie("paramEmp");
                                    indexSe.Value = dr.GetFieldValue<string>(0);
                                    indexSe.Expires = DateTime.Now.AddDays(30);
                                    Response.Cookies.Add(indexSe);
                                    DropDownList1.DataBind();
                                    DropDownList1.SelectedValue = dr.GetFieldValue<string>(1);
                                    if (dr.GetFieldValue<string>(1) == "TARJETA DE CREDITO")
                                    {
                                        Label5.Attributes.Add("style", "display");
                                        Text1.Attributes.Add("style", "display");
                                        Label15.Attributes.Add("style", "display");
                                        Radio1.Attributes.Add("style", "display");
                                        Radio2.Attributes.Add("style", "display");
                                        Label7.Attributes.Add("style", "display");
                                        Text4.Attributes.Add("style", "display");
                                        Label1.Attributes.Add("style", "display");
                                        Text2.Attributes.Add("style", "display");
                                        Label2.Attributes.Add("style", "display");
                                        Text8.Attributes.Add("style", "display");
                                        Label3.Attributes.Add("style", "display");
                                        Text10.Attributes.Add("style", "display");
                                        Label8.Attributes.Add("style", "display");
                                        Text11.Attributes.Add("style", "display");
                                        if (dr.IsDBNull(2))
                                        {

                                        }
                                        else
                                        {
                                            Text1.Value = dr.GetFieldValue<string>(2);
                                        }
                                        if (dr.IsDBNull(3))
                                        {

                                        }
                                        else
                                        {
                                            Text4.Value = dr.GetFieldValue<string>(3);
                                        }
                                        if (dr.IsDBNull(4))
                                        {

                                        }
                                        else
                                        {
                                            Text2.Value = dr.GetFieldValue<string>(4);
                                        }
                                        if (dr.IsDBNull(5))
                                        {

                                        }
                                        else
                                        {
                                            if (dr.GetFieldValue<string>(5) == "AHORROS")
                                            {
                                                Radio1.Checked = true;
                                            }
                                            else
                                            {
                                                Radio2.Checked = true;
                                            }
                                        }
                                        if (dr.IsDBNull(6))
                                        {

                                        }
                                        else
                                        {
                                            Text10.Value = dr.GetFieldValue<string>(6);
                                        }
                                        if (dr.IsDBNull(7))
                                        {

                                        }
                                        else
                                        {
                                            Text11.Value = dr.GetFieldValue<string>(7);
                                        }
                                    }
                                    else if (dr.GetFieldValue<string>(1) == "ROL DE PAGOS")
                                    {
                                        Label5.Attributes.Add("style", "display:none");
                                        Text1.Attributes.Add("style", "display:none");
                                        Label15.Attributes.Add("style", "display:none");
                                        Radio1.Attributes.Add("style", "display:none");
                                        Radio2.Attributes.Add("style", "display:none");
                                        Label7.Attributes.Add("style", "display:none");
                                        Text4.Attributes.Add("style", "display:none");
                                        Label1.Attributes.Add("style", "display:none");
                                        Text2.Attributes.Add("style", "display:none");
                                        Label2.Attributes.Add("style", "display:none");
                                        Text8.Attributes.Add("style", "display:none");
                                        Label3.Attributes.Add("style", "display:none");
                                        Text10.Attributes.Add("style", "display:none");
                                        Label8.Attributes.Add("style", "display:none");
                                        Text11.Attributes.Add("style", "display:none");

                                    }


                                }



                            }
                            else
                            {


                            }



                            dr.Close();
                        }

                        con.Close();
                    }
                    Response.Cookies["indexC"].Expires = DateTime.Now.AddDays(-1);
                }
              
                else 
                {
                    
                }
            }
                    

        }
        protected void itemSelected(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue == "TARJETA DE CREDITO")
            {
                Label5.Attributes.Add("style", "display");
                Text1.Attributes.Add("style", "display");
                Label15.Attributes.Add("style", "display");
                Radio1.Attributes.Add("style", "display");
                Radio2.Attributes.Add("style", "display");
                Label7.Attributes.Add("style", "display");
                Text4.Attributes.Add("style", "display");
                Label1.Attributes.Add("style", "display");
                Text2.Attributes.Add("style", "display");
                Label2.Attributes.Add("style", "display");
                Text8.Attributes.Add("style", "display");
                Label3.Attributes.Add("style", "display");
                Text10.Attributes.Add("style", "display");
                Label8.Attributes.Add("style", "display");
                Text11.Attributes.Add("style", "display");
                ahorros.Attributes.Add("style", "display");
                corriente.Attributes.Add("style", "display");
            }
            else if (DropDownList1.SelectedValue == "ROL DE PAGOS")
            {
                Label5.Attributes.Add("style", "display:none");
                Text1.Attributes.Add("style", "display:none");
                Label15.Attributes.Add("style", "display:none");
                Radio1.Attributes.Add("style", "display:none");
                Radio2.Attributes.Add("style", "display:none");
                Label7.Attributes.Add("style", "display:none");
                Text4.Attributes.Add("style", "display:none");
                Label1.Attributes.Add("style", "display:none");
                Text2.Attributes.Add("style", "display:none");
                Label2.Attributes.Add("style", "display:none");
                Text8.Attributes.Add("style", "display:none");
                Label3.Attributes.Add("style", "display:none");
                Text10.Attributes.Add("style", "display:none");
                Label8.Attributes.Add("style", "display:none");
                Text11.Attributes.Add("style", "display:none");
                ahorros.Attributes.Add("style", "display:none");
                corriente.Attributes.Add("style", "display:none");

            }
        }
        

        
        



        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            HttpCookie indexS = new HttpCookie("totalC");
            indexS.Value = prefifin.Text;
            indexS.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(indexS);
            string cuentatipo;
            long tarjeta;
            if (Radio1.Checked == true)
            {
                cuentatipo = "AHORROS";
            }
            else
            {
                if (Radio2.Checked == true)
                {
                    cuentatipo = "CORRIENTE";
                }
                else
                {
                    cuentatipo = "";
                }


            }
            if (Text8.Value == "")
            {
                tarjeta = 0;
            }
            else
            {
                tarjeta = Int64.Parse(Text8.Value);

            }
            using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
            {

                string saveStaff = "UPDATE Asegurados SET Banco=@Banco, Cuenta=@Cuenta, Tarjeta=@Tarjeta, TipoCuenta=@TipoCuenta, Vencimiento=@Vencimiento, CodigoSeguridad=@CodigoSeguridad, Digitador=@Digitador, NumeroTar=@NumeroTar WHERE NumeroCertificado=@NumeroCertificado";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
                    querySaveStaff.Parameters.Add("@Banco", SqlDbType.VarChar).Value = Text1.Value;
                    querySaveStaff.Parameters.Add("@Cuenta", SqlDbType.VarChar).Value = Text4.Value;
                    querySaveStaff.Parameters.Add("@Tarjeta", SqlDbType.VarChar).Value = Text2.Value;
                    querySaveStaff.Parameters.Add("@TipoCuenta", SqlDbType.VarChar).Value = cuentatipo;
                    querySaveStaff.Parameters.Add("@Vencimiento", SqlDbType.VarChar).Value = Text10.Value;
                    querySaveStaff.Parameters.Add("@NumeroTar", SqlDbType.BigInt).Value = tarjeta;
                    querySaveStaff.Parameters.Add("@CodigoSeguridad", SqlDbType.VarChar).Value = Text11.Value;
                    querySaveStaff.Parameters.Add("@Digitador", SqlDbType.VarChar).Value = Request.Cookies["nombreC"].Value;
                    querySaveStaff.Parameters.Add("@NumeroCertificado", SqlDbType.Int).Value = Int32.Parse(Request.Cookies["paramCert"].Value);
                    try
                    {
                        openCon.Open();
                        querySaveStaff.ExecuteNonQuery();
                        openCon.Close();               
                        HttpCookie indexSr = new HttpCookie("indexC");
                        indexSr.Value = "8";
                        indexSr.Expires = DateTime.Now.AddDays(30);
                        Response.Cookies.Add(indexSr);
                        Response.Redirect("InclusionCertificados.aspx");

                    }
                    catch (SqlException ex)
                    {
                        Response.Write("Error" + ex);
                    }
                }
            }

        }
        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            Response.Redirect("InclusionTomador.aspx");

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            HttpCookie indexS = new HttpCookie("indexC");
            indexS.Value = "8";
            indexS.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(indexS);
            
            Response.Redirect("AdicionSeleccion.aspx");
        }

        protected void Unnamed_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}
    
