<%@ Page Title="" Language="C#" MasterPageFile="~/Desk/MasterPageDesk.master" AutoEventWireup="true" CodeFile="VehicleAdd.aspx.cs" Inherits="Desk_AehicleAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphTitle" runat="Server">
    Dodaj pojazd
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="Server">
    <div class="row">
        <div class="col-lg-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                    Dodaj nowy pojazd
                </div>
                <div class="panel-body">
                    <div class="row">
                        <div class="col-lg-6">
                            <div class="form-group">
                                <label>Marka</label>
                                <asp:TextBox ID="txtMarka" runat="server" placeholder="wpisz tekst" CssClass="form-control" TabIndex="1" />
                            </div>
                            <div class="form-group">
                                <label>Model</label>
                                <asp:TextBox ID="txtModel" runat="server" placeholder="wpisz tekst" CssClass="form-control" TabIndex="1" />
                            </div>
                            <div class="form-group">
                                <label>Pojemność silnika (cm3)</label>
                                <asp:TextBox ID="txtPojemnoscSilnika" runat="server" placeholder="wpisz tekst" CssClass="form-control" TabIndex="1" />
                            </div>
                        </div>
                        <div class="col-lg-6">
                            <div class="form-group">
                                <label>Numer VIN</label>
                                <asp:TextBox ID="txtVIN" runat="server" placeholder="wpisz tekst" CssClass="form-control" TabIndex="1" />
                            </div>
                            <div class="form-group">
                                <label>Rok produkcji</label>
                                <asp:TextBox ID="txtRokProdukcji" runat="server" placeholder="wpisz tekst" CssClass="form-control" TabIndex="1" />
                            </div>
                            <div class="form-group">
                                <label>Data pierwszej rejestracji w kraju</label>
                                <asp:TextBox ID="txtDataPierwszejRejestracjiWkraju" runat="server" placeholder="wpisz tekst" CssClass="form-control" TabIndex="1" />
                            </div>
                            <div class="form-group">
                                <label>Numer rejestracyjny</label>
                                <asp:TextBox ID="txtNumerRejestracyjny" runat="server" placeholder="wpisz tekst" CssClass="form-control" TabIndex="1" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="panel panel-default">
                <div class="panel-heading">
                    Podstawowe materiały eksploatacyjne pojazdu
                </div>
                <div class="panel-body">
                    <div class="row">
                        <div class="col-lg-12 panel-headingTitle">Płyny ekspoatacyjne</div>
                        <div class="col-lg-6">
                            <div class="form-group">
                                <label>Olej silnikowy</label>
                                <asp:TextBox ID="txtOlejSilnikowy" runat="server" placeholder="wpisz tekst" CssClass="form-control" TabIndex="1" />
                            </div>
                            <div class="form-group">
                                <label>Olej w przednim widelcu</label>
                                <asp:TextBox ID="txtOlejWprzednimWidelcu" runat="server" placeholder="wpisz tekst" CssClass="form-control" TabIndex="1" />
                            </div>
                            <div class="form-group">
                                <label>Olej przekładniowy</label>
                                <asp:TextBox ID="txtOlejPrzekladniowy" runat="server" placeholder="wpisz tekst" CssClass="form-control" TabIndex="1" />
                            </div>
                        </div>
                        <div class="col-lg-6">
                            <div class="form-group">
                                <label>Płyn hamulcowy</label>
                                <asp:TextBox ID="txtPlynHamulcowy" runat="server" placeholder="wpisz tekst" CssClass="form-control" TabIndex="1" />
                            </div>
                            <div class="form-group">
                                <label>Płyn chłodzący</label>
                                <asp:TextBox ID="txtPlynChlodzacy" runat="server" placeholder="wpisz tekst" CssClass="form-control" TabIndex="1" />
                            </div>
                        </div>
                        <div class="col-lg-12 panel-headingTitle">Płyny ekspoatacyjne</div>
                        <div class="col-lg-6">
                            <div class="form-group">
                                <label>Świece zapłonowe</label>
                                <asp:TextBox ID="txtSwieceZaplonowe" runat="server" placeholder="wpisz tekst" CssClass="form-control" TabIndex="1" />
                            </div>
                            <div class="form-group">
                                <label>Akumulator</label>
                                <asp:TextBox ID="txtAkumulator" runat="server" placeholder="wpisz tekst" CssClass="form-control" TabIndex="1" />
                            </div>

                        </div>
                        <div class="col-lg-6">
                            <div class="form-group">
                                <label>Inne</label>
                                <asp:TextBox ID="txtPlynyEksploatacyjneInne" runat="server" placeholder="wpisz tekst" CssClass="form-control" TabIndex="1" />
                            </div>
                        </div>
                        <div class="col-lg-12 panel-headingTitle">Układ napędowy</div>
                        <div class="col-lg-6">
                            <div class="form-group">
                                <label>Pasek napędowy(długość i szerokość)</label>
                                <asp:TextBox ID="txtPasekNapedowy" runat="server" placeholder="wpisz tekst" CssClass="form-control" TabIndex="1" />
                            </div>
                        </div>
                        <div class="col-lg-6">
                            <div class="form-group">
                                <label>Inne</label>
                                <asp:TextBox ID="txtUkladNapedowyInne" runat="server" placeholder="wpisz tekst" CssClass="form-control" TabIndex="1" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="panel panel-default">
                <div class="panel-heading">
                    Właścicie pojazdu
                </div>
                <div class="panel-body">
                    <div class="row">
                        <div class="col-lg-6">
                            <div class="form-group">
                                <label>Imię i nazwisko</label>
                                <asp:TextBox ID="txtKlientImieNazwisko" runat="server" placeholder="wpisz tekst" CssClass="form-control" TabIndex="1" />
                            </div>
                            <div class="form-group">
                                <label>Nazwa firmy</label>
                                <asp:TextBox ID="txtKlientNazwaFirmy" runat="server" placeholder="wpisz tekst" CssClass="form-control" TabIndex="1" />
                            </div>
                            <div class="form-group">
                                <label>Telefon kontaktowy</label>
                                <asp:TextBox ID="txtKlientTelefon" runat="server" placeholder="wpisz tekst" CssClass="form-control" TabIndex="1" />
                            </div>
                        </div>
                        <div class="col-lg-6">
                            <div class="form-group">
                                <label>Miejscowość</label>
                                <asp:TextBox ID="txtKlientMiejscowosc" runat="server" placeholder="wpisz tekst" CssClass="form-control" TabIndex="1" />
                            </div>
                            <div class="form-group">
                                <label>Ulica i nr</label>
                                <asp:TextBox ID="txtKlientUlica" runat="server" placeholder="wpisz tekst" CssClass="form-control" TabIndex="1" />
                            </div>
                            <div class="form-group">
                                <label>Kod pocztowy</label>
                                <asp:TextBox ID="txtKlientKodPocztowy" runat="server" placeholder="wpisz tekst" CssClass="form-control" TabIndex="1" />
                            </div>

                        </div>
                    </div>
                </div>
            </div>
            <div class="col-lg-12" style="padding: 0; margin-bottom: 30px;">
                <asp:LinkButton ID="lbtnVehicleAdd" runat="server" OnClick="VehicleAdd_onClick" CssClass="btn btn-lg btn-success btn-block" TabIndex="8">
                </asp:LinkButton>
            </div>
        </div>
    </div>
</asp:Content>

