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
    public partial class Beneficiarios : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {         
            
        }

        
        protected void Unnamed1_Click(object sender, EventArgs e)
        {

            string fecha = Request.Cookies["fechaC"].Value;
            using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
            {

                string saveStaff = "UPDATE Asegurados SET Beneficiario1=@Beneficiario1, Beneficiario2=@Beneficiario2, Beneficiario3=@Beneficiario3, Beneficiario4=@Beneficiario4, Beneficiario5=@Beneficiario5 WHERE NumeroCertificado=@NumeroCertificado";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
                    querySaveStaff.Parameters.Add("@Beneficiario1", SqlDbType.VarChar).Value = "TOMADOR: "+Correo.Value+" "+Text1.Value+" "+Text2.Value+ " CONYUGE: " + Text15.Value + " " + Text16.Value + " " + Text17.Value + " PROGENITORES: " + Text30.Value + " " + Text31.Value + " " + Text32.Value + "";
                    querySaveStaff.Parameters.Add("@Beneficiario5", SqlDbType.VarChar).Value = "TOMADOR: " + Text12.Value + " " + Text13.Value + " " + Text14.Value + " CONYUGE: " + Text18.Value + " " + Text19.Value + " " + Text20.Value + " PROGENITORES: " + Text33.Value + " " + Text34.Value + " " + Text35.Value + "";
                    querySaveStaff.Parameters.Add("@Beneficiario2", SqlDbType.VarChar).Value = "TOMADOR: " + Text3.Value + " " + Text4.Value + " " + Text5.Value + " CONYUGE: " + Text21.Value + " " + Text22.Value + " " + Text23.Value + " PROGENITORES: " + Text36.Value + " " + Text37.Value + " " + Text38.Value + "";
                    querySaveStaff.Parameters.Add("@Beneficiario3", SqlDbType.VarChar).Value = "TOMADOR: " + Text6.Value + " " + Text7.Value + " " + Text8.Value + " CONYUGE: " + Text24.Value + " " + Text25.Value + " " + Text26.Value + " PROGENITORES: " + Text39.Value + " " + Text40.Value + " " + Text41.Value + "";
                    querySaveStaff.Parameters.Add("@Beneficiario4", SqlDbType.VarChar).Value = "TOMADOR: " + Text9.Value + " " + Text10.Value + " " + Text11.Value + " CONYUGE: " + Text27.Value + " " + Text28.Value + " " + Text29.Value + " PROGENITORES: " + Text42.Value + " " + Text43.Value + " " + Text44.Value + "";
                    querySaveStaff.Parameters.Add("@NumeroCertificado", SqlDbType.Int).Value = Int32.Parse(Request.Cookies["paramCert"].Value);
                    try
                    {
                        openCon.Open();
                        querySaveStaff.ExecuteNonQuery();
                        openCon.Close();
                        Response.Write("<script>alert('REGISTRO EXITOSO')</script>");
                        HttpCookie indexS = new HttpCookie("indexC");
                        indexS.Value = "8";
                        indexS.Expires = DateTime.Now.AddDays(30);
                        Response.Cookies.Add(indexS);
                        Response.Redirect("MedioCobro.aspx");

                    }
                    catch (SqlException ex)
                    {
                        Response.Write("Error" + ex);
                    }
                }
            }

        }
        

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            HttpCookie indexS = new HttpCookie("indexC");
            indexS.Value = "8";
            indexS.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(indexS);
            Response.Redirect("AdicionSeleccion.aspx");
        }

        protected void Unnamed_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}