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
    public partial class AdminCert : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlConnection con = new SqlConnection(Conection.ConexLine);
                SqlCommand cmd = new SqlCommand("select distinct Alias from Usuario where (Perfil = 'SUPERVEN' or Perfil = 'ADMIN' or Perfil = 'VENTA' or Perfil = 'DIRECVEN' or Perfil = 'SERVICIO') AND Estado = 'ACTIVO'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                DropDownList2.DataSource = dt;
                DropDownList2.DataBind();
            }
            //string connectionString = "workstation id = affisDB.mssql.somee.com; packet size = 4096; user id = localarts_SQLLogin_2; pwd = kgiivi9to9; data source = affisDB.mssql.somee.com; persist security info = False; initial catalog = affisDB";
            //string query = "SELECT TOP 1 Numero from Certificados ORDER BY Numero DESC";


            //using (SqlConnection con = new SqlConnection(connectionString))
            //using (SqlCommand cmd = new SqlCommand(query, con))
            //{

            //    con.Open();


            //    using (SqlDataReader dr = cmd.ExecuteReader())
            //    {
            //        if (dr.Read())
            //        {
            //            int tasa = dr.GetFieldValue<int>(0);
            //            int prox = tasa + 1;
            //            Text4.Value = prox.ToString();
            //            Text4.Disabled = true;

            //        }
            //        else
            //        {
            //            Response.Write("<script>alert('revise la tasa')</script>");

            //        }

            //        dr.Close();
            //    }

            //    con.Close();
            //}
        }
        protected void itemSelected(object sender, EventArgs e)
        {
            if(DropDownList1.SelectedValue == "DEVUELTO")
            {
                Label1.Attributes.Add("style", "display:none");
                Label4.Attributes.Add("style", "display:none");
                DropDownList2.Attributes.Add("style", "display:none");
                Text4.Attributes.Add("style", "display:none");
                Label2.Text = "NUMERO CERTIFICADO";
                Text1.Attributes.Add("placeholder", "NUMERO");
            }
            else if (DropDownList1.SelectedValue == "USADO")
            {
                Label1.Attributes.Add("style", "display:none");
                Label4.Attributes.Add("style", "display:none");
                DropDownList2.Attributes.Add("style", "display:none");
                Text4.Attributes.Add("style", "display:none");
                Label2.Text = "NUMERO CERTIFICADO";
                Text1.Attributes.Add("placeholder", "NUMERO");
            }
            else if (DropDownList1.SelectedValue == "ANULADO")
            {
                Label1.Attributes.Add("style", "display:none");
                Label4.Attributes.Add("style", "display:none");
                DropDownList2.Attributes.Add("style", "display:none");
                Text4.Attributes.Add("style", "display:none");
                Label2.Text = "NUMERO CERTIFICADO";
                Text1.Attributes.Add("placeholder", "NUMERO");
            }
            else if (DropDownList1.SelectedValue == "REASIGNADO")
            {
                Label1.Attributes.Add("style", "display:none");
                Text4.Attributes.Add("style", "display:none");
                Label2.Text = "NUMERO CERTIFICADO";
                Text1.Attributes.Add("placeholder", "NUMERO");
                Label4.Attributes.Add("style", "display font-weight: bold; font-size: 18px;");
                DropDownList2.Attributes.Add("style", "display");
            }
            else {
                Label1.Attributes.Add("style", "display");
                Label1.Attributes.Add("style", "font-weight: bold; font-size: 18px;");
                Text4.Attributes.Add("style", "display");
                Label2.Text = "HASTA";
                Text1.Attributes.Add("placeholder", "HASTA");
                Label4.Attributes.Add("style", "display display font-weight: bold; font-size: 18px;");
                DropDownList2.Attributes.Add("style", "display");
            }
        }


        protected void Unnamed_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue == "ENTREGADO")
            {
                int ini = Int32.Parse(Text4.Value);
                int cierre = Int32.Parse(Text1.Value);
                for (int i = ini; i <= cierre; i++)
                {
                    using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
                    {
                        string saveStaff = "INSERT into Certificados (Ejecutivo, Numero, Estado, Observaciones, Fecha) VALUES (@Ejecutivo, @Numero, @Estado, @Observaciones, @Fecha)";

                        using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                        {
                            querySaveStaff.Connection = openCon;
                            querySaveStaff.Parameters.Add("@Ejecutivo", SqlDbType.VarChar).Value = DropDownList2.SelectedValue;
                            querySaveStaff.Parameters.Add("@Numero", SqlDbType.Int).Value = i;
                            querySaveStaff.Parameters.Add("@Estado", SqlDbType.VarChar).Value = "ENTREGADO";
                            querySaveStaff.Parameters.Add("@Observaciones", SqlDbType.VarChar).Value = Correo.Value;
                            querySaveStaff.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = DateTime.Now;
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
                Text4.Value = "";
                Text1.Value = "";
                DropDownList2.SelectedValue = "EJECUTIVO ASIGNADO";
                Response.Write("<script>alert('CERTIFICADOS ENTREGADOS')</script>");

            }
            else if (DropDownList1.SelectedValue == "DEVUELTO")
            {

                using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
                {
                    string saveStaff = "UPDATE Certificados SET Estado=@Estado, Observaciones=@Observaciones WHERE Numero=@Numero";

                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = openCon;                        
                        querySaveStaff.Parameters.Add("@Numero", SqlDbType.Int).Value = Int32.Parse(Text1.Value);
                        querySaveStaff.Parameters.Add("@Estado", SqlDbType.VarChar).Value = "DEVUELTO";
                        querySaveStaff.Parameters.Add("@Observaciones", SqlDbType.VarChar).Value = Correo.Value;

                        try
                        {
                            openCon.Open();
                            querySaveStaff.ExecuteNonQuery();
                            openCon.Close();
                            Text4.Value = "";
                            Text1.Value = "";
                            DropDownList2.SelectedValue = "EJECUTIVO ASIGNADO";
                            Response.Write("<script>alert('CERTIFICADO DEVUELTO')</script>");

                        }
                        catch (SqlException ex)
                        {
                            Response.Write("Error" + ex);
                        }
                    }
                }
            }
            else if (DropDownList1.SelectedValue == "ANULADO")
            {
                using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
                {
                    string saveStaff = "UPDATE Certificados SET Estado=@Estado, Observaciones=@Observaciones WHERE Numero=@Numero";

                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = openCon;                        
                        querySaveStaff.Parameters.Add("@Numero", SqlDbType.Int).Value = Int32.Parse(Text1.Value);
                        querySaveStaff.Parameters.Add("@Estado", SqlDbType.VarChar).Value = "ANULADO";
                        querySaveStaff.Parameters.Add("@Observaciones", SqlDbType.VarChar).Value = Correo.Value;

                        try
                        {
                            openCon.Open();
                            querySaveStaff.ExecuteNonQuery();
                            openCon.Close();
                            Text4.Value = "";
                            Text1.Value = "";
                            DropDownList2.SelectedValue = "EJECUTIVO ASIGNADO";
                            Response.Write("<script>alert('CERTIFICADO ANULADO')</script>");

                        }
                        catch (SqlException ex)
                        {
                            Response.Write("Error" + ex);
                        }
                    }
                }
            }
            else if (DropDownList1.SelectedValue == "REASIGNADO")
            {
                using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
                {
                    string saveStaff = "UPDATE Certificados SET Ejecutivo=@Ejecutivo, Estado=@Estado, Observaciones=@Observaciones WHERE Numero=@Numero";

                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = openCon;
                        querySaveStaff.Parameters.Add("@Ejecutivo", SqlDbType.VarChar).Value = DropDownList2.SelectedValue;
                        querySaveStaff.Parameters.Add("@Numero", SqlDbType.Int).Value = Int32.Parse(Text1.Value);
                        querySaveStaff.Parameters.Add("@Estado", SqlDbType.VarChar).Value = "ENTREGADO";
                        querySaveStaff.Parameters.Add("@Observaciones", SqlDbType.VarChar).Value = Correo.Value;

                        try
                        {
                            openCon.Open();
                            querySaveStaff.ExecuteNonQuery();
                            openCon.Close();
                            Text4.Value = "";
                            Text1.Value = "";
                            DropDownList2.SelectedValue = "EJECUTIVO ASIGNADO";
                            Response.Write("<script>alert('CERTIFICADO REASIGNADO')</script>");

                        }
                        catch (SqlException ex)
                        {
                            Response.Write("Error" + ex);
                        }
                    }
                }
            }
            else if (DropDownList1.SelectedValue == "USADO")
            {
                using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
                {
                    string saveStaff = "UPDATE Certificados SET Estado=@Estado, Observaciones=@Observaciones WHERE Numero=@Numero";

                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = openCon;                        
                        querySaveStaff.Parameters.Add("@Numero", SqlDbType.Int).Value = Int32.Parse(Text1.Value);
                        querySaveStaff.Parameters.Add("@Estado", SqlDbType.VarChar).Value = "USADO";
                        querySaveStaff.Parameters.Add("@Observaciones", SqlDbType.VarChar).Value = Correo.Value;

                        try
                        {
                            openCon.Open();
                            querySaveStaff.ExecuteNonQuery();
                            openCon.Close();
                            Text4.Value = "";
                            Text1.Value = "";
                            DropDownList2.SelectedValue = "EJECUTIVO ASIGNADO";
                            Response.Write("<script>alert('CERTIFICADO USADO')</script>");

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
            Response.Redirect("Default.aspx");
        }
    }
}