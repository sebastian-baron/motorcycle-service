using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

public partial class Desk_Vehicle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Load_VehicleList();
    }

    private void Load_VehicleList()
    {
        StringBuilder sb = new StringBuilder();
        SqlConnection sc = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        SqlCommand c = new SqlCommand("MT_Vehicle_Get", sc);
        c.CommandType = CommandType.StoredProcedure;
        sc.Open();

        SqlDataReader dr = c.ExecuteReader();
        while (dr.Read())
        {
            sb.Append("<tr class=\"gradeA\">");
            sb.Append("<td>").Append(dr["VIN"].ToString()).Append("</td>");
            sb.Append("<td>").Append(dr["Marka"].ToString()).Append(" ").Append(dr["Model"].ToString()).Append("</td>");
            sb.Append("<td>").Append(dr["NumerRejestracyjny"].ToString()).Append("</td>");
            sb.Append("<td>");
            sb.Append("<a href=\"/Desk/VehicleAdd.aspx?VehicleID=").Append(dr["VehicleID"].ToString()).Append("\" type=\"submit\" class=\"btn btn-primary pull-right btnListVeh\">Edytuj pojazd</a>");
            sb.Append("<a href=\"/Desk/VehicleDetail.aspx?VehicleID=").Append(dr["VehicleID"].ToString()).Append("\" type=\"submit\" class=\"btn btn-info pull-right btnListVeh\">Szczegóły</a>");
            sb.Append("<a href=\"/Desk/VehicleInspectionAdd.aspx?VehicleID=").Append(dr["VehicleID"].ToString()).Append("\" type=\"submit\" class=\"btn btn-success pull-right btnListVeh\">Dodaj nowy przegląd</a>");
            sb.Append("</td>");
            sb.Append("</tr>");
        }
        dr.Close();
        sc.Close();

        litContent.Text = sb.ToString();
    }

}