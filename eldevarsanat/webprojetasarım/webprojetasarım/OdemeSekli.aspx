<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="OdemeSekli.aspx.cs" Inherits="webprojetasarım.OdemeYontemi" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- LIGHT SECTION -->
    <section class="lightSection clearfix pageHeader">
        <div class="container">
            <div class="row">
                <div class="col-xs-6">
                    <div class="page-title">
                        <h2>Ödeme Şekli</h2>
                    </div>
                </div>
                <div class="col-xs-6">
                    <ol class="breadcrumb pull-right">
                        <li>
                            <a href="Anasayfa.aspx">Anasayfa</a>
                        </li>
                        <li class="active">Ödeme Şekli</li>
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

                            <div class="col-xs-3 progress-wizard-step complete fullBar">
                                <div class="text-center progress-wizard-stepnum">Teslimat Şekli</div>
                                <div class="progress">
                                    <div class="progress-bar"></div>
                                </div>
                                <a href="TeslimatSekli.aspx" class="progress-wizard-dot"></a>
                            </div>

                            <div class="col-xs-3 progress-wizard-step active">
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
                                    <h4>Ödeme Bilgileri</h4>
                                </div>
                            </div>
                            <div class="form-group col-sm-4 col-xs-12">
                                <table style="width: 350px; text-align: left">
                                    <tr>
                                        <td style="width: 130px;">
                                            <asp:Label ID="lbl1" runat="server" Text="Adı"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:Label ID="lbladi" runat="server" Text="Adi"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="lbl2" runat="server" Text="Soyadı"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:Label ID="lblSoyadi" runat="server" Text="Soyadı"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="lbl3" runat="server" Text="Alışveriş Tutar"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:Label ID="lblTutar" runat="server" Text="Tutar"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Button ID="btnKredikarti" Width="110px" CssClass="bluebutton" runat="server" Text="Kredi Kartı" OnClick="btnKredikarti_Click" />
                                        </td>
                                        <td>
                                            <asp:Button ID="btnhavaleeft" CssClass="bluebutton" runat="server" Text="Havale/EFT" OnClick="btnhavaleeft_Click" /></td>
                                    </tr>
                                </table>
                                <asp:Panel ID="Panel1" runat="server">
                                    <table style="width: 350px; text-align: left">
                                        <tr>
                                            <td style="width: 130px;">
                                                <asp:Label ID="Label2" runat="server" Visible="false" Text="Firma Ünvan"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label4" runat="server" Text="MS-YAZ-10 Sağlık Ürünleri Projesi"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Label ID="Label6" runat="server" Text="Banka"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label7" runat="server" Text="Garanti Bankası"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Label ID="Label8" runat="server" Text="Şube"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label9" runat="server" Text="Beşiktaş-Barbaros"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Label ID="Label10" runat="server" Text="Hesap No"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label11" runat="server" Text="5246246"></asp:Label>
                                            </td>
                                        </tr>

                                        <tr>
                                            <td>
                                                <asp:Label ID="Label12" runat="server" Text="IbanNO"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label13" runat="server" Text="TR 12 3426 5464 5486 1548"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Button ID="btndevam" Width="110px" CssClass="bluebutton" runat="server" Text="Devam" OnClick="btndevam_Click" />
                                            </td>
                                            <td>
                                                <asp:Button ID="btncikis" CssClass="bluebutton" runat="server" Text="Güvenli çıkış" OnClick="btncikis_Click" /></td>
                                        </tr>

                                    </table>
                                    </asp:Panel>


                                    <%--<span class="step-drop">
                      <select name="guiest_id3" id="guiest_id3" class="select-drop">
                        <option value="0">Credit Card</option>
                        <option value="1">Credit Card 1</option>
                        <option value="2">Credit Card 2</option>
                        <option value="3">Credit Card 3</option>            
                      </select>
                    </span>--%>
                            </div>
                            <%--   <div class="form-group col-sm-4 col-xs-12">
                    <label for="">Kart</label>
                    <span class="step-drop">
                      <select name="guiest_id3" id="guiest_id3" class="select-drop">
                        <option value="0">Visa Card</option>
                        <option value="1">Visa Card 1</option>
                        <option value="2">Visa Card 2</option>
                        <option value="3">Visa Card 3</option>            
                      </select>
                    </span>--%>
                    </div>
                    <%--<div class="form-group col-sm-4 col-xs-12">
                    <label for="">Kart Numarası</label>
                    <input type="password" class="form-control" id="">
                  </div>
                  <div class="form-group col-sm-4 col-xs-12">
                    <label for="">Tarih</label>--%>

                    <%--<div class="row">
                      <div class="col-xs-6">
                        <span class="step-drop">
                          <select name="guiest_id3" id="guiest_id3" class="select-drop">
                            <option value="0">month</option>
                            <option value="1">month 1</option>
                            <option value="2">month 2</option>
                            <option value="3">month 3</option>   
                          </select>
                        </span>
                      </div>--%>
                    <%-- <div class="col-xs-6">
                        <span class="step-drop">
                          <select name="guiest_id3" id="guiest_id3" class="select-drop">
                            <option value="0">2016</option>
                            <option value="1">2017</option>
                            <option value="2">2018</option>
                            <option value="3">2019</option>            
                          </select>
                        </span>
                      </div>--%>
                </div>
            </div>
            <%--  <div class="form-group col-sm-4 col-xs-12">
                    <label for="">CV Kodu</label>
                    <input type="text" class="form-control" id="">
                  </div>--%>
            <div class="col-xs-12">
                <div class="well well-lg clearfix">
                    <ul class="pager">
                        <li class="previous"><a href="TeslimatSekli.aspx">Geri</a></li>
                        <li class="next"><a href="Onizleme.aspx">Devam</a></li>
                    </ul>
                </div>
            </div>
            </form>
        </div>
        </div>
          </div>
        </div>
    </section>
    </section>
</asp:Content>
