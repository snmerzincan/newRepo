<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Adminİslemleri.ascx.cs" Inherits="webprojetasarım.Admin.Adminİslemleri" %>
<!-- MAIN CONTENT SECTION -->
<section class="mainContent clearfix logIn">
    <div class="container">
        <div class="row">
       
            <div class="col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2 col-xs-12">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        <h3 style="text-align: center; font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; font-weight: bold; font-size: larger; color: white">Admin Girişi</h3>
                    </div>
                    <div class="panel-body">
                        <form action="" method="POST" role="form">
                            <div class="form-group">
                                <label for="">Kullanıcı Adı</label>
                                <%--<input type="email" class="form-control" id="">--%>
                                <asp:TextBox class="form-control" ID="txtKullaniciAdi" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="rfvKullaniciAdi" runat="server" ErrorMessage="Kullanıcı Adı boş geçilemez" ControlToValidate="txtKullaniciAdi" ValidationGroup="1" ForeColor="Red">*</asp:RequiredFieldValidator>
                            </div>
                            <div class="form-group">
                                <label for="">Şifre</label>
                                <%--  <input type="password" class="form-control" id="">--%>
                                <asp:TextBox class="form-control" ID="txtSifre" TextMode="Password" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="rfvSifre" runat="server" ErrorMessage="Şifre boş Geçilemez" ControlToValidate="txtSifre" ValidationGroup="1" ForeColor="red">*</asp:RequiredFieldValidator>
                            </div>

                            <%--<button type="submit" class="btn btn-primary btn-block"><a href="Anasayfa.aspx">Giriş</button>--%>

                            <div>
                                <asp:Button ID="btnGiris" Text="Giriş" class="btn btn-primary btn-block" runat="server" ValidationGroup="1" OnClick="btnGiris_Click" /></div>

                            <div>
                                <br />
                                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="1" ForeColor="red" />
                            </div>
                            <div>
                                <br />
                                <%--<asp:Button Text="Şifremi Unuttum" class="btn btn-link btn-block" runat="server" OnClick="Unnamed2_Click1" />--%>
                            </div>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
