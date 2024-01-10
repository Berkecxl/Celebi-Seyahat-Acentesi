<%@ Page Title="Anasayfa" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Çelebi_Seyahat_Acentesi._Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="hero-section">
        <div class="hero-content">
            <h1>Çelebi Seyahat Acentesi</h1>
            <p>Çelebi Seyahat Acentesi, seyahatlerinizde size en iyi deneyimi sunmayı hedefler. Tatil ve seyahatleriniz için en geniş seçenekler ve en uygun fiyatlarla hizmetinizdeyiz!</p>
        <a href="TicketList.aspx" class="btn">Hemen Bilet Al</a>
        </div>
    </div>

    <section class="services-section">
        <div class="container">
            <h2>Neler Yapabilirsiniz?</h2>
            <div class="service">
                <img src="Images/train.png" alt="Uçak" />
                <h3>Bilet Satın Al</h3>
                <p>Çeşitli firmalardan bilet satın alabilirsiniz. Uçan Türk, Devlet Demir Yolları (TCDD) ve YTUR otobüs firmalarının biletleri mevcut ve ileride başka firmaların biletleri de eklenmeyi planlıyoruz.</p>
            </div>
            <div class="service">
                <img src="Images/hotel.png" alt="Otel" />
                <h3>Otel Rezervasyonu</h3>
                <p>Harika tatil fırsatları için otel rezervasyonlarınızı yapabilirsiniz. Çeşitli otellerle anlaşma imzaladık ve müşterilerimize geniş bir seçenek sunuyoruz.</p>
            </div>
            <div class="service">
                <img src="Images/reward.png" alt="Ödüller" />
                <h3>Puan Kazanın</h3>
                <p>Yaptığınız seyahatlerde ve alışverişlerde puanlar kazanabilirsiniz. Özel olarak belirlenen kurallarla, seyahatlerinizdeki harcamalarınıza karşılık puanlar kazanabilir ve bunları sonraki seyahatlerinizde kullanabilirsiniz.</p>
            </div>
        </div>
    </section>
</asp:Content>
