<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Bloglar.aspx.cs" Inherits="webprojetasarım.Blog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
      <!-- LIGHT SECTION -->
      <section class="lightSection clearfix pageHeader">
        <div class="container">
          <div class="row">
            <div class="col-xs-6">
              <div class="page-title">
                <h2>Blog</h2>
              </div>
            </div>
            <div class="col-xs-6">
              <ol class="breadcrumb pull-right">
                <li>
                  <a href="Anasayfa.aspx">Anasayfa</a>
                </li>
                <li class="active">Blog</li>
              </ol>
            </div>
          </div>
        </div>
      </section>
      
      <!-- MAIN CONTENT SECTION -->
      <section class="mainContent clearfix blogPage">
        <div class="container">
          <div class="row">
            <div class="col-md-9 col-sm-8 col-md-push-3 col-sm-push-4 col-xs-12">
              <div class="row">
                <div class="col-xs-12">
                  <div class="thumbnail">
                  <img src="img\blog\blog-01.jpg" alt="blog-image">
                    <div class="caption">
                      <div class="row">
                        <div class="col-md-2 col-md-push-10 col-sm-4 col-sm-push-8 col-xs-12">
                          <%--<h5>Bilgiler</h5>--%> 
                          <ul class="list-unstyled">
                            <%--<li><a href="#"><i class="fa fa-user" aria-hidden="true"></i>Adam Smith</a></li>
                            <li><i class="fa fa-calendar" aria-hidden="true"></i>Mar 20, 2016</li>
                            <li><a href="#"><i class="fa fa-tags" aria-hidden="true"></i>Travel</a></li>
                            <li><a href="#"><i class="fa fa-envelope" aria-hidden="true"></i>8 comments</a></li>--%>
                          </ul> 
                        </div>
                        <div class="col-md-10 col-md-pull-2 col-sm-8 col-sm-pull-4 col-xs-12">
                          <h3><a href="BlogAciklama.aspx">Bu sayfa çok yakında firma sahiplerimizden gelecek samimi hikayeler ile yayında olacak...</a> </h3>
                          <%--<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.</p>--%>  
                        </div>
                      </div>
                    </div>
                  </div>
                </div>
                <div class="col-xs-12">
                  <div class="thumbnail">
                  <!-- <img src="img/blog/blog-02.jpg" alt="blog-image"> -->
                  <div id="carousel-id" class="carousel slide" data-ride="carousel">
                    <div class="carousel-inner">
                      <div class="item">
                        <img src="img\blog\blog-02.jpg" alt="blog-image">
                      </div>
                      <div class="item">
                        <img src="img\blog\blog-02.jpg" alt="blog-image">
                      </div>
                      <div class="item active">
                        <img src="img\blog\blog-02.jpg" alt="blog-image">
                      </div>
                    </div>
                    <a class="left carousel-control" href="#carousel-id" data-slide="prev"><span class="glyphicon glyphicon-chevron-left"></span></a>
                    <a class="right carousel-control" href="#carousel-id" data-slide="next"><span class="glyphicon glyphicon-chevron-right"></span></a>
                  </div>
                    <div class="caption">
                      <div class="row">
                        <div class="col-md-2 col-md-push-10 col-sm-3 col-sm-push-9 col-xs-12">
                          <%--<h5>Bilgiler</h5>--%> 
                          <ul class="list-unstyled">
                            <%--<li><a href="#"><i class="fa fa-user" aria-hidden="true"></i>Adam Smith</a></li>
                            <li><i class="fa fa-calendar" aria-hidden="true"></i>Mar 20, 2016</li>
                            <li><a href="#"><i class="fa fa-tags" aria-hidden="true"></i>Travel</a></li>
                            <li><a href="#"><i class="fa fa-envelope" aria-hidden="true"></i>8 comments</a></li>--%>
                          </ul> 
                        </div>
                        <div class="col-md-10 col-md-pull-2 col-sm-9 col-sm-pull-3 col-xs-12col-xs-12">
                          <%--<h3><a href="BlogAciklama.aspx">Praesent justo dolor, lobortis quis, lobortis dignissim</a> </h3>--%>
                          <%--<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.</p>--%>  
                        </div>
                      </div>
                    </div>
                  </div>
                </div>
                <div class="col-xs-12">
                  <div class="thumbnail">
                  <img src="img\blog\blog-03.jpg" alt="blog-image">
                    <div class="caption">
                      <div class="row">
                        <div class="col-md-2 col-md-push-10 col-sm-3 col-sm-push-9 col-xs-12">
                          <h5>Bilgiler</h5> 
                          <ul class="list-unstyled">
                            <%--<li><a href="#"><i class="fa fa-user" aria-hidden="true"></i>Adam Smith</a></li>
                            <li><i class="fa fa-calendar" aria-hidden="true"></i>Mar 20, 2016</li>
                            <li><a href="#"><i class="fa fa-tags" aria-hidden="true"></i>Travel</a></li>
                            <li><a href="#"><i class="fa fa-envelope" aria-hidden="true"></i>8 comments</a></li>--%>
                          </ul> 
                        </div>
                        <div class="col-md-10 col-md-pull-2 col-sm-9 col-sm-pull-3 col-xs-12">
                          <%--<h3><a href="BlogAciklama.aspx">Praesent justo dolor, lobortis quis, lobortis dignissim</a> </h3>--%>
                          <%--<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.</p>--%>  
                        </div>
                      </div>
                    </div>
                  </div>
                </div>
                <div class="col-xs-12">
                  <div class="thumbnail">
                  <img src="img\blog\blog-04.jpg" alt="blog-image">
                    <div class="caption">
                      <div class="row">
                        <div class="col-md-2 col-md-push-10 col-sm-3 col-sm-push-9 col-xs-12">
                          <h5>Bilgiler</h5> 
                          <ul class="list-unstyled">
                            <%--<li><a href="#"><i class="fa fa-user" aria-hidden="true"></i>Adam Smith</a></li>
                            <li><i class="fa fa-calendar" aria-hidden="true"></i>Mar 20, 2016</li>
                            <li><a href="#"><i class="fa fa-tags" aria-hidden="true"></i>Travel</a></li>
                            <li><a href="#"><i class="fa fa-envelope" aria-hidden="true"></i>8 comments</a></li>--%>
                          </ul> 
                        </div>
                        <div class="col-md-10 col-md-pull-2 col-sm-9 col-sm-pull-3 col-xs-12">
                          <%--<h3><a href="BlogAciklama.aspx">Praesent justo dolor, lobortis quis, lobortis dignissim</a> </h3>--%>
                          <%--<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.</p>--%>  
                        </div>
                      </div>
                    </div>
                  </div>
                </div>
                <div class="col-xs-12">
                  <div class="thumbnail">
                  <img src="img\blog\blog-05.jpg" alt="blog-image">
                    <div class="caption">
                      <div class="row">
                        <div class="col-md-2 col-md-push-10 col-sm-3 col-sm-push-9 col-xs-12">
                          <h5>Bilgiler</h5> 
                          <ul class="list-unstyled">
                            <%--<li><a href="#"><i class="fa fa-user" aria-hidden="true"></i>Adam Smith</a></li>
                            <li><i class="fa fa-calendar" aria-hidden="true"></i>Mar 20, 2016</li>
                            <li><a href="#"><i class="fa fa-tags" aria-hidden="true"></i>Travel</a></li>
                            <li><a href="#"><i class="fa fa-envelope" aria-hidden="true"></i>8 comments</a></li>--%>
                          </ul> 
                        </div>
                        <div class="col-md-10 col-md-pull-2 col-sm-9 col-sm-pull-3 col-xs-12">
                          <%--<h3><a href="BlogAciklama.aspx">Praesent justo dolor, lobortis quis, lobortis dignissim</a> </h3>--%>
                          <%--<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.</p>--%>  
                        </div>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
              <div class="row">
                <div class="col-xs-12">
                  <div class="text-left">
                    <ul class="pagination">
                      <li class="active"><a href="#">1</a></li>
                      <li><a href="#">2</a></li>
                      <li><a href="#">3</a></li>
                      <li><a href="#">4</a></li>
                      <li><a href="#">5</a></li>
                      <li>
                        <a href="#" aria-label="Next">
                          <span aria-hidden="true">&raquo;</span>
                        </a>
                      </li>
                    </ul>
                  </div>
                </div>
              </div>
            </div>
            <div class="col-md-3 col-sm-4 col-md-pull-9 col-sm-pull-8 col-xs-12 sideBar">
              <div class="input-group">
                <input type="text" class="form-control" placeholder="Ara" aria-describedby="basic-addon2">
                <a href="#" class="input-group-addon" id="basic-addon2"><i class="fa fa-search"></i></a>
              </div>
              <div class="panel panel-default">
                <div class="panel-heading">Kategoriler</div>
                <div class="panel-body">
                  <ul class="list-unstyle sidebar-list">
                     <li><a href="#"><i class="fa fa-caret-right" aria-hidden="true"></i>Düğün <span>(6)</span></a></li>
                    <li><a href="#"><i class="fa fa-caret-right" aria-hidden="true"></i>Nişan <span>(6)</span></a></li>
                      <li><a href="#"><i class="fa fa-caret-right" aria-hidden="true"></i>Doğum Günü <span>(6)</span></a></li>
                  </ul>
                </div>
              </div>
              <div class="panel panel-default recentBlogPosts">
                <div class="panel-heading">Son Gönderilen Yorumlar</div>
                <div class="panel-body">
                  <div class="media">
                    <a class="media-left" href="BlogAciklama.aspx">
                      <img class="media-object" src="img\blog\blog-small-01.jpg" alt="Image">
                    </a>
                    <div class="media-body">
                      <h4 class="media-heading"><a href="BlogAciklama.aspx">-</a></h4>
                      <p><i class="fa fa-calendar" aria-hidden="true"></i>5 Mart, 2016</p>
                    </div>
                  </div>
                  <div class="media">
                    <a class="media-left" href="BlogAciklama.aspx">
                      <img class="media-object" src="img\blog\blog-small-02.jpg" alt="Image">
                    </a>
                    <div class="media-body">
                      <h4 class="media-heading"><a href="BlogAciklama.aspx">-</a></h4>
                      <p><i class="fa fa-calendar" aria-hidden="true"></i>17 Mart, 2016</p>
                    </div>
                  </div>
                  <div class="media">
                    <a class="media-left" href="BlogAciklama.aspx">
                      <img class="media-object" src="img\blog\blog-small-03.jpg" alt="Image">
                    </a>
                    <div class="media-body">
                      <h4 class="media-heading"><a href="BlogAciklama.aspx">-</a></h4>
                      <p><i class="fa fa-calendar" aria-hidden="true"></i>8 Haziran, 2016</p>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </section>
</asp:Content>
