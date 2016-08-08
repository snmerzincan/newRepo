<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Urunekle.aspx.cs" Inherits="webSaglikProjesi.Admin.Urunekle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div style="font-family:Verdana; font-size:small">
          <asp:Label ID="Label3" runat="server" Text="Kategori Seçiniz"></asp:Label><br />
          <asp:DropDownList ID="ddlKategoriler" runat="server" Width="120px" AutoPostBack="True" OnSelectedIndexChanged="ddlKategoriler_SelectedIndexChanged" ></asp:DropDownList>
            
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            
            <asp:DropDownList ID="ddlAltKategoriler" runat="server" AutoPostBack="True" Width="120px" OnSelectedIndexChanged="ddlAltKategoriler_SelectedIndexChanged"></asp:DropDownList>
            <br />
          <br />
        <asp:GridView ID="gvUrunler" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="505px" AutoGenerateColumns="False" DataKeyNames="urunid" OnSelectedIndexChanged="gvUrunler_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:CommandField ButtonType="Button" SelectText="&gt;" ShowSelectButton="True" />
                <asp:BoundField DataField="urunkodu" HeaderText="Ürün Kodu" />
                <asp:BoundField DataField="urunad" HeaderText="Ürün Adı" />
                <asp:BoundField DataField="miktar" HeaderText="Miktar" />
                <asp:BoundField DataField="urunfiyat" HeaderText="Fiyat">
                <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="urunbilgisi" HeaderText="Ürün bilgisi" />
                <asp:BoundField DataField="resimyolu1" HeaderText="Resim Yolu" Visible="False" />
                <asp:BoundField DataField="resimyolu2" HeaderText="Resim Yolu" Visible="False" />
                <asp:BoundField DataField="urunkategorino" HeaderText="KategoriNo" Visible="False" />
                <asp:BoundField DataField="urunaltkategorino" HeaderText="AltKategoriNo" Visible="False" />
                <asp:BoundField DataField="urunid" HeaderText="urunid" Visible="False" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView><br />
        <br />
        <asp:LinkButton ID="lbYeniUrun" runat="server" OnClick="lbYeniUrun_Click"  >Yeni Ürün Ekle</asp:LinkButton>
            <br />
        <br />
        <asp:Panel ID="pnlEkle" runat="server" Visible="false">
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Ürün Kodu :"></asp:Label>

                    </td>
                    <td>
                        <asp:TextBox ID="txtUrunKodu" runat="server" Width="160px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Ürün Adı :"></asp:Label>

                    </td>
                    <td>
                        <asp:TextBox ID="txtUrunAdi" runat="server" Width="160px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Ürün Miktar:"></asp:Label>

                    </td>
                    <td>
                        <asp:TextBox ID="txtMiktar" runat="server" Width="160px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="Ürün Fiyat:"></asp:Label>

                    </td>
                    <td>
                        <asp:TextBox ID="txtFiyat" runat="server" Width="160px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Ürün Bilgisi :"></asp:Label>

                    </td>
                    <td>
                        <asp:TextBox ID="txtUrunBilgisi" runat="server" Height="36px" TextMode="MultiLine" Width="160px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label7" runat="server" Text="Küçük Resim:"></asp:Label>

                    </td>
                    <td>
                        <asp:FileUpload ID="fuKucukResim" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label8" runat="server" Text="Büyük Resim:"></asp:Label>

                    </td>
                    <td>
                        <asp:FileUpload ID="fuBuyukResim" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" style="text-align:center">
                        <asp:Button ID="btnKaydet" runat="server" Text="Kaydet" Width="80px" OnClick="btnKaydet_Click"  />
                        <asp:Button ID="btnDegistir" runat="server" Text="Değiştir" Width="80px"  />
                        <asp:Button ID="btnSil" runat="server" Text="Sil" Width="80px"  />
                    </td>
                </tr>
            </table>

        </asp:Panel>


   </div>

</asp:Content>
