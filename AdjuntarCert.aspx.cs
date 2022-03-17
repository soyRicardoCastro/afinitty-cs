using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReachSystem
{
    public partial class AdjuntarCert : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["indexC"] != null)
            {
                if (Request.Cookies["indexC"].Value == "11")
                {
                    DropDownList1.Attributes.Add("style", "display:none");
                    Label6.Attributes.Add("style", "display:none");
                    Label4.Attributes.Add("style", "display:none");
                    Label3.Attributes.Add("style", "display:none");
                    Label8.Attributes.Add("style", "display:none");
                    Button3.Attributes.Add("style", "display:none");
                    GridView2.Attributes.Add("style", "display:none");
                }
                else if (Request.Cookies["indexC"].Value == "2")
                {
                    DropDownList1.Attributes.Add("style", "display:none");
                    Label6.Attributes.Add("style", "display:none");
                    Label4.Attributes.Add("style", "display:none");
                    Label2.Attributes.Add("style", "display:none");
                    Label8.Attributes.Add("style", "display:none");
                    Button3.Attributes.Add("style", "display:none");
                    GridView2.Attributes.Add("style", "display:none");
                }
                else if (Request.Cookies["indexC"].Value == "15")
                {
                    DropDownList1.Attributes.Add("style", "display:none");
                    Label6.Attributes.Add("style", "display:none");
                    Label4.Attributes.Add("style", "display:none");
                    Label2.Attributes.Add("style", "display:none");
                    Label8.Attributes.Add("style", "display:none");
                    Button3.Attributes.Add("style", "display:none");
                    GridView2.Attributes.Add("style", "display:none");
                }
                else if (Request.Cookies["indexC"].Value == "3")
                {
                    DropDownList1.Attributes.Add("style", "display:none");
                    Label6.Attributes.Add("style", "display:none");
                    Label4.Attributes.Add("style", "display:none");
                    Label2.Attributes.Add("style", "display:none");
                    Label8.Attributes.Add("style", "display:none");
                    Button3.Attributes.Add("style", "display:none");
                    GridView2.Attributes.Add("style", "display:none");
                }
                else if (Request.Cookies["indexC"].Value == "30")
                {
                    DropDownList1.Attributes.Add("style", "display:none");
                    Label6.Attributes.Add("style", "display:none");
                    Label4.Attributes.Add("style", "display:none");
                    Label2.Attributes.Add("style", "display:none");
                    Label3.Attributes.Add("style", "display:none");
                    Button3.Attributes.Add("style", "display:none");
                    GridView2.Attributes.Add("style", "display:none");
                }
                else if (Request.Cookies["indexC"].Value == "8")
                {
                    Label2.Attributes.Add("style", "display:none");
                    Label3.Attributes.Add("style", "display:none");
                    Label8.Attributes.Add("style", "display:none");
                    RequiredFieldValidator1.Enabled = false;
                    GridView1.Attributes.Add("style", "display:none");
                    
                    string connectionString = Conection.ConexLine;
                    string query = "Select Proceso from Asegurados where  NumeroCertificado = " + Request.Cookies["paramCert"].Value + "";


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
                                    DropDownList1.SelectedValue = "INGRESADO";
                                }
                                else
                                {                                                                        
                                    DropDownList1.SelectedValue = dr.GetFieldValue<string>(0);                                                                      
                                }



                            }
                            else
                            {


                            }



                            dr.Close();
                        }

                        con.Close();
                    }
                    Response.Cookies["indexC"].Expires = DateTime.Now.AddDays(-1);
                    HttpCookie indexS = new HttpCookie("indexC");
                    indexS.Value = "9";
                    indexS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(indexS);
                }
                else if (Request.Cookies["indexC"].Value == "9")
                {
                    Label2.Attributes.Add("style", "display:none");
                    Label3.Attributes.Add("style", "display:none");
                    Label8.Attributes.Add("style", "display:none");
                    RequiredFieldValidator1.Enabled = false;
                    GridView1.Attributes.Add("style", "display:none");
                }
                else
                {
                    Label2.Attributes.Add("style", "display:none");
                    Label3.Attributes.Add("style", "display:none");
                    Label8.Attributes.Add("style", "display:none");
                    GridView2.Attributes.Add("style", "display:none");
                }
            
            }
            else
            {
                Label2.Attributes.Add("style", "display:none");
                Label3.Attributes.Add("style", "display:none");
                Label8.Attributes.Add("style", "display:none");
                GridView2.Attributes.Add("style", "display:none");
            }
        }
            
            
        

        
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            string transferente1;
            string transferente2;
            string transferente3;
            using (BinaryReader reader = new BinaryReader(FileUpload1.PostedFile.InputStream))
            {
                if (FileUpload1.HasFile == true)
                {
                    var Archivod1 = reader.ReadBytes(FileUpload1.PostedFile.ContentLength);
                    transferente1 = Convert.ToBase64String(Archivod1);
                    
                }
                else
                {
                    transferente1 = "";
                }
            }
            using (BinaryReader reader2 = new BinaryReader(FileUpload2.PostedFile.InputStream))
            {
                if (FileUpload2.HasFile == true)
                {
                    var Archivod2 = reader2.ReadBytes(FileUpload2.PostedFile.ContentLength);
                    transferente2 = Convert.ToBase64String(Archivod2);

                }
                else
                {
                    transferente2 = "";
                }
            }
            using (BinaryReader reader3 = new BinaryReader(FileUpload3.PostedFile.InputStream))
            {
                if (FileUpload3.HasFile == true)
                {
                    var Archivod3 = reader3.ReadBytes(FileUpload3.PostedFile.ContentLength);
                    transferente3 = Convert.ToBase64String(Archivod3);

                }
                else
                {
                    transferente3 = "";
                }
            }
            if (transferente1 != "")
            {
                if (Request.Cookies["indexC"] != null)
                {
                    if (Request.Cookies["indexC"].Value == "9")
                    {
                        string EstadoFinal;
                        if (DropDownList1.SelectedValue == "REVISADO")
                        {
                            EstadoFinal = "VENTA";
                        }
                        else
                        {
                            EstadoFinal = "PREVENTA";
                        }
                        using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
                        {

                            string saveStaff = "UPDATE Asegurados SET Archivo1=@Archivo1, Archivo2=@Archivo2, Archivo3=@Archivo3, Proceso=@Proceso, Estado=@Estado WHERE NumeroCertificado=@NumeroCertificado";

                            using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                            {
                                querySaveStaff.Connection = openCon;
                                querySaveStaff.Parameters.Add("@Archivo1", SqlDbType.VarChar).Value = transferente1;
                                querySaveStaff.Parameters.Add("@Archivo2", SqlDbType.VarChar).Value = transferente2;
                                querySaveStaff.Parameters.Add("@Archivo3", SqlDbType.VarChar).Value = transferente3;
                                querySaveStaff.Parameters.Add("@Proceso", SqlDbType.VarChar).Value = DropDownList1.SelectedValue;
                                querySaveStaff.Parameters.Add("@Estado", SqlDbType.VarChar).Value = EstadoFinal;
                                querySaveStaff.Parameters.Add("@NumeroCertificado", SqlDbType.Int).Value = Int32.Parse(Request.Cookies["paramCert"].Value);
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
                        using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
                        {

                            string saveStaff = "UPDATE Dependientes SET Estado=@Estado WHERE NumeroCertificado=@NumeroCertificado";

                            using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                            {
                                querySaveStaff.Connection = openCon;
                                querySaveStaff.Parameters.Add("@Estado", SqlDbType.VarChar).Value = EstadoFinal;
                                querySaveStaff.Parameters.Add("@NumeroCertificado", SqlDbType.Int).Value = Int32.Parse(Request.Cookies["paramCert"].Value);
                                try
                                {
                                    openCon.Open();
                                    querySaveStaff.ExecuteNonQuery();
                                    openCon.Close();
                                    HttpCookie indexS = new HttpCookie("indexC");
                                    indexS.Value = "8";
                                    indexS.Expires = DateTime.Now.AddDays(30);
                                    Response.Cookies.Add(indexS);
                                    Response.Cookies["paramCedula"].Expires = DateTime.Now.AddDays(-1);
                                    Response.Cookies["paramCert"].Expires = DateTime.Now.AddDays(-1);
                                    Page.RegisterStartupScript("LoadFunction", "<script type='text/javascript'>alert('PROCESO FINALIZADO CON EXITO');window.location='ProcCert.aspx'</script>");

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
                        using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
                        {

                            string saveStaff = "UPDATE Asegurados SET Archivo1=@Archivo1, Archivo2=@Archivo2, Archivo3=@Archivo3, Proceso=@Proceso WHERE NumeroCertificado=@NumeroCertificado";

                            using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                            {
                                querySaveStaff.Connection = openCon;
                                querySaveStaff.Parameters.Add("@Archivo1", SqlDbType.VarChar).Value = transferente1;
                                querySaveStaff.Parameters.Add("@Archivo2", SqlDbType.VarChar).Value = transferente2;
                                querySaveStaff.Parameters.Add("@Archivo3", SqlDbType.VarChar).Value = transferente3;
                                querySaveStaff.Parameters.Add("@Proceso", SqlDbType.VarChar).Value = DropDownList1.SelectedValue;
                                querySaveStaff.Parameters.Add("@NumeroCertificado", SqlDbType.Int).Value = Int32.Parse(Request.Cookies["paramCert"].Value);
                                try
                                {
                                    openCon.Open();
                                    querySaveStaff.ExecuteNonQuery();
                                    openCon.Close();
                                    HttpCookie indexS = new HttpCookie("indexC");
                                    indexS.Value = "8";
                                    indexS.Expires = DateTime.Now.AddDays(30);
                                    Response.Cookies.Add(indexS);
                                    Response.Cookies["paramCedula"].Expires = DateTime.Now.AddDays(-1);
                                    Response.Cookies["paramCert"].Expires = DateTime.Now.AddDays(-1);
                                    Page.RegisterStartupScript("LoadFunction", "<script type='text/javascript'>alert('PROCESO FINALIZADO CON EXITO');window.location='Default.aspx'</script>");

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

                        string saveStaff = "UPDATE Asegurados SET Proceso=@Proceso WHERE NumeroCertificado=@NumeroCertificado";

                        using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                        {
                            querySaveStaff.Connection = openCon;                           
                            querySaveStaff.Parameters.Add("@Proceso", SqlDbType.VarChar).Value = DropDownList1.SelectedValue;
                            querySaveStaff.Parameters.Add("@NumeroCertificado", SqlDbType.Int).Value = Int32.Parse(Request.Cookies["paramCert"].Value);
                            try
                            {
                                openCon.Open();
                                querySaveStaff.ExecuteNonQuery();
                                openCon.Close();
                                HttpCookie indexS = new HttpCookie("indexC");
                                indexS.Value = "8";
                                indexS.Expires = DateTime.Now.AddDays(30);
                                Response.Cookies.Add(indexS);
                                Response.Cookies["paramCedula"].Expires = DateTime.Now.AddDays(-1);
                                Response.Cookies["paramCert"].Expires = DateTime.Now.AddDays(-1);
                                Page.RegisterStartupScript("LoadFunction", "<script type='text/javascript'>alert('PROCESO FINALIZADO CON EXITO');window.location='Default.aspx'</script>");

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
        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            Response.Redirect("InclusionTomador.aspx");

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["indexC"] != null)
            {
                if (Request.Cookies["indexC"].Value == "8")
                {
                    HttpCookie indexS = new HttpCookie("indexC");
                    indexS.Value = "8";
                    indexS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(indexS);
                    Response.Redirect("InclusionCertificados.aspx");
                }
                else if (Request.Cookies["indexC"].Value == "9")
                {
                    HttpCookie indexS = new HttpCookie("indexC");
                    indexS.Value = "8";
                    indexS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(indexS);
                    Response.Redirect("InclusionCertificados.aspx");
                }
                else
                {
                    Response.Redirect("InclusionCertificados.aspx");
                }
            }
            else
            {
                Response.Redirect("InclusionCertificados.aspx");
            }
            
        }

        protected void Unnamed_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void descarga1(object sender, EventArgs e)
        {

            using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
            {
                string saveStaff = "SELECT Archivo1 FROM Asegurados WHERE NumeroCertificado=@NumeroCertificado";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
                    querySaveStaff.Parameters.Add("@NumeroCertificado", SqlDbType.Int).Value = Request.Cookies["paramCert"].Value;


                    try
                    {
                        openCon.Open();
                        using (SqlDataReader dr = querySaveStaff.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                string archivo = dr.GetFieldValue<string>(0);
                                var transporte = Convert.FromBase64String(archivo);
                                Response.Clear();
                                Response.ClearHeaders();
                                Response.ContentType = "application/pdf";
                                Response.AddHeader("content-disposition", "attachment; filename=" + "CERTIFICADO NUMERO " + GridView1.Rows[0].Cells[1].Text + ".pdf");
                                Response.BufferOutput = true; ;
                                Response.OutputStream.Write(transporte, 0, transporte.Length);
                                Response.End();

                            }
                            else
                            {

                            }

                            dr.Close();
                        }
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