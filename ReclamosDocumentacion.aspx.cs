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
    public partial class ReclamosDocumentacion : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Text2.Value = Request.Cookies["casorecC"].Value;
            Text2.Disabled = true;
            Text6.Value = Request.Cookies["fechainicC"].Value;
            Text6.Disabled = true;


        }



        protected void Unnamed_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            Response.Redirect("ReclamoDocCons.aspx");
        }
        
        protected void Unnamed_Click1(object sender, EventArgs e)
        {
            string ingreso;            
            if (Text3.Value == "")
            {
                ingreso = "00-00-0000";
            }
            else
            {
                ingreso = Text3.Value;
            }
            string alta;
            if (Text4.Value == "")
            {
                alta = "00-00-0000";
            }
            else
            {
                alta = Text4.Value;
            }
            string recep;
            if (Correo.Value == "")
            {
                recep = "00-00-0000";
            }
            else
            {
                recep = Correo.Value;
            }
            string entre;
            if (Text1.Value == "")
            {
                entre = "00-00-0000";
            }
            else
            {
                entre = Text1.Value;
            }
            string confir;
            if (Text7.Value == "")
            {
                confir = "00-00-0000";
            }
            else
            {
                confir = Text7.Value;
            }
            string salid;
            if (Text5.Value == "")
            {
                salid = "00-00-0000";
            }
            else
            {
                salid = Text5.Value;
            }
            string hosp;
            if (Text9.Value == "")
            {
                hosp = "0";
            }
            else
            {
                hosp = Text9.Value;
            }
            string uci;
            if (Text10.Value == "")
            {
                uci = "0";
            }
            else
            {
                uci = Text10.Value;
            }
            //DateTime Alta = DateTime.Parse(Text4.Value);
            //DateTime Ingreso = DateTime.Parse(Text3.Value);

            using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
            {

                string saveStaff = "UPDATE Reclamos SET Observaciones=@Observaciones, Recepcion=@Recepcion, Confirmacion=@Confirmacion, FechaIngreso=@FechaIngreso, Dias=@Dias, EntregaDoc=@EntregaDoc, FechaPago=@FechaPago, Alta=@Alta, Uci=@Uci, Valor=@Valor, Registrado=@Registrado, EstadoReclamo='DOCUMENTADO' WHERE CasoNum=@CasoNum";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
                    querySaveStaff.Parameters.Add("@Observaciones", SqlDbType.VarChar).Value = Text8.Value;
                    querySaveStaff.Parameters.Add("@Recepcion", SqlDbType.DateTime).Value = DateTime.Parse(recep);
                    querySaveStaff.Parameters.Add("@Confirmacion", SqlDbType.DateTime).Value = DateTime.Parse(confir);
                    querySaveStaff.Parameters.Add("@FechaIngreso", SqlDbType.VarChar).Value = ingreso;
                    querySaveStaff.Parameters.Add("@Dias", SqlDbType.Int).Value = Int32.Parse(hosp);
                    querySaveStaff.Parameters.Add("@EntregaDoc", SqlDbType.DateTime).Value = DateTime.Parse(entre);
                    querySaveStaff.Parameters.Add("@FechaPago", SqlDbType.DateTime).Value = DateTime.Parse(salid);
                    querySaveStaff.Parameters.Add("@Alta", SqlDbType.VarChar).Value = alta;
                    querySaveStaff.Parameters.Add("@Uci", SqlDbType.Int).Value = Int32.Parse(uci);
                    querySaveStaff.Parameters.Add("@Valor", SqlDbType.VarChar).Value = Number1.Value;
                    querySaveStaff.Parameters.Add("@Registrado", SqlDbType.VarChar).Value = DropDownList1.SelectedValue.ToString();
                    querySaveStaff.Parameters.Add("@CasoNum", SqlDbType.VarChar).Value = Text2.Value;
                    try
                    {
                        openCon.Open();
                        querySaveStaff.ExecuteNonQuery();
                        Response.Write("<script>alert('CASO DOCUMENTADO')</script>");
                        Response.Redirect("ReclamoDocCons.aspx");
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