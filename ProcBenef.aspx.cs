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
    public partial class ProcBenef : Page
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
                string query = "SELECT Beneficiario1, Beneficiario2, Beneficiario3, beneficiario4, Beneficiario5 FROM Asegurados WHERE NumeroCertificado=@NumeroCertificado AND Nombre=@Nombre;";


                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {

                    cmd.Parameters.Add("@NumeroCertificado", SqlDbType.Int, 50).Value = Int32.Parse(GridView2.Rows[i].Cells[1].Text);
                    cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = GridView2.Rows[i].Cells[3].Text;


                    con.Open();


                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {


                            string genero;
                            if (dr.IsDBNull(0))
                            {
                                genero = "";
                            }
                            else
                            {
                                genero = dr.GetFieldValue<string>(0);
                            }
                            string direccion;
                            if (dr.IsDBNull(1))
                            {
                                direccion = "";
                            }
                            else
                            {
                                direccion = dr.GetFieldValue<string>(1);
                            }
                            string direccionemp;
                            if (dr.IsDBNull(2))
                            {
                                direccionemp = "";
                            }
                            else
                            {
                                direccionemp = dr.GetFieldValue<string>(2);
                            }
                            string cargo;
                            if (dr.IsDBNull(3))
                            {
                                cargo = "";
                            }
                            else
                            {
                                cargo = dr.GetFieldValue<string>(3);
                            }
                            string codigo;
                            if (dr.IsDBNull(4))
                            {
                                codigo = "";
                            }
                            else
                            {
                                codigo = dr.GetFieldValue<string>(4);
                            }







                            HttpCookie idclienteS = new HttpCookie("benef1");
                            idclienteS.Value = genero;
                            idclienteS.Expires = DateTime.Now.AddDays(30);
                            Response.Cookies.Add(idclienteS);

                            HttpCookie perfilS = new HttpCookie("benef2");
                            perfilS.Value = direccion;
                            perfilS.Expires = DateTime.Now.AddDays(30);
                            Response.Cookies.Add(perfilS);

                            HttpCookie nombre1S = new HttpCookie("benef3");
                            nombre1S.Value = direccionemp;
                            nombre1S.Expires = DateTime.Now.AddDays(30);
                            Response.Cookies.Add(nombre1S);

                            HttpCookie idcliente1S = new HttpCookie("benef4");
                            idcliente1S.Value = cargo;
                            idcliente1S.Expires = DateTime.Now.AddDays(30);
                            Response.Cookies.Add(idcliente1S);

                            HttpCookie perfil1S = new HttpCookie("benef5");
                            perfil1S.Value = codigo;
                            perfil1S.Expires = DateTime.Now.AddDays(30);
                            Response.Cookies.Add(perfil1S);








                        }
                        else
                        {

                        }

                        dr.Close();
                    }

                    con.Close();
                }
                HttpCookie codigoS = new HttpCookie("paramCert");
                codigoS.Value = GridView2.Rows[i].Cells[1].Text;
                codigoS.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(codigoS);

                HttpCookie nombretomS = new HttpCookie("nombretomC");
                nombretomS.Value = GridView2.Rows[i].Cells[3].Text;
                nombretomS.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(nombretomS);

                DateTime FECHA = DateTime.Now;
                HttpCookie fechaS = new HttpCookie("fechaC");
                fechaS.Value = FECHA.ToString();
                fechaS.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(fechaS);

                HttpCookie indexS = new HttpCookie("indexC");
                indexS.Value = "27";
                indexS.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(indexS);

                HttpCookie index2S = new HttpCookie("ejecprocC");
                index2S.Value = GridView2.Rows[i].Cells[4].Text; ;
                index2S.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(index2S);

                Response.Redirect("BeneficiariosEdit.aspx");
            }
            else
            {
                int i = GridView1.SelectedIndex;
                string connectionString = Conection.ConexLine;
                string query = "SELECT Beneficiario1, Beneficiario2, Beneficiario3, beneficiario4, Beneficiario5 FROM Asegurados WHERE NumeroCertificado=@NumeroCertificado AND Nombre=@Nombre;";


                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {

                    cmd.Parameters.Add("@NumeroCertificado", SqlDbType.Int, 50).Value = Int32.Parse(GridView1.Rows[i].Cells[1].Text);
                    cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = GridView1.Rows[i].Cells[3].Text;


                    con.Open();


                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {


                            string genero;
                            if (dr.IsDBNull(0))
                            {
                                genero = "";
                            }
                            else
                            {
                                genero = dr.GetFieldValue<string>(0);
                            }
                            string direccion;
                            if (dr.IsDBNull(1))
                            {
                                direccion = "";
                            }
                            else
                            {
                                direccion = dr.GetFieldValue<string>(1);
                            }
                            string direccionemp;
                            if (dr.IsDBNull(2))
                            {
                                direccionemp = "";
                            }
                            else
                            {
                                direccionemp = dr.GetFieldValue<string>(2);
                            }
                            string cargo;
                            if (dr.IsDBNull(3))
                            {
                                cargo = "";
                            }
                            else
                            {
                                cargo = dr.GetFieldValue<string>(3);
                            }
                            string codigo;
                            if (dr.IsDBNull(4))
                            {
                                codigo = "";
                            }
                            else
                            {
                                codigo = dr.GetFieldValue<string>(4);
                            }







                            HttpCookie idclienteS = new HttpCookie("benef1");
                            idclienteS.Value = genero;
                            idclienteS.Expires = DateTime.Now.AddDays(30);
                            Response.Cookies.Add(idclienteS);

                            HttpCookie perfilS = new HttpCookie("benef2");
                            perfilS.Value = direccion;
                            perfilS.Expires = DateTime.Now.AddDays(30);
                            Response.Cookies.Add(perfilS);

                            HttpCookie nombre1S = new HttpCookie("benef3");
                            nombre1S.Value = direccionemp;
                            nombre1S.Expires = DateTime.Now.AddDays(30);
                            Response.Cookies.Add(nombre1S);

                            HttpCookie idcliente1S = new HttpCookie("benef4");
                            idcliente1S.Value = cargo;
                            idcliente1S.Expires = DateTime.Now.AddDays(30);
                            Response.Cookies.Add(idcliente1S);

                            HttpCookie perfil1S = new HttpCookie("benef5");
                            perfil1S.Value = codigo;
                            perfil1S.Expires = DateTime.Now.AddDays(30);
                            Response.Cookies.Add(perfil1S);








                        }
                        else
                        {

                        }

                        dr.Close();
                    }

                    con.Close();
                }
                HttpCookie codigoS = new HttpCookie("paramCert");
                codigoS.Value = GridView2.Rows[i].Cells[1].Text;
                codigoS.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(codigoS);

                HttpCookie nombretomS = new HttpCookie("nombretomC");
                nombretomS.Value = GridView2.Rows[i].Cells[3].Text;
                nombretomS.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(nombretomS);

                DateTime FECHA = DateTime.Now;
                HttpCookie fechaS = new HttpCookie("fechaC");
                fechaS.Value = FECHA.ToString();
                fechaS.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(fechaS);

                HttpCookie indexS = new HttpCookie("indexC");
                indexS.Value = "27";
                indexS.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(indexS);

                HttpCookie index2S = new HttpCookie("ejecprocC");
                index2S.Value = GridView2.Rows[i].Cells[4].Text; ;
                index2S.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(index2S);

                Response.Redirect("BeneficiariosEdit.aspx");


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
            Response.Redirect("ProcBenef.aspx");

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