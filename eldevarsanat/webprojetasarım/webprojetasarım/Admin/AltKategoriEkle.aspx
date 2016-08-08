<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="AltKategoriEkle.aspx.cs" Inherits="webprojetasarım.Admin.AltKategoriEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- MAIN CONTENT SECTION -->
  <%--  <section class="mainContent clearfix productsContent">--%>
        <div class="container">
            <div class="row">
                
                <div class="col-md-9 col-sm-8 col-xs-12">
                    <div class="row filterArea">
                        <div class="col-xs-6">
                            <asp:DropDownList ID="ddlKategoriler" runat="server" Height="16px" Width="132px" AutoPostBack="True" OnSelectedIndexChanged="ddlKategoriler_SelectedIndexChanged"></asp:DropDownList>
                        </div>
                    </div>

                    <div class="row">
                        <%--AltKategori Bilgileri--%>
                        <br />
                        <asp:GridView ID="gvAltKategoriler" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#47BAC1" BorderStyle="None" BorderWidth="5px" CellPadding="4" HeaderStyle-HorizontalAlign="Center" HeaderStyle-VerticalAlign="Middle" OnSelectedIndexChanged="gvAltKategoriler_SelectedIndexChanged" DataKeyNames="AltKategoriID" Height="280px" Width="1030px" Font-Bold="True" Font-Italic="False" Font-Names="Courier New" Font-Size="Large" ShowFooter="True">
                            <Columns>
                                <asp:CommandField HeaderText="Seç" SelectText="&gt;&gt;" ShowSelectButton="True" HeaderStyle-HorizontalAlign="Center" HeaderStyle-VerticalAlign="Middle" />
                                <asp:BoundField DataField="AltKategoriAd" HeaderText="Alt Kategori Adı" HeaderStyle-HorizontalAlign="Center" HeaderStyle-VerticalAlign="Middle" />
                                <asp:BoundField DataField="Aciklama" HeaderText="Açıklama" HeaderStyle-HorizontalAlign="Center" HeaderStyle-VerticalAlign="Middle" />
                            </Columns>
                            <EditRowStyle ForeColor="Red" HorizontalAlign="Center" VerticalAlign="Middle" />
                            <FooterStyle BackColor="#47BAC1" ForeColor="#333333" />
                            <HeaderStyle BackColor="#47BAC1" Font-Bold="True" ForeColor="White" Font-Strikeout="False" Font-Underline="True" HorizontalAlign="Center" VerticalAlign="Middle" />
                            <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" VerticalAlign="Middle" />
                            <RowStyle BackColor="White" ForeColor="#333333" HorizontalAlign="Center" VerticalAlign="Middle" />
                            <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" VerticalAlign="Middle" />
                            <SortedAscendingCellStyle BackColor="#F7F7F7" />
                            <SortedAscendingHeaderStyle BackColor="#487575" />
                            <SortedDescendingCellStyle BackColor="#E5E5E5" />
                            <SortedDescendingHeaderStyle BackColor="#275353" />
                        </asp:GridView>
                        <br />
                        <asp:LinkButton ID="lbEkle" ForeColor="GrayText" runat="server" OnClick="lbEkle_Click">Alt Kategori Ekle</asp:LinkButton>
                        <br />
                        <br />
                        <asp:Panel ID="pnlEkle" runat="server" Visible="false">
                            <table style="width: 1544px">
                                <tr>
                                    <td>
                                        <asp:Label ID="lblAltKategoriAdi" runat="server" Text="Alt Kategori Adı" Font-Bold="True" Font-Names="Candara" Font-Size="Large"></asp:Label>&nbsp;:</td>
                                    <td>
                                        <asp:TextBox ID="txtAltKategoriAdi" runat="server" Width="810px" Height="28px"></asp:TextBox>
                                    </td>
                                </tr>
                               
                                <tr>
                                    <td><br><br/>
                                        <asp:Label ID="lblAciklama" runat="server" Text="Açıklama" Font-Bold="True" Font-Names="Candara" Font-Size="Large"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :</td>
                                    <td><br><br/>
                                        <asp:TextBox ID="txtAciklama" runat="server" Width="811px" TextMode="MultiLine" Height="39px"></asp:TextBox>
                                    </td>
                                </tr>

                                <tr>
                                    <td <tr="" colspan="2">
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        <asp:Button ID="btnKaydet" runat="server" CssClass="btn btn-primary btn-block" Height="40px" OnClick="btnKaydet_Click" Text="Kaydet" Width="100px" BackColor="#47BAC1" BorderColor="#33CCCC" BorderStyle="Double" BorderWidth="5px" Font-Bold="True" Font-Size="Small" />
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:Button ID="btnSil" runat="server" CssClass="btn btn-primary btn-block" Height="40px" OnClick="btnSil_Click" OnClientClick="return confirm('Silmek İstiyor musunuz?')" Text="Sil" Width="100px" BackColor="#47BAC1" BorderColor="#33CCCC" BorderStyle="Double" BorderWidth="5px" Font-Bold="True" Font-Size="Small" />
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                                        <asp:Button ID="btnDegistir" runat="server" CssClass="btn btn-primary btn-block" Height="40px" OnClick="btnDegistir_Click" Text="Değiştir" Width="100px" BackColor="#47BAC1" BorderColor="#33CCCC" BorderStyle="Double" BorderWidth="5px" Font-Bold="True" Font-Size="Small" />
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                    </div>
                </div>
            </div>
<%--    </section>--%>
</asp:Content>
