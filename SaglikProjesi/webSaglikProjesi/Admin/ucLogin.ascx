<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucLogin.ascx.cs" Inherits="webSaglikProjesi.Admin.WebUserControl1" %>
<link href="../Content/style/style.css" rel="stylesheet" />
<style type="text/css">
    .auto-style1 {
        height: 19px;
    }
</style>
<div>
    <table style="text-align: left; width: 397px;">
        <tr>
            <td colspan="2" style="text-align: center;" class="auto-style1">
                <h3>Admin Girişi</h3>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="username"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtuser" runat="server" Width="211px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvkullanici" runat="server" ErrorMessage="Kullanıcı adını boş bırakmayın" ControlToValidate="txtuser" ForeColor="red" ValidationGroup="1">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="password"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtsifre" runat="server" Width="211px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvsifre" runat="server" ErrorMessage="Şifreyi giriniz" ControlToValidate="txtuser" ForeColor="red" ValidationGroup="1">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnGiris" runat="server" Text="Giriş" CssClass="bluebutton" Width="83px" OnClick="btnGiris_Click" />
            </td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: center;">
                <asp:Label ID="lblmesaj" runat="server" ForeColor="Red" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: center;">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" />  </td>

        </tr>
    </table>

</div>
