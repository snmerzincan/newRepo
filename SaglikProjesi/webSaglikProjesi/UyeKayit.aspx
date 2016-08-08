<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="UyeKayit.aspx.cs" Inherits="webSaglikProjesi.UyeKayit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="width:355px; float:left">
          <table style="text-align:left;  width:355px">
            <tr>
                <td colspan="2" style="text-align:center">
                    <asp:Label ID="lblMesaj" runat="server" ForeColor="Red"></asp:Label> </td>
            </tr>
            <tr>
                <td  style="width:120px">
                    <asp:Label ID="Label1" runat="server" Text="kullanıcı adı(email)"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server" Width="200px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="kullanıcı adı boş geçilmez." ForeColor="Red" ValidationGroup="1">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revEmail" runat="server" ErrorMessage="Email formatı yanlış" ForeColor="Red" ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Şifre"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtSifre" runat="server" Width="200px" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvSifre" runat="server" ControlToValidate="txtSifre" ErrorMessage="şifre boş geçilmez." ForeColor="Red" ValidationGroup="1">*</asp:RequiredFieldValidator>
                </td>             
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Şifre Tekrar"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtSifreTekrar" runat="server" Width="200px" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvSifreTekrar" runat="server" ControlToValidate="txtSifreTekrar" ErrorMessage="şifre boş geçilmez." ForeColor="Red" ValidationGroup="1">*</asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="cvSifreTekrar" runat="server" ControlToCompare="txtSifre" ControlToValidate="txtSifreTekrar" ErrorMessage="şifreler aynı değil" ForeColor="Red" ValidationGroup="1">*</asp:CompareValidator>
                </td>             
            </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label8" runat="server" Text="Adı" ></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtAdi" runat="server" Width="200px" ></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvAdi" runat="server" ControlToValidate="txtAdi" ErrorMessage="İsim boş geçilmez." ForeColor="Red" ValidationGroup="1">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label9" runat="server" Text="Soyadı"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtSoyadi" runat="server" Width="200px" ></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvSoyadi" runat="server" ControlToValidate="txtSoyadi" ErrorMessage="soyisim boş geçilmez." ForeColor="Red" ValidationGroup="1">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label10" runat="server" Text="TCKimlik No"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtTCKNo" runat="server" Width="200px" ></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvTCKNo" runat="server" ControlToValidate="txtTCKNo" ErrorMessage="TCKNo boş geçilmez." ForeColor="Red" ValidationGroup="1">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label7" runat="server" Text="Telefon"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtTelefon" runat="server" Width="200px" ></asp:TextBox>
                    </td>
                </tr>
               <tr>
                    <td style="width:120px">
                        <asp:Label ID="Label4" runat="server" Text="Teslim Adresi"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtAdres" runat="server" TextMode="MultiLine" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="İlçe"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtIlce" runat="server" Width="200px" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="İl"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtIl" runat="server" Width="200px" ></asp:TextBox>
                    </td>
                </tr>
<tr>
    <td colspan="2" style="text-align:center">
        <asp:CheckBox ID="cbxSozlesme" runat="server" Text="Gizlilik Sözleşmesini Okudum" /></td>
</tr>
            <tr>
                <td></td>
                <td style="text-align:center">
                    <asp:Button ID="btnKayit" CssClass="bluebutton" runat="server" Text="Kayit Ol" Width="100px" OnClick="btnKayit_Click1" ValidationGroup="1"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnDevam" CssClass="bluebutton" runat="server" Text="Devam" Width="100px"  ValidationGroup="2" /></td>
            </tr>
        </table>
    </div>
    <div style="float:left; width:140px">
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" Width="136px" Height="73px" ValidationGroup="1" />
        <br /><br /><br />
        <asp:TextBox ID="txtSozlesme" runat="server" TextMode="MultiLine" Text="Gizlilik Sözleşmesi : Girmiş olduğunuz kişisel bilgileriniz 3.şahıs ve kurumlarla kesinlikle paylaşılmayacaktır. Her türlü özel bilgi ve ödeme işlemleriniz 128 bit SSL güvenlik sertifikalarıyla şifrelenmektedir." Font-Names="Verdana" Font-Size="8pt" Height="145px" Width="128px"></asp:TextBox>
    </div>
    
</asp:Content>
