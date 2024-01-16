<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="TicketList.aspx.cs" Inherits="Çelebi_Seyahat_Acentesi.TicketList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!DOCTYPE html>
    <html xmlns="http://www.w3.org/1999/xhtml">
    <head>
        <meta charset="utf-8" />
        <meta name="viewport" content="width=device-width, initial-scale=1" />
        <title>Ticket List</title>
        <link href="Content/TicketList.css" rel="stylesheet" />
        <script type="text/javascript">
            function showModal(ticketInfo) {
                document.getElementById('modalText').innerHTML = ticketInfo + " biletini satın almak istediğinize emin misiniz?";
            }
            function hideModal() {
                document.getElementById('<%= pnlConfirmModal.ClientID %>').style.display = 'none';
            }
            function confirmTicket() {
                document.getElementById('modalContent').innerHTML = '<div class="ticket-confirmation"><span class="checkmark">&#10003;</span> Bilet satım alımınız gerçekleşti.</div>';

            }
        </script>
    </head>
    <body>
        <div class="container-ticket-list">
            <h2 class="section-title-ticket-list">Bilet Satın Al</h2>
            <asp:GridView ID="gvTicketList" runat="server" DataKeyNames="Id" AutoGenerateColumns="False" CssClass="ticket-list">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="ID" />
                    <asp:BoundField DataField="Company" HeaderText="Şirket" />
                    <asp:BoundField DataField="Time" HeaderText="Tarih" />
                    <asp:BoundField DataField="ExitPoint" HeaderText="Çıkış Noktası" />
                    <asp:BoundField DataField="DestinationPoint" HeaderText="Varış Noktası" />
                    <asp:BoundField DataField="Price" HeaderText="Fiyat" />
                    <asp:TemplateField HeaderText="Müsait">
                        <ItemTemplate>
                            <asp:CheckBox ID="chkPurchasable" runat="server" Checked='<%# Eval("isPurchasable") %>' Enabled="false" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Bilet Al">
                        <ItemTemplate>
                            <asp:Button ID="btnReserve" runat="server" Text="Satın Al"
                                CommandArgument='<%# Eval("Id") %>'
                                OnClick="btnReserve_Click"
                                OnClientClick='<%# "showModal(\"" + Eval("Company") + " - " + Eval("Time") + "\");" %>'
                                Visible='<%# Convert.ToBoolean(Eval("isPurchasable")) %>' />

                        </ItemTemplate>
                    </asp:TemplateField>

                </Columns>

            </asp:GridView>

            <asp:Panel ID="pnlConfirmModal" runat="server" CssClass="modal" Style="display: none;">
                <div class="modal-content" id="modalContent">
                    <span class="close-button" onclick="hideModal();">&times;</span>
                    <h2>Bilet Alım Onayı</h2>
                    <p id="modalText">Bu bileti satın almak istediğinize emin misiniz?</p>
                    <asp:Button ID="btnConfirm" runat="server" Text="Evet" CssClass="confirm-button" OnClick="btnConfirm_Click" OnClientClick='<%# "confirmTicket(); return false;" %>' />
                    <button class="cancel-button" onclick="hideModal()">Hayır</button>
                </div>
            </asp:Panel>

        </div>
    </body>
    </html>
</asp:Content>
