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
    public partial class AdicionSeleccion : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["indexC"] != null)
            {
                if (Request.Cookies["indexC"].Value == "8")
                {
                    Label4.Attributes.Add("style", "display:none");
                    Label7.Attributes.Add("style", "display:none");
                    GridView5.Attributes.Add("style", "display:none");
                    Label3.Attributes.Add("style", "display:none");
                    GridView2.Attributes.Add("style", "display:none");
                    Label6.Attributes.Add("style", "display:none");
                    GridView3.Attributes.Add("style", "display:none");
                    GridView4.Attributes.Add("style", "display:none");
                    ADIC.Attributes.Add("style", "display:none");
                    Button1.Attributes.Add("style", "display:none");
                    Button2.Attributes.Add("style", "display:none");
                    INCLU.Attributes.Add("style", "display:none");
                }
                else if (Request.Cookies["indexC"].Value == "9")
                {
                    HttpCookie indexS = new HttpCookie("indexC");
                    indexS.Value = "8";
                    indexS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(indexS);
                }
                else if (Request.Cookies["indexC"].Value == "15")
                {
                    Label4.Attributes.Add("style", "display:none");
                    Label3.Attributes.Add("style", "display:none");
                    GridView2.Attributes.Add("style", "display:none");
                    GridView4.Attributes.Add("style", "display:none");
                    Label2.Attributes.Add("style", "display:none");
                    GridView1.Attributes.Add("style", "display:none");
                    siguiente.Attributes.Add("style", "display:none");
                    Button1.Attributes.Add("style", "display:none");
                    Button3.Attributes.Add("style", "display:none");
                    Decimal total;
                    string connectionString = Conection.ConexLine;
                    string query = "Select SUM(TotalPrima) from Dependientes where CedulaTomador = "+ Request.Cookies["paramCedula"].Value + " AND NumeroCertificado = "+ Request.Cookies["paramCert"].Value + " AND Estado <> 'EXCLUIDO'";

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
                                    total = 0;
                                }
                                else
                                {
                                    total = dr.GetFieldValue<decimal>(0);
                                    Label5.Text = "PRIMA CERTIFICADO: "+total.ToString()+"";
                                }
                            }
                            else
                            {
                                total = 0;
                            }
                            dr.Close();
                        }
                        con.Close();
                    }

                }
                else if (Request.Cookies["indexC"].Value == "30")
                {
                    Label7.Attributes.Add("style", "display:none");
                    GridView5.Attributes.Add("style", "display:none");
                    Label4.Attributes.Add("style", "display:none");
                    Label6.Attributes.Add("style", "display:none");
                    Label2.Attributes.Add("style", "display:none");
                    GridView1.Attributes.Add("style", "display:none");
                    GridView3.Attributes.Add("style", "display:none");
                    GridView4.Attributes.Add("style", "display:none");
                    siguiente.Attributes.Add("style", "display:none");
                    Button3.Attributes.Add("style", "display:none");
                    Decimal total;
                    string connectionString = Conection.ConexLine;
                    string query = "Select SUM(TotalPrima) from Dependientes where CedulaTomador = " + Request.Cookies["paramCedula"].Value + " AND NumeroCertificado = " + Request.Cookies["paramCert"].Value + " AND Estado <> 'EXCLUIDO'";
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
                                    total = 0;
                                }
                                else
                                {
                                    total = dr.GetFieldValue<decimal>(0);
                                    Label5.Text = "PRIMA CERTIFICADO: " + total.ToString() + "";
                                }


                            }
                            else
                            {
                                total = 0;

                            }



                            dr.Close();
                        }

                        con.Close();
                    }

                }
                else if (Request.Cookies["indexC"].Value == "2")
                {
                    Label4.Attributes.Add("style", "display:none");
                    Label3.Attributes.Add("style", "display:none");
                    Label2.Attributes.Add("style", "display:none");
                    GridView1.Attributes.Add("style", "display:none");
                    GridView2.Attributes.Add("style", "display:none");
                    GridView4.Attributes.Add("style", "display:none");
                    siguiente.Attributes.Add("style", "display:none");
                    Button1.Attributes.Add("style", "display:none");
                    Button3.Attributes.Add("style", "display:none");
                }
                else if (Request.Cookies["indexC"].Value == "99")
                {
                    Label7.Attributes.Add("style", "display:none");
                    GridView5.Attributes.Add("style", "display:none");
                    Label6.Attributes.Add("style", "display:none");
                    Label3.Attributes.Add("style", "display:none");
                    Label2.Attributes.Add("style", "display:none");
                    GridView1.Attributes.Add("style", "display:none");
                    GridView2.Attributes.Add("style", "display:none");
                    GridView3.Attributes.Add("style", "display:none");
                    siguiente.Attributes.Add("style", "display:none");
                    Button1.Attributes.Add("style", "display:none");
                    Button2.Attributes.Add("style", "display:none");
                    ADIC.Attributes.Add("style", "display:none");
                    Button3.Attributes.Add("style", "display:none");            
                }
            }
            else
            {
                siguiente.Attributes.Add("style", "display:none");
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Request.Cookies["indexC"] != null)
            {
                if (Request.Cookies["indexC"].Value == "8")
                {                    
                    int i = GridView1.SelectedIndex;

                    HttpCookie fechavigS = new HttpCookie("fechavigC");
                    fechavigS.Value = GridView1.Rows[i].Cells[8].Text;
                    fechavigS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(fechavigS);

                    HttpCookie claseS = new HttpCookie("paramCedulaD");
                    claseS.Value = GridView1.Rows[i].Cells[0].Text;
                    claseS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(claseS);
                    

                    HttpCookie idclienteS = new HttpCookie("generotomC");
                    idclienteS.Value = GridView1.Rows[i].Cells[2].Text;
                    idclienteS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(idclienteS);

                    HttpCookie perfilS = new HttpCookie("fechanacC");
                    perfilS.Value = DateTime.Parse(GridView1.Rows[i].Cells[4].Text).ToString();
                    perfilS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(perfilS);

                    HttpCookie nombreadS = new HttpCookie("nombreadC");
                    nombreadS.Value = GridView1.Rows[i].Cells[1].Text;
                    nombreadS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(nombreadS);

                    HttpCookie clase2S = new HttpCookie("relaproaD");
                    clase2S.Value = GridView1.Rows[i].Cells[3].Text;
                    clase2S.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(clase2S);


                    HttpCookie idcliente2S = new HttpCookie("cobproC");
                    idcliente2S.Value = GridView1.Rows[i].Cells[5].Text;
                    idcliente2S.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(idcliente2S);

                    HttpCookie perfil2S = new HttpCookie("planproC");
                    perfil2S.Value = GridView1.Rows[i].Cells[6].Text;
                    perfil2S.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(perfil2S);

                    HttpCookie perfil3S = new HttpCookie("primaproC");
                    perfil3S.Value = GridView1.Rows[i].Cells[7].Text;
                    perfil3S.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(perfil3S);

                    HttpCookie perfil3S7 = new HttpCookie("rowC");
                    perfil3S7.Value = GridView1.Rows[i].Cells[9].Text;
                    perfil3S7.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(perfil3S7);

                    Response.Redirect("InclusionAegurados.aspx");
                }
                else if (Request.Cookies["indexC"].Value == "30")
                {
                    int i = GridView2.SelectedIndex;

                    HttpCookie fechavigS = new HttpCookie("fechavigC");
                    fechavigS.Value = "" + DateTime.Now.Year + "-" + DateTime.Now.AddMonths(1).Month + "-01";
                    fechavigS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(fechavigS);

                    HttpCookie claseS = new HttpCookie("paramCedulaD");
                    claseS.Value = GridView2.Rows[i].Cells[0].Text;
                    claseS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(claseS);


                    HttpCookie idclienteS = new HttpCookie("generotomC");
                    idclienteS.Value = GridView2.Rows[i].Cells[2].Text;
                    idclienteS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(idclienteS);

                    HttpCookie perfilS = new HttpCookie("fechanacC");
                    perfilS.Value = DateTime.Parse(GridView2.Rows[i].Cells[4].Text).ToString();
                    perfilS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(perfilS);

                    HttpCookie nombreadS = new HttpCookie("nombreadC");
                    nombreadS.Value = GridView2.Rows[i].Cells[1].Text;
                    nombreadS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(nombreadS);

                    HttpCookie clase2S = new HttpCookie("relaproaD");
                    clase2S.Value = GridView2.Rows[i].Cells[3].Text;
                    clase2S.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(clase2S);


                    HttpCookie idcliente2S = new HttpCookie("cobproC");
                    idcliente2S.Value = GridView2.Rows[i].Cells[5].Text;
                    idcliente2S.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(idcliente2S);

                    HttpCookie perfil2S = new HttpCookie("planproC");
                    perfil2S.Value = GridView2.Rows[i].Cells[6].Text;
                    perfil2S.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(perfil2S);

                    HttpCookie perfil3S = new HttpCookie("primaproC");
                    perfil3S.Value = GridView2.Rows[i].Cells[7].Text;
                    perfil3S.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(perfil3S);

           

                    Response.Redirect("InclusionAegurados.aspx");
                }
                else if (Request.Cookies["indexC"].Value == "3")
                {
                    int i = GridView2.SelectedIndex;

                    HttpCookie fechavigS = new HttpCookie("fechavigC");
                    fechavigS.Value = "" + DateTime.Now.Year + "-" + DateTime.Now.AddMonths(1).Month + "-01";
                    fechavigS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(fechavigS);

                    HttpCookie claseS = new HttpCookie("paramCedulaD");
                    claseS.Value = GridView2.Rows[i].Cells[2].Text;
                    claseS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(claseS);


                    HttpCookie idclienteS = new HttpCookie("generotomC");
                    idclienteS.Value = GridView2.Rows[i].Cells[1].Text;
                    idclienteS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(idclienteS);

                    HttpCookie perfilS = new HttpCookie("fechanacC");
                    perfilS.Value = DateTime.Parse(GridView2.Rows[i].Cells[4].Text).ToString();
                    perfilS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(perfilS);

                    HttpCookie nombreadS = new HttpCookie("nombreadC");
                    nombreadS.Value = GridView2.Rows[i].Cells[0].Text;
                    nombreadS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(nombreadS);

                    HttpCookie clase2S = new HttpCookie("relaproaD");
                    clase2S.Value = GridView2.Rows[i].Cells[3].Text;
                    clase2S.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(clase2S);


                    HttpCookie idcliente2S = new HttpCookie("cobproC");
                    idcliente2S.Value = GridView2.Rows[i].Cells[5].Text;
                    idcliente2S.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(idcliente2S);

                    HttpCookie perfil2S = new HttpCookie("planproC");
                    perfil2S.Value = GridView2.Rows[i].Cells[6].Text;
                    perfil2S.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(perfil2S);

                    HttpCookie perfil3S = new HttpCookie("primaproC");
                    perfil3S.Value = GridView2.Rows[i].Cells[7].Text;
                    perfil3S.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(perfil3S);

                    HttpCookie nombread2S = new HttpCookie("nombreadC");
                    nombread2S.Value = GridView2.Rows[i].Cells[0].Text;
                    nombread2S.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(nombread2S);

                    Response.Redirect("InclusionAegurados.aspx");
                }
                else if (Request.Cookies["indexC"].Value == "99")
                {
                    int i = GridView4.SelectedIndex;

                    HttpCookie fechavigS = new HttpCookie("fechavigC");
                    fechavigS.Value = "" + DateTime.Now.Year + "-" + DateTime.Now.AddMonths(1).Month + "-01";
                    fechavigS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(fechavigS);

                    HttpCookie claseS = new HttpCookie("paramCedulaD");
                    claseS.Value = GridView4.Rows[i].Cells[0].Text;
                    claseS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(claseS);                    

                    HttpCookie perfilS = new HttpCookie("fechanacC");
                    perfilS.Value = DateTime.Parse(GridView4.Rows[i].Cells[3].Text).ToString();
                    perfilS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(perfilS);

                    HttpCookie nombreadS = new HttpCookie("nombreadC");
                    nombreadS.Value = GridView4.Rows[i].Cells[1].Text;
                    nombreadS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(nombreadS);

                    HttpCookie clase2S = new HttpCookie("relaproaD");
                    clase2S.Value = GridView4.Rows[i].Cells[2].Text;
                    clase2S.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(clase2S);

                    HttpCookie idcliente2S = new HttpCookie("cobproC");
                    idcliente2S.Value = GridView4.Rows[i].Cells[4].Text;
                    idcliente2S.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(idcliente2S);

                    HttpCookie perfil2S = new HttpCookie("planproC");
                    perfil2S.Value = GridView4.Rows[i].Cells[5].Text;
                    perfil2S.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(perfil2S);

                    HttpCookie perfil3S = new HttpCookie("primaproC");
                    perfil3S.Value = GridView4.Rows[i].Cells[6].Text;
                    perfil3S.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(perfil3S);

                    Response.Redirect("ReclamosCreacion.aspx");
                }
                else
                {
                    int i = GridView3.SelectedIndex;

                    HttpCookie fechavigS = new HttpCookie("fechavigC");
                    fechavigS.Value = "" + DateTime.Now.Year + "-" + DateTime.Now.AddMonths(1).Month + "-01";
                    fechavigS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(fechavigS);

                    HttpCookie claseS = new HttpCookie("paramCedulaD");
                    claseS.Value = GridView3.Rows[i].Cells[0].Text;
                    claseS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(claseS);

                    HttpCookie indexS = new HttpCookie("indexC");
                    indexS.Value = "2";
                    indexS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(indexS);

                    HttpCookie idclienteS = new HttpCookie("generotomC");
                    idclienteS.Value = GridView3.Rows[i].Cells[2].Text;
                    idclienteS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(idclienteS);

                    HttpCookie perfilS = new HttpCookie("fechanacC");
                    perfilS.Value = DateTime.Parse(GridView3.Rows[i].Cells[4].Text).ToString();
                    perfilS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(perfilS);

                    HttpCookie nombreadS = new HttpCookie("nombreadC");
                    nombreadS.Value = GridView3.Rows[i].Cells[1].Text;
                    nombreadS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(nombreadS);

                    HttpCookie nombreadS2 = new HttpCookie("indexTOM");
                    nombreadS2.Value = "1";
                    nombreadS2.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(nombreadS2);

                    Response.Redirect("InclusionAegurados.aspx");
                }
            }
            else
            {
                int i = GridView3.SelectedIndex;

                HttpCookie fechavigS = new HttpCookie("fechavigC");
                fechavigS.Value = "" + DateTime.Now.Year + "-" + DateTime.Now.AddMonths(1).Month + "-01";
                fechavigS.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(fechavigS);

                HttpCookie claseS = new HttpCookie("paramCedulaD");
                claseS.Value = GridView3.Rows[i].Cells[2].Text;
                claseS.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(claseS);

                HttpCookie indexS = new HttpCookie("indexC");
                indexS.Value = "2";
                indexS.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(indexS);

                HttpCookie idclienteS = new HttpCookie("generotomC");
                idclienteS.Value = GridView3.Rows[i].Cells[1].Text;
                idclienteS.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(idclienteS);

                HttpCookie perfilS = new HttpCookie("fechanacC");
                perfilS.Value = DateTime.Parse(GridView3.Rows[i].Cells[4].Text).ToString();
                perfilS.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(perfilS);

                HttpCookie nombreadS = new HttpCookie("nombreadC");
                nombreadS.Value = GridView3.Rows[i].Cells[0].Text;
                nombreadS.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(nombreadS);

                Response.Redirect("InclusionAegurados.aspx");
            }
            
        }
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            if(Request.Cookies["indexC"].Value == "30")
            {
                HttpCookie indexS = new HttpCookie("indexC");
                indexS.Value = "35";
                indexS.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(indexS);
            }
            else
            {
                HttpCookie indexS = new HttpCookie("indexC");
                indexS.Value = "3";
                indexS.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(indexS);
            }
                        
            HttpCookie fechavigS = new HttpCookie("fechavigC");
            fechavigS.Value = "" + DateTime.Now.Year + "-" + DateTime.Now.AddMonths(1).Month + "-01";
            fechavigS.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(fechavigS);

            Response.Redirect("InclusionAegurados.aspx");
        }
        
        protected void siguiclick(object sender, EventArgs e)
        {
            if (Request.Cookies["indexC"] != null)
            {
                if (Request.Cookies["indexC"].Value == "2")
                {
                    Response.Redirect("ListaTotal.aspx");
                }
                else if (Request.Cookies["indexC"].Value == "30")
                {
                    Response.Redirect("ListaTotal.aspx");
                }
                else if (Request.Cookies["indexC"].Value == "30")
                {
                    Response.Redirect("ListaTotal.aspx");
                }
                else if (Request.Cookies["indexC"].Value == "99")
                {
                    Response.Redirect("ReclamoCons.aspx");
                }
                else if (Request.Cookies["indexC"].Value == "15")
                {
                    Response.Redirect("ListaTotal.aspx");
                }
                else if (Request.Cookies["indexC"].Value == "8")
                {
                    HttpCookie indexS = new HttpCookie("indexC");
                    indexS.Value = "9";
                    indexS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(indexS);

                    string connectionString = Conection.ConexLine;
                    string query = "SELECT Producto FROM Dependientes WHERE (Producto='MUERTE ACCIDENTAL Y DESMEMBRACION ACCIDENTAL' AND NumeroCertificado=@Certificado) OR (Producto='BECA EDUCATIVA' AND NumeroCertificado=@Certificado)";

                    using (SqlConnection con = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.Add("@Certificado", SqlDbType.VarChar, 50).Value = Request.Cookies["paramCert"].Value;
                        con.Open();
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                if (dr.IsDBNull(0))
                                {
                                    Response.Redirect("MedioCobro.aspx");
                                }                                
                                else
                                {
                                    string connectionString2 = Conection.ConexLine;
                                    string query2 = "SELECT Beneficiario1 FROM Asegurados WHERE NumeroCertificado=@Certificado";

                                    using (SqlConnection con2 = new SqlConnection(connectionString2))
                                    using (SqlCommand cmd2 = new SqlCommand(query2, con2))
                                    {
                                        cmd2.Parameters.Add("@Certificado", SqlDbType.VarChar, 50).Value = Request.Cookies["paramCert"].Value;
                                        con2.Open();
                                        using (SqlDataReader dr2 = cmd2.ExecuteReader())
                                        {
                                            if (dr2.Read())
                                            {
                                                if (dr2.IsDBNull(0))
                                                {
                                                    Response.Redirect("Beneficiarios.aspx");
                                                }
                                                else
                                                {
                                                    Response.Redirect("MedioCobro.aspx");
                                                }
                                            }
                                            else
                                            {
                                                Response.Redirect("MedioCobro.aspx");
                                            }
                                            dr2.Close();
                                        }
                                        con2.Close();                                        
                                    } 
                                }

                            }
                            else
                            {
                                Response.Redirect("MedioCobro.aspx");
                            }

                            dr.Close();
                        }

                        con.Close();
                    }                    
                }
                else
                {
                    Response.Redirect("Beneficiarios.aspx");
                }
            }
            else
            {
                Response.Redirect("Beneficiarios.aspx");
            }                
        }
        protected void elim(object sender, EventArgs e)
        {
            Response.Redirect("ReemplazoElim.aspx");
        }
        protected void volverclick(object sender, EventArgs e)
        {
            HttpCookie indexS = new HttpCookie("indexC");
            indexS.Value = "9";
            indexS.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(indexS);
            Response.Redirect("InclusionTomador.aspx");
        }
        protected void cancelar(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}