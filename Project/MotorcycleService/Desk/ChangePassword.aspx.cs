using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.Security;

public partial class Desk_ChangePassword : MotorcycleService.Base.MTPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void ChangePass(object sender, EventArgs e)
    {
        if (txtPass.Text != "" && txtPass2.Text != "")
        {
            if (txtPass.Text == txtPass2.Text)
            {
                SqlConnection sc = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                SqlCommand c = new SqlCommand("MT_Users_ChangePasswordUpdate", sc);
                c.CommandType = CommandType.StoredProcedure;
                c.Parameters.Add("@UserID", SqlDbType.Int).Value = User.UserID;
                c.Parameters.Add("@Login", SqlDbType.NVarChar).Value = User.UserLogin;
                c.Parameters.Add("@Password", SqlDbType.NVarChar).Value = FormsAuthentication.HashPasswordForStoringInConfigFile(txtPass.Text, "SHA1");
                sc.Open();
                c.ExecuteNonQuery();
                sc.Close();

                pnlChangePass.Visible = false;
                lblError.Text = "<div style=\"padding:15px 0;text-align:center;\">Hasła zostały zmienione.</div>";
            }
            else
            {
                lblError.Text = "<div style=\"padding:15px 0;text-align:center;\">Podałeś różne hasła</div>";
            }
        }
        else
        {
            lblError.Text = "<div style=\"padding:15px 0;text-align:center;\">Musisz podać nowe hasło</div>";
        }
    }

}