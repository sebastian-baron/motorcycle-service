using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

public partial class Desk_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        getVehicleInspectionTop();
    }

    protected void getVehicleInspectionTop()
    {
        StringBuilder sb = new StringBuilder("");
        int i = 0;
        SqlConnection sc = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        SqlCommand c = new SqlCommand("MT_VehicleInspection_GetLast", sc);
        c.CommandType = CommandType.StoredProcedure;
        sc.Open();
        SqlDataReader dr = c.ExecuteReader();
        while (dr.Read())
        {
            i++;
            if (i == 1)
            {
                sb.Append("<li>");
            }
            else
            {
                sb.Append("<li class=\"timeline-inverted\">");
            }

            sb.Append("<div class=\"timeline-badge warning\">");
            sb.Append("<i class=\"fa fa-check\"></i>");
            sb.Append("</div>");
            sb.Append("<div class=\"timeline-panel\">");
            sb.Append("<div class=\"timeline-heading\">");
            sb.Append("<h4 class=\"timeline-title\">");
            if (dr["VIN"].ToString() != "")
            {
                sb.Append("VIN: ").Append(dr["VIN"].ToString()).Append(" - ");
            }
            if (dr["Marka"].ToString() != "")
            {
                sb.Append("Marka: ").Append(dr["Marka"].ToString()).Append(" - ");
            }
            if (dr["Model"].ToString() != "")
            {
                sb.Append("Model: ").Append(dr["Model"].ToString()).Append(" - ");
            }
            sb.Append("<small>").Append(dr["CREDATE"].ToString()).Append("</small>");

            sb.Append("</h4>");
            sb.Append("</div>");
            sb.Append("<div class=\"timeline-body\">");
            sb.Append("<p>");
            sb.Append("<ul>");

            if ((bool)dr["OlejSilnikowyInspekcja"] == true) { sb.Append("<li>Olej silnikowy inspekcja</li>"); }
            if ((bool)dr["OlejSilnikowyWymianaTak"] == true) { sb.Append("<li>Olej silnikowy wymiana TAK</li>"); }
            if ((bool)dr["OlejSilnikowyWymianaNie"] == true) { sb.Append("<li>Olej silnikowy wymiana NIE</li>"); }
            if ((bool)dr["FiltrOlejuInspekcja"] == true) { sb.Append("<li>Filtr oleju inspekcja</li>"); }
            if ((bool)dr["FiltrOlejuWymianaTak"] == true) { sb.Append("<li>Filtr oleju wymiana TAK</li>"); }
            if ((bool)dr["FiltrOlejuWymianaNie"] == true) { sb.Append("<li>Filtr oleju wymiana NIE</li>"); }
            if ((bool)dr["FiltrPowietrzaInspekcja"] == true) { sb.Append("<li>Filtr Powietrza Inspekcja</li>"); }
            if ((bool)dr["FiltrPowietrzaWymianaTak"] == true) { sb.Append("<li>Filtr Powietrza Wymiana TAK</li>"); }
            if ((bool)dr["FiltrPowietrzaWymianaNie"] == true) { sb.Append("<li>Filtr Powietrza Wymiana NIE</li>"); }
            if ((bool)dr["FiltrPaliwaInspekcja"] == true) { sb.Append("<li>Filtr Paliwa Inspekcja</li>"); }
            if ((bool)dr["FiltrPaliwaWymianaTak"] == true) { sb.Append("<li>Filtr Paliwa Wymiana TAK</li>"); }
            if ((bool)dr["FiltrPaliwaWymianaNie"] == true) { sb.Append("<li>Filtr Paliwa Wymiana NIE</li>"); }
            if ((bool)dr["KlockiSzczekiHamulcowePrzodInspekcja"] == true) { sb.Append("<li>Klocki Szczeki Hamulcowe Przod Inspekcja</li>"); }
            if ((bool)dr["KlockiSzczekiHamulcowePrzodWymianaTak"] == true) { sb.Append("<li>Klocki Szczeki Hamulcowe Przod Wymiana TAK</li>"); }
            if ((bool)dr["KlockiSzczekiHamulcowePrzodWymianaNie"] == true) { sb.Append("<li>Klocki Szczeki Hamulcowe Przod Wymiana NIE</li>"); }
            if ((bool)dr["KlockiSzczekiHamulcoweTylInspekcja"] == true) { sb.Append("<li>Klocki Szczeki Hamulcowe Tyl Inspekcja</li>"); }
            if ((bool)dr["KlockiSzczekiHamulcoweTylWymianaTak"] == true) { sb.Append("<li>Klocki Szczeki Hamulcowe Tyl Wymiana TAK</li>"); }
            if ((bool)dr["KlockiSzczekiHamulcoweTyl2WymianaNie"] == true) { sb.Append("<li>Klocki Szczeki Hamulcowe Tyl Wymiana NIE</li>"); }
            if ((bool)dr["PlynHamulcowyInspekcja"] == true) { sb.Append("<li>Plyn Hamulcowy Inspekcja</li>"); }
            if ((bool)dr["PlynHamulcowyWymianaTak"] == true) { sb.Append("<li>Plyn Hamulcowy Wymiana TAK</li>"); }
            if ((bool)dr["PlynHamulcowyWymianaNie"] == true) { sb.Append("<li>Plyn Hamulcowy Wymiana NIE</li>"); }
            if ((bool)dr["SwieceZaplonoweInspekcja"] == true) { sb.Append("<li>Swiece Zaplonowe Inspekcja</li>"); }
            if ((bool)dr["SwieceZaplonoweWymianaTak"] == true) { sb.Append("<li>Swiece Zaplonowe Wymiana TAK</li>"); }
            if ((bool)dr["SwieceZaplonowe2WymianaNie"] == true) { sb.Append("<li>Swiece Zaplonowe Wymiana NIE</li>"); }
            if ((bool)dr["FajkiZaplonoweInspekcja"] == true) { sb.Append("<li>Fajki Zaplonowe Inspekcja</li>"); }
            if ((bool)dr["FajkiZaplonoweWymianaTak"] == true) { sb.Append("<li>Fajki Zaplonowe Wymiana TAK</li>"); }
            if ((bool)dr["FajkiZaplonoweWymianaNie"] == true) { sb.Append("<li>Fajki Zaplonowe Wymiana NIE</li>"); }
            if ((bool)dr["PrzewodyWysNapieciaInspekcja"] == true) { sb.Append("<li>Przewody Wys Napiecia Inspekcja</li>"); }
            if ((bool)dr["PrzewodyWysNapieciaWymianaTak"] == true) { sb.Append("<li>Przewody Wys Napiecia Wymiana TAK</li>"); }
            if ((bool)dr["PrzewodyWysNapieciaWymianaNie"] == true) { sb.Append("<li>Przewody Wys Napiecia Wymiana NIE</li>"); }
            if ((bool)dr["PlynChlodzacyInspekcja"] == true) { sb.Append("<li>Plyn Chlodzacy Inspekcja</li>"); }
            if ((bool)dr["PlynChlodzacyWymianaTak"] == true) { sb.Append("<li>Plyn Chlodzacy Wymiana TAK</li>"); }
            if ((bool)dr["PlynChlodzacyWymianaNie"] == true) { sb.Append("<li>Plyn Chlodzacy Wymiana NIE</li>"); }
            if ((bool)dr["OlejWprzednimZawieszeniuInspekcja"] == true) { sb.Append("<li>Olej w przednim Zawieszeniu Inspekcja</li>"); }
            if ((bool)dr["OlejWprzednimZawieszeniuWymianaTak"] == true) { sb.Append("<li>Olej W przednim Zawieszeniu Wymiana TAK</li>"); }
            if ((bool)dr["OlejWprzednimZawieszeniuWymianaNie"] == true) { sb.Append("<li>Olej W przednim Zawieszeniu Wymiana NIE</li>"); }
            if ((bool)dr["UszczelniaczePrzedniegoZawieszeniaInspekcja"] == true) { sb.Append("<li>Uszczelniacze Przedniego Zawieszenia Inspekcja</li>"); }
            if ((bool)dr["UszczelniaczePrzedniegoZawieszeniaWymianaTak"] == true) { sb.Append("<li>Uszczelniacze Przedniego Zawieszenia Wymiana TAK</li>"); }
            if ((bool)dr["UszczelniaczePrzedniegoZawieszeniaWymianaNie"] == true) { sb.Append("<li>Uszczelniacze Przedniego Zawieszenia Wymiana NIE</li>"); }
            if ((bool)dr["ZestawNapedowyInspekcja"] == true) { sb.Append("<li>Zestaw Napedowy Inspekcja</li>"); }
            if ((bool)dr["ZestawNapedowyWymianaTak"] == true) { sb.Append("<li>Zestaw Napedowy Wymiana TAK</li>"); }
            if ((bool)dr["ZestawNapedowyWymianaNie"] == true) { sb.Append("<li>Zestaw Napedowy Wymiana NIE</li>"); }
            if ((bool)dr["ZaworyInspekcja"] == true) { sb.Append("<li>Zawory Inspekcja</li>"); }
            if ((bool)dr["ZaworyWymianaTak"] == true) { sb.Append("<li>Zawory Wymiana TAK</li>"); }
            if ((bool)dr["ZaworyWymianaNie"] == true) { sb.Append("<li>Zawory Wymiana NIE</li>"); }
            if ((bool)dr["LancuchNapinaczRozrzaduInspekcja"] == true) { sb.Append("<li>Lancuch Napinacz Rozrzadu Inspekcja</li>"); }
            if ((bool)dr["LancuchNapinaczRozrzaduWymianaTak"] == true) { sb.Append("<li>Lancuch Napinacz Rozrzadu Wymiana TAK</li>"); }
            if ((bool)dr["LancuchNapinaczRozrzaduWymianaNie"] == true) { sb.Append("<li>Lancuch Napinacz Rozrzadu Wymiana NIE</li>"); }
            if ((bool)dr["LinkaGazuInspekcja"] == true) { sb.Append("<li>Linka Gazu Inspekcja</li>"); }
            if ((bool)dr["LinkaGazuWymianaTak"] == true) { sb.Append("<li>Linka Gazu Wymiana TAK</li>"); }
            if ((bool)dr["LinkaGazuWymianaNie"] == true) { sb.Append("<li>Linka Gazu Wymiana NIE</li>"); }
            if ((bool)dr["LinkaSpedzeglaInspekcja"] == true) { sb.Append("<li>Linka Spedzegla Inspekcja</li>"); }
            if ((bool)dr["LinkaSpedzeglaWymianaTak"] == true) { sb.Append("<li>Linka Spedzegla Wymiana TAK</li>"); }
            if ((bool)dr["LinkaSpedzeglaWymianaNie"] == true) { sb.Append("<li>Linka Spedzegla Wymiana NIE</li>"); }
            if ((bool)dr["LinkaHamulcaPrzodInspekcja"] == true) { sb.Append("<li>Linka Hamulca Przod Inspekcja</li>"); }
            if ((bool)dr["LinkaHamulcaPrzodWymianaTak"] == true) { sb.Append("<li>Linka Hamulca Przod Wymiana TAK</li>"); }
            if ((bool)dr["LinkaHamulcaPrzodWymianaNie"] == true) { sb.Append("<li>Linka Hamulca Przod Wymiana NIE</li>"); }
            if ((bool)dr["LinkaHamulcaTylInspekcja"] == true) { sb.Append("<li>Linka Hamulca Tyl Inspekcja</li>"); }
            if ((bool)dr["LinkaHamulcaTylWymianaTak"] == true) { sb.Append("<li>Linka Hamulca Tyl Wymiana TAK</li>"); }
            if ((bool)dr["LinkaHamulcaTylWymianaNie"] == true) { sb.Append("<li>Linka Hamulca Tyl Wymiana NIE</li>"); }
            if ((bool)dr["LinkaObrotomierzaInspekcja"] == true) { sb.Append("<li>Linka Obrotomierza Inspekcja</li>"); }
            if ((bool)dr["LinkaObrotomierzaWymianaTak"] == true) { sb.Append("<li>Linka Obrotomierza Wymiana TAK</li>"); }
            if ((bool)dr["LinkaObrotomierzaWymianaNie"] == true) { sb.Append("<li>Linka Obrotomierza Wymiana NIE</li>"); }
            if ((bool)dr["LinkaPredkosciomierzaInspekcja"] == true) { sb.Append("<li>Linka Predkosciomierza Inspekcja</li>"); }
            if ((bool)dr["LinkaPredkosciomierzaWymianaTak"] == true) { sb.Append("<li>Linka Predkosciomierza Wymiana TAK</li>"); }
            if ((bool)dr["LinkaPredkosciomierzaWymianaNie"] == true) { sb.Append("<li>Linka Predkosciomierza Wymiana NIE</li>"); }
            if ((bool)dr["SynchronizacjaInspekcja"] == true) { sb.Append("<li>Synchronizacja Inspekcja</li>"); }
            if ((bool)dr["SynchronizacjaWymianaTak"] == true) { sb.Append("<li>Synchronizacja Wymiana TAK</li>"); }
            if ((bool)dr["SynchronizacjaWymianaNie"] == true) { sb.Append("<li>Synchronizacja Wymiana NIE</li>"); }
            if ((bool)dr["PrzepustnicaInspekcja"] == true) { sb.Append("<li>Przepustnica Inspekcja</li>"); }
            if ((bool)dr["PrzepustnicaWymianaTak"] == true) { sb.Append("<li>Przepustnica Wymiana TAK</li>"); }
            if ((bool)dr["PrzepustnicaWymianaNie"] == true) { sb.Append("<li>Przepustnica Wymiana NIE</li>"); }
            sb.Append("</ul>");
            sb.Append("</p>");
            sb.Append("<p>");
            if (dr["Uwagi"].ToString() != "") { sb.Append("Uwagi:  ").Append(dr["Uwagi"].ToString()); }
            sb.Append("</p>");

            sb.Append("</div>");
            sb.Append("<div class=\"BtnEditVehicle\">");
            sb.Append("<a href=\"/Desk/VehicleDetail.aspx?VehicleID=").Append(dr["VehicleID"].ToString()).Append("\" class=\"btn btn-primary pull-right\">szczegóły</a>");
            sb.Append("</div>");
            sb.Append("</div>");
            sb.Append("</li>");

            if (i == 2)
            {
                i = 0;
            }

        }
        dr.Close();
        sc.Close();

        litVehicleDetail.Text = sb.ToString();

    }

}