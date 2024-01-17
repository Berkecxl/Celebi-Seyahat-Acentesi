<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="ReservationList.aspx.cs" Inherits="Çelebi_Seyahat_Acentesi.ReservationList" %>

<asp:Content ID="ContentReservation" ContentPlaceHolderID="MainContent" runat="server">
    <!DOCTYPE html>
    <html xmlns="http://www.w3.org/1999/xhtml">
    <head>
        <meta charset="utf-8" />
        <meta name="viewport" content="width=device-width, initial-scale=1" />
        <title>Reservation List</title>
        <link href="Content/ReservationList.css" rel="stylesheet" />
        <script type="text/javascript">
            function showModal(reservationInfo) {
                document.getElementById('modalText').innerHTML = reservationInfo + " rezervasyonunu yapmak istediğinize emin misiniz?";
            }
            function hideModal() {
                document.getElementById('<%= pnlConfirmModal.ClientID %>').style.display = 'none';
            }
            function confirmRezervation() {
                document.getElementById('modalContent').innerHTML = '<div class="reservation-confirmation"><span class="checkmark">&#10003;</span> Rezervasyonunuz gerçekleşti.</div>';

            }
        </script>
    </head>
    <body>
        <div class="container-reservation-list">
            <h2 class="section-title-reservation-list">Rezervasyon Yap</h2>
            <asp:GridView ID="gvReservationList" runat="server" DataKeyNames="Id" AutoGenerateColumns="False" CssClass="reservation-list">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="ID" />
                    <asp:BoundField DataField="Hotel" HeaderText="Otel" />
                    <asp:BoundField DataField="Time" HeaderText="Tarih" />
                    <asp:BoundField DataField="Price" HeaderText="Fiyat" />
                    <asp:TemplateField HeaderText="Müsait">
                        <ItemTemplate>
                            <asp:CheckBox ID="chkPurchasable" runat="server" Checked='<%# Eval("isPurchasable") %>' Enabled="false" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Rezervasyon Yap">
                        <ItemTemplate>
                            <asp:Button ID="btnReserve" runat="server" Text="Rezerve Et"
                                CommandArgument='<%# Eval("Id") %>'
                                OnClick="btnReserve_Click"
                                OnClientClick='<%# "showModal(\"" + Eval("Hotel") + " - " + Eval("Time") + "\");" %>'
                                Visible='<%# Convert.ToBoolean(Eval("isPurchasable")) %>' />

                        </ItemTemplate>
                    </asp:TemplateField>

                </Columns>

            </asp:GridView>

            <asp:Panel ID="pnlConfirmModal" runat="server" CssClass="modal" Style="display: none;">
                <div class="modal-content" id="modalContent">
                    <span class="close-button" onclick="hideModal();">&times;</span>
                    <h2>Rezervasyon Onayı</h2>
                    <p id="modalText">Bu otelden rezervasyon yapmak istediğinize emin misiniz?</p>
                    <asp:Button ID="btnConfirm" runat="server" Text="Evet" CssClass="confirm-button" OnClick="btnConfirm_Click" OnClientClick='<%# "confirmRezervation(); return false;" %>' />
                    <button class="cancel-button" onclick="hideModal()">Hayır</button>
                </div>
            </asp:Panel>

        </div>
    </body>
    </html>
</asp:Content>
