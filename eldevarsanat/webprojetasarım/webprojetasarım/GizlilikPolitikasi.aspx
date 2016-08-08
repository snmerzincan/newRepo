<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="GizlilikPolitikasi.aspx.cs" Inherits="webprojetasarım.GizlilikPolitikasi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <!-- LIGHT SECTION -->
      <section class="lightSection clearfix pageHeader">
        <div class="container">
          <div class="row">
            <div class="col-xs-6">
              <div class="page-title">
                <h2>Gizlilik Politikası</h2>
              </div>
            </div>
            <div class="col-xs-6">
              <ol class="breadcrumb pull-right">
                <li>
                  <a href="index.htm">Anasayfa</a>
                </li>
                <li class="active">Gizlilik Politikası</li>
              </ol>
            </div>
          </div>
        </div>
      </section>
      
      <!-- MAIN CONTENT SECTION -->
      <section class="mainContent clearfix genricContent">
        <div class="container">
          <div class="row">
            <div class="col-xs-12">
             <%-- <h3>Some Title Should Be Here</h3>--%>
              <p>Girmiş olduğunuz kişisel bilgileriniz 3.şahıs ve kurumlarla kesinlikle paylaşılmayacaktır. Her türlü özel bilgi ve ödeme işlemleriniz 128 bit SSL güvenlik sertifikalarıyla şifrelenmektedir.</p>
            </div>
          </div>
        </div>
      </section>
</asp:Content>
