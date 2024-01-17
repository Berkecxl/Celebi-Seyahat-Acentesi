<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="StaffPanel.aspx.cs" Inherits="Çelebi_Seyahat_Acentesi.StaffPanel" %>

<asp:Content ID="ContentLog" ContentPlaceHolderID="MainContent" runat="server">
    <head>
        <link rel="stylesheet" href="Content/Log.css"/>
    </head>
    <body>
      <div class="containerLogList">
          <h2 class="section-titleLogList">Ürün Yönetim Geçmişi</h2>
          <asp:Repeater ID="repeaterLogs" runat="server">
              <ItemTemplate>
                  <div class="item shadow-lg p-3 mb-5 bg-body-tertiary rounded">
                      <h2 class="title"><%# Eval("Merchant") %></h2>
                      <p class="info">ID:  <%# Eval("Id") %></p>
                      <p class="info">Kullanıcı: <%# Eval("Username") %></p>
                      <p class="info">Alış Fiyatı: <%# Eval("Price") %></p>
                      <p class="info">Tarih: <%# Convert.ToDateTime(Eval("CreatedDate")).ToString("dd MMMM yyyy 'saat' HH:mm") %></p>
                  </div>
              </ItemTemplate>
          </asp:Repeater>
      </div>
  </body>
</asp:Content>
