<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdresDuzenle.aspx.cs" Inherits="webprojetasarım.AdresDuzenle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- LIGHT SECTION -->
      <section class="lightSection clearfix pageHeader">
        <div class="container">
          <div class="row">
            <div class="col-xs-6">
              <div class="page-title">
                <h2>Adres Güncelleme</h2>
              </div>
            </div>
            <div class="col-xs-6">
              <ol class="breadcrumb pull-right">
                <li>
                  <a href="index.htm">Anasayfa</a>
                </li>
                <li class="active">Güncelleme</li>
              </ol>
            </div>
          </div>
        </div>
      </section>
      
     <!-- MAIN CONTENT SECTION -->
      <section class="mainContent clearfix logIn">
        <div class="container">
          <div class="row">
            <div class="col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2 col-xs-12">
              <div class="panel panel-default">
                <div class="panel-heading"><h3>Adres Güncelleme</h3></div>
                <div class="panel-body">
                  <form action="" method="POST" role="form">
                    <div class="form-group">
                      <label for="">Şirket</label>
                      <input type="sirket" class="form-control" id="">
                    </div>
                    <div class="form-group">
                      <label for="">İsim</label>
                      <input type="isim" class="form-control" id="">
                    </div>
                      <div class="form-group">
                      <label for="">Adres</label>
                      <input type="adres" class="form-control" id="">
                    </div>
                      <div class="form-group">
                      <label for="">Ülke</label>
                      <input type="ulke" class="form-control" id="">
                    </div>
                      <div class="form-group">
                      <label for="">Telefon</label>
                      <input type="telefon" class="form-control" id="">
                    </div>
                    <button type="submit" class="btn btn-primary btn-block"><a href="Adres.aspx">Güncelle</button>
                   
                  </form>
                </div>
              </div>
            </div>
          </div>
        </div>
      </section>
</asp:Content>
