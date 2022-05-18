<%@ Page Title="" Language="C#" MasterPageFile="~/Desk/MasterPageDesk.master" AutoEventWireup="true" CodeFile="ChangePassword.aspx.cs" Inherits="Desk_ChangePassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphTitle" runat="Server">
    Zmień hasło
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="Server">
    <div class="container">
        <div class="row">
            <div class="col-md-4 col-md-offset-4">
                <div class="login-panel panel panel-default">
                    <div class="panel-body">
                        <asp:Panel ID="pnlChangePass" runat="server" DefaultButton="ibtChangePass" HorizontalAlign="Center">
                            <form role="form">
                                <fieldset>
                                    <div class="form-group">
                                        <asp:TextBox ID="txtPass" TextMode="Password" placeholder="Podaj nowe hasło" runat="server" CssClass="form-control" ValidationGroup="Login2" TabIndex="1" />
                                    </div>
                                    <div class="form-group">
                                        <asp:TextBox ID="txtPass2" TextMode="Password" placeholder="Powtórz nowe hasło" runat="server" CssClass="form-control" ValidationGroup="Login2" TabIndex="2" />
                                    </div>
                                    <asp:Button ID="ibtChangePass" runat="server" ValidationGroup="Login2" CssClass="btn btn-lg btn-success btn-block" OnClick="ChangePass" TabIndex="3" Text="Zmień hasło" />
                                </fieldset>
                            </form>
                        </asp:Panel>
                        <asp:Panel ID="pnlSucces" runat="server" HorizontalAlign="Center">

                        </asp:Panel>
                        <asp:Label ID="lblError" runat="server" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

