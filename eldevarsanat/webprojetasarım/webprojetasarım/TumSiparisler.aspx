<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="TumSiparisler.aspx.cs" Inherits="webprojetasarım.TumSiparisler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <!-- LIGHT SECTION -->
      <section class="lightSection clearfix pageHeader">
        <div class="container">
          <div class="row">
            <div class="col-xs-6">
              <div class="page-title">
                <h2>Tüm Siparişler</h2>
              </div>
            </div>
            <div class="col-xs-6">
              <ol class="breadcrumb pull-right">
                <li>
                  <a href="Anasayfa.aspx">Anasayfa</a>
                </li>
                <li class="active">Tüm Siparişler</li>
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
              <div class="innerWrapper">
                <div class="orderBox">
                  <h4>Tüm Siparişler</h4>
                  <div class="table-responsive">
                    <table class="table">
                      <thead>
                        <tr>
                          <th>Sipariş ID</th>
                          <th>Tarih</th>
                          <th>Adet</th>
                          <th>Toplam Tutar</th>
                          <th>Durum</th>
                          <th></th>
                        </tr>
                      </thead>
                      <tbody>
                        <tr>
                          <td>#451231</td>
                          <td>Mar 25, 2016</td>
                          <td>2</td>
                          <td>$99.00</td>
                          <td><span class="label label-primary">Processing</span></td>
                          <td><a href="SiparisOzeti.aspx" class="btn btn-default">Sipariş Özeti</a></td>
                        </tr>
                        <tr>
                          <td>#451231</td>
                          <td>Mar 25, 2016</td>
                          <td>3</td>
                          <td>$150.00</td>
                          <td><span class="label label-success">Completed</span></td>
                          <td><a href="SiparisOzeti.aspx" class="btn btn-default">Sipariş Özeti</a></td>
                        </tr>
                        <tr>
                          <td>#451231</td>
                          <td>Mar 25, 2016</td>
                          <td>3</td>
                          <td>$150.00</td>
                          <td><span class="label label-danger">Canceled</span></td>
                          <td><a href="SiparisOzeti.aspx" class="btn btn-default">Sipariş Özeti</a></td>
                        </tr>
                        <tr>
                          <td>#451231</td>
                          <td>Mar 25, 2016</td>
                          <td>2</td>
                          <td>$99.00</td>
                          <td><span class="label label-info">On Hold</span></td>
                          <td><a href="SiparisOzeti.aspx" class="btn btn-default">Sipariş Özeti</a></td>
                        </tr>
                        <tr>
                          <td>#451231</td>
                          <td>Mar 25, 2016</td>
                          <td>3</td>
                          <td>$150.00</td>
                          <td><span class="label label-warning">Pending</span></td>
                          <td><a href="SiparisOzeti.aspx" class="btn btn-default">Sipariş Özeti</a></td>
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
