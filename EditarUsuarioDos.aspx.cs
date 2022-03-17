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
    public partial class EditarUsuarioDos : Page
    {
        Double m;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["idusuC"] != null)
            {
                string connectionString = Conection.ConexLine;
                string query = "SELECT Nombre, Apellido, Correo, Pass, Perfil, Cargo, Ciudad, FechaIngreso, [Usu], Alias, Estado, HoraIni, HoraCierre, Cedula, Celular FROM Usuario WHERE Alias=@Alias";


                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {

                    cmd.Parameters.Add("@Alias", SqlDbType.VarChar).Value = Request.Cookies["idusuC"].Value;



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
                                Correo.Value = dr.GetFieldValue<string>(0);
                            }
                            if (dr.IsDBNull(1))
                            {

                            }
                            else
                            {
                                Text4.Value = dr.GetFieldValue<string>(1);
                            }
                            if (dr.IsDBNull(8))
                            {

                            }
                            else
                            {
                                Text5.Value = dr.GetFieldValue<string>(8);
                            }
                            if (dr.IsDBNull(2))
                            {

                            }
                            else
                            {
                                Text6.Value = dr.GetFieldValue<string>(2);
                            }
                            if (dr.IsDBNull(4))
                            {

                            }
                            else
                            {
                                DropDownList7.SelectedValue = dr.GetFieldValue<string>(4);
                            }
                            if (dr.IsDBNull(5))
                            {

                            }
                            else
                            {
                                DropDownList1.SelectedValue = dr.GetFieldValue<string>(5);
                            }
                            if (dr.IsDBNull(7))
                            {

                            }
                            else
                            {
                                DateTime fechaing = dr.GetFieldValue<DateTime>(7);
                                Text1.Value = "" + fechaing.Year.ToString() + "-" + fechaing.Month.ToString("00") + "-" + fechaing.Day.ToString("00") + "";
                            }
                            if (dr.IsDBNull(6))
                            {

                            }
                            else
                            {
                                DropDownList2.SelectedValue = dr.GetFieldValue<string>(6);
                            }
                            if (dr.IsDBNull(9))
                            {

                            }
                            else
                            {
                                Text3.Value = dr.GetFieldValue<string>(9);
                            }
                            if (dr.IsDBNull(10))
                            {

                            }
                            else
                            {
                                if (dr.GetFieldValue<string>(10) == "ACTIVO")
                                {
                                    Radio8.Checked = true;
                                }
                                else if (dr.GetFieldValue<string>(10) == "INACTIVO")
                                {
                                    Radio9.Checked = true;
                                }

                            }
                            if (dr.IsDBNull(11))
                            {

                            }
                            else
                            {
                                horaini.Value = dr.GetFieldValue<string>(11);
                            }
                            if (dr.IsDBNull(12))
                            {

                            }
                            else
                            {
                                horacier.Value = dr.GetFieldValue<string>(12);
                            }
                            if (dr.IsDBNull(13))
                            {

                            }
                            else
                            {
                                Text7.Value = dr.GetFieldValue<string>(13);
                            }
                            if (dr.IsDBNull(14))
                            {

                            }
                            else
                            {
                                Text8.Value = dr.GetFieldValue<string>(14);
                            }
                        }


                        dr.Close();
                    }

                    con.Close();
                }
                HttpCookie nombretomS = new HttpCookie("idusutempC");
                nombretomS.Value = Request.Cookies["idusuC"].Value;
                nombretomS.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(nombretomS);
                Response.Cookies["idusuC"].Expires = DateTime.Now.AddDays(-1);

            }
            else
            {

            }
            
            




        }





        protected void Unnamed_Click(object sender, EventArgs e)
        {
            string estado;
            if (Radio8.Checked == true)
            {
                estado = Radio8.Value;
            }
            else if (Radio9.Checked == true)
            {
                estado = Radio9.Value;
            }
            else
            {
                estado = Radio9.Value;
            }


            using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
            {
                string saveStaff = "UPDATE Usuario SET Nombre=@Nombre, Apellido=@Apellido, Correo=@Correo, Perfil=@Perfil, Cargo=@Cargo, Ciudad=@Ciudad, FechaIngreso=@FechaIngreso, [Usu]=@Usu, Alias=@Alias, Estado=@Estado, Celular=@Celular, Cedula=@Cedula, HoraCierre=@HoraCierre, HoraIni=@HoraIni WHERE Alias=@AliasG";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
                    querySaveStaff.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Correo.Value;
                    querySaveStaff.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = Text4.Value;
                    querySaveStaff.Parameters.Add("@Correo", SqlDbType.VarChar).Value = Text5.Value;                   
                    querySaveStaff.Parameters.Add("@Perfil", SqlDbType.VarChar).Value = DropDownList7.SelectedValue.ToString();
                    querySaveStaff.Parameters.Add("@Cargo", SqlDbType.VarChar).Value = DropDownList1.SelectedValue.ToString();
                    querySaveStaff.Parameters.Add("@Ciudad", SqlDbType.VarChar).Value = DropDownList2.SelectedValue;
                    querySaveStaff.Parameters.Add("@FechaIngreso", SqlDbType.DateTime).Value = DateTime.Parse(Text1.Value);                    
                    querySaveStaff.Parameters.Add("@Usu", SqlDbType.VarChar).Value = Text5.Value;
                    querySaveStaff.Parameters.Add("@Alias", SqlDbType.VarChar).Value = Text3.Value;
                    querySaveStaff.Parameters.Add("@Estado", SqlDbType.VarChar).Value = estado;
                    querySaveStaff.Parameters.Add("@HoraIni", SqlDbType.VarChar).Value = horaini.Value;
                    querySaveStaff.Parameters.Add("@HoraCierre", SqlDbType.VarChar).Value = horacier.Value;
                    querySaveStaff.Parameters.Add("@Cedula", SqlDbType.VarChar).Value = Text7.Value;
                    querySaveStaff.Parameters.Add("@Celular", SqlDbType.VarChar).Value = Text8.Value;
                    querySaveStaff.Parameters.Add("@AliasG", SqlDbType.VarChar).Value = Request.Cookies["idusutempC"].Value;
                    try
                    {
                        openCon.Open();
                        querySaveStaff.ExecuteNonQuery();
                        openCon.Close();
                        Response.Cookies["idusutempC"].Expires = DateTime.Now.AddDays(-1);
                        Page.RegisterStartupScript("LoadFunction", "<script type='text/javascript'>alert('USUARIO ACTUALIZADO');window.location='UsuEdicUno.aspx'</script>");

                    }
                    catch (SqlException ex)
                    {
                        Response.Write("Error" + ex);
                    }
                }
            }                                                                                        
                
        }

        protected void Unnamed_Click1(object sender, EventArgs e)
        {
            Response.Redirect("EditarUsuario.aspx");
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
                        Page.RegisterStartupScript("LoadFunction", "<script type='text/javascript'>alert('PRODUCTO ELIMINADO');window.location='ProdListaEdic.aspx'</script>");
                     
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