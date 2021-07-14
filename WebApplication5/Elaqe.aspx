<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Elaqe.aspx.cs" Inherits="WebApplication5.Elaqe" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Eduline" runat="server">
    <section class="contact container">
		<div class="row ipu">
			<div class="col-sm-6">
				<h2>Əlaqə Formu</h2>
                <form runat="server">
				<label>AD:</label>&nbsp;&nbsp;&nbsp;&nbsp;<input runat="server" id="name" type="text" name="ad" placeholder="ad">
                    &nbsp;&nbsp;<label>Email:</label>&nbsp;&nbsp;&nbsp;
                    <input runat="server" id="email" type="text" name="email" placeholder="email adresi"><br>
				<label>Basliq</label><input runat="server" id="basliq" type="text" name="basliq" placeholder="basliq">&nbsp;&nbsp;<label>Telefon:</label><input runat="server" id="number" type="text" name="telefon" placeholder="telefon"><br>
				<label>Mesajiniz:</label><textarea runat="server" id="message" placeholder="mesajiniz"></textarea><br><br>
                
                <asp:Button runat="server" Text="mesaji gonder" ID="Send" OnClick="Send_Click" />

				<%--<a href="#">mesaji gonder</a>&nbsp;&nbsp;--%>
                <a href="#" class="xanat">xanalari temizle</a>
                </form>
			</div>
			<div class="col-sm-6">
				<h2>Əlaqə Vasitələri </h2><br>
				Bizimlə əlaqə üçün aşağıdakı vasitələrdən birini seçə bilərsiniz.<br>
                <a href="#" class="fa fa-facebook hn" id="ilkhn"></a>
                <a href="#" class="fa fa-twitter hn"></a>
                <a href="#" class="fa fa-google hn"></a>
                <a href="#" class="fa fa-linkedin hn"></a>
                <br>
                <ul class="kul" type="none">
                	<li class="li">
                       <div class="left"><i class="fas fa-map-marked-alt"></i></div>
                       <div class="right mt-3 ml-4"><p>Ünvan
                       <span>Nizami küç. 203B</span></p></div>
                    </li>
                    <li class="li">
                       <div class="left"><i class="fas fa-phone-alt"></i></div>
                       <div class="right mt-3 ml-4"><p>Əlaqə nömrələri
                       <span>0557670790</span></p></div>
                    </li>
                    <li class="li">
                       <div class="left"><i class="fas fa-envelope"></i></div>
                       <div class="right mt-3 ml-4"><p>Email adresi
                       <span>
                          Email adresi
                          info@eduline.az</span></p></div>
                    </li>
                </ul>
			</div>
		</div>
	</section>
</asp:Content>
