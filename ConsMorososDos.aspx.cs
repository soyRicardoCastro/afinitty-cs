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
    public partial class ConsMorososDos : Page
    {
        string tasa;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = GridView1.SelectedIndex;


            //HttpCookie fecha2S = new HttpCookie("cedulacobC");
            //fecha2S.Value = GridView1.Rows[i].Cells[0].Text;
            //fecha2S.Expires = DateTime.Now.AddDays(30);
            //Response.Cookies.Add(fecha2S);

            //HttpCookie fecha2Sx = new HttpCookie("emprecobnom");
            //fecha2Sx.Value = GridView2.Rows[0].Cells[0].Text;
            //fecha2Sx.Expires = DateTime.Now.AddDays(30);
            //Response.Cookies.Add(fecha2Sx);

            //HttpCookie fecha2Sx1 = new HttpCookie("nomcobnom");
            //fecha2Sx1.Value = GridView1.Rows[i].Cells[1].Text;
            //fecha2Sx1.Expires = DateTime.Now.AddDays(30);
            //Response.Cookies.Add(fecha2Sx1);

            //HttpCookie fecha2Sx2 = new HttpCookie("montcobnom");
            //fecha2Sx2.Value = GridView1.Rows[i].Cells[2].Text;
            //fecha2Sx2.Expires = DateTime.Now.AddDays(30);
            //Response.Cookies.Add(fecha2Sx2);

            //HttpCookie fecha2Sx3 = new HttpCookie("certcobnom");
            //fecha2Sx3.Value = GridView1.Rows[i].Cells[3].Text;
            //fecha2Sx3.Expires = DateTime.Now.AddDays(30);
            //Response.Cookies.Add(fecha2Sx3);

            using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
            {
                string saveStaff = "UPDATE Morosos SET Mes='' WHERE Ceudla=@Cedula AND Mes=@Mes";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
                    
                    querySaveStaff.Parameters.Add("@Cedula", SqlDbType.Int).Value = GridView1.Rows[i].Cells[0].Text;                    
                    querySaveStaff.Parameters.Add("@Mes", SqlDbType.VarChar).Value = GridView1.Rows[i].Cells[4].Text;

                    try
                    {
                        openCon.Open();
                        querySaveStaff.ExecuteNonQuery();
                        openCon.Close();
                        Response.Write("<script>alert('CLIENTE ELIMINADO DE LISTA DE MOROSOS')</script>");
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
            Response.Redirect("ConsMorosos.aspx");

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