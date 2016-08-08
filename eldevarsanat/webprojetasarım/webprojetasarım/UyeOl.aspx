<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="UyeOl.aspx.cs" EnableEventValidation="false" Inherits="webprojetasarım.UyeOl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- LIGHT SECTION -->
      <section class="lightSection clearfix pageHeader">
        <div class="container">
          <div class="row">
            <div class="col-xs-6">
              <div class="page-title">
                <h2>Üye Kayıt</h2>
              </div>
            </div>
            <div class="col-xs-6">
              <ol class="breadcrumb pull-right">
                <li>
                  <a href="Anasayfa.aspx">Anasayfa</a>
                </li>
                <li class="active">Üye Kayıt</li>
              </ol>
            </div>
          </div>
        </div>
      </section>
      
      <!-- MAIN CONTENT SECTION -->
     
      <section class="mainContent clearfix signUp">
        <div class="container">
          <div class="row">
            <div class="col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2 col-xs-12">
              <div class="panel panel-default">
                <div class="panel-heading"><h3>Üye Ol</h3></div>
                <div class="panel-body">
                    <form action="" method="POST" role="form">
                        <div class="form-group">
                            <asp:Label ForeColor="red" ID="lblMesaj" runat="server"></asp:Label>
                        </div>
                        <div class="form-group">
                            <label for="">Kullanıcı Adı</label>
                            <%--  <input type="text" class="form-control" id="">--%>
                            <asp:TextBox class="form-control" ID="txtKullaniciAdi" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvKullaniciAdi" runat="server" ControlToValidate="txtKullaniciAdi" ErrorMessage="Kullanıcı Adı boş geçilemez" ForeColor="red" ValidationGroup="1">*</asp:RequiredFieldValidator>
                        </div>
                        <div class="form-group">
                            <label for="">Şifre</label>
                            <%-- <input type="password" class="form-control" id="">--%>
                            <asp:TextBox class="form-control" ID="txtsifre" TextMode="Password" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvsifre" runat="server" ControlToValidate="txtsifre" ErrorMessage="Şifre boş geçilemez" ForeColor="red" ValidationGroup="1">*</asp:RequiredFieldValidator>
                        </div>
                        <div class="form-group">
                            <label for="">Şifre Tekrar</label>
                            <%-- <input type="password" class="form-control" id="">--%>
                            <asp:TextBox class="form-control" ID="txtsifretekrar" TextMode="Password" runat="server"></asp:TextBox>
                            <asp:CompareValidator ID="rfvsifretekrar" ControlToValidate="txtsifretekrar" ControlToCompare="txtsifre" ForeColor="red" runat="server" ErrorMessage="Şifreler aynı olmalıdır" ValidationGroup="1">*</asp:CompareValidator>
                        </div>
                        <div class="form-group">
                            <label for="">Ad</label>
                            <%--  <input type="text" class="form-control" id="">--%>
                            <asp:TextBox class="form-control" ID="txtad" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvad" runat="server" ControlToValidate="txtad" ErrorMessage="Ad alanı boş geçilemez" ForeColor="red" ValidationGroup="1">*</asp:RequiredFieldValidator>
                        </div>
                        <div class="form-group">
                            <label for="">Soyad</label>
                            <%--<input type="text" class="form-control" id="">--%>
                            <asp:TextBox class="form-control" ID="txtsoyad" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvsoyad" runat="server" ControlToValidate="txtsoyad" ErrorMessage="Soyad alanı boş geçilemez" ForeColor="red" ValidationGroup="1">*</asp:RequiredFieldValidator>
                        </div>
                        <div class="form-group">
                            <label for="">TC Kimlik No</label>
                            <%--<input type="email" class="form-control" id="">--%>
                            <asp:TextBox class="form-control" ID="txtTCKNo" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvTCKNo" runat="server" ControlToValidate="txtTCKNo" ForeColor="red" ErrorMessage="TC Kimlik No boş geçilemez" ValidationGroup="1">*</asp:RequiredFieldValidator>
                        </div>
                        <div class="form-group">
                            <label for="">Telefon</label>
                            <%--<input type="email" class="form-control" id="">--%>
                            <asp:TextBox class="form-control" ID="txtTelefon" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="">Adres</label>
                            <%--<input type="email" class="form-control" id="">--%>
                            <asp:TextBox class="form-control" ID="txtAdres" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvAdres" runat="server" ControlToValidate="txtAdres" ForeColor="red" ErrorMessage="Adres boş geçilemez" ValidationGroup="1">*</asp:RequiredFieldValidator>
                        </div>
                        <div class="form-group">
                            <label for="">İl</label>
                            <%--<input type="email" class="form-control" id="">--%>
                            <asp:TextBox class="form-control" ID="txtil" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="">İlçe</label>
                            <%--<input type="email" class="form-control" id="">--%>
                            <asp:TextBox class="form-control" ID="txtilce" runat="server"></asp:TextBox>
                            </div><br />
                            <div class="form-group">
                                <asp:CheckBox Text="Gizlilik Sözleşmesini okudum." ID="cbxSozlesme" runat="server" /></div>
                                <%-- <asp:RequiredFieldValidator ID="rfvSozlesme" ForeColor="red"  runat="server" ErrorMessage="Gizlilik Sözleşmesini kabul ediniz"  ValidationGroup="1"></asp:RequiredFieldValidator>--%>
                            
                            <%--<button type="submit" class="btn btn-primary btn-block" >Gönder</button>--%>
                            <asp:Button ValidationGroup="1" Text="Kayıt Ol" ID="btnKayit" CssClass="btn btn-primary btn-block" runat="server" OnClick="btnKayit_Click" />
                            <div>
                                <br />
                                <asp:ValidationSummary ID="ValidationSummary1" ValidationGroup="1" runat="server" ForeColor="Red" />
                            </div>
                    </form>
                </div>
              </div>
            </div>
          </div>
        </div>
      </section>
</asp:Content>
