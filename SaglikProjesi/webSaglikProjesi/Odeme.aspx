<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Odeme.aspx.cs" Inherits="webSaglikProjesi.Odeme" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="text-align:center">
<img src="Content/style/images/odeme2.jpg" />
  <br /><br />
<table style="width:350px; text-align:left" >
    <tr>
        <td style="width:130px;"><asp:Label ID="lbl1" runat="server" Text="Adı"></asp:Label>   </td>
         <td><asp:Label ID="lbladi" runat="server" Text="Adi"></asp:Label>   </td>
    </tr>
     <tr>
        <td><asp:Label ID="lbl2" runat="server" Text="Soyadı"></asp:Label>   </td>
         <td><asp:Label ID="lblSoyadi" runat="server" Text="Soyadı"></asp:Label>   </td>
    </tr>
    <tr>
        <td><asp:Label ID="lbl3" runat="server" Text="Alışveriş Tutar"></asp:Label>   </td>
         <td><asp:Label ID="lblTutar" runat="server" Text="Tutar"></asp:Label>   </td>
    </tr>    <tr><td></td><td></td></tr>
    <tr>
        <td>
            <asp:Button ID="btnKredikarti" Width="110px" CssClass="bluebutton" runat="server" Text="Kredi Kartı" /> </td >
            <td><asp:Button ID="btnhavaleeft" CssClass="bluebutton" runat="server" Text="Havale/EFT" OnClick="btnhavaleeft_Click" /></td>
    </tr>
    </table>
        <asp:Panel ID="Panel1" runat="server">
    <table style="width:350px; text-align:left">
         <tr>
        <td style="width:130px;"><asp:Label ID="Label2" runat="server" Visible="false" Text="Firma Ünvan"></asp:Label>   </td>
         <td><asp:Label ID="Label4" runat="server" Text="MS-YAZ-10 Sağlık Ürünleri Projesi"></asp:Label>   </td>
    </tr>
         <tr>
        <td><asp:Label ID="Label6" runat="server" Text="Banka"></asp:Label>   </td>
         <td><asp:Label ID="Label7" runat="server" Text="Garanti Bankası"></asp:Label>   </td>
    </tr>
         <tr>
        <td><asp:Label ID="Label8" runat="server" Text="Şube"></asp:Label>   </td>
         <td><asp:Label ID="Label9" runat="server" Text="Beşiktaş-Barbaros"></asp:Label>   </td>
    </tr>
         <tr>
        <td><asp:Label ID="Label10" runat="server" Text="Hesap No"></asp:Label>   </td>
         <td><asp:Label ID="Label11" runat="server" Text="5246246"></asp:Label>   </td>
    </tr>
         
         <tr>
        <td><asp:Label ID="Label12" runat="server" Text="IbanNO"></asp:Label>   </td>
         <td><asp:Label ID="Label13" runat="server" Text="TR 12 3426 5464 5486 1548"></asp:Label>   </td>
    </tr>
         <tr>
        <td>
            <asp:Button ID="btndevam" Width="110px" CssClass="bluebutton" runat="server" Text="Devam" OnClick="btndevam_Click" /> </td >
            <td><asp:Button ID="btncikis" CssClass="bluebutton" runat="server" Text="Güvenli çıkış" OnClick="btncikis_Click" /></td>
    </tr>
</table>
</asp:Panel>
</div>
</asp:Content>
