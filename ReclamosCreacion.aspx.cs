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
    public partial class ReclamosCreacion : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Correo.Value = Request.Cookies["paramCedula"].Value;
            Correo.Disabled = true;
            Text1.Value = Request.Cookies["nombretomC"].Value;
            Text1.Disabled = true;
            Text7.Value = Request.Cookies["telceladC"].Value;
            Text7.Disabled = true;
            Text5.Value = Request.Cookies["direccionemadC"].Value;
            Text5.Disabled = true;
            Text6.Value = DateTime.Now.ToString();
            Text6.Disabled = true;
            Text3.Value = Request.Cookies["empresaadC"].Value;
            Text3.Disabled = true;            
            Text4.Value = Request.Cookies["ejecutivoC"].Value;
            Text4.Disabled = true;
            Text9.Value = Request.Cookies["relaproaD"].Value;
            Text9.Disabled = true;
            Text10.Value = Request.Cookies["nombreadC"].Value;
            Text10.Disabled = true;
            Text12.Value = Request.Cookies["cobproC"].Value;
            Text12.Disabled = true;
            Text21.Value = Request.Cookies["planproC"].Value;
            Text21.Disabled = true;
            Text8.Value = Request.Cookies["medioadC"].Value;
            Text8.Disabled = true;
            string connectionString = Conection.ConexLine;
            string query = "SELECT TOP 1 CasoNum from Reclamos ORDER BY CasoNum DESC";


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
                            Text2.Value = "1";
                        }
                        else
                        {
                            int tasa = dr.GetFieldValue<int>(0);
                            int prox = tasa + 1;
                            Text2.Value = prox.ToString();
                            Text2.Disabled = true;
                        }
                    }
                    else
                    {
                        Text2.Value = "1";

                    }

                    dr.Close();
                }

                con.Close();
            }
            
            Text2.Disabled = true;
        }



        protected void Unnamed_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            HttpCookie perfil3S = new HttpCookie("indexC");
            perfil3S.Value = "99";
            perfil3S.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(perfil3S);
            Response.Redirect("AdicionSeleccion.aspx");
        }

        protected void Unnamed_Click1(object sender, EventArgs e)
        {

            using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
            {

                string saveStaff = "INSERT INTO Reclamos (Cedula, Celular, Entidad, Relacion, Cobertura, Causa, Casa, [Plan], Nombre, Direccion, Ejecutivo, Asegurado, Diagnostico, CasoNum, Fecha, EstadoReclamo, Observaciones, MedioDeCobro) VALUES (@Cedula, @Celular, @Entidad, @Relacion, @Cobertura, @Causa, @Casa, @Plan, @Nombre, @Direccion, @Ejecutivo, @Asegurado, @Diagnostico, @CasoNum, @Fecha, 'CREADO', @Observaciones, @MedioDeCobro)";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
                    querySaveStaff.Parameters.Add("@Cedula", SqlDbType.Int).Value = Correo.Value;
                    querySaveStaff.Parameters.Add("@Celular", SqlDbType.VarChar).Value = Text7.Value;
                    querySaveStaff.Parameters.Add("@Entidad", SqlDbType.VarChar).Value = Text3.Value;
                    querySaveStaff.Parameters.Add("@Relacion", SqlDbType.VarChar).Value = Text9.Value;                    
                    querySaveStaff.Parameters.Add("@Cobertura", SqlDbType.VarChar).Value = Text12.Value;
                    querySaveStaff.Parameters.Add("@Causa", SqlDbType.VarChar).Value = Text15.SelectedValue;
                    querySaveStaff.Parameters.Add("@Casa", SqlDbType.VarChar).Value = Text18.SelectedValue;
                    querySaveStaff.Parameters.Add("@Plan", SqlDbType.VarChar).Value = Text21.Value;
                    querySaveStaff.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Text1.Value;
                    querySaveStaff.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = Text5.Value;
                    querySaveStaff.Parameters.Add("@Ejecutivo", SqlDbType.VarChar).Value = Text4.Value;
                    querySaveStaff.Parameters.Add("@Asegurado", SqlDbType.VarChar).Value = Text10.Value;
                    querySaveStaff.Parameters.Add("@Diagnostico", SqlDbType.VarChar).Value = Text13.Value;
                    querySaveStaff.Parameters.Add("@CasoNum", SqlDbType.Int).Value = Int32.Parse(Text2.Value);
                    querySaveStaff.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = DateTime.Parse(Text6.Value);
                    querySaveStaff.Parameters.Add("@Observaciones", SqlDbType.VarChar).Value = Text14.Value;
                    querySaveStaff.Parameters.Add("@MedioDeCobro", SqlDbType.VarChar).Value = Text8.Value;
                    try
                    {
                        openCon.Open();
                        querySaveStaff.ExecuteNonQuery();
                        Response.Write("<script>alert('CASO CREADO')</script>");
                        Response.Redirect("ReclamoCons.aspx");
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
}