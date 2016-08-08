<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Profil.aspx.cs" Inherits="webprojetasarım.Profil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- LIGHT SECTION -->
      <section class="lightSection clearfix pageHeader">
        <div class="container">
          <div class="row">
            <div class="col-xs-6">
              <div class="page-title">
                <h2>Profil</h2>
              </div>
            </div>
            <div class="col-xs-6">
              <ol class="breadcrumb pull-right">
                <li>
                  <a href="Anasayfa.aspx">Anasayfa</a>
                </li>
                <li class="active">Profil</li>
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
                <a href="Profil.aspx" class="btn btn-default active"><i class="fa fa-user" aria-hidden="true"></i>Profil</a>
                <a href="Adres.aspx" class="btn btn-default"><i class="fa fa-map-marker" aria-hidden="true"></i>Adres</a>
                <a href="TumSiparisler.aspx" class="btn btn-default"><i class="fa fa-list" aria-hidden="true"></i>Tüm Siparişler</a>
                <a href="SepeteEkle.aspx" class="btn btn-default"><i class="fa fa-gift" aria-hidden="true"></i>Sepet</a>
              </div>
            </div>
          </div>
          <div class="row">
            <div class="col-xs-12">
              <div class="innerWrapper profile">
                <div class="orderBox">
                  <h4>Profil</h4>
                </div>
                <div class="row">
                  <div class="col-md-2 col-sm-3 col-xs-12">
                    <div class="thumbnail">
                      <img src="img\products\profile\profile-image.jpg" alt="profile-image">
                      <div class="caption">
                        <a href="#" class="btn btn-primary btn-block" role="button">Resmi Değiştir</a>  
                      </div>
                    </div>
                  </div>
                  <div class="col-md-10 col-sm-9 col-xs-12">
                      <form class="form-horizontal">
                        <div class="form-group">
                          <label for="" class="col-md-2 col-sm-3 control-label">İsim</label>
                          <div class="col-md-10 col-sm-9">
                            <input type="text" class="form-control" id="" placeholder=""><br />
                          </div>
                        </div>
                        <div class="form-group">
                          <label for="" class="col-md-2 col-sm-3 control-label">Soyisim</label>
                          <div class="col-md-10 col-sm-9">
                            <input type="text" class="form-control" id="" placeholder=""><br />
                          </div>
                        </div>
                        <div class="form-group">
                          <label for="" class="col-md-2 col-sm-3 control-label">Telefon Numarası</label>
                          <div class="col-md-10 col-sm-9">
                            <input type="text" class="form-control" id="" placeholder=""><br />
                          </div>
                        </div>
                        <div class="form-group">
                          <label for="" class="col-md-2 col-sm-3 control-label">E-Posta Adresi</label>
                          <div class="col-md-10 col-sm-9">
                            <input type="email" class="form-control" id="" placeholder=""><br />
                          </div>
                        </div>
                        <div class="form-group">
                          <label for="" class="col-md-2 col-sm-3 control-label">Şifre</label>
                          <div class="col-md-10 col-sm-9">
                            <input type="password" class="form-control" id="" placeholder=""><br />
                          </div>
                        </div>
                        <div class="form-group">
                          <label for="" class="col-md-2 col-sm-3 control-label">Yeni Şifre</label>
                          <div class="col-md-10 col-sm-9">
                            <input type="password" class="form-control" id="" placeholder=""><br />
                          </div>
                        </div>
                        <div class="form-group">
                          <div class="col-md-offset-10 col-md-2 col-sm-offset-9 col-sm-3">
                            <button type="submit" class="btn btn-primary btn-block">Kaydet</button><br />
                          </div>
                        </div>
                      </form>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </section>
      
</asp:Content>
