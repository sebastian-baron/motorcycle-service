<%@ Page Title="" Language="C#" MasterPageFile="~/Desk/MasterPageDesk.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Desk_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphTitle" runat="Server">
    Witamy
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="Server">
    <div class="panel panel-default">
        <div class="panel-heading">
            <i class="fa fa-clock-o fa-fw"></i>Ostatnio naprawiane pojazdy
        </div>
        <div class="panel-body">
            <ul class="timeline">
                <asp:Literal runat="server" ID="litVehicleDetail" EnableViewState="false" />
            </ul>
        </div>
    </div>
</asp:Content>

