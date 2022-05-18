<%@ Page Title="" Language="C#" MasterPageFile="~/Desk/MasterPageDesk.master" AutoEventWireup="true" CodeFile="Vehicle.aspx.cs" Inherits="Desk_Vehicle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphTitle" runat="Server">
    Lista pojazdów
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
                            <table class="table table-striped table-bordered table-hover" id="dataTables-example">
                                <thead>
                                    <tr>
                                        <th>VIN</th>
                                        <th>Marka i model</th>
                                        <th>Nr rej.</th>
                                        <th>Akcje</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <asp:Literal ID="litContent" runat="server" EnableViewState="false" />
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

