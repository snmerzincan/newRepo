<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="SiparisOzeti.aspx.cs" Inherits="webprojetasarım.TekSiparis" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <!-- LIGHT SECTION -->
      <section class="lightSection clearfix pageHeader">
        <div class="container">
          <div class="row">
            <div class="col-xs-6">
              <div class="page-title">
                <h2>Siparişler</h2>
              </div>
            </div>
            <div class="col-xs-6">
              <ol class="breadcrumb pull-right">
                <li>
                  <a href="Anasayfa.aspx">Anasayfa</a>
                </li>
                <li class="active">Siparişler</li>
              </ol>
            </div>
          </div>
        </div>
      </section>
      
      <!-- MAIN CONTENT SECTION -->
      <section class="mainContent clearfix userProfile">
        <div class="container">
          <div class="row">
            <div class="col-xs-12">
              <div class="btn-group" role="group" aria-label="...">
                <a href="KontrolPaneli.aspx" class="btn btn-default"><i class="fa fa-th" aria-hidden="true"></i>Hesap Kontrol Paneli</a>
                <a href="Profil.aspx" class="btn btn-default"><i class="fa fa-user" aria-hidden="true"></i>Profil</a>
                <a href="Adres.aspx" class="btn btn-default"><i class="fa fa-map-marker" aria-hidden="true"></i>Adres</a>
                <a href="TumSiparisler.aspx" class="btn btn-default active"><i class="fa fa-list" aria-hidden="true"></i>Tüm Siparişler</a>
                <a href="SepeteEkle.aspx" class="btn btn-default"><i class="fa fa-gift" aria-hidden="true"></i>Sepet</a>
              </div>
            </div>
          </div>
          <div class="row">
            <div class="col-xs-12">
              <div class="innerWrapper singleOrder">
                <div class="orderBox">
                  <h4>Sipariş #451221</h4>
                </div>
                <div class="row">
                  <div class="col-sm-6 col-xs-12">
                    <div class="panel panel-default">
                      <div class="panel-heading">
                        <h4 class="panel-title">Fatura Adresi</h4>
                      </div>
                      <div class="panel-body">
                        <address>
                          <strong>Ali Güneş</strong><br>
                          Ataşehir
                        </address>
                      </div>
                    </div>
                  </div>
                  <div class="col-sm-6 col-xs-12">
                    <div class="panel panel-default">
                      <div class="panel-heading">
                        <h4 class="panel-title">Teslimat Adresi</h4>
                      </div>
                      <div class="panel-body">
                        <address>
                          <strong>Ali Güneş</strong><br>
                          Ataşehir
                        </address>
                      </div>
                    </div>
                  </div>
                  <div class="col-sm-6 col-xs-12">
                    <div class="panel panel-default">
                      <div class="panel-heading">
                        <h4 class="panel-title">Ödeme Şekli</h4>
                      </div>
                      <div class="panel-body">
                        <address>
                          <span>Kredi Kartı - VISA</span>
                        </address>
                      </div>
                    </div>
                  </div>
                  <div class="col-sm-6 col-xs-12">
                    <div class="panel panel-default">
                      <div class="panel-heading">
                        <h4 class="panel-title">Teslimat Şekli</h4>
                      </div>
                      <div class="panel-body">
                        <address>
                          <span>Kargo</span>
                        </address>
                      </div>
                    </div>
                  </div>
                  <div class="col-xs-12">
                    <div class="panel panel-default">
                      <div class="panel-heading">
                        <h4 class="panel-title">Sipariş Detayları</h4>
                      </div>
                      <div class="panel-body">
                        <div class="row">
                          <div class="col-sm-4 col-xs-12">
                            <address>
                              <a href="#">Email: aligunes@gmail.com</a> <br>
                              <span>Phone: +884 5452 6432</span>
                            </address>
                          </div>
                          <div class="col-sm-8 col-xs-12">
                            <address>
                              <span>Ek Bilgi </span><br>
                              <%--<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip</p>--%>
                            </address>
                          </div>
                        </div>
                      </div>
                    </div>
                  </div>
                  <div class="col-xs-12">
                    <div class="btn-group" role="group" aria-label="...">
                      <button type="button" class="btn btn-default">Yazdır</button>
                      <button type="button" class="btn btn-default">Siparişi İptal Et</button>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </section>
</asp:Content>
