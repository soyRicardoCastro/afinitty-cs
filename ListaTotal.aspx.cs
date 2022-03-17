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
    public partial class ListaTotal : Page
    {
        Double m;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            Text4.Value = Request.Cookies["nombretomC"].Value;
            Text3.Value = Request.Cookies["paramCedula"].Value;
            Text5.Value = Request.Cookies["fechanactomC"].Value;

            if (Request.Cookies["indexC"] != null)
            {
                if (Request.Cookies["indexC"].Value == "11")
                {
                    string CedulaTom = Request.Cookies["paramCedula"].Value;
                    DateTime fecha = DateTime.Parse(Request.Cookies["fechaC"].Value);
                    string connectionString = Conection.ConexLine;
                    string query = "SELECT  SUM(Valor) FROM VentaTemp where CedulaTomador=" + CedulaTom + " AND YEAR(FechaVenta) = '" + fecha.Year + "' AND MONTH(FechaVenta)='" + fecha.Month + "' AND DAY(FechaVenta)='" + fecha.Day + "'";


                    using (SqlConnection con = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {

                        con.Open();


                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                //int tasa = dr.GetFieldValue<int>(0);
                                Decimal prox = dr.GetFieldValue<Decimal>(0);
                                prefifin.Text = prox.ToString();
                            }
                            else
                            {
                                Response.Write("<script>alert('revise la tasa')</script>");

                            }

                            dr.Close();
                        }

                        con.Close();
                    }
                    Label2.Attributes.Add("style", "display:none");
                    Label3.Attributes.Add("style", "display:none");
                    Label7.Attributes.Add("style", "display:none");
                    Label4.Attributes.Add("style", "display:none");
                    GridView2.Attributes.Add("style", "display:none");

                }
                else if (Request.Cookies["indexC"].Value == "2")
                {
                    string CedulaTom = Request.Cookies["paramCedula"].Value;
                    DateTime fecha = DateTime.Parse(Request.Cookies["fechaC"].Value);
                    string connectionString = Conection.ConexLine;
                    string query = "SELECT  SUM(Valor) FROM VentaTemp where CedulaTomador=" + CedulaTom + " AND YEAR(FechaVenta) = '" + fecha.Year + "' AND MONTH(FechaVenta)='" + fecha.Month + "' AND DAY(FechaVenta)='" + fecha.Day + "'";


                    using (SqlConnection con = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {

                        con.Open();


                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                //int tasa = dr.GetFieldValue<int>(0);
                                Decimal prox = dr.GetFieldValue<Decimal>(0);
                                prefifin.Text = prox.ToString();
                            }
                            else
                            {
                                Response.Write("<script>alert('revise la tasa')</script>");

                            }

                            dr.Close();
                        }

                        con.Close();
                    }
                    Label6.Attributes.Add("style", "display:none");
                    Label3.Attributes.Add("style", "display:none");
                    Label7.Attributes.Add("style", "display:none");
                    Label4.Attributes.Add("style", "display:none");
                    GridView2.Attributes.Add("style", "display:none");

                }
                else if (Request.Cookies["indexC"].Value == "15")
                {
                    string CedulaTom = Request.Cookies["paramCedula"].Value;
                    DateTime fecha = DateTime.Parse(Request.Cookies["fechaC"].Value);
                    string connectionString = Conection.ConexLine;
                    string query = "SELECT  SUM(Valor) FROM VentaTemp where CedulaTomador=" + CedulaTom + " AND YEAR(FechaVenta) = '" + fecha.Year + "' AND MONTH(FechaVenta)='" + fecha.Month + "' AND DAY(FechaVenta)='" + fecha.Day + "'";


                    using (SqlConnection con = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {

                        con.Open();


                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                //int tasa = dr.GetFieldValue<int>(0);
                                Decimal prox = dr.GetFieldValue<Decimal>(0);
                                prefifin.Text = prox.ToString();
                            }
                            else
                            {
                                Response.Write("<script>alert('revise la tasa')</script>");

                            }

                            dr.Close();
                        }

                        con.Close();
                    }
                    string CedulaTom2 = Request.Cookies["paramCedula"].Value;
                    //DateTime fecha2 = DateTime.Parse(Request.Cookies["fechaC"].Value);
                    string connectionString2 = Conection.ConexLine;
                    string query2 = "SELECT  SUM(TotalCobrar) FROM Dependientes where CedulaTomador=" + CedulaTom2 + "";


                    using (SqlConnection con2 = new SqlConnection(connectionString2))
                    using (SqlCommand cmd2 = new SqlCommand(query2, con2))
                    {

                        con2.Open();


                        using (SqlDataReader dr2 = cmd2.ExecuteReader())
                        {
                            if (dr2.Read())
                            {
                                //int tasa = dr.GetFieldValue<int>(0);
                                Decimal prox2 = dr2.GetFieldValue<Decimal>(0);
                                Label7.Text = prox2.ToString();
                            }
                            else
                            {
                                Response.Write("<script>alert('revise la tasa')</script>");

                            }

                            dr2.Close();
                        }

                        con2.Close();
                    }
                    Label6.Attributes.Add("style", "display:none");
                    Label3.Attributes.Add("style", "display:none");
                    GridView2.Attributes.Add("style", "display:none");

                }
                else if (Request.Cookies["indexC"].Value == "3")
                {
                    string CedulaTom = Request.Cookies["paramCedula"].Value;
                    DateTime fecha = DateTime.Parse(Request.Cookies["fechaC"].Value);
                    string connectionString = Conection.ConexLine;
                    string query = "SELECT  SUM(Valor) FROM VentaTemp where CedulaTomador=" + CedulaTom + " AND YEAR(FechaVenta) = '" + fecha.Year + "' AND MONTH(FechaVenta)='" + fecha.Month + "' AND DAY(FechaVenta)='" + fecha.Day + "'";


                    using (SqlConnection con = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {

                        con.Open();


                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                //int tasa = dr.GetFieldValue<int>(0);
                                Decimal prox = dr.GetFieldValue<Decimal>(0);
                                prefifin.Text = prox.ToString();
                            }
                            else
                            {
                                Response.Write("<script>alert('revise la tasa')</script>");

                            }

                            dr.Close();
                        }

                        con.Close();
                    }
                    GridView2.Attributes.Add("style", "display:none");
                    Label6.Attributes.Add("style", "display:none");
                    Label3.Attributes.Add("style", "display:none");
                    Label7.Attributes.Add("style", "display:none");
                    Label4.Attributes.Add("style", "display:none");

                }
                else if (Request.Cookies["indexC"].Value == "30")
                {
                    string CedulaTom = Request.Cookies["paramCedula"].Value;
                    DateTime fecha = DateTime.Parse(Request.Cookies["fechaC"].Value);
                    string connectionString = Conection.ConexLine;
                    string query = "SELECT  SUM(TotalCobrar) FROM Dependientes where NumeroCertificado=" + Request.Cookies["paramCert"].Value + " AND Estado <> 'EXCLUIDO'";


                    using (SqlConnection con = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {

                        con.Open();


                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                //int tasa = dr.GetFieldValue<int>(0);
                                Decimal prox = dr.GetFieldValue<Decimal>(0);
                                prefifin.Text = prox.ToString();
                            }
                            else
                            {
                                Response.Write("<script>alert('revise la tasa')</script>");

                            }

                            dr.Close();
                        }

                        con.Close();
                    }
                    Label6.Attributes.Add("style", "display:none");
                    Label2.Attributes.Add("style", "display:none");
                    //Label7.Attributes.Add("style", "display:none");
                    //Label4.Attributes.Add("style", "display:none");
                    GridView1.Attributes.Add("style", "display:none");
                    string CedulaTom2 = Request.Cookies["paramCedula"].Value;
                    //DateTime fecha2 = DateTime.Parse(Request.Cookies["fechaC"].Value);
                    string connectionString2 = Conection.ConexLine;
                    string query2 = "SELECT  SUM(TotalCobrar) FROM Dependientes where CedulaTomador=" + CedulaTom2 + " AND Estado <> 'EXCLUIDO'";


                    using (SqlConnection con2 = new SqlConnection(connectionString2))
                    using (SqlCommand cmd2 = new SqlCommand(query2, con2))
                    {

                        con2.Open();


                        using (SqlDataReader dr2 = cmd2.ExecuteReader())
                        {
                            if (dr2.Read())
                            {
                                //int tasa = dr.GetFieldValue<int>(0);
                                Decimal prox2 = dr2.GetFieldValue<Decimal>(0);
                                Label7.Text = prox2.ToString();
                            }
                            else
                            {
                                Response.Write("<script>alert('revise la tasa')</script>");

                            }

                            dr2.Close();
                        }

                        con2.Close();
                    }

                }
            }
        }
        

       

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            
            if (Request.Cookies["indexC"].Value == "2")
            {
                HttpCookie nombre2S = new HttpCookie("totalC");
                nombre2S.Value = prefifin.Text;
                nombre2S.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(nombre2S);
                //Response.Cookies["indexC"].Expires = DateTime.Now.AddDays(-1);
                //Response.Redirect("AdicionSeleccion.aspx");
                Response.Redirect("InclusionCertificados.aspx");
            }
            else
            {
                HttpCookie nombre2S = new HttpCookie("totalC");
                nombre2S.Value = prefifin.Text;
                nombre2S.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(nombre2S);
                Response.Redirect("InclusionCertificados.aspx");
            }
        }

       
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = GridView1.SelectedIndex;

            string CedulaTom = Request.Cookies["paramCedula"].Value;
            string Ejec = Request.Cookies["nombreC"].Value;
            string fecha = Request.Cookies["fechaC"].Value;
            string nombre = GridView1.Rows[i].Cells[0].Text;
            string prod = GridView1.Rows[i].Cells[4].Text;
            string plan = GridView1.Rows[i].Cells[5].Text;

            double n = Double.Parse(GridView1.Rows[i].Cells[6].Text);
            double x = Double.Parse(prefifin.Text);
            m = x - n;
            HttpCookie totalS = new HttpCookie("totalC");
            totalS.Value = m.ToString();
            totalS.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(totalS);
            prefifin.Text = m.ToString();
            using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
            {
                

                string saveStaff = "DELETE FROM VentaTemp WHERE Nombre=@Nombre AND PlanSelect=@PlanSelect AND CedulaTomador=@CedulaTomador AND FechaVenta=@FechaVenta AND Ejecutivo=@Ejecutivo AND Producto=@Producto"; 

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
                    querySaveStaff.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = nombre;
                    querySaveStaff.Parameters.Add("@Producto", SqlDbType.VarChar).Value = prod;
                    querySaveStaff.Parameters.Add("@PlanSelect", SqlDbType.VarChar).Value = plan;
                    querySaveStaff.Parameters.Add("@CedulaTomador", SqlDbType.BigInt).Value = Int64.Parse(CedulaTom);
                    querySaveStaff.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DateTime.Parse(fecha);
                    querySaveStaff.Parameters.Add("@Ejecutivo", SqlDbType.NVarChar).Value = Ejec;

                    try
                    {
                        openCon.Open();
                        querySaveStaff.ExecuteNonQuery();
                        openCon.Close();
                        GridView1.DataBind();
                        
                    }
                    catch (SqlException ex)
                    {
                        Response.Write("Error" + ex);
                    }
                }
            }
            using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
            {                

                string saveStaff = "DELETE FROM Dependientes WHERE Nombre=@Nombre AND [Plan]=@Plan AND CedulaTomador=@CedulaTomador AND Producto=@Producto";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
                    querySaveStaff.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = nombre;
                    querySaveStaff.Parameters.Add("@Producto", SqlDbType.VarChar).Value = prod;
                    querySaveStaff.Parameters.Add("@Plan", SqlDbType.VarChar).Value = plan;
                    querySaveStaff.Parameters.Add("@CedulaTomador", SqlDbType.BigInt).Value = Int64.Parse(CedulaTom);                    

                    try
                    {
                        openCon.Open();
                        querySaveStaff.ExecuteNonQuery();
                        openCon.Close();
                        GridView1.DataBind();
                        Response.Write("<script>alert('REGISTRO EXCLUIDO')</script>");
                    }
                    catch (SqlException ex)
                    {
                        Response.Write("Error" + ex);
                    }
                }
            }

        }

        protected void Unnamed_Click2(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void Unnamed_Click3(object sender, EventArgs e)
        {
            if (Request.Cookies["indexC"].Value == "11")
            {
                HttpCookie totalS = new HttpCookie("indexC");
                totalS.Value = "1";
                totalS.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(totalS);
                Response.Redirect("InclusionAegurados.aspx");
            }
            if (Request.Cookies["indexC"].Value == "15")
            {
                //HttpCookie totalS = new HttpCookie("IndexC");
                //totalS.Value = "1";
                //totalS.Expires = DateTime.Now.AddDays(30);
                //Response.Cookies.Add(totalS);
                Response.Redirect("AdicionSeleccion.aspx");
            }
            if (Request.Cookies["indexC"].Value == "30")
            {
                //HttpCookie totalS = new HttpCookie("IndexC");
                //totalS.Value = "1";
                //totalS.Expires = DateTime.Now.AddDays(30);
                //Response.Cookies.Add(totalS);
                Response.Redirect("AdicionSeleccion.aspx");
            }
            else
            {
                Response.Redirect("InclusionAegurados.aspx");
            }
            
        }
    }
}