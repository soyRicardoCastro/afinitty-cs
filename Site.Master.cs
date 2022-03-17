using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReachSystem
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int timer = DateTime.Now.Hour;

            BLOQUE2.Attributes.Add("style", "display:none");
            if (Request.Cookies["nombreC"] != null)
            {
                Label1.Text = ""+Request.Cookies["nombreC"].Value+" "+Request.Cookies["appellC"].Value + "";
                if(Request.Cookies["PerfilC"].Value == "VENTA")
                {
                    ap1.Attributes.Add("style", "display:none");
                    BLOQUE2.Attributes.Add("style", "display:none");
                    BLOQUE3.Attributes.Add("style", "display:none");
                    reptom.Attributes.Add("style", "display:none");
                    //repcert.Attributes.Add("style", "display:none");
                    repcert2.Attributes.Add("style", "display:none");
                    //repven.Attributes.Add("style", "display:none");
                    //repaseg.Attributes.Add("style", "display:none");
                    //repcob.Attributes.Add("style", "display:none");
                    //repex.Attributes.Add("style", "display:none");
                    cierr.Attributes.Add("style", "display:none");
                    cirrex.Attributes.Add("style", "display:none");
                    repcierr.Attributes.Add("style", "display:none");
                    //repus.Attributes.Add("style", "display:none");
                    //reprec.Attributes.Add("style", "display:none");
                    aper3.Attributes.Add("style", "display:none");
                    A1.Attributes.Add("style", "display:none");
                    A2.Attributes.Add("style", "display:none");
                    A3.Attributes.Add("style", "display:none");
                    A4.Attributes.Add("style", "display:none");
                    A5.Attributes.Add("style", "display:none");
                    A7.Attributes.Add("style", "display:none");
                    A6.Attributes.Add("style", "display:none");
                    A8.Attributes.Add("style", "display:none");
                    A9.Attributes.Add("style", "display:none");
                    A10.Attributes.Add("style", "display:none");
                    A11.Attributes.Add("style", "display:none");
                    A12.Attributes.Add("style", "display:none");
                    A13.Attributes.Add("style", "display:none");
                    A14.Attributes.Add("style", "display:none");
                    A15.Attributes.Add("style", "display:none");
                    A19.Attributes.Add("style", "display:none");
                    A17.Attributes.Add("style", "display:none");
                    A18.Attributes.Add("style", "display:none");
                    A16.Attributes.Add("style", "display:none");
                    A20.Attributes.Add("style", "display:none");
                    A24.Attributes.Add("style", "display:none");
                    A25.Attributes.Add("style", "display:none");
                    A22.Attributes.Add("style", "display:none");
                    A21.Attributes.Add("style", "display:none");
                    A26.Attributes.Add("style", "display:none");
                    A27.Attributes.Add("style", "display:none");

                }
                else if (Request.Cookies["PerfilC"].Value == "ADMIN")
                {
                    

                }
                else if (Request.Cookies["PerfilC"].Value == "COBRANZA")
                {
                    BLOQUE1.Attributes.Add("style", "display:none");
                    BLOQUE2.Attributes.Add("style", "display:none");
                    reptom.Attributes.Add("style", "display:none");
                    //repcert.Attributes.Add("style", "display:none");
                    repcert2.Attributes.Add("style", "display:none");
                    //repven.Attributes.Add("style", "display:none");
                    //repaseg.Attributes.Add("style", "display:none");
                    //repcob.Attributes.Add("style", "display:none");
                    //repex.Attributes.Add("style", "display:none");
                    repvendedor.Attributes.Add("style", "display:none");
                    //repcobertemp.Attributes.Add("style", "display:none");
                    repcierr.Attributes.Add("style", "display:none");
                    //repus.Attributes.Add("style", "display:none");
                    //reprec.Attributes.Add("style", "display:none");
                    //proc.Attributes.Add("style", "display:none");
                    //reten.Attributes.Add("style", "display:none");
                    list.Attributes.Add("style", "display:none");
                    crea.Attributes.Add("style", "display:none");
                    edic.Attributes.Add("style", "display:none");
                    list2.Attributes.Add("style", "display:none");
                    prod2.Attributes.Add("style", "display:none");
                    edic2.Attributes.Add("style", "display:none");
                    empre.Attributes.Add("style", "display:none");
                    asist.Attributes.Add("style", "display:none");
                    cierr.Attributes.Add("style", "display:none");
                    cirrex.Attributes.Add("style", "display:none");
                    rechist.Attributes.Add("style", "display:none");
                    cobtom.Attributes.Add("style", "display:none");
                    recons.Attributes.Add("style", "display:none");
                    recdoc.Attributes.Add("style", "display:none");
                    recresp.Attributes.Add("style", "display:none");
                    admin.Attributes.Add("style", "display:none");
                    aper3.Attributes.Add("style", "display:none");
                    A1.Attributes.Add("style", "display:none");
                    A2.Attributes.Add("style", "display:none");
                    A4.Attributes.Add("style", "display:none");
                    A5.Attributes.Add("style", "display:none");
                    //A7.Attributes.Add("style", "display:none");
                    A6.Attributes.Add("style", "display:none");
                    A8.Attributes.Add("style", "display:none");
                    A9.Attributes.Add("style", "display:none");
                    A10.Attributes.Add("style", "display:none");
                    A11.Attributes.Add("style", "display:none");
                    A12.Attributes.Add("style", "display:none");
                    A13.Attributes.Add("style", "display:none");
                    A14.Attributes.Add("style", "display:none");
                    //A15.Attributes.Add("style", "display:none");
                    A19.Attributes.Add("style", "display:none");
                    A17.Attributes.Add("style", "display:none");
                    A16.Attributes.Add("style", "display:none");
                    A20.Attributes.Add("style", "display:none");
                    A24.Attributes.Add("style", "display:none");
                    A25.Attributes.Add("style", "display:none");
                    A22.Attributes.Add("style", "display:none");
                    A21.Attributes.Add("style", "display:none");
                    A26.Attributes.Add("style", "display:none");
                    A27.Attributes.Add("style", "display:none");
                }
                else if (Request.Cookies["PerfilC"].Value == "DIRECVEN")
                {
                    BLOQUE2.Attributes.Add("style", "display:none");
                    admin.Attributes.Add("style", "display:none");
                    proc.Attributes.Add("style", "display:none");
                    reten.Attributes.Add("style", "display:none");
                    list.Attributes.Add("style", "display:none");
                    crea.Attributes.Add("style", "display:none");
                    edic.Attributes.Add("style", "display:none");
                    list2.Attributes.Add("style", "display:none");
                    prod2.Attributes.Add("style", "display:none");
                    edic2.Attributes.Add("style", "display:none");
                    empre.Attributes.Add("style", "display:none");
                    asist.Attributes.Add("style", "display:none");
                    cierr.Attributes.Add("style", "display:none");
                    cirrex.Attributes.Add("style", "display:none");
                    cobremp.Attributes.Add("style", "display:none");
                    cobtom.Attributes.Add("style", "display:none");
                    recons.Attributes.Add("style", "display:none");
                    recdoc.Attributes.Add("style", "display:none");
                    recresp.Attributes.Add("style", "display:none");
                    //repcert.Attributes.Add("style", "display:none");
                    //repaseg.Attributes.Add("style", "display:none");
                    repcert2.Attributes.Add("style", "display:none");
                    //repex.Attributes.Add("style", "display:none");
                    //repag.Attributes.Add("style", "display:none");
                    //repcobertemp.Attributes.Add("style", "display:none");
                    repcierr.Attributes.Add("style", "display:none");
                    //repus.Attributes.Add("style", "display:none");
                    aper3.Attributes.Add("style", "display:none");
                    A1.Attributes.Add("style", "display:none");
                    A2.Attributes.Add("style", "display:none");
                    A3.Attributes.Add("style", "display:none");
                    A4.Attributes.Add("style", "display:none");
                    A5.Attributes.Add("style", "display:none");
                    A7.Attributes.Add("style", "display:none");
                    A8.Attributes.Add("style", "display:none");
                    A9.Attributes.Add("style", "display:none");
                    A10.Attributes.Add("style", "display:none");
                    A11.Attributes.Add("style", "display:none");
                    A12.Attributes.Add("style", "display:none");
                    A13.Attributes.Add("style", "display:none");
                    A14.Attributes.Add("style", "display:none");
                    A15.Attributes.Add("style", "display:none");
                    A19.Attributes.Add("style", "display:none");
                    A17.Attributes.Add("style", "display:none");
                    A18.Attributes.Add("style", "display:none");
                    //A16.Attributes.Add("style", "display:none");
                    A24.Attributes.Add("style", "display:none");
                    A25.Attributes.Add("style", "display:none");
                    A22.Attributes.Add("style", "display:none");
                    A21.Attributes.Add("style", "display:none");
                    A26.Attributes.Add("style", "display:none");
                    A27.Attributes.Add("style", "display:none");
                }
                else if (Request.Cookies["PerfilC"].Value == "SERVICIO")
                {
                    ap1.Attributes.Add("style", "display:none");
                    admin.Attributes.Add("style", "display:none");
                    BLOQUE2.Attributes.Add("style", "display:none");
                    reten.Attributes.Add("style", "display:none");
                    list.Attributes.Add("style", "display:none");
                    crea.Attributes.Add("style", "display:none");
                    edic.Attributes.Add("style", "display:none");
                    list2.Attributes.Add("style", "display:none");
                    prod2.Attributes.Add("style", "display:none");
                    edic2.Attributes.Add("style", "display:none");
                    cierr.Attributes.Add("style", "display:none");
                    cirrex.Attributes.Add("style", "display:none");
                    cobtom.Attributes.Add("style", "display:none");
                    reptom.Attributes.Add("style", "display:none");
                    //repven.Attributes.Add("style", "display:none");
                    repvendedor.Attributes.Add("style", "display:none");
                    //repaseg.Attributes.Add("style", "display:none");
                    //repcob.Attributes.Add("style", "display:none");
                    //repex.Attributes.Add("style", "display:none");
                    //repag.Attributes.Add("style", "display:none");
                    //repcobertemp.Attributes.Add("style", "display:none");
                    repcierr.Attributes.Add("style", "display:none");
                    //repus.Attributes.Add("style", "display:none");
                    aper3.Attributes.Add("style", "display:none");
                    A1.Attributes.Add("style", "display:none");
                    A2.Attributes.Add("style", "display:none");
                    A4.Attributes.Add("style", "display:none");
                    A5.Attributes.Add("style", "display:none");
                    A6.Attributes.Add("style", "display:none");
                    A8.Attributes.Add("style", "display:none");
                    A9.Attributes.Add("style", "display:none");
                    A11.Attributes.Add("style", "display:none");
                    A12.Attributes.Add("style", "display:none");
                    A13.Attributes.Add("style", "display:none");
                    A14.Attributes.Add("style", "display:none");
                    A19.Attributes.Add("style", "display:none");
                    A17.Attributes.Add("style", "display:none");
                    A18.Attributes.Add("style", "display:none");
                    A20.Attributes.Add("style", "display:none");
                    repcert2.Attributes.Add("style", "display:none");
                    A7.Attributes.Add("style", "display:none");
                    A24.Attributes.Add("style", "display:none");
                    A25.Attributes.Add("style", "display:none");
                    A22.Attributes.Add("style", "display:none");
                    A21.Attributes.Add("style", "display:none");
                    A26.Attributes.Add("style", "display:none");
                    A27.Attributes.Add("style", "display:none");
                }
                else if (Request.Cookies["PerfilC"].Value == "OPERACIONES")
                {
                    ap1.Attributes.Add("style", "display:none");
                    inipro.Attributes.Add("style", "display:none");
                    adic.Attributes.Add("style", "display:none");
                    rem.Attributes.Add("style", "display:none");
                    BLOQUE2.Attributes.Add("style", "display:none");
                    cierr.Attributes.Add("style", "display:none");
                    cirrex.Attributes.Add("style", "display:none");
                    //BLOQUE4.Attributes.Add("style", "display:none");
                    list.Attributes.Add("style", "display:none");
                    crea.Attributes.Add("style", "display:none");
                    edic.Attributes.Add("style", "display:none");
                    list2.Attributes.Add("style", "display:none");
                    prod2.Attributes.Add("style", "display:none");
                    edic2.Attributes.Add("style", "display:none");
                    asist.Attributes.Add("style", "display:none");
                    cobtom.Attributes.Add("style", "display:none");
                    recons.Attributes.Add("style", "display:none");
                    recdoc.Attributes.Add("style", "display:none");
                    recresp.Attributes.Add("style", "display:none");
                    aper3.Attributes.Add("style", "display:none");
                    A1.Attributes.Add("style", "display:none");
                    A2.Attributes.Add("style", "display:none");
                    A4.Attributes.Add("style", "display:none");
                    A5.Attributes.Add("style", "display:none");
                    //A7.Attributes.Add("style", "display:none");
                    A6.Attributes.Add("style", "display:none");
                    A8.Attributes.Add("style", "display:none");
                    A9.Attributes.Add("style", "display:none");
                    A11.Attributes.Add("style", "display:none");
                    A12.Attributes.Add("style", "display:none");
                    A13.Attributes.Add("style", "display:none");
                    A14.Attributes.Add("style", "display:none");
                    A19.Attributes.Add("style", "display:none");
                    A17.Attributes.Add("style", "display:none");
                    A18.Attributes.Add("style", "display:none");
                    A16.Attributes.Add("style", "display:none");
                    A20.Attributes.Add("style", "display:none");
                    repcierr.Attributes.Add("style", "display:none");
                    repvendedor.Attributes.Add("style", "display:none");
                    reptom.Attributes.Add("style", "display:none");
                    repcierr.Attributes.Add("style", "display:none");
                    //repcert2.Attributes.Add("style", "display:none");
                    //A15.Attributes.Add("style", "display:none");
                    //repus.Attributes.Add("style", "display:none");
                    A24.Attributes.Add("style", "display:none");
                    A25.Attributes.Add("style", "display:none");
                    A22.Attributes.Add("style", "display:none");
                    A21.Attributes.Add("style", "display:none");
                    A26.Attributes.Add("style", "display:none");
                    A27.Attributes.Add("style", "display:none");
                }
                else if (Request.Cookies["PerfilC"].Value == "SUPEROP")
                {
                    ap1.Attributes.Add("style", "display:none");
                    inipro.Attributes.Add("style", "display:none");
                    adic.Attributes.Add("style", "display:none");
                    rem.Attributes.Add("style", "display:none");
                    list.Attributes.Add("style", "display:none");
                    crea.Attributes.Add("style", "display:none");
                    edic.Attributes.Add("style", "display:none");
                    cierr.Attributes.Add("style", "display:none");
                    cirrex.Attributes.Add("style", "display:none");
                    reptom.Attributes.Add("style", "display:none");
                    //repven.Attributes.Add("style", "display:none");
                    repvendedor.Attributes.Add("style", "display:none");
                    //repaseg.Attributes.Add("style", "display:none");
                    //repcob.Attributes.Add("style", "display:none");
                    repcierr.Attributes.Add("style", "display:none");
                    //repus.Attributes.Add("style", "display:none");
                    A2.Attributes.Add("style", "display:none");
                    A6.Attributes.Add("style", "display:none");
                    A9.Attributes.Add("style", "display:none");
                    A14.Attributes.Add("style", "display:none");
                    A19.Attributes.Add("style", "display:none");
                    DataTable DET;
                    if (Request.Cookies["TimerC"] == null && timer >= 9 && timer < 14)
                    {
                        HttpCookie nombreS = new HttpCookie("timerC");
                        nombreS.Value = timer.ToString();
                        nombreS.Expires = DateTime.Now.AddHours(16);
                        Response.Cookies.Add(nombreS);
                        SqlConnection con = new SqlConnection(Conection.ConexLine);
                        SqlDataAdapter sda = new SqlDataAdapter("select Correo, Alias from Usuario where perfil = 'OPERACIONES' or perfil = 'SUPEROP' ", con);
                        DataTable dt = new DataTable();
                        DET = dt;
                        sda.Fill(dt);
                        for (int j = 0; j < DET.Rows.Count; j++)
                        {


                            string body = "<body>" +
                                        "<h4>REPORTE CERTIFICADOS</h4>" +
                                        "<h4>ESTIMAD@: " + DET.Rows[j][1].ToString() + "</h4>" +
                                        "<h4>Estos son los certificados en estado INGRESADO</h4>" +
                                        //"<h4>https://affinity.somee.com/ProcesoIngresado</h4>" +
                                        //"<h4>https://affis.somee.com/ProcesoIngresado</h4>" +
                                        "<h4>https://localhost:44349//ProcesoIngresado</h4>" +
                                        "</body>";
                            SmtpClient smtp = new SmtpClient();
                            smtp.EnableSsl = false;
                            smtp.UseDefaultCredentials = false;
                            smtp.Host = "smtp.affinity.somee.com";
                            smtp.Port = 26;
                            smtp.Credentials = new NetworkCredential("certificados@affinity.somee.com", "Otto.123");
                            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;



                            MailMessage mail = new MailMessage();
                            mail.From = new MailAddress("certificados@affinity.somee.com", "SISTEMA AFFIS");
                            mail.To.Add(new MailAddress(DET.Rows[j][0].ToString()));
                            mail.Subject = "REPORTE CERTIFICADOS INGRESADOS " + DateTime.Now + "";
                            mail.IsBodyHtml = true;
                            mail.Body = body;

                            smtp.Send(mail);
                        }




                    }
                    else if (Request.Cookies["TimerC2"] == null && timer >= 14 && timer < 17)
                    {
                        HttpCookie nombreS = new HttpCookie("timerC2");
                        nombreS.Value = timer.ToString();
                        nombreS.Expires = DateTime.Now.AddHours(16);
                        Response.Cookies.Add(nombreS);
                        SqlConnection con = new SqlConnection(Conection.ConexLine);
                        SqlDataAdapter sda = new SqlDataAdapter("select Correo, Alias from Usuario where perfil = 'SUPEROP' ", con);
                        DataTable dt = new DataTable();
                        DET = dt;
                        sda.Fill(dt);
                        for (int j = 0; j < DET.Rows.Count; j++)
                        {


                            string body = "<body>" +
                                        "<h4>REPORTE CERTIFICADOS</h4>" +
                                        "<h4>ESTIMAD@: " + DET.Rows[j][1].ToString() + "</h4>" +
                                        "<h4>Estos son los certificados en estado COMPLETADO</h4>" +
                                        //"<h4>https://affinity.somee.com/ProcesoCompletado</h4>" +
                                        //"<h4>https://affis.somee.com/ProcesoCompletado</h4>" +
                                        "<h4>https://localhost:44349//ProcesoCompletado</h4>" +
                                        "</body>";
                            SmtpClient smtp = new SmtpClient();
                            smtp.EnableSsl = false;
                            smtp.UseDefaultCredentials = false;
                            smtp.Host = "smtp.affinity.somee.com";
                            smtp.Port = 26;
                            smtp.Credentials = new NetworkCredential("certificados@affinity.somee.com", "Otto.123");
                            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;



                            MailMessage mail = new MailMessage();
                            mail.From = new MailAddress("certificados@affinity.somee.com", "SISTEMA AFFIS");
                            mail.To.Add(new MailAddress(DET.Rows[j][0].ToString()));
                            mail.Subject = "REPORTE CERTIFICADOS COMPLETADOS " + DateTime.Now + "";
                            mail.IsBodyHtml = true;
                            mail.Body = body;

                            smtp.Send(mail);
                        }
                    }
                    else if (Request.Cookies["TimerC3"] == null && timer >= 17 && timer < 20)
                    {
                        HttpCookie nombreS = new HttpCookie("timerC3");
                        nombreS.Value = timer.ToString();
                        nombreS.Expires = DateTime.Now.AddHours(16);
                        Response.Cookies.Add(nombreS);
                        SqlConnection con = new SqlConnection(Conection.ConexLine);
                        SqlDataAdapter sda = new SqlDataAdapter("select Correo, Alias from Usuario where perfil = 'ADMIN' ", con);
                        DataTable dt = new DataTable();
                        DET = dt;
                        sda.Fill(dt);
                        for (int j = 0; j < DET.Rows.Count; j++)
                        {


                            string body = "<body>" +
                                        "<h4>REPORTE CERTIFICADOS</h4>" +
                                        "<h4>ESTIMAD@: " + DET.Rows[j][1].ToString() + "</h4>" +
                                        "<h4>Estos son los certificados en estado REVISADO</h4>" +
                                        //"<h4>https://affinity.somee.com/ProcesoRevisado</h4>" +
                                        //"<h4>https://affis.somee.com/ProcesoRevisado</h4>" +
                                        "<h4>https://localhost:44349//ProcesoRevisado</h4>" +
                                        "</body>";
                            SmtpClient smtp = new SmtpClient();
                            smtp.EnableSsl = false;
                            smtp.UseDefaultCredentials = false;
                            smtp.Host = "smtp.affinity.somee.com";
                            smtp.Port = 26;
                            smtp.Credentials = new NetworkCredential("certificados@affinity.somee.com", "Otto.123");
                            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;



                            MailMessage mail = new MailMessage();
                            mail.From = new MailAddress("certificados@affinity.somee.com", "SISTEMA AFFIS");
                            mail.To.Add(new MailAddress(DET.Rows[j][0].ToString()));
                            mail.Subject = "REPORTE CERTIFICADOS REVISADOS " + DateTime.Now + "";
                            mail.IsBodyHtml = true;
                            mail.Body = body;

                            smtp.Send(mail);
                        }
                    }
                    else
                    {

                    }
                }
                else if (Request.Cookies["PerfilC"].Value == "SUPERVEN")
                {
                    ap1.Attributes.Add("style", "display:none");
                    BLOQUE2.Attributes.Add("style", "display:none");
                    admin.Attributes.Add("style", "display:none");
                    proc.Attributes.Add("style", "display:none");
                    reten.Attributes.Add("style", "display:none");
                    list.Attributes.Add("style", "display:none");
                    crea.Attributes.Add("style", "display:none");
                    edic.Attributes.Add("style", "display:none");
                    list2.Attributes.Add("style", "display:none");
                    prod2.Attributes.Add("style", "display:none");
                    edic2.Attributes.Add("style", "display:none");
                    empre.Attributes.Add("style", "display:none");
                    asist.Attributes.Add("style", "display:none");
                    cierr.Attributes.Add("style", "display:none");
                    cirrex.Attributes.Add("style", "display:none");
                    cobremp.Attributes.Add("style", "display:none");
                    cobtom.Attributes.Add("style", "display:none");
                    recons.Attributes.Add("style", "display:none");
                    recdoc.Attributes.Add("style", "display:none");
                    recresp.Attributes.Add("style", "display:none");
             
                    //repcert.Attributes.Add("style", "display:none");
                    //repaseg.Attributes.Add("style", "display:none");
                    repcert2.Attributes.Add("style", "display:none");
                    //repcob.Attributes.Add("style", "display:none");
                    //repex.Attributes.Add("style", "display:none");
                    //repag.Attributes.Add("style", "display:none");
                    //repcobertemp.Attributes.Add("style", "display:none");
                    repcierr.Attributes.Add("style", "display:none");
                    //repus.Attributes.Add("style", "display:none");
                    //repven.Attributes.Add("style", "display:none");
                    aper3.Attributes.Add("style", "display:none");
                    A1.Attributes.Add("style", "display:none");
                    A2.Attributes.Add("style", "display:none");
                    A3.Attributes.Add("style", "display:none");
                    A4.Attributes.Add("style", "display:none");
                    A5.Attributes.Add("style", "display:none");
                    A7.Attributes.Add("style", "display:none");
                    A6.Attributes.Add("style", "display:none");
                    A8.Attributes.Add("style", "display:none");
                    A9.Attributes.Add("style", "display:none");
                    A10.Attributes.Add("style", "display:none");
                    A11.Attributes.Add("style", "display:none");
                    A12.Attributes.Add("style", "display:none");
                    A13.Attributes.Add("style", "display:none");
                    A14.Attributes.Add("style", "display:none");
                    A15.Attributes.Add("style", "display:none");
                    A19.Attributes.Add("style", "display:none");
                    A17.Attributes.Add("style", "display:none");
                    A18.Attributes.Add("style", "display:none");
                    //A16.Attributes.Add("style", "display:none");
                    A20.Attributes.Add("style", "display:none");
                    A24.Attributes.Add("style", "display:none");
                    A25.Attributes.Add("style", "display:none");
                    A22.Attributes.Add("style", "display:none");
                    A21.Attributes.Add("style", "display:none");
                    A26.Attributes.Add("style", "display:none");
                    A27.Attributes.Add("style", "display:none");
                }
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
            
        }
        public void CierreClick(object sender, EventArgs e)
        {
            
            using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
            {

                string saveStaff = "DELETE FROM VENTATEMP";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
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
            if (HttpContext.Current != null)
            {
                int cookieCount = HttpContext.Current.Request.Cookies.Count;
                for (var i = 0; i < cookieCount; i++)
                {
                    var cookie = HttpContext.Current.Request.Cookies[i];
                    if (cookie != null)
                    {
                        var expiredCookie = new HttpCookie(cookie.Name)
                        {
                            Expires = DateTime.Now.AddDays(-1),
                            Domain = cookie.Domain
                        };
                        HttpContext.Current.Response.Cookies.Add(expiredCookie); // overwrite it
                    }
                }

                // clear cookies server side
                HttpContext.Current.Request.Cookies.Clear();
            }
            Response.Redirect("Login.aspx");
        }
        
        public void BuscarClick(object sender, EventArgs e)
        {
            if (busqueda.Value == "")
            {
                Response.Write("<script>alert('LA BUSQUEDA DEBE TENER 3-10 CARACTERES')</script>");
            }
            else if (busqueda.Value.Length > 10)
            {
                Response.Write("<script>alert('LA BUSQUEDA DEBE TENER 3-10 CARACTERES')</script>");
            }
            else
            {
                string buscar = busqueda.Value;
                HttpCookie buscarS = new HttpCookie("paramCedula");
                buscarS.Value = buscar.ToString();
                buscarS.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(buscarS);
                Response.Redirect("Busqueda.aspx");
            }
            
        }
    }
}