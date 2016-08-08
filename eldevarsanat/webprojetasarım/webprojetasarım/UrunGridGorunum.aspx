<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="UrunGridGorunum.aspx.cs" Inherits="webprojetasarım.UrunGridGorunum" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- LIGHT SECTION -->
    <section class="lightSection clearfix pageHeader">
        <div class="container">
            <div class="row">
                <div class="col-xs-6">
                    <div class="page-title">
                        <h2>Ürünler</h2>
                    </div>
                </div>
                <div class="col-xs-6">
                    <ol class="breadcrumb pull-right">
                        <li>
                            <a href="Anasayfa.aspx">Anasayfa</a>
                        </li>
                        <li>
                            <a href="#">Ürünler</a>
                        </li>
                        <li class="active">Grid Görünüm</li>
                    </ol>
                </div>
            </div>
        </div>
    </section>

    <!-- MAIN CONTENT SECTION -->
    <section class="mainContent clearfix productsContent">
        <div class="container">
            <div class="row">
                <div class="col-md-3 col-sm-4 col-xs-12 sideBar">
                    <div class="panel panel-default">
                        <div class="panel-heading">Kategoriler</div>
                        <div class="panel-body">
                            <div class="collapse navbar-collapse navbar-ex1-collapse navbar-side-collapse">
                                <ul class="nav navbar-nav side-nav">
                                    <li>
                                        <a href="javascript:;" data-toggle="collapse" data-target="#women">Ev Aksesuarları <i class="fa fa-plus"></i></a>
                                        <ul id="women" class="collapse collapseItem">
                                            <li><a href="#"><i class="fa fa-caret-right" aria-hidden="true"></i>Kokulutaş<span></a></li>
                                            <li><a href="#"><i class="fa fa-caret-right" aria-hidden="true"></i>Mini Mumlar<span>(6)</span></a></li>
                                            <li><a href="#"><i class="fa fa-caret-right" aria-hidden="true"></i>Kapı Süsü<span>(25)</span></a></li>

                                        </ul>
                                    </li>
                                    <li>
                                        <a href="javascript:;" data-toggle="collapse" data-target="#men">Düğün,Nişan,Kına <i class="fa fa-plus"></i></a>
                                        <ul id="men" class="collapse collapseItem">
                                            <li><a href="#"><i class="fa fa-caret-right" aria-hidden="true"></i>Nikah Şekeri<span></a></li>
                                            <li><a href="#"><i class="fa fa-caret-right" aria-hidden="true"></i>Kına Aynası<span>(6)</span></a></li>
                                            <li><a href="#"><i class="fa fa-caret-right" aria-hidden="true"></i>Söz Tepsisi<span>(25)</span></a></li>
                                        </ul>
                                    </li>
                                    <li>
                                        <a href="javascript:;" data-toggle="collapse" data-target="#kids">Hediyelik <i class="fa fa-plus"></i></a>
                                        <ul id="kids" class="collapse collapseItem">
                                            <li><a href="#"><i class="fa fa-caret-right" aria-hidden="true"></i>Anı Defteri ve Kalemi<span></a></li>
                                            <li><a href="#"><i class="fa fa-caret-right" aria-hidden="true"></i>Magnetler<span></span></a></li>
                                            <li><a href="#"><i class="fa fa-caret-right" aria-hidden="true"></i>İsimlik<span>(25)</span></a></li>
                                        </ul>
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>
                    <%--<div class="panel panel-default priceRange">
               <div class="panel-heading">Fiyat</div>
                <div class="panel-body clearfix">
                  <div class="price-slider-inner"> 
                    <span class="amount-wrapper">
                      Price:
                      <input type="text" id="price-amount-1" readonly="">
                      <strong>-</strong>
                      <input type="text" id="price-amount-2" readonly=""> 
                    </span>                                            
                    <div id="price-range"></div>  
                  </div>
                  <input class="btn btn-default" type="submit" value="Ara">
                  <!-- <span class="priceLabel">Price: <strong>$12 - $30</strong></span> -->
                </div>
              </div>--%>
                   <%-- <div class="panel panel-default filterNormal">
                        <div class="panel-heading">Renk</div>
                        <div class="panel-body">
                            <ul class="list-unstyled">
                                <li><a href="#">Black<span>(15)</span></a></li>
                                <li><a href="#">White<span>(10)</span></a></li>
                                <li><a href="#">Red<span>(7)</span></a></li>
                                <li><a href="#">Blue<span>(12)</span></a></li>
                                <li><a href="#">Orange<span>(12)</span></a></li>
                            </ul>
                        </div>
                    </div>--%>
                    <%--   <div class="panel panel-default filterNormal">
                <div class="panel-heading">Beden</div>
                <div class="panel-body">
                  <ul class="list-unstyled clearfix">
                    <li><a href="#">Small<span>(15)</span></a></li>
                    <li><a href="#">Medium<span>(10)</span></a></li>
                    <li><a href="#">Large<span>(7)</span></a></li>
                    <li><a href="#">Extra Large<span>(12)</span></a></li>
                  </ul>
                </div>
              </div>--%>
                </div>
                 <div class="col-md-9 col-sm-8 col-xs-12">
                <div class="row filterArea">
                    <div class="col-xs-6">
                        <select name="guiest_id1" id="guiest_id1" class="select-drop">
                                <option value="0">Ev Aksesuarları</option>
                                <option value="1">Düğün,Nişan,Kına Organizasyon</option>
                                <option value="2">Hediyelik Tasarımlar</option>
                            </select>-
                        <%-- <asp:DropDownList ID="ddlUrunKategorileri" DataTextField="<%#Eval("KategoriAd") %>" DataValueField="<%#Eval("KategoriID") %>" AutoPostBack="True" runat="server"></asp:DropDownList>--%>
                    </div>
                    <div class="col-xs-6">
                        <div class="btn-group pull-right" role="group">
                            <button type="button" class="btn btn-default active" onclick="window.location.href='UrunListGorunum.aspx'"><i class="fa fa-th" aria-hidden="true"></i><span>Grid</span></button>
                            <%-- <button type="button" class="btn btn-default" onclick="window.location.href='UrunListGorunum.aspx'"><i class="fa fa-th-list" aria-hidden="true"></i><span>List</span></button>--%>
                        </div>
                    </div>
                </div>

                <%-- <div class="row">
                        <%--Ürün Bilgileri--%>
                <%--  <asp:Repeater ID="rptUrunler" runat="server">
                            <ItemTemplate>
                            <div class="col-sm-4 col-xs-12">
                                <div class="productBox">
                                    <div class="productImage clearfix">
                                        <img src='<%#Eval("ResimYolu1") %>' width="80px" height="230px">
                                        <div class="productMasking">
                                            <ul class="list-inline btn-group" role="group">
                                                <li><asp:LinkButton data-toggle="modal" ID="LinkButton1" href="Login.aspx" class="btn btn-default" runat="server"><i class="fa fa-heart"></i></asp:LinkButton></li>
                                                <%--<li><a data-toggle="modal" href="Login.aspx" class="btn btn-default"></a></li>
                                                <li><a href="Kart.aspx" class="btn btn-default"><i class="fa fa-shopping-cart"></i></a></li>
                                                <li><a class="btn btn-default" data-toggle="modal" href=".quick-view"><i class="fa fa-eye"></i></a></li>
                                            </ul>
                                            <a href="Sepet.aspx">
                                                <asp:Button Text="Sepete Ekle"  class="btn btn-default"  runat="server" /></a>
                                        </div>
                                    </div>
                                    <div class="productCaption clearfix">
                                        <a href="UrunDetayi.aspx">
                                            <h5><%#Eval("UrunAd") %></h5>
                                        </a>
                                        <h3><%#Eval("Fiyat", "{0:C}") %></h3>
                                    </div>
                                </div>
                            </div>
                                </ItemTemplate>
                        </asp:Repeater>--%>

                <asp:DataList ID="dtUrunler" ForeColor="#333333" DataKeyField="UrunID" CellSpacing="2" RepeatColumns="3" Width="700px" Style="text-align: center" runat="server" OnItemCommand="dtUrunler_ItemCommand">
                    <ItemTemplate>
                        <%--<div class="col-sm-4 col-xs-12">--%>
                        <div class="productBox">
                            <div class="productImage clearfix">
                                <asp:ImageButton ID="imgresim" ImageUrl='<%#Eval("ResimYolu1")%>' runat="server" CommandName="UrunDetayi" CommandArgument='<%#Eval("UrunID")%>' Width="228px" Height="228px" />

                                <br>

                                </br>
                                        <asp:Label ID="lblurunad" data-toggle="modal" runat="server" Text='<%# Eval("UrunAd") %>'></asp:Label>
                                <br>
                                </br>
                                        
                                        <asp:Label Font-Size="10px" ID="lblurunfiyat" runat="server" data-toggle="modal" Text='<%# Eval("Fiyat","{0:N}") %>'></asp:Label>
                                <br>
                                </br>
                                       
                                        <asp:TextBox ID="txtAdet" runat="server" Text="1" Width="20"></asp:TextBox>
                                <br>
                                </br>
                                        <br>
                                        </br>
                                       <%-- <asp:ImageButton ID="btnsepeteat" runat="server" CommandArgument='<%#Eval("UrunID")%>' CommandName="Sepet" Text="Sepete Ekle" />--%>
                                <asp:Button Text="Sepete Ekle" ID="btnSepeteEkle" class="btn btn-default"  CommandArgument='<%# Eval("UrunID") %>' CommandName="SepetEkle" runat="server" BackColor="#6ab5b5" ForeColor="White" Width="130px" Height="40px" /><i class="fa fa-shopping-cart"></i>
                                <br>
                                </br>
                                        <br>
                                        </br>
                                        
                            </div>
                        </div>
                        <%--</div>--%>
                    </ItemTemplate>

                </asp:DataList>

                <%-- <div class="col-sm-4 col-xs-12">
                  <div class="productBox">
                    <div class="productImage clearfix">
                      <img src="img\products\products-02.jpg" alt="products-img">
                      <div class="productMasking">
                        <ul class="list-inline btn-group" role="group">
                          <li><a data-toggle="modal" href=".login-modal" class="btn btn-default"><i class="fa fa-heart"></i></a></li>
                          <li><a href="Kart.aspt" class="btn btn-default"><i class="fa fa-shopping-cart"></i></a></li>
                          <li><a class="btn btn-default" data-toggle="modal" href=".quick-view"><i class="fa fa-eye"></i></a></li>
                        </ul>
                      </div>
                    </div>
                    <div class="productCaption clearfix">
                      <a href="UrunDetayi.aspx"><h5>Dip Dyed Sweater</h5> </a>
                      <h3>$249</h3>
                    </div>
                  </div>
                </div>
                <div class="col-sm-4 col-xs-12">
                  <div class="productBox">
                    <div class="productImage clearfix">
                      <img src="img\products\products-03.jpg" alt="products-img">
                      <div class="productMasking">
                        <ul class="list-inline btn-group" role="group">
                          <li><a data-toggle="modal" href=".login-modal" class="btn btn-default"><i class="fa fa-heart"></i></a></li>
                          <li><a href="Kart.aspx" class="btn btn-default"><i class="fa fa-shopping-cart"></i></a></li>
                          <li><a class="btn btn-default" data-toggle="modal" href=".quick-view"><i class="fa fa-eye"></i></a></li>
                        </ul>
                      </div>
                    </div>
                    <div class="productCaption clearfix">
                      <a href="UrunDetayi.aspx"><h5>Scarf Ring Corner</h5></a>
                      <h3>$179</h3>
                    </div>
                  </div>
                </div>
                <div class="col-sm-4 col-xs-12">
                  <div class="productBox">
                    <div class="productImage clearfix">
                      <img src="img\products\products-04.jpg" alt="products-img">
                      <div class="productMasking">
                        <ul class="list-inline btn-group" role="group">
                          <li><a data-toggle="modal" href=".login-modal" class="btn btn-default"><i class="fa fa-heart"></i></a></li>
                          <li><a href="Kart.aspx" class="btn btn-default"><i class="fa fa-shopping-cart"></i></a></li>
                          <li><a class="btn btn-default" data-toggle="modal" href=".quick-view"><i class="fa fa-eye"></i></a></li>
                        </ul>
                      </div>
                    </div>
                    <div class="productCaption clearfix">
                      <a href="UrunDetayi.aspx"><h5>Sun Buddies</h5></a>
                      <h3>$149</h3>
                    </div>
                  </div>
                </div>
                <div class="col-sm-4 col-xs-12">
                  <div class="productBox">
                    <div class="productImage clearfix">
                      <img src="img\products\products-05.jpg" alt="products-img">
                      <div class="productMasking">
                        <ul class="list-inline btn-group" role="group">
                          <li><a data-toggle="modal" href=".login-modal" class="btn btn-default"><i class="fa fa-heart"></i></a></li>
                          <li><a href="Kart.aspx" class="btn btn-default"><i class="fa fa-shopping-cart"></i></a></li>
                          <li><a class="btn btn-default" data-toggle="modal" href=".quick-view"><i class="fa fa-eye"></i></a></li>
                        </ul>
                      </div>
                    </div>
                    <div class="productCaption clearfix">
                        <a href="UrunDetayi.aspx"><h5>Nike Sportswear</h5></a>
                      <h3>$199</h3>
                    </div>
                  </div>
                </div>
                <div class="col-sm-4 col-xs-12">
                  <div class="productBox">
                    <div class="productImage clearfix">
                      <img src="img\products\products-06.jpg" alt="products-img">
                      <div class="productMasking">
                        <ul class="list-inline btn-group" role="group">
                          <li><a data-toggle="modal" href=".login-modal" class="btn btn-default"><i class="fa fa-heart"></i></a></li>
                          <li><a href="Kart.aspx" class="btn btn-default"><i class="fa fa-shopping-cart"></i></a></li>
                          <li><a class="btn btn-default" data-toggle="modal" href=".quick-view"><i class="fa fa-eye"></i></a></li>
                        </ul>
                      </div>
                    </div>
                    <div class="productCaption clearfix">
                      <a href="UrunDetayi.aspx"><h5>Dip Dyed Sweater</h5></a>
                      <h3>$249</h3>
                    </div>
                  </div>
                </div>
                <div class="col-sm-4 col-xs-12">
                  <div class="productBox">
                    <div class="productImage clearfix">
                      <img src="img\products\products-07.jpg" alt="products-img">
                      <div class="productMasking">
                        <ul class="list-inline btn-group" role="group">
                          <li><a data-toggle="modal" href=".login-modal" class="btn btn-default"><i class="fa fa-heart"></i></a></li>
                          <li><a href="Kart.aspx" class="btn btn-default"><i class="fa fa-shopping-cart"></i></a></li>
                          <li><a class="btn btn-default" data-toggle="modal" href=".quick-view"><i class="fa fa-eye"></i></a></li>
                        </ul>
                      </div>
                    </div>
                    <div class="productCaption clearfix">
                      <a href="UrunDetayi.aspx"><h5>Scarf Ring Corner</h5></a>
                      <h3>$179</h3>
                    </div>
                  </div>
                </div>
                <div class="col-sm-4 col-xs-12">
                  <div class="productBox">
                    <div class="productImage clearfix">
                      <img src="img\products\products-08.jpg" alt="products-img">
                      <div class="productMasking">
                        <ul class="list-inline btn-group" role="group">
                          <li><a data-toggle="modal" href=".login-modal" class="btn btn-default"><i class="fa fa-heart"></i></a></li>
                          <li><a href="Kart.aspx" class="btn btn-default"><i class="fa fa-shopping-cart"></i></a></li>
                          <li><a class="btn btn-default" data-toggle="modal" href=".quick-view"><i class="fa fa-eye"></i></a></li>
                        </ul>
                      </div>
                    </div>
                    <div class="productCaption clearfix">
                      <a href="UrunDetayi.aspx"><h5>Sun Buddies</h5></a>
                      <h3>$149</h3>
                    </div>
                  </div>
                </div>
                <div class="col-sm-4 col-xs-12">
                  <div class="productBox">
                    <div class="productImage clearfix">
                      <img src="img\products\products-09.jpg" alt="products-img">
                      <div class="productMasking">
                        <ul class="list-inline btn-group" role="group">
                          <li><a data-toggle="modal" href=".login-modal" class="btn btn-default"><i class="fa fa-heart"></i></a></li>
                          <li><a href="Kart.aspx" class="btn btn-default"><i class="fa fa-shopping-cart"></i></a></li>
                          <li><a class="btn btn-default" data-toggle="modal" href=".quick-view"><i class="fa fa-eye"></i></a></li>
                        </ul>
                      </div>
                    </div>
                    <div class="productCaption clearfix">
                        <a href="UrunDetayi.aspx"><h5>Nike Sportswear</h5></a>
                      <h3>$199</h3>
                    </div>
                  </div>
                </div>
                <div class="col-sm-4 col-xs-12">
                  <div class="productBox">
                    <div class="productImage clearfix">
                      <img src="img\products\products-10.jpg" alt="products-img">
                      <div class="productMasking">
                        <ul class="list-inline btn-group" role="group">
                          <li><a data-toggle="modal" href=".login-modal" class="btn btn-default"><i class="fa fa-heart"></i></a></li>
                          <li><a href="Kart.aspx" class="btn btn-default"><i class="fa fa-shopping-cart"></i></a></li>
                          <li><a class="btn btn-default" data-toggle="modal" href=".quick-view"><i class="fa fa-eye"></i></a></li>
                        </ul>
                      </div>
                    </div>
                    <div class="productCaption clearfix">
                      <a href="UrunDetayi.aspx"><h5>Dip Dyed Sweater</h5></a>
                      <h3>$249</h3>
                    </div>
                  </div>
                </div>
                <div class="col-sm-4 col-xs-12">
                  <div class="productBox">
                    <div class="productImage clearfix">
                      <img src="img\products\products-11.jpg" alt="products-img">
                      <div class="productMasking">
                        <ul class="list-inline btn-group" role="group">
                          <li><a data-toggle="modal" href=".login-modal" class="btn btn-default"><i class="fa fa-heart"></i></a></li>
                          <li><a href="Kart.aspx" class="btn btn-default"><i class="fa fa-shopping-cart"></i></a></li>
                          <li><a class="btn btn-default" data-toggle="modal" href=".quick-view"><i class="fa fa-eye"></i></a></li>
                        </ul>
                      </div>
                    </div>
                    <div class="productCaption clearfix">
                      <a href="UrunDetayi.aspx"><h5>Scarf Ring Corner</h5></a>
                      <h3>$179</h3>
                    </div>
                  </div>
                </div>
                <div class="col-sm-4 col-xs-12">
                  <div class="productBox">
                    <div class="productImage clearfix">
                      <img src="img\products\products-12.jpg" alt="products-img">
                      <div class="productMasking">
                        <ul class="list-inline btn-group" role="group">
                          <li><a data-toggle="modal" href=".login-modal" class="btn btn-default"><i class="fa fa-heart"></i></a></li>
                          <li><a href="Kart.aspx" class="btn btn-default"><i class="fa fa-shopping-cart"></i></a></li>
                          <li><a class="btn btn-default" data-toggle="modal" href=".quick-view"><i class="fa fa-eye"></i></a></li>
                        </ul>
                      </div>
                    </div>
                    <div class="productCaption clearfix">
                      <a href= "UrunDetayi.aspx"><h5>Sun Buddies</h5></a>
                      <h3>$149</h3>
                    </div>
                  </div>
                </div>--%>
            </div>
        </div>
        </div>
        </div>
    </section>

    </span></span></span>

</asp:Content>
