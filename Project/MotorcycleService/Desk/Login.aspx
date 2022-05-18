<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="desk_Login" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container">
        <div class="row">
            <div class="col-md-4 col-md-offset-4">
                <div class="login-panel panel panel-default">
                    <div class="panel-heading">
                        <h3 class="panel-title">Zaloguj się</h3>
                    </div>
                    <div class="panel-body">
                        <div class="form-group">
                            <asp:TextBox ID="txtLogin" placeholder="Podaj login" runat="server" CssClass="form-control" ValidationGroup="Login2" TabIndex="1" />
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtPassword" TextMode="Password" placeholder="Podaj hasło" runat="server" CssClass="form-control" ValidationGroup="Login2" TabIndex="2" />
                        </div>
                        <asp:Button ID="ibtLogin" runat="server" ValidationGroup="Login2" CssClass="btn btn-lg btn-success btn-block" OnClick="LoginToDesk_click" TabIndex="3" Text="Zaloguj się" />
                        <asp:Label ID="lblError" runat="server" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

