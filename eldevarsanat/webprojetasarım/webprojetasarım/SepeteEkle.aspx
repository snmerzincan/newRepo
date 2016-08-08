<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="SepeteEkle.aspx.cs" Inherits="webprojetasarım.WishList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <!-- LIGHT SECTION -->
      <section class="lightSection clearfix pageHeader">
        <div class="container">
          <div class="row">
            <div class="col-xs-6">
              <div class="page-title">
                <h2>Sepet</h2>
              </div>
            </div>
            <div class="col-xs-6">
              <ol class="breadcrumb pull-right">
                <li>
                  <a href="Anasayfa.htm">Anasayfa</a>
                </li>
                <li class="active">Sepet</li>
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
                <a href="TumSiparisler.aspx" class="btn btn-default"><i class="fa fa-list" aria-hidden="true"></i>Tüm Siparişler</a>
                <a href="SepeteEkle.aspx" class="btn btn-default active"><i class="fa fa-gift" aria-hidden="true"></i>Sepet</a>
              </div>
            </div>
          </div>
          <div class="row">
            <div class="col-xs-12">
              <div class="innerWrapper">
                <div class="orderBox myAddress wishList">
                  <h4>Sepet</h4>
                  <div class="table-responsive">
                    <table class="table">
                      <thead>
                        <tr>
                          <th></th>
                          <th>Ürün İsmi</th>
                          <th>Fiyat</th>
                          <th>Stok</th>
                          <th></th>
                        </tr>
                      </thead>
                      <tbody>
                        <tr>
                          <td class="col-md-2 col-sm-3">
                            <button type="button" class="close" data-dismiss="alert" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                            <span class="cartImage"><img src="img\products\cart-image.jpg" alt="image"></span>
                          </td>
                          <td>Italian Winter Hat</td>
                          <td>$ 99.00</td>
                          <td>In Stock</td>
                          <td>
                            <a class="btn btn-default" href="Kart.aspx">Sepete Ekle</a>
                          </td>
                        </tr>
                        <tr>
                          <td class="col-md-2 col-sm-3">
                            <button type="button" class="close" data-dismiss="alert" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                            <span class="cartImage"><img src="img\products\cart-image.jpg" alt="image"></span>
                          </td>
                          <td>Italian Winter Hat</td>
                          <td>$ 99.00</td>
                          <td>In Stock</td>
                          <td>
                            <a class="btn btn-default" href="Kart.aspx">Sepete Ekle</a>
                          </td>
                        </tr>
                        <tr>
                          <td class="col-md-2 col-sm-3">
                            <button type="button" class="close" data-dismiss="alert" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                            <span class="cartImage"><img src="img\products\cart-image.jpg" alt="image"></span>
                          </td>
                          <td>Italian Winter Hat</td>
                          <td>$ 99.00</td>
                          <td>In Stock</td>
                          <td>
                            <a class="btn btn-default" href="Kart.aspx">Sepete Ekle</a>
                          </td>
                        </tr>
                      </tbody>
                    </table>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </section>
</asp:Content>
