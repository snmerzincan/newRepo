<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Onizleme.aspx.cs" Inherits="webprojetasarım.Onizleme" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <!-- LIGHT SECTION -->
      <section class="lightSection clearfix pageHeader">
        <div class="container">
          <div class="row">
            <div class="col-xs-6">
              <div class="page-title">
                <h2>Önizleme</h2>
              </div>
            </div>
            <div class="col-xs-6">
              <ol class="breadcrumb pull-right">
                <li>
                  <a href="index.htm">Anasayfa</a>
                </li>
                <li class="active">Önizleme</li>
              </ol>
            </div>
          </div>
        </div>
      </section>
      
      <!-- MAIN CONTENT SECTION -->
      <section class="mainContent clearfix stepsWrapper">
        <div class="container">
          <div class="row">
            <div class="col-xs-12">
              <div class="innerWrapper clearfix stepsPage">
                <div class="row progress-wizard" style="border-bottom:0;">

                  <div class="col-xs-3 progress-wizard-step complete fullBar">
                    <div class="text-center progress-wizard-stepnum">Faturalandırma & Teslimat Adresi</div>
                    <div class="progress"><div class="progress-bar"></div></div>
                    <a href="FaturaBilgileri.aspx" class="progress-wizard-dot"></a>
                  </div>

                  <div class="col-xs-3 progress-wizard-step complete fullBar">
                    <div class="text-center progress-wizard-stepnum">Teslimat Şekli</div>
                    <div class="progress"><div class="progress-bar"></div></div>
                    <a href="TeslimatSekli.aspx" class="progress-wizard-dot"></a>
                  </div>

                  <div class="col-xs-3 progress-wizard-step complete fullBar">
                    <div class="text-center progress-wizard-stepnum">Ödeme Şekli</div>
                    <div class="progress"><div class="progress-bar"></div></div>
                    <a href="OdemeSekli.aspx" class="progress-wizard-dot"></a>
                  </div>

                  <div class="col-xs-3 progress-wizard-step complete">
                    <div class="text-center progress-wizard-stepnum">Önizleme</div>
                    <div class="progress"><div class="progress-bar"></div></div>
                    <a href="Onizleme.aspx" class="progress-wizard-dot"></a>
                  </div>
                </div>
                
                <form action="" class="row" method="POST" role="form">
                  <div class="col-xs-12">
                    <div class="page-header">
                      <h4>Sipariş Önizleme</h4>
                    </div>
                  </div>
                  <div class="col-sm-6 col-xs-12">
                    <div class="panel panel-default">
                      <div class="panel-heading">
                        <h4 class="panel-title">Fatura Adresi</h4>
                      </div>
                      <div class="panel-body">
                        <address>
                          <strong>Adam Smith</strong><br>
                          9/4 C Babor Road, Mohammad pur, <br>
                          Shyamoli, Dhaka <br>
                          Bangladesh
                        </address>
                      </div>
                    </div>
                  </div>
                  <div class="col-sm-6 col-xs-12">
                    <div class="panel panel-default">
                      <div class="panel-heading">
                        <h4 class="panel-title">Teslimat Adresi</h4>
                      </div>
                      <div class="panel-body">
                        <address>
                          <strong>Adam Smith</strong><br>
                          9/4 C Babor Road, Mohammad pur, <br>
                          Shyamoli, Dhaka <br>
                          Bangladesh
                        </address>
                      </div>
                    </div>
                  </div>
                  <div class="col-sm-6 col-xs-12">
                    <div class="panel panel-default">
                      <div class="panel-heading">
                        <h4 class="panel-title">Ödeme Şekli</h4>
                      </div>
                      <div class="panel-body">
                        <address>
                          <span>Credit Card - VISA</span>
                        </address>
                      </div>
                    </div>
                  </div>
                  <div class="col-sm-6 col-xs-12">
                    <div class="panel panel-default">
                      <div class="panel-heading">
                        <h4 class="panel-title">Teslimat Şekli</h4>
                      </div>
                      <div class="panel-body">
                        <address>
                          <span>Post Air Mail</span>
                        </address>
                      </div>
                    </div>
                  </div>
                  <div class="col-xs-12">
                    <div class="panel panel-default">
                      <div class="panel-heading">
                        <h4 class="panel-title">Sipariş Detayı</h4>
                      </div>
                      <div class="panel-body">
                        <div class="row">
                          <div class="col-sm-4 col-xs-12">
                            <address>
                              <a href="#">E-Posta: adamsmith@bigbag.com</a> <br>
                              <span>Telefon Numarası: +884 5452 6432</span>
                            </address>
                          </div>
                          <div class="col-sm-8 col-xs-12">
                            <address>
                              <span>Ek Bilgi</span><br>
                              <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip</p>
                            </address>
                          </div>
                        </div>
                      </div>
                    </div>
                  </div>
                  <div class="col-xs-12">
                    <div class="cartListInner">
                      <div class="table-responsive">
                        <table class="table">
                          <thead>
                            <tr>
                              <th></th>
                              <th>Ürün</th>
                              <th>Fiyat</th>
                              <th>Adet</th>
                              <th>Tutar</th>
                            </tr>
                          </thead>
                          <tbody>
                            <tr>
                              <td class="col-xs-2">
                                <button type="button" class="close" data-dismiss="alert" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                                <span class="cartImage"><img src="img\products\cart-image.jpg" alt="image"></span>
                              </td>
                              <td class="col-xs-4">Italian Winter Hat</td>
                              <td class="col-xs-2">$ 99.00</td>
                              <td class="col-xs-2"><input type="text" placeholder="1"></td>
                              <td class="col-xs-2">$ 99.00</td>
                            </tr>
                            <tr>
                              <td class="col-xs-2">
                                <button type="button" class="close" data-dismiss="alert" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                                <span class="cartImage"><img src="img\products\cart-image.jpg" alt="image"></span>
                              </td>
                              <td class="col-xs-4">Italian Winter Hat</td>
                              <td class="col-xs-2">$ 99.00</td>
                              <td class="col-xs-2"><input type="text" placeholder="1"></td>
                              <td class="col-xs-2">$ 99.00</td>
                            </tr>
                            <tr>
                              <td class="col-xs-2">
                                <button type="button" class="close" data-dismiss="alert" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                                <span class="cartImage"><img src="img\products\cart-image.jpg" alt="image"></span>
                              </td>
                              <td class="col-xs-4">Italian Winter Hat</td>
                              <td class="col-xs-2">$ 99.00</td>
                              <td class="col-xs-2"><input type="text" placeholder="1"></td>
                              <td class="col-xs-2">$ 99.00</td>
                            </tr>
                          </tbody>
                        </table>
                      </div>
                      <div class="row totalAmountArea">
                        <div class="col-sm-4 col-sm-offset-8 col-xs-12">
                          <ul class="list-unstyled">
                            <li>&nbsp;Ara Tutar <span>$ 792.00</span></li>
                            <li>KDV<span>$ 18.00</span></li>
                            <li>Toplam Tutar <span class="grandTotal">$ 810.00</span></li>
                          </ul>
                        </div>
                      </div>
                    </div>
                  </div>
                  <div class="col-xs-12">
                    <div class="well well-lg clearfix">
                      <ul class="pager">
                      <li class="previous"><a href="OdemeSekli.aspx">Geri</a></li>
                        <li class="next"><a href="TamamlananSiparis.aspx">Onayla</a></li>
                      </ul>
                    </div>
                  </div>
                </form>
              </div>
            </div>
          </div>
        </div>
      </section>
</asp:Content>
