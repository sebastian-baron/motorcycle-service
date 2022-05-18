<%@ Page Title="" Language="C#" MasterPageFile="~/Desk/MasterPageDesk.master" AutoEventWireup="true" CodeFile="CustomerAdd.aspx.cs" Inherits="Desk_CustomerAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphTitle" runat="Server">
    Dodaj nowego klienta
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="Server">
    <div class="row">
        <div class="col-lg-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                    Dodaj nowego klienta
                </div>
                <div class="panel-body">
                    <div class="row">
                        <div class="col-lg-6">
                            <form role="form">
                                <div class="form-group">
                                    <label>Imię i nazwisko</label>
                                    <input class="form-control" placeholder="wpisz tekst">
                                </div>
                                <div class="form-group">
                                    <label>Nazwa firmy</label>
                                    <input class="form-control" placeholder="wpisz tekst">
                                </div>
                                <div class="form-group">
                                    <label>Telefon kontaktowy</label>
                                    <input class="form-control" placeholder="wpisz tekst">
                                </div>
                            </form>

                        </div>
                        <div class="col-lg-6">
                            <form role="form">
                                <div class="form-group">
                                    <label>Miejscowość</label>
                                    <input class="form-control" placeholder="wpisz tekst">
                                </div>
                                <div class="form-group">
                                    <label>Ulica i nr</label>
                                    <input class="form-control" placeholder="wpisz tekst">
                                </div>
                                <div class="form-group">
                                    <label>Kod pocztowy</label>
                                    <input class="form-control" placeholder="wpisz tekst">
                                </div>
                            </form>
                        </div>
                        <div class="col-lg-12">
                            <button type="submit" class="btn btn-default">Submit Button</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

