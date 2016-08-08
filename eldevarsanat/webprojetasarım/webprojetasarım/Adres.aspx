<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Adres.aspx.cs" Inherits="webprojetasarım.Adres" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- LIGHT SECTION -->
      <section class="lightSection clearfix pageHeader">
        <div class="container">
          <div class="row">
            <div class="col-xs-6">
              <div class="page-title">
                <h2>Adres</h2>
              </div>
            </div>
            <div class="col-xs-6">
              <ol class="breadcrumb pull-right">
                <li>
                  <a href="Anasayfa.aspx">Anasayfa</a>
                </li>
                <li class="active">Adres</li>
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
                <a href="Adres.aspx" class="btn btn-default active"><i class="fa fa-map-marker" aria-hidden="true"></i>Adres</a>
                <a href="TumSiparisler.aspx" class="btn btn-default"><i class="fa fa-list" aria-hidden="true"></i>Tüm Siparişler</a>
                <a href="SepeteEkle.aspx" class="btn btn-default"><i class="fa fa-gift" aria-hidden="true"></i>Sepet</a>
              </div>
            </div>
          </div>
          <div class="row">
            <div class="col-xs-12">
              <div class="innerWrapper">
                <div class="orderBox myAddress">
                  <h4>Adres</h4>
                  <div class="table-responsive">
                    <table class="table">
                      <thead>
                        <tr>
                          <th>Şirket</th>
                          <th>İsim</th>
                          <th>Adres</th>
                          <th>Ülke</th>
                          <th class="col-md-2 col-sm-3">Telefon</th>
                          <th></th>
                        </tr>
                      </thead>
                      <tbody>
                        <tr>
                          <td>Nokia</td>
                          <td>Adam Smith</td>
                          <td>9/4 C Babor Road, Mohammad Pur, Dhaka</td>
                          <td>Bangladesh</td>
                          <td>+884 5452 6452</td>
                          <td>
                            <div class="btn-group" role="group">
                              <button type="button" class="btn btn-default"><i class="fa fa-pencil" aria-hidden="true"></i></button>
                              <button type="button" class="btn btn-default"><i class="fa fa-times" aria-hidden="true"></i></button>
                            </div>
                          </td>
                        </tr>
                        <tr>
                          <td>Samsung</td>
                          <td>Adam Smith</td>
                          <td>9/4 C Babor Road, Mohammad Pur, Dhaka</td>
                          <td>Bangladesh</td>
                          <td>+884 5452 6452</td>
                          <td>
                            <div class="btn-group" role="group">
                              <button type="button" class="btn btn-default"><i class="fa fa-pencil" aria-hidden="true"></i></button>
                              <button type="button" class="btn btn-default"><i class="fa fa-times" aria-hidden="true"></i></button>
                            </div>
                          </td>
                        </tr>
                        <tr>
                          <td>Motorola</td>
                          <td>Adam Smith</td>
                          <td>9/4 C Babor Road, Mohammad Pur, Dhaka</td>
                          <td>Bangladesh</td>
                          <td>+884 5452 6452</td>
                          <td>
                            <div class="btn-group" role="group">
                              <button type="button" class="btn btn-default"><i class="fa fa-pencil" aria-hidden="true"></i></button>
                              <button type="button" class="btn btn-default"><i class="fa fa-times" aria-hidden="true"></i></button>
                            </div>
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
