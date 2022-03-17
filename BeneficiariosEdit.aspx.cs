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
    public partial class BeneficiariosEdit : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["indexC"] != null)
            {
                if (Request.Cookies["indexC"].Value == "27")
                {
                    Correo.Value = Request.Cookies["benef1"].Value;
                    Text3.Value = Request.Cookies["benef2"].Value;
                    Text6.Value = Request.Cookies["benef3"].Value;
                    Text9.Value = Request.Cookies["benef4"].Value;
                    Text12.Value = Request.Cookies["benef5"].Value;

                    Response.Cookies["indexC"].Expires = DateTime.Now.AddDays(-1);

                
                }
                else
                {
                    Correo.Value = Request.Cookies["benef1"].Value;
                    Text3.Value = Request.Cookies["benef2"].Value;
                    Text6.Value = Request.Cookies["benef3"].Value;
                    Text9.Value = Request.Cookies["benef4"].Value;
                    Text12.Value = Request.Cookies["benef5"].Value;

                    Response.Cookies["indexC"].Expires = DateTime.Now.AddDays(-1);

               
                }
            }
            else
            {

            }
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
                    querySaveStaff.Parameters.Add("@Beneficiario1", SqlDbType.VarChar).Value = Correo.Value;
                    querySaveStaff.Parameters.Add("@Beneficiario5", SqlDbType.VarChar).Value = Text12.Value;
                    querySaveStaff.Parameters.Add("@Beneficiario2", SqlDbType.VarChar).Value = Text3.Value;
                    querySaveStaff.Parameters.Add("@Beneficiario3", SqlDbType.VarChar).Value = Text6.Value;
                    querySaveStaff.Parameters.Add("@Beneficiario4", SqlDbType.VarChar).Value = Text9.Value;
                    querySaveStaff.Parameters.Add("@NumeroCertificado", SqlDbType.Int).Value = Int32.Parse(Request.Cookies["paramCert"].Value);
                    try
                    {
                        openCon.Open();
                        querySaveStaff.ExecuteNonQuery();
                        openCon.Close();                        
                        
                        Page.RegisterStartupScript("LoadFunction", "<script type='text/javascript'>alert('EDITADO CON EXITO');window.location='ProcBenef.aspx'</script>");

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
           
            Response.Redirect("ProcBenef.aspx");
        }

        protected void Unnamed_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}