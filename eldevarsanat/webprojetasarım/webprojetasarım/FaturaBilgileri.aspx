<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="FaturaBilgileri.aspx.cs" Inherits="webprojetasarım.FaturaBilgileri" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <!-- LIGHT SECTION -->
      <section class="lightSection clearfix pageHeader">
        <div class="container">
          <div class="row">
            <div class="col-xs-6">
              <div class="page-title">
                <h2>Adres</h2>
              </div>
            </div>
            <div class="col-xs-6">
              <ol class="breadcrumb pull-right">
                <li>
                  <a href="Anasayfa.aspx">Anasayfa</a>
                </li>
                <li class="active">Adres</li>
              </ol>
            </div>
          </div>
        </div>
      </section>
      
      <!-- MAIN CONTENT SECTION -->
      <section class="mainContent clearfix stepsWrapper">
        <div class="container">
          <div class="row">
            <div class="col-xs-12">
              <div class="innerWrapper clearfix stepsPage">
                <div class="row progress-wizard" style="border-bottom:0;">

                  <div class="col-xs-3 progress-wizard-step complete">
                    <div class="text-center progress-wizard-stepnum">Adres</div>
                    <div class="progress"><div class="progress-bar"></div></div>
                    <a href="FaturaBilgileri.aspx" class="progress-wizard-dot"></a>
                  </div>

                  <div class="col-xs-3 progress-wizard-step disabled">
                    <div class="text-center progress-wizard-stepnum">Teslimat Şekli</div>
                    <div class="progress"><div class="progress-bar"></div></div>
                    <a href="TeslimatSekli.aspx" class="progress-wizard-dot"></a>
                  </div>

                  <div class="col-xs-3 progress-wizard-step disabled">
                    <div class="text-center progress-wizard-stepnum">Ödeme Şekli</div>
                    <div class="progress"><div class="progress-bar"></div></div>
                    <a href="OdemeSekli.aspx" class="progress-wizard-dot"></a>
                  </div>

                  <div class="col-xs-3 progress-wizard-step disabled">
                    <div class="text-center progress-wizard-stepnum">Önizleme</div>
                    <div class="progress"><div class="progress-bar"></div></div>
                    <a href="Onizleme.aspx" class="progress-wizard-dot"></a>
                  </div>
                </div>
                
                <form action="" class="row" method="POST" role="form">
                  <div class="col-xs-12">
                    <div class="page-header">
                      <h4>Adres Bilgileri</h4>
                    </div>
                  </div>
                  <div class="form-group col-sm-6 col-xs-12">
                      <asp:Panel ID="Panel1" runat="server">
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
                    <asp:Button ID="btnGiris" runat="server" Text="Giriş" class="well well-lg clearfix" Width="83px" OnClick="btnGiris_Click"/>
                </td>
            </tr>
        </table>  <asp:CheckBox ID="cbxUnuttum" Text="Şifremi unuttum" runat="server"  AutoPostBack="True" OnCheckedChanged="cbxUnuttum_CheckedChanged" /><br/>
                          </asp:Panel>
      
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
                    <asp:TextBox ID="txtilce" runat="server" Width="208px" ></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="İl"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtIl" runat="server" Width="208px"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="Telefon"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtTelefon" runat="server" Height="19px" Width="207px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td></td>
                <td> 
                    <asp:Button ID="btnAdresOnay" runat="server" Text="Onay" class="well well-lg clearfix" Width="83px"  ValidationGroup="2" OnClick="btnAdresOnay_Click"/>
                </td>
            </tr>

        </table>
                          <asp:Label ID="lblmesaj" runat="server" Text="Label" ForeColor="red"></asp:Label>
            </asp:Panel>
                  <div class="col-xs-12 checkboxArea">
                    
                      <asp:CheckBox ID="chkAciklama" Checked="true" Text="Fatura için bu adresi kullan" runat="server" />
                  </div>
                  <div class="col-xs-12">
                    <div class="well well-lg clearfix">
                      <ul class="pager">
                      <li class="previous"><a href="#" class="hideContent">Geri</a></li>
                        <li class="next"><a href="TeslimatSekli.aspx">Devam</a></li>
                      </ul>
                    </div>
                  </div>
                </form>
              </div>
            </div>
          </div>
        </div>
      </section>
      
</asp:Content>
