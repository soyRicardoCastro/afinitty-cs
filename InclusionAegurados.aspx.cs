using Newtonsoft.Json;
using ReachSystem.Datos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReachSystem
{
    public partial class InclusionAegurados : Page
    {
        Double m;
        DateTime FECHA;
        int MIN;
        int MAX;
        protected void Page_Load(object sender, EventArgs e)
        {                
            
            
            if (Request.Cookies["indexC"] != null)
            {
                if (Request.Cookies["indexC"].Value == "1")
                {
                    Label18.Attributes.Add("style", "display:none");
                    Text6.Attributes.Add("style", "display:none");
                    Text4.Value = Request.Cookies["nombretomC"].Value;
                    Text3.Value = Request.Cookies["paramCedula"].Value;
                    Text5.Value = Request.Cookies["fechanactomC"].Value;
                    prefifin.Text = "0,00";
                    DropDownList3.Enabled = false;
                    DropDownList4.Enabled = false;
                    DropDownList5.Attributes.Add("style", "display:none");
                    DropDownList6.Attributes.Add("style", "display:none");
                    DropDownList7.Attributes.Add("style", "display:none");
                    Button1.Attributes.Add("style", "display:none");
                    if (!IsPostBack)
                    {
                        SqlConnection con = new SqlConnection(Conection.ConexLine);
                        SqlCommand cmd = new SqlCommand("select distinct Aplica from Productos", con);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        DropDownList2.DataSource = dt;
                        DropDownList2.DataBind();

                    }
                    Label12.Attributes.Add("style", "display:none");
                    Label13.Attributes.Add("style", "display:none");
                    Label11.Attributes.Add("style", "display:none");
                    Label14.Attributes.Add("style", "display:none");
                    VOLVERCLICK.Attributes.Add("style", "display:none");
                    if (Request.Cookies["indexTOM"] != null)
                    {
                        if (Request.Cookies["indexTOM"].Value == "1")
                        {
                            Correo.Value = Request.Cookies["paramCedula"].Value;
                            Text1.Value = Request.Cookies["nombretomC"].Value;
                            Text2.Value = Request.Cookies["fechanacC"].Value;
                            DropDownList1.SelectedValue = Request.Cookies["generotomC"].Value;
                            Response.Cookies["indexTOM"].Expires = DateTime.Now.AddDays(-1);
                        }
                        else
                        {

                        }
                    }
                    else
                    {

                    }
                   

                }
                else if (Request.Cookies["indexC"].Value == "2")
                {
                    Label18.Attributes.Add("style", "display:none");
                    Text6.Attributes.Add("style", "display:none");
                    Text3.Value = Request.Cookies["paramCedula"].Value;
                    Text5.Value = Request.Cookies["fechanactomC"].Value;
                    Text4.Value = Request.Cookies["nombretomC"].Value;
                    prefifin.Text = "0,00";
                    DropDownList3.Enabled = false;
                    DropDownList4.Enabled = false;
                    DropDownList5.Attributes.Add("style", "display:none");
                    DropDownList6.Attributes.Add("style", "display:none");
                    DropDownList7.Attributes.Add("style", "display:none");
                    siguiclick.Attributes.Add("style", "display:none");
                    nuevoaseg.Attributes.Add("style", "display:none");
                    Button1.Attributes.Add("style", "display:none");
                    if (!IsPostBack)
                    {
                        SqlConnection con = new SqlConnection(Conection.ConexLine);
                        SqlCommand cmd = new SqlCommand("select distinct Aplica from Productos", con);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        DropDownList2.DataSource = dt;
                        DropDownList2.DataBind();

                    }
                    Label12.Attributes.Add("style", "display:none");
                    Label6.Attributes.Add("style", "display:none");
                    Label13.Attributes.Add("style", "display:none");
                    Label14.Attributes.Add("style", "display:none");
                    FECHA = DateTime.Parse(Request.Cookies["fechanacC"].Value);
                    Correo.Value = Request.Cookies["paramCedulaD"].Value;
                    Text1.Value = Request.Cookies["nombreadC"].Value;
                    Text2.Value = "" + FECHA.Year + "-" + FECHA.Month.ToString("00") + "-" + FECHA.Day.ToString("00") + "";
                    DropDownList1.SelectedValue = Request.Cookies["generotomC"].Value;
                }
                else if (Request.Cookies["indexC"].Value == "3")
                {
                    Label18.Attributes.Add("style", "display:none");
                    Text6.Attributes.Add("style", "display:none");
                    Text3.Value = Request.Cookies["paramCedula"].Value;
                    Text5.Value = Request.Cookies["fechanactomC"].Value;
                    Text4.Value = Request.Cookies["nombretomC"].Value;
                    prefifin.Text = "0,00";
                    DropDownList3.Enabled = false;
                    DropDownList4.Enabled = false;
                    DropDownList5.Attributes.Add("style", "display:none");
                    DropDownList6.Attributes.Add("style", "display:none");
                    DropDownList7.Attributes.Add("style", "display:none");
                    siguiclick.Attributes.Add("style", "display:none");
                    nuevoaseg.Attributes.Add("style", "display:none");
                    Button1.Attributes.Add("style", "display:none");
                    if (!IsPostBack)
                    {
                        SqlConnection con = new SqlConnection(Conection.ConexLine);
                        SqlCommand cmd = new SqlCommand("select distinct Aplica from Productos", con);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        DropDownList2.DataSource = dt;
                        DropDownList2.DataBind();

                    }
                    Label11.Attributes.Add("style", "display:none");
                    Label6.Attributes.Add("style", "display:none");
                    Label13.Attributes.Add("style", "display:none");
                    Label14.Attributes.Add("style", "display:none");
                }
                else if (Request.Cookies["indexC"].Value == "35")
                {
                    Label18.Attributes.Add("style", "display:none");
                    Text6.Attributes.Add("style", "display:none");
                    Text4.Value = Request.Cookies["nombretomC"].Value;
                    Text3.Value = Request.Cookies["paramCedula"].Value;
                    Text5.Value = Request.Cookies["fechanactomC"].Value;
                    prefifin.Text = "0,00";
                    DropDownList3.Enabled = false;
                    DropDownList4.Enabled = false;
                    DropDownList5.Attributes.Add("style", "display:none");
                    DropDownList6.Attributes.Add("style", "display:none");
                    DropDownList7.Attributes.Add("style", "display:none");
                    siguiclick.Attributes.Add("style", "display:none");
                    nuevoaseg.Attributes.Add("style", "display:none");
                    Button1.Attributes.Add("style", "display:none");
                    if (!IsPostBack)
                    {
                        SqlConnection con = new SqlConnection(Conection.ConexLine);
                        SqlCommand cmd = new SqlCommand("select distinct Aplica from Productos", con);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        DropDownList2.DataSource = dt;
                        DropDownList2.DataBind();

                    }
                    Label11.Attributes.Add("style", "display:none");
                    Label6.Attributes.Add("style", "display:none");
                    Label13.Attributes.Add("style", "display:none");
                    Label14.Attributes.Add("style", "display:none");
                }
                else if (Request.Cookies["indexC"].Value == "8")
                {
                    Text4.Value = Request.Cookies["nombretomC"].Value;
                    Text3.Value = Request.Cookies["paramCedula"].Value;
                    Text5.Value = Request.Cookies["fechanactomC"].Value;
                    prefifin.Text = Request.Cookies["primaproC"].Value.ToString();
                    DropDownList5.Attributes.Add("style", "display:none");
                    DropDownList6.Attributes.Add("style", "display:none");
                    DropDownList7.Attributes.Add("style", "display:none");

                    if (!IsPostBack)
                    {
                        SqlConnection con = new SqlConnection(Conection.ConexLine);
                        SqlCommand cmd = new SqlCommand("select distinct Aplica from Productos", con);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        DropDownList2.DataSource = dt;
                        DropDownList2.DataBind();

                    }
                    Label12.Attributes.Add("style", "display:none");
                    Label11.Attributes.Add("style", "display:none");
                    Label6.Attributes.Add("style", "display:none");
                    Label14.Attributes.Add("style", "display:none");
                    siguiclick.Attributes.Add("style", "display:none");
                    nuevoaseg.Attributes.Add("style", "display:none");
                    regis.Attributes.Add("style", "display:none");
                    sri.Attributes.Add("style", "display:none");
                    
                    FECHA = DateTime.Parse(Request.Cookies["fechanacC"].Value);
                    DateTime FECHAD = DateTime.Parse(Request.Cookies["fechavigC"].Value);
                    Correo.Value = Request.Cookies["paramCedulaD"].Value;
                    Text1.Value = Request.Cookies["nombreadC"].Value;
                    Text2.Value = "" + FECHA.Year + "-" + FECHA.Month.ToString("00") + "-" + FECHA.Day.ToString("00") + "";
                    Text6.Value = "" + FECHAD.Year + "-" + FECHAD.Month.ToString("00") + "-" + FECHAD.Day.ToString("00") + "";
                    DropDownList1.SelectedValue = Request.Cookies["generotomC"].Value;
                    DropDownList2.SelectedValue = Request.Cookies["relaproaD"].Value;
                    DropDownList3.SelectedValue = Request.Cookies["cobproC"].Value;
                    DropDownList4.SelectedValue = Request.Cookies["planproC"].Value;

                    if (!IsPostBack)
                    {
                        SqlConnection con = new SqlConnection(Conection.ConexLine);
                        SqlCommand cmd = new SqlCommand("select distinct Producto from Productos", con);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        DropDownList3.DataSource = dt;
                        DropDownList3.DataBind();
                        DropDownList3.Enabled = true;

                        SqlConnection con2 = new SqlConnection(Conection.ConexLine);
                        SqlCommand cmd2 = new SqlCommand("select distinct PlanSelect from Productos", con2);
                        SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
                        DataTable dt2 = new DataTable();
                        sda2.Fill(dt2);
                        DropDownList4.DataSource = dt2;
                        DropDownList4.DataBind();
                        DropDownList4.Enabled = true;

                       
                    }
                    string connectionString = Conection.ConexLine;
                    string query = "SELECT distinct Edadmin, Edadmax from Productos where Aplica=@Aplica";


                    using (SqlConnection con = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {

                        cmd.Parameters.Add("@Aplica", SqlDbType.VarChar, 50).Value = Request.Cookies["relaproaD"].Value;
                        con.Open();


                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                string min = dr.GetFieldValue<string>(0);
                                string max = dr.GetFieldValue<string>(1);

                                HttpCookie indexS1 = new HttpCookie("minC");
                                indexS1.Value = min;
                                indexS1.Expires = DateTime.Now.AddDays(30);
                                Response.Cookies.Add(indexS1);

                                HttpCookie indexS2 = new HttpCookie("maxC");
                                indexS2.Value = max;
                                indexS2.Expires = DateTime.Now.AddDays(30);
                                Response.Cookies.Add(indexS2);

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
                else if (Request.Cookies["indexC"].Value == "30")
                {
                    Label18.Attributes.Add("style", "display:none");
                    Text6.Attributes.Add("style", "display:none");
                    Button1.Attributes.Add("style", "display:none");
                    Text5.Value = Request.Cookies["fechanactomC"].Value;
                    Text3.Value = Request.Cookies["paramCedula"].Value;
                    Text4.Value = Request.Cookies["nombretomC"].Value;
                    prefifin.Text = Request.Cookies["primaproC"].Value.ToString();
                    DropDownList5.Attributes.Add("style", "display:none");
                    DropDownList6.Attributes.Add("style", "display:none");
                    DropDownList7.Attributes.Add("style", "display:none");
                    siguiclick.Attributes.Add("style", "display:none");
                    Correo.Disabled = true;
                    Text1.Disabled = true;
                    Text2.Disabled = true;
                    DropDownList1.Enabled = false;
                    if (!IsPostBack)
                    {
                        SqlConnection con = new SqlConnection(Conection.ConexLine);
                        SqlCommand cmd = new SqlCommand("select distinct Aplica from Productos", con);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        DropDownList2.DataSource = dt;
                        DropDownList2.DataBind();
                        DropDownList2.Enabled = false;

                    }
                    Label12.Attributes.Add("style", "display:none");
                    Label11.Attributes.Add("style", "display:none");
                    Label6.Attributes.Add("style", "display:none");
                    Label13.Attributes.Add("style", "display:none");
                    FECHA = DateTime.Parse(Request.Cookies["fechanacC"].Value);
                    Correo.Value = Request.Cookies["paramCedulaD"].Value;
                    Text1.Value = Request.Cookies["nombreadC"].Value;
                    Text2.Value = "" + FECHA.Year + "-" + FECHA.Month.ToString("00") + "-" + FECHA.Day.ToString("00") + "";
                    DropDownList1.SelectedValue = Request.Cookies["generotomC"].Value;
                    DropDownList2.SelectedValue = Request.Cookies["relaproaD"].Value;
                    DropDownList3.SelectedValue = Request.Cookies["cobproC"].Value;
                    DropDownList4.SelectedValue = Request.Cookies["planproC"].Value;
                    if (!IsPostBack)
                    {
                        SqlConnection con = new SqlConnection(Conection.ConexLine);
                        SqlCommand cmd = new SqlCommand("select distinct Producto from Productos", con);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        DropDownList3.DataSource = dt;
                        DropDownList3.DataBind();
                        DropDownList3.Enabled = true;

                        SqlConnection con2 = new SqlConnection(Conection.ConexLine);
                        SqlCommand cmd2 = new SqlCommand("select distinct PlanSelect from Productos", con2);
                        SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
                        DataTable dt2 = new DataTable();
                        sda2.Fill(dt2);
                        DropDownList4.DataSource = dt2;
                        DropDownList4.DataBind();
                        DropDownList4.Enabled = true;
                    }
                    Response.Cookies["indexC"].Expires = DateTime.Now.AddDays(-1);

                    HttpCookie indexS = new HttpCookie("indexC");
                    indexS.Value = "31";
                    indexS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(indexS);
                }
                else if (Request.Cookies["indexC"].Value == "31")
                {
                    Label18.Attributes.Add("style", "display:none");
                    Text6.Attributes.Add("style", "display:none");
                    Text4.Value = Request.Cookies["nombretomC"].Value;
                    Text5.Value = Request.Cookies["fechanactomC"].Value;
                    Text3.Value = Request.Cookies["paramCedula"].Value;
                    prefifin.Text = Request.Cookies["primaproC"].Value.ToString();
                    DropDownList5.Attributes.Add("style", "display:none");
                    DropDownList6.Attributes.Add("style", "display:none");
                    DropDownList7.Attributes.Add("style", "display:none");
                    siguiclick.Attributes.Add("style", "display:none");
                    Button1.Attributes.Add("style", "display:none");
                    Correo.Disabled = true;
                    Text1.Disabled = true;
                    Text2.Disabled = true;
                    DropDownList1.Enabled = false;
                    if (!IsPostBack)
                    {
                        SqlConnection con = new SqlConnection(Conection.ConexLine);
                        SqlCommand cmd = new SqlCommand("select distinct Aplica from Productos", con);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        DropDownList2.DataSource = dt;
                        DropDownList2.DataBind();
                        DropDownList2.Enabled = false;

                    }
                    Label12.Attributes.Add("style", "display:none");
                    Label11.Attributes.Add("style", "display:none");
                    Label6.Attributes.Add("style", "display:none");
                    Label13.Attributes.Add("style", "display:none");

                    FECHA = DateTime.Parse(Request.Cookies["fechanacC"].Value);
                    Correo.Value = Request.Cookies["paramCedulaD"].Value;
                    Text1.Value = Request.Cookies["nombreadC"].Value;
                    Text2.Value = "" + FECHA.Year + "-" + FECHA.Month.ToString("00") + "-" + FECHA.Day.ToString("00") + "";
                    DropDownList1.SelectedValue = Request.Cookies["generotomC"].Value;
                    DropDownList2.SelectedValue = Request.Cookies["relaproaD"].Value;
                    DropDownList3.SelectedValue = Request.Cookies["cobproC"].Value;
                    DropDownList4.SelectedValue = Request.Cookies["planproC"].Value;
                    if (!IsPostBack)
                    {
                        SqlConnection con = new SqlConnection(Conection.ConexLine);
                        SqlCommand cmd = new SqlCommand("select distinct Producto from Productos", con);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        DropDownList3.DataSource = dt;
                        DropDownList3.DataBind();
                        DropDownList3.Enabled = true;

                        SqlConnection con2 = new SqlConnection(Conection.ConexLine);
                        SqlCommand cmd2 = new SqlCommand("select distinct PlanSelect from Productos", con2);
                        SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
                        DataTable dt2 = new DataTable();
                        sda2.Fill(dt2);
                        DropDownList4.DataSource = dt2;
                        DropDownList4.DataBind();
                        DropDownList4.Enabled = true;
                    }
                    Response.Cookies["indexC"].Expires = DateTime.Now.AddDays(-1);

                    HttpCookie indexS = new HttpCookie("indexintC");
                    indexS.Value = "31";
                    indexS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(indexS);
                }
                if (Request.Cookies["indexC"].Value == "11")
                {
                    Label18.Attributes.Add("style", "display:none");
                    Text6.Attributes.Add("style", "display:none");
                    Text4.Value = Request.Cookies["nombretomC"].Value;
                    Text3.Value = Request.Cookies["paramCedula"].Value;
                    Text5.Value = Request.Cookies["fechanactomC"].Value;
                    prefifin.Text = "0,00";
                    DropDownList3.Enabled = false;
                    DropDownList4.Enabled = false;
                    DropDownList5.Attributes.Add("style", "display:none");
                    DropDownList6.Attributes.Add("style", "display:none");
                    DropDownList7.Attributes.Add("style", "display:none");
                    Button1.Attributes.Add("style", "display:none");
                    if (!IsPostBack)
                    {
                        SqlConnection con = new SqlConnection(Conection.ConexLine);
                        SqlCommand cmd = new SqlCommand("select distinct Aplica from Productos", con);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        DropDownList2.DataSource = dt;
                        DropDownList2.DataBind();

                    }
                    Label12.Attributes.Add("style", "display:none");
                    Label13.Attributes.Add("style", "display:none");
                    Label11.Attributes.Add("style", "display:none");
                    Label14.Attributes.Add("style", "display:none");

                    if (Request.Cookies["indexTOM"] != null)
                    {
                        if (Request.Cookies["indexTOM"].Value == "1")
                        {
                            Label18.Attributes.Add("style", "display:none");
                            Text6.Attributes.Add("style", "display:none");
                            Correo.Value = Request.Cookies["paramCedula"].Value;
                            Text1.Value = Request.Cookies["nombretomC"].Value;
                            Text2.Value = Request.Cookies["fechanacC"].Value;
                            DropDownList1.SelectedValue = Request.Cookies["generotomC"].Value;
                            Response.Cookies["indexTOM"].Expires = DateTime.Now.AddDays(-1);
                        }
                        else
                        {

                        }
                    }
                    else
                    {

                    }
                    HttpCookie total2S = new HttpCookie("indexC");
                    total2S.Value = "1";
                    total2S.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(total2S);
                }

            }
            else
            {

            }
        }        


        protected void fijarrelacion(object sender, EventArgs e)
        {
            DropDownList3.Items.Clear();
            DropDownList3.Items.Add("COBERTURA");

            SqlConnection con = new SqlConnection(Conection.ConexLine);
            SqlCommand cmd = new SqlCommand("select distinct Producto from Productos where Aplica = '"+DropDownList2.SelectedValue+"'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DropDownList3.DataSource = dt;
            DropDownList3.DataBind();
            DropDownList3.Enabled = true;
            

        }
        protected void fijarcobertura(object sender, EventArgs e)
        {
            DropDownList4.Items.Clear();
            DropDownList4.Items.Add("PLAN");

            SqlConnection con = new SqlConnection(Conection.ConexLine);
            SqlCommand cmd = new SqlCommand("select distinct PlanSelect from Productos where Aplica = '" + DropDownList2.SelectedValue + "' and Producto = '"+DropDownList3.SelectedValue+"'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DropDownList4.DataSource = dt;
            DropDownList4.DataBind();
            DropDownList4.Enabled = true;
           
        }
        protected void fijarplan(object sender, EventArgs e)
        {
            DropDownList5.Items.Clear();
            DropDownList6.Items.Clear();
            DropDownList7.Items.Clear();

            SqlConnection con = new SqlConnection(Conection.ConexLine);
            SqlCommand cmd = new SqlCommand("select distinct Valor, Edadmin, Edadmax from Productos where Aplica = '" + DropDownList2.SelectedValue + "' and Producto = '" + DropDownList3.SelectedValue + "' and PlanSelect ='" + DropDownList4.SelectedValue+"'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            DataSet ds1 = new DataSet();
            sda.Fill(ds1);
            sda.Fill(dt);
            HttpCookie indexS1 = new HttpCookie("minC");
            indexS1.Value = ds1.Tables[0].Rows[0]["Edadmin"].ToString();
            indexS1.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(indexS1);

            HttpCookie indexS2 = new HttpCookie("maxC");
            indexS2.Value = ds1.Tables[0].Rows[0]["Edadmax"].ToString();
            indexS2.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(indexS2);

            DropDownList5.DataSource = dt;
            DropDownList5.DataBind();
            DropDownList5.Enabled = true;
            DropDownList6.DataSource = dt;
            DropDownList6.DataBind();
            DropDownList6.Enabled = true;
            DropDownList7.DataSource = dt;
            DropDownList7.DataBind();
            DropDownList7.Enabled = true;
            prefifin.Text = String.Format("{0:.##}", Double.Parse(DropDownList5.SelectedValue));
           
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            DateTime estasi = DateTime.Parse(Text2.Value);
            int edadaseg = DateTime.Now.Year - estasi.Year;
            double limitemin;
            double limitemax;
            if (Request.Cookies["indexC"] != null)
            {
                limitemin = Int32.Parse(Request.Cookies["minC"].Value);
                limitemax = Int32.Parse(Request.Cookies["maxC"].Value);
            }
            else
            {
                limitemin = Int32.Parse(Request.Cookies["minC"].Value);
                limitemax = Int32.Parse(Request.Cookies["maxC"].Value);
            }
    
            
       
            if (edadaseg < limitemin)
            {
                Response.Write("<script>alert('NO CUMPLE CON EL PARAMETRO EDAD MINIMA')</script>");
            }
            else
            {
                if (edadaseg > limitemax)
                {
                    Response.Write("<script>alert('NO CUMPLE CON EL PARAMETRO EDAD MAXIMA')</script>");
                }
                else
                {
                    Int64 Cedula;


                    if (Correo.Value == "")
                    {
                        Cedula = 0;
                    }
                    else
                    {
                        Cedula = Int64.Parse(Correo.Value);
                    }
                    if (Request.Cookies["indexC"] != null)
                    {
                        if (Request.Cookies["indexC"].Value == "100")
                        {

                            //if (Request.Cookies["totalC"] == null)
                            //{
                            //    m = Double.Parse(prefifin.Text);
                            //}
                            //else
                            //{
                            //    double n = Double.Parse(Request.Cookies["totalC"].Value);
                            //    double x = Double.Parse(prefifin.Text);
                            //    m = x;
                            //}
                            //HttpCookie totalS = new HttpCookie("totalC");
                            //totalS.Value = prefifin.Text;
                            //totalS.Expires = DateTime.Now.AddDays(30);
                            //Response.Cookies.Add(totalS);
                            //HttpCookie total2S = new HttpCookie("indexC");
                            //total2S.Value = "11";
                            //total2S.Expires = DateTime.Now.AddDays(30);
                            //Response.Cookies.Add(total2S);
                            //using (SqlConnection openCon = new SqlConnection("workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB"))
                            //{
                            //    string saveStaff = "INSERT into VentaTemp (Nombre, Producto, PlanSelect, Valor, FechaVenta, CedulaTomador, Ejecutivo) VALUES (@Nombre, @Producto, @PlanSelect, @Valor, @FechaVenta, @CedulaTomador, @Ejecutivo)";

                            //    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                            //    {
                            //        querySaveStaff.Connection = openCon;
                            //        querySaveStaff.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Text1.Value;
                            //        querySaveStaff.Parameters.Add("@Producto", SqlDbType.VarChar).Value = DropDownList3.SelectedValue.ToString();
                            //        querySaveStaff.Parameters.Add("@PlanSelect", SqlDbType.VarChar).Value = DropDownList4.SelectedValue.ToString();
                            //        querySaveStaff.Parameters.Add("@Valor", SqlDbType.Money).Value = Double.Parse(prefifin.Text);
                            //        querySaveStaff.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DateTime.Parse(fecha);
                            //        querySaveStaff.Parameters.Add("@CedulaTomador", SqlDbType.Int).Value = Int32.Parse(CedulaTom);
                            //        querySaveStaff.Parameters.Add("@Ejecutivo", SqlDbType.VarChar).Value = Ejec;
                            //        try
                            //        {
                            //            openCon.Open();
                            //            querySaveStaff.ExecuteNonQuery();
                            //            openCon.Close();
                            //        }
                            //        catch (SqlException ex)
                            //        {
                            //            Response.Write("Error" + ex);
                            //        }
                            //    }
                            //}
                        }
                        if (Request.Cookies["indexC"].Value == "11")
                        {
                            prefifin.Text = String.Format("{0:.##}", Double.Parse(DropDownList5.SelectedValue));
                            string CedulaTom = Request.Cookies["paramCedula"].Value;
                            string Ejec = Request.Cookies["nombreC"].Value;
                            string fecha = Request.Cookies["fechaC"].Value;
                            if (Request.Cookies["totalC"] == null)
                            {
                                m = double.Parse(prefifin.Text);
                            }
                            else
                            {
                                double n = Double.Parse(Request.Cookies["totalC"].Value);
                                double x = Double.Parse(prefifin.Text);
                                m = n + x;
                            }
                            HttpCookie totalS = new HttpCookie("totalC");
                            totalS.Value = m.ToString();
                            totalS.Expires = DateTime.Now.AddDays(30);
                            Response.Cookies.Add(totalS);
                            //using (SqlConnection openCon = new SqlConnection("workstation id=affisDB.mssql.somee.com;packet size=4096;user id=localarts_SQLLogin_2;pwd=kgiivi9to9;data source=affisDB.mssql.somee.com;persist security info=False;initial catalog=affisDB"))
                            //{
                            //    string saveStaff = "INSERT into VentaTemp (Nombre, Producto, PlanSelect, Valor, FechaVenta, CedulaTomador, Ejecutivo) VALUES (@Nombre, @Producto, @PlanSelect, @Valor, @FechaVenta, @CedulaTomador, @Ejecutivo)";

                            //    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                            //    {
                            //        querySaveStaff.Connection = openCon;
                            //        querySaveStaff.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Text1.Value;
                            //        querySaveStaff.Parameters.Add("@Producto", SqlDbType.VarChar).Value = DropDownList3.SelectedValue.ToString();
                            //        querySaveStaff.Parameters.Add("@PlanSelect", SqlDbType.VarChar).Value = DropDownList4.SelectedValue.ToString();
                            //        querySaveStaff.Parameters.Add("@Valor", SqlDbType.Money).Value = Double.Parse(prefifin.Text);
                            //        querySaveStaff.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DateTime.Parse(fecha);
                            //        querySaveStaff.Parameters.Add("@CedulaTomador", SqlDbType.Int).Value = Int32.Parse(CedulaTom);
                            //        querySaveStaff.Parameters.Add("@Ejecutivo", SqlDbType.VarChar).Value = Ejec;
                            //        try
                            //        {
                            //            openCon.Open();
                            //            querySaveStaff.ExecuteNonQuery();
                            //            openCon.Close();
                            //        }
                            //        catch (SqlException ex)
                            //        {
                            //            Response.Write("Error" + ex);
                            //        }
                            //    }
                            //}
                        }

                        if (Request.Cookies["indexC"].Value == "2")
                        {
                            prefifin.Text = String.Format("{0:.##}", Double.Parse(DropDownList5.SelectedValue));
                            string CedulaTom = Request.Cookies["paramCedula"].Value;
                            string Ejec = Request.Cookies["nombreC"].Value;
                            string fecha = Request.Cookies["fechaC"].Value;
                            if (Request.Cookies["totalC"] == null)
                            {
                                m = double.Parse(prefifin.Text);
                            }
                            else
                            {
                                double n = Double.Parse(Request.Cookies["totalC"].Value);
                                double x = Double.Parse(prefifin.Text);
                                m = n + x;
                            }
                            HttpCookie totalS = new HttpCookie("totalC");
                            totalS.Value = m.ToString();
                            totalS.Expires = DateTime.Now.AddDays(30);
                            Response.Cookies.Add(totalS);
                            using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
                            {
                                string saveStaff = "INSERT into VentaTemp (Nombre, Producto, PlanSelect, Valor, FechaVenta, CedulaTomador, Ejecutivo, Cedula, Relacion, FechaNac) VALUES (@Nombre, @Producto, @PlanSelect, @Valor, @FechaVenta, @CedulaTomador, @Ejecutivo, @Cedula, @Relacion, @FechaNac)";

                                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                                {
                                    querySaveStaff.Connection = openCon;
                                    querySaveStaff.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Text1.Value;
                                    querySaveStaff.Parameters.Add("@Producto", SqlDbType.VarChar).Value = DropDownList3.SelectedValue.ToString();
                                    querySaveStaff.Parameters.Add("@PlanSelect", SqlDbType.VarChar).Value = DropDownList4.SelectedValue.ToString();
                                    querySaveStaff.Parameters.Add("@Valor", SqlDbType.Money).Value = Double.Parse(prefifin.Text);
                                    querySaveStaff.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DateTime.Parse(fecha);
                                    querySaveStaff.Parameters.Add("@CedulaTomador", SqlDbType.BigInt).Value = Int64.Parse(CedulaTom);
                                    querySaveStaff.Parameters.Add("@Ejecutivo", SqlDbType.VarChar).Value = Ejec;
                                    querySaveStaff.Parameters.Add("@Cedula", SqlDbType.BigInt).Value = Cedula;
                                    querySaveStaff.Parameters.Add("@Relacion", SqlDbType.VarChar).Value = DropDownList2.SelectedValue;
                                    querySaveStaff.Parameters.Add("@FechaNac", SqlDbType.DateTime).Value = DateTime.Parse(Text2.Value);
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

                                string saveStaff = "INSERT into Dependientes (Nombre, Cedula, Relacion, Producto, [Plan], TotalPrima, TotalCobrar, Genero, telfcelular, CedulaTomador, FechaVenta, FechaVigencia, FechaNac, NumeroCertificado, Estado, procesoWSM) VALUES (@Nombre, @Cedula, @Relacion, @Producto, @Plan, @TotalPrima, @TotalCobrar, @Genero, @telfcelular, @CedulaTomador, @FechaVenta, @FechaVigencia, @FechaNac, @NumeroCertificado, 'PREVENTA', @procesoWSM)";

                                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                                {
                                    querySaveStaff.Connection = openCon;
                                    querySaveStaff.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Text1.Value;
                                    querySaveStaff.Parameters.Add("@Cedula", SqlDbType.BigInt).Value = Cedula;
                                    querySaveStaff.Parameters.Add("@Relacion", SqlDbType.VarChar).Value = DropDownList2.SelectedValue;
                                    querySaveStaff.Parameters.Add("@Producto", SqlDbType.VarChar).Value = DropDownList3.SelectedValue;
                                    querySaveStaff.Parameters.Add("@Plan", SqlDbType.VarChar).Value = DropDownList4.SelectedValue;
                                    querySaveStaff.Parameters.Add("@TotalPrima", SqlDbType.Money).Value = Double.Parse(prefifin.Text);
                                    querySaveStaff.Parameters.Add("@TotalCobrar", SqlDbType.Money).Value = Double.Parse(prefifin.Text);
                                    querySaveStaff.Parameters.Add("@Genero", SqlDbType.VarChar).Value = DropDownList1.SelectedValue;
                                    querySaveStaff.Parameters.Add("@telfcelular", SqlDbType.VarChar).Value = "";
                                    querySaveStaff.Parameters.Add("@CedulaTomador", SqlDbType.BigInt).Value = Int64.Parse(CedulaTom);
                                    querySaveStaff.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DateTime.Parse(fecha);
                                    querySaveStaff.Parameters.Add("@FechaVigencia", SqlDbType.DateTime).Value = DateTime.Parse(Request.Cookies["fechavigC"].Value);
                                    querySaveStaff.Parameters.Add("@FechaNac", SqlDbType.DateTime).Value = DateTime.Parse(Text2.Value);
                                    querySaveStaff.Parameters.Add("@NumeroCertificado", SqlDbType.Int).Value = Request.Cookies["paramCert"].Value;
                                    querySaveStaff.Parameters.Add("@procesoWSM", SqlDbType.VarChar).Value = Request.Cookies["indexWSM"].Value;
                                    try
                                    {
                                        openCon.Open();
                                        querySaveStaff.ExecuteNonQuery();
                                        openCon.Close();
                                        HttpCookie total3S = new HttpCookie("indexC");
                                        total3S.Value = "15";
                                        total3S.Expires = DateTime.Now.AddDays(30);
                                        Response.Cookies.Add(total3S);
                                        Page.RegisterStartupScript("LoadFunction", "<script type='text/javascript'>alert('REGISTRO EXITOSO');window.location='AdicionSeleccion.aspx'</script>");
                                    }
                                    catch (SqlException ex)
                                    {
                                        Response.Write("Error" + ex);
                                    }
                                }
                            }
                        }
                        if (Request.Cookies["indexC"].Value == "3")
                        {
                            prefifin.Text = String.Format("{0:.##}", Double.Parse(DropDownList5.SelectedValue));
                            string CedulaTom = Request.Cookies["paramCedula"].Value;
                            string Ejec = Request.Cookies["nombreC"].Value;
                            string fecha = Request.Cookies["fechaC"].Value;
                            if (Request.Cookies["totalC"] == null)
                            {
                                m = double.Parse(prefifin.Text);
                            }
                            else
                            {
                                double n = Double.Parse(Request.Cookies["totalC"].Value);
                                double x = Double.Parse(prefifin.Text);
                                m = n + x;
                            }
                            HttpCookie totalS = new HttpCookie("totalC");
                            totalS.Value = m.ToString();
                            totalS.Expires = DateTime.Now.AddDays(30);
                            Response.Cookies.Add(totalS);
                            using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
                            {
                                string saveStaff = "INSERT into VentaTemp (Nombre, Producto, PlanSelect, Valor, FechaVenta, CedulaTomador, Ejecutivo, Cedula, Relacion, FechaNac) VALUES (@Nombre, @Producto, @PlanSelect, @Valor, @FechaVenta, @CedulaTomador, @Ejecutivo, @Cedula, @Relacion, @FechaNac)";

                                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                                {
                                    querySaveStaff.Connection = openCon;
                                    querySaveStaff.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Text1.Value;
                                    querySaveStaff.Parameters.Add("@Producto", SqlDbType.VarChar).Value = DropDownList3.SelectedValue.ToString();
                                    querySaveStaff.Parameters.Add("@PlanSelect", SqlDbType.VarChar).Value = DropDownList4.SelectedValue.ToString();
                                    querySaveStaff.Parameters.Add("@Valor", SqlDbType.Money).Value = Double.Parse(prefifin.Text);
                                    querySaveStaff.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DateTime.Parse(fecha);
                                    querySaveStaff.Parameters.Add("@CedulaTomador", SqlDbType.BigInt).Value = Int64.Parse(CedulaTom);
                                    querySaveStaff.Parameters.Add("@Ejecutivo", SqlDbType.VarChar).Value = Ejec;
                                    querySaveStaff.Parameters.Add("@Cedula", SqlDbType.BigInt).Value = Cedula;
                                    querySaveStaff.Parameters.Add("@Relacion", SqlDbType.VarChar).Value = DropDownList2.SelectedValue;
                                    querySaveStaff.Parameters.Add("@FechaNac", SqlDbType.DateTime).Value = DateTime.Parse(Text2.Value);
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

                                string saveStaff = "INSERT into Dependientes (Nombre, Cedula, Relacion, Producto, [Plan], TotalPrima, TotalCobrar, Genero, telfcelular, CedulaTomador, FechaVenta, FechaVigencia, FechaNac, NumeroCertificado, Estado, procesoWSM) VALUES (@Nombre, @Cedula, @Relacion, @Producto, @Plan, @TotalPrima, @TotalCobrar, @Genero, @telfcelular, @CedulaTomador, @FechaVenta, @FechaVigencia, @FechaNac, @NumeroCertificado, 'PREVENTA', @procesoWSM)";

                                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                                {
                                    querySaveStaff.Connection = openCon;
                                    querySaveStaff.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Text1.Value;
                                    querySaveStaff.Parameters.Add("@Cedula", SqlDbType.BigInt).Value = Cedula;
                                    querySaveStaff.Parameters.Add("@Relacion", SqlDbType.VarChar).Value = DropDownList2.SelectedValue;
                                    querySaveStaff.Parameters.Add("@Producto", SqlDbType.VarChar).Value = DropDownList3.SelectedValue;
                                    querySaveStaff.Parameters.Add("@Plan", SqlDbType.VarChar).Value = DropDownList4.SelectedValue;
                                    querySaveStaff.Parameters.Add("@TotalPrima", SqlDbType.Money).Value = Double.Parse(prefifin.Text);
                                    querySaveStaff.Parameters.Add("@TotalCobrar", SqlDbType.Money).Value = Double.Parse(prefifin.Text);
                                    querySaveStaff.Parameters.Add("@Genero", SqlDbType.VarChar).Value = DropDownList1.SelectedValue;
                                    querySaveStaff.Parameters.Add("@telfcelular", SqlDbType.VarChar).Value = "";
                                    querySaveStaff.Parameters.Add("@CedulaTomador", SqlDbType.BigInt).Value = Int64.Parse(CedulaTom);
                                    querySaveStaff.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DateTime.Parse(fecha);
                                    querySaveStaff.Parameters.Add("@FechaVigencia", SqlDbType.DateTime).Value = DateTime.Parse(Request.Cookies["fechavigC"].Value);
                                    querySaveStaff.Parameters.Add("@FechaNac", SqlDbType.DateTime).Value = DateTime.Parse(Text2.Value);
                                    querySaveStaff.Parameters.Add("@NumeroCertificado", SqlDbType.Int).Value = Request.Cookies["paramCert"].Value;
                                    querySaveStaff.Parameters.Add("@procesoWSM", SqlDbType.VarChar).Value = Request.Cookies["indexWSM"].Value;
                                    try
                                    {
                                        openCon.Open();
                                        querySaveStaff.ExecuteNonQuery();
                                        openCon.Close();
                                        HttpCookie total3S = new HttpCookie("indexC");
                                        total3S.Value = "15";
                                        total3S.Expires = DateTime.Now.AddDays(30);
                                        Response.Cookies.Add(total3S);
                                        Page.RegisterStartupScript("LoadFunction", "<script type='text/javascript'>alert('REGISTRO EXITOSO');window.location='AdicionSeleccion.aspx'</script>");
                                    }
                                    catch (SqlException ex)
                                    {
                                        Response.Write("Error" + ex);
                                    }
                                }
                            }
                        }
                        if (Request.Cookies["indexC"].Value == "9")
                        {
                            string CedulaTom = Request.Cookies["paramCedula"].Value;
                            string Ejec = Request.Cookies["nombreC"].Value;
                            string fecha = Request.Cookies["fechaC"].Value;
                            using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
                            {

                                string saveStaff = "UPDATE Dependientes SET Nombre=@Nombre, Cedula=@Cedula, Relacion=@Relacion, Producto=@Producto, [Plan]=@Plan, TotalPrima=@TotalPrima, TotalCobrar=@TotalCobrar, Genero=@Genero, telfcelular=@telfcelular, CedulaTomador=@CedulaTomador, FechaVenta=@FechaVenta, FechaVigencia=@FechaVigencia, FechaNac=@FechaNac, NumeroCertificado=@NumeroCertificado WHERE Nombre=@FIJADOR1 AND Cedula=@FIJADOR2 AND Producto=@FIJADOR3";

                                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                                {
                                    querySaveStaff.Connection = openCon;
                                    querySaveStaff.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Text1.Value;
                                    querySaveStaff.Parameters.Add("@Cedula", SqlDbType.BigInt).Value = Cedula;
                                    querySaveStaff.Parameters.Add("@Relacion", SqlDbType.VarChar).Value = DropDownList2.SelectedValue;
                                    querySaveStaff.Parameters.Add("@Producto", SqlDbType.VarChar).Value = DropDownList3.SelectedValue;
                                    querySaveStaff.Parameters.Add("@Plan", SqlDbType.VarChar).Value = DropDownList4.SelectedValue;
                                    querySaveStaff.Parameters.Add("@TotalPrima", SqlDbType.Money).Value = Double.Parse(prefifin.Text);
                                    querySaveStaff.Parameters.Add("@TotalCobrar", SqlDbType.Money).Value = Double.Parse(prefifin.Text);
                                    querySaveStaff.Parameters.Add("@Genero", SqlDbType.VarChar).Value = DropDownList1.SelectedValue;
                                    querySaveStaff.Parameters.Add("@telfcelular", SqlDbType.VarChar).Value = "";
                                    querySaveStaff.Parameters.Add("@CedulaTomador", SqlDbType.BigInt).Value = Int64.Parse(CedulaTom);
                                    querySaveStaff.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DateTime.Parse(fecha);
                                    querySaveStaff.Parameters.Add("@FechaVigencia", SqlDbType.DateTime).Value = DateTime.Parse(Text6.Value);
                                    querySaveStaff.Parameters.Add("@FechaNac", SqlDbType.DateTime).Value = DateTime.Parse(Text2.Value);
                                    querySaveStaff.Parameters.Add("@NumeroCertificado", SqlDbType.Int).Value = Request.Cookies["paramCert"].Value;
                                    querySaveStaff.Parameters.Add("@FIJADOR1", SqlDbType.VarChar).Value = Request.Cookies["nombreadC"].Value;
                                    querySaveStaff.Parameters.Add("@FIJADOR2", SqlDbType.BigInt).Value = Int64.Parse(Request.Cookies["paramCedulaD"].Value);
                                    querySaveStaff.Parameters.Add("@FIJADOR3", SqlDbType.VarChar).Value = Request.Cookies["cobproC"].Value;
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
                                        Response.Redirect("AdicionSeleccion.aspx");

                                    }
                                    catch (SqlException ex)
                                    {
                                        Response.Write("Error" + ex);
                                    }
                                }
                            }
                        }
                        if (Request.Cookies["indexC"].Value == "35")
                        {
                            prefifin.Text = String.Format("{0:.##}", Double.Parse(DropDownList5.SelectedValue));
                            string CedulaTom = Request.Cookies["paramCedula"].Value;
                            string Ejec = Request.Cookies["nombreC"].Value;
                            string fecha = Request.Cookies["fechaC"].Value;
                            if (Request.Cookies["totalC"] == null)
                            {
                                double t = double.Parse(DropDownList5.SelectedValue);
                                double z = double.Parse(Request.Cookies["ajusteC"].Value);
                                double y;
                                if (Request.Cookies["primaproC"] != null)
                                {
                                    y = double.Parse(Request.Cookies["primaproC"].Value);
                                    m = (z - y) + t;
                                }
                                else
                                {
                                    y = 0;
                                    m = (z - y) + t;
                                }
                                
                          
                            }
                            else
                            {
                                double n = Double.Parse(Request.Cookies["totalC"].Value);
                                double x = Double.Parse(DropDownList5.SelectedValue);
                                double z = double.Parse(Request.Cookies["ajusteC"].Value);
                                double y = double.Parse(Request.Cookies["primaproC"].Value);
                                m = (n - y + x);
                            }
                            HttpCookie totalS = new HttpCookie("totalC");
                            totalS.Value = m.ToString();
                            totalS.Expires = DateTime.Now.AddDays(30);
                            Response.Cookies.Add(totalS);
                            using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
                            {
                                string saveStaff = "INSERT into VentaTemp (Nombre, Producto, PlanSelect, Valor, FechaVenta, CedulaTomador, Ejecutivo, Cedula, Relacion, FechaNac) VALUES (@Nombre, @Producto, @PlanSelect, @Valor, @FechaVenta, @CedulaTomador, @Ejecutivo, @Cedula, @Relacion, @FechaNac)";

                                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                                {
                                    querySaveStaff.Connection = openCon;
                                    querySaveStaff.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Text1.Value;
                                    querySaveStaff.Parameters.Add("@Producto", SqlDbType.VarChar).Value = DropDownList3.SelectedValue.ToString();
                                    querySaveStaff.Parameters.Add("@PlanSelect", SqlDbType.VarChar).Value = DropDownList4.SelectedValue.ToString();
                                    querySaveStaff.Parameters.Add("@Valor", SqlDbType.Money).Value = Double.Parse(prefifin.Text);
                                    querySaveStaff.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DateTime.Parse(fecha);
                                    querySaveStaff.Parameters.Add("@CedulaTomador", SqlDbType.BigInt).Value = Int64.Parse(CedulaTom);
                                    querySaveStaff.Parameters.Add("@Ejecutivo", SqlDbType.VarChar).Value = Ejec;
                                    querySaveStaff.Parameters.Add("@Cedula", SqlDbType.BigInt).Value = Cedula;
                                    querySaveStaff.Parameters.Add("@Relacion", SqlDbType.VarChar).Value = DropDownList2.SelectedValue;
                                    querySaveStaff.Parameters.Add("@FechaNac", SqlDbType.DateTime).Value = DateTime.Parse(Text2.Value);
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

                            
                        }
                        
                        else if (Request.Cookies["IndexC"].Value == "1")
                        {

                            //Response.Cookies["indexC"].Expires = DateTime.Now.AddDays(-1);
                            prefifin.Text = String.Format("{0:.##}", Double.Parse(DropDownList5.SelectedValue));
                            string CedulaTom = Request.Cookies["paramCedula"].Value;
                            string Ejec = Request.Cookies["nombreC"].Value;
                            string fecha = Request.Cookies["fechaC"].Value;
                            if (Request.Cookies["totalC"] == null)
                            {
                                m = double.Parse(prefifin.Text);
                            }
                            else
                            {
                                double n = Double.Parse(Request.Cookies["totalC"].Value);
                                double x = Double.Parse(prefifin.Text);
                                m = n + x;
                            }
                            HttpCookie totalS = new HttpCookie("totalC");
                            totalS.Value = m.ToString();
                            totalS.Expires = DateTime.Now.AddDays(30);
                            Response.Cookies.Add(totalS);
                            using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
                            {

                                string saveStaff = "INSERT into Dependientes (Nombre, Cedula, Relacion, Producto, [Plan], TotalPrima, TotalCobrar, Genero, telfcelular, CedulaTomador, FechaVenta, FechaVigencia, FechaNac, procesoWSM, Estado) VALUES (@Nombre, @Cedula, @Relacion, @Producto, @Plan, @TotalPrima, @TotalCobrar, @Genero, @telfcelular, @CedulaTomador, @FechaVenta, @FechaVigencia, @FechaNac, @procesoWSM, 'PREVENTA')";

                                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                                {
                                    querySaveStaff.Connection = openCon;
                                    querySaveStaff.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Text1.Value;
                                    querySaveStaff.Parameters.Add("@Cedula", SqlDbType.BigInt).Value = Cedula;
                                    querySaveStaff.Parameters.Add("@Relacion", SqlDbType.VarChar).Value = DropDownList2.SelectedValue;
                                    querySaveStaff.Parameters.Add("@Producto", SqlDbType.VarChar).Value = DropDownList3.SelectedValue;
                                    querySaveStaff.Parameters.Add("@Plan", SqlDbType.VarChar).Value = DropDownList4.SelectedValue;
                                    querySaveStaff.Parameters.Add("@TotalPrima", SqlDbType.Money).Value = Double.Parse(prefifin.Text);
                                    querySaveStaff.Parameters.Add("@TotalCobrar", SqlDbType.Money).Value = Double.Parse(prefifin.Text);
                                    querySaveStaff.Parameters.Add("@Genero", SqlDbType.VarChar).Value = DropDownList1.SelectedValue;
                                    querySaveStaff.Parameters.Add("@telfcelular", SqlDbType.VarChar).Value = "";
                                    querySaveStaff.Parameters.Add("@CedulaTomador", SqlDbType.BigInt).Value = Int64.Parse(CedulaTom);
                                    querySaveStaff.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DateTime.Parse(fecha);
                                    querySaveStaff.Parameters.Add("@FechaVigencia", SqlDbType.DateTime).Value = DateTime.Parse(Request.Cookies["fechavigC"].Value);
                                    querySaveStaff.Parameters.Add("@FechaNac", SqlDbType.DateTime).Value = DateTime.Parse(Text2.Value);
                                    querySaveStaff.Parameters.Add("@procesoWSM", SqlDbType.VarChar).Value = Request.Cookies["indexWSM"].Value;
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
                                string saveStaff = "INSERT into VentaTemp (Nombre, Producto, PlanSelect, Valor, FechaVenta, CedulaTomador, Ejecutivo, Cedula, Relacion, FechaNac) VALUES (@Nombre, @Producto, @PlanSelect, @Valor, @FechaVenta, @CedulaTomador, @Ejecutivo, @Cedula, @Relacion, @FechaNac)";

                                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                                {
                                    querySaveStaff.Connection = openCon;
                                    querySaveStaff.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Text1.Value;
                                    querySaveStaff.Parameters.Add("@Producto", SqlDbType.VarChar).Value = DropDownList3.SelectedValue.ToString();
                                    querySaveStaff.Parameters.Add("@PlanSelect", SqlDbType.VarChar).Value = DropDownList4.SelectedValue.ToString();
                                    querySaveStaff.Parameters.Add("@Valor", SqlDbType.Money).Value = Double.Parse(prefifin.Text);
                                    querySaveStaff.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DateTime.Parse(fecha);
                                    querySaveStaff.Parameters.Add("@CedulaTomador", SqlDbType.BigInt).Value = Int64.Parse(CedulaTom);
                                    querySaveStaff.Parameters.Add("@Ejecutivo", SqlDbType.VarChar).Value = Ejec;
                                    querySaveStaff.Parameters.Add("@Cedula", SqlDbType.BigInt).Value = Cedula;
                                    querySaveStaff.Parameters.Add("@Relacion", SqlDbType.VarChar).Value = DropDownList2.SelectedValue;
                                    querySaveStaff.Parameters.Add("@FechaNac", SqlDbType.DateTime).Value = DateTime.Parse(Text2.Value);
                                    try
                                    {
                                        openCon.Open();
                                        querySaveStaff.ExecuteNonQuery();
                                        openCon.Close();
                                        ///Diferencial entre adicion e inclusion ////
                                        if (Request.Cookies["indexC"].Value != null)
                                        {
                                            if (Request.Cookies["indexC"].Value == "1")
                                            {
                                                //HttpCookie total3S = new HttpCookie("indexC");
                                                //total3S.Value = "1";
                                                //total3S.Expires = DateTime.Now.AddDays(30);
                                                //Response.Cookies.Add(total3S);
                                                Response.Write("<script>alert('REGISTRO EXITOSO')</script>");
                                            }
                                            else
                                            {
                                                HttpCookie total3S = new HttpCookie("indexC");
                                                total3S.Value = "15";
                                                total3S.Expires = DateTime.Now.AddDays(30);
                                                Response.Cookies.Add(total3S);
                                                Page.RegisterStartupScript("LoadFunction", "<script type='text/javascript'>alert('REGISTRO EXITOSO');window.location='AdicionSeleccion.aspx'</script>");
                                            }
                                        }

                                    }
                                    catch (SqlException ex)
                                    {
                                        Response.Write("Error" + ex);
                                    }
                                }
                            }
                        }
                        if (Request.Cookies["indexC"].Value == "35")
                        {
                            prefifin.Text = String.Format("{0:.##}", Double.Parse(DropDownList5.SelectedValue));
                            string CedulaTom = Request.Cookies["paramCedula"].Value;
                            string Ejec = Request.Cookies["nombreC"].Value;
                            string fecha = Request.Cookies["fechaC"].Value;
                            if (Request.Cookies["totalC"] == null)
                            {
                                double t = double.Parse(DropDownList5.SelectedValue);
                                double z = double.Parse(Request.Cookies["ajusteC"].Value);
                                double y;
                                if (Request.Cookies["primaproC"] != null)
                                {
                                    y = double.Parse(Request.Cookies["primaproC"].Value);
                                    m = (z - y) + t;
                                }
                                else
                                {
                                    y = 0;
                                    m = (z - y) + t;
                                }
                                
                            }
                            else
                            {
                                double n = Double.Parse(Request.Cookies["totalC"].Value);
                                double x = Double.Parse(DropDownList5.SelectedValue);
                                double z = double.Parse(Request.Cookies["ajusteC"].Value);
                                double y;
                                if (Request.Cookies["primaproC"] != null)
                                {
                                    y = double.Parse(Request.Cookies["primaproC"].Value);
                                    m = (n - y + x);
                                }
                                else
                                {
                                    y = 0;
                                    m = (n - y + x);
                                }
                                
                               
                            }
                            HttpCookie totalS = new HttpCookie("totalC");
                            totalS.Value = m.ToString();
                            totalS.Expires = DateTime.Now.AddDays(30);
                            Response.Cookies.Add(totalS);
                            using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
                            {
                                string saveStaff = "INSERT into VentaTemp (Nombre, Producto, PlanSelect, Valor, FechaVenta, CedulaTomador, Ejecutivo, Cedula, Relacion, FechaNac) VALUES (@Nombre, @Producto, @PlanSelect, @Valor, @FechaVenta, @CedulaTomador, @Ejecutivo, @Cedula, @Relacion, @FechaNac)";

                                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                                {
                                    querySaveStaff.Connection = openCon;
                                    querySaveStaff.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Text1.Value;
                                    querySaveStaff.Parameters.Add("@Producto", SqlDbType.VarChar).Value = DropDownList3.SelectedValue.ToString();
                                    querySaveStaff.Parameters.Add("@PlanSelect", SqlDbType.VarChar).Value = DropDownList4.SelectedValue.ToString();
                                    querySaveStaff.Parameters.Add("@Valor", SqlDbType.Money).Value = Double.Parse(prefifin.Text);
                                    querySaveStaff.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DateTime.Parse(fecha);
                                    querySaveStaff.Parameters.Add("@CedulaTomador", SqlDbType.BigInt).Value = Int64.Parse(CedulaTom);
                                    querySaveStaff.Parameters.Add("@Ejecutivo", SqlDbType.VarChar).Value = Ejec;
                                    querySaveStaff.Parameters.Add("@Cedula", SqlDbType.BigInt).Value = Cedula;
                                    querySaveStaff.Parameters.Add("@Relacion", SqlDbType.VarChar).Value = DropDownList2.SelectedValue;
                                    querySaveStaff.Parameters.Add("@FechaNac", SqlDbType.DateTime).Value = DateTime.Parse(Text2.Value);
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

                                string saveStaff = "INSERT INTO Dependientes (Nombre, Cedula, Relacion, Producto, [Plan], TotalPrima, TotalCobrar, Genero, telfcelular, CedulaTomador, FechaVenta, FechaVigencia, FechaNac, NumeroCertificado, Estado, procesoWSM) VALUES (@Nombre, @Cedula, @Relacion, @Producto, @Plan, @TotalPrima, @TotalCobrar, @Genero, @telfcelular, @CedulaTomador, @FechaVenta, @FechaVigencia, @FechaNac, @NumeroCertificado, @Estado, @procesoWSM)";

                                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                                {
                                    querySaveStaff.Connection = openCon;
                                    querySaveStaff.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Text1.Value;
                                    querySaveStaff.Parameters.Add("@Estado", SqlDbType.VarChar).Value = "PREVENTA";
                                    querySaveStaff.Parameters.Add("@Cedula", SqlDbType.BigInt).Value = Cedula;
                                    querySaveStaff.Parameters.Add("@Relacion", SqlDbType.VarChar).Value = DropDownList2.SelectedValue;
                                    querySaveStaff.Parameters.Add("@Producto", SqlDbType.VarChar).Value = DropDownList3.SelectedValue;
                                    querySaveStaff.Parameters.Add("@Plan", SqlDbType.VarChar).Value = DropDownList4.SelectedValue;
                                    querySaveStaff.Parameters.Add("@TotalPrima", SqlDbType.Money).Value = Double.Parse(prefifin.Text);
                                    querySaveStaff.Parameters.Add("@TotalCobrar", SqlDbType.Money).Value = Double.Parse(prefifin.Text);
                                    querySaveStaff.Parameters.Add("@Genero", SqlDbType.VarChar).Value = DropDownList1.SelectedValue;
                                    querySaveStaff.Parameters.Add("@telfcelular", SqlDbType.VarChar).Value = "";
                                    querySaveStaff.Parameters.Add("@CedulaTomador", SqlDbType.BigInt).Value = Int64.Parse(CedulaTom);
                                    querySaveStaff.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DateTime.Parse(fecha);
                                    querySaveStaff.Parameters.Add("@FechaVigencia", SqlDbType.DateTime).Value = DateTime.Parse(Request.Cookies["fechavigC"].Value);
                                    querySaveStaff.Parameters.Add("@FechaNac", SqlDbType.DateTime).Value = DateTime.Parse(Text2.Value);
                                    querySaveStaff.Parameters.Add("@NumeroCertificado", SqlDbType.Int).Value = Request.Cookies["paramCert"].Value;
                                    querySaveStaff.Parameters.Add("@procesoWSM", SqlDbType.VarChar).Value = Request.Cookies["indexWSM"].Value;

                                    try
                                    {
                                        openCon.Open();
                                        querySaveStaff.ExecuteNonQuery();
                                        openCon.Close();
                                        Response.Write("<script>alert('REGISTRO EXITOSO')</script>");
                                        HttpCookie indexS = new HttpCookie("indexC");
                                        indexS.Value = "30";
                                        indexS.Expires = DateTime.Now.AddDays(30);
                                        Response.Cookies.Add(indexS);
                                        Response.Redirect("AdicionSeleccion.aspx");

                                    }
                                    catch (SqlException ex)
                                    {
                                        Response.Write("Error" + ex);
                                    }
                                }
                            }


                        }
                    }
                    else if (Request.Cookies["indexintC"] != null)
                    {
                        if (Request.Cookies["indexintC"].Value == "31")
                        {
                            prefifin.Text = String.Format("{0:.##}", Double.Parse(DropDownList5.SelectedValue));
                            string CedulaTom = Request.Cookies["paramCedula"].Value;
                            string Ejec = Request.Cookies["nombreC"].Value;
                            string fecha = Request.Cookies["fechaC"].Value;
                            if (Request.Cookies["totalC"] == null)
                            {
                                double t = double.Parse(DropDownList5.SelectedValue);
                                double z = double.Parse(Request.Cookies["ajusteC"].Value);
                                double y = double.Parse(Request.Cookies["primaproC"].Value);
                                m = (z - y) + t;
                            }
                            else
                            {
                                double n = Double.Parse(Request.Cookies["totalC"].Value);
                                double x = Double.Parse(DropDownList5.SelectedValue);
                                double z = double.Parse(Request.Cookies["ajusteC"].Value);
                                double y = double.Parse(Request.Cookies["primaproC"].Value);
                                m = (n - y + x);
                            }
                            HttpCookie totalS = new HttpCookie("totalC");
                            totalS.Value = m.ToString();
                            totalS.Expires = DateTime.Now.AddDays(30);
                            Response.Cookies.Add(totalS);
                            using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
                            {
                                string saveStaff = "INSERT into VentaTemp (Nombre, Producto, PlanSelect, Valor, FechaVenta, CedulaTomador, Ejecutivo, Cedula, Relacion, FechaNac) VALUES (@Nombre, @Producto, @PlanSelect, @Valor, @FechaVenta, @CedulaTomador, @Ejecutivo, @Cedula, @Relacion, @FechaNac)";

                                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                                {
                                    querySaveStaff.Connection = openCon;
                                    querySaveStaff.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Text1.Value;
                                    querySaveStaff.Parameters.Add("@Producto", SqlDbType.VarChar).Value = DropDownList3.SelectedValue.ToString();
                                    querySaveStaff.Parameters.Add("@PlanSelect", SqlDbType.VarChar).Value = DropDownList4.SelectedValue.ToString();
                                    querySaveStaff.Parameters.Add("@Valor", SqlDbType.Money).Value = Double.Parse(prefifin.Text);
                                    querySaveStaff.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DateTime.Parse(fecha);
                                    querySaveStaff.Parameters.Add("@CedulaTomador", SqlDbType.BigInt).Value = Int64.Parse(CedulaTom);
                                    querySaveStaff.Parameters.Add("@Ejecutivo", SqlDbType.VarChar).Value = Ejec;
                                    querySaveStaff.Parameters.Add("@Cedula", SqlDbType.BigInt).Value = Cedula;
                                    querySaveStaff.Parameters.Add("@Relacion", SqlDbType.VarChar).Value = DropDownList2.SelectedValue;
                                    querySaveStaff.Parameters.Add("@FechaNac", SqlDbType.DateTime).Value = DateTime.Parse(Text2.Value);
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

                                string saveStaff = "UPDATE Dependientes SET Estado=@Nombre, procesoWSM=@procesoWSM WHERE Nombre=@FIJADOR1 AND Cedula=@FIJADOR2 AND Producto=@FIJADOR3";

                                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                                {
                                    querySaveStaff.Connection = openCon;
                                    querySaveStaff.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = "EXCLUIDO";
                                    querySaveStaff.Parameters.Add("@procesoWSM", SqlDbType.VarChar).Value = "REEMPLAZADO";
                                    querySaveStaff.Parameters.Add("@FIJADOR1", SqlDbType.VarChar).Value = Request.Cookies["nombreadC"].Value;
                                    querySaveStaff.Parameters.Add("@FIJADOR2", SqlDbType.Int).Value = Int32.Parse(Request.Cookies["paramCedulaD"].Value);
                                    querySaveStaff.Parameters.Add("@FIJADOR3", SqlDbType.VarChar).Value = Request.Cookies["cobproC"].Value;
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

                                string saveStaff = "INSERT INTO Dependientes (Nombre, Cedula, Relacion, Producto, [Plan], TotalPrima, TotalCobrar, Genero, telfcelular, CedulaTomador, FechaVenta, FechaVigencia, FechaNac, NumeroCertificado, Estado, procesoWSM) VALUES (@Nombre, @Cedula, @Relacion, @Producto, @Plan, @TotalPrima, @TotalCobrar, @Genero, @telfcelular, @CedulaTomador, @FechaVenta, @FechaVigencia, @FechaNac, @NumeroCertificado, @Estado, @procesoWSM)";

                                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                                {
                                    querySaveStaff.Connection = openCon;
                                    querySaveStaff.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Text1.Value;
                                    querySaveStaff.Parameters.Add("@Estado", SqlDbType.VarChar).Value = "PREVENTA";
                                    querySaveStaff.Parameters.Add("@Cedula", SqlDbType.BigInt).Value = Cedula;
                                    querySaveStaff.Parameters.Add("@Relacion", SqlDbType.VarChar).Value = DropDownList2.SelectedValue;
                                    querySaveStaff.Parameters.Add("@Producto", SqlDbType.VarChar).Value = DropDownList3.SelectedValue;
                                    querySaveStaff.Parameters.Add("@Plan", SqlDbType.VarChar).Value = DropDownList4.SelectedValue;
                                    querySaveStaff.Parameters.Add("@TotalPrima", SqlDbType.Money).Value = Double.Parse(prefifin.Text);
                                    querySaveStaff.Parameters.Add("@TotalCobrar", SqlDbType.Money).Value = Double.Parse(prefifin.Text);
                                    querySaveStaff.Parameters.Add("@Genero", SqlDbType.VarChar).Value = DropDownList1.SelectedValue;
                                    querySaveStaff.Parameters.Add("@telfcelular", SqlDbType.VarChar).Value = "";
                                    querySaveStaff.Parameters.Add("@CedulaTomador", SqlDbType.BigInt).Value = Int64.Parse(CedulaTom);
                                    querySaveStaff.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DateTime.Parse(fecha);
                                    querySaveStaff.Parameters.Add("@FechaVigencia", SqlDbType.DateTime).Value = DateTime.Parse(Request.Cookies["fechavigC"].Value);
                                    querySaveStaff.Parameters.Add("@FechaNac", SqlDbType.DateTime).Value = DateTime.Parse(Text2.Value);
                                    querySaveStaff.Parameters.Add("@NumeroCertificado", SqlDbType.Int).Value = Request.Cookies["paramCert"].Value;
                                    querySaveStaff.Parameters.Add("@procesoWSM", SqlDbType.VarChar).Value = Request.Cookies["indexWSM"].Value;

                                    try
                                    {
                                        openCon.Open();
                                        querySaveStaff.ExecuteNonQuery();
                                        openCon.Close();
                                        Response.Write("<script>alert('REGISTRO EXITOSO')</script>");
                                        HttpCookie indexS = new HttpCookie("indexC");
                                        indexS.Value = "30";
                                        indexS.Expires = DateTime.Now.AddDays(30);
                                        Response.Cookies.Add(indexS);
                                        Response.Redirect("AdicionSeleccion.aspx");

                                    }
                                    catch (SqlException ex)
                                    {
                                        Response.Write("Error" + ex);
                                    }
                                }
                            }
                        }
                        else if (Request.Cookies["indexintC"].Value == "30")
                        {
                            prefifin.Text = String.Format("{0:.##}", Double.Parse(DropDownList5.SelectedValue));
                            string CedulaTom = Request.Cookies["paramCedula"].Value;
                            string Ejec = Request.Cookies["nombreC"].Value;
                            string fecha = Request.Cookies["fechaC"].Value;
                            if (Request.Cookies["totalC"] == null)
                            {
                                double t = double.Parse(DropDownList5.SelectedValue);
                                double z = double.Parse(Request.Cookies["ajusteC"].Value);
                                double y = double.Parse(Request.Cookies["primaproC"].Value);
                                m = (z - y) + t;
                            }
                            else
                            {
                                double n = Double.Parse(Request.Cookies["totalC"].Value);
                                double x = Double.Parse(DropDownList5.SelectedValue);
                                double z = double.Parse(Request.Cookies["ajusteC"].Value);
                                double y = double.Parse(Request.Cookies["primaproC"].Value);
                                m = (n - y + x);
                            }
                            HttpCookie totalS = new HttpCookie("totalC");
                            totalS.Value = m.ToString();
                            totalS.Expires = DateTime.Now.AddDays(30);
                            Response.Cookies.Add(totalS);
                            using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
                            {
                                string saveStaff = "INSERT into VentaTemp (Nombre, Producto, PlanSelect, Valor, FechaVenta, CedulaTomador, Ejecutivo, Cedula, Relacion, FechaNac) VALUES (@Nombre, @Producto, @PlanSelect, @Valor, @FechaVenta, @CedulaTomador, @Ejecutivo, @Cedula, @Relacion, @FechaNac)";

                                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                                {
                                    querySaveStaff.Connection = openCon;
                                    querySaveStaff.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Text1.Value;
                                    querySaveStaff.Parameters.Add("@Producto", SqlDbType.VarChar).Value = DropDownList3.SelectedValue.ToString();
                                    querySaveStaff.Parameters.Add("@PlanSelect", SqlDbType.VarChar).Value = DropDownList4.SelectedValue.ToString();
                                    querySaveStaff.Parameters.Add("@Valor", SqlDbType.Money).Value = Double.Parse(prefifin.Text);
                                    querySaveStaff.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DateTime.Parse(fecha);
                                    querySaveStaff.Parameters.Add("@CedulaTomador", SqlDbType.BigInt).Value = Int64.Parse(CedulaTom);
                                    querySaveStaff.Parameters.Add("@Ejecutivo", SqlDbType.VarChar).Value = Ejec;
                                    querySaveStaff.Parameters.Add("@Cedula", SqlDbType.BigInt).Value = Cedula;
                                    querySaveStaff.Parameters.Add("@Relacion", SqlDbType.VarChar).Value = DropDownList2.SelectedValue;
                                    querySaveStaff.Parameters.Add("@FechaNac", SqlDbType.DateTime).Value = DateTime.Parse(Text2.Value);
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

                                string saveStaff = "UPDATE Dependientes SET Estado=@Nombre, procesoWSM=@procesoWSM WHERE Nombre=@FIJADOR1 AND Cedula=@FIJADOR2 AND Producto=@FIJADOR3";

                                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                                {
                                    querySaveStaff.Connection = openCon;
                                    querySaveStaff.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = "EXCLUIDO";
                                    querySaveStaff.Parameters.Add("@procesoWSM", SqlDbType.VarChar).Value = "REEMPLAZADO";
                                    querySaveStaff.Parameters.Add("@FIJADOR1", SqlDbType.VarChar).Value = Request.Cookies["nombreadC"].Value;
                                    querySaveStaff.Parameters.Add("@FIJADOR2", SqlDbType.Int).Value = Int32.Parse(Request.Cookies["paramCedulaD"].Value);
                                    querySaveStaff.Parameters.Add("@FIJADOR3", SqlDbType.VarChar).Value = Request.Cookies["cobproC"].Value;
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

                                string saveStaff = "INSERT INTO Dependientes (Nombre, Cedula, Relacion, Producto, [Plan], TotalPrima, TotalCobrar, Genero, telfcelular, CedulaTomador, FechaVenta, FechaVigencia, FechaNac, NumeroCertificado, Estado) VALUES (@Nombre, @Cedula, @Relacion, @Producto, @Plan, @TotalPrima, @TotalCobrar, @Genero, @telfcelular, @CedulaTomador, @FechaVenta, @FechaVigencia, @FechaNac, @NumeroCertificado, @Estado)";

                                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                                {
                                    querySaveStaff.Connection = openCon;
                                    querySaveStaff.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Text1.Value;
                                    querySaveStaff.Parameters.Add("@Estado", SqlDbType.VarChar).Value = "PREVENTA";
                                    querySaveStaff.Parameters.Add("@Cedula", SqlDbType.BigInt).Value = Cedula;
                                    querySaveStaff.Parameters.Add("@Relacion", SqlDbType.VarChar).Value = DropDownList2.SelectedValue;
                                    querySaveStaff.Parameters.Add("@Producto", SqlDbType.VarChar).Value = DropDownList3.SelectedValue;
                                    querySaveStaff.Parameters.Add("@Plan", SqlDbType.VarChar).Value = DropDownList4.SelectedValue;
                                    querySaveStaff.Parameters.Add("@TotalPrima", SqlDbType.Money).Value = Double.Parse(prefifin.Text);
                                    querySaveStaff.Parameters.Add("@TotalCobrar", SqlDbType.Money).Value = Double.Parse(prefifin.Text);
                                    querySaveStaff.Parameters.Add("@Genero", SqlDbType.VarChar).Value = DropDownList1.SelectedValue;
                                    querySaveStaff.Parameters.Add("@telfcelular", SqlDbType.VarChar).Value = "";
                                    querySaveStaff.Parameters.Add("@CedulaTomador", SqlDbType.BigInt).Value = Int64.Parse(CedulaTom);
                                    querySaveStaff.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DateTime.Parse(fecha);
                                    querySaveStaff.Parameters.Add("@FechaVigencia", SqlDbType.DateTime).Value = DateTime.Parse(Request.Cookies["fechavigC"].Value);
                                    querySaveStaff.Parameters.Add("@FechaNac", SqlDbType.DateTime).Value = DateTime.Parse(Text2.Value);
                                    querySaveStaff.Parameters.Add("@NumeroCertificado", SqlDbType.Int).Value = Request.Cookies["paramCert"].Value;

                                    try
                                    {
                                        openCon.Open();
                                        querySaveStaff.ExecuteNonQuery();
                                        openCon.Close();
                                        Response.Write("<script>alert('REGISTRO EXITOSO')</script>");
                                        HttpCookie indexS = new HttpCookie("indexC");
                                        indexS.Value = "30";
                                        indexS.Expires = DateTime.Now.AddDays(30);
                                        Response.Cookies.Add(indexS);
                                        Response.Redirect("AdicionSeleccion.aspx");

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
                            prefifin.Text = String.Format("{0:.##}", Double.Parse(DropDownList5.SelectedValue));
                            string CedulaTom = Request.Cookies["paramCedula"].Value;
                            string Ejec = Request.Cookies["nombreC"].Value;
                            string fecha = Request.Cookies["fechaC"].Value;
                            if (Request.Cookies["totalC"] == null)
                            {
                                double t = double.Parse(DropDownList5.SelectedValue);
                                double z = double.Parse(Request.Cookies["ajusteC"].Value);
                                double y = double.Parse(Request.Cookies["primaproC"].Value);
                                m = (z - y) + t;
                            }
                            else
                            {
                                double n = Double.Parse(Request.Cookies["totalC"].Value);
                                double x = Double.Parse(DropDownList5.SelectedValue);
                                double z = double.Parse(Request.Cookies["ajusteC"].Value);
                                double y = double.Parse(Request.Cookies["primaproC"].Value);
                                m = (n - y + x);
                            }
                            HttpCookie totalS = new HttpCookie("totalC");
                            totalS.Value = m.ToString();
                            totalS.Expires = DateTime.Now.AddDays(30);
                            Response.Cookies.Add(totalS);
                            using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
                            {
                                string saveStaff = "INSERT into VentaTemp (Nombre, Producto, PlanSelect, Valor, FechaVenta, CedulaTomador, Ejecutivo, Cedula, Relacion, FechaNac) VALUES (@Nombre, @Producto, @PlanSelect, @Valor, @FechaVenta, @CedulaTomador, @Ejecutivo, @Cedula, @Relacion, @FechaNac)";

                                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                                {
                                    querySaveStaff.Connection = openCon;
                                    querySaveStaff.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Text1.Value;
                                    querySaveStaff.Parameters.Add("@Producto", SqlDbType.VarChar).Value = DropDownList3.SelectedValue.ToString();
                                    querySaveStaff.Parameters.Add("@PlanSelect", SqlDbType.VarChar).Value = DropDownList4.SelectedValue.ToString();
                                    querySaveStaff.Parameters.Add("@Valor", SqlDbType.Money).Value = Double.Parse(prefifin.Text);
                                    querySaveStaff.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DateTime.Parse(fecha);
                                    querySaveStaff.Parameters.Add("@CedulaTomador", SqlDbType.BigInt).Value = Int64.Parse(CedulaTom);
                                    querySaveStaff.Parameters.Add("@Ejecutivo", SqlDbType.VarChar).Value = Ejec;
                                    querySaveStaff.Parameters.Add("@Cedula", SqlDbType.BigInt).Value = Cedula;
                                    querySaveStaff.Parameters.Add("@Relacion", SqlDbType.VarChar).Value = DropDownList2.SelectedValue;
                                    querySaveStaff.Parameters.Add("@FechaNac", SqlDbType.DateTime).Value = DateTime.Parse(Text2.Value);
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

                                string saveStaff = "UPDATE Dependientes SET Estado=@Nombre, procesoWSM=@procesoWSM WHERE Nombre=@FIJADOR1 AND Cedula=@FIJADOR2 AND Producto=@FIJADOR3";

                                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                                {
                                    querySaveStaff.Connection = openCon;
                                    querySaveStaff.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = "EXCLUIDO";
                                    querySaveStaff.Parameters.Add("@procesoWSM", SqlDbType.VarChar).Value = "REEMPLAZADO";
                                    querySaveStaff.Parameters.Add("@FIJADOR1", SqlDbType.VarChar).Value = Request.Cookies["nombreadC"].Value;
                                    querySaveStaff.Parameters.Add("@FIJADOR2", SqlDbType.Int).Value = Int32.Parse(Request.Cookies["paramCedulaD"].Value);
                                    querySaveStaff.Parameters.Add("@FIJADOR3", SqlDbType.VarChar).Value = Request.Cookies["cobproC"].Value;
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

                                string saveStaff = "INSERT INTO Dependientes (Nombre, Cedula, Relacion, Producto, [Plan], TotalPrima, TotalCobrar, Genero, telfcelular, CedulaTomador, FechaVenta, FechaVigencia, FechaNac, NumeroCertificado, Estado) VALUES (@Nombre, @Cedula, @Relacion, @Producto, @Plan, @TotalPrima, @TotalCobrar, @Genero, @telfcelular, @CedulaTomador, @FechaVenta, @FechaVigencia, @FechaNac, @NumeroCertificado, @Estado)";

                                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                                {
                                    querySaveStaff.Connection = openCon;
                                    querySaveStaff.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Text1.Value;
                                    querySaveStaff.Parameters.Add("@Estado", SqlDbType.VarChar).Value = "PRE VENTA";
                                    querySaveStaff.Parameters.Add("@Cedula", SqlDbType.BigInt).Value = Cedula;
                                    querySaveStaff.Parameters.Add("@Relacion", SqlDbType.VarChar).Value = DropDownList2.SelectedValue;
                                    querySaveStaff.Parameters.Add("@Producto", SqlDbType.VarChar).Value = DropDownList3.SelectedValue;
                                    querySaveStaff.Parameters.Add("@Plan", SqlDbType.VarChar).Value = DropDownList4.SelectedValue;
                                    querySaveStaff.Parameters.Add("@TotalPrima", SqlDbType.Money).Value = Double.Parse(prefifin.Text);
                                    querySaveStaff.Parameters.Add("@TotalCobrar", SqlDbType.Money).Value = Double.Parse(prefifin.Text);
                                    querySaveStaff.Parameters.Add("@Genero", SqlDbType.VarChar).Value = DropDownList1.SelectedValue;
                                    querySaveStaff.Parameters.Add("@telfcelular", SqlDbType.VarChar).Value = "";
                                    querySaveStaff.Parameters.Add("@CedulaTomador", SqlDbType.BigInt).Value = Int64.Parse(CedulaTom);
                                    querySaveStaff.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DateTime.Parse(fecha);
                                    querySaveStaff.Parameters.Add("@FechaVigencia", SqlDbType.DateTime).Value = DateTime.Parse(Request.Cookies["fechavigC"].Value);
                                    querySaveStaff.Parameters.Add("@FechaNac", SqlDbType.DateTime).Value = DateTime.Parse(Text2.Value);
                                    querySaveStaff.Parameters.Add("@NumeroCertificado", SqlDbType.Int).Value = Request.Cookies["paramCert"].Value;

                                    try
                                    {
                                        openCon.Open();
                                        querySaveStaff.ExecuteNonQuery();
                                        openCon.Close();
                                        Response.Write("<script>alert('REGISTRO EXITOSO')</script>");
                                        HttpCookie indexS = new HttpCookie("indexC");
                                        indexS.Value = "30";
                                        indexS.Expires = DateTime.Now.AddDays(30);
                                        Response.Cookies.Add(indexS);
                                        Response.Redirect("AdicionSeleccion.aspx");

                                    }
                                    catch (SqlException ex)
                                    {
                                        Response.Write("Error" + ex);
                                    }
                                }
                            }
                        }
                    }




                        
                    DropDownList2.SelectedValue = "0";
                }
            }
            


        }

        protected void Unnamed_Click1(object sender, EventArgs e)
        {
            if (Request.Cookies["indexC"] != null)
            {
                if (Request.Cookies["indexC"].Value == "9")
                {
                    Response.Redirect("Beneficiarios.aspx");
                }
                else if (Request.Cookies["indexC"].Value == "1")
                {
                    HttpCookie totalS = new HttpCookie("indexC");
                    totalS.Value = "11";
                    totalS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(totalS);
                    Response.Redirect("ListaTotal.aspx");
                }
                else
                {
                    Response.Redirect("ListaTotal.aspx");
                }
            }
            else
            {
                Response.Redirect("ListaTotal.aspx");
            }
        }

        protected void Unnamed_Click2(object sender, EventArgs e)
        {
            if (Request.Cookies["indexC"] != null)
            {
                if (Request.Cookies["indexC"].Value == "9")
                {
                    HttpCookie indexS = new HttpCookie("indexC");
                    indexS.Value = "8";
                    indexS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(indexS);
                    Response.Redirect("AdicionSeleccion.aspx");
                }
                else if (Request.Cookies["indexC"].Value == "2")
                {
                    HttpCookie indexS = new HttpCookie("indexC");
                    indexS.Value = "15";
                    indexS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(indexS);
                    Response.Redirect("AdicionSeleccion.aspx");
                }                
                else if (Request.Cookies["indexC"].Value == "3")
                {
                    HttpCookie indexS = new HttpCookie("indexC");
                    indexS.Value = "15";
                    indexS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(indexS);
                    Response.Redirect("AdicionSeleccion.aspx");
                }
                else if (Request.Cookies["indexC"].Value == "35")
                {
                    HttpCookie indexS = new HttpCookie("indexC");
                    indexS.Value = "30";
                    indexS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(indexS);
                    Response.Redirect("AdicionSeleccion.aspx");
                }

                else
                {
                    Response.Redirect("InclusionTomador.aspx");
                }
            }
            else if (Request.Cookies["indexintC"] != null)
            {
                if (Request.Cookies["indexintC"].Value == "31")
                {
                    HttpCookie indexS = new HttpCookie("indexC");
                    indexS.Value = "30";
                    indexS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(indexS);
                    Response.Redirect("AdicionSeleccion.aspx");
                }
                else if (Request.Cookies["indexintC"].Value == "30")
                {
                    HttpCookie indexS = new HttpCookie("indexC");
                    indexS.Value = "30";
                    indexS.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(indexS);
                    Response.Redirect("AdicionSeleccion.aspx");
                }
                else
                {
                    Response.Redirect("InclusionTomador.aspx");
                }
            }
            else
            {
                Response.Redirect("InclusionTomador.aspx");
            }
        }

        protected void Unnamed_Click3(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
        protected void Unnamed_Click5(object sender, EventArgs e)
        {
            string url = "https://servicios.registrocivil.gob.ec/cdd/";
            Response.Write("<script> window.open('" + url + "','_blank'); </script>");
        }

        protected void Unnamed_Click6(object sender, EventArgs e)
        {
            string url = "https://srienlinea.sri.gob.ec/sri-en-linea/SriDeclaracionesWeb/ConsultaImpuestoRenta/Consultas/consultaImpuestoRenta";
            Response.Write("<script> window.open('" + url + "','_blank'); </script>");
        }
        protected void Unnamed_Click7(object sender, EventArgs e)
        {
            Correo.Value = "";
            Text1.Value = "";
            Text2.Value = "";
            DropDownList1.SelectedValue = "GENERO";            
            DropDownList2.SelectedValue = "0";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            


            using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
            {

                string saveStaff = "DELETE FROM Dependientes WHERE Row=@Row";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
                    querySaveStaff.Parameters.Add("@Row", SqlDbType.Int).Value = Int32.Parse(Request.Cookies["rowC"].Value);


                    try
                    {
                        openCon.Open();
                        querySaveStaff.ExecuteNonQuery();
                        openCon.Close();

                        HttpCookie indexS = new HttpCookie("indexC");
                        indexS.Value = "8";
                        indexS.Expires = DateTime.Now.AddDays(30);
                        Response.Cookies.Add(indexS);
                        Response.Redirect("AdicionSeleccion.aspx");
                       

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