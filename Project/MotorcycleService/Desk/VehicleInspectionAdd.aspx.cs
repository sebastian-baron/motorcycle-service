using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web.UI;

public partial class Desk_VehicleInspection : System.Web.UI.Page
{
    protected int _vehicleID = 0;
    protected int _inspectionID = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            _vehicleID = int.Parse(Request.QueryString["VehicleID"].ToString());

        }
        catch
        {
            _vehicleID = 0;
        }
        try
        {
            _inspectionID = int.Parse(Request.QueryString["InspectionID"].ToString());
        }
        catch
        {
            _inspectionID = 0;
        }

        if (!Page.IsPostBack)
        {
            if (_inspectionID != 0)
            {
                getInspectionToUpdate();
                lbtnVehicleInspectionAdd.Text = "edytuj przegląd techniczny";
            }
            else
            {
                lbtnVehicleInspectionAdd.Text = "dodaj przegląd techniczny";
            }

            getVehicleGet();
        }
        
    }

    protected void getVehicleGet()
    {
        StringBuilder sb = new StringBuilder("");

        SqlConnection sc = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        SqlCommand c = new SqlCommand("MT_Vehicle_GetByID", sc);
        c.Parameters.Add("@VehicleID", SqlDbType.Int).Value = _vehicleID;
        c.CommandType = CommandType.StoredProcedure;
        sc.Open();
        SqlDataReader dr = c.ExecuteReader();
        if (dr.Read())
        {
            if (dr["VIN"].ToString() != "")
            {
                sb.Append(" - VIN: ");
                sb.Append(dr["VIN"].ToString());
            }

            if (dr["Marka"].ToString() != "")
            {
                sb.Append(" - ");
                sb.Append(dr["Marka"].ToString());
            }

            if (dr["Model"].ToString() != "")
            {
                sb.Append(" - ");
                sb.Append(dr["Model"].ToString());
            }

            

        }
        dr.Close();
        sc.Close();

        litVehicleTitle.Text = sb.ToString();

    }

    protected void VehicleInspectionAdd_onClick(object sender, EventArgs e)
    {

        SqlConnection scAc = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        SqlCommand cAc = new SqlCommand("MT_VehicleInspectionAdd_Create", scAc);
        cAc.CommandType = CommandType.StoredProcedure;
        cAc.Parameters.Add("@InspectionID", SqlDbType.Int).Value = 10;
        cAc.Parameters.Add("@VehicleID", SqlDbType.Int).Value = _vehicleID;
        cAc.Parameters.Add("@OlejSilnikowyInspekcja", SqlDbType.Bit).Value = (bool)OlejSilnikowyInspekcja.Checked;
        cAc.Parameters.Add("@OlejSilnikowyWymianaTak", SqlDbType.Bit).Value = (bool)OlejSilnikowyWymianaTak.Checked;
        cAc.Parameters.Add("@OlejSilnikowyWymianaNie", SqlDbType.Bit).Value = (bool)OlejSilnikowyWymianaNie.Checked;
        cAc.Parameters.Add("@FiltrOlejuInspekcja", SqlDbType.Bit).Value = (bool)FiltrOlejuInspekcja.Checked;
        cAc.Parameters.Add("@FiltrOlejuWymianaTak", SqlDbType.Bit).Value = (bool)FiltrOlejuWymianaTak.Checked;
        cAc.Parameters.Add("@FiltrOlejuWymianaNie", SqlDbType.Bit).Value = (bool)FiltrOlejuWymianaNie.Checked;
        cAc.Parameters.Add("@FiltrPowietrzaInspekcja", SqlDbType.Bit).Value = (bool)FiltrPowietrzaInspekcja.Checked;
        cAc.Parameters.Add("@FiltrPowietrzaWymianaTak", SqlDbType.Bit).Value = (bool)FiltrPowietrzaWymianaTak.Checked;
        cAc.Parameters.Add("@FiltrPowietrzaWymianaNie", SqlDbType.Bit).Value = (bool)FiltrPowietrzaWymianaNie.Checked;
        cAc.Parameters.Add("@FiltrPaliwaInspekcja", SqlDbType.Bit).Value = (bool)FiltrPaliwaInspekcja.Checked;
        cAc.Parameters.Add("@FiltrPaliwaWymianaTak", SqlDbType.Bit).Value = (bool)FiltrPaliwaWymianaTak.Checked;
        cAc.Parameters.Add("@FiltrPaliwaWymianaNie", SqlDbType.Bit).Value = (bool)FiltrPaliwaWymianaNie.Checked;
        cAc.Parameters.Add("@KlockiSzczekiHamulcowePrzodInspekcja", SqlDbType.Bit).Value = (bool)KlockiSzczekiHamulcowePrzodInspekcja.Checked;
        cAc.Parameters.Add("@KlockiSzczekiHamulcowePrzodWymianaTak", SqlDbType.Bit).Value = (bool)KlockiSzczekiHamulcowePrzodWymianaTak.Checked;
        cAc.Parameters.Add("@KlockiSzczekiHamulcowePrzodWymianaNie", SqlDbType.Bit).Value = (bool)KlockiSzczekiHamulcowePrzodWymianaNie.Checked;
        cAc.Parameters.Add("@KlockiSzczekiHamulcoweTylInspekcja", SqlDbType.Bit).Value = (bool)KlockiSzczekiHamulcoweTylInspekcja.Checked;
        cAc.Parameters.Add("@KlockiSzczekiHamulcoweTylWymianaTak", SqlDbType.Bit).Value = (bool)KlockiSzczekiHamulcoweTylWymianaTak.Checked;
        cAc.Parameters.Add("@KlockiSzczekiHamulcoweTyl2WymianaNie", SqlDbType.Bit).Value = (bool)KlockiSzczekiHamulcoweTyl2WymianaNie.Checked;
        cAc.Parameters.Add("@PlynHamulcowyInspekcja", SqlDbType.Bit).Value = (bool)PlynHamulcowyInspekcja.Checked;
        cAc.Parameters.Add("@PlynHamulcowyWymianaTak", SqlDbType.Bit).Value = (bool)PlynHamulcowyWymianaTak.Checked;
        cAc.Parameters.Add("@PlynHamulcowyWymianaNie", SqlDbType.Bit).Value = (bool)PlynHamulcowyWymianaNie.Checked;
        cAc.Parameters.Add("@SwieceZaplonoweInspekcja", SqlDbType.Bit).Value = (bool)SwieceZaplonoweInspekcja.Checked;
        cAc.Parameters.Add("@SwieceZaplonoweWymianaTak", SqlDbType.Bit).Value = (bool)SwieceZaplonoweWymianaTak.Checked;
        cAc.Parameters.Add("@SwieceZaplonowe2WymianaNie", SqlDbType.Bit).Value = (bool)SwieceZaplonowe2WymianaNie.Checked;
        cAc.Parameters.Add("@FajkiZaplonoweInspekcja", SqlDbType.Bit).Value = (bool)FajkiZaplonoweInspekcja.Checked;
        cAc.Parameters.Add("@FajkiZaplonoweWymianaTak", SqlDbType.Bit).Value = (bool)FajkiZaplonoweWymianaTak.Checked;
        cAc.Parameters.Add("@FajkiZaplonoweWymianaNie", SqlDbType.Bit).Value = (bool)FajkiZaplonoweWymianaNie.Checked;
        cAc.Parameters.Add("@PrzewodyWysNapieciaInspekcja", SqlDbType.Bit).Value = (bool)PrzewodyWysNapieciaInspekcja.Checked;
        cAc.Parameters.Add("@PrzewodyWysNapieciaWymianaTak", SqlDbType.Bit).Value = (bool)PrzewodyWysNapieciaWymianaTak.Checked;
        cAc.Parameters.Add("@PrzewodyWysNapieciaWymianaNie", SqlDbType.Bit).Value = (bool)PrzewodyWysNapieciaWymianaNie.Checked;
        cAc.Parameters.Add("@PlynChlodzacyInspekcja", SqlDbType.Bit).Value = (bool)PlynChlodzacyInspekcja.Checked;
        cAc.Parameters.Add("@PlynChlodzacyWymianaTak", SqlDbType.Bit).Value = (bool)PlynChlodzacyWymianaTak.Checked;
        cAc.Parameters.Add("@PlynChlodzacyWymianaNie", SqlDbType.Bit).Value = (bool)PlynChlodzacyWymianaNie.Checked;
        cAc.Parameters.Add("@OlejWprzednimZawieszeniuInspekcja", SqlDbType.Bit).Value = (bool)OlejWprzednimZawieszeniuInspekcja.Checked;
        cAc.Parameters.Add("@OlejWprzednimZawieszeniuWymianaTak", SqlDbType.Bit).Value = (bool)OlejWprzednimZawieszeniuWymianaTak.Checked;
        cAc.Parameters.Add("@OlejWprzednimZawieszeniuWymianaNie", SqlDbType.Bit).Value = (bool)OlejWprzednimZawieszeniuWymianaNie.Checked;
        cAc.Parameters.Add("@UszczelniaczePrzedniegoZawieszeniaInspekcja", SqlDbType.Bit).Value = (bool)UszczelniaczePrzedniegoZawieszeniaInspekcja.Checked;
        cAc.Parameters.Add("@UszczelniaczePrzedniegoZawieszeniaWymianaTak", SqlDbType.Bit).Value = (bool)UszczelniaczePrzedniegoZawieszeniaWymianaTak.Checked;
        cAc.Parameters.Add("@UszczelniaczePrzedniegoZawieszeniaWymianaNie", SqlDbType.Bit).Value = (bool)UszczelniaczePrzedniegoZawieszeniaWymianaNie.Checked;
        cAc.Parameters.Add("@ZestawNapedowyInspekcja", SqlDbType.Bit).Value = (bool)ZestawNapedowyInspekcja.Checked;
        cAc.Parameters.Add("@ZestawNapedowyWymianaTak", SqlDbType.Bit).Value = (bool)ZestawNapedowyWymianaTak.Checked;
        cAc.Parameters.Add("@ZestawNapedowyWymianaNie", SqlDbType.Bit).Value = (bool)ZestawNapedowyWymianaNie.Checked;
        cAc.Parameters.Add("@ZaworyInspekcja", SqlDbType.Bit).Value = (bool)ZaworyInspekcja.Checked;
        cAc.Parameters.Add("@ZaworyWymianaTak", SqlDbType.Bit).Value = (bool)ZaworyWymianaTak.Checked;
        cAc.Parameters.Add("@ZaworyWymianaNie", SqlDbType.Bit).Value = (bool)ZaworyWymianaNie.Checked;
        cAc.Parameters.Add("@LancuchNapinaczRozrzaduInspekcja", SqlDbType.Bit).Value = (bool)LancuchNapinaczRozrzaduInspekcja.Checked;
        cAc.Parameters.Add("@LancuchNapinaczRozrzaduWymianaTak", SqlDbType.Bit).Value = (bool)LancuchNapinaczRozrzaduWymianaTak.Checked;
        cAc.Parameters.Add("@LancuchNapinaczRozrzaduWymianaNie", SqlDbType.Bit).Value = (bool)LancuchNapinaczRozrzaduWymianaNie.Checked;
        cAc.Parameters.Add("@LinkaGazuInspekcja", SqlDbType.Bit).Value = (bool)LinkaGazuInspekcja.Checked;
        cAc.Parameters.Add("@LinkaGazuWymianaTak", SqlDbType.Bit).Value = (bool)LinkaGazuWymianaTak.Checked;
        cAc.Parameters.Add("@LinkaGazuWymianaNie", SqlDbType.Bit).Value = (bool)LinkaGazuWymianaNie.Checked;
        cAc.Parameters.Add("@LinkaSpedzeglaInspekcja", SqlDbType.Bit).Value = (bool)LinkaSpedzeglaInspekcja.Checked;
        cAc.Parameters.Add("@LinkaSpedzeglaWymianaTak", SqlDbType.Bit).Value = (bool)LinkaSpedzeglaWymianaTak.Checked;
        cAc.Parameters.Add("@LinkaSpedzeglaWymianaNie", SqlDbType.Bit).Value = (bool)LinkaSpedzeglaWymianaNie.Checked;
        cAc.Parameters.Add("@LinkaHamulcaPrzodInspekcja", SqlDbType.Bit).Value = (bool)LinkaHamulcaPrzodInspekcja.Checked;
        cAc.Parameters.Add("@LinkaHamulcaPrzodWymianaTak", SqlDbType.Bit).Value = (bool)LinkaHamulcaPrzodWymianaTak.Checked;
        cAc.Parameters.Add("@LinkaHamulcaPrzodWymianaNie", SqlDbType.Bit).Value = (bool)LinkaHamulcaPrzodWymianaNie.Checked;
        cAc.Parameters.Add("@LinkaHamulcaTylInspekcja", SqlDbType.Bit).Value = (bool)LinkaHamulcaTylInspekcja.Checked;
        cAc.Parameters.Add("@LinkaHamulcaTylWymianaTak", SqlDbType.Bit).Value = (bool)LinkaHamulcaTylWymianaTak.Checked;
        cAc.Parameters.Add("@LinkaHamulcaTylWymianaNie", SqlDbType.Bit).Value = (bool)LinkaHamulcaTylWymianaNie.Checked;
        cAc.Parameters.Add("@LinkaObrotomierzaInspekcja", SqlDbType.Bit).Value = (bool)LinkaObrotomierzaInspekcja.Checked;
        cAc.Parameters.Add("@LinkaObrotomierzaWymianaTak", SqlDbType.Bit).Value = (bool)LinkaObrotomierzaWymianaTak.Checked;
        cAc.Parameters.Add("@LinkaObrotomierzaWymianaNie", SqlDbType.Bit).Value = (bool)LinkaObrotomierzaWymianaNie.Checked;
        cAc.Parameters.Add("@LinkaPredkosciomierzaInspekcja", SqlDbType.Bit).Value = (bool)LinkaPredkosciomierzaInspekcja.Checked;
        cAc.Parameters.Add("@LinkaPredkosciomierzaWymianaTak", SqlDbType.Bit).Value = (bool)LinkaPredkosciomierzaWymianaTak.Checked;
        cAc.Parameters.Add("@LinkaPredkosciomierzaWymianaNie", SqlDbType.Bit).Value = (bool)LinkaPredkosciomierzaWymianaNie.Checked;
        cAc.Parameters.Add("@SynchronizacjaInspekcja", SqlDbType.Bit).Value = (bool)SynchronizacjaInspekcja.Checked;
        cAc.Parameters.Add("@SynchronizacjaWymianaTak", SqlDbType.Bit).Value = (bool)SynchronizacjaWymianaTak.Checked;
        cAc.Parameters.Add("@SynchronizacjaWymianaNie", SqlDbType.Bit).Value = (bool)SynchronizacjaWymianaNie.Checked;
        cAc.Parameters.Add("@PrzepustnicaInspekcja", SqlDbType.Bit).Value = (bool)PrzepustnicaInspekcja.Checked;
        cAc.Parameters.Add("@PrzepustnicaWymianaTak", SqlDbType.Bit).Value = (bool)PrzepustnicaWymianaTak.Checked;
        cAc.Parameters.Add("@PrzepustnicaWymianaNie", SqlDbType.Bit).Value = (bool)PrzepustnicaWymianaNie.Checked;
        cAc.Parameters.Add("@Uwagi", SqlDbType.NVarChar).Value = Uwagi.Text;
        cAc.Parameters.Add("@CREDATE", SqlDbType.DateTime).Value = (DateTime.Now);
        cAc.Parameters.Add("@CREUSER", SqlDbType.NVarChar, 50).Value = "AUTO";
        scAc.Open();
        cAc.ExecuteNonQuery();
        scAc.Close();

        Response.Redirect("/Desk/VehicleDetail.aspx?VehicleID=" + _vehicleID);

    }

    protected void getInspectionToUpdate()
    {
        SqlConnection sc = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        SqlCommand c = new SqlCommand("MT_VehicleInspection_GetByID", sc);
        c.Parameters.Add("@VehicleID", SqlDbType.Int).Value = _vehicleID;
        c.Parameters.Add("@InspectionID", SqlDbType.Int).Value = _inspectionID;
        c.CommandType = CommandType.StoredProcedure;
        sc.Open();
        SqlDataReader dr = c.ExecuteReader();
        if (dr.Read())
        {
            OlejSilnikowyInspekcja.Checked = (bool)dr["OlejSilnikowyInspekcja"];
            OlejSilnikowyWymianaTak.Checked = (bool)dr["OlejSilnikowyWymianaTak"];
            OlejSilnikowyWymianaNie.Checked = (bool)dr["OlejSilnikowyWymianaNie"];
            FiltrOlejuInspekcja.Checked = (bool)dr["FiltrOlejuInspekcja"];
            FiltrOlejuWymianaTak.Checked = (bool)dr["FiltrOlejuWymianaTak"];
            FiltrOlejuWymianaNie.Checked = (bool)dr["FiltrOlejuWymianaNie"];
            FiltrPowietrzaInspekcja.Checked = (bool)dr["FiltrPowietrzaInspekcja"];
            FiltrPowietrzaWymianaTak.Checked = (bool)dr["FiltrPowietrzaWymianaTak"];
            FiltrPowietrzaWymianaNie.Checked = (bool)dr["FiltrPowietrzaWymianaNie"];
            FiltrPaliwaInspekcja.Checked = (bool)dr["FiltrPaliwaInspekcja"];
            FiltrPaliwaWymianaTak.Checked = (bool)dr["FiltrPaliwaWymianaTak"];
            FiltrPaliwaWymianaNie.Checked = (bool)dr["FiltrPaliwaWymianaNie"];
            KlockiSzczekiHamulcowePrzodInspekcja.Checked = (bool)dr["KlockiSzczekiHamulcowePrzodInspekcja"];
            KlockiSzczekiHamulcowePrzodWymianaTak.Checked = (bool)dr["KlockiSzczekiHamulcowePrzodWymianaTak"];
            KlockiSzczekiHamulcowePrzodWymianaNie.Checked = (bool)dr["KlockiSzczekiHamulcowePrzodWymianaNie"];
            KlockiSzczekiHamulcoweTylInspekcja.Checked = (bool)dr["KlockiSzczekiHamulcoweTylInspekcja"];
            KlockiSzczekiHamulcoweTylWymianaTak.Checked = (bool)dr["KlockiSzczekiHamulcoweTylWymianaTak"];
            KlockiSzczekiHamulcoweTyl2WymianaNie.Checked = (bool)dr["KlockiSzczekiHamulcoweTyl2WymianaNie"];
            PlynHamulcowyInspekcja.Checked = (bool)dr["PlynHamulcowyInspekcja"];
            PlynHamulcowyWymianaTak.Checked = (bool)dr["PlynHamulcowyWymianaTak"];
            PlynHamulcowyWymianaNie.Checked = (bool)dr["PlynHamulcowyWymianaNie"];
            SwieceZaplonoweInspekcja.Checked = (bool)dr["SwieceZaplonoweInspekcja"];
            SwieceZaplonoweWymianaTak.Checked = (bool)dr["SwieceZaplonoweWymianaTak"];
            SwieceZaplonowe2WymianaNie.Checked = (bool)dr["SwieceZaplonowe2WymianaNie"];
            FajkiZaplonoweInspekcja.Checked = (bool)dr["FajkiZaplonoweInspekcja"];
            FajkiZaplonoweWymianaTak.Checked = (bool)dr["FajkiZaplonoweWymianaTak"];
            FajkiZaplonoweWymianaNie.Checked = (bool)dr["FajkiZaplonoweWymianaNie"];
            PrzewodyWysNapieciaInspekcja.Checked = (bool)dr["PrzewodyWysNapieciaInspekcja"];
            PrzewodyWysNapieciaWymianaTak.Checked = (bool)dr["PrzewodyWysNapieciaWymianaTak"];
            PrzewodyWysNapieciaWymianaNie.Checked = (bool)dr["PrzewodyWysNapieciaWymianaNie"];
            PlynChlodzacyInspekcja.Checked = (bool)dr["PlynChlodzacyInspekcja"];
            PlynChlodzacyWymianaTak.Checked = (bool)dr["PlynChlodzacyWymianaTak"];
            PlynChlodzacyWymianaNie.Checked = (bool)dr["PlynChlodzacyWymianaNie"];
            OlejWprzednimZawieszeniuInspekcja.Checked = (bool)dr["OlejWprzednimZawieszeniuInspekcja"];
            OlejWprzednimZawieszeniuWymianaTak.Checked = (bool)dr["OlejWprzednimZawieszeniuWymianaTak"];
            OlejWprzednimZawieszeniuWymianaNie.Checked = (bool)dr["OlejWprzednimZawieszeniuWymianaNie"];
            UszczelniaczePrzedniegoZawieszeniaInspekcja.Checked = (bool)dr["UszczelniaczePrzedniegoZawieszeniaInspekcja"];
            UszczelniaczePrzedniegoZawieszeniaWymianaTak.Checked = (bool)dr["UszczelniaczePrzedniegoZawieszeniaWymianaTak"];
            UszczelniaczePrzedniegoZawieszeniaWymianaNie.Checked = (bool)dr["UszczelniaczePrzedniegoZawieszeniaWymianaNie"];
            ZestawNapedowyInspekcja.Checked = (bool)dr["ZestawNapedowyInspekcja"];
            ZestawNapedowyWymianaTak.Checked = (bool)dr["ZestawNapedowyWymianaTak"];
            ZestawNapedowyWymianaNie.Checked = (bool)dr["ZestawNapedowyWymianaNie"];
            ZaworyInspekcja.Checked = (bool)dr["ZaworyInspekcja"];
            ZaworyWymianaTak.Checked = (bool)dr["ZaworyWymianaTak"];
            ZaworyWymianaNie.Checked = (bool)dr["ZaworyWymianaNie"];
            LancuchNapinaczRozrzaduInspekcja.Checked = (bool)dr["LancuchNapinaczRozrzaduInspekcja"];
            LancuchNapinaczRozrzaduWymianaTak.Checked = (bool)dr["LancuchNapinaczRozrzaduWymianaTak"];
            LancuchNapinaczRozrzaduWymianaNie.Checked = (bool)dr["LancuchNapinaczRozrzaduWymianaNie"];
            LinkaGazuInspekcja.Checked = (bool)dr["LinkaGazuInspekcja"];
            LinkaGazuWymianaTak.Checked = (bool)dr["LinkaGazuWymianaTak"];
            LinkaGazuWymianaNie.Checked = (bool)dr["LinkaGazuWymianaNie"];
            LinkaSpedzeglaInspekcja.Checked = (bool)dr["LinkaSpedzeglaInspekcja"];
            LinkaSpedzeglaWymianaTak.Checked = (bool)dr["LinkaSpedzeglaWymianaTak"];
            LinkaSpedzeglaWymianaNie.Checked = (bool)dr["LinkaSpedzeglaWymianaNie"];
            LinkaHamulcaPrzodInspekcja.Checked = (bool)dr["LinkaHamulcaPrzodInspekcja"];
            LinkaHamulcaPrzodWymianaTak.Checked = (bool)dr["LinkaHamulcaPrzodWymianaTak"];
            LinkaHamulcaPrzodWymianaNie.Checked = (bool)dr["LinkaHamulcaPrzodWymianaNie"];
            LinkaHamulcaTylInspekcja.Checked = (bool)dr["LinkaHamulcaTylInspekcja"];
            LinkaHamulcaTylWymianaTak.Checked = (bool)dr["LinkaHamulcaTylWymianaTak"];
            LinkaHamulcaTylWymianaNie.Checked = (bool)dr["LinkaHamulcaTylWymianaNie"];
            LinkaObrotomierzaInspekcja.Checked = (bool)dr["LinkaObrotomierzaInspekcja"];
            LinkaObrotomierzaWymianaTak.Checked = (bool)dr["LinkaObrotomierzaWymianaTak"];
            LinkaObrotomierzaWymianaNie.Checked = (bool)dr["LinkaObrotomierzaWymianaNie"];
            LinkaPredkosciomierzaInspekcja.Checked = (bool)dr["LinkaPredkosciomierzaInspekcja"];
            LinkaPredkosciomierzaWymianaTak.Checked = (bool)dr["LinkaPredkosciomierzaWymianaTak"];
            LinkaPredkosciomierzaWymianaNie.Checked = (bool)dr["LinkaPredkosciomierzaWymianaNie"];
            SynchronizacjaInspekcja.Checked = (bool)dr["SynchronizacjaInspekcja"];
            SynchronizacjaWymianaTak.Checked = (bool)dr["SynchronizacjaWymianaTak"];
            SynchronizacjaWymianaNie.Checked = (bool)dr["SynchronizacjaWymianaNie"];
            PrzepustnicaInspekcja.Checked = (bool)dr["PrzepustnicaInspekcja"];
            PrzepustnicaWymianaTak.Checked = (bool)dr["PrzepustnicaWymianaTak"];
            PrzepustnicaWymianaNie.Checked = (bool)dr["PrzepustnicaWymianaNie"];
            Uwagi.Text = dr["Uwagi"].ToString();

        }
        dr.Close();
        sc.Close();
    }



}