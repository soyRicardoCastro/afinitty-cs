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
    public partial class Default2 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["paramComer"] != null)
            {
                Correo.Value = Request.Cookies["paramComer"].Value;

                HttpCookie nombretomS = new HttpCookie("comertempC");
                nombretomS.Value = Request.Cookies["paramComer"].Value;
                nombretomS.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(nombretomS);
                Response.Cookies["paramComer"].Expires = DateTime.Now.AddDays(-1);
            }
            else
            {

            }
        }
        protected void Unnamed_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {            

            
        }
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            
            string definidor = DropDownList4.SelectedValue.ToString();            
            using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
            {
                string saveStaff = "INSERT into Empresa (NombreComercial, MedioDeCobro) VALUES (@NombreComercial, @MedioDeCobro)";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
                    querySaveStaff.Parameters.Add("@NombreComercial", SqlDbType.VarChar).Value = Request.Cookies["comertempC"].Value;
                    querySaveStaff.Parameters.Add("@MedioDeCobro", SqlDbType.VarChar).Value = DropDownList4.SelectedValue.ToString();                    
                    try
                    {
                        openCon.Open();
                        querySaveStaff.ExecuteNonQuery();
                        openCon.Close();
                        if (definidor == "ROL DE PAGOS")
                        {
                            using (SqlConnection openCon2 = new SqlConnection(Conection.ConexLine))
                            {
                                string saveStaff2 = "INSERT into Medios (NombreComercial, Medio) VALUES (@NombreComercial, @Medio)";

                                using (SqlCommand querySaveStaff2 = new SqlCommand(saveStaff2))
                                {
                                    querySaveStaff2.Connection = openCon2;
                                    querySaveStaff2.Parameters.Add("@NombreComercial", SqlDbType.VarChar).Value = Request.Cookies["comertempC"].Value;
                                    querySaveStaff2.Parameters.Add("@Medio", SqlDbType.VarChar).Value = "ROL DE PAGOS";
                                    try
                                    {
                                        openCon2.Open();
                                        querySaveStaff2.ExecuteNonQuery();
                                        openCon2.Close();
                                        Correo.Value = null;
                                        DropDownList4.SelectedValue = null;
                                        Response.Write("<script>alert('EMPRESA CREADA')</script>");
                                        
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
                            if (definidor == "TARJETA DE CREDITO")
                            {
                                using (SqlConnection openCon5 = new SqlConnection(Conection.ConexLine))
                                {
                                    string saveStaff5 = "INSERT into Medios (NombreComercial, Medio) VALUES (@NombreComercial, @Medio)";

                                    using (SqlCommand querySaveStaff5 = new SqlCommand(saveStaff5))
                                    {
                                        querySaveStaff5.Connection = openCon5;
                                        querySaveStaff5.Parameters.Add("@NombreComercial", SqlDbType.VarChar).Value = Request.Cookies["comertempC"].Value;
                                        querySaveStaff5.Parameters.Add("@Medio", SqlDbType.VarChar).Value = "TARJETA DE CREDITO";
                                        try
                                        {
                                            openCon5.Open();
                                            querySaveStaff5.ExecuteNonQuery();
                                            openCon5.Close();
                                            Correo.Value = null;
                                            DropDownList4.SelectedValue = null;
                                            Response.Write("<script>alert('EMPRESA CREADA')</script>");
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
                                using (SqlConnection openCon4 = new SqlConnection(Conection.ConexLine))
                                {
                                    string saveStaff4 = "INSERT into Medios (NombreComercial, Medio) VALUES (@NombreComercial, @Medio)";

                                    using (SqlCommand querySaveStaff4 = new SqlCommand(saveStaff4))
                                    {
                                        querySaveStaff4.Connection = openCon4;
                                        querySaveStaff4.Parameters.Add("@NombreComercial", SqlDbType.VarChar).Value = Request.Cookies["comertempC"].Value;
                                        querySaveStaff4.Parameters.Add("@Medio", SqlDbType.VarChar).Value = "TARJETA DE CREDITO";
                                        try
                                        {
                                            openCon4.Open();
                                            querySaveStaff4.ExecuteNonQuery();
                                            openCon4.Close();
                                            
                                        }
                                        catch (SqlException ex)
                                        {
                                            Response.Write("Error" + ex);
                                        }
                                    }
                                }
                                using (SqlConnection openCon3 = new SqlConnection(Conection.ConexLine))
                                {
                                    string saveStaff3 = "INSERT into Medios (NombreComercial, Medio) VALUES (@NombreComercial, @Medio)";

                                    using (SqlCommand querySaveStaff3 = new SqlCommand(saveStaff3))
                                    {
                                        querySaveStaff3.Connection = openCon3;
                                        querySaveStaff3.Parameters.Add("@NombreComercial", SqlDbType.VarChar).Value = Request.Cookies["comertempC"].Value;
                                        querySaveStaff3.Parameters.Add("@Medio", SqlDbType.VarChar).Value = "ROL DE PAGOS";
                                        try
                                        {
                                            openCon3.Open();
                                            querySaveStaff3.ExecuteNonQuery();
                                            openCon3.Close();
                                            Correo.Value = null;
                                            DropDownList4.SelectedValue = null;
                                            Response.Write("<script>alert('EMPRESA CREADA')</script>");
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
                    catch (SqlException ex)
                    {
                        Response.Write("Error" + ex);
                    }
                }
            }            
        }
    }
}