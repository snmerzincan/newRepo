<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="KategoriEkle.aspx.cs" Inherits="webprojetasarım.Admin.KategoriEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <!-- MAIN CONTENT SECTION -->
   <%-- <section class="mainContent clearfix productsContent">--%>
    <br />
    <br />
    <br />

        <div class="container">
            <div class="row">
                 <div class="col-md-9 col-sm-8 col-xs-12">
                    <div class="row">
                        <%--Kategori Bilgileri--%>
                        <asp:GridView ID="gvKategoriler" runat="server" AutoGenerateColumns="False" Width="933px" OnSelectedIndexChanged="gvKategoriler_SelectedIndexChanged" Height="230px" DataKeyNames="KategoriID" BorderColor="#47BAC1" BorderStyle="Solid" BorderWidth="5px" Font-Bold="True" Font-Names="Courier New" Font-Size="Medium">
                            <Columns>
                                <asp:CommandField HeaderText="Seç" SelectText="&gt;&gt;" ControlStyle-Width="50px" ShowSelectButton="True" />
                                <asp:BoundField DataField="KategoriAd" HeaderText="Kategori Adı" />
                                <asp:BoundField DataField="Aciklama" HeaderText="Açıklama" />
                            </Columns>
                            <HeaderStyle BackColor="#47BAC1" Font-Bold="True" Font-Names="Courier New" Font-Size="Medium" Font-Underline="True" ForeColor="White" HorizontalAlign="Center" VerticalAlign="Middle" />
                            <RowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            <SelectedRowStyle BackColor="#006666" Font-Bold="True" Font-Italic="True" ForeColor="White" />
                        </asp:GridView>
                        <br />
                        <asp:LinkButton ID="lbEkle" ForeColor="GrayText" runat="server" OnClick="lbEkle_Click">Kategori Ekle</asp:LinkButton>
                        <br />
                        <br />
                        <asp:Panel ID="pnlEkle" runat="server" Visible="false">
                            <table style="width: 300px">
                                <tr>
                                    <td>
                                        <asp:Label ID="lblKategoriAd" runat="server" Text="Kategori Adı" Font-Bold="True" Font-Names="Candara" Font-Size="Large"></asp:Label>&nbsp;:</td>
                                    <td>
                                        <asp:TextBox ID="txtKategoriAdi" runat="server" Width="810px" Height="28px"></asp:TextBox>
                                    </td>
                                </tr>
                               
                                <tr>
                                    <td><br><br/>
                                        <asp:Label ID="lblAciklama" runat="server" Text="Açıklama" Font-Bold="True" Font-Names="Candara" Font-Size="Large"></asp:Label>:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :</td>
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
                 <%--   </div>
                </div>
            </div>--%>
<%--    </section>--%>
</asp:Content>
