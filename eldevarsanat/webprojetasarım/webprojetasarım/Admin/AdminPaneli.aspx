<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="AdminPaneli.aspx.cs" EnableEventValidation="false" Inherits="webprojetasarım.AdminPaneli" %>

<%@ Register Src="~/Admin/Adminİslemleri.ascx" TagPrefix="uc1" TagName="Adminİslemleri" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="pnlGiris" runat="server">
        <uc1:Adminİslemleri runat="server" ID="Adminİslemleri" />
    </asp:Panel>
</asp:Content>
