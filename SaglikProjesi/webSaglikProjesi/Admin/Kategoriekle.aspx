<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Kategoriekle.aspx.cs" Inherits="webSaglikProjesi.Admin.Kategoriekle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 78px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:GridView ID="gvKategoriler" runat="server" AutoGenerateColumns="False" Width="353px" CellPadding="4" ForeColor="#333333" GridLines="None" DataKeyNames="ID" OnRowEditing="gvKategoriler_RowEditing" OnSelectedIndexChanged="gvKategoriler_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField SelectText="Seç" ShowSelectButton="True" />
                <asp:BoundField DataField="kategoriad" HeaderText="KategoriAdı" />
                <asp:BoundField DataField="aciklama" HeaderText="Acıklama" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView><br /><br />
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" >Yeni Kategori</asp:LinkButton> <br /><br />
        <asp:Panel ID="pnlEkle" Visible="false" runat="server">
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Kategori:"></asp:Label>

                    </td>
                    <td>
                        <asp:TextBox ID="txtKategori" runat="server" Width="160px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Açıklama  :"></asp:Label>

                    </td>
                    <td>
                        <asp:TextBox ID="txtAciklama" runat="server" Height="36px" TextMode="MultiLine" Width="160px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" style="text-align:left">
                        <asp:Button ID="btnKaydet" runat="server" Text="Kaydet" Width="80px" OnClick="btnKaydet_Click" />
                        <asp:Button ID="btndegistir" runat="server" Text="Değiştir" Width="80px" OnClick="btndegistir_Click"  />
                        <asp:Button ID="btnsil" runat="server" Text="Sil" Width="80px" OnClick="btnsil_Click" />
                    </td>
                  
                </tr>
            </table>
        </asp:Panel>
    </div>
</asp:Content>
