<%@ Page Title="" Language="C#" MasterPageFile="~/Desk/MasterPageDesk.master" AutoEventWireup="true" CodeFile="VehicleDetail.aspx.cs" Inherits="Desk_VehicleDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphTitle" runat="Server">
    Szczegóły pojazdu
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="Server">
    <div class="row vehicleDetail">
        <asp:Literal ID="litVehicleDetail" runat="server" />
    </div>
    <div class="panel panel-default">
        <div class="panel-heading">
            <i class="fa fa-clock-o fa-fw"></i>Historia zmian
        </div>
        <div class="panel-body">
            <div class="row">
                <div class="col-lg-12">
                    <asp:Literal ID="litMakeBtnForAddInspect" runat="server" />
                </div>
            </div>
            <ul class="timeline">
                <asp:Literal runat="server" ID="litVehicleInspection" EnableViewState="false" />
            </ul>
        </div>
    </div>
</asp:Content>

