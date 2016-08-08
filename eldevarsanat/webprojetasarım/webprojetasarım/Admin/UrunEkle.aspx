<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="UrunEkle.aspx.cs" Inherits="webprojetasarım.Admin.UrunEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <!-- MAIN CONTENT SECTION -->
    <%--    <section class="mainContent clearfix productsContent">--%>
    <br />
    <br />
    <br />
    <div class="container">
        <div class="row">
            <div class="col-md-9 col-sm-8 col-xs-12">
                <div class="row filterArea">
                    <div class="col-xs-6">
                        <asp:DropDownList ID="ddlKategoriler" runat="server" Height="16px" Width="132px" OnSelectedIndexChanged="ddlKategoriler_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="ddlAltKategoriler" runat="server" Height="16px" Width="132px" OnSelectedIndexChanged="ddlAltKategoriler_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
                    </div>
                </div>
         
        <div class="row">
            <%--Ürün Bilgileri--%>
            <br />
            <asp:GridView ID="gvUrunler" runat="server" AutoGenerateColumns="False" Height="235px" Width="843px" CellPadding="3" ForeColor="Black" OnSelectedIndexChanged="gvUrunler_SelectedIndexChanged" DataKeyNames="UrunID" BackColor="White" BorderColor="#47BAC1" BorderStyle="Solid" BorderWidth="5px">
                <AlternatingRowStyle BackColor="#CCCCCC" />
                <Columns>
                    <asp:CommandField HeaderText="Select" SelectText="&gt;&gt;" ShowSelectButton="True" />
                    <asp:BoundField DataField="UrunID" HeaderText="ID" Visible="False" />
                    <asp:BoundField DataField="UrunKodu" HeaderText="Ürün Kodu" />
                    <asp:BoundField DataField="UrunAd" HeaderText="Ürün Adı" />
                    <asp:BoundField DataField="Miktar" HeaderText="Miktar" />
                    <asp:BoundField DataField="Fiyat" HeaderText="Fiyat" />
                    <asp:BoundField DataField="Aciklama" HeaderText="Aciklama" />
                </Columns>
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="#47BAC1" Font-Bold="True" ForeColor="White" Font-Names="Courier New" Font-Size="Large" Font-Underline="True" HorizontalAlign="Center" VerticalAlign="Middle" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <RowStyle Font-Bold="True" Font-Names="Courier New" Font-Size="Medium" HorizontalAlign="Center" VerticalAlign="Middle" />
                <SelectedRowStyle BackColor="#006666" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#808080" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>
            <br />
            <asp:LinkButton ID="lbEkle" ForeColor="GrayText" runat="server" OnClick="lbEkle_Click">Yeni Ürün Ekle</asp:LinkButton>
            <br />
            <br />
            <asp:Panel ID="pnlEkle" runat="server" Visible="false">
                <table style="width: 1565px">

                    <tr>
                        <td>
                            <asp:Label ID="Label5" runat="server" Text="Ürün Kodu" Font-Bold="True" Font-Names="Courier New" Font-Size="Medium"></asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtUrunKodu" runat="server" Width="650px" Height="25px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label6" runat="server" Text="Ürün Adı" Font-Bold="True" Font-Names="Courier New" Font-Size="Medium"></asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtUrunAdi" runat="server" Width="649px" Height="25px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text="Miktar" Font-Bold="True" Font-Names="Courier New" Font-Size="Medium"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtMiktar" runat="server" Width="650px" Height="25px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label3" runat="server" Text="Fiyat" Font-Bold="True" Font-Names="Courier New" Font-Size="Medium"></asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtFiyat" runat="server" Width="651px" Height="25px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text="Açıklama" Font-Bold="True" Font-Names="Courier New" Font-Size="Medium"></asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtAciklama" runat="server" Width="650px" TextMode="MultiLine" Height="40px"></asp:TextBox>
                        </td>
                    </tr>

                    <tr>
                        <td>
                            <asp:Label ID="Label4" runat="server" Text="Resim" Font-Bold="True" Font-Names="Courier New" Font-Size="Medium"></asp:Label></td>
                        <td>
                            <asp:FileUpload ID="fuResim" runat="server" Height="25px" Width="201px"></asp:FileUpload>
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
   <%-- </section>--%>
</asp:Content>
