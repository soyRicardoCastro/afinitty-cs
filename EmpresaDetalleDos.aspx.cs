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
    public partial class EmpresaDetalleDos : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["indexempC"] != null)
            {
                if (Request.Cookies["indexempC"].Value == "1")
                {
                    Text2.Value = Request.Cookies["empdetalleC"].Value;
                    //Text2.Disabled = true;
                    string connectionString = Conection.ConexLine;
                    string query = "SELECT * FROM Empresa WHERE NombreComercial=@NombreComercial";


                    using (SqlConnection con = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {

                        cmd.Parameters.Add("@NombreComercial", SqlDbType.VarChar, 50).Value = Request.Cookies["empdetalleC"].Value;



                        con.Open();


                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                if (dr.IsDBNull(43))
                                {

                                }
                                else
                                {
                                    DropDownList1.SelectedValue = dr.GetFieldValue<string>(43);
                                }

                                if (dr.IsDBNull(0))
                                {

                                }
                                else
                                {
                                    Correo.Value = dr.GetFieldValue<string>(0);
                                }

                                if (dr.IsDBNull(1))
                                {

                                }
                                else
                                {
                                    Text1.Value = dr.GetFieldValue<string>(1);
                                }

                                if (dr.IsDBNull(3))
                                {

                                }
                                else
                                {
                                    Text7.Value = dr.GetFieldValue<string>(3);
                                }

                                if (dr.IsDBNull(4))
                                {

                                }
                                else
                                {
                                    Text5.Value = dr.GetFieldValue<string>(4);
                                }

                                if (dr.IsDBNull(5))
                                {

                                }
                                else
                                {
                                    Text6.Value = dr.GetFieldValue<string>(5);
                                }

                                if (dr.IsDBNull(9))
                                {

                                }
                                else
                                {
                                    Text3.Value = dr.GetFieldValue<string>(9);
                                }



                                if (dr.IsDBNull(10))
                                {

                                }
                                else
                                {
                                    Text9.Value = dr.GetFieldValue<string>(10);
                                }

                                if (dr.IsDBNull(11))
                                {

                                }
                                else
                                {
                                    Text13.Value = dr.GetFieldValue<string>(11);
                                }


                                if (dr.IsDBNull(12))
                                {

                                }
                                else
                                {
                                    Text4.Value = dr.GetFieldValue<string>(12);
                                }

                                if (dr.IsDBNull(13))
                                {

                                }
                                else
                                {
                                    Text10.Value = dr.GetFieldValue<string>(13);
                                }

                                if (dr.IsDBNull(14))
                                {

                                }
                                else
                                {
                                    Text14.Value = dr.GetFieldValue<string>(14);
                                }


                                if (dr.IsDBNull(15))
                                {

                                }
                                else
                                {
                                    Text8.Value = dr.GetFieldValue<string>(15);
                                }

                                if (dr.IsDBNull(16))
                                {

                                }
                                else
                                {
                                    Text11.Value = dr.GetFieldValue<string>(16);
                                }

                                if (dr.IsDBNull(17))
                                {

                                }
                                else
                                {
                                    Text15.Value = dr.GetFieldValue<string>(17);
                                }



                                if (dr.IsDBNull(18))
                                {

                                }
                                else
                                {
                                    Text17.Value = dr.GetFieldValue<string>(18);
                                }

                                if (dr.IsDBNull(19))
                                {

                                }
                                else
                                {
                                    Text12.Value = dr.GetFieldValue<string>(19);
                                }

                                if (dr.IsDBNull(20))
                                {

                                }
                                else
                                {
                                    Text16.Value = dr.GetFieldValue<string>(20);
                                }



                                if (dr.IsDBNull(21))
                                {

                                }
                                else
                                {
                                    Text18.Value = dr.GetFieldValue<string>(21);
                                }

                                if (dr.IsDBNull(22))
                                {

                                }
                                else
                                {
                                    Text19.Value = dr.GetFieldValue<string>(22);
                                }

                                if (dr.IsDBNull(23))
                                {

                                }
                                else
                                {
                                    Text20.Value = dr.GetFieldValue<string>(23);
                                }

                                if (dr.IsDBNull(24))
                                {

                                }
                                else
                                {
                                    Text21.Value = dr.GetFieldValue<string>(24);
                                }



                                if (dr.IsDBNull(25))
                                {

                                }
                                else
                                {
                                    Text22.Value = dr.GetFieldValue<string>(25);
                                }

                                if (dr.IsDBNull(26))
                                {

                                }
                                else
                                {
                                    Text23.Value = dr.GetFieldValue<string>(26);
                                }

                                if (dr.IsDBNull(27))
                                {

                                }
                                else
                                {
                                    Text24.Value = dr.GetFieldValue<string>(27);
                                }

                                if (dr.IsDBNull(28))
                                {

                                }
                                else
                                {
                                    Text25.Value = dr.GetFieldValue<string>(28);
                                }


                                if (dr.IsDBNull(29))
                                {

                                }
                                else
                                {
                                    Text26.Value = dr.GetFieldValue<string>(29);
                                }

                                if (dr.IsDBNull(30))
                                {

                                }
                                else
                                {
                                    Text27.Value = dr.GetFieldValue<string>(30);
                                }

                                if (dr.IsDBNull(31))
                                {

                                }
                                else
                                {
                                    Text28.Value = dr.GetFieldValue<string>(31);
                                }

                                if (dr.IsDBNull(32))
                                {

                                }
                                else
                                {
                                    Text29.Value = dr.GetFieldValue<string>(32);
                                }




                                if (dr.IsDBNull(33))
                                {

                                }
                                else
                                {
                                    Text30.Value = dr.GetFieldValue<string>(33);
                                }

                                if (dr.IsDBNull(34))
                                {

                                }
                                else
                                {
                                    Text31.Value = dr.GetFieldValue<string>(34);
                                }

                                if (dr.IsDBNull(35))
                                {

                                }
                                else
                                {
                                    Text32.Value = dr.GetFieldValue<string>(35);
                                }

                                if (dr.IsDBNull(36))
                                {

                                }
                                else
                                {
                                    Text33.Value = dr.GetFieldValue<string>(36);
                                }


                                if (dr.IsDBNull(7))
                                {

                                }
                                else
                                {
                                    DropDownList4.SelectedValue = dr.GetFieldValue<int>(7).ToString();
                                }

                                if (dr.IsDBNull(6))
                                {

                                }
                                else
                                {
                                    Text35.Value = dr.GetFieldValue<int>(6).ToString();
                                }

                                if (dr.IsDBNull(37))
                                {

                                }
                                else
                                {
                                    DropDownList3.SelectedValue = dr.GetFieldValue<string>(37);
                                }

                                if (dr.IsDBNull(38))
                                {

                                }
                                else
                                {
                                    Text39.Value = dr.GetFieldValue<string>(38);
                                }


                                if (dr.IsDBNull(39))
                                {

                                }
                                else
                                {
                                    DropDownList5.SelectedValue = dr.GetFieldValue<string>(39);
                                }

                                if (dr.IsDBNull(40))
                                {

                                }
                                else
                                {
                                    DropDownList2.SelectedValue = dr.GetFieldValue<string>(40);
                                }

                                if (dr.IsDBNull(44))
                                {

                                }
                                else
                                {
                                    Text43.Value = dr.GetFieldValue<double>(44).ToString();
                                }


                                if (dr.IsDBNull(41))
                                {

                                }
                                else
                                {
                                    Text44.Value = dr.GetFieldValue<string>(41);
                                }


                                if (dr.IsDBNull(8))
                                {

                                }
                                else
                                {
                                    if (dr.GetFieldValue<string>(8) == "TARJETA DE CREDITO")
                                    {
                                        Radio1.Checked = true;
                                    }
                                    else if (dr.GetFieldValue<string>(8) == "ROL DE PAGOS")
                                    {
                                        Radio2.Checked = true;
                                    }
                                    else if (dr.GetFieldValue<string>(8) == "AMBOS")
                                    {
                                        Radio7.Checked = true;
                                    }
                                }


                                if (dr.IsDBNull(42))
                                {

                                }
                                else
                                {
                                    if (dr.GetFieldValue<string>(42) == "TRANSFERENCIA")
                                    {
                                        Radio3.Checked = true;
                                    }
                                    else if (dr.GetFieldValue<string>(42) == "CHEQUE")
                                    {
                                        Radio4.Checked = true;
                                    }
                                    else if (dr.GetFieldValue<string>(42) == "DEBITO BANCARIO")
                                    {
                                        Radio5.Checked = true;
                                    }
                                    else if (dr.GetFieldValue<string>(42) == "MIX")
                                    {
                                        Radio6.Checked = true;
                                    }
                                }



                                if (dr.IsDBNull(66))
                                {

                                }
                                else
                                {
                                    if (dr.GetFieldValue<string>(66) == "ACTIVA")
                                    {
                                        Radio8.Checked = true;
                                    }
                                    else if (dr.GetFieldValue<string>(66) == "INACTIVA")
                                    {
                                        Radio9.Checked = true;
                                    }

                                }

                            }


                            dr.Close();
                        }

                        con.Close();
                    }
                    Response.Cookies["indexempC"].Expires = DateTime.Now.AddDays(-1);
                    
                    HttpCookie nombreS23 = new HttpCookie("indexIntempNomC");
                    nombreS23.Value = Request.Cookies["empdetalleC"].Value;
                    nombreS23.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(nombreS23);
                    Response.Cookies["empdetalleC"].Expires = DateTime.Now.AddDays(-1);
                    HttpCookie nombreS2 = new HttpCookie("indexIntempC");
                    nombreS2.Value = "2";
                    nombreS2.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(nombreS2);

                }
                else if (Request.Cookies["indexempC"].Value == "2")
                {
                    Text2.Value = Request.Cookies["empdetalleC"].Value;
                    //Text2.Disabled = true;
                    string connectionString = Conection.ConexLine;
                    string query = "SELECT * FROM Empresa WHERE NombreComercial=@NombreComercial";


                    using (SqlConnection con = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {

                        cmd.Parameters.Add("@NombreComercial", SqlDbType.VarChar, 50).Value = Request.Cookies["empdetalleC"].Value;



                        con.Open();


                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {


                                if (dr.IsDBNull(0))
                                {

                                }
                                else
                                {
                                    Correo.Value = dr.GetFieldValue<string>(0);
                                }

                                if (dr.IsDBNull(1))
                                {

                                }
                                else
                                {
                                    Text1.Value = dr.GetFieldValue<string>(1);
                                }

                                if (dr.IsDBNull(3))
                                {

                                }
                                else
                                {
                                    Text7.Value = dr.GetFieldValue<string>(3);
                                }

                                if (dr.IsDBNull(4))
                                {

                                }
                                else
                                {
                                    Text5.Value = dr.GetFieldValue<string>(4);
                                }

                                if (dr.IsDBNull(5))
                                {

                                }
                                else
                                {
                                    Text6.Value = dr.GetFieldValue<string>(5);
                                }

                                if (dr.IsDBNull(9))
                                {

                                }
                                else
                                {
                                    Text3.Value = dr.GetFieldValue<string>(9);
                                }



                                if (dr.IsDBNull(10))
                                {

                                }
                                else
                                {
                                    Text9.Value = dr.GetFieldValue<string>(10);
                                }

                                if (dr.IsDBNull(11))
                                {

                                }
                                else
                                {
                                    Text13.Value = dr.GetFieldValue<string>(11);
                                }


                                if (dr.IsDBNull(12))
                                {

                                }
                                else
                                {
                                    Text4.Value = dr.GetFieldValue<string>(12);
                                }

                                if (dr.IsDBNull(13))
                                {

                                }
                                else
                                {
                                    Text10.Value = dr.GetFieldValue<string>(13);
                                }

                                if (dr.IsDBNull(14))
                                {

                                }
                                else
                                {
                                    Text14.Value = dr.GetFieldValue<string>(14);
                                }


                                if (dr.IsDBNull(15))
                                {

                                }
                                else
                                {
                                    Text8.Value = dr.GetFieldValue<string>(15);
                                }

                                if (dr.IsDBNull(16))
                                {

                                }
                                else
                                {
                                    Text11.Value = dr.GetFieldValue<string>(16);
                                }

                                if (dr.IsDBNull(17))
                                {

                                }
                                else
                                {
                                    Text15.Value = dr.GetFieldValue<string>(17);
                                }



                                if (dr.IsDBNull(18))
                                {

                                }
                                else
                                {
                                    Text17.Value = dr.GetFieldValue<string>(18);
                                }

                                if (dr.IsDBNull(19))
                                {

                                }
                                else
                                {
                                    Text12.Value = dr.GetFieldValue<string>(19);
                                }

                                if (dr.IsDBNull(20))
                                {

                                }
                                else
                                {
                                    Text16.Value = dr.GetFieldValue<string>(20);
                                }



                                if (dr.IsDBNull(21))
                                {

                                }
                                else
                                {
                                    Text18.Value = dr.GetFieldValue<string>(21);
                                }

                                if (dr.IsDBNull(22))
                                {

                                }
                                else
                                {
                                    Text19.Value = dr.GetFieldValue<string>(22);
                                }

                                if (dr.IsDBNull(23))
                                {

                                }
                                else
                                {
                                    Text20.Value = dr.GetFieldValue<string>(23);
                                }

                                if (dr.IsDBNull(24))
                                {

                                }
                                else
                                {
                                    Text21.Value = dr.GetFieldValue<string>(24);
                                }



                                if (dr.IsDBNull(25))
                                {

                                }
                                else
                                {
                                    Text22.Value = dr.GetFieldValue<string>(25);
                                }

                                if (dr.IsDBNull(26))
                                {

                                }
                                else
                                {
                                    Text23.Value = dr.GetFieldValue<string>(26);
                                }

                                if (dr.IsDBNull(27))
                                {

                                }
                                else
                                {
                                    Text24.Value = dr.GetFieldValue<string>(27);
                                }

                                if (dr.IsDBNull(28))
                                {

                                }
                                else
                                {
                                    Text25.Value = dr.GetFieldValue<string>(28);
                                }


                                if (dr.IsDBNull(29))
                                {

                                }
                                else
                                {
                                    Text26.Value = dr.GetFieldValue<string>(29);
                                }

                                if (dr.IsDBNull(30))
                                {

                                }
                                else
                                {
                                    Text27.Value = dr.GetFieldValue<string>(30);
                                }

                                if (dr.IsDBNull(31))
                                {

                                }
                                else
                                {
                                    Text28.Value = dr.GetFieldValue<string>(31);
                                }

                                if (dr.IsDBNull(32))
                                {

                                }
                                else
                                {
                                    Text29.Value = dr.GetFieldValue<string>(32);
                                }




                                if (dr.IsDBNull(33))
                                {

                                }
                                else
                                {
                                    Text30.Value = dr.GetFieldValue<string>(33);
                                }

                                if (dr.IsDBNull(34))
                                {

                                }
                                else
                                {
                                    Text31.Value = dr.GetFieldValue<string>(34);
                                }

                                if (dr.IsDBNull(35))
                                {

                                }
                                else
                                {
                                    Text32.Value = dr.GetFieldValue<string>(35);
                                }

                                if (dr.IsDBNull(36))
                                {

                                }
                                else
                                {
                                    Text33.Value = dr.GetFieldValue<string>(36);
                                }


                                if (dr.IsDBNull(7))
                                {

                                }
                                else
                                {
                                    DropDownList4.SelectedValue = dr.GetFieldValue<int>(7).ToString();
                                }

                                if (dr.IsDBNull(6))
                                {

                                }
                                else
                                {
                                    Text35.Value = dr.GetFieldValue<int>(6).ToString();
                                }

                                if (dr.IsDBNull(37))
                                {

                                }
                                else
                                {
                                    DropDownList3.SelectedValue = dr.GetFieldValue<string>(37);
                                }

                                if (dr.IsDBNull(38))
                                {

                                }
                                else
                                {
                                    Text39.Value = dr.GetFieldValue<string>(38);
                                }


                                if (dr.IsDBNull(39))
                                {

                                }
                                else
                                {
                                    DropDownList5.SelectedValue = dr.GetFieldValue<string>(39);
                                }

                                if (dr.IsDBNull(40))
                                {

                                }
                                else
                                {
                                    DropDownList2.SelectedValue = dr.GetFieldValue<string>(40);
                                }
                                if (dr.IsDBNull(43))
                                {

                                }
                                else
                                {
                                    DropDownList1.SelectedValue = dr.GetFieldValue<string>(43);
                                }

                                if (dr.IsDBNull(44))
                                {

                                }
                                else
                                {
                                    Text43.Value = dr.GetFieldValue<double>(44).ToString();
                                }


                                if (dr.IsDBNull(41))
                                {

                                }
                                else
                                {
                                    Text44.Value = dr.GetFieldValue<string>(41);
                                }


                                if (dr.IsDBNull(8))
                                {

                                }
                                else
                                {
                                    if (dr.GetFieldValue<string>(8) == "TARJETA DE CREDITO")
                                    {
                                        Radio1.Checked = true;
                                    }
                                    else if (dr.GetFieldValue<string>(8) == "ROL DE PAGOS")
                                    {
                                        Radio2.Checked = true;
                                    }
                                    else if (dr.GetFieldValue<string>(8) == "AMBOS")
                                    {
                                        Radio7.Checked = true;
                                    }
                                }


                                if (dr.IsDBNull(42))
                                {

                                }
                                else
                                {
                                    if (dr.GetFieldValue<string>(42) == "TRANSFERENCIA")
                                    {
                                        Radio3.Checked = true;
                                    }
                                    else if (dr.GetFieldValue<string>(42) == "CHEQUE")
                                    {
                                        Radio4.Checked = true;
                                    }
                                    else if (dr.GetFieldValue<string>(42) == "DEBITO BANCARIO")
                                    {
                                        Radio5.Checked = true;
                                    }
                                    else if (dr.GetFieldValue<string>(42) == "MIX")
                                    {
                                        Radio6.Checked = true;
                                    }
                                }



                                if (dr.IsDBNull(66))
                                {

                                }
                                else
                                {
                                    if (dr.GetFieldValue<string>(66) == "ACTIVA")
                                    {
                                        Radio8.Checked = true;
                                    }
                                    else if (dr.GetFieldValue<string>(66) == "INACTIVA")
                                    {
                                        Radio9.Checked = true;
                                    }

                                }

                            }


                            dr.Close();
                        }

                        con.Close();
                    }
                    Response.Cookies["indexempC"].Expires = DateTime.Now.AddDays(-1);
                   
                }
                else if (Request.Cookies["indexempC"].Value == "3")
                {
                    elimbutton.Attributes.Add("style", "display:none");
                    Text2.Value = Request.Cookies["empdetalleC"].Value;
                    Text2.Disabled = true;
                    string connectionString = Conection.ConexLine;
                    string query = "SELECT MedioDeCobro FROM Empresa WHERE NombreComercial=@NombreComercial";


                    using (SqlConnection con = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {

                        cmd.Parameters.Add("@NombreComercial", SqlDbType.VarChar, 50).Value = Request.Cookies["empdetalleC"].Value;



                        con.Open();


                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {


                                if (dr.IsDBNull(0))
                                {

                                }
                                else
                                {
                                    if (dr.GetFieldValue<string>(0) == "TARJETA DE CREDITO")
                                    {
                                        Radio1.Checked = true;
                                    }
                                    else if (dr.GetFieldValue<string>(0) == "ROL DE PAGOS")
                                    {
                                        Radio2.Checked = true;
                                    }
                                    else if (dr.GetFieldValue<string>(0) == "AMBOS")
                                    {
                                        Radio7.Checked = true;
                                    }


                                }






                            }


                            dr.Close();
                        }

                        con.Close();
                    }
                    Response.Cookies["indexempC"].Expires = DateTime.Now.AddDays(-1);
                    HttpCookie nombreS23 = new HttpCookie("indexIntempNomC");
                    nombreS23.Value = Request.Cookies["empdetalleC"].Value;
                    nombreS23.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(nombreS23);
                    Response.Cookies["empdetalleC"].Expires = DateTime.Now.AddDays(-1);
                }
                else
                {
                    Text2.Value = Request.Cookies["empdetalleC"].Value;
                    Text2.Disabled = true;
                    string connectionString = Conection.ConexLine;
                    string query = "SELECT * FROM Empresa WHERE NombreComercial=@NombreComercial";


                    using (SqlConnection con = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {

                        cmd.Parameters.Add("@NombreComercial", SqlDbType.VarChar, 50).Value = Request.Cookies["empdetalleC"].Value;



                        con.Open();


                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {


                                if (dr.IsDBNull(0))
                                {

                                }
                                else
                                {
                                    Correo.Value = dr.GetFieldValue<string>(0);
                                }

                                if (dr.IsDBNull(1))
                                {

                                }
                                else
                                {
                                    Text1.Value = dr.GetFieldValue<string>(1);
                                }

                                if (dr.IsDBNull(3))
                                {

                                }
                                else
                                {
                                    Text7.Value = dr.GetFieldValue<string>(3);
                                }

                                if (dr.IsDBNull(4))
                                {

                                }
                                else
                                {
                                    Text5.Value = dr.GetFieldValue<string>(4);
                                }

                                if (dr.IsDBNull(5))
                                {

                                }
                                else
                                {
                                    Text6.Value = dr.GetFieldValue<string>(5);
                                }

                                if (dr.IsDBNull(9))
                                {

                                }
                                else
                                {
                                    Text3.Value = dr.GetFieldValue<string>(9);
                                }



                                if (dr.IsDBNull(10))
                                {

                                }
                                else
                                {
                                    Text9.Value = dr.GetFieldValue<string>(10);
                                }

                                if (dr.IsDBNull(11))
                                {

                                }
                                else
                                {
                                    Text13.Value = dr.GetFieldValue<string>(11);
                                }


                                if (dr.IsDBNull(12))
                                {

                                }
                                else
                                {
                                    Text4.Value = dr.GetFieldValue<string>(12);
                                }

                                if (dr.IsDBNull(13))
                                {

                                }
                                else
                                {
                                    Text10.Value = dr.GetFieldValue<string>(13);
                                }

                                if (dr.IsDBNull(14))
                                {

                                }
                                else
                                {
                                    Text14.Value = dr.GetFieldValue<string>(14);
                                }


                                if (dr.IsDBNull(15))
                                {

                                }
                                else
                                {
                                    Text8.Value = dr.GetFieldValue<string>(15);
                                }

                                if (dr.IsDBNull(16))
                                {

                                }
                                else
                                {
                                    Text11.Value = dr.GetFieldValue<string>(16);
                                }

                                if (dr.IsDBNull(17))
                                {

                                }
                                else
                                {
                                    Text15.Value = dr.GetFieldValue<string>(17);
                                }



                                if (dr.IsDBNull(18))
                                {

                                }
                                else
                                {
                                    Text17.Value = dr.GetFieldValue<string>(18);
                                }

                                if (dr.IsDBNull(19))
                                {

                                }
                                else
                                {
                                    Text12.Value = dr.GetFieldValue<string>(19);
                                }

                                if (dr.IsDBNull(20))
                                {

                                }
                                else
                                {
                                    Text16.Value = dr.GetFieldValue<string>(20);
                                }



                                if (dr.IsDBNull(21))
                                {

                                }
                                else
                                {
                                    Text18.Value = dr.GetFieldValue<string>(21);
                                }

                                if (dr.IsDBNull(22))
                                {

                                }
                                else
                                {
                                    Text19.Value = dr.GetFieldValue<string>(22);
                                }

                                if (dr.IsDBNull(23))
                                {

                                }
                                else
                                {
                                    Text20.Value = dr.GetFieldValue<string>(23);
                                }

                                if (dr.IsDBNull(24))
                                {

                                }
                                else
                                {
                                    Text21.Value = dr.GetFieldValue<string>(24);
                                }



                                if (dr.IsDBNull(25))
                                {

                                }
                                else
                                {
                                    Text22.Value = dr.GetFieldValue<string>(25);
                                }

                                if (dr.IsDBNull(26))
                                {

                                }
                                else
                                {
                                    Text23.Value = dr.GetFieldValue<string>(26);
                                }

                                if (dr.IsDBNull(27))
                                {

                                }
                                else
                                {
                                    Text24.Value = dr.GetFieldValue<string>(27);
                                }

                                if (dr.IsDBNull(28))
                                {

                                }
                                else
                                {
                                    Text25.Value = dr.GetFieldValue<string>(28);
                                }


                                if (dr.IsDBNull(29))
                                {

                                }
                                else
                                {
                                    Text26.Value = dr.GetFieldValue<string>(29);
                                }

                                if (dr.IsDBNull(30))
                                {

                                }
                                else
                                {
                                    Text27.Value = dr.GetFieldValue<string>(30);
                                }

                                if (dr.IsDBNull(31))
                                {

                                }
                                else
                                {
                                    Text28.Value = dr.GetFieldValue<string>(31);
                                }

                                if (dr.IsDBNull(32))
                                {

                                }
                                else
                                {
                                    Text29.Value = dr.GetFieldValue<string>(32);
                                }




                                if (dr.IsDBNull(33))
                                {

                                }
                                else
                                {
                                    Text30.Value = dr.GetFieldValue<string>(33);
                                }

                                if (dr.IsDBNull(34))
                                {

                                }
                                else
                                {
                                    Text31.Value = dr.GetFieldValue<string>(34);
                                }

                                if (dr.IsDBNull(35))
                                {

                                }
                                else
                                {
                                    Text32.Value = dr.GetFieldValue<string>(35);
                                }

                                if (dr.IsDBNull(36))
                                {

                                }
                                else
                                {
                                    Text33.Value = dr.GetFieldValue<string>(36);
                                }


                                if (dr.IsDBNull(7))
                                {

                                }
                                else
                                {
                                    DropDownList4.SelectedValue = dr.GetFieldValue<int>(7).ToString();
                                }

                                if (dr.IsDBNull(6))
                                {

                                }
                                else
                                {
                                    Text35.Value = dr.GetFieldValue<int>(6).ToString();
                                }

                                if (dr.IsDBNull(37))
                                {

                                }
                                else
                                {
                                    DropDownList3.SelectedValue = dr.GetFieldValue<string>(37);
                                }

                                if (dr.IsDBNull(38))
                                {

                                }
                                else
                                {
                                    Text39.Value = dr.GetFieldValue<string>(38);
                                }


                                if (dr.IsDBNull(39))
                                {

                                }
                                else
                                {
                                    DropDownList5.SelectedValue = dr.GetFieldValue<string>(39);
                                }

                                if (dr.IsDBNull(40))
                                {

                                }
                                else
                                {
                                    DropDownList2.SelectedValue = dr.GetFieldValue<string>(40);
                                }

                                if (dr.IsDBNull(44))
                                {

                                }
                                else
                                {
                                    Text43.Value = dr.GetFieldValue<double>(44).ToString();
                                }


                                if (dr.IsDBNull(41))
                                {

                                }
                                else
                                {
                                    Text44.Value = dr.GetFieldValue<string>(41);
                                }


                                if (dr.IsDBNull(8))
                                {

                                }
                                else
                                {
                                    if (dr.GetFieldValue<string>(8) == "TARJETA DE CREDITO")
                                    {
                                        Radio1.Checked = true;
                                    }
                                    else if (dr.GetFieldValue<string>(8) == "ROL DE PAGOS")
                                    {
                                        Radio2.Checked = true;
                                    }
                                    else if (dr.GetFieldValue<string>(8) == "AMBOS")
                                    {
                                        Radio7.Checked = true;
                                    }
                                }


                                if (dr.IsDBNull(42))
                                {

                                }
                                else
                                {
                                    if (dr.GetFieldValue<string>(42) == "TRANSFERENCIA")
                                    {
                                        Radio3.Checked = true;
                                    }
                                    else if (dr.GetFieldValue<string>(42) == "CHEQUE")
                                    {
                                        Radio4.Checked = true;
                                    }
                                    else if (dr.GetFieldValue<string>(42) == "DEBITO BANCARIO")
                                    {
                                        Radio5.Checked = true;
                                    }
                                    else if (dr.GetFieldValue<string>(42) == "MIX")
                                    {
                                        Radio6.Checked = true;
                                    }
                                }



                                if (dr.IsDBNull(66))
                                {

                                }
                                else
                                {
                                    if (dr.GetFieldValue<string>(66) == "ACTIVA")
                                    {
                                        Radio8.Checked = true;
                                    }
                                    else if (dr.GetFieldValue<string>(66) == "INACTIVA")
                                    {
                                        Radio9.Checked = true;
                                    }

                                }

                            }


                            dr.Close();
                        }

                        con.Close();
                    }
                    Response.Cookies["indexempC"].Expires = DateTime.Now.AddDays(-1);
                    HttpCookie nombreS2 = new HttpCookie("indexempC");
                    nombreS2.Value = "1";
                    nombreS2.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(nombreS2);
                    HttpCookie nombreS23 = new HttpCookie("indexIntempNomC");
                    nombreS23.Value = Request.Cookies["empdetalleC"].Value;
                    nombreS23.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(nombreS23);
                    Response.Cookies["empdetalleC"].Expires = DateTime.Now.AddDays(-1);

                }
            }
            else
            {
                
            }
            
            
            

        }



        protected void Unnamed_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["indexIntempC"] != null)
            {
                if (Request.Cookies["indexIntempC"].Value == "2")
                {
                    Response.Redirect("EmpEdicUno.aspx");
                }
                else if (Request.Cookies["indexIntempC"].Value == "1")
                {
                    Response.Redirect("EmpEdicUno.aspx");
                }
                else
                {
                    Response.Redirect("EmpDetalleUno.aspx");
                }
            }
            else
            {
                Response.Redirect("EmpDetalleUno.aspx");
            }
            
        }

        protected void Unnamed_Click1(object sender, EventArgs e)
        {
            string estado;
            if(Radio8.Checked == true)
            {
                estado = Radio8.Value;
            }
            else if (Radio9.Checked == true)
            {
                estado = Radio9.Value;
            }
            else
            {
                estado = Radio9.Value;
            }

            string forma;
            if (Radio3.Checked == true)
            {
                forma = Radio3.Value;
            }
            else if(Radio4.Checked == true)
            {
                forma = Radio4.Value;
            }
            else if (Radio5.Checked == true)
            {
                forma = Radio5.Value;
            }
            else if (Radio6.Checked == true)
            {
                forma = Radio6.Value;
            }
            else
            {
                forma = Radio6.Value;
            }

            string medio;
            if (Radio1.Checked == true)
            {
                medio = Radio1.Value;
            }
            else if (Radio2.Checked == true)
            {
                medio = Radio2.Value;
            }
            else if (Radio7.Checked == true)
            {
                medio = Radio7.Value;
            }
            else
            {
                medio = Radio7.Value;
            }
            



            using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
            {
                int clase;
                int poliza;
                if (Text35.Value == "")
                {
                    clase = 0;
                }
                else
                {
                    clase = Int32.Parse(Text35.Value);
                }
                if (DropDownList4.SelectedValue == "POLIZA")
                {
                    poliza = 0;
                }
                else
                {
                    poliza = Int32.Parse(DropDownList4.SelectedValue);
                }
                string saveStaff = "UPDATE Empresa SET Ruc=@Ruc, RazonSocial=@RazonSocial, Direccion=@Direccion, Provincia=@Provincia, Ciudad=@Ciudad, Clase=@Clase, Poliza=@Poliza, cf1=@cf1, cf2=@cf2, cf3=@cf3, telf1=@telf1, telf2=@telf2, telf3=@telf3, cel1=@cel1, cel2=@cel2, cel3=@cel3, email1=@email1, email2=@email2, email3=@email3, cdl1=@cdl1, cdl2=@cdl2, tdl1=@tdl1, tdl2=@tdl2, ccdl1=@ccdl1, ccdl2=@ccdl2, edl1=@edl1, edl2=@edl2, cdc1=@cdc1, cdc2=@cdc2, tdc1=@tdc1, tdc2=@tdc2, ccdc1=@ccdc1, ccdc2=@ccdc2, edc1=@edc1, edc2=@edc2, EjecutivoApertura=@EjecutivoApertura, FechaEnvioListado=@FechaEnvioListado, FechaEmision=@FechaEmision, TipoListado=@TipoListado, EmitenFactura=@EmitenFactura, PorcenComision=@PorcenComision, FechaLlamada=@FechaLlamada, Estado=@Estado, FormaPago=@FormaPago, MedioDeCobro=@MedioDeCobro, NombreComercial=@NombreComercialDos  WHERE NombreComercial=@NombreComercial";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
                    querySaveStaff.Parameters.Add("@Ruc", SqlDbType.VarChar).Value = Correo.Value;
                    querySaveStaff.Parameters.Add("@RazonSocial", SqlDbType.VarChar).Value = Text1.Value;
                    querySaveStaff.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = Text7.Value;
                    querySaveStaff.Parameters.Add("@Provincia", SqlDbType.VarChar).Value = Text5.Value;                    
                    querySaveStaff.Parameters.Add("@Ciudad", SqlDbType.VarChar).Value = Text6.Value;
                    querySaveStaff.Parameters.Add("@Clase", SqlDbType.Int).Value = clase;
                    querySaveStaff.Parameters.Add("@Poliza", SqlDbType.Int).Value = poliza;
                    querySaveStaff.Parameters.Add("@cf1", SqlDbType.VarChar).Value = Text3.Value;
                    querySaveStaff.Parameters.Add("@cf2", SqlDbType.VarChar).Value = Text9.Value;
                    querySaveStaff.Parameters.Add("@cf3", SqlDbType.VarChar).Value = Text13.Value;
                    querySaveStaff.Parameters.Add("@telf1", SqlDbType.VarChar).Value = Text4.Value;
                    querySaveStaff.Parameters.Add("@telf2", SqlDbType.VarChar).Value = Text10.Value;
                    querySaveStaff.Parameters.Add("@telf3", SqlDbType.VarChar).Value = Text14.Value;
                    querySaveStaff.Parameters.Add("@cel1", SqlDbType.VarChar).Value = Text8.Value;
                    querySaveStaff.Parameters.Add("@cel2", SqlDbType.VarChar).Value = Text11.Value;
                    querySaveStaff.Parameters.Add("@cel3", SqlDbType.VarChar).Value = Text15.Value;
                    querySaveStaff.Parameters.Add("@email1", SqlDbType.VarChar).Value = Text17.Value;
                    querySaveStaff.Parameters.Add("@email2", SqlDbType.VarChar).Value = Text12.Value;
                    querySaveStaff.Parameters.Add("@email3", SqlDbType.VarChar).Value = Text16.Value;
                    querySaveStaff.Parameters.Add("@cdl1", SqlDbType.VarChar).Value = Text18.Value;
                    querySaveStaff.Parameters.Add("@cdl2", SqlDbType.VarChar).Value = Text19.Value;
                    querySaveStaff.Parameters.Add("@tdl1", SqlDbType.VarChar).Value = Text20.Value;
                    querySaveStaff.Parameters.Add("@tdl2", SqlDbType.VarChar).Value = Text21.Value;
                    querySaveStaff.Parameters.Add("@ccdl1", SqlDbType.VarChar).Value = Text22.Value;
                    querySaveStaff.Parameters.Add("@ccdl2", SqlDbType.VarChar).Value = Text23.Value;
                    querySaveStaff.Parameters.Add("@edl1", SqlDbType.VarChar).Value = Text24.Value;
                    querySaveStaff.Parameters.Add("@edl2", SqlDbType.VarChar).Value = Text25.Value;
                    querySaveStaff.Parameters.Add("@cdc1", SqlDbType.VarChar).Value = Text26.Value;
                    querySaveStaff.Parameters.Add("@cdc2", SqlDbType.VarChar).Value = Text27.Value;
                    querySaveStaff.Parameters.Add("@tdc1", SqlDbType.VarChar).Value = Text28.Value;
                    querySaveStaff.Parameters.Add("@tdc2", SqlDbType.VarChar).Value = Text29.Value;
                    querySaveStaff.Parameters.Add("@ccdc1", SqlDbType.VarChar).Value = Text30.Value;
                    querySaveStaff.Parameters.Add("@ccdc2", SqlDbType.VarChar).Value = Text31.Value;
                    querySaveStaff.Parameters.Add("@edc1", SqlDbType.VarChar).Value = Text32.Value;
                    querySaveStaff.Parameters.Add("@edc2", SqlDbType.VarChar).Value = Text33.Value;                    
                    querySaveStaff.Parameters.Add("@EjecutivoApertura", SqlDbType.VarChar).Value = DropDownList1.SelectedValue;
                    querySaveStaff.Parameters.Add("@FechaEmision", SqlDbType.VarChar).Value = DropDownList3.SelectedValue;
                    querySaveStaff.Parameters.Add("@FechaEnvioListado", SqlDbType.VarChar).Value = Text39.Value;
                    querySaveStaff.Parameters.Add("@TipoListado", SqlDbType.VarChar).Value = DropDownList5.SelectedValue;
                    querySaveStaff.Parameters.Add("@EmitenFactura", SqlDbType.VarChar).Value = DropDownList2.SelectedValue;
                    querySaveStaff.Parameters.Add("@PorcenComision", SqlDbType.VarChar).Value = Text43.Value;
                    querySaveStaff.Parameters.Add("@FechaLlamada", SqlDbType.VarChar).Value = Text44.Value;
                    querySaveStaff.Parameters.Add("@Estado", SqlDbType.VarChar).Value = estado;
                    querySaveStaff.Parameters.Add("@FormaPago", SqlDbType.VarChar).Value = forma;
                    querySaveStaff.Parameters.Add("@MedioDeCobro", SqlDbType.VarChar).Value = medio;
                    querySaveStaff.Parameters.Add("@NombreComercial", SqlDbType.VarChar).Value = Request.Cookies["indexIntempNomC"].Value;
                    querySaveStaff.Parameters.Add("@NombreComercialDos", SqlDbType.VarChar).Value = Text2.Value;
                    try
                    {
                        openCon.Open();
                        querySaveStaff.ExecuteNonQuery();
                        openCon.Close();
                        if (Request.Cookies["indexIntempC"] != null)
                        {
                            if (Request.Cookies["indexIntempC"].Value == "2")
                            {
                                Page.RegisterStartupScript("LoadFunction", "<script type='text/javascript'>alert('REGISTRO COMPLETADO CON EXITO');window.location='EmpEdicUno.aspx'</script>");
                                Response.Cookies["indexIntempC"].Expires = DateTime.Now.AddDays(-1);
                                
                            }
                            else if (Request.Cookies["indexempC"].Value == "1")
                            {
                                Page.RegisterStartupScript("LoadFunction", "<script type='text/javascript'>alert('REGISTRO COMPLETADO CON EXITO');window.location='EmpEdicUno.aspx'</script>");
                                Response.Cookies["indexempC"].Expires = DateTime.Now.AddDays(-1);
                            }
                            else
                            {
                                Page.RegisterStartupScript("LoadFunction", "<script type='text/javascript'>alert('REGISTRO COMPLETADO CON EXITO');window.location='EmpDetalleUno.aspx'</script>");
                                Response.Cookies["indexempC"].Expires = DateTime.Now.AddDays(-1);
                            }
                        }
                        else
                        {
                            Page.RegisterStartupScript("LoadFunction", "<script type='text/javascript'>alert('REGISTRO COMPLETADO CON EXITO');window.location='EmpDetalleUno.aspx'</script>");
                            Response.Cookies["indexempC"].Expires = DateTime.Now.AddDays(-1);
                        }


                    }
                    catch (SqlException ex)
                    {
                        Response.Write("Error" + ex);
                    }
                }


            }
            
        }
        protected void Unnamed_Click12(object sender, EventArgs e)
        {

            using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
            {

                string saveStaff = "DELETE FROM EMPRESA WHERE NombreComercial=@NombreComercial ";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
                    

                    querySaveStaff.Parameters.Add("@NombreComercial", SqlDbType.VarChar).Value = Text2.Value;
                    try
                    {
                        openCon.Open();
                        querySaveStaff.ExecuteNonQuery();
                        openCon.Close();
                        if (Request.Cookies["indexempC"] != null)
                        {
                            if (Request.Cookies["indexempC"].Value == "2")
                            {
                                Page.RegisterStartupScript("LoadFunction", "<script type='text/javascript'>alert('EMPRESA ELIMINADA');window.location='EmpEdicUno.aspx'</script>");
                                Response.Cookies["indexempC"].Expires = DateTime.Now.AddDays(-1);
                            }
                            else if (Request.Cookies["indexempC"].Value == "1")
                            {
                                Page.RegisterStartupScript("LoadFunction", "<script type='text/javascript'>alert('EMPRESA ELIMINADA');window.location='EmpEdicUno.aspx'</script>");
                                Response.Cookies["indexempC"].Expires = DateTime.Now.AddDays(-1);
                            }
                            else
                            {
                                Page.RegisterStartupScript("LoadFunction", "<script type='text/javascript'>alert('EMPRESA ELIMINADA');window.location='EmpDetalleUno.aspx'</script>");
                                Response.Cookies["indexempC"].Expires = DateTime.Now.AddDays(-1);
                            }
                        }
                        else
                        {
                            Page.RegisterStartupScript("LoadFunction", "<script type='text/javascript'>alert('EMPRESA ELIMINADA');window.location='EmpDetalleUno.aspx'</script>");
                            Response.Cookies["indexempC"].Expires = DateTime.Now.AddDays(-1);
                        }
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