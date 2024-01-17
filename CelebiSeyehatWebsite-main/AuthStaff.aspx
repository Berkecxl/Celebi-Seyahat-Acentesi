<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AuthStaff.aspx.cs" Inherits="Çelebi_Seyahat_Acentesi.AuthStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Giriş Ekranı</title>
    <link href="Content/Auth.css" rel="stylesheet" /> 
</head>
<body>
    <section class="container">
        <div class="login-container">
            <div class="circle circle-one"></div>
            <div class="form-container">
                <img src="https://raw.githubusercontent.com/hicodersofficial/glassmorphism-login-form/master/assets/illustration.png" alt="illustration" class="illustration" />
                <h1 class="opacity">Giriş Yap</h1>
                <form runat="server">
                    <asp:TextBox ID="txtStaffId" runat="server" TextMode="Number" placeholder="Personel No" CssClass="opacity"></asp:TextBox>
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" placeholder="Şifre" CssClass="opacity"></asp:TextBox>
                    <div class="alert alert-danger" id="loginError" runat="server" visible="false">
                    Personel No veya şifre hatalı.
                    </div>
                    <asp:Button ID="btnGiris" runat="server" Text="GİRİŞ YAP" CssClass="opacity" OnClick="btnGiris_Click" />
                </form>
            </div>
            <div class="circle circle-two"></div>
        </div>
        <div class="theme-btn-container"></div>
    </section>
    <script src="Scripts/auth.js"></script>
</body>
</html>
