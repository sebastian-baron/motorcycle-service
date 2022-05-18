using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Web;
using System.Web.Security;
using System.Xml;

public partial class desk_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LoginToDesk_click(object sender, EventArgs e)
    {
        if (txtLogin.Text != "" && txtPassword.Text != "")
        {
            SqlConnection sc = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            SqlCommand c = new SqlCommand("MT_Users_GetByLoginPassword", sc);
            c.Parameters.Add("@Login", SqlDbType.NVarChar).Value = txtLogin.Text;
            c.Parameters.Add("@Password", SqlDbType.NVarChar).Value = FormsAuthentication.HashPasswordForStoringInConfigFile(txtPassword.Text, "SHA1");
            c.CommandType = CommandType.StoredProcedure;
            sc.Open();
            SqlDataReader dr = c.ExecuteReader();
            if (dr.Read())
            {
                string userID = dr["UserID"].ToString();
                string userLogin = dr["Login"].ToString();

                StringWriter stream = new StringWriter();
                XmlTextWriter writer = new XmlTextWriter(stream);

                writer.WriteStartDocument();
                writer.WriteStartElement("User", null);
                writer.WriteStartElement("Properties", null);
                writer.WriteElementString("UserID", userID);
                writer.WriteElementString("UserLogin", userLogin);
                writer.WriteEndElement();
                writer.WriteEndElement();
                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1, "_Mt", DateTime.Now, DateTime.Now.AddMinutes(60), false, stream.ToString());
                string encrypted = FormsAuthentication.Encrypt(ticket);
                HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encrypted);
                cookie.Path = FormsAuthentication.FormsCookiePath;
                Response.Cookies.Add(cookie);

                UpdateLoginLog(userID, "", "SUCCESS", "");

                Response.Redirect("/Desk");
            }
            else
            {
                UpdateLoginLog("", txtLogin.Text, "ERROR", txtPassword.Text);
                lblError.Text = "<div style=\"padding:15px 0;text-align:center;\">Nieprawidłowe dane</div>";
            }

            dr.Close();
            sc.Close();

        }
        else
        {
            lblError.Text = "<div style=\"padding:15px 0;text-align:center;\">Oba pola są wymagane</div>";
        }
    }

    private void UpdateLoginLog(string _UserID, string _UserLogin, string _success, string _bledneHaslo)
    {
        System.Data.SqlClient.SqlConnection sc;
        System.Data.SqlClient.SqlCommand c;
        sc = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        c = new System.Data.SqlClient.SqlCommand("MT_UserActivity_UpdateLog", sc);
        c.CommandType = System.Data.CommandType.StoredProcedure;
        c.Parameters.Add("@UserID", System.Data.SqlDbType.NVarChar).Value = _UserID;
        c.Parameters.Add("@UserLogin", System.Data.SqlDbType.NVarChar).Value = _UserLogin;
        c.Parameters.Add("@BledneHaslo", System.Data.SqlDbType.NVarChar).Value = _bledneHaslo;
        c.Parameters.Add("@Status", System.Data.SqlDbType.NVarChar).Value = _success;
        c.Parameters.Add("@IP", System.Data.SqlDbType.NVarChar).Value = Request.ServerVariables["REMOTE_ADDR"];
        sc.Open();
        c.ExecuteNonQuery();
        sc.Close();
        sc.Dispose();
    }


}