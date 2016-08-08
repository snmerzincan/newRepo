<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="TamamlananSiparis.aspx.cs" Inherits="webprojetasarım.TamamlananSiparis" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <!-- LIGHT SECTION -->
      <section class="lightSection clearfix pageHeader">
        <div class="container">
          <div class="row">
            <div class="col-xs-6">
              <div class="page-title">
                <h2>Teşekkürler</h2>
              </div>
            </div>
            <div class="col-xs-6">
              <ol class="breadcrumb pull-right">
                <li>
                  <a href="Anasayfa.aspx">Anasayfa</a>
                </li>
              <%--  <li class="active">Teşekkürler</li>--%>
              </ol>
            </div>
          </div>
        </div>
      </section>
      
      <!-- MAIN CONTENT SECTION -->
      <section class="mainContent clearfix setp5">
        <div class="container">
          <div class="row">
            <div class="col-xs-12">
              <div class="thanksContent">
                <h2>Siparişiniz için Teşekkürler <small>Siparişiniz ile ilgili bir e-posta alacaksınız</small></h2>
              <%--  <h3>Teslimat Detayı</h3>
                <div class="thanksInner">
                  <div class="row">
                    <div class="col-sm-6 col-xs-12 tableBlcok">
                      <address>
                        <span>Teslimat Adresi:</span> <a href="mailto:adamsmith@bigbag.com">adamsmith@bigbag.com</a> <br>
                        <span>E-Posta:</span> <a href="mailto:adamsmith@bigbag.com">adamsmith@bigbag.com</a> <br>
                        <span>Telefon Numarası:</span> +884 5452 6432
                      </address>
                    </div>
                    <div class="col-sm-6 col-xs-12">
                      <div class="well">
                        <h2><small>Sipariş ID</small>9547</h2>
                      </div>
                    </div>
                  </div>
                </div>--%>
              </div>
            </div>
          </div>
        </div>
         <%--  &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Button Font-Bold="true" Text="Çıkış Yap" ID="btnAlisveris" class="btn btn-default" runat="server" BackColor="#6ab5b5" ForeColor="White" Width="150px" Height="40px" OnClick="btnAlisveris_Click"/><i class="fa fa-shopping-cart"></i>--%>
      </section>
      
</asp:Content>
