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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            string connectionString = Conection.ConexLine;
            string query = "SELECT Nombre, Row, Perfil, Apellido, Alias, HoraIni, HoraCierre FROM Usuario WHERE Usu=@Correo AND Pass=@Pass AND Estado='ACTIVO'";


            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {

                cmd.Parameters.Add("@Correo", SqlDbType.VarChar, 50).Value = Correo.Value.ToString();
                cmd.Parameters.Add("@Pass", SqlDbType.VarChar, 50).Value = Contrasena.Value.ToString();


                con.Open();


                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        string nombre = dr.GetFieldValue<string>(0);
                        int Row = dr.GetFieldValue<int>(1);
                        string Perfil = dr.GetFieldValue<string>(2);
                        string Apellido = dr.GetFieldValue<string>(3);
                        string Alias = dr.GetFieldValue<string>(4);
                        string ini = dr.GetFieldValue<string>(5);
                        string cierr = dr.GetFieldValue<string>(6);
                        int inidef = Int32.Parse(ini);
                        int cierdef = Int32.Parse(cierr);
                        int inilim = DateTime.Now.Hour;
                        
                        if (inidef < inilim && cierdef > inilim)
                        {
                            HttpCookie nombreS = new HttpCookie("nombreC");
                            nombreS.Value = nombre;
                            nombreS.Expires = DateTime.Now.AddDays(30);
                            Response.Cookies.Add(nombreS);

                            HttpCookie nombre2S = new HttpCookie("appellC");
                            nombre2S.Value = Apellido;
                            nombre2S.Expires = DateTime.Now.AddDays(30);
                            Response.Cookies.Add(nombre2S);

                            HttpCookie idclienteS = new HttpCookie("rowC");
                            idclienteS.Value = Row.ToString();
                            idclienteS.Expires = DateTime.Now.AddDays(30);
                            Response.Cookies.Add(idclienteS);

                            HttpCookie perfilS = new HttpCookie("PerfilC");
                            perfilS.Value = Perfil;
                            perfilS.Expires = DateTime.Now.AddDays(30);
                            Response.Cookies.Add(perfilS);

                            HttpCookie perfilS2 = new HttpCookie("namescreenC");
                            perfilS2.Value = Alias;
                            perfilS2.Expires = DateTime.Now.AddDays(30);
                            Response.Cookies.Add(perfilS2);

                            HttpCookie nombreS3 = new HttpCookie("usupassC");
                            nombreS3.Value = Correo.Value.ToString();
                            nombreS3.Expires = DateTime.Now.AddDays(30);
                            Response.Cookies.Add(nombreS3);


                            Page.RegisterStartupScript("LoadFunction", "<script type='text/javascript'>alert('BIENVENIDO');window.location='Default.aspx'</script>");
                        }
                        else
                        {
                            Page.RegisterStartupScript("LoadFunction", "<script type='text/javascript'>alert('FUERA DE HORARIO');window.location='Login.aspx'</script>");
                        }
                        



                    }
                    else
                    {
                        Response.Write("<script>alert('Usuario y Contraseña incorrectos')</script>");

                    }

                    dr.Close();
                }

                con.Close();
            }
        }

    }
    
}