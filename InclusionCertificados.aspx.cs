using Newtonsoft.Json;
using ReachSystem.Datos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReachSystem
{
    public partial class InclusionCertificados : Page
    {
        int certviejo;
        Double m;
        DateTime FECHA;
        protected void Page_Load(object sender, EventArgs e)
        {
            
         
            Label7.Text = Request.Cookies["paramCedula"].Value;
            Label8.Text = Request.Cookies["nombretomC"].Value;
            Label9.Text = Request.Cookies["totalC"].Value;
            if (Request.Cookies["indexC"] != null)
            {
                if (Request.Cookies["indexC"].Value == "11")
                {
                    Label10.Attributes.Add("style", "display:none");
                    Label11.Attributes.Add("style", "display:none");
                    Label5.Attributes.Add("style", "display:none");
                    Text1.Attributes.Add("style", "display:none");
                    Label12.Attributes.Add("style", "display:none");
                    Text2.Attributes.Add("style", "display:none");

                }
                else if (Request.Cookies["indexC"].Value == "2")
                {
                    Label6.Attributes.Add("style", "display:none");
                    Label11.Attributes.Add("style", "display:none");
                    Label5.Attributes.Add("style", "display:none");
                    Text1.Attributes.Add("style", "display:none");
                    Label12.Attributes.Add("style", "display:none");
                    Text2.Attributes.Add("style", "display:none");
                }
                else if (Request.Cookies["indexC"].Value == "15")
                {
                    Label6.Attributes.Add("style", "display:none");
                    Label11.Attributes.Add("style", "display:none");
                    Label5.Attributes.Add("style", "display:none");
                    Text1.Attributes.Add("style", "display:none");
                    Label12.Attributes.Add("style", "display:none");
                    Text2.Attributes.Add("style", "display:none");
                }
                else if (Request.Cookies["indexC"].Value == "3")
                {
                    Label6.Attributes.Add("style", "display:none");
                    Label11.Attributes.Add("style", "display:none");
                    Label5.Attributes.Add("style", "display:none");
                    Text1.Attributes.Add("style", "display:none");
                    Label12.Attributes.Add("style", "display:none");
                    Text2.Attributes.Add("style", "display:none");
                }
                else if (Request.Cookies["indexC"].Value == "30")
                {
                    Label6.Attributes.Add("style", "display:none");
                    Label10.Attributes.Add("style", "display:none");
                    certviejo = Int32.Parse(Request.Cookies["paramCerViejo"].Value);
                    Label5.Attributes.Add("style", "display:none");
                    Text1.Attributes.Add("style", "display:none");
                    Label12.Attributes.Add("style", "display:none");
                    Text2.Attributes.Add("style", "display:none");
                }
                else if (Request.Cookies["indexC"].Value == "8")
                {
                    FECHA = DateTime.Parse(Request.Cookies["paramFV"].Value);
                    Text2.Value = "" + FECHA.Year + "-" + FECHA.Month.ToString("00") + "-" + FECHA.Day.ToString("00") + "";
                    Label6.Attributes.Add("style", "display:none");
                    Label10.Attributes.Add("style", "display:none");
                    Label11.Attributes.Add("style", "display:none");
                    DropDownList1.Attributes.Add("style", "display:none");
                    Text1.Value = Request.Cookies["paramCert"].Value;
                    HttpCookie nombreS = new HttpCookie("indexC");
                    nombreS.Value = "9";
                    nombreS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(nombreS);

                }
            }

        }        

        

        protected void Unnamed_Click(object sender, EventArgs e)
        {
           
            if (Request.Cookies["indexC"].Value == "2")
            {
                HttpCookie nombreS = new HttpCookie("paramCert");
                nombreS.Value = DropDownList1.SelectedValue;
                nombreS.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(nombreS);
                using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
                {
                    string saveStaff = "INSERT into Asegurados (Cedula, Nombre, FechaNac, Genero, Direccion, DireccionEmpleador, Cargo, Codigo, telfcelular, telfempresa, Email, NombreComercial, FechaVigencia, MedioDeCobro, FechaEfectiva, FechaVenta, TotalCobrar, NumeroCertificado, Estado, Ejecutivo, procesoWSM) VALUES (@Cedula, @Nombre, @FechaNac, @Genero, @Direccion, @DireccionEmpleador, @Cargo, @Codigo, @telfcelular, @telfempresa, @Email, @NombreComercial, @FechaVigencia, @MedioDeCobro, @FechaEfectiva, @FechaVenta, @TotalCobrar, @NumeroCertificado, @Estado, @Ejecutivo, @procesoWSM)";

                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = openCon;
                        querySaveStaff.Parameters.Add("@Cedula", SqlDbType.VarChar).Value = Request.Cookies["paramCedula"].Value;
                        querySaveStaff.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Request.Cookies["nombretomC"].Value;
                        querySaveStaff.Parameters.Add("@FechaNac", SqlDbType.DateTime).Value = DateTime.Parse(Request.Cookies["fechanacadC"].Value);
                        querySaveStaff.Parameters.Add("@Genero", SqlDbType.VarChar).Value = Request.Cookies["generoadcC"].Value;
                        querySaveStaff.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = Request.Cookies["direccionadC"].Value;
                        querySaveStaff.Parameters.Add("@DireccionEmpleador", SqlDbType.VarChar).Value = Request.Cookies["direccionemadC"].Value;
                        querySaveStaff.Parameters.Add("@Cargo", SqlDbType.VarChar).Value = Request.Cookies["cargoadC"].Value;
                        querySaveStaff.Parameters.Add("@Codigo", SqlDbType.VarChar).Value = Request.Cookies["codigoadC"].Value;
                        querySaveStaff.Parameters.Add("@telfcelular", SqlDbType.VarChar).Value = Request.Cookies["telceladC"].Value;
                        querySaveStaff.Parameters.Add("@telfempresa", SqlDbType.VarChar).Value = Request.Cookies["telempreadC"].Value;
                        querySaveStaff.Parameters.Add("@Email", SqlDbType.VarChar).Value = Request.Cookies["emailadC"].Value;
                        querySaveStaff.Parameters.Add("@NombreComercial", SqlDbType.VarChar).Value = Request.Cookies["empresaadC"].Value;
                        querySaveStaff.Parameters.Add("@FechaVigencia", SqlDbType.DateTime).Value = DateTime.Parse("" + DateTime.Now.Year + "-" + DateTime.Now.AddMonths(1).Month + "-01");
                        querySaveStaff.Parameters.Add("@MedioDeCobro", SqlDbType.VarChar).Value = Request.Cookies["medioadC"].Value;
                        querySaveStaff.Parameters.Add("@FechaEfectiva", SqlDbType.DateTime).Value = DateTime.Parse(Request.Cookies["fechaC"].Value);
                        querySaveStaff.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DateTime.Parse(Request.Cookies["fechaC"].Value);
                        querySaveStaff.Parameters.Add("@TotalCobrar", SqlDbType.Money).Value = Double.Parse(Label9.Text);
                        querySaveStaff.Parameters.Add("@NumeroCertificado", SqlDbType.Int).Value = Int32.Parse(DropDownList1.SelectedValue);
                        querySaveStaff.Parameters.Add("@Estado", SqlDbType.VarChar).Value = "PREVENTA";
                        querySaveStaff.Parameters.Add("@Ejecutivo", SqlDbType.VarChar).Value = Request.Cookies["namescreenC"].Value;
                        querySaveStaff.Parameters.Add("@procesoWSM", SqlDbType.VarChar).Value = Request.Cookies["indexWSM"].Value;
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
                    string saveStaff = "UPDATE Dependientes SET NumeroCertificado=@NumeroCertificado, procesoWSM=@procesoWSM, NombreComercial=@NombreComercial WHERE CedulaTomador=@CedulaTomador AND FechaVenta=@FechaVenta";

                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = openCon;
                        querySaveStaff.Parameters.Add("@NumeroCertificado", SqlDbType.Int).Value = Int32.Parse(DropDownList1.SelectedValue);
                        querySaveStaff.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DateTime.Parse(Request.Cookies["fechaC"].Value);
                        querySaveStaff.Parameters.Add("@CedulaTomador", SqlDbType.BigInt).Value = Int64.Parse(Request.Cookies["paramCedula"].Value);
                        querySaveStaff.Parameters.Add("@procesoWSM", SqlDbType.VarChar).Value = Request.Cookies["indexWSM"].Value;
                        querySaveStaff.Parameters.Add("@NombreComercial", SqlDbType.VarChar).Value = Request.Cookies["empresaadC"].Value;
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
                    string saveStaff = "UPDATE Certificados SET Estado=@Estado WHERE Numero=@Numero";

                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = openCon;
                        querySaveStaff.Parameters.Add("@Numero", SqlDbType.Int).Value = Int32.Parse(DropDownList1.SelectedValue);
                        querySaveStaff.Parameters.Add("@Estado", SqlDbType.VarChar).Value = "USADO";

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
            if (Request.Cookies["indexC"].Value == "15")
            {
                HttpCookie nombreS = new HttpCookie("paramCert");
                nombreS.Value = DropDownList1.SelectedValue;
                nombreS.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(nombreS);
                using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
                {
                    string saveStaff = "INSERT into Asegurados (Cedula, Nombre, FechaNac, Genero, Direccion, DireccionEmpleador, Cargo, Codigo, telfcelular, telfempresa, Email, NombreComercial, FechaVigencia, MedioDeCobro, FechaEfectiva, FechaVenta, TotalCobrar, NumeroCertificado, Estado, Ejecutivo, procesoWSM) VALUES (@Cedula, @Nombre, @FechaNac, @Genero, @Direccion, @DireccionEmpleador, @Cargo, @Codigo, @telfcelular, @telfempresa, @Email, @NombreComercial, @FechaVigencia, @MedioDeCobro, @FechaEfectiva, @FechaVenta, @TotalCobrar, @NumeroCertificado, @Estado, @Ejecutivo, @ProcesoWSM)";

                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = openCon;
                        querySaveStaff.Parameters.Add("@Cedula", SqlDbType.VarChar).Value = Request.Cookies["paramCedula"].Value;
                        querySaveStaff.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Request.Cookies["nombretomC"].Value;
                        querySaveStaff.Parameters.Add("@FechaNac", SqlDbType.DateTime).Value = DateTime.Parse(Request.Cookies["fechanacadC"].Value);
                        querySaveStaff.Parameters.Add("@Genero", SqlDbType.VarChar).Value = Request.Cookies["generoadcC"].Value;
                        querySaveStaff.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = Request.Cookies["direccionadC"].Value;
                        querySaveStaff.Parameters.Add("@DireccionEmpleador", SqlDbType.VarChar).Value = Request.Cookies["direccionemadC"].Value;
                        querySaveStaff.Parameters.Add("@Cargo", SqlDbType.VarChar).Value = Request.Cookies["cargoadC"].Value;
                        querySaveStaff.Parameters.Add("@Codigo", SqlDbType.VarChar).Value = Request.Cookies["codigoadC"].Value;
                        querySaveStaff.Parameters.Add("@telfcelular", SqlDbType.VarChar).Value = Request.Cookies["telceladC"].Value;
                        querySaveStaff.Parameters.Add("@telfempresa", SqlDbType.VarChar).Value = Request.Cookies["telempreadC"].Value;
                        querySaveStaff.Parameters.Add("@Email", SqlDbType.VarChar).Value = Request.Cookies["emailadC"].Value;
                        querySaveStaff.Parameters.Add("@NombreComercial", SqlDbType.VarChar).Value = Request.Cookies["empresaadC"].Value;
                        querySaveStaff.Parameters.Add("@FechaVigencia", SqlDbType.DateTime).Value = DateTime.Parse("" + DateTime.Now.Year + "-" + DateTime.Now.AddMonths(1).Month + "-01");
                        querySaveStaff.Parameters.Add("@MedioDeCobro", SqlDbType.VarChar).Value = Request.Cookies["medioadC"].Value;
                        querySaveStaff.Parameters.Add("@FechaEfectiva", SqlDbType.DateTime).Value = DateTime.Parse(Request.Cookies["fechaC"].Value);
                        querySaveStaff.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DateTime.Parse(Request.Cookies["fechaC"].Value);
                        querySaveStaff.Parameters.Add("@TotalCobrar", SqlDbType.Money).Value = Double.Parse(Label9.Text);
                        querySaveStaff.Parameters.Add("@NumeroCertificado", SqlDbType.Int).Value = Int32.Parse(DropDownList1.SelectedValue);
                        querySaveStaff.Parameters.Add("@Estado", SqlDbType.VarChar).Value = "PREVENTA";
                        querySaveStaff.Parameters.Add("@Ejecutivo", SqlDbType.VarChar).Value = Request.Cookies["namescreenC"].Value;
                        querySaveStaff.Parameters.Add("@procesoWSM", SqlDbType.VarChar).Value = Request.Cookies["indexWSM"].Value;
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
                    string saveStaff = "UPDATE Dependientes SET NumeroCertificado=@NumeroCertificado, procesoWSM=@procesoWSM, NombreComercial=@NombreComercial WHERE CedulaTomador=@CedulaTomador AND FechaVenta=@FechaVenta";

                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = openCon;
                        querySaveStaff.Parameters.Add("@NumeroCertificado", SqlDbType.Int).Value = Int32.Parse(DropDownList1.SelectedValue);
                        querySaveStaff.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DateTime.Parse(Request.Cookies["fechaC"].Value);
                        querySaveStaff.Parameters.Add("@CedulaTomador", SqlDbType.BigInt).Value = Int64.Parse(Request.Cookies["paramCedula"].Value);
                        querySaveStaff.Parameters.Add("@procesoWSM", SqlDbType.VarChar).Value = Request.Cookies["indexWSM"].Value;
                        querySaveStaff.Parameters.Add("@NombreComercial", SqlDbType.VarChar).Value = Request.Cookies["empresaadC"].Value;
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
                    string saveStaff = "UPDATE Certificados SET Estado=@Estado WHERE Numero=@Numero";

                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = openCon;
                        querySaveStaff.Parameters.Add("@Numero", SqlDbType.Int).Value = Int32.Parse(DropDownList1.SelectedValue);
                        querySaveStaff.Parameters.Add("@Estado", SqlDbType.VarChar).Value = "USADO";

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
                if (Request.Cookies["indexC"].Value == "3")
                {
                    HttpCookie nombreS = new HttpCookie("paramCert");
                    nombreS.Value = DropDownList1.SelectedValue;
                    nombreS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(nombreS);
                    using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
                    {
                        string saveStaff = "INSERT into Asegurados (Cedula, Nombre, FechaNac, Genero, Direccion, DireccionEmpleador, Cargo, Codigo, telfcelular, telfempresa, Email, NombreComercial, FechaVigencia, MedioDeCobro, FechaEfectiva, FechaVenta, TotalCobrar, NumeroCertificado, Estado, Ejecutivo, procesoWSM) VALUES (@Cedula, @Nombre, @FechaNac, @Genero, @Direccion, @DireccionEmpleador, @Cargo, @Codigo, @telfcelular, @telfempresa, @Email, @NombreComercial, @FechaVigencia, @MedioDeCobro, @FechaEfectiva, @FechaVenta, @TotalCobrar, @NumeroCertificado, @Estado, @Ejecutivo, @procesoWSM)";

                        using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                        {
                            querySaveStaff.Connection = openCon;
                            querySaveStaff.Parameters.Add("@Cedula", SqlDbType.VarChar).Value = Request.Cookies["paramCedula"].Value;
                            querySaveStaff.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Request.Cookies["nombretomC"].Value;
                            querySaveStaff.Parameters.Add("@FechaNac", SqlDbType.DateTime).Value = DateTime.Parse(Request.Cookies["fechanacadC"].Value);
                            querySaveStaff.Parameters.Add("@Genero", SqlDbType.VarChar).Value = Request.Cookies["generoadcC"].Value;
                            querySaveStaff.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = Request.Cookies["direccionadC"].Value;
                            querySaveStaff.Parameters.Add("@DireccionEmpleador", SqlDbType.VarChar).Value = Request.Cookies["direccionemadC"].Value;
                            querySaveStaff.Parameters.Add("@Cargo", SqlDbType.VarChar).Value = Request.Cookies["cargoadC"].Value;
                            querySaveStaff.Parameters.Add("@Codigo", SqlDbType.VarChar).Value = Request.Cookies["codigoadC"].Value;
                            querySaveStaff.Parameters.Add("@telfcelular", SqlDbType.VarChar).Value = Request.Cookies["telceladC"].Value;
                            querySaveStaff.Parameters.Add("@telfempresa", SqlDbType.VarChar).Value = Request.Cookies["telempreadC"].Value;
                            querySaveStaff.Parameters.Add("@Email", SqlDbType.VarChar).Value = Request.Cookies["emailadC"].Value;
                            querySaveStaff.Parameters.Add("@NombreComercial", SqlDbType.VarChar).Value = Request.Cookies["empresaadC"].Value;
                            querySaveStaff.Parameters.Add("@FechaVigencia", SqlDbType.DateTime).Value = DateTime.Parse("" + DateTime.Now.Year + "-" + DateTime.Now.AddMonths(1).Month + "-01");
                            querySaveStaff.Parameters.Add("@MedioDeCobro", SqlDbType.VarChar).Value = Request.Cookies["medioadC"].Value;
                            querySaveStaff.Parameters.Add("@FechaEfectiva", SqlDbType.DateTime).Value = DateTime.Parse(Request.Cookies["fechaC"].Value);
                            querySaveStaff.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DateTime.Parse(Request.Cookies["fechaC"].Value);
                            querySaveStaff.Parameters.Add("@TotalCobrar", SqlDbType.Money).Value = Double.Parse(Label9.Text);
                            querySaveStaff.Parameters.Add("@NumeroCertificado", SqlDbType.Int).Value = Int32.Parse(DropDownList1.SelectedValue);
                            querySaveStaff.Parameters.Add("@Estado", SqlDbType.VarChar).Value = "PREVENTA";
                            querySaveStaff.Parameters.Add("@Ejecutivo", SqlDbType.VarChar).Value = Request.Cookies["namescreenC"].Value;
                            querySaveStaff.Parameters.Add("@procesoWSM", SqlDbType.VarChar).Value = Request.Cookies["indexWSM"].Value;
                            try
                            {
                                openCon.Open();
                                querySaveStaff.ExecuteNonQuery();
                                openCon.Close();
                                Response.Write("<script>alert('TOMADOR REGISTRADO')</script>");

                            }
                            catch (SqlException ex)
                            {
                                Response.Write("Error" + ex);
                            }
                        }
                    }

                    using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
                    {
                        string saveStaff = "UPDATE Dependientes SET NumeroCertificado=@NumeroCertificado, procesoWSM=@procesoWSM, NombreComercial=@NombreComercial WHERE CedulaTomador=@CedulaTomador AND FechaVenta=@FechaVenta";

                        using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                        {
                            querySaveStaff.Connection = openCon;
                            querySaveStaff.Parameters.Add("@NumeroCertificado", SqlDbType.Int).Value = Int32.Parse(DropDownList1.SelectedValue);
                            querySaveStaff.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DateTime.Parse(Request.Cookies["fechaC"].Value);
                            querySaveStaff.Parameters.Add("@CedulaTomador", SqlDbType.BigInt).Value = Int64.Parse(Request.Cookies["paramCedula"].Value);
                            querySaveStaff.Parameters.Add("@procesoWSM", SqlDbType.VarChar).Value = Request.Cookies["indexWSM"].Value;
                            querySaveStaff.Parameters.Add("@NombreComercial", SqlDbType.VarChar).Value = Request.Cookies["empresaadC"].Value;
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
                        string saveStaff = "UPDATE Certificados SET Estado=@Estado WHERE Numero=@Numero";

                        using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                        {
                            querySaveStaff.Connection = openCon;
                            querySaveStaff.Parameters.Add("@Numero", SqlDbType.Int).Value = Int32.Parse(DropDownList1.SelectedValue);
                            querySaveStaff.Parameters.Add("@Estado", SqlDbType.VarChar).Value = "USADO";

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
                else if (Request.Cookies["indexC"].Value == "30")
                {
                    HttpCookie nombreS = new HttpCookie("paramCert");
                    nombreS.Value = DropDownList1.SelectedValue;
                    nombreS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(nombreS);
                    using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
                    {
                        string saveStaff = "UPDATE Asegurados SET Estado='EXCLUIDO', FechaReemplazo=@FechaReemplazo, ProcesoWSM=@ProcesoWSM WHERE NumeroCertificado=@NumeroCertificadoViejo";

                        using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                        {
                            querySaveStaff.Connection = openCon;                            
                            querySaveStaff.Parameters.Add("@NumeroCertificadoViejo", SqlDbType.Int).Value = certviejo;
                            querySaveStaff.Parameters.Add("@FechaReemplazo", SqlDbType.DateTime).Value = DateTime.Now;
                            querySaveStaff.Parameters.Add("@procesoWSM", SqlDbType.VarChar).Value = Request.Cookies["indexWSM"].Value;
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
                        string saveStaff = "INSERT INTO Asegurados (Cedula, Nombre, FechaNac, Genero, Direccion, DireccionEmpleador, Cargo, Codigo, telfcelular, telfempresa, Email, NombreComercial, FechaVigencia, MedioDeCobro, FechaEfectiva, FechaVenta, TotalCobrar, NumeroCertificado, Estado, Ejecutivo,  procesoWSM) SELECT Cedula, Nombre, FechaNac, Genero, Direccion, DireccionEmpleador, Cargo, Codigo, telfcelular, telfempresa, Email, NombreComercial, FechaVigencia, MedioDeCobro, FechaEfectiva, @FechaVenta, @TotalCobrar, @NumeroCertificado, 'PREVENTA', @Ejecutivo, procesoWSM FROM Asegurados  WHERE NumeroCertificado=@NumeroCertificadoViejo";

                        using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                        {
                            querySaveStaff.Connection = openCon;

                            querySaveStaff.Parameters.Add("@NumeroCertificado", SqlDbType.Int).Value = Int32.Parse(DropDownList1.SelectedValue);
                            querySaveStaff.Parameters.Add("@NumeroCertificadoViejo", SqlDbType.Int).Value = certviejo;
                            querySaveStaff.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DateTime.Parse(Request.Cookies["fechaC"].Value);
                            querySaveStaff.Parameters.Add("@TotalCobrar", SqlDbType.Money).Value = Double.Parse(Label9.Text);
                            querySaveStaff.Parameters.Add("@Ejecutivo", SqlDbType.VarChar).Value = Request.Cookies["namescreenC"].Value;
                            querySaveStaff.Parameters.Add("@procesoWSM", SqlDbType.VarChar).Value = Request.Cookies["indexWSM"].Value;
                            querySaveStaff.Parameters.Add("@NombreComercial", SqlDbType.VarChar).Value = Request.Cookies["empresaadC"].Value;
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
                        string saveStaff = "UPDATE Dependientes SET NumeroCertificado=@NumeroCertificado, procesoWSM=@procesoWSM, NombreComercial=@NombreComercial WHERE (NumeroCertificado=@CertViejo AND Estado='PREVENTA') OR (NumeroCertificado=@CertViejo AND Estado='VENTA')";

                        using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                        {
                            querySaveStaff.Connection = openCon;
                            querySaveStaff.Parameters.Add("@NumeroCertificado", SqlDbType.Int).Value = Int32.Parse(DropDownList1.SelectedValue);
                            querySaveStaff.Parameters.Add("@CertViejo", SqlDbType.Int).Value = certviejo;
                            querySaveStaff.Parameters.Add("@CedulaTomador", SqlDbType.BigInt).Value = Int64.Parse(Request.Cookies["paramCedula"].Value);
                            querySaveStaff.Parameters.Add("@procesoWSM", SqlDbType.VarChar).Value = Request.Cookies["indexWSM"].Value;
                            querySaveStaff.Parameters.Add("@NombreComercial", SqlDbType.VarChar).Value = Request.Cookies["empresaadC"].Value;

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
                        string saveStaff = "UPDATE Certificados SET Estado=@Estado WHERE Numero=@Numero";

                        using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                        {
                            querySaveStaff.Connection = openCon;
                            querySaveStaff.Parameters.Add("@Numero", SqlDbType.Int).Value = Int32.Parse(DropDownList1.SelectedValue);
                            querySaveStaff.Parameters.Add("@Estado", SqlDbType.VarChar).Value = "USADO";

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
                else if (Request.Cookies["indexC"].Value == "9")
                {
                    
                    using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
                    {
                        string saveStaff = "UPDATE Asegurados SET NumeroCertificado=@NumeroCertificadoDos, FechaVenta=@FechaVenta WHERE NumeroCertificado=@NumeroCertificado";

                        using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                        {
                            querySaveStaff.Connection = openCon;
                            querySaveStaff.Parameters.Add("@NumeroCertificadoDos", SqlDbType.Money).Value = Text1.Value;
                            querySaveStaff.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DateTime.Parse(Text2.Value);
                            querySaveStaff.Parameters.Add("@NumeroCertificado", SqlDbType.Int).Value = Request.Cookies["paramCert"].Value;
                            
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
                        string saveStaff = "UPDATE Dependientes SET NumeroCertificado=@NumeroCertificadoDos, FechaVenta=@FechaVenta WHERE NumeroCertificado=@NumeroCertificado";

                        using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                        {
                            querySaveStaff.Connection = openCon;
                            querySaveStaff.Parameters.Add("@NumeroCertificadoDos", SqlDbType.Money).Value = Text1.Value;
                            querySaveStaff.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DateTime.Parse(Text2.Value);
                            querySaveStaff.Parameters.Add("@NumeroCertificado", SqlDbType.Int).Value = Request.Cookies["paramCert"].Value;
                            try
                            {
                                openCon.Open();
                                querySaveStaff.ExecuteNonQuery();
                                openCon.Close();
                                HttpCookie nombreS = new HttpCookie("paramCert");
                                nombreS.Value = Text1.Value;
                                nombreS.Expires = DateTime.Now.AddDays(30);
                                Response.Cookies.Add(nombreS);
                                HttpCookie nombreS2 = new HttpCookie("indexC");
                                nombreS2.Value = "8";
                                nombreS2.Expires = DateTime.Now.AddDays(30);
                                Response.Cookies.Add(nombreS2);
                                
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
                    HttpCookie nombreS = new HttpCookie("paramCert");
                    nombreS.Value = DropDownList1.SelectedValue;
                    nombreS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(nombreS);
                    using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
                    {
                        string saveStaff = "UPDATE Asegurados SET TotalCobrar=@TotalCobrar, Estado=@Estado, NumeroCertificado=@NumeroCertificado, Ejecutivo=@Ejecutivo, procesoWSM=@ProcesoWSM WHERE Cedula=@Cedula AND FechaVenta=@FechaVenta";

                        using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                        {
                            querySaveStaff.Connection = openCon;
                            querySaveStaff.Parameters.Add("@TotalCobrar", SqlDbType.Money).Value = Double.Parse(Label9.Text);
                            querySaveStaff.Parameters.Add("@NumeroCertificado", SqlDbType.Int).Value = Int32.Parse(DropDownList1.SelectedValue);
                            querySaveStaff.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DateTime.Parse(Request.Cookies["fechaC"].Value);
                            querySaveStaff.Parameters.Add("@Cedula", SqlDbType.BigInt).Value = Int64.Parse(Request.Cookies["paramCedula"].Value);
                            querySaveStaff.Parameters.Add("@Estado", SqlDbType.VarChar).Value = "PREVENTA";
                            querySaveStaff.Parameters.Add("@procesoWSM", SqlDbType.VarChar).Value = Request.Cookies["indexWSM"].Value;
                            querySaveStaff.Parameters.Add("@Ejecutivo", SqlDbType.VarChar).Value = Request.Cookies["namescreenC"].Value;
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
                        string saveStaff = "UPDATE Dependientes SET NumeroCertificado=@NumeroCertificado, procesoWSM=@ProcesoWSM, NombreComercial=@NombreComercial WHERE CedulaTomador=@CedulaTomador AND FechaVenta=@FechaVenta";

                        using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                        {
                            querySaveStaff.Connection = openCon;
                            querySaveStaff.Parameters.Add("@NumeroCertificado", SqlDbType.Int).Value = Int32.Parse(DropDownList1.SelectedValue);
                            querySaveStaff.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DateTime.Parse(Request.Cookies["fechaC"].Value);
                            querySaveStaff.Parameters.Add("@CedulaTomador", SqlDbType.BigInt).Value = Int64.Parse(Request.Cookies["paramCedula"].Value);
                            querySaveStaff.Parameters.Add("@procesoWSM", SqlDbType.VarChar).Value = Request.Cookies["indexWSM"].Value;
                            querySaveStaff.Parameters.Add("@NombreComercial", SqlDbType.VarChar).Value = Request.Cookies["empresaadC"].Value;
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
                        string saveStaff = "UPDATE Certificados SET Estado=@Estado WHERE Numero=@Numero";

                        using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                        {
                            querySaveStaff.Connection = openCon;
                            querySaveStaff.Parameters.Add("@Numero", SqlDbType.Int).Value = Int32.Parse(DropDownList1.SelectedValue);
                            querySaveStaff.Parameters.Add("@Estado", SqlDbType.VarChar).Value = "USADO";

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
            using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
            {
                string saveStaff = "DELETE FROM VentaTemp WHERE CedulaTomador=@Numero";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
                    querySaveStaff.Parameters.Add("@Numero", SqlDbType.BigInt).Value = Int64.Parse(Request.Cookies["paramCedula"].Value);


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

            Response.Redirect("AdjuntarCert.aspx");


        }

        protected void Unnamed_Click1(object sender, EventArgs e)
        {
            Response.Redirect("ListaTotal.aspx");
        }

        protected void Unnamed_Click2(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void Unnamed_Click3(object sender, EventArgs e)
        {
            if(Request.Cookies["indexC"] != null)
            {
                if (Request.Cookies["indexC"].Value == "9")
                {
                    HttpCookie indexS = new HttpCookie("indexC");
                    indexS.Value = "9";
                    indexS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(indexS);
                    Response.Redirect("MedioCobro.aspx");
                }
                else if (Request.Cookies["indexC"].Value == "8")
                {
                    HttpCookie indexS = new HttpCookie("indexC");
                    indexS.Value = "9";
                    indexS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(indexS);
                    Response.Redirect("MedioCobro.aspx");
                }
                else
                {
                    Response.Redirect("ListaTotal.aspx");
                }
            }            
            else
            {
                Response.Redirect("ListaTotal.aspx");
            }
            
        }
    }
}