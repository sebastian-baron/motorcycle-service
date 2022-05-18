<%@ Page Title="" Language="C#" MasterPageFile="~/Desk/MasterPageDesk.master" AutoEventWireup="true" CodeFile="Customers.aspx.cs" Inherits="Desk_Customers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphTitle" runat="Server">
    Klienci
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="Server">
    <!-- /.row -->
    <div class="row">
        <div class="col-lg-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                    DataTables Advanced Tables
                </div>
                <div class="panel-body">
                    <div class="dataTable_wrapper">
                        <table class="table table-striped table-bordered table-hover" id="dataTables-example">
                            <thead>
                                <tr>
                                    <th>Imię i nazwisko</th>
                                    <th>Nr telefonu</th>
                                    <th>Miejscowość</th>
                                    <th>Ostatni przegląd</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr class="gradeA">
                                    <td>KHTML</td>
                                    <td>Konqureror 3.3</td>
                                    <td>KDE 3.3</td>
                                    <td class="center">3.3</td>
                                </tr>

                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

