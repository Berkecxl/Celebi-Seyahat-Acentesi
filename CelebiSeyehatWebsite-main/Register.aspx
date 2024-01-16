<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Çelebi_Seyahat_Acentesi.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Kayıt Ol Ekranı</title>
    <link href="Content/Register.css" rel="stylesheet" /> 
</head>
<body>
    <section class="container">
        <div class="login-container">
            <div class="circle circle-one"></div>
            <div class="form-container">
                <img src="https://raw.githubusercontent.com/hicodersofficial/glassmorphism-login-form/master/assets/illustration.png" alt="illustration" class="illustration" />
                <h1 class="opacity">KAYIT OL</h1>
                <form runat="server">
                    <asp:TextBox ID="txtUsername" runat="server" placeholder="Kullanıcı Adı" CssClass="opacity"></asp:TextBox>
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" placeholder="Şifre" CssClass="opacity"></asp:TextBox>
                    <asp:TextBox ID="txtName" runat="server" placeholder="İsim" CssClass="opacity"></asp:TextBox>
                    <asp:TextBox ID="txtSurname" runat="server" placeholder="Soyisim" CssClass="opacity"></asp:TextBox>
                    <asp:Button ID="btnKayitOl" runat="server" Text="KAYIT OL" CssClass="opacity" OnClick="btnKayitOl_Click" />
                    <asp:LinkButton ID="lnkGiris" runat="server" OnClick="lnkGiris_Click">GİRİŞ YAP</asp:LinkButton>
                </form>
            </div>
            <div class="circle circle-two"></div>
        </div>
        <div class="theme-btn-container"></div>
    </section>
    <script src="Scripts/auth.js"></script>

</body>
</html>