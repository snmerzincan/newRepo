<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Adres.aspx.cs" Inherits="webSaglikProjesi.Adres" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 120px;
            height: 38px;
        }
        .auto-style2 {
            height: 38px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <%--  <script type="text/javascript">
        var baslik = this.document.getElementById("Baslik2");
        baslik.innerText = "Sepet İşlemleri";
    </script>--%>
    <div style ="text-align:center">
        <img src="Content/style/images/adresonay2.jpg" /></br>
        Sitemizden alışveriş yapabilmeni için üye olmanız gerekmektedir. Eğer üye değilseniz <a href="Uyekayit.aspx"> yeni üye kaydı için tıklayınız.</a></br>
         <table style="text-align:left; width:400px;">
            <tr>
                <td>
                <asp:Label ID="Label1" runat="server" Text="kullanıcı adı (e-mail)"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtemail" runat="server" Width="211px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvkullanici" runat="server" ErrorMessage="Kullanıcı adını boş bırakmayın" ControlToValidate="txtemail" ForeColor="red" ValidationGroup="1">*</asp:RequiredFieldValidator>
               </td>
            </tr>
            <tr>
                 <td>
                <asp:Label ID="Label2" runat="server" Text="sifre"></asp:Label></td>
                 <td>
                    <asp:TextBox ID="txtsifre" runat="server" Width="211px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvsifre" runat="server" ErrorMessage="Şifreyi giriniz" ControlToValidate="txtemail" ForeColor="red" ValidationGroup="1">*</asp:RequiredFieldValidator>
               </td>
            </tr>
            <tr>
                <td></td>
                <td> 
                    <asp:Button ID="btnGiris" runat="server" Text="Giriş" CssClass="bluebutton" Width="83px" OnClick="btnGiris_Click"/>
                </td>
            </tr>
        </table>
        <asp:CheckBox ID="cbxUnuttum" Text="Şifremi unuttum" runat="server" OnCheckedChanged="cbxUnuttum_CheckedChanged" AutoPostBack="True" /><br/>
        <asp:Label ID="lblmesaj" runat="server" Text="Label" ForeColor="red"></asp:Label>
        <asp:Panel ID="pnladres" runat="server" Visible="false">

        <table style="text-align:left; width:400px;">
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label3" runat="server" Text="Teslim Adresi"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtadres" runat="server" TextMode="MultiLine" Width="211px"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="İlçe"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtilce" runat="server" ></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="İl"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtIl" runat="server"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="Telefon"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtTelefon" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td></td>
                <td> 
                    <asp:Button ID="btnAdresOnay" runat="server" Text="Adres Onay" CssClass="bluebutton" Width="83px" OnClick="btnAdresOnay_Click" ValidationGroup="2"/>
                </td>
            </tr>

        </table>
            </asp:Panel>
    </div>
</asp:Content>
