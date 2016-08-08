<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="BlogAciklama.aspx.cs" Inherits="webprojetasarım.BlogAciklama" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <!-- LIGHT SECTION -->
      <section class="lightSection clearfix pageHeader">
        <div class="container">
          <div class="row">
            <div class="col-xs-6">
              <div class="page-title">
                <h2>Blog Detay</h2>
              </div>
            </div>
            <div class="col-xs-6">
              <ol class="breadcrumb pull-right">
                <li>
                  <a href="Anasayfa.aspx">Anasayfa</a>
                </li>
                <li class="active">Blog Detay</li>
              </ol>
            </div>
          </div>
        </div>
      </section>
      
      <!-- MAIN CONTENT SECTION -->
      <section class="mainContent clearfix blogPage singleBlog">
        <div class="container">
          <div class="row">
            <div class="col-md-9 col-sm-8 col-md-push-3 col-sm-push-4 col-xs-12">
              <div class="row">
                <div class="col-xs-12">
                  <div class="thumbnail">
                    <img src="img\blog\blog-01.jpg" alt="blog-image">
                    <div class="caption">
                      <div class="row">
                        <div class="col-md-3 col-md-push-9 col-sm-4 col-sm-push-8 col-xs-12">
                          <h5>Bilgiler</h5> 
                          <ul class="list-unstyled">
                            <li><i class="fa fa-user" aria-hidden="true"></i>Adam Smith</li>
                            <li><i class="fa fa-calendar" aria-hidden="true"></i>Mar 20, 2016</li>
                            <li><i class="fa fa-tags" aria-hidden="true"></i>Travel</li>
                            <li><i class="fa fa-envelope" aria-hidden="true"></i>8 comments</li>
                          </ul> 
                          <h5>Paylaş</h5> 
                          <ul class="list-inline">
                            <li><a href="#"><i class="fa fa-facebook" aria-hidden="true"></i></a></li>
                            <li><a href="#"><i class="fa fa-twitter" aria-hidden="true"></i></a></li>
                            <li><a href="#"><i class="fa fa-dribbble" aria-hidden="true"></i></a></li>
                            <li><a href="#"><i class="fa fa-tumblr" aria-hidden="true"></i></a></li>
                          </ul>
                        </div>
                        <div class="col-md-9 col-md-pull-3 col-sm-8 col-sm-pull-4 col-xs-12">
                          <h3>Praesent justo dolor, lobortis quis, lobortis dignissim </h3>
                          <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.</p> 

                          <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. </p>

                          <p>Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. </p>

                          <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. </p>

                          <p>Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. </p>
                        </div>
                      </div>
                    </div>
                    <ul class="pager">
                      <li class="previous"><a href="#">Geri</a></li>
                      <li class="next"><a href="#">Devam</a></li>
                    </ul>
                    <div class="commentsArea">
                  <h3>4 Yorumlar</h3>
                  <div class="media">
                    <a class="media-left" href="#">
                      <img class="media-object" src="img\blog\avatar.jpg" alt="Image">
                    </a>
                    <div class="media-body">
                      <h4 class="media-heading">Jessica Brown </h4>
                      <h4><span><i class="fa fa-calendar" aria-hidden="true"></i>Mar 20, 2016</span></h4>
                      <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident.</p>
                      <button class="btn btn-link" type="submit">Yenile</button>
                    </div>
                  </div>
                  <div class="media">
                    <a class="media-left" href="#">
                      <img class="media-object" src="img\blog\avatar.jpg" alt="Image">
                    </a>
                    <div class="media-body">
                      <h4 class="media-heading">Jessica Brown </h4>
                      <h4><span><i class="fa fa-calendar" aria-hidden="true"></i>Mar 20, 2016</span></h4>
                      <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident.</p>
                      <button class="btn btn-link" type="submit">Yenile</button>
                      <div class="media">
                        <a class="media-left" href="#">
                          <img class="media-object" src="img\blog\avatar.jpg" alt="Image">
                        </a>
                        <div class="media-body">
                          <h4 class="media-heading">Jessica Brown </h4>
                          <h4><span><i class="fa fa-calendar" aria-hidden="true"></i>Mar 20, 2016</span></h4>
                          <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident.</p>
                          <button class="btn btn-link" type="submit">Yenile</button>
                        </div>
                      </div>
                    </div>
                  </div>
                  <div class="media">
                    <a class="media-left" href="#">
                      <img class="media-object" src="img\blog\avatar.jpg" alt="Image">
                    </a>
                    <div class="media-body">
                      <h4 class="media-heading">Jessica Brown </h4>
                      <h4><span><i class="fa fa-calendar" aria-hidden="true"></i>Mar 20, 2016</span></h4>
                      <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident.</p>
                      <button class="btn btn-link" type="submit">Yenile</button>
                    </div>
                  </div>
                </div>
                  </div>
                </div>
              </div>
              <div class="row">
                <div class="col-xs-12">
                  <form action="" method="POST" role="form" class="commentsForm">
                    <h3>Yorum Ekleyin</h3>
                    <div class="row">
                      <div class="col-sm-6 col-xs-12">
                        <div class="form-group">
                          <input type="text" class="form-control" id="" placeholder="İsim">
                        </div>
                      </div>
                      <div class="col-sm-6 col-xs-12">
                        <div class="form-group">
                          <input type="email" class="form-control" id="" placeholder="E-Posta">
                        </div>
                      </div>
                      <div class="col-xs-12">
                        <div class="form-group">
                          <input type="text" class="form-control" id="" placeholder="Website">
                        </div>
                      </div>
                      <div class="col-xs-12">
                        <div class="form-group">
                          <textarea class="form-control" rows="3" placeholder="Yorum"></textarea>
                        </div>
                      </div>

                    </div>
                    <button type="submit" class="btn btn-primary">Ekle</button>
                  </form>
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
                    <a class="media-left" href="Yorum.aspx">
                      <img class="media-object" src="img\blog\blog-small-01.jpg" alt="Image">
                    </a>
                    <div class="media-body">
                      <h4 class="media-heading"><a href="Yorum.aspx">Totam Rem Aperiam Ea queab Ipsa.</a></h4>
                      <p><i class="fa fa-calendar" aria-hidden="true"></i>5 March, 2016</p>
                    </div>
                  </div>
                  <div class="media">
                    <a class="media-left" href="Yorum.aspx">
                      <img class="media-object" src="img\blog\blog-small-02.jpg" alt="Image">
                    </a>
                    <div class="media-body">
                      <h4 class="media-heading"><a href="Yorum.aspx">Totam Rem Aperiam Ea queab Ipsa.</a></h4>
                      <p><i class="fa fa-calendar" aria-hidden="true"></i>5 March, 2016</p>
                    </div>
                  </div>
                  <div class="media">
                    <a class="media-left" href="Yorum.aspx">
                      <img class="media-object" src="img\blog\blog-small-03.jpg" alt="Image">
                    </a>
                    <div class="media-body">
                      <h4 class="media-heading"><a href="Yorum.aspx">Totam Rem Aperiam Ea queab Ipsa.</a></h4>
                      <p><i class="fa fa-calendar" aria-hidden="true"></i>5 March, 2016</p>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </section>
</asp:Content>
