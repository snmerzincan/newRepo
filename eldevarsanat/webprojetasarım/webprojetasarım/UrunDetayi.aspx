<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="UrunDetayi.aspx.cs" Inherits="webprojetasarım.UrunDetayi" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- LIGHT SECTION -->
    <section class="lightSection clearfix pageHeader">
        <div class="container">
            <div class="row">
                <div class="col-xs-6">
                    <div class="page-title">
                        <h2>Ürün Detayı</h2>
                    </div>
                </div>
                <div class="col-xs-6">
                    <ol class="breadcrumb pull-right">
                        <li>
                            <a href="Anasayfa.aspx">Anasayfa</a>
                        </li>
                        <li class="active">Ürün Detayı</li>
                    </ol>
                </div>
            </div>
        </div>
    </section>

    <!-- MAIN CONTENT SECTION -->
    <section class="mainContent clearfix">
        <div class="container">
            <div class="row singleProduct">
                <div class="col-xs-12">
                    <div class="media">
                        <asp:DataList ID="dtUrunDetay" runat="server" CellPadding="4" ForeColor="#333333" DataKeyField="urunid" RepeatColumns="1" Width="400px" Style="text-align: center" OnItemCommand="dtUrunDetay_ItemCommand1">
                            <SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                            <ItemTemplate>
                                <div>
                                    <asp:Label ID="lblurunad" runat="server" Text='<%#Eval("UrunAd")%>' Font-Size="Large" Font-Bold Font-Underline></asp:Label>
                                    <br></br>
                                    <asp:ImageButton ID="imgresim" ImageUrl='<%#Eval("ResimYolu1")%>' runat="server" CommandName="UrunDetayi" CommandArgument='<%#Eval("UrunID")%>' Width="640px" Height="640px" />
                                    <br></br>
                                    <asp:Label ID="lblurunfiyat" runat="server" Text='<%# Eval("Fiyat","{0:N}") %>' Font-Bold Font-Size="Medium" ForeColor="DarkTurquoise"></asp:Label>
                                    <br></br>
                                    <asp:TextBox ID="txtAdet" runat="server" Text="1" Font-Size="medium" Font-Bold BorderWidth="5" BorderColor="DarkTurquoise" Width="20"></asp:TextBox>
                                    <br></br>
                                      <asp:Button Text="Sepete Ekle" ID="btnSepeteEkle" class="btn btn-default"  CommandArgument='<%# Eval("UrunID") %>' CommanName="SepeteEkle" runat="server" BackColor="#6ab5b5" ForeColor="White" Width="130px" Height="40px" /><i class="fa fa-shopping-cart"></i>
                                    <br></br>
                                    <asp:Label ID="lblurunbilgi" runat="server" Text='<%#Eval("Aciklama")%>' Font-Size="X-Large" ForeColor="Navy"></asp:Label>
                                    <br></br>
                                </div>
                            </ItemTemplate>
                        </asp:DataList>
                        <%--<div class="media-left productSlider">--%>
                        <%-- <div id="carousel" class="carousel slide" data-ride="carousel">
                      <div class="carousel-inner">
                          <div class="item active" data-thumb="0">
                              <img src="img\products\signle-product\product-slide-big-01.jpg">
                          </div>
                          <div class="item" data-thumb="1">
                              <img src="img\products\signle-product\product-slide-big-02.jpg">
                          </div>
                          <div class="item" data-thumb="2">
                              <img src="img\products\signle-product\product-slide-big-03.jpg">
                          </div>
                          <div class="item" data-thumb="3">
                              <img src="img\products\signle-product\product-slide-big-04.jpg">
                          </div>
                      </div>
                  </div> --%>
                        <%--<div class="clearfix">
                    <div id="thumbcarousel" class="carousel slide" data-interval="false">
                      <div class="carousel-inner">
                          <div data-target="#carousel" data-slide-to="0" class="thumb"><img src="img\products\signle-product\product-slide-small-01.jpg"></div>
                          <div data-target="#carousel" data-slide-to="1" class="thumb"><img src="img\products\signle-product\product-slide-small-02.jpg"></div>
                          <div data-target="#carousel" data-slide-to="2" class="thumb"><img src="img\products\signle-product\product-slide-small-03.jpg"></div>
                          <div data-target="#carousel" data-slide-to="3" class="thumb"><img src="img\products\signle-product\product-slide-small-04.jpg"></div>
                      </div>--%>
                        <%--<a class="left carousel-control" href="#thumbcarousel" role="button" data-slide="prev">
                        <span class="glyphicon glyphicon-chevron-left"></span>
                      </a>
                      <a class="right carousel-control" href="#thumbcarousel" role="button" data-slide="next">
                        <span class="glyphicon glyphicon-chevron-right"></span>
                      </a>--%>
                        <%-- </div>--%>
                    </div>
                </div>
                <div class="media-body">
                    <ul class="list-inline">
                        <li><a href="UrunGridGorunum.aspx"><i class="fa fa-reply" aria-hidden="true"></i>Alışverişe Devam</a></li>
                    </ul>
                    <%--<%--<%--<%--<h2>Pellentesque non risus quis tellus</h2>
                    <h3>$149</h3>
                    <p>Mauris lobortis augue ex, ut faucibus nisi mollis ac. Sed volutpat scelerisque ex ut ullamcorper. Cras at velit quis sapien dapibus laoreet a id odio. Sed sit amet accumsan ante, eu congue metus. Aenean eros tortor, cursus quis feugiat sed, vestibulum vel purus. Etiam aliquam turpis quis blandit finibus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec porttitor placerat lectus, facilisis ornare leo tincidunt vel. Duis rutrum felis felis, eget malesuada massa tincidunt a.</p>
                    <%--<span class="quick-drop">
                    <select name="guiest_id3" id="guiest_id3" class="select-drop">
                      <option value="0">Size</option>
                      <option value="1">Small</option>
                      <option value="2">Medium</option>
                      <option value="3">Big</option>            
                    </select>
                  </span>--
                    <span class="quick-drop resizeWidth">
                        <select name="guiest_id4" id="guiest_id4" class="select-drop">
                            <option value="1">1</option>
                            <option value="2">2</option>
                            <option value="3">3</option>
                        </select>
                    </span>
                    <div class="btn-area">
                        <a href="Sepet.aspx" class="btn btn-primary btn-block">Sepete Ekle<i class="fa fa-angle-right" aria-hidden="true"></i></a>
                    </div>
                    <div class="tabArea">
                        <ul class="nav nav-tabs">
                            <li class="active"><a data-toggle="tab" href="#details">details</a></li>
                            <li><a data-toggle="tab" href="#about-art">about art</a></li>
                            <li><a data-toggle="tab" href="#sizing">sizing</a></li>
                            <li><a data-toggle="tab" href="#shipping">shipping</a></li>
                        </ul>
                        <div class="tab-content">
                            <div id="details" class="tab-pane fade in active">
                                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</p>
                                <ul class="list-unstyled">
                                    <li>Black, Crew Neck</li>
                                    <li>75% Cotton, 25% Rayon</li>
                                    <li>Waterbased Ink</li>
                                    <li>Wash Cold, dry low</li>
                                </ul>
                            </div>
                            <div id="about-art" class="tab-pane fade">
                                <p>Nulla facilisi. Mauris efficitur, massa et iaculis accumsan, mauris velit ultrices purus, quis condimentum nibh dolor ut tortor. Donec egestas tortor quis mattis gravida. Ut efficitur elit vitae dignissim volutpat. </p>
                            </div>
                            <div id="sizing" class="tab-pane fade">
                                <p>Praesent dui felis, gravida a auctor at, facilisis commodo ipsum. Cras eu faucibus justo. Nullam varius cursus nisi, sed elementum sem sagittis at. Nulla tellus massa, vestibulum a commodo facilisis, pulvinar convallis nunc.</p>
                            </div>
                            <div id="shipping" class="tab-pane fade">
                                <p>Mauris lobortis augue ex, ut faucibus nisi mollis ac. Sed volutpat scelerisque ex ut ullamcorper. Cras at velit quis sapien dapibus laoreet a id odio. Sed sit amet accumsan ante, eu congue metus. Aenean eros tortor, cursus quis feugiat sed, vestibulum vel purus.</p>
                            </div>
                        </div>
                    </div>--%>
                </div>
            </div>
        </div>
        </div>
          <div class="row productsContent">
              <%--   <div class="col-xs-12">
              <div class="page-header">
                <h4>Benzer Ürünler</h4>
              </div>
            </div>--%>
              <%--     <div class="col-md-3 col-sm-6 col-xs-12">
              <div class="productBox">
                <div class="productImage clearfix">
                  <img src="img\products\products-01.jpg" alt="products-img">
                  <div class="productMasking">
                    <ul class="list-inline btn-group" role="group">
                      <li><a data-toggle="modal" href=".login-modal" class="btn btn-default"><i class="fa fa-heart"></i></a></li>
                      <li><a href="Kart.aspx" class="btn btn-default"><i class="fa fa-shopping-cart"></i></a></li>
                      <li><a class="btn btn-default" data-toggle="modal" href=".quick-view"><i class="fa fa-eye"></i></a></li>
                    </ul>
                  </div>
                </div>
                <div class="productCaption clearfix">
                 <h5>Nike Sportswear</h5>
                 <h3>$199</h3>
                </div>
              </div>
            </div>--%>
              <%--    <div class="col-md-3 col-sm-6 col-xs-12">
              <div class="productBox">
                <div class="productImage clearfix">
                  <img src="img\products\products-02.jpg" alt="products-img">
                  <div class="productMasking">
                    <ul class="list-inline btn-group" role="group">
                      <li><a data-toggle="modal" href=".login-modal" class="btn btn-default"><i class="fa fa-heart"></i></a></li>
                      <li><a href="Kart.aspx" class="btn btn-default"><i class="fa fa-shopping-cart"></i></a></li>
                      <li><a class="btn btn-default" data-toggle="modal" href=".quick-view"><i class="fa fa-eye"></i></a></li>
                    </ul>
                  </div>
                </div>
                <div class="productCaption clearfix">
                 <h5>Dip Dyed Sweater</h5>
                 <h3>$249</h3>
                </div>
              </div>
            </div>--%>
              <%--    <div class="col-md-3 col-sm-6 col-xs-12">
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
                 <h5>Scarf Ring Corner</h5>
                 <h3>$179</h3>
                </div>
              </div>
            </div>--%>
              <%--<div class="col-md-3 col-sm-6 col-xs-12">
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
                 <h5>Sun Buddies</h5>
                 <h3>$149</h3>
                </div>
              </div>
            </div>--%>
          </div>
        </div>
    </section>
</asp:Content>
