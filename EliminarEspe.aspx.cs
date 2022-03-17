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
    public partial class EliminarEspe : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["paramCedula"] != null)
            {
                if (GridView1.Rows.Count == 0)
                {
                    Label1.Attributes.Add("style", "display:inline, font-weight: bold; font-size: 18px;");
                    GridView1.Attributes.Add("style", "display:none");
                    //Label1.Text = "EL REGISTRO NO EXISTE EN NUESTRA BASE DE DATOS ¿QUE DESEA HACER?";
                    Correo.Value = Request.Cookies["paramCedula"].Value;
                    Response.Cookies["paramCedula"].Expires = DateTime.Now.AddDays(-1);

                }
                else
                {
                    Label1.Attributes.Add("style", "display:none");
                    GridView2.Attributes.Add("style", "display:none");
                    Correo.Value = Request.Cookies["paramCedula"].Value;
                    Response.Cookies["paramCedula"].Expires = DateTime.Now.AddDays(-1);
                }
            }
            else
            {

            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GridView1.Rows.Count == 0)
            {
                int i = GridView2.SelectedIndex;
                string connectionString = Conection.ConexLine;
                string query = "DELETE FROM Asegurados WHERE NumeroCertificado = @NumeroCertificado";


                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {

                    cmd.Parameters.Add("@NumeroCertificado", SqlDbType.Int, 50).Value = Int32.Parse(GridView2.Rows[i].Cells[1].Text);



                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    con.Close();
                }

                string connectionString2 = Conection.ConexLine;
                string query2 = "DELETE FROM Dependientes WHERE NumeroCertificado = @NumeroCertificado";


                using (SqlConnection con2 = new SqlConnection(connectionString2))
                using (SqlCommand cmd2 = new SqlCommand(query2, con2))
                {

                    cmd2.Parameters.Add("@NumeroCertificado", SqlDbType.Int, 50).Value = Int32.Parse(GridView2.Rows[i].Cells[1].Text);



                    con2.Open();
                    using (SqlDataReader dr2 = cmd2.ExecuteReader())
                        con2.Close();
                }

                string connectionString3 = Conection.ConexLine;
                string query3 = "DELETE FROM Certificados WHERE Numero = @NumeroCertificado";


                using (SqlConnection con3 = new SqlConnection(connectionString3))
                using (SqlCommand cmd3 = new SqlCommand(query3, con3))
                {

                    cmd3.Parameters.Add("@NumeroCertificado", SqlDbType.Int, 50).Value = Int32.Parse(GridView2.Rows[i].Cells[1].Text);



                    con3.Open();
                    using (SqlDataReader dr3 = cmd3.ExecuteReader())
                        con3.Close();
                }


                Response.Redirect("EliminarEspe.aspx");
            }
            else
            {
                int i = GridView1.SelectedIndex;
                string connectionString = Conection.ConexLine;
                string query = "DELETE FROM Asegurados WHERE NumeroCertificado = @NumeroCertificado";


                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {

                    cmd.Parameters.Add("@NumeroCertificado", SqlDbType.Int, 50).Value = Int32.Parse(GridView1.Rows[i].Cells[1].Text);



                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                        con.Close();
                }

                string connectionString2 = Conection.ConexLine;
                string query2 = "DELETE FROM Dependientes WHERE NumeroCertificado = @NumeroCertificado";


                using (SqlConnection con2 = new SqlConnection(connectionString2))
                using (SqlCommand cmd2 = new SqlCommand(query2, con2))
                {

                    cmd2.Parameters.Add("@NumeroCertificado", SqlDbType.Int, 50).Value = Int32.Parse(GridView1.Rows[i].Cells[1].Text);



                    con2.Open();
                    using (SqlDataReader dr2 = cmd2.ExecuteReader())
                        con2.Close();
                }
                string connectionString3 = Conection.ConexLine;
                string query3 = "DELETE FROM Certificados WHERE Numero = @NumeroCertificado";


                using (SqlConnection con3 = new SqlConnection(connectionString3))
                using (SqlCommand cmd3 = new SqlCommand(query3, con3))
                {

                    cmd3.Parameters.Add("@NumeroCertificado", SqlDbType.Int, 50).Value = Int32.Parse(GridView2.Rows[i].Cells[1].Text);



                    con3.Open();
                    using (SqlDataReader dr3 = cmd3.ExecuteReader())
                        con3.Close();
                }

            }

        }
        protected void Unnamed1_Click(object sender, EventArgs e)
        {

            GridView1.DataSource = null;
            SqlDataSource1.DataBind();
            string buscar = Correo.Value;
            HttpCookie buscarS = new HttpCookie("paramCedula");
            buscarS.Value = buscar;
            buscarS.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(buscarS);
            DateTime FECHA = DateTime.Now;
            HttpCookie fechaS = new HttpCookie("fechaC");
            fechaS.Value = FECHA.ToString();
            fechaS.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(fechaS);
            Response.Redirect("EliminarEspe.aspx");

        }       

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");

        }

        protected void Unnamed_Click1(object sender, EventArgs e)
        {
            string url = "https://srienlinea.sri.gob.ec/sri-en-linea/SriDeclaracionesWeb/ConsultaImpuestoRenta/Consultas/consultaImpuestoRenta";
            Response.Write("<script> window.open('" + url + "','_blank'); </script>");
        }
    }
}