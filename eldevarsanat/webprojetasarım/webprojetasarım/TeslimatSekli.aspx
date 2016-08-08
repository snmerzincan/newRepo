<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="TeslimatSekli.aspx.cs" Inherits="webprojetasarım.TeslimatYontemi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- LIGHT SECTION -->
    <section class="lightSection clearfix pageHeader">
        <div class="container">
            <div class="row">
                <div class="col-xs-6">
                    <div class="page-title">
                        <h2>Teslimat Şekli</h2>
                    </div>
                </div>
                <div class="col-xs-6">
                    <ol class="breadcrumb pull-right">
                        <li>
                            <a href="Anasayfa.aspx">Anasayfa</a>
                        </li>
                        <li class="active">Teslimat Şekli</li>
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
                        <div class="row progress-wizard" style="border-bottom: 0;">

                            <div class="col-xs-3 progress-wizard-step complete fullBar">
                                <div class="text-center progress-wizard-stepnum">Adres</div>
                                <div class="progress">
                                    <div class="progress-bar"></div>
                                </div>
                                <a href="FaturaBilgileri.aspx" class="progress-wizard-dot"></a>
                            </div>

                            <div class="col-xs-3 progress-wizard-step active">
                                <div class="text-center progress-wizard-stepnum">Teslimat Şekli</div>
                                <div class="progress">
                                    <div class="progress-bar"></div>
                                </div>
                                <a href="TeslimatSekli.aspx" class="progress-wizard-dot"></a>
                            </div>

                            <div class="col-xs-3 progress-wizard-step disabled">
                                <div class="text-center progress-wizard-stepnum">Ödeme Şekli</div>
                                <div class="progress">
                                    <div class="progress-bar"></div>
                                </div>
                                <a href="OdemeSekli.aspx" class="progress-wizard-dot"></a>
                            </div>

                            <div class="col-xs-3 progress-wizard-step disabled">
                                <div class="text-center progress-wizard-stepnum">Önizleme</div>
                                <div class="progress">
                                    <div class="progress-bar"></div>
                                </div>
                                <a href="Onizleme.aspx" class="progress-wizard-dot"></a>
                            </div>
                        </div>

                        <form action="" class="row" method="POST" role="form">
                            <div class="col-xs-12">
                                <div class="page-header">
                                    <h4>Teslimat Şekli</h4>
                                </div>
                            </div>

                            <asp:Panel ID="pnlBilgi" runat="server">
                                <div>&nbsp<asp:Image ID="Image1" src="img\teslimatresmi\1470282486_meanicons_7.png" runat="server" /><span>Standart Teslim</span></div>
                                 <div>
                                    <p>Ürünlerimiz kampanya bittiğinde veya sizin için hazırlanır hazırlanmaz standart kargo ile teslim edilir.Ürünler alış tarihinden 1 gün sonra kargoya verilir.</p> 
                                 </div><br />
                               

                            </asp:Panel>
                            <%--<div class="form-group col-sm-4 col-xs-12">
                    <label for="">Ülke</label>
                    <span class="step-drop">
                      <select name="guiest_id3" id="guiest_id3" class="select-drop">
                        <option value="0">Choose</option>
                        <option value="1">Choose 1</option>
                        <option value="2">Choose 2</option>
                        <option value="3">Choose 3</option>            
                      </select>
                    </span>
                  </div>
                  <div class="form-group col-sm-4 col-xs-12">
                    <label for="">Şehir</label>
                    <span class="step-drop">
                      <select name="guiest_id3" id="guiest_id3" class="select-drop">
                        <option value="0">Choose</option>
                        <option value="1">Choose 1</option>
                        <option value="2">Choose 2</option>
                        <option value="3">Choose 3</option>            
                      </select>
                    </span>
                  </div>
                  <div class="form-group col-sm-4 col-xs-12">
                    <label for="">Posta Kodu</label>
                    <input type="text" class="form-control" id="">
                  </div>--%>
                            <%-- <div class="col-xs-12">
                    <div class="orderBox">
                      <div class="table-responsive">
                        <table class="table">
                          <thead>
                            <tr>
                              <th>Kurye</th>
                              <th>Yöntem</th>
                              <th>Bilgi</th>
                              <th>Fiyat</th>
                              <th></th>
                            </tr>
                          </thead>
                          <tbody>
                            <tr>
                              <td class="col-xs-1"><i class="fa fa-plane" aria-hidden="true"></i></td>
                              <td>Havayoluyla</td>
                              <td>Delivery next day!</td>
                              <td>$ 99.00</td>
                              <td>
                                <div class="checkboxArea">
                                  <input id="checkbox1" type="checkbox" name="checkbox" value="1" checked="checked">
                                  <label for="checkbox1"><span></span></label>
                                </div>
                              </td>
                            </tr>
                            <tr>
                              <td class="col-xs-1"><i class="fa fa-ship" aria-hidden="true"></i></td>
                              <td>Gemiyle</td>
                              <td>Pick up in-store</td>
                              <td>$ 39.00</td>
                              <td>
                                <div class="checkboxArea">
                                  <input id="checkbox2" type="checkbox" name="checkbox" value="1">
                                  <label for="checkbox2"><span></span></label>
                                </div>
                              </td>
                            </tr>
                          </tbody>
                        </table>
                      </div>
                    </div>
                  </div>--%>
                            <div class="col-xs-12">
                                <div class="well well-lg clearfix">
                                    <ul class="pager">
                                        <li class="previous"><a href="FaturaBilgileri.aspx">Geri</a></li>
                                        <li class="next"><a href="OdemeSekli.aspx">Devam</a></li>
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
