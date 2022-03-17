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
    public partial class RetenFin : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["Indext"] != null)
            {
                if(Request.Cookies["Indext"].Value == "1")
                {
                    Label1.Value = DateTime.Now.ToString();
                    //Correo.Value = "" + DateTime.Now.Year + "-" + DateTime.Now.Month.ToString("00") + "-" + DateTime.Now.Day.ToString("00") + "";
                    string connectionString = Conection.ConexLine;
                    string query = "SELECT Retencion FROM Asegurados WHERE NumeroCertificado=@NumeroCertificado";


                    using (SqlConnection con = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {

                        cmd.Parameters.Add("@NumeroCertificado", SqlDbType.VarChar, 50).Value = Request.Cookies["paramCert"].Value;



                        con.Open();


                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {


                                if (dr.IsDBNull(0))
                                {
                                    GridView2.Attributes.Add("style", "display:none");
                                }
                                else
                                {
                                    Label3.Attributes.Add("style", "display:none");
                                    DropDownList2.Attributes.Add("style", "display:none");
                                    Label5.Attributes.Add("style", "display:none");
                                    DropDownList3.Attributes.Add("style", "display:none");
                                    Label7.Attributes.Add("style", "display:none");
                                    DropDownList4.Attributes.Add("style", "display:none");
                                    Label2.Attributes.Add("style", "display:none");
                                    Label1.Attributes.Add("style", "display:none");
                                    Label8.Attributes.Add("style", "display:none");
                                    Correo.Attributes.Add("style", "display:none");
                                    Label11.Attributes.Add("style", "display:none");
                                    DATE1.Attributes.Add("style", "display:none");
                                    DropDownList1.SelectedValue = dr.GetFieldValue<string>(0);
                                }



                                dr.Close();
                            }

                            con.Close();
                        }
                    }
                }
                else
                {
                    Label1.Value = DateTime.Now.ToString();
                    //Correo.Value = "" + DateTime.Now.Year + "-" + DateTime.Now.Month.ToString("00") + "-" + DateTime.Now.Day.ToString("00") + "";
                    string connectionString = Conection.ConexLine;
                    string query = "SELECT Retencion FROM Asegurados WHERE NumeroCertificado=@NumeroCertificado";


                    using (SqlConnection con = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {

                        cmd.Parameters.Add("@NumeroCertificado", SqlDbType.VarChar, 50).Value = Request.Cookies["paramCert"].Value;



                        con.Open();


                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {


                                if (dr.IsDBNull(0))
                                {
                                    GridView2.Attributes.Add("style", "display:none");
                                }
                                else
                                {
                                    Label3.Attributes.Add("style", "display:none");
                                    DropDownList2.Attributes.Add("style", "display:none");
                                    Label5.Attributes.Add("style", "display:none");
                                    DropDownList3.Attributes.Add("style", "display:none");
                                    Label7.Attributes.Add("style", "display:none");
                                    DropDownList4.Attributes.Add("style", "display:none");
                                    Label2.Attributes.Add("style", "display:none");
                                    Label1.Attributes.Add("style", "display:none");
                                    Label8.Attributes.Add("style", "display:none");
                                    Correo.Attributes.Add("style", "display:none");
                                    Label11.Attributes.Add("style", "display:none");
                                    DATE1.Attributes.Add("style", "display:none");
                                    DropDownList1.SelectedValue = dr.GetFieldValue<string>(0);
                                }



                                dr.Close();
                            }

                            con.Close();
                        }
                    }
                }
                Response.Cookies["Indext"].Expires = DateTime.Now.AddDays(-1);
            }
            else
            {

            }
            
        }

        
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            string transferente2;
            string transferente3;
           
            
            //Label1.Value = DateTime.Now.ToString();
            //Correo.Value = "" + DateTime.Now.Year + "-" + DateTime.Now.Month.ToString("00") + "-" + DateTime.Now.Day.ToString("00") + "";
            string connectionString = Conection.ConexLine;
            string query = "SELECT Retencion, Archivo2, Archivo3 FROM Asegurados WHERE NumeroCertificado=@NumeroCertificado";


            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {

                cmd.Parameters.Add("@NumeroCertificado", SqlDbType.VarChar, 50).Value = Request.Cookies["paramCert"].Value;



                con.Open();


                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        if (dr.IsDBNull(1))
                        {
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
                        }
                        else
                        {
                            using (BinaryReader reader2 = new BinaryReader(FileUpload2.PostedFile.InputStream))
                            {
                                if (FileUpload2.HasFile == true)
                                {
                                    var Archivod2 = reader2.ReadBytes(FileUpload2.PostedFile.ContentLength);
                                    transferente2 = Convert.ToBase64String(Archivod2);

                                }
                                else
                                {
                                    transferente2 = dr.GetFieldValue<string>(1);
                                }
                            }
                            
                        }
                        if (dr.IsDBNull(2))
                        {
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
                        }
                        else
                        {
                            using (BinaryReader reader3 = new BinaryReader(FileUpload3.PostedFile.InputStream))
                            {
                                if (FileUpload3.HasFile == true)
                                {
                                    var Archivod3 = reader3.ReadBytes(FileUpload3.PostedFile.ContentLength);
                                    transferente3 = Convert.ToBase64String(Archivod3);

                                }
                                else
                                {
                                    transferente3 = dr.GetFieldValue<string>(2);
                                }
                            }
                        }


                        if (dr.IsDBNull(0))
                        {
                            if (DropDownList1.SelectedValue == "EXCLUIDO")
                            {
                                using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
                                {

                                    string saveStaff = "UPDATE Asegurados SET Retencion=@Retencion, FechaRet=@FechaRet, Estado=@Estado, Motivo=@Motivo, Canal=@Canal, Responsable=@Responsable, FechaSolicitud=@FechaSolicitud, FechaResolucion=@FechaResolucion, Archivo2=@Archivo2, Archivo3=@Archivo3 WHERE NumeroCertificado=@NumeroCertificado";

                                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                                    {
                                        querySaveStaff.Connection = openCon;

                                        querySaveStaff.Parameters.Add("@FechaRet", SqlDbType.DateTime).Value = DateTime.Now;
                                        querySaveStaff.Parameters.Add("@FechaSolicitud", SqlDbType.DateTime).Value = Correo.Value;
                                        querySaveStaff.Parameters.Add("@FechaResolucion", SqlDbType.DateTime).Value = DATE1.Value;
                                        querySaveStaff.Parameters.Add("@Retencion", SqlDbType.VarChar).Value = DropDownList1.SelectedValue;
                                        querySaveStaff.Parameters.Add("@Estado", SqlDbType.VarChar).Value = DropDownList1.SelectedValue;
                                        querySaveStaff.Parameters.Add("@Motivo", SqlDbType.VarChar).Value = DropDownList2.SelectedValue;
                                        querySaveStaff.Parameters.Add("@Canal", SqlDbType.VarChar).Value = DropDownList3.SelectedValue;
                                        querySaveStaff.Parameters.Add("@Responsable", SqlDbType.VarChar).Value = DropDownList4.SelectedValue;
                                        querySaveStaff.Parameters.Add("@Archivo2", SqlDbType.VarChar).Value = transferente2;
                                        querySaveStaff.Parameters.Add("@Archivo3", SqlDbType.VarChar).Value = transferente3;
                                        querySaveStaff.Parameters.Add("@NumeroCertificado", SqlDbType.Int).Value = Int32.Parse(Request.Cookies["paramCert"].Value);
                                        try
                                        {
                                            openCon.Open();
                                            querySaveStaff.ExecuteNonQuery();
                                            openCon.Close();
                                            Page.RegisterStartupScript("LoadFunction", "<script type='text/javascript'>alert('REGISTRO EXITOSO');window.location='ProReten.aspx'</script>");

                                        }
                                        catch (SqlException ex)
                                        {
                                            Response.Write("Error" + ex);
                                        }
                                    }
                                }
                            }
                            else if (DropDownList1.SelectedValue == "REEMPLAZADO")
                            {
                                using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
                                {

                                    string saveStaff = "UPDATE Asegurados SET Retencion=@Retencion, FechaRet=@FechaRet, Estado=@Estado, Motivo=@Motivo, Canal=@Canal, Responsable=@Responsable, FechaSolicitud=@FechaSolicitud, FechaResolucion=@FechaResolucion, Archivo2=@Archivo2, Archivo3=@Archivo3 WHERE NumeroCertificado=@NumeroCertificado";

                                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                                    {
                                        querySaveStaff.Connection = openCon;

                                        querySaveStaff.Parameters.Add("@FechaRet", SqlDbType.DateTime).Value = DateTime.Now;
                                        querySaveStaff.Parameters.Add("@FechaSolicitud", SqlDbType.DateTime).Value = Correo.Value;
                                        querySaveStaff.Parameters.Add("@FechaResolucion", SqlDbType.DateTime).Value = DATE1.Value;
                                        querySaveStaff.Parameters.Add("@Retencion", SqlDbType.VarChar).Value = DropDownList1.SelectedValue;
                                        querySaveStaff.Parameters.Add("@Estado", SqlDbType.VarChar).Value = DropDownList1.SelectedValue;
                                        querySaveStaff.Parameters.Add("@Motivo", SqlDbType.VarChar).Value = DropDownList2.SelectedValue;
                                        querySaveStaff.Parameters.Add("@Canal", SqlDbType.VarChar).Value = DropDownList3.SelectedValue;
                                        querySaveStaff.Parameters.Add("@Responsable", SqlDbType.VarChar).Value = DropDownList4.SelectedValue;
                                        querySaveStaff.Parameters.Add("@Archivo2", SqlDbType.VarChar).Value = transferente2;
                                        querySaveStaff.Parameters.Add("@Archivo3", SqlDbType.VarChar).Value = transferente3;
                                        querySaveStaff.Parameters.Add("@NumeroCertificado", SqlDbType.Int).Value = Int32.Parse(Request.Cookies["paramCert"].Value);
                                        try
                                        {
                                            openCon.Open();
                                            querySaveStaff.ExecuteNonQuery();
                                            openCon.Close();
                                            Page.RegisterStartupScript("LoadFunction", "<script type='text/javascript'>alert('REGISTRO EXITOSO');window.location='ProReten.aspx'</script>");

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

                                    string saveStaff = "UPDATE Asegurados SET Retencion=@Retencion, FechaRet=@FechaRet, Estado=@Estado, Motivo=@Motivo, Canal=@Canal, Responsable=@Responsable, FechaSolicitud=@FechaSolicitud, FechaResolucion=@FechaResolucion, Archivo2=@Archivo2, Archivo3=@Archivo3 WHERE NumeroCertificado=@NumeroCertificado";

                                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                                    {
                                        querySaveStaff.Connection = openCon;

                                        querySaveStaff.Parameters.Add("@FechaRet", SqlDbType.DateTime).Value = DateTime.Now;
                                        querySaveStaff.Parameters.Add("@FechaSolicitud", SqlDbType.DateTime).Value = Correo.Value;
                                        querySaveStaff.Parameters.Add("@FechaResolucion", SqlDbType.DateTime).Value = DATE1.Value;
                                        querySaveStaff.Parameters.Add("@Retencion", SqlDbType.VarChar).Value = DropDownList1.SelectedValue;
                                        querySaveStaff.Parameters.Add("@Estado", SqlDbType.VarChar).Value = "VENTA";
                                        querySaveStaff.Parameters.Add("@Motivo", SqlDbType.VarChar).Value = DropDownList2.SelectedValue;
                                        querySaveStaff.Parameters.Add("@Canal", SqlDbType.VarChar).Value = DropDownList3.SelectedValue;
                                        querySaveStaff.Parameters.Add("@Responsable", SqlDbType.VarChar).Value = DropDownList4.SelectedValue;
                                        querySaveStaff.Parameters.Add("@Archivo2", SqlDbType.VarChar).Value = transferente2;
                                        querySaveStaff.Parameters.Add("@Archivo3", SqlDbType.VarChar).Value = transferente3;
                                        querySaveStaff.Parameters.Add("@NumeroCertificado", SqlDbType.Int).Value = Int32.Parse(Request.Cookies["paramCert"].Value);
                                        try
                                        {
                                            openCon.Open();
                                            querySaveStaff.ExecuteNonQuery();
                                            openCon.Close();
                                            Page.RegisterStartupScript("LoadFunction", "<script type='text/javascript'>alert('REGISTRO EXITOSO');window.location='ProReten.aspx'</script>");

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
                            if (DropDownList1.SelectedValue == "EXCLUIDO")
                            {
                                using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
                                {

                                    string saveStaff = "UPDATE Asegurados SET FechaRet=@FechaRet, Retencion=@Retencion, Estado=@Estado, Archivo2=@Archivo2, Archivo3=@Archivo3 WHERE NumeroCertificado=@NumeroCertificado";

                                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                                    {
                                        querySaveStaff.Connection = openCon;
                                        querySaveStaff.Parameters.Add("@FechaRet", SqlDbType.DateTime).Value = DateTime.Now;
                                        querySaveStaff.Parameters.Add("@Retencion", SqlDbType.VarChar).Value = DropDownList1.SelectedValue;
                                        querySaveStaff.Parameters.Add("@Estado", SqlDbType.VarChar).Value = DropDownList1.SelectedValue;                                      
                                        querySaveStaff.Parameters.Add("@Archivo2", SqlDbType.VarChar).Value = transferente2;
                                        querySaveStaff.Parameters.Add("@Archivo3", SqlDbType.VarChar).Value = transferente3;
                                        querySaveStaff.Parameters.Add("@NumeroCertificado", SqlDbType.Int).Value = Int32.Parse(Request.Cookies["paramCert"].Value);
                                        try
                                        {
                                            openCon.Open();
                                            querySaveStaff.ExecuteNonQuery();
                                            openCon.Close();
                                            Page.RegisterStartupScript("LoadFunction", "<script type='text/javascript'>alert('REGISTRO EXITOSO');window.location='ProReten.aspx'</script>");

                                        }
                                        catch (SqlException ex)
                                        {
                                            Response.Write("Error" + ex);
                                        }
                                    }
                                }
                            }
                            else if (DropDownList1.SelectedValue == "REEMPLAZADO")
                            {
                                using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
                                {

                                    string saveStaff = "UPDATE Asegurados SET FechaRet=@FechaRet, Retencion=@Retencion, Estado=@Estado, Archivo2=@Archivo2, Archivo3=@Archivo3 WHERE NumeroCertificado=@NumeroCertificado";

                                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                                    {
                                        querySaveStaff.Connection = openCon;
                                        querySaveStaff.Parameters.Add("@FechaRet", SqlDbType.DateTime).Value = DateTime.Now;
                                        querySaveStaff.Parameters.Add("@Retencion", SqlDbType.VarChar).Value = DropDownList1.SelectedValue;
                                        querySaveStaff.Parameters.Add("@Estado", SqlDbType.VarChar).Value = DropDownList1.SelectedValue;                                       
                                        querySaveStaff.Parameters.Add("@Archivo2", SqlDbType.VarChar).Value = transferente2;
                                        querySaveStaff.Parameters.Add("@Archivo3", SqlDbType.VarChar).Value = transferente3;
                                        querySaveStaff.Parameters.Add("@NumeroCertificado", SqlDbType.Int).Value = Int32.Parse(Request.Cookies["paramCert"].Value);
                                        try
                                        {
                                            openCon.Open();
                                            querySaveStaff.ExecuteNonQuery();
                                            openCon.Close();
                                            Page.RegisterStartupScript("LoadFunction", "<script type='text/javascript'>alert('REGISTRO EXITOSO');window.location='ProReten.aspx'</script>");

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

                                    string saveStaff = "UPDATE Asegurados SET FechaRet=@FechaRet, Retencion=@Retencion, Estado=@Estado, Archivo2=@Archivo2, Archivo3=@Archivo3 WHERE NumeroCertificado=@NumeroCertificado";

                                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                                    {
                                        querySaveStaff.Connection = openCon;
                                        querySaveStaff.Parameters.Add("@FechaRet", SqlDbType.DateTime).Value = DateTime.Now;
                                        querySaveStaff.Parameters.Add("@Retencion", SqlDbType.VarChar).Value = DropDownList1.SelectedValue;
                                        querySaveStaff.Parameters.Add("@Estado", SqlDbType.VarChar).Value = "VENTA";
                                        querySaveStaff.Parameters.Add("@Archivo2", SqlDbType.VarChar).Value = transferente2;
                                        querySaveStaff.Parameters.Add("@Archivo3", SqlDbType.VarChar).Value = transferente3;
                                        querySaveStaff.Parameters.Add("@NumeroCertificado", SqlDbType.Int).Value = Int32.Parse(Request.Cookies["paramCert"].Value);
                                        try
                                        {
                                            openCon.Open();
                                            querySaveStaff.ExecuteNonQuery();
                                            openCon.Close();
                                            Page.RegisterStartupScript("LoadFunction", "<script type='text/javascript'>alert('REGISTRO EXITOSO');window.location='ProReten.aspx'</script>");

                                        }
                                        catch (SqlException ex)
                                        {
                                            Response.Write("Error" + ex);
                                        }
                                    }
                                }
                            }
                        }



                        dr.Close();
                    }

                    con.Close();
                }
            }
            
            
           

        }        

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProReten.aspx");
        }

        protected void Unnamed_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}