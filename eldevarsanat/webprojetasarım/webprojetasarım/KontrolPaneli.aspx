<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="KontrolPaneli.aspx.cs" Inherits="webprojetasarım.KontrolPaneli" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- LIGHT SECTION -->
      <section class="lightSection clearfix pageHeader">
        <div class="container">
          <div class="row">
            <div class="col-xs-6">
              <div class="page-title">
                <h2>Hesap Kontrol Paneli</h2>
              </div>
            </div>
            <div class="col-xs-6">
              <ol class="breadcrumb pull-right">
                <li>
                  <a href="index.htm">Anasayfa</a>
                </li>
                <li class="active">Hesap Kontrol Paneli</li>
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
                <a href="KontrolPaneli.aspx" class="btn btn-default active"><i class="fa fa-th" aria-hidden="true"></i>Hesap Kontrol Paneli</a>
                <a href="Profil.aspx" class="btn btn-default"><i class="fa fa-user" aria-hidden="true"></i>Profil</a>
                <a href="Adres.aspx" class="btn btn-default"><i class="fa fa-map-marker" aria-hidden="true"></i>Adres</a>
                <a href="TumSiparisler.aspx" class="btn btn-default"><i class="fa fa-list" aria-hidden="true"></i>Tüm Siparişler</a>
                <a href="SepeteEkle.aspx" class="btn btn-default"><i class="fa fa-gift" aria-hidden="true"></i>Sepet</a>
              </div>
            </div>
          </div>
          <div class="row">
            <div class="col-xs-12">
              <div class="innerWrapper">
                <div class="alert alert-warning alert-dismissible" role="alert">
                  <button type="button" class="close" data-dismiss="alert" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                  <strong>Uyarı</strong> Ödenmemiş bir siparişin var
                </div>
                <h3>Hoşgeldiniz <span>Adam Smith</span></h3>
                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</p>
                <ul class="list-inline">
                  <li><a href="Profil.aspx" class="btn btn-default btn-lg"><i class="fa fa-user" aria-hidden="true"></i>Profil</a></li>
                  <li><a href="Adres.aspx" class="btn btn-default btn-lg"><i class="fa fa-map-marker" aria-hidden="true"></i>Adres</a></li>
                  <li><a href="TumSiparisler.aspx" class="btn btn-default btn-lg"><i class="fa fa-list" aria-hidden="true"></i>Tüm Siparişler</a></li>
                  <li><a href="SepeteEkle.aspx" class="btn btn-default btn-lg"><i class="fa fa-gift" aria-hidden="true"></i>Sepet</a></li>
                  <%--<li><a href="#" class="btn btn-default btn-lg"><i class="fa fa-plus-circle" aria-hidden="true"></i>Yeni Adres</a></li>--%>
                </ul>
                <div class="orderBox">
                  <h4>Siparişler</h4>
                  <div class="table-responsive">
                    <table class="table">
                      <thead>
                        <tr>
                          <th>Sipariş ID</th>
                          <th>Tarih</th>
                          <th>Adet</th>
                          <th>Toplam Tutar</th>
                          <th></th>
                        </tr>
                      </thead>
                      <tbody>
                        <tr>
                          <td>#252125</td>
                          <td>Mar 25, 2016</td>
                          <td>2</td>
                          <td>$ 99.00</td>
                          <td><a href="Sepet.aspx" class="btn btn-default">Öde</a></td>
                        </tr>
                      </tbody>
                    </table>
                  </div>
                </div>
                <%--<div class="orderBox">
                  <h4>Pending Warranty Claims</h4>
                  <div class="table-responsive">
                    <table class="table">
                      <thead>
                        <tr>
                           <th>Sipariş ID</th>
                          <th>Tarih</th>
                          <th>Ürün</th>
                          <th>Toplam Tutar</th>
                          <th></th>
                        </tr>
                      </thead>
                      <tbody>
                        <tr>
                          <td>#252125</td>
                          <td>Mar 25, 2016</td>
                          <td>Z - 45263</td>
                          <td>Lorem ipsum doler</td>
                          <td><a href="#" class="btn btn-default">View</a></td>
                        </tr>
                      </tbody>
                    </table>
                  </div>
                </div>--%>
              </div>
            </div>
          </div>
        </div>
      </section>
</asp:Content>
