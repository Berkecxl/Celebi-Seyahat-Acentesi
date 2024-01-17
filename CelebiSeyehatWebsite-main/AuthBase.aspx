<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AuthBase.aspx.cs" Inherits="Çelebi_Seyahat_Acentesi.AuthBase" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Giriş Ekranı</title>
    <link href="Content/AuthBase.css" rel="stylesheet" />
</head>
<body>
    <section class="container">
        <div class="login-container">
            <div class="circle circle-one"></div>
            <div class="form-container">
                <img src="https://raw.githubusercontent.com/hicodersofficial/glassmorphism-login-form/master/assets/illustration.png" alt="illustration" class="illustration" />
                <h1 class="opacity">Giriş Yap</h1>
                <form runat="server" class="button-form">
                    <div>
                        <asp:LinkButton ID="lnkStaffSign" runat="server" CssClass="opacity" OnClick="lnkStaffSign_Click">Personel Girişi</asp:LinkButton>
                    </div>
                    <div>
                        <asp:LinkButton ID="lnkUserSign" runat="server" CssClass="opacity" OnClick="lnkUserSign_Click">Üye Girişi</asp:LinkButton>
                    </div>
                </form>
            </div>
            <div class="circle circle-two"></div>
        </div>
        <div class="theme-btn-container"></div>
    </section>
    <script src="Scripts/auth.js"></script>
</body>
</html>
