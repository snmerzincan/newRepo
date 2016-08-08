<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Sepet.aspx.cs" Inherits="webSaglikProjesi.Sepet" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    &nbsp;
<%--   /* <script type="text/javascript">
        var baslik = this.document.getElementById("Baslik2");
        baslik.innerText = "Sepet İşlemleri";
    </script> --%>
    <center>
    <img src="Content/style/images/sepetonay2.jpg" />
    <br/>
    <asp:GridView ID="gvSepet" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="sepetID" ForeColor="#333333" GridLines="None" ShowFooter="True" Width="396px" OnRowDeleting="gvSepet_RowDeleting">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="urunID" HeaderText="UrunID" Visible="False" />
            <asp:BoundField DataField="urunAd" HeaderText="Urun Adı" />
            <asp:BoundField DataField="Adet" HeaderText="Adet" >
            <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="Fiyat" HeaderText="Fiyat" >
            <ItemStyle BorderStyle="None" HorizontalAlign="Right" />
            </asp:BoundField>
            <asp:BoundField DataField="Tutar" HeaderText="Tutar" >
            <ItemStyle HorizontalAlign="Right" />
            </asp:BoundField>
            <asp:CommandField DeleteText="Sil" ShowDeleteButton="True" />
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <PagerTemplate>
            &nbsp;
        </PagerTemplate>
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
        <EmptyDataTemplate>Sepetinizde ürün bulunmamaktadır.</EmptyDataTemplate>
    </asp:GridView>
         <br />
        <asp:Button CssClass="bluebutton" ID="btnSepetiBosalt" runat="server" Text="Sepeti Bosalt" Width="101px" OnClick="btnSepetiBosalt_Click" />
         <asp:Button CssClass="bluebutton" ID="btndevam" runat="server" Text="Alışverişe Devam" OnClick="btndevam_Click" />
     <asp:Button CssClass="bluebutton" ID="btnSatinAl" runat="server" Text="Satın Al" Width="90px" OnClick="btnSatinAl_Click" />
          </center>
</asp:Content>
