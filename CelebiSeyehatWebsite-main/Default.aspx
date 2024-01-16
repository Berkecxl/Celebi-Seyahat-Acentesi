<%@ Page Title="Anasayfa" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Çelebi_Seyahat_Acentesi._Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="hero-section">
        <div class="hero-content">
            <h1>Çelebi Seyahat Acentesi</h1>
            <p>Çelebi Seyahat Acentesi, seyahatlerinizde size en iyi deneyimi sunmayı hedefler. Tatil ve seyahatleriniz için en geniş seçenekler ve en uygun fiyatlarla hizmetinizdeyiz!</p>
        <a href="TicketList.aspx" class="btn">Hemen Bilet Al</a>
        <a href="ReservationList.aspx" class="btn">Hemen Rezervasyon Yap</a>
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

    <style>
    #carouselExampleIndicators {
        max-width: 800px; 
        margin: 0 auto; 
    }

    .carousel-inner img {
        width: 100%;
        height: auto;
    }
</style>

<div id="carouselExampleIndicators" class="carousel slide mb-4">
    <div class="carousel-indicators">
        <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="0" class="active" aria-current="true" aria-label="Slide 1"></button>
        <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="1" aria-label="Slide 2"></button>
        <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="2" aria-label="Slide 3"></button>
        <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="3" aria-label="Slide 4"></button>
    </div>

    <div class="carousel-inner">
        <div class="carousel-item active">
            <img src="Images/merchant1.png" class="d-block w-100" alt="Image Bulunamadı">
            <div class="carousel-caption">
                <h2>Anlaşmalı Olduğumuz Şirketler</h2>
                <p>TatilTurizm</p>
            </div>
        </div>

        <div class="carousel-item">
            <img src="Images/merchant2.png" class="d-block w-100" alt="Image Bulunamadı">
            <div class="carousel-caption">
                <h2>Anlaşmalı Olduğumuz Şirketler</h2>
                <p>SeyahatTurizm</p>
            </div>
        </div>

        <div class="carousel-item">
            <img src="Images/merchant3.png" class="d-block w-100" alt="Image Bulunamadı">
            <div class="carousel-caption">
                <h2>Anlaşmalı Olduğumuz Şirketler</h2>
                <p>TaylandTurizm</p>
            </div>
        </div>

        <div class="carousel-item">
            <img src="Images/merchant4.png" class="d-block w-100" alt="Image Bulunamadı">
            <div class="carousel-caption">
                <h2>Anlaşmalı Olduğumuz Şirketler</h2>
                <p>DalışTurizm</p>
            </div>
        </div>
    </div>

    <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide="prev">
        <span class="carousel-control-prev-icon" aria-hidden="true"></span>
        <span class="visually-hidden">Previous</span>
    </button>

    <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide="next">
        <span class="carousel-control-next-icon" aria-hidden="true"></span>
        <span class="visually-hidden">Next</span>
    </button>
</div>

</asp:Content>
