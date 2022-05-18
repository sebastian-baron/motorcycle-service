using System.Web.Security;
using System.Web.UI;
using System.Xml;

/// <summary>
/// Summary description for advControl
/// </summary>
namespace MotorcycleService.Base
{
    public class MTControls : UserControl
    {
        #region User
        public User User
        {
            get
            {
                if (Page.User.Identity.IsAuthenticated)
                {
                    int UserID;
                    string UserLogin;


                    XmlDocument doc = new XmlDocument();
                    doc.LoadXml(((FormsIdentity)Page.User.Identity).Ticket.UserData);

                    UserID = int.Parse(doc.DocumentElement.SelectSingleNode("/User/Properties/UserID").InnerText);
                    UserLogin = doc.DocumentElement.SelectSingleNode("/User/Properties/UserLogin").InnerText;

                    return new User(UserID, UserLogin);
                }
                else
                {
                    return new User(0, "");
                }
            }

        }
        #endregion

        #region linkRpl
        public string linkRpl(string s)
        {
            int i = s.Length;
            if (i > 100) i = 100;
            s = s.Substring(0, i);
            return s.Replace("-", "").Replace(" ", "-").Replace(",", "").Replace(":", "").Replace(";", "").Replace(".", "").Replace("/", "-").Replace("\"", "").Replace("&", "").Replace("?", "").Replace("\\", "").Replace(">", "").Replace("<", "").Replace("*", "").Replace("ó", "o").Replace("ą", "a").Replace("ę", "e").Replace("ł", "l").Replace("ś", "s").Replace("ż", "z").Replace("ź", "z").Replace("ć", "c").Replace("ń", "n").Replace("+", "-").Replace("(", "").Replace(")", "").ToLower();
        }

        #endregion
    }
}
