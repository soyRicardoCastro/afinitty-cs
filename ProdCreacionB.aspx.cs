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
    public partial class ProdCreacionB : Page
    {
        Double m;
        protected void Page_Load(object sender, EventArgs e)
        {
                        
            if (!IsPostBack)
            {                
                SqlConnection con = new SqlConnection(Conection.ConexLine);
                SqlCommand cmd = new SqlCommand("select distinct PlanSelect from Productos", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                DropDownList6.DataSource = dt;
                DropDownList6.DataBind();

                SqlConnection con2 = new SqlConnection(Conection.ConexLine);
                SqlCommand cmd2 = new SqlCommand("select distinct Edadmin from Productos", con2);
                SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                sda2.Fill(dt2);

                DropDownList7.DataSource = dt2;
                DropDownList7.DataBind();

                SqlConnection con3 = new SqlConnection(Conection.ConexLine);
                SqlCommand cmd3 = new SqlCommand("select distinct Edadmax from Productos", con3);
                SqlDataAdapter sda3 = new SqlDataAdapter(cmd3);
                DataTable dt3 = new DataTable();
                sda3.Fill(dt3);

                DropDownList1.DataSource = dt3;
                DropDownList1.DataBind();

                SqlConnection con4 = new SqlConnection(Conection.ConexLine);
                SqlCommand cmd4 = new SqlCommand("select distinct Edadren from Productos", con4);
                SqlDataAdapter sda4 = new SqlDataAdapter(cmd4);
                DataTable dt4 = new DataTable();
                sda4.Fill(dt4);

                DropDownList2.DataSource = dt4;
                DropDownList2.DataBind();

                SqlConnection con5 = new SqlConnection(Conection.ConexLine);
                SqlCommand cmd5 = new SqlCommand("select distinct Aplica from Productos", con5);
                SqlDataAdapter sda5 = new SqlDataAdapter(cmd5);
                DataTable dt5 = new DataTable();
                sda5.Fill(dt5);

                DropDownList3.DataSource = dt5;
                DropDownList3.DataBind();
                if (Request.Cookies["indexprod"] != null)
                {
                    if (Request.Cookies["indexprod"].Value == "1")
                    {
                        //Correo.Disabled = true;
                        //DropDownList6.Enabled = false;
                        //DropDownList3.Enabled = false;
                        Label6.Attributes.Add("style", "display:none");
                        Correo.Value = Request.Cookies["paramprod"].Value;
                        DropDownList6.SelectedValue = Request.Cookies["paramplan"].Value;
                        DropDownList7.SelectedValue = Request.Cookies["parammin"].Value;
                        DropDownList1.SelectedValue = Request.Cookies["parammax"].Value;
                        DropDownList2.SelectedValue = Request.Cookies["paramren"].Value;
                        DropDownList3.SelectedValue = Request.Cookies["paramapli"].Value;
                        Text2.Value = Request.Cookies["paramval"].Value;
                        Text1.Value = Request.Cookies["paramcob"].Value;
                        Text3.Value = Request.Cookies["paramCausa"].Value;
                        Response.Cookies["paramprod"].Expires = DateTime.Now.AddDays(-1);
                        Response.Cookies["paramplan"].Expires = DateTime.Now.AddDays(-1);
                        Response.Cookies["parammin"].Expires = DateTime.Now.AddDays(-1);
                        Response.Cookies["parammax"].Expires = DateTime.Now.AddDays(-1);
                        Response.Cookies["paramren"].Expires = DateTime.Now.AddDays(-1);
                        Response.Cookies["paramapli"].Expires = DateTime.Now.AddDays(-1);
                        Response.Cookies["paramval"].Expires = DateTime.Now.AddDays(-1);
                        Response.Cookies["paramcob"].Expires = DateTime.Now.AddDays(-1);
                        Response.Cookies["paramCausa"].Expires = DateTime.Now.AddDays(-1);
                        HttpCookie clase5S = new HttpCookie("indexprod");
                        clase5S.Value = "2";
                        clase5S.Expires = DateTime.Now.AddDays(30);
                        Response.Cookies.Add(clase5S);
                    }

                }
                else
                {
                    Label10.Attributes.Add("style", "display:none");
                    ELIMINAR.Attributes.Add("style", "display:none");
                    VOLVER.Attributes.Add("style", "display:none");
                }

            }
                        
           
        }        


        
        

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["indexprod"] != null)
            {
                if (Request.Cookies["indexprod"].Value == "2")
                {
                    using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
                    {
                        string saveStaff = "UPDATE Productos SET Edadmin=@Edadmin, Edadmax=@Edadmax, Edadren=@Edadren, Cobertura=@Cobertura, Valor=@Valor, Causa=@Causa, Producto=@Producto, Aplica=@Aplica, PlanSelect=@PlanSelect WHERE Row=@Row";

                        using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                        {
                            querySaveStaff.Connection = openCon;
                            querySaveStaff.Parameters.Add("@Producto", SqlDbType.VarChar).Value = Correo.Value;
                            querySaveStaff.Parameters.Add("@PlanSelect", SqlDbType.VarChar).Value = DropDownList6.SelectedValue.ToString();
                            querySaveStaff.Parameters.Add("@Edadmin", SqlDbType.VarChar).Value = DropDownList7.SelectedValue.ToString();
                            querySaveStaff.Parameters.Add("@Edadmax", SqlDbType.VarChar).Value = DropDownList1.SelectedValue.ToString();
                            querySaveStaff.Parameters.Add("@Edadren", SqlDbType.VarChar).Value = DropDownList2.SelectedValue.ToString();
                            querySaveStaff.Parameters.Add("@Aplica", SqlDbType.VarChar).Value = DropDownList3.SelectedValue.ToString();
                            querySaveStaff.Parameters.Add("@Cobertura", SqlDbType.Money).Value = Double.Parse(Text2.Value);
                            querySaveStaff.Parameters.Add("@Valor", SqlDbType.Money).Value = Double.Parse(Text1.Value);
                            querySaveStaff.Parameters.Add("@Causa", SqlDbType.VarChar).Value = Text3.Value;
                            querySaveStaff.Parameters.Add("@Row", SqlDbType.VarChar).Value = Request.Cookies["paramRow"].Value;
                            try
                            {
                                openCon.Open();
                                querySaveStaff.ExecuteNonQuery();
                                openCon.Close();
                                //Response.Write("<script>alert('PRODUCTO EDITADO')</script>");
                                Response.Cookies["indexprod"].Expires = DateTime.Now.AddDays(-1);
                                Page.RegisterStartupScript("LoadFunction", "<script type='text/javascript'>alert('PRODUCTO EDITADO CON EXITO');window.location='ProdListaEdicB.aspx'</script>");
                             
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
                using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
                {
                    string saveStaff = "INSERT into Productos (Producto, PlanSelect, Edadmin, Edadmax, Edadren, Aplica, Cobertura, Valor, Causa, Medio) VALUES (@Producto, @PlanSelect, @Edadmin, @Edadmax, @Edadren, @Aplica, @Cobertura, @Valor, @Causa, 'BANCA')";

                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = openCon;
                        querySaveStaff.Parameters.Add("@Producto", SqlDbType.VarChar).Value = Correo.Value;
                        querySaveStaff.Parameters.Add("@PlanSelect", SqlDbType.VarChar).Value = DropDownList6.SelectedValue.ToString();
                        querySaveStaff.Parameters.Add("@Edadmin", SqlDbType.VarChar).Value = DropDownList7.SelectedValue.ToString();
                        querySaveStaff.Parameters.Add("@Edadmax", SqlDbType.VarChar).Value = DropDownList1.SelectedValue.ToString();
                        querySaveStaff.Parameters.Add("@Edadren", SqlDbType.VarChar).Value = DropDownList2.SelectedValue.ToString();
                        querySaveStaff.Parameters.Add("@Aplica", SqlDbType.VarChar).Value = DropDownList3.SelectedValue.ToString();
                        querySaveStaff.Parameters.Add("@Cobertura", SqlDbType.Money).Value = Double.Parse(Text2.Value);
                        querySaveStaff.Parameters.Add("@Valor", SqlDbType.Money).Value = Double.Parse(Text1.Value);
                        querySaveStaff.Parameters.Add("@Causa", SqlDbType.VarChar).Value = Text3.Value;
                        try
                        {
                            openCon.Open();
                            querySaveStaff.ExecuteNonQuery();
                            openCon.Close();
                            Response.Write("<script>alert('PRODUCTO CREADO CON EXITO')</script>");

                            Correo.Value = "";
                            DropDownList6.SelectedValue = "PLAN";
                            DropDownList7.SelectedValue = "EDAD MINIMA";
                            DropDownList1.SelectedValue = "EDAD MAXIMA";
                            DropDownList2.SelectedValue = "EDAD PERMANENCIA";
                            DropDownList3.SelectedValue = "RELACION";
                            Text1.Value = "";
                            Text2.Value = "";
                            Text3.Value = "";
                        }
                        catch (SqlException ex)
                        {
                            Response.Write("Error" + ex);
                        }
                    }
                }
            }
                    
            
                
        }

        protected void Unnamed_Click1(object sender, EventArgs e)
        {
            Response.Redirect("ProdListaEdicB.aspx");
        }

        protected void Unnamed_Click2(object sender, EventArgs e)
        {
            using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
            {
                string saveStaff = "DELETE FROM Productos WHERE Row=@Row;";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
                    //querySaveStaff.Parameters.Add("@Producto", SqlDbType.VarChar).Value = Correo.Value;
                    //querySaveStaff.Parameters.Add("@PlanSelect", SqlDbType.VarChar).Value = DropDownList6.SelectedValue.ToString();                    
                    //querySaveStaff.Parameters.Add("@Aplica", SqlDbType.VarChar).Value = DropDownList3.SelectedValue.ToString();
                    querySaveStaff.Parameters.Add("@Row", SqlDbType.VarChar).Value = Request.Cookies["paramRow"].Value;
                    try
                    {
                        openCon.Open();
                        querySaveStaff.ExecuteNonQuery();
                        openCon.Close();
            
                        Response.Cookies["indexprod"].Expires = DateTime.Now.AddDays(-1);
                        Page.RegisterStartupScript("LoadFunction", "<script type='text/javascript'>alert('PRODUCTO ELIMINADO');window.location='ProdListaEdicB.aspx'</script>");
                     
                    }
                    catch (SqlException ex)
                    {
                        Response.Write("Error" + ex);
                    }
                }
            }
        }

        protected void Unnamed_Click3(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}