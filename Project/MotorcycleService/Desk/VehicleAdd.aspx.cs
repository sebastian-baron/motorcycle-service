using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

public partial class Desk_AehicleAdd : System.Web.UI.Page
{
    private int _vehicleID = 0;

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

        if (!Page.IsPostBack)
        {
            if (_vehicleID != 0)
            {
                getVehicleToUpdate();
                lbtnVehicleAdd.Text = "edytuj pojazd";
            }
            else
            {
                lbtnVehicleAdd.Text = "dodaj pojazd";
            }
        }


    }

    protected void getVehicleToUpdate()
    {
        SqlConnection sc = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        SqlCommand c = new SqlCommand("MT_Vehicle_GetByID", sc);
        c.Parameters.Add("@VehicleID", SqlDbType.Int).Value = _vehicleID;
        c.CommandType = CommandType.StoredProcedure;
        sc.Open();
        SqlDataReader dr = c.ExecuteReader();
        if (dr.Read())
        {
            txtMarka.Text = dr["Marka"].ToString();
            txtModel.Text = dr["Model"].ToString();
            txtPojemnoscSilnika.Text = dr["PojemnoscSilnika"].ToString();
            txtVIN.Text = dr["VIN"].ToString();
            txtRokProdukcji.Text = dr["RokProdukcji"].ToString();
            txtDataPierwszejRejestracjiWkraju.Text = dr["DataPierwszejRejestracjiWkraju"].ToString();
            txtNumerRejestracyjny.Text = dr["NumerRejestracyjny"].ToString();
            txtOlejSilnikowy.Text = dr["OlejSilnikowy"].ToString();
            txtOlejWprzednimWidelcu.Text = dr["OlejWprzednimWidelcu"].ToString();
            txtOlejPrzekladniowy.Text = dr["OlejPrzekladniowy"].ToString();
            txtPlynHamulcowy.Text = dr["PlynHamulocwy"].ToString();
            txtPlynChlodzacy.Text = dr["PlynChlodzacy"].ToString();
            txtSwieceZaplonowe.Text = dr["SwieceZaplonowe"].ToString();
            txtAkumulator.Text = dr["Akumulator"].ToString();
            txtPlynyEksploatacyjneInne.Text = dr["PlynyEksploatacyjneInne"].ToString();
            txtPasekNapedowy.Text = dr["PasekNapedowy"].ToString();
            txtUkladNapedowyInne.Text = dr["UkladNapedowyInne"].ToString();
            txtKlientImieNazwisko.Text = dr["KlientImieNazwisko"].ToString();
            txtKlientNazwaFirmy.Text = dr["KlientNazwaFirmy"].ToString();
            txtKlientTelefon.Text = dr["KlientTelefon"].ToString();
            txtKlientMiejscowosc.Text = dr["KlientMiejscowosc"].ToString();
            txtKlientUlica.Text = dr["KlientUlica"].ToString();
            txtKlientKodPocztowy.Text = dr["KlientKodPocztowy"].ToString();
        }
        dr.Close();
        sc.Close();
    }

    protected void VehicleAdd_onClick(object sender, EventArgs e)
    {

        SqlConnection scAc = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        SqlCommand cAc = new SqlCommand("MT_Vehicle_Create", scAc);
        cAc.CommandType = CommandType.StoredProcedure;
        cAc.Parameters.Add("@VehicleID", SqlDbType.Int).Value = _vehicleID;
        cAc.Parameters.Add("@Marka", SqlDbType.NVarChar).Value = txtMarka.Text;
        cAc.Parameters.Add("@Model", SqlDbType.NVarChar).Value = txtModel.Text;
        cAc.Parameters.Add("@PojemnoscSilnika", SqlDbType.NVarChar).Value = txtPojemnoscSilnika.Text;
        cAc.Parameters.Add("@VIN", SqlDbType.NVarChar).Value = txtVIN.Text;
        cAc.Parameters.Add("@RokProdukcji", SqlDbType.NVarChar).Value = txtRokProdukcji.Text;
        cAc.Parameters.Add("@DataPierwszejRejestracjiWkraju", SqlDbType.NVarChar).Value = txtDataPierwszejRejestracjiWkraju.Text;
        cAc.Parameters.Add("@NumerRejestracyjny", SqlDbType.NVarChar).Value = txtNumerRejestracyjny.Text;
        cAc.Parameters.Add("@OlejSilnikowy", SqlDbType.NVarChar).Value = txtOlejSilnikowy.Text;
        cAc.Parameters.Add("@OlejWprzednimWidelcu", SqlDbType.NVarChar).Value = txtOlejWprzednimWidelcu.Text;
        cAc.Parameters.Add("@OlejPrzekladniowy", SqlDbType.NVarChar).Value = txtOlejPrzekladniowy.Text;
        cAc.Parameters.Add("@PlynHamulocwy", SqlDbType.NVarChar).Value = txtPlynHamulcowy.Text;
        cAc.Parameters.Add("@PlynChlodzacy", SqlDbType.NVarChar).Value = txtPlynChlodzacy.Text;
        cAc.Parameters.Add("@SwieceZaplonowe", SqlDbType.NVarChar).Value = txtSwieceZaplonowe.Text;
        cAc.Parameters.Add("@Akumulator", SqlDbType.NVarChar).Value = txtAkumulator.Text;
        cAc.Parameters.Add("@PlynyEksploatacyjneInne", SqlDbType.NVarChar).Value = txtPlynyEksploatacyjneInne.Text;
        cAc.Parameters.Add("@PasekNapedowy", SqlDbType.NVarChar).Value = txtPasekNapedowy.Text;
        cAc.Parameters.Add("@UkladNapedowyInne", SqlDbType.NVarChar).Value = txtUkladNapedowyInne.Text;
        cAc.Parameters.Add("@KlientImieNazwisko", SqlDbType.NVarChar).Value = txtKlientImieNazwisko.Text;
        cAc.Parameters.Add("@KlientNazwaFirmy", SqlDbType.NVarChar).Value = txtKlientNazwaFirmy.Text;
        cAc.Parameters.Add("@KlientTelefon", SqlDbType.NVarChar).Value = txtKlientTelefon.Text;
        cAc.Parameters.Add("@KlientMiejscowosc", SqlDbType.NVarChar).Value = txtKlientMiejscowosc.Text;
        cAc.Parameters.Add("@KlientUlica", SqlDbType.NVarChar).Value = txtKlientUlica.Text;
        cAc.Parameters.Add("@KlientKodPocztowy", SqlDbType.NVarChar).Value = txtKlientKodPocztowy.Text;
        cAc.Parameters.Add("@CREDATE", SqlDbType.DateTime).Value = (DateTime.Now);
        cAc.Parameters.Add("@CREUSER", SqlDbType.NVarChar, 50).Value = "AUTO";
        scAc.Open();
        cAc.ExecuteNonQuery();
        scAc.Close();

        Response.Redirect("/Desk/Vehicle.aspx");


    }



}