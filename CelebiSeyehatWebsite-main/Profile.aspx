<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Profile.aspx.cs" Inherits="Çelebi_Seyahat_Acentesi.Profile" %>

<asp:Content ID="ContentProfile" ContentPlaceHolderID="MainContent" runat="server">
    <!DOCTYPE html>
    <html xmlns="http://www.w3.org/1999/xhtml">
    <head>
        <title>Profil</title>
        <style>
            body {
                font-family: Arial, sans-serif;
                background-color: #f4f4f4;
                margin: 0;
                padding: 20px;
            }

            .profile-container {
                max-width: 600px;
                margin: 0 auto;
                background-color: #fff;
                padding: 20px;
                border-radius: 8px;
                box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            }

            .profile-info {
                margin-bottom: 15px;
            }

                .profile-info label {
                    font-weight: bold;
                    display: block;
                    margin-bottom: 5px;
                }

                .profile-info span {
                    display: block;
                    margin-bottom: 10px;
                }
        </style>
    </head>
    <body>
        <div class="profile-container">
            <h1>Kullanıcı Profili</h1>
            <div class="profile-info" runat="server">
                <asp:PlaceHolder ID="phUsername" runat="server">
                    <label>Kullanıcı Adı:</label>
                    <span>
                        <asp:Label ID="lblUsername" runat="server"></asp:Label></span>
                </asp:PlaceHolder>
            </div>
            <div class="profile-info">
                <label>Ad:</label>
                <span>
                    <asp:Label ID="lblName" runat="server"></asp:Label></span>
            </div>
            <div class="profile-info">
                <label>Soyad:</label>
                <span>
                    <asp:Label ID="lblSurname" runat="server"></asp:Label></span>
            </div>
            <div class="profile-info" runat="server">
                <asp:PlaceHolder ID="phPoint" runat="server">
                    <label>Puan:</label>
                    <span>
                        <asp:Label ID="lblPoint" runat="server"></asp:Label></span>
                </asp:PlaceHolder>
            </div>
            <div class="profile-info" runat="server">
                <asp:PlaceHolder ID="phOwnTickets" runat="server">
                    <label>Sahip Olunan Biletler:</label>
                    <span>
                        <asp:Label ID="lblOwnTickets" runat="server"></asp:Label></span>
                </asp:PlaceHolder>
            </div>
            <div class="profile-info" runat="server">
                <asp:PlaceHolder ID="phOwnReservations" runat="server">
                    <label>Sahip Olunan Rezervasyonlar:</label>
                    <span>
                        <asp:Label ID="lblOwnReservations" runat="server"></asp:Label></span>
                </asp:PlaceHolder>
            </div>
            <div class="profile-info" runat="server">
                <asp:PlaceHolder ID="phStaffId" runat="server">
                    <label>Personel ID:</label>
                    <span>
                        <asp:Label ID="lblStaffId" runat="server"></asp:Label></span>
                </asp:PlaceHolder>
            </div>
            <div class="profile-info" runat="server">
                <asp:PlaceHolder ID="phWorkingPlace" runat="server">
                    <label>Çalışma Yeri:</label>
                    <span>
                        <asp:Label ID="lblWorkingPlace" runat="server"></asp:Label></span>
                </asp:PlaceHolder>
            </div>

        </div>
    </body>
    </html>
</asp:Content>
