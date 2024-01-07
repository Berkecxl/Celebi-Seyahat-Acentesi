<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="TicketList.aspx.cs" Inherits="Çelebi_Seyahat_Acentesi.TicketList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!DOCTYPE html>
    <html xmlns="http://www.w3.org/1999/xhtml">
    <head>
        <meta charset="utf-8" />
        <meta name="viewport" content="width=device-width, initial-scale=1" />
        <title>Ticket List</title>
        <link href="Content/TicketList.css" rel="stylesheet" />
    </head>
    <body>
            <div class="container-ticket-list">
                <h2 class="section-title-ticket-list">Ticket List</h2>
                <asp:GridView ID="gvTicketList" runat="server" AutoGenerateColumns="False" CssClass="ticket-list">
                    <Columns>
                        <asp:BoundField DataField="Id" HeaderText="ID" />
                        <asp:BoundField DataField="Company" HeaderText="Company" />
                        <asp:BoundField DataField="Time" HeaderText="Time" />
                        <asp:BoundField DataField="ExitPoint" HeaderText="Exit Point" />
                        <asp:BoundField DataField="DestinationPoint" HeaderText="Destination Point" />
                        <asp:BoundField DataField="Price" HeaderText="Price" />
                        <asp:TemplateField HeaderText="Purchasable">
                            <ItemTemplate>
                                <asp:CheckBox ID="chkPurchasable" runat="server" Checked='<%# Eval("isPurchasable") %>' Enabled="false" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
    </body>
    </html>
</asp:Content>
