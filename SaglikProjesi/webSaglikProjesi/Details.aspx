<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="webSaglikProjesi.Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <asp:DataList ID="dlstUrunler" runat="server" CellPadding="4" ForeColor="#333333" DataKeyField="urunid" RepeatColumns="1" Width="497px" Style="text-align: center" OnItemCommand="dlstUrunler_ItemCommand">
        <SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <ItemTemplate>
            <div>
                <asp:Label ID="lblurunad" runat="server" Text='<%#Eval("urunad")%>'></asp:Label>
                <br></br>
                <asp:ImageButton ID="imgresim" ImageUrl='<%#Eval("urunresimyolu2")%>' runat="server" CommandName="detay" CommandArgument='<%#Eval("urunid")%>' Width="220px" Height="240px" />
                <br></br>
                <asp:Label ID="lblurunfiyat" runat="server" Text='<%# Eval("urunfiyat","{0:N}") %>'></asp:Label>
                <br></br>
                <asp:TextBox ID="txtAdet" runat="server" Text="1" Width="20"></asp:TextBox>
                <br></br>
                <asp:ImageButton ID="btnsepeteat" runat="server" Text="Sepete Ekle" ImageUrl="~/Content/style/images/btnSepeteAt.png" CommandName="sepet" CommandArgument='<%#Eval("urunid")%>' />
                 <asp:Label ID="lblurunbilgi" runat="server" Text='<%#Eval("urunbilgisi")%>'></asp:Label>
                <br></br>
            </div>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
