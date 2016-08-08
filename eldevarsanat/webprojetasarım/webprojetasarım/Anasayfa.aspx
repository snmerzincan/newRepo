<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Anasayfa.aspx.cs" Inherits="webprojetasarım.Anasayfa" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
              <div class="col-md-6 col-xs-12">
    <asp:Label ID="lblKullanıcıismi" runat="server" CssClass="col-md-6 col-xs-12"></asp:Label>
                  </div>
     <!-- BANNER -->
      <div class="bannercontainer">
        <div class="fullscreenbanner-container">
          <div class="fullscreenbanner">
            <ul>
              <li data-transition="slidehorizontal" data-slotamount="5" data-masterspeed="700" data-title="Slide 1">
                <img src="img\seteklogobanner.png" alt="slidebg1" data-bgfit="cover" data-bgposition="centercenter" data-bgrepeat="no-repeat">
                <div class="slider-caption container">
                  <div class="tp-caption rs-caption-1 sft start" data-hoffset="0" data-x="440" data-y="54" data-speed="800" data-start="1500" data-easing="Back.easeInOut" data-endspeed="300">
                    <img src="img\seteklogobanner.png" alt="slider-image">
                  </div>

                  <div class="tp-caption rs-caption-2 sft" data-hoffset="0" data-y="119" data-speed="800" data-start="2000" data-easing="Back.easeInOut" data-endspeed="300">
                    Onlarca Sanatkar<br>
                    Binlerce El Emeği Ürün<br />
                    www.eldevarsanat.com<br>
                  </div>
                  <div class="tp-caption rs-caption-4 sft" data-hoffset="0" data-y="320" data-speed="800" data-start="3500" data-easing="Power4.easeOut" data-endspeed="300" data-endeasing="Power1.easeIn" data-captionhidden="off">
                    <span class="page-scroll"><a href="UrunGridGorunum.aspx" class="btn primary-btn">TÜM ÜRÜNLER<i class="glyphicon glyphicon-chevron-right"></i></a></span>
                  </div>
                </div>
              </li>

              <li data-transition="slidehorizontal" data-slotamount="5" data-masterspeed="700" data-title="Slide 2">
                <img src="img\SliderResimleri\MadamCasi_minimumlar.png" alt="slidebg1" data-bgfit="cover" data-bgposition="centercenter" data-bgrepeat="no-repeat">
                <div class="slider-caption container">
                  <div class="tp-caption rs-caption-1 sft start" data-hoffset="0" data-x="370" data-y="54" data-speed="800" data-start="1500" data-easing="Back.easeInOut" data-endspeed="300">
                    <img src="img\SliderResimleri\MadamCasi_minimumlar.png" alt="slider-image">
                  </div>

                  <div class="tp-caption rs-caption-2 sft" data-hoffset="0" data-y="119" data-speed="800" data-start="2000" data-easing="Back.easeInOut" data-endspeed="300">
                    Evinize Özel<br>
                    Renkli Mini<br />
                    Mumlar<br>
                  </div>
                  <div class="tp-caption rs-caption-4 sft" data-hoffset="0" data-y="320" data-speed="800" data-start="3500" data-easing="Power4.easeOut" data-endspeed="300" data-endeasing="Power1.easeIn" data-captionhidden="off">
                    <span class="page-scroll"><a href="#" class="btn primary-btn">Satın Al<i class="glyphicon glyphicon-chevron-right"></i></a></span>
                  </div>
                </div>
              </li>
              <li data-transition="slidehorizontal" data-slotamount="5" data-masterspeed="1000" data-title="Slide 3">
                <img src="img\SliderResimleri\KucukMucizeler_kolonyasiseleri.png" alt="slidebg" data-bgfit="cover" data-bgposition="center center" data-bgrepeat="no-repeat">
                <div class="slider-caption container captionCenter">
                  <div class="tp-caption rs-caption-1 sft start captionCenterAlign" data-x="center" data-y="228" data-speed="800" data-start="1500" data-easing="Back.easeInOut" data-endspeed="300">
                    <img src="img\SliderResimleri\KucukMucizeler_kolonyasiseleri.png" alt="slider-image">
                  </div>

                  <div class="tp-caption rs-caption-2 sft captionCenterAlign" data-x="center" data-y="50" data-speed="800" data-start="2000" data-easing="Back.easeInOut" data-endspeed="300">
                    Hediyelik
                  </div>

                  <div class="tp-caption rs-caption-3 sft captionCenterAlign" data-x="center" data-y="98" data-speed="1000" data-start="3000" data-easing="Power4.easeOut" data-endspeed="300" data-endeasing="Power1.easeIn" data-captionhidden="off">
                    Kolonya Şişeleri
                  </div>

                  <div class="tp-caption rs-caption-4 sft captionCenterAlign" data-x="center" data-y="156" data-speed="800" data-start="3500" data-easing="Power4.easeOut" data-endspeed="300" data-endeasing="Power1.easeIn" data-captionhidden="off">
                    <span class="page-scroll"><a href="#" class="btn primary-btn">Satın Al<i class="glyphicon glyphicon-chevron-right"></i></a></span>
                  </div>
                </div>
              </li>
              <li data-transition="slidehorizontal" data-slotamount="5" data-masterspeed="700" data-title="Slide 4">
                <img src="img\SliderResimleri\EzgiliTasarımlar_kokulutasisimlik.png" alt="slidebg" data-bgfit="cover" data-bgposition="center center" data-bgrepeat="no-repeat">
                <div class="slider-caption container">
                  <div class="tp-caption rs-caption-1 sft start" data-hoffset="0" data-x="0" data-y="85" data-speed="800" data-start="1500" data-easing="Back.easeInOut" data-endspeed="300">
                    <img src="img\SliderResimleri\EzgiliTasarımlar_kokulutasisimlik.png" alt="slider-image">
                  </div>

                  <div class="tp-caption rs-caption-2 sft " data-hoffset="0" data-y="119" data-x="800" data-speed="800" data-start="2000" data-easing="Back.easeInOut" data-endspeed="300">
                    Bebeğiniz için<br />
                    Özel Hazırlanan<br />
                  </div>
                     
                  <div class="tp-caption rs-caption-3 sft" data-hoffset="0" data-y="185" data-x="800" data-speed="1000" data-start="3000" data-easing="Power4.easeOut" data-endspeed="300" data-endeasing="Power1.easeIn" data-captionhidden="off">
                    <br>Kokulutaş İsimlik
                  </div>

                  <div class="tp-caption rs-caption-4 sft" data-hoffset="0" data-y="320" data-x="800" data-speed="800" data-start="3500" data-easing="Power4.easeOut" data-endspeed="300" data-endeasing="Power1.easeIn" data-captionhidden="off">
                    <span class="page-scroll"><a href="#" class="btn primary-btn">Satın Al<i class="glyphicon glyphicon-chevron-right"></i></a></span>
                   </div>
                </div>
              </li> 
            </ul>
          </div>
        </div>
      </div>

      <!-- MAIN CONTENT SECTION -->
      <section class="mainContent clearfix">
        <div class="container">
          <div class="row featuredCollection">
            <div class="col-xs-12">
              <div class="page-header">
                <h4>Tasarım Yapılan Alanlar</h4>
              </div>
            </div>
            <div class="col-sm-4 col-xs-12">
              <div class="thumbnail" onclick="location.href='UrunDetayi.aspx';">
                <div class="imageWrapper">
                  <img src="img\TasarımAlanları\EzgiliTasarımlar_kokulutasbanyoaksesuarı.png" alt="feature-collection-image">
                  <div class="masking"><a href="UrunGridGorunum.aspx" class="btn viewBtn">Görüntüle</a></div>
                </div>
                <div class="caption">
                  <h4>Ev Aksesuarları</h4>
                </div>
              </div>
            </div>
            <div class="col-sm-4 col-xs-12">
              <div class="thumbnail" onclick="location.href='UrunDetayi.aspx';">
                <div class="imageWrapper">
                  <img src="img\TasarımAlanları\MadamCasi_nikahsekeri.png" alt="feature-collection-image">
                  <div class="masking"><a href="UrunGridGorunum.aspx" class="btn viewBtn">Görüntüle</a></div>
                </div>
                <div class="caption">
                  <h4>Düğün-Nişan-Kına-Baby Shower Organizasyon</h4>
                </div>
              </div>
            </div>
            <div class="col-sm-4 col-xs-12">
              <div class="thumbnail" onclick="location.href='UrunDetayi.aspx';">
                <div class="imageWrapper">
                  <img src="img\TasarımAlanları\KucukMucizeler_kapısüsü.png" alt="feature-collection-image">
                  <div class="masking"><a href="UrunGridGorunum.aspx" class="btn viewBtn">Görüntüle</a></div>
                </div>
                <div class="caption">
                  <h4>Hediyelik Tasarımlar</h4>
                </div>
              </div>
            </div>
          </div>
          <div class="row featuredProducts">
            <div class="col-xs-12">
              <div class="page-header">
                <h4>Ürünler / Tasarımlar</h4>
            </div>
            </div>
            <div class="col-xs-12">
              <div class="owl-carousel featuredProductsSlider">
                <div class="slide">
                  <div class="productImage clearfix">
                    <img src="img\home\featured-product\product-01.png" alt="featured-product-img">
                    <div class="productMasking">
                      <ul class="list-inline btn-group" role="group">
                        <li><a data-toggle="modal" href=".login-modal" class="btn btn-default"><i class="fa fa-heart"></i></a></li>
                        <li><a href="Sepet.aspx" class="btn btn-default"><i class="fa fa-shopping-cart"></i></a></li>
                        <li><a data-toggle="modal" href=".quick-view" class="btn btn-default"><i class="fa fa-eye"></i></a></li>
                      </ul>
                    </div>
                  </div>
                  <div class="productCaption clearfix">
                    <a href="UrunDetayi.aspx">
                      <h5>Kokulu Taş Hediyelik</h5>
                    </a>
                    <h3>19,90tl</h3>
                  </div>
                </div>
                <div class="slide">
                  <div class="productImage">
                    <img src="img\home\featured-product\product-02.png" alt="featured-product-img">
                    <div class="productMasking">
                      <ul class="list-inline btn-group" role="group">
                        <li><a data-toggle="modal" href=".login-modal" class="btn btn-default"><i class="fa fa-heart"></i></a></li>
                        <li><a href="Sepet.aspx" class="btn btn-default"><i class="fa fa-shopping-cart"></i></a></li>
                        <li><a data-toggle="modal" href=".quick-view" class="btn btn-default"><i class="fa fa-eye"></i></a></li>
                      </ul>
                    </div>
                  </div>
                  <div class="productCaption">
                    <a href="UrunDetayi.aspx">
                      <h5>Yuvarlak Aynalı Kapı Süsü</h5>
                    </a>
                    <h3>49,90tl</h3>
                  </div>
                </div>
                <div class="slide">
                  <div class="productImage">
                    <img src="img\home\featured-product\product-03.png" alt="featured-product-img">
                    <div class="productMasking">
                      <ul class="list-inline btn-group" role="group">
                        <li><a data-toggle="modal" href=".login-modal" class="btn btn-default"><i class="fa fa-heart"></i></a></li>
                        <li><a href="Sepet.aspx" class="btn btn-default"><i class="fa fa-shopping-cart"></i></a></li>
                        <li><a data-toggle="modal" href=".quick-view" class="btn btn-default"><i class="fa fa-eye"></i></a></li>
                      </ul>
                    </div>
                  </div>
                  <div class="productCaption">
                    <a href="UrunDetayi.aspx">
                      <h5>İsimlikli Kokulu Taş Pano</h5>
                    </a>
                    <h3>79,90tl</h3>
                  </div>
                </div>
                <div class="slide">
                  <div class="productImage">
                    <img src="img\home\featured-product\product-04.png" alt="featured-product-img">
                    <div class="productMasking">
                      <ul class="list-inline btn-group" role="group">
                        <li><a data-toggle="modal" href=".login-modal" class="btn btn-default"><i class="fa fa-heart"></i></a></li>
                        <li><a href="Sepet.aspx" class="btn btn-default"><i class="fa fa-shopping-cart"></i></a></li>
                        <li><a data-toggle="modal" href=".quick-view" class="btn btn-default"><i class="fa fa-eye"></i></a></li>
                      </ul>
                    </div>
                  </div>
                  <div class="productCaption">
                    <a href="UrunDetayi.aspx">
                      <h5>Kolonya Şişesi</h5>
                    </a>
                    <h3>4,90tl</h3>
                  </div>
                </div>
                <div class="slide">
                  <div class="productImage">
                    <img src="img\home\featured-product\product-05.png" alt="featured-product-img">
                    <div class="productMasking">
                      <ul class="list-inline btn-group" role="group">
                        <li><a data-toggle="modal" href=".login-modal" class="btn btn-default"><i class="fa fa-heart"></i></a></li>
                        <li><a href="Sepet.aspx" class="btn btn-default"><i class="fa fa-shopping-cart"></i></a></li>
                        <li><a data-toggle="modal" href=".quick-view" class="btn btn-default"><i class="fa fa-eye"></i></a></li>
                      </ul>
                    </div>
                  </div>
                  <div class="productCaption">
                    <a href="UrunDetayi.aspx">
                      <h5>Oda Kokusu</h5>
                    </a>
                    <h3>16,90tl</h3>
                  </div>
                </div>
                <div class="slide">
                  <div class="productImage">
                    <img src="img\home\featured-product\product-06.png" alt="featured-product-img">
                    <div class="productMasking">
                      <ul class="list-inline btn-group" role="group">
                        <li><a data-toggle="modal" href=".login-modal" class="btn btn-default"><i class="fa fa-heart"></i></a></li>
                        <li><a href="Sepet.aspx" class="btn btn-default"><i class="fa fa-shopping-cart"></i></a></li>
                        <li><a data-toggle="modal" href=".quick-view" class="btn btn-default"><i class="fa fa-eye"></i></a></li>
                      </ul>
                    </div>
                  </div>
                  <div class="productCaption">
                    <a href="UrunDetayi.aspx">
                      <h5>Erkek Bebek Takı Yastığı</h5>
                    </a>
                   <h3>39.90tl</h3>
                  </div>
                </div>
                <div class="slide">
                  <div class="productImage">
                    <img src="img\home\featured-product\product-07.png" alt="featured-product-img">
                    <div class="productMasking">
                      <ul class="list-inline btn-group" role="group">
                        <li><a data-toggle="modal" href=".login-modal" class="btn btn-default"><i class="fa fa-heart"></i></a></li>
                        <li><a href="Sepet.aspx" class="btn btn-default"><i class="fa fa-shopping-cart"></i></a></li>
                        <li><a data-toggle="modal" href=".quick-view" class="btn btn-default"><i class="fa fa-eye"></i></a></li>
                      </ul>
                    </div>
                  </div>
                  <div class="productCaption">
                    <a href="UrunDetayi.aspx">
                      <h5>Yenidoğan Kokulu Taş Hediye</h5>
                    </a>
                    <h3>5,90tl</h3>
                  </div>
                </div>
                <div class="slide">
                  <div class="productImage">
                    <img src="img\home\featured-product\product-08.png" alt="featured-product-img">
                    <div class="productMasking">
                      <ul class="list-inline btn-group" role="group">
                        <li><a data-toggle="modal" href=".login-modal" class="btn btn-default"><i class="fa fa-heart"></i></a></li>
                        <li><a href="Sepet.aspx" class="btn btn-default"><i class="fa fa-shopping-cart"></i></a></li>
                        <li><a data-toggle="modal" href=".quick-view" class="btn btn-default"><i class="fa fa-eye"></i></a></li>
                      </ul>
                    </div>
                  </div>
                  <div class="productCaption">
                    <a href="UrunDetayi.aspx">
                      <h5>Çiçek Demeti Kokulu Taş</h5>
                    </a>
                    <h3>49,90tl</h3>
                  </div>
                </div>
              </div>
            </div>  
          </div>
          <div class="row latestArticles">
            <div class="col-xs-12">
              <div class="page-header">
                <h4>Bloglar</h4>
              </div>
            </div>
              <div style="margin:auto">
            <div class="col-sm-3 col-xs-12">
              <div class="thumbnail">
                <h5><a href="BlogAciklama.aspx">Ezgili Tasarımlar</a></h5>
                <span class="meta">0539 377 76 73 <a href="#">Gülay Küpeli</a></span>
                <a href="BlogAciklama.aspx"><img src="img\ProfilResimleri\EzgiliTasarımlar_Profil.png" alt="article-image"></a>
                <div class="caption">
                  <p>Hayat okulu mezunu, hobisini işe dönüştürmüş birisi 😊</p>
                </div>
              </div>
            </div>
            <div class="col-sm-3 col-xs-12">
              <div class="thumbnail">
                <h5><a href="BlogAciklama.aspx">Küçük Mucizeler Dükkanı</a></h5>
                <span class="meta"> 0539 379 96 12 <a href="#">Abdus</a></span>
                <a href="BlogAciklama.aspx"><img src="img\ProfilResimleri\KucukMucizeler_Profil.png" alt="article-image"></a>
                <div class="caption">
                  <p>Kişiye özel tasarımlar yapılır...</p>
                </div>
              </div>
            </div>
            <div class="col-sm-3 col-xs-12">
              <div class="thumbnail">
                <h5><a href="BlogAciklama.aspx">Madam Casi</a></h5>
                <span class="meta">July 16, 2016 by <a href="#">Canan Aslı Seher</a></span>
                <a href="BlogAciklama.aspx"><img src="img\ProfilResimleri\MadamCasi_Profil.png" alt="article-image"></a>
                <div class="caption">
                  <p>Tasarım damacana kılıfları, Kokulu sabun demetleri, Nikah şekerleri, Kina,nişan,düğün,mevlüt süslemeleri, El emeği göz nuru, Akliniza gelebilecek niceleri...</p>
                </div>
              </div>
            </div>
                  </div>
         <%--   <div class="col-sm-3 col-xs-12">
              <div class="thumbnail">
                <h5><a href="BlogAciklama.aspx">Suspendisse vestibulum dignissim</a></h5>
                <span class="meta">July 16, 2016 by <a href="#">Abdus</a></span>
                <a href="BlogAciklama.aspx"><img src="img\home\articles\articles-04.jpg" alt="article-image"></a>
                <div class="caption">
                  <p>Suspendisse tristique interdum est, at hendrerit nunc laoreet et. Nulla vel arcu ac turpis pulvinar 
tincidunt eu eu nisi.</p>
                </div>
              </div>
            </div>--%>
          </div>
        </div>
      </section>
</asp:Content>
