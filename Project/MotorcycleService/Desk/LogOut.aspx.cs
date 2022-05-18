using System;
using System.Web;
using System.Web.Security;

public partial class Desk_LogOut : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, "");
        Response.Cookies.Add(cookie);


        Response.Redirect("/Desk");
    }
}