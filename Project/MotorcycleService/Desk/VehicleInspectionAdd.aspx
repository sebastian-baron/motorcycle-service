<%@ Page Title="" Language="C#" MasterPageFile="~/Desk/MasterPageDesk.master" AutoEventWireup="true" CodeFile="VehicleInspectionAdd.aspx.cs" Inherits="Desk_VehicleInspection" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphTitle" runat="Server">
    Przegląd techniczny <asp:Literal ID="litVehicleTitle" runat="server"></asp:Literal>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="Server">
    <div class="row">
        <div class="col-lg-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                    Lista pojazdów
                </div>
                <div class="panel-body">
                    <div class="dataTable_wrapper">
                        <div class="table-responsive">
                            <table class="table table-striped table-bordered table-hover text-center tableVehicleInspectionAdd">
                                <thead>
                                    <tr class="gradeA">
                                        <th width="30"></th>
                                        <th></th>
                                        <th></th>
                                        <th colspan="2">Wymiana</th>
                                    </tr>
                                    <tr>
                                        <th>L.p.</th>
                                        <th></th>
                                        <th>Inspekcja</th>
                                        <th>Tak</th>
                                        <th>Nie</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>1.</td>
                                        <td>Olej silnikowy</td>
                                        <td>
                                            <label for="ctl00_cphContent_OlejSilnikowyInspekcja">
                                                <asp:CheckBox ID="OlejSilnikowyInspekcja" runat="server" /></label></td>
                                        <td>
                                            <label for="ctl00_cphContent_OlejSilnikowyWymianaTak">
                                                <asp:CheckBox ID="OlejSilnikowyWymianaTak" runat="server" /></label></td>
                                        <td>
                                            <label for="ctl00_cphContent_OlejSilnikowyWymianaNie">
                                                <asp:CheckBox ID="OlejSilnikowyWymianaNie" runat="server" /></label></td>
                                    </tr>
                                    <tr>
                                        <td>2.</td>
                                        <td>Filtr oleju</td>
                                        <td>
                                            <label for="ctl00_cphContent_FiltrOlejuInspekcja">
                                                <asp:CheckBox ID="FiltrOlejuInspekcja" runat="server" /></label></td>
                                        <td>
                                            <label for="ctl00_cphContent_FiltrOlejuWymianaTak">
                                                <asp:CheckBox ID="FiltrOlejuWymianaTak" runat="server" /></label></td>
                                        <td>
                                            <label for="ctl00_cphContent_FiltrOlejuWymianaNie">
                                                <asp:CheckBox ID="FiltrOlejuWymianaNie" runat="server" /></label></td>
                                    </tr>
                                    <tr>
                                        <td>3.</td>
                                        <td>Filtr powietrza</td>
                                        <td>
                                            <label for="ctl00_cphContent_FiltrPowietrzaInspekcja">
                                                <asp:CheckBox ID="FiltrPowietrzaInspekcja" runat="server" /></label></td>
                                        <td>
                                            <label for="ctl00_cphContent_FiltrPowietrzaWymianaTak">
                                                <asp:CheckBox ID="FiltrPowietrzaWymianaTak" runat="server" /></label></td>
                                        <td>
                                            <label for="ctl00_cphContent_FiltrPowietrzaWymianaNie">
                                                <asp:CheckBox ID="FiltrPowietrzaWymianaNie" runat="server" /></label></td>
                                    </tr>
                                    <tr>
                                        <td>4.</td>
                                        <td>Filtr paliwa</td>
                                        <td>
                                            <label for="ctl00_cphContent_FiltrPaliwaInspekcja">
                                                <asp:CheckBox ID="FiltrPaliwaInspekcja" runat="server" /></label></td>
                                        <td>
                                            <label for="ctl00_cphContent_FiltrPaliwaWymianaTak">
                                                <asp:CheckBox ID="FiltrPaliwaWymianaTak" runat="server" /></label></td>
                                        <td>
                                            <label for="ctl00_cphContent_FiltrPaliwaWymianaNie">
                                                <asp:CheckBox ID="FiltrPaliwaWymianaNie" runat="server" /></label></td>
                                    </tr>
                                    <tr>
                                        <td>5.</td>
                                        <td>Klocki/szczęki hamulcowe (przód)</td>
                                        <td>
                                            <label for="ctl00_cphContent_KlockiSzczekiHamulcowePrzodInspekcja">
                                                <asp:CheckBox ID="KlockiSzczekiHamulcowePrzodInspekcja" runat="server" /></label></td>
                                        <td>
                                            <label for="ctl00_cphContent_KlockiSzczekiHamulcowePrzodWymianaTak">
                                                <asp:CheckBox ID="KlockiSzczekiHamulcowePrzodWymianaTak" runat="server" /></label></td>
                                        <td>
                                            <label for="ctl00_cphContent_KlockiSzczekiHamulcowePrzodWymianaNie">
                                                <asp:CheckBox ID="KlockiSzczekiHamulcowePrzodWymianaNie" runat="server" /></label></td>
                                    </tr>
                                    <tr>
                                        <td>6.</td>
                                        <td>Klocki/szczęki hamulcowe (tył)</td>
                                        <td>
                                            <label for="ctl00_cphContent_KlockiSzczekiHamulcoweTylInspekcja">
                                                <asp:CheckBox ID="KlockiSzczekiHamulcoweTylInspekcja" runat="server" /></label></td>
                                        <td>
                                            <label for="ctl00_cphContent_KlockiSzczekiHamulcoweTylWymianaTak">
                                                <asp:CheckBox ID="KlockiSzczekiHamulcoweTylWymianaTak" runat="server" /></label></td>
                                        <td>
                                            <label for="ctl00_cphContent_KlockiSzczekiHamulcoweTyl2WymianaNie">
                                                <asp:CheckBox ID="KlockiSzczekiHamulcoweTyl2WymianaNie" runat="server" /></label></td>
                                    </tr>
                                    <tr>
                                        <td>7.</td>
                                        <td>Płyn hamulcowy</td>
                                        <td>
                                            <label for="ctl00_cphContent_PlynHamulcowyInspekcja">
                                                <asp:CheckBox ID="PlynHamulcowyInspekcja" runat="server" /></label></td>
                                        <td>
                                            <label for="ctl00_cphContent_PlynHamulcowyWymianaTak">
                                                <asp:CheckBox ID="PlynHamulcowyWymianaTak" runat="server" /></label></td>
                                        <td>
                                            <label for="ctl00_cphContent_PlynHamulcowyWymianaNie">
                                                <asp:CheckBox ID="PlynHamulcowyWymianaNie" runat="server" /></label></td>
                                    </tr>
                                    <tr>
                                        <td>8.</td>
                                        <td>Świece zapłonowe</td>
                                        <td>
                                            <label for="ctl00_cphContent_SwieceZaplonoweInspekcja">
                                                <asp:CheckBox ID="SwieceZaplonoweInspekcja" runat="server" /></label></td>
                                        <td>
                                            <label for="ctl00_cphContent_SwieceZaplonoweWymianaTak">
                                                <asp:CheckBox ID="SwieceZaplonoweWymianaTak" runat="server" /></label></td>
                                        <td>
                                            <label for="ctl00_cphContent_SwieceZaplonowe2WymianaNie">
                                                <asp:CheckBox ID="SwieceZaplonowe2WymianaNie" runat="server" /></label></td>
                                    </tr>
                                    <tr>
                                        <td>9.</td>
                                        <td>Fajki zapłonowe</td>
                                        <td>
                                            <label for="ctl00_cphContent_FajkiZaplonoweInspekcja">
                                                <asp:CheckBox ID="FajkiZaplonoweInspekcja" runat="server" /></label></td>
                                        <td>
                                            <label for="ctl00_cphContent_FajkiZaplonoweWymianaTak">
                                                <asp:CheckBox ID="FajkiZaplonoweWymianaTak" runat="server" /></label></td>
                                        <td>
                                            <label for="ctl00_cphContent_FajkiZaplonoweWymianaNie">
                                                <asp:CheckBox ID="FajkiZaplonoweWymianaNie" runat="server" /></label></td>
                                    </tr>
                                    <tr>
                                        <td>10.</td>
                                        <td>Przewody wys. napięcia</td>
                                        <td>
                                            <label for="ctl00_cphContent_PrzewodyWysNapieciaInspekcja">
                                                <asp:CheckBox ID="PrzewodyWysNapieciaInspekcja" runat="server" /></label></td>
                                        <td>
                                            <label for="ctl00_cphContent_PrzewodyWysNapieciaWymianaTak">
                                                <asp:CheckBox ID="PrzewodyWysNapieciaWymianaTak" runat="server" /></label></td>
                                        <td>
                                            <label for="ctl00_cphContent_PrzewodyWysNapieciaWymianaNie">
                                                <asp:CheckBox ID="PrzewodyWysNapieciaWymianaNie" runat="server" /></label></td>
                                    </tr>
                                    <tr>
                                        <td>11.</td>
                                        <td>Płyn chłodzacy</td>
                                        <td>
                                            <label for="ctl00_cphContent_PlynChlodzacyInspekcja">
                                                <asp:CheckBox ID="PlynChlodzacyInspekcja" runat="server" /></label></td>
                                        <td>
                                            <label for="ctl00_PlynChlodzacyWymianaTak">
                                                <asp:CheckBox ID="PlynChlodzacyWymianaTak" runat="server" /></label></td>
                                        <td>
                                            <label for="ctl00_cphContent_PlynChlodzacyWymianaNie">
                                                <asp:CheckBox ID="PlynChlodzacyWymianaNie" runat="server" /></label></td>
                                    </tr>
                                    <tr>
                                        <td>12.</td>
                                        <td>Olej w przednim zawieszeniu</td>
                                        <td>
                                            <label for="ctl00_cphContent_OlejWprzednimZawieszeniuInspekcja">
                                                <asp:CheckBox ID="OlejWprzednimZawieszeniuInspekcja" runat="server" /></label></td>
                                        <td>
                                            <label for="ctl00_cphContent_OlejWprzednimZawieszeniuWymianaTak">
                                                <asp:CheckBox ID="OlejWprzednimZawieszeniuWymianaTak" runat="server" /></label></td>
                                        <td>
                                            <label for="ctl00_cphContent_OlejWprzednimZawieszeniuWymianaNie">
                                                <asp:CheckBox ID="OlejWprzednimZawieszeniuWymianaNie" runat="server" /></label></td>
                                    </tr>
                                    <tr>
                                        <td>13.</td>
                                        <td>Uszczelniacze przedniego zawieszenia</td>
                                        <td>
                                            <label for="ctl00_cphContent_UszczelniaczePrzedniegoZawieszeniaInspekcja">
                                                <asp:CheckBox ID="UszczelniaczePrzedniegoZawieszeniaInspekcja" runat="server" /></label></td>
                                        <td>
                                            <label for="ctl00_cphContent_UszczelniaczePrzedniegoZawieszeniaWymianaTak">
                                                <asp:CheckBox ID="UszczelniaczePrzedniegoZawieszeniaWymianaTak" runat="server" /></label></td>
                                        <td>
                                            <label for="ctl00_cphContent_UszczelniaczePrzedniegoZawieszeniaWymianaNie">
                                                <asp:CheckBox ID="UszczelniaczePrzedniegoZawieszeniaWymianaNie" runat="server" /></label></td>
                                    </tr>
                                    <tr>
                                        <td>14.</td>
                                        <td>Zestaw napędowy</td>
                                        <td>
                                            <label for="ctl00_cphContent_ZestawNapedowyInspekcja">
                                                <asp:CheckBox ID="ZestawNapedowyInspekcja" runat="server" /></label></td>
                                        <td>
                                            <label for="ctl00_cphContent_ZestawNapedowyWymianaTak">
                                                <asp:CheckBox ID="ZestawNapedowyWymianaTak" runat="server" /></label></td>
                                        <td>
                                            <label for="ctl00_cphContent_ZestawNapedowyWymianaNie">
                                                <asp:CheckBox ID="ZestawNapedowyWymianaNie" runat="server" /></label></td>
                                    </tr>
                                    <tr>
                                        <td>15.</td>
                                        <td>Zawory</td>
                                        <td>
                                            <label for="ctl00_cphContent_ZaworyInspekcja">
                                                <asp:CheckBox ID="ZaworyInspekcja" runat="server" /></label></td>
                                        <td>
                                            <label for="ctl00_cphContent_ZaworyWymianaTak">
                                                <asp:CheckBox ID="ZaworyWymianaTak" runat="server" /></label></td>
                                        <td>
                                            <label for="ctl00_cphContent_ZaworyWymianaNie">
                                                <asp:CheckBox ID="ZaworyWymianaNie" runat="server" /></label></td>
                                    </tr>
                                    <tr>
                                        <td>16.</td>
                                        <td>Łańcuch/napinacz rozrządu</td>
                                        <td>
                                            <label for="ctl00_cphContent_LancuchNapinaczRozrzaduInspekcja">
                                                <asp:CheckBox ID="LancuchNapinaczRozrzaduInspekcja" runat="server" /></label></td>
                                        <td>
                                            <label for="ctl00_cphContent_LancuchNapinaczRozrzaduWymianaTak">
                                                <asp:CheckBox ID="LancuchNapinaczRozrzaduWymianaTak" runat="server" /></label></td>
                                        <td>
                                            <label for="ctl00_cphContent_LancuchNapinaczRozrzaduWymianaNie">
                                                <asp:CheckBox ID="LancuchNapinaczRozrzaduWymianaNie" runat="server" /></label></td>
                                    </tr>
                                    <tr>
                                        <td>17.</td>
                                        <td>Linki/cięgna/przewody</td>
                                        <td colspan="3"></td>
                                    </tr>
                                    <tr>
                                        <td>17a.</td>
                                        <td>gazu</td>
                                        <td>
                                            <label for="ctl00_cphContent_LinkaGazuInspekcja">
                                                <asp:CheckBox ID="LinkaGazuInspekcja" runat="server" /></label></td>
                                        <td>
                                            <label for="ctl00_cphContent_LinkaGazuWymianaTak">
                                                <asp:CheckBox ID="LinkaGazuWymianaTak" runat="server" /></label></td>
                                        <td>
                                            <label for="ctl00_cphContent_LinkaGazuWymianaNie">
                                                <asp:CheckBox ID="LinkaGazuWymianaNie" runat="server" /></label></td>
                                    </tr>
                                    <tr>
                                        <td>17b.</td>
                                        <td>sprzęgła</td>
                                        <td>
                                            <label for="ctl00_cphContent_LinkaSpedzeglaInspekcja">
                                                <asp:CheckBox ID="LinkaSpedzeglaInspekcja" runat="server" /></label></td>
                                        <td>
                                            <label for="ctl00_cphContent_LinkaSpedzeglaWymianaTak">
                                                <asp:CheckBox ID="LinkaSpedzeglaWymianaTak" runat="server" /></label></td>
                                        <td>
                                            <label for="ctl00_cphContent_LinkaSpedzeglaWymianaNie">
                                                <asp:CheckBox ID="LinkaSpedzeglaWymianaNie" runat="server" /></label></td>
                                    </tr>
                                    <tr>
                                        <td>17c.</td>
                                        <td>hamulca przód</td>
                                        <td>
                                            <label for="ctl00_cphContent_LinkaHamulcaPrzodInspekcja">
                                                <asp:CheckBox ID="LinkaHamulcaPrzodInspekcja" runat="server" /></label></td>
                                        <td>
                                            <label for="ctl00_cphContent_LinkaHamulcaPrzodWymianaTak">
                                                <asp:CheckBox ID="LinkaHamulcaPrzodWymianaTak" runat="server" /></label></td>
                                        <td>
                                            <label for="ctl00_cphContent_LinkaHamulcaPrzodWymianaNie">
                                                <asp:CheckBox ID="LinkaHamulcaPrzodWymianaNie" runat="server" /></label></td>
                                    </tr>
                                    <tr>
                                        <td>17d.</td>
                                        <td>hamulca tył</td>
                                        <td>
                                            <label for="ctl00_cphContent_LinkaHamulcaTylInspekcja">
                                                <asp:CheckBox ID="LinkaHamulcaTylInspekcja" runat="server" /></label></td>
                                        <td>
                                            <label for="ctl00_cphContent_LinkaHamulcaTylWymianaTak">
                                                <asp:CheckBox ID="LinkaHamulcaTylWymianaTak" runat="server" /></label></td>
                                        <td>
                                            <label for="ctl00_cphContent_LinkaHamulcaTylWymianaNie">
                                                <asp:CheckBox ID="LinkaHamulcaTylWymianaNie" runat="server" /></label></td>
                                    </tr>
                                    <tr>
                                        <td>17e.</td>
                                        <td>obrotomierza</td>
                                        <td>
                                            <label for="ctl00_cphContent_LinkaObrotomierzaInspekcja">
                                                <asp:CheckBox ID="LinkaObrotomierzaInspekcja" runat="server" /></label></td>
                                        <td>
                                            <label for="ctl00_cphContent_LinkaObrotomierzaWymianaTak">
                                                <asp:CheckBox ID="LinkaObrotomierzaWymianaTak" runat="server" /></label></td>
                                        <td>
                                            <label for="ctl00_cphContent_LinkaObrotomierzaWymianaNie">
                                                <asp:CheckBox ID="LinkaObrotomierzaWymianaNie" runat="server" /></label></td>
                                    </tr>
                                    <tr>
                                        <td>17f.</td>
                                        <td>prędkościomierza</td>
                                        <td>
                                            <label for="ctl00_cphContent_LinkaPredkosciomierzaInspekcja">
                                                <asp:CheckBox ID="LinkaPredkosciomierzaInspekcja" runat="server" /></label></td>
                                        <td>
                                            <label for="ctl00_cphContent_LinkaPredkosciomierzaWymianaTak">
                                                <asp:CheckBox ID="LinkaPredkosciomierzaWymianaTak" runat="server" /></label></td>
                                        <td>
                                            <label for="ctl00_cphContent_LinkaPredkosciomierzaWymianaNie">
                                                <asp:CheckBox ID="LinkaPredkosciomierzaWymianaNie" runat="server" /></label></td>
                                    </tr>
                                    <tr>
                                        <td>18.</td>
                                        <td>Synchronizator</td>
                                        <td>
                                            <label for="ctl00_cphContent_SynchronizacjaInspekcja">
                                                <asp:CheckBox ID="SynchronizacjaInspekcja" runat="server" /></label></td>
                                        <td>
                                            <label for="ctl00_cphContent_SynchronizacjaWymianaTak">
                                                <asp:CheckBox ID="SynchronizacjaWymianaTak" runat="server" /></label></td>
                                        <td>
                                            <label for="ctl00_cphContent_SynchronizacjaWymianaNie">
                                                <asp:CheckBox ID="SynchronizacjaWymianaNie" runat="server" /></label></td>
                                    </tr>
                                    <tr>
                                        <td>19.</td>
                                        <td>Przepustnica</td>
                                        <td>
                                            <label for="ctl00_cphContent_PrzepustnicaInspekcja">
                                                <asp:CheckBox ID="PrzepustnicaInspekcja" runat="server" /></label></td>
                                        <td>
                                            <label for="ctl00_cphContent_PrzepustnicaWymianaTak">
                                                <asp:CheckBox ID="PrzepustnicaWymianaTak" runat="server" /></label></td>
                                        <td>
                                            <label for="ctl00_cphContent_PrzepustnicaWymianaNie">
                                                <asp:CheckBox ID="PrzepustnicaWymianaNie" runat="server" /></label></td>
                                    </tr>
                                    <tr>
                                        <td>20.</td>
                                        <td>Uwagi inne</td>
                                        <td colspan="3">
                                            <asp:TextBox ID="Uwagi" TextMode="MultiLine" Width="100%" CssClass="inputVehicleInsAdd" Height="100" runat="server"></asp:TextBox></td>
                                    </tr>
                                    <tr>
                                        <td colspan="5" style="">
                                            <asp:LinkButton ID="lbtnVehicleInspectionAdd" runat="server" OnClick="VehicleInspectionAdd_onClick" CssClass="btn btn-lg btn-success btn-block" TabIndex="8">Dodaj przegląd techniczny</asp:LinkButton>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="5" style="">
                                            <a href="/Desk/Vehicle.aspx" class="btn btn-lg btn-warning btn-block">Anuluj</a>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>