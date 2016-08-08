<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="SifremiUnuttum.aspx.cs" Inherits="webprojetasarım.SifremiUnuttumaspx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- LIGHT SECTION -->
      <section class="lightSection clearfix pageHeader">
        <div class="container">
          <div class="row">
            <div class="col-xs-6">
              <div class="page-title">
                <h2>Şifremi Unuttum</h2>
              </div>
            </div>
            <div class="col-xs-6">
              <ol class="breadcrumb pull-right">
                <li>
                  <a href="Anasayfa.aspx">Anasayfa</a>
                </li>
                <li class="active">Şifrenizi Yenileyin</li>
              </ol>
            </div>
          </div>
        </div>
      </section>
      
      <!-- MAIN CONTENT SECTION -->
      <section class="mainContent clearfix lostPassword">
        <div class="container">
          <div class="row">
            <div class="col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2 col-xs-12">
              <div class="panel panel-default">
                <div class="panel-heading"><h3>Şifrenizi Yenileyin</h3></div>
                <div class="panel-body">
                  <form action="" method="POST" role="form">
                    <p class="help-block">Üyeliğinize ait e-posta adresinizi girin.</p>
                    <div class="form-group">
                      <label for="">E-Posta Adresiniz</label>
                      <input type="email" class="form-control" id="">
                    </div>
                    <button type="submit" class="btn btn-primary btn-block">Gönder</button>
                  </form>
                </div>
              </div>
            </div>
          </div>
        </div>
      </section>
</asp:Content>
