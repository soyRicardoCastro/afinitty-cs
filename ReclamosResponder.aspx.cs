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
    public partial class ReclamosResponder : Page
    {
        DateTime registro;
        protected void Page_Load(object sender, EventArgs e)
        {
            Text1.Value = DateTime.Now.ToString();
            Text1.Disabled = true;
            Text2.Value = Request.Cookies["casorecC"].Value;
            Text2.Disabled = true;
            Text6.Value = Request.Cookies["fechainicC"].Value;
            Text6.Disabled = true;
            string connectionString = Conection.ConexLine;
            string query = "SELECT Ejecutivo, EntregaDoc from Reclamos WHERE CasoNum="+ Request.Cookies["casorecC"].Value + "";


            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {

                con.Open();


                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        //int tasa = dr.GetFieldValue<int>(0);
                        DateTime prox = dr.GetFieldValue<DateTime>(1);
                        registro = prox;
                        TimeSpan diferencia = DateTime.Now - registro;
                        Text7.Value = diferencia.Days.ToString();
                        //Number1.SelectedValue = prox;
                        Text7.Disabled = true;
                    }
                    else
                    {
                        Response.Write("<script>alert('revise la tasa')</script>");

                    }

                    dr.Close();
                }

                con.Close();
            }


        }



        protected void Unnamed_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            Response.Redirect("ReclamoRespCons.aspx");
        }

        protected void Unnamed_Click1(object sender, EventArgs e)
        {
            string fechapgo;
            decimal pagocli;
            int NroDoc;
            if (Text3.Value == "")
            {
                fechapgo = DateTime.Now.ToString();
            }
            else
            {
                fechapgo = Text3.Value;
            }
            if (Text5.Value == "")
            {
                pagocli = 0;
            }
            else
            {
                pagocli = Decimal.Parse(Text5.Value);
            }
            if (Correo.Value == "")
            {
                NroDoc = 0;
            }
            else
            {
                NroDoc = Int32.Parse(Correo.Value);
            }
            using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
            {

                string saveStaff = "UPDATE Reclamos SET NroDoc=@NroDoc, DiasResuelto=@DiasResuelto, FechaPagoCli=@FechaPagoCli, RegistroNum=@RegistroNum, EjecutivoResp=@EjecutivoResp, PagoAseg=@PagoAseg, EstadoReclamo=@EstadoReclamo, Observaciones=@Observaciones WHERE CasoNum=@CasoNum";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
                    querySaveStaff.Parameters.Add("@NroDoc", SqlDbType.Int).Value = NroDoc;
                    querySaveStaff.Parameters.Add("@DiasResuelto", SqlDbType.Int).Value = Int32.Parse(Text7.Value);
                    querySaveStaff.Parameters.Add("@FechaPagoCli", SqlDbType.DateTime).Value = fechapgo;
                    querySaveStaff.Parameters.Add("@RegistroNum", SqlDbType.DateTime).Value = DateTime.Parse(Text1.Value);
                    querySaveStaff.Parameters.Add("@EjecutivoResp", SqlDbType.VarChar).Value = Drop1.SelectedValue.ToString();
                    querySaveStaff.Parameters.Add("@EstadoReclamo", SqlDbType.VarChar).Value = DropDownList1.SelectedValue.ToString();
                    querySaveStaff.Parameters.Add("@Observaciones", SqlDbType.VarChar).Value = Text8.Value;
                    querySaveStaff.Parameters.Add("@PagoAseg", SqlDbType.Money).Value = pagocli;                    
                    querySaveStaff.Parameters.Add("@CasoNum", SqlDbType.VarChar).Value = Text2.Value;
                    try
                    {
                        openCon.Open();
                        querySaveStaff.ExecuteNonQuery();
                        Response.Write("<script>alert('CASO RESPONDIDO')</script>");
                        Response.Redirect("ReclamoRespCons.aspx");
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