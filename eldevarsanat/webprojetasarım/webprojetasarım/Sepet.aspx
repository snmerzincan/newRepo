<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Sepet.aspx.cs" Inherits="webprojetasarım.Kart" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <!-- LIGHT SECTION -->
      <section class="lightSection clearfix pageHeaderImage">
        <div class="container">
          <div class="tableBlock">
            <div class="row tableInner">
              <div class="col-xs-12">
                <div class="page-title">
                  <h2>Sepetim</h2>
                  <ol class="breadcrumb">
                    <li>
                      <a href="Anasayfa.aspx">Anasayfa</a>
                    </li>
                    <li class="active">Sepetim</li>
                  </ol>
                </div>
              </div>
            </div>
          </div>
        </div>
      </section>
      
      <!-- MAIN CONTENT SECTION -->
      <section class="mainContent clearfix cartListWrapper">
        <div class="container">
          <div class="row">
            <div class="col-xs-12">
              <div class="cartListInner">
                <form action="#">
                    <br />
                    <asp:Image ID="OdemeSepetBankalar" src="img/Odeme.png" runat="server" />
                    <br /><br /><br /><br />
                    <asp:GridView ID="gvSepet" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" DataKeyNames="sepetID" ForeColor="Black" GridLines="Vertical" Height="252px" OnRowDeleting="gvSepet_RowDeleting1" Width="1140px" ShowFooter="True">
                        <AlternatingRowStyle BackColor="#CCCCCC" />
                        <Columns>
                            <asp:BoundField DataField="UrunID" HeaderText="UrunID" />
                            <asp:BoundField DataField="UrunAd" HeaderText="Urün Adı" />
                            <asp:BoundField DataField="Adet" HeaderText="Adet" />
                            <asp:BoundField DataField="Fiyat" HeaderText="Fiyat" />
                            <asp:BoundField DataField="Tutar" HeaderText="Tutar" />
                            <asp:CommandField DeleteText="Sil" ShowDeleteButton="True" />
                        </Columns>
                        <EmptyDataTemplate>
                            &nbsp;&nbsp;&nbsp;&nbsp; Sepetinizde ürün bulunmamaktadır.
                        </EmptyDataTemplate>
                        <FooterStyle BackColor="#CCCCCC" />
                        <HeaderStyle BackColor="#47BAC1" Font-Bold="True" ForeColor="White" BorderStyle="Solid" BorderWidth="5px" HorizontalAlign="Center" VerticalAlign="Middle" />
                        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                        <RowStyle BorderColor="#47BAC1" BorderStyle="Solid" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Middle" />
                        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#808080" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#383838" />

                    </asp:GridView>

                 <%-- <div class="table-responsive">--%>
                   <%-- <table class="table">
                      <thead>
                        <tr>
                          <th></th>
                          <th>Ürün</th>
                          <th>Fiyat</th>
                          <th>Miktar</th>
                          <th>Toplam</th>
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
                  </div>--%>

                 <%-- <div class="updateArea">
                    <div class="input-group">
                      <%--<input type="text" class="form-control" placeholder="I have a discount coupon" aria-describedby="basic-addon2">
                      <a href="#" class="btn input-group-addon" id="basic-addon2">apply coupon</a>--%>
                   <%-- </div>
                    <a href="#" class="btn">Kartı Güncelle</a>
                  </div>--%>



                 <%--   Bu KISMI EKLEMEYE ÇALIŞ--%>

              <%--    <div class=" totalAmountArea">
                    <div class="row ">
                      <div class="col-sm-4 col-sm-offset-8 col-xs-12">
                        <ul class="list-unstyled">
                          <li>Sub Total <span>$ 792.00</span></li>
                          <li>UK Vat <span>$ 18.00</span></li>
                          <li>Grand Total <span class="grandTotal">$ 810.00</span></li>
                        </ul>
                      </div>
                    </div>
                  </div>--%>

                   <%------------------------------------------------------------------------%>

                  <div class="checkBtnArea">
                    <%--<a href="FaturaBilgileri.aspx" class="btn btn-primary btn-block">Devam<i class="fa fa-arrow-circle-right" aria-hidden="true"></i></a>--%> 
                      <asp:Button Font-Bold="true" Text="Sepeti Boşalt" ID="btnSepetBosalt" class="btn btn-default" runat="server" BackColor="#6ab5b5" ForeColor="White" Width="130px" Height="40px" OnClick="btnSepetBosalt_Click" /><i class="fa fa-shopping-cart"></i>

                      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                      <asp:Button Font-Bold="true" Text="Devam" ID="btnDevam" class="btn btn-default" runat="server" BackColor="#6ab5b5" ForeColor="White" Width="130px" Height="40px" OnClick="btnDevam_Click1"  /><i class="fa fa-shopping-cart"></i>

                      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                       <asp:Button Font-Bold="true" Text=" Alışverişe Devam" ID="btnAlisveris" class="btn btn-default" runat="server" BackColor="#6ab5b5" ForeColor="White" Width="150px" Height="40px" OnClick="btnAlisveris_Click"/><i class="fa fa-shopping-cart"></i>

                     
                  </div>
                </form>
              </div>
            </div>
          </div>
        </div>
      </section>
</asp:Content>
