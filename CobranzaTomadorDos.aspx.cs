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
    public partial class CobranzaTomadorDos : Page
    {
        string tasa;
        protected void Page_Load(object sender, EventArgs e)
        {
            Label2.Text = "MES FACTURACION: "+Request.Cookies["empresmesC"].Value + "";
            string connectionString = Conection.ConexLine;
            string query = "SELECT TOP 1 Mes From cierres";


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

                            tasa = "0";

                        }
                        else
                        {
                            tasa = dr.GetFieldValue<string>(0);


                        }


                    }
                    else
                    {
                        tasa = "0";

                    }



                    dr.Close();
                }

                con.Close();
            }
            string connectionString2 = Conection.ConexLine;
            string query2 = "SELECT SUM(TotalCobrar) AS TotalVenta FROM Asegurados where NombreComercial = @NombreComercial and Estado = 'VENTA' AND FechaVenta < @MesGuia";
            string tasa2;

            using (SqlConnection con2 = new SqlConnection(connectionString2))
            using (SqlCommand cmd2 = new SqlCommand(query2, con2))
            {
                cmd2.Parameters.Add("@NombreComercial", SqlDbType.VarChar, 50).Value = Request.Cookies["empresaadC"].Value;
                cmd2.Parameters.Add("@MesGuia", SqlDbType.DateTime).Value = DateTime.Parse(Request.Cookies["empresmesguiaC"].Value);
                con2.Open();


                using (SqlDataReader dr2 = cmd2.ExecuteReader())
                {

                    if (dr2.Read())
                    {
                        if (dr2.IsDBNull(0))
                        {

                            tasa2 = "0";

                        }
                        else
                        {
                            tasa2 = dr2.GetFieldValue<decimal>(0).ToString();
                            Label3.Text = tasa2.ToString();


                        }


                    }
                    else
                    {
                        tasa = "0";

                    }



                    dr2.Close();
                }

                con2.Close();
            }
            string connectionString3 = Conection.ConexLine;
            string query3 = "SELECT SUM(TotalCobrar) AS TotalVenta FROM Asegurados where NombreComercial = @NombreComercial and Estado = 'EXCLUIDO' AND FechaRet > @MesGuia";
            string tasa3;

            using (SqlConnection con3 = new SqlConnection(connectionString3))
            using (SqlCommand cmd3 = new SqlCommand(query3, con3))
            {
                cmd3.Parameters.Add("@NombreComercial", SqlDbType.VarChar, 50).Value = Request.Cookies["empresaadC"].Value;
                cmd3.Parameters.Add("@MesGuia", SqlDbType.DateTime).Value = DateTime.Parse(Request.Cookies["empresmesguiaC"].Value);
                con3.Open();


                using (SqlDataReader dr3 = cmd3.ExecuteReader())
                {

                    if (dr3.Read())
                    {
                        if (dr3.IsDBNull(0))
                        {

                            tasa3 = "0";

                        }
                        else
                        {
                            tasa3 = dr3.GetFieldValue<decimal>(0).ToString();
                            Label4.Text = tasa3;


                        }


                    }
                    else
                    {
                        tasa = "0";

                    }



                    dr3.Close();
                }

                con3.Close();
            }
            if (Request.Cookies["paramCedula"] != null)
            {
                if (GridView1.Rows.Count == 0)
                {
                    Label1.Attributes.Add("style", "display:inline, font-weight: bold; font-size: 18px;");
                    //INCLU.Attributes.Add("style", "display:inline");
                    Label1.Text = "El registro no existe en nuestra base de Datos";

                }
                else
                {
                    Label1.Attributes.Add("style", "display:none");
                    //INCLU.Attributes.Add("style", "display:none");
                }
            }
            else
            {

            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = GridView1.SelectedIndex;
            

            HttpCookie fecha2S = new HttpCookie("cedulacobC");
            fecha2S.Value = GridView1.Rows[i].Cells[0].Text;
            fecha2S.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(fecha2S);

            HttpCookie fecha2Sx = new HttpCookie("emprecobnom");
            fecha2Sx.Value = GridView2.Rows[0].Cells[0].Text;
            fecha2Sx.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(fecha2Sx);

            HttpCookie fecha2Sx1 = new HttpCookie("nomcobnom");
            fecha2Sx1.Value = GridView1.Rows[i].Cells[1].Text;
            fecha2Sx1.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(fecha2Sx1);

            HttpCookie fecha2Sx2 = new HttpCookie("montcobnom");
            fecha2Sx2.Value = GridView1.Rows[i].Cells[2].Text;
            fecha2Sx2.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(fecha2Sx2);

            HttpCookie fecha2Sx3 = new HttpCookie("certcobnom");
            fecha2Sx3.Value = GridView1.Rows[i].Cells[3].Text;
            fecha2Sx3.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(fecha2Sx3);

            using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
            {
                string saveStaff = "INSERT into Morosos (Nombre, Ceudla, NumeroCertificado, Total, Empresa, Mes) VALUES (@Nombre, @Cedula, @NumeroCetificado, @Total, @Empresa, @Mes)";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
                    querySaveStaff.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = GridView1.Rows[i].Cells[1].Text; 
                    querySaveStaff.Parameters.Add("@Cedula", SqlDbType.Int).Value = GridView1.Rows[i].Cells[0].Text;
                    querySaveStaff.Parameters.Add("@NumeroCetificado", SqlDbType.VarChar).Value = GridView1.Rows[i].Cells[3].Text;
                    querySaveStaff.Parameters.Add("@Total", SqlDbType.Money).Value = Decimal.Parse(GridView1.Rows[i].Cells[2].Text);
                    querySaveStaff.Parameters.Add("@Empresa", SqlDbType.VarChar).Value = GridView2.Rows[0].Cells[0].Text;
                    querySaveStaff.Parameters.Add("@Mes", SqlDbType.VarChar).Value = Request.Cookies["empresmesC"].Value;
                    
                    try
                    {
                        openCon.Open();
                        querySaveStaff.ExecuteNonQuery();
                        openCon.Close();
                        Response.Write("<script>alert('TOMADOR REGISTRADO COMO IMPAGO')</script>");
                    }
                    catch (SqlException ex)
                    {
                        Response.Write("Error" + ex);
                    }
                }
            }

            

        }
        protected void Unnamed1_Click(object sender, EventArgs e)
        {

            //GridView1.DataSource = null;
            //SqlDataSource1.DataBind();
            //string buscar = Correo.Value;
            //HttpCookie buscarS = new HttpCookie("paramCedula");
            //buscarS.Value = buscar;
            //buscarS.Expires = DateTime.Now.AddDays(30);
            //Response.Cookies.Add(buscarS);
            //DateTime FECHA = DateTime.Now;
            //HttpCookie fechaS = new HttpCookie("fechaC");
            //fechaS.Value = FECHA.ToString();
            //fechaS.Expires = DateTime.Now.AddDays(30);
            //Response.Cookies.Add(fechaS);
            //Response.Redirect("ReclamoHistCons.aspx");

        }
        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            Response.Redirect("CobranzaTomadorUno.aspx");

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