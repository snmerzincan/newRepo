<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="404.aspx.cs" Inherits="webprojetasarım._404" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <!-- MAIN CONTENT SECTION -->
    <section class="mainContent clearfix notFound">
      <div class="container">
        <div class="row">
          <div class="col-md-6 col-md-offset-3 col-sm-10 col-sm-offset-1 col-xs-12">
            <a href="index.htm" class="navbar-brand pageLogo"><img src="img\logo.png" alt="logo"></a>
            <h1>404</h1>
            <h2>Sayfa Bulunamadı</h2>
            <div class="input-group">
              <input type="text" class="form-control" placeholder="Search again" aria-describedby="basic-addon2">
              <a href="#" class="input-group-addon" id="basic-addon2"><i class="fa fa-search"></i></a>
            </div>
            <a class="btn btn-default" href="index.htm" role="button">Geri</a>
          </div>
        </div>
      </div>
    </section>
</asp:Content>
