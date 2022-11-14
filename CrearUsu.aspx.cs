using Newtonsoft.Json;
using ReachSystem.Datos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReachSystem
{
    public partial class CrearUsu : Page
    {
        Double m;
        protected void Page_Load(object sender, EventArgs e)
        {
                        
          
                        
           
        }        


        
        

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            if (Text2.Value != null)
            {
                string body = "<body>" +
                        "<h4>Estimado: " + Text3.Value + "</h4>" +
                        "<h4>Tu Usuario ha sido creado y ahora puedes acceder a nuestro sistema.</h4>" +
                        "<h4>Recuerda que lo puedes hacer desde www.affinity.somee.com con las siguientes credenciales</h4>" +
                        "<h4>Usuario: "+Text5.Value+"</h4>" +
                        "<h4>Contraseña: "+Text2.Value+"</h4>" +
                        "<h4>Cordiales Saludos</h4>" +
                        "<h4>Seguros Affinity.</h4>" +
                        "<img  src='https://1.bp.blogspot.com/-pWSO2elPkeI/X5woEanJ0GI/AAAAAAAAPkI/UMptMYuBh6oX0V61V2758z_VF52oc8i-ACLcBGAsYHQ/s16000/logo.png' />" +
                        "</body>";
                SmtpClient smtp = new SmtpClient();
                smtp.EnableSsl = false;
                smtp.UseDefaultCredentials = false;
                smtp.Host = "smtp.affinity.somee.com";
                smtp.Port = 26;
                smtp.Credentials = new NetworkCredential("usuario@affinity.somee.com", "Otto.123");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;



                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("usuario@affinity.somee.com", "Seguros Affinity");
                mail.To.Add(new MailAddress("" + Text6.Value.ToString() + ""));
                mail.Subject = "Tu usuario ha sido creado";
                mail.IsBodyHtml = true;
                mail.Body = body;

                smtp.Send(mail);
                using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
                {
                    string saveStaff = "INSERT into Usuario (Nombre, Apellido, Correo, Pass, Perfil, Cargo, Ciudad, FechaIngreso, FechaCreacion, [Usu], Alias, Estado, HoraCierre, HoraIni, Cedula, Celular) VALUES (@Nombre, @Apellido, @Correo, @Pass, @Perfil, @Cargo, @Ciudad, @FechaIngreso, GETDATE(), @Usu, @Alias, 'ACTIVO', @HoraCierre, @HoraIni, @Cedula, @Celular)";

                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = openCon;
                        querySaveStaff.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Correo.Value;
                        querySaveStaff.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = Text4.Value;
                        querySaveStaff.Parameters.Add("@Correo", SqlDbType.VarChar).Value = Text6.Value;
                        querySaveStaff.Parameters.Add("@Pass", SqlDbType.VarChar).Value = Text2.Value;
                        querySaveStaff.Parameters.Add("@Perfil", SqlDbType.VarChar).Value = DropDownList7.SelectedValue.ToString();
                        querySaveStaff.Parameters.Add("@Cargo", SqlDbType.VarChar).Value = DropDownList1.SelectedValue.ToString();
                        querySaveStaff.Parameters.Add("@Ciudad", SqlDbType.VarChar).Value = DropDownList2.SelectedValue;
                        querySaveStaff.Parameters.Add("@FechaIngreso", SqlDbType.DateTime).Value = DateTime.Parse(Text1.Value);
                        querySaveStaff.Parameters.Add("@FechaCreacion", SqlDbType.DateTime).Value = DateTime.Now;
                        querySaveStaff.Parameters.Add("@Usu", SqlDbType.VarChar).Value = Text5.Value;
                        querySaveStaff.Parameters.Add("@Alias", SqlDbType.VarChar).Value = Text3.Value;
                        querySaveStaff.Parameters.Add("@HoraIni", SqlDbType.VarChar).Value = horaini.Value;
                        querySaveStaff.Parameters.Add("@HoraCierre", SqlDbType.VarChar).Value = horacier.Value;
                        querySaveStaff.Parameters.Add("@Cedula", SqlDbType.VarChar).Value = Text7.Value;
                        querySaveStaff.Parameters.Add("@Celular", SqlDbType.VarChar).Value = Text8.Value;
                        querySaveStaff.Parameters.Add("@Estado", SqlDbType.VarChar).Value = "ACTIVO";
                        try
                        {
                            openCon.Open();
                            querySaveStaff.ExecuteNonQuery();
                            openCon.Close();

                            Page.RegisterStartupScript("LoadFunction", "<script type='text/javascript'>alert('USUARIO CREADO');window.location='Default.aspx'</script>");

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
                Response.Write("<script>alert('NO OLVIDE COLOCAR CONTRASEÑA')</script>");
            }
            
            
                    
            
                
        }

        protected void Unnamed_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
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