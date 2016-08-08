<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Hakkimizda.aspx.cs" Inherits="webprojetasarım.Hakkında" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <!-- LIGHT SECTION -->
      <section class="lightSection clearfix pageHeader">
        <div class="container">
          <div class="row">
            <div class="col-xs-6">
              <div class="page-title">
                <h2>Hakkımızda</h2>
              </div>
            </div>
            <div class="col-xs-6">
              <ol class="breadcrumb pull-right">
                <li>
                  <a href="index.htm">Anasayfa</a>
                </li>
                <li class="active">Hakkımızda</li>
              </ol>
            </div>
          </div>
        </div>
      </section>
      
      <!-- MAIN CONTENT SECTION -->
      <section class="mainContent clearfix aboutUsInfo">
        <div class="container">
          <div class="row">
            <div class="col-xs-12">
              <div class="page-header">
                <h3>SE'TEK Mağazacılık ve İnternet Hizmetleri A.Ş</h3>
              </div>
            </div>
            <div class="col-sm-6 col-sm-push-6 col-xs-12">
              <img src="img\about-us\title-img.jpg" alt="about-us-img">
            </div>
            <div class="col-sm-6 col-sm-pull-6 col-xs-12">
              <p class="lead">Türkiye'yi güvenli ve hızlı e-ticaret ile buluşturuyoruz. </p>
              <ul class="list-unstyled">
                <li>2016 yılında www.eldevarsanat.com SE'TEK A.Ş. isimli şirketimiz kurulmuştur. En başta müşteri memnuniyetini en üst noktada tutmayı bir yaşam ilkesi olarak gören SE'TEK A.Ş. olarak diğer en büyük özelliğimiz rekabetçi hizmet ve fiyat avantajını bir arada toplamak ve tecrübemizi siz müşterilerimizle buluşturmayı amaçlamaktır. 

eldevarsanat.com olarak bir şirketin geleceğinin siz müşterilerimizin elinde olduğunun bilincindeyiz. Bu nedenle müşteri memnuniyetini en önemli etken olarak düşünmekteyiz. eldevarsanat.com'un sunduğu kaliteli ürünler ve hizmetler ile müşterilerimiz için yeni bir sektörü ve yeni bir yaşam tecrübesini iyileştirmeye çalışmaktayız. </li> 
              </ul>
            </div>
          </div>
        </div>
      </section>
      
      <!-- DARK SECTION -->
      <section class="darkSection clearfix">
        <%--<div class="container">
          <div class="row">
            <div class="col-xs-12">
              <h3>Our Store Locations</h3>
            </div>
            <div class="col-md-3 col-sm-6 col-xs-12">
              <div class="thumbnail">
                <div class="caption">
                  <h5>New York</h5>
                  <address>
                    Krakovská 1307/22, 110 00 N,Y <br>
                    Vězeňská 910/2, 110 00 N,Y-Staré  <br>
                    Město Na Hřebenkách 2, 150 00  <br>
                    N,Y
                  </address>
                </div>
              </div>
            </div>
            <div class="col-md-3 col-sm-6 col-xs-12">
              <div class="thumbnail">
                <div class="caption">
                  <h5>Paris</h5>
                  <address>
                    Bebelpl. 1, 10117 Paris <br>
                    Jablonskistraße 16, 10405 Paris <br>
                    Rigaer Str. 9, 10247 Paris
                  </address>
                </div>
              </div>
            </div>
            <div class="col-md-3 col-sm-6 col-xs-12">
              <div class="thumbnail">
                <div class="caption">
                  <h5>New York</h5>
                  <address>
                    Krakovská 1307/22, 110 00 N,Y <br>
                    Vězeňská 910/2, 110 00 N,Y-Staré  <br>
                    Město Na Hřebenkách 2, 150 00  <br>
                    N,Y
                  </address>
                </div>
              </div>
            </div>
            <div class="col-md-3 col-sm-6 col-xs-12">
              <div class="thumbnail">
                <div class="caption">
                  <h5>Paris</h5>
                  <address>
                    Bebelpl. 1, 10117 Paris <br>
                    Jablonskistraße 16, 10405 Paris <br>
                    Rigaer Str. 9, 10247 Paris
                  </address>
                </div>
              </div>
            </div>
            <div class="col-xs-12">
              <button type="button" class="btn btn-default">Check more</button>
            </div>
          </div>
        </div>--%>
      </section>

      <!-- WHITE SECTION -->
      <section class="whiteSection clearfix aboutPeople">
        <div class="container">
          <div class="row">
            <div class="col-xs-12">
              <h3>Yönetim</h3>
            </div>
            <div class="col-sm-3 col-xs-12">
              <div class="thumbnail">
                <img src="img\about-us\people-01.jpg" alt="people-image">
                <div class="caption">
                  <h5>Tuğrul Emre KILIÇ</h5>
                  <p>(CEO)</p>
                </div>
              </div>
            </div>
            <div class="col-sm-3 col-xs-12">
              <div class="thumbnail">
                <img src="img\about-us\people-02.jpg" alt="people-image">
                <div class="caption">
                  <h5>Sinem ERZİNCAN</h5>
                  <p>(CTO)</p>
                </div>
              </div>
            </div>
          </div>
        </div>
      </section>
</asp:Content>
