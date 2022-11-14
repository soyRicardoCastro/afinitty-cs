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
    public partial class InclusionTomador : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.Cookies["indexC"] != null)
            {
                if(Request.Cookies["indexC"].Value == "9")
                {
                    Label6.Attributes.Add("style", "display:none");
                    Label16.Attributes.Add("style", "display:none");
                    Text14.Attributes.Add("style", "display:none");
                    //Label15.Attributes.Add("style", "display:none");
                    //Text13.Attributes.Add("style", "display:none");
                    //Radio1.Attributes.Add("style", "display:none");
                    DateTime FECHA = DateTime.Parse(Request.Cookies["fechanacadC"].Value);
                    Correo.Value = Request.Cookies["paramCedula"].Value;
                    Text1.Value = Request.Cookies["nombretomC"].Value;
                    Text2.Value = "" + FECHA.Year + "-" + FECHA.Month.ToString("00") + "-" + FECHA.Day.ToString("00") + "";
                    DropDownList1.SelectedValue = Request.Cookies["generoadcC"].Value;
                    DropDownList3.SelectedValue = Request.Cookies["empresaadC"].Value;
                    string fijador = Request.Cookies["empresaadC"].Value;
                    if (!IsPostBack)
                    {
                        SqlConnection con = new SqlConnection(Conection.ConexLine);
                        SqlCommand cmd = new SqlCommand("SELECT DISTINCT Medio FROM Medios WHERE NombreComercial = '" + fijador + "'", con);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        DropDownList2.DataSource = dt;
                        DropDownList2.DataBind();
                    }

                    DropDownList2.SelectedValue = Request.Cookies["medioadC"].Value;
                    Text6.Value = Request.Cookies["direccionemadC"].Value;
                    Text7.Value = Request.Cookies["cargoadC"].Value;
                    Text5.Value = Request.Cookies["direccionadC"].Value;
                    Text8.Value = Request.Cookies["codigoadC"].Value;
                    Text9.Value = Request.Cookies["telceladC"].Value;
                    Text10.Value = Request.Cookies["telempreadC"].Value;
                    Text11.Value = Request.Cookies["emailadC"].Value;
                    Domicilio.Value = Request.Cookies["paramDomi"].Value;
                    DateTime FechaVig = DateTime.Parse(Request.Cookies["paramVig"].Value);
                    Text14.Value = "" + FechaVig.Year.ToString() + "-" + FechaVig.Month.ToString("00") + "-" + FechaVig.Day.ToString("00") + "";
                    string connectionString2 = Conection.ConexLine;
                    string query2 = "SELECT  Cedula FROM Dependientes where Cedula=" + Request.Cookies["paramCedula"].Value + " AND NumeroCertificado = "+ Request.Cookies["paramCert"].Value +"";


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
                                    Radio1.Checked = true;
                                }
                                else
                                {
                                    Text13.Checked = true;
                                }
                            }
                            else
                            {
                                Radio1.Checked = true;
                            }
                               

                            dr2.Close();
                        }

                        con2.Close();
                    }
                    
                    if (!IsPostBack)
                    {
                        SqlConnection con = new SqlConnection(Conection.ConexLine);
                        SqlCommand cmd = new SqlCommand("select NombreComercial from Empresa order by NombreComercial asc ", con);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        DropDownList3.DataSource = dt;
                        DropDownList3.DataBind();

                    }
                    //Response.Cookies["medioadC"].Expires = DateTime.Now.AddDays(-1);
                    //Response.Cookies["direccionemadC"].Expires = DateTime.Now.AddDays(-1);
                    //Response.Cookies["cargoadC"].Expires = DateTime.Now.AddDays(-1);
                    //Response.Cookies["telceladC"].Expires = DateTime.Now.AddDays(-1);
                    //Response.Cookies["telempreadC"].Expires = DateTime.Now.AddDays(-1);
                    //Response.Cookies["codigoadC"].Expires = DateTime.Now.AddDays(-1);
                    //Response.Cookies["direccionadC"].Expires = DateTime.Now.AddDays(-1);
                    //Response.Cookies["emailadC"].Expires = DateTime.Now.AddDays(-1);

                    //Response.Cookies["paramVig"].Expires = DateTime.Now.AddDays(-1);
                    //Response.Cookies["paramDomi"].Expires = DateTime.Now.AddDays(-1);

                    //Response.Cookies["fechanacadC"].Expires = DateTime.Now.AddDays(-1);
                    //Response.Cookies["paramCedulaD"].Expires = DateTime.Now.AddDays(-1);
                    //Response.Cookies["nombreadC"].Expires = DateTime.Now.AddDays(-1);
                    //Response.Cookies["generotomC"].Expires = DateTime.Now.AddDays(-1);
                    //Response.Cookies["empresaadC"].Expires = DateTime.Now.AddDays(-1);
                    
                    Response.Cookies["indexC"].Expires = DateTime.Now.AddDays(-1);

                    HttpCookie indexS = new HttpCookie("indexC");
                    indexS.Value = "8";
                    indexS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(indexS);

                    Response.Cookies["paramCedula"].Expires = DateTime.Now.AddDays(-1);

                    

                }
                else
                {
                    if (Request.Cookies["paramCedula"] != null)
                    {

                    }
                    else
                    {
                        HttpCookie indexS2 = new HttpCookie("paramCedula");
                        indexS2.Value = Correo.Value;
                        indexS2.Expires = DateTime.Now.AddDays(30);
                        Response.Cookies.Add(indexS2);
                    }





                    Correo.Value = Request.Cookies["paramCedula"].Value;


                    Label5.Attributes.Add("style", "display:none");
                    //Text14.Value = "" + DateTime.Now.Year + "-" + DateTime.Now.AddMonths(1).Month + "-01";
                    DropDownList2.Enabled = false;
                    if (!IsPostBack)
                    {
                        SqlConnection con = new SqlConnection(Conection.ConexLine);
                        SqlCommand cmd = new SqlCommand("select NombreComercial from Empresa", con);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        DropDownList3.DataSource = dt;
                        DropDownList3.DataBind();

                    }
                }
            }
            else
            {
             

                Label5.Attributes.Add("style", "display:none");
                Correo.Value = Request.Cookies["paramCedula"].Value;

                HttpCookie indexS2 = new HttpCookie("paramCedula");
                indexS2.Value = Correo.Value;
                indexS2.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(indexS2);
                Label5.Attributes.Add("style", "display:none");
                //Text14.Value = "" + DateTime.Now.Year + "-" + DateTime.Now.AddMonths(1).Month + "-01";
                DropDownList2.Enabled = false;
                if (!IsPostBack)
                {
                    SqlConnection con = new SqlConnection(Conection.ConexLine);
                    SqlCommand cmd = new SqlCommand("select NombreComercial from Empresa", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    DropDownList3.DataSource = dt;
                    DropDownList3.DataBind();

                }
            }
            
        }
        
        protected void fijarempresa(object sender, EventArgs e)
        {
            DropDownList2.Items.Clear();
            DropDownList2.Items.Add("MEDIO DE COBRO");

            SqlConnection con = new SqlConnection(Conection.ConexLine);
            SqlCommand cmd = new SqlCommand("select Medio from Medios where NombreComercial = '" + DropDownList3.SelectedValue + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DropDownList2.DataSource = dt;
            DropDownList2.DataBind();
            DropDownList2.Enabled = true;
            HttpCookie nombretomS = new HttpCookie("empresaadC");
            nombretomS.Value = DropDownList3.SelectedValue;
            nombretomS.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(nombretomS);

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
        protected void Unnamed4_Click(object sender, EventArgs e)
        {
            if(Request.Cookies["indexC"] != null)
            {
                if (Request.Cookies["indexC"].Value == "8")
                {
                    Response.Redirect("ProcCert.aspx");
                }
                else
                {
                    Response.Redirect("InicioProceso.aspx");
                }
            }
            else
            {
                Response.Redirect("InicioProceso.aspx");
            }
            
        }

        protected void Unnamed_Click1(object sender, EventArgs e)
        {
            HttpCookie perfilS7 = new HttpCookie("fechanactomC");
            perfilS7.Value = Text2.Value;
            perfilS7.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(perfilS7);
            if (Request.Cookies["indexC"] != null)
            {
                if (Request.Cookies["indexC"].Value == "8")
                {
                    HttpCookie indexS2 = new HttpCookie("paramCedula");
                    indexS2.Value = Correo.Value;
                    indexS2.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(indexS2);

                    HttpCookie fechavigS = new HttpCookie("fechavigC");
                    fechavigS.Value = Text14.Value;
                    fechavigS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(fechavigS);

                    HttpCookie nombretomS = new HttpCookie("nombretomC");
                    nombretomS.Value = Text1.Value;
                    nombretomS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(nombretomS);
                    if (Text13.Checked == true)
                    {                        

                        HttpCookie idclienteS = new HttpCookie("generotomC");
                        idclienteS.Value = DropDownList1.SelectedValue;
                        idclienteS.Expires = DateTime.Now.AddDays(30);
                        Response.Cookies.Add(idclienteS);

                        HttpCookie perfilS = new HttpCookie("fechanacC");
                        perfilS.Value = Text2.Value;
                        perfilS.Expires = DateTime.Now.AddDays(30);
                        Response.Cookies.Add(perfilS);
                        

                        

                    }
                    using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
                    {
                        string saveStaff = "UPDATE Dependientes SET CedulaTomador=@Cedula WHERE NumeroCertificado=@NumeroCertificado";

                        using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                        {
                            querySaveStaff.Connection = openCon;
                            querySaveStaff.Parameters.Add("@Cedula", SqlDbType.BigInt).Value = Int64.Parse(Correo.Value);                            
                            querySaveStaff.Parameters.Add("@NumeroCertificado", SqlDbType.Int).Value = Int32.Parse(Request.Cookies["paramCert"].Value);
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
                        string saveStaff = "UPDATE Asegurados SET Cedula=@Cedula, Nombre=@Nombre, FechaNac=@FechaNac, Genero=@Genero, Direccion=@Direccion, DireccionEmpleador=@DireccionEmpleador, Cargo=@Cargo, Codigo=@Codigo, telfcelular=@telfcelular, telfempresa=@telfempresa, Email=@Email, NombreComercial=@NombreComercial, FechaVigencia=@FechaVigencia, MedioDeCobro=@MedioDeCobro, FechaEfectiva=@FechaEfectiva, FechaVenta=@FechaVenta, telfdomicilio=@telfdomicilio WHERE NumeroCertificado=@NumeroCertificado";

                        using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                        {
                            querySaveStaff.Connection = openCon;
                            querySaveStaff.Parameters.Add("@Cedula", SqlDbType.BigInt).Value = Int64.Parse(Correo.Value);
                            querySaveStaff.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Text1.Value;
                            querySaveStaff.Parameters.Add("@FechaNac", SqlDbType.DateTime).Value = DateTime.Parse(Text2.Value);
                            querySaveStaff.Parameters.Add("@Genero", SqlDbType.VarChar).Value = DropDownList1.SelectedValue;
                            querySaveStaff.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = Text5.Value;
                            querySaveStaff.Parameters.Add("@DireccionEmpleador", SqlDbType.VarChar).Value = Text6.Value;
                            querySaveStaff.Parameters.Add("@Cargo", SqlDbType.VarChar).Value = Text7.Value;
                            querySaveStaff.Parameters.Add("@Codigo", SqlDbType.VarChar).Value = Text8.Value;
                            querySaveStaff.Parameters.Add("@telfcelular", SqlDbType.VarChar).Value = Text9.Value;
                            querySaveStaff.Parameters.Add("@telfempresa", SqlDbType.VarChar).Value = Text10.Value;
                            querySaveStaff.Parameters.Add("@telfdomicilio", SqlDbType.VarChar).Value = Domicilio.Value;
                            querySaveStaff.Parameters.Add("@Email", SqlDbType.VarChar).Value = Text11.Value;
                            querySaveStaff.Parameters.Add("@NombreComercial", SqlDbType.VarChar).Value = DropDownList3.SelectedValue; ;
                            querySaveStaff.Parameters.Add("@FechaVigencia", SqlDbType.DateTime).Value = DateTime.Parse(Text14.Value);
                            querySaveStaff.Parameters.Add("@MedioDeCobro", SqlDbType.VarChar).Value = DropDownList2.SelectedValue;
                            querySaveStaff.Parameters.Add("@FechaEfectiva", SqlDbType.DateTime).Value = DateTime.Parse(Text14.Value);
                            querySaveStaff.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DateTime.Parse(Request.Cookies["fechaC"].Value);
                            querySaveStaff.Parameters.Add("@NumeroCertificado", SqlDbType.Int).Value = Int32.Parse(Request.Cookies["paramCert"].Value);
                            try
                            {
                                openCon.Open();
                                querySaveStaff.ExecuteNonQuery();
                                openCon.Close();
                                Response.Write("<script>alert('TOMADOR PROCESADO')</script>");
                                Response.Redirect("AdicionSeleccion.aspx");                            }
                            catch (SqlException ex)
                            {
                                Response.Write("Error" + ex);
                            }
                        }
                    }
                }
                else
                {
                    HttpCookie fechavigS = new HttpCookie("fechavigC");
                    fechavigS.Value = Text14.Value;
                    fechavigS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(fechavigS);

                    HttpCookie nombretomS = new HttpCookie("nombretomC");
                    nombretomS.Value = Text1.Value;
                    nombretomS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(nombretomS);
                    if (Text13.Checked == true)
                    {
                        HttpCookie indexS = new HttpCookie("indexC");
                        indexS.Value = "1";
                        indexS.Expires = DateTime.Now.AddDays(30);
                        Response.Cookies.Add(indexS);

                        HttpCookie idclienteS = new HttpCookie("generotomC");
                        idclienteS.Value = DropDownList1.SelectedValue;
                        idclienteS.Expires = DateTime.Now.AddDays(30);
                        Response.Cookies.Add(idclienteS);

                        HttpCookie perfilS = new HttpCookie("fechanacC");
                        perfilS.Value = Text2.Value;
                        perfilS.Expires = DateTime.Now.AddDays(30);
                        Response.Cookies.Add(perfilS);

                        HttpCookie perfilS2 = new HttpCookie("indexTOM");
                        perfilS2.Value = "1";
                        perfilS2.Expires = DateTime.Now.AddDays(30);
                        Response.Cookies.Add(perfilS2);

                    }
                    else
                    {
                        HttpCookie perfilS2 = new HttpCookie("indexTOM");
                        perfilS2.Value = "2";
                        perfilS2.Expires = DateTime.Now.AddDays(30);
                        Response.Cookies.Add(perfilS2);
                    }
                    using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
                    {

                        string saveStaff = "INSERT into Asegurados (Cedula, Nombre, FechaNac, Genero, Direccion, DireccionEmpleador, Cargo, Codigo, telfcelular, telfempresa, Email, NombreComercial, FechaVigencia, MedioDeCobro, FechaEfectiva, FechaVenta, telfdomicilio) VALUES (@Cedula, @Nombre, @FechaNac, @Genero, @Direccion, @DireccionEmpleador, @Cargo, @Codigo, @telfcelular, @telfempresa, @Email, @NombreComercial, @FechaVigencia, @MedioDeCobro, @FechaEfectiva, @FechaVenta, @telfdomicilio)";

                        using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                        {
                            querySaveStaff.Connection = openCon;
                            querySaveStaff.Parameters.Add("@Cedula", SqlDbType.BigInt).Value = Int64.Parse(Correo.Value);
                            querySaveStaff.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Text1.Value;
                            querySaveStaff.Parameters.Add("@FechaNac", SqlDbType.DateTime).Value = DateTime.Parse(Text2.Value);
                            querySaveStaff.Parameters.Add("@Genero", SqlDbType.VarChar).Value = DropDownList1.SelectedValue;
                            querySaveStaff.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = Text5.Value;
                            querySaveStaff.Parameters.Add("@DireccionEmpleador", SqlDbType.VarChar).Value = Text6.Value;
                            querySaveStaff.Parameters.Add("@Cargo", SqlDbType.VarChar).Value = Text7.Value;
                            querySaveStaff.Parameters.Add("@Codigo", SqlDbType.VarChar).Value = Text8.Value;
                            querySaveStaff.Parameters.Add("@telfcelular", SqlDbType.VarChar).Value = Text9.Value;
                            querySaveStaff.Parameters.Add("@telfempresa", SqlDbType.VarChar).Value = Text10.Value;
                            querySaveStaff.Parameters.Add("@telfdomicilio", SqlDbType.VarChar).Value = Domicilio.Value;
                            querySaveStaff.Parameters.Add("@Email", SqlDbType.VarChar).Value = Text11.Value;
                            querySaveStaff.Parameters.Add("@NombreComercial", SqlDbType.VarChar).Value = DropDownList3.SelectedValue; ;
                            querySaveStaff.Parameters.Add("@FechaVigencia", SqlDbType.DateTime).Value = DateTime.Parse(Text14.Value);
                            querySaveStaff.Parameters.Add("@MedioDeCobro", SqlDbType.VarChar).Value = DropDownList2.SelectedValue;
                            querySaveStaff.Parameters.Add("@FechaEfectiva", SqlDbType.DateTime).Value = DateTime.Parse(Text14.Value);
                            querySaveStaff.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DateTime.Parse(Request.Cookies["fechaC"].Value);
                            try
                            {
                                openCon.Open();
                                querySaveStaff.ExecuteNonQuery();
                                openCon.Close();
                                Response.Write("<script>alert('TOMADOR REGISTRADO')</script>");
                                Response.Redirect("InclusionAegurados.aspx");
                            }
                            catch (SqlException ex)
                            {
                                Response.Write("Error" + ex);
                            }
                        }
                    }
                }
            }
            else
            {
                HttpCookie fechavigS = new HttpCookie("fechavigC");
                fechavigS.Value = Text14.Value;
                fechavigS.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(fechavigS);

                HttpCookie nombretomS = new HttpCookie("nombretomC");
                nombretomS.Value = Text1.Value;
                nombretomS.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(nombretomS);
                if (Text13.Checked == true)
                {
                    HttpCookie indexS = new HttpCookie("indexC");
                    indexS.Value = "1";
                    indexS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(indexS);

                    HttpCookie idclienteS = new HttpCookie("generotomC");
                    idclienteS.Value = DropDownList1.SelectedValue;
                    idclienteS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(idclienteS);

                    HttpCookie perfilS = new HttpCookie("fechanacC");
                    perfilS.Value = Text2.Value;
                    perfilS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(perfilS);

                    

                }
                using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
                {

                    string saveStaff = "INSERT into Asegurados (Cedula, Nombre, FechaNac, Genero, Direccion, DireccionEmpleador, Cargo, Codigo, telfcelular, telfempresa, Email, NombreComercial, FechaVigencia, MedioDeCobro, FechaEfectiva, FechaVenta, telfdomicilio) VALUES (@Cedula, @Nombre, @FechaNac, @Genero, @Direccion, @DireccionEmpleador, @Cargo, @Codigo, @telfcelular, @telfempresa, @Email, @NombreComercial, @FechaVigencia, @MedioDeCobro, @FechaEfectiva, @FechaVenta, @telfdomicilio)";

                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = openCon;
                        querySaveStaff.Parameters.Add("@Cedula", SqlDbType.BigInt).Value = Int64.Parse(Correo.Value);
                        querySaveStaff.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Text1.Value;
                        querySaveStaff.Parameters.Add("@FechaNac", SqlDbType.DateTime).Value = DateTime.Parse(Text2.Value);
                        querySaveStaff.Parameters.Add("@Genero", SqlDbType.VarChar).Value = DropDownList1.SelectedValue;
                        querySaveStaff.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = Text5.Value;
                        querySaveStaff.Parameters.Add("@DireccionEmpleador", SqlDbType.VarChar).Value = Text6.Value;
                        querySaveStaff.Parameters.Add("@Cargo", SqlDbType.VarChar).Value = Text7.Value;
                        querySaveStaff.Parameters.Add("@Codigo", SqlDbType.VarChar).Value = Text8.Value;
                        querySaveStaff.Parameters.Add("@telfcelular", SqlDbType.VarChar).Value = Text9.Value;
                        querySaveStaff.Parameters.Add("@telfempresa", SqlDbType.VarChar).Value = Text10.Value;
                        querySaveStaff.Parameters.Add("@telfdomicilio", SqlDbType.VarChar).Value = Domicilio.Value;
                        querySaveStaff.Parameters.Add("@Email", SqlDbType.VarChar).Value = Text11.Value;
                        querySaveStaff.Parameters.Add("@NombreComercial", SqlDbType.VarChar).Value = DropDownList3.SelectedValue; ;
                        querySaveStaff.Parameters.Add("@FechaVigencia", SqlDbType.DateTime).Value = DateTime.Parse(Text14.Value);
                        querySaveStaff.Parameters.Add("@MedioDeCobro", SqlDbType.VarChar).Value = DropDownList2.SelectedValue;
                        querySaveStaff.Parameters.Add("@FechaEfectiva", SqlDbType.DateTime).Value = DateTime.Parse(Text14.Value);
                        querySaveStaff.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DateTime.Parse(Request.Cookies["fechaC"].Value);
                        try
                        {
                            openCon.Open();
                            querySaveStaff.ExecuteNonQuery();
                            openCon.Close();
                            Response.Write("<script>alert('TOMADOR REGISTRADO')</script>");
                            Response.Redirect("InclusionAegurados.aspx");
                        }
                        catch (SqlException ex)
                        {
                            Response.Write("Error" + ex);
                        }
                    }
                }
            }
                   
        }
    }
}