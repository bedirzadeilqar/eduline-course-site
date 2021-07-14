<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Adminhaqqimizda.aspx.cs" Inherits="WebApplication5.Adminhaqqimizda" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Eduline" runat="server">
    <div class="container">
<form method="post" action="#"  enctype="multipart/form-data" runat="server">



              <div class="row">
                <div class="form-group col-md-3">
                  <label>Facebook Linki</label>
                    <input name="ctl00$ContentPlaceHolder1$textboxfacebookurl" runat="server"  id="facebook" type="text" class="form-control">
                </div>
                <div class="form-group col-md-3">
                  <label>Instagram linki</label>
                    <input name="ctl00$ContentPlaceHolder1$textboxinstagramurl" runat="server"  id="instagram" type="text" class="form-control">
                </div>
                <div class="form-group col-md-3">
                  <label>Youtube Linki</label>
                    <input name="ctl00$ContentPlaceHolder1$textboxyoutubeurl" runat="server"  id="youtube" type="text" class="form-control">
                </div>
                <div class="form-group col-md-3">
                  <label>Twitter linki</label>
                    <input name="ctl00$ContentPlaceHolder1$textboxtwitterurl" runat="server"  id="twitter" type="text" class="form-control">
                </div>
                <div class="form-group col-md-3">
                  <label>Sayt linki</label>
                    <input name="ctl00$ContentPlaceHolder1$textboxwebsiteurl" runat="server"  id="website" type="text" class="form-control">
                </div>
                <div class="form-group col-md-3">
                  <label>Email</label>
                    <input name="ctl00$ContentPlaceHolder1$textboxemail" runat="server"  id="email" type="text" class="form-control">
                </div>
                <div class="form-group col-md-3">
                  <label>Telefon 1</label>
                    <input name="ctl00$ContentPlaceHolder1$textboxtelefon1" runat="server"  id="telefon1" type="text" class="form-control">
                </div>
                <div class="form-group col-md-3">
                  <label>Telefon 2</label>
                    <input name="ctl00$ContentPlaceHolder1$textboxtelefon2" runat="server" id="telefon2" type="text" class="form-control">
                </div>
                <div class="form-group col-md-12">
                  <label>Sloqan</label>
                    <input name="ctl00$ContentPlaceHolder1$textboxsloqan" runat="server"  id="sloqan" type="text" class="form-control">
                </div>
                <div class="form-group col-md-12">
                  <label>Ünvan</label>
                    <input name="ctl00$ContentPlaceHolder1$textboxunvan"  runat="server" id="unvan" type="text" class="form-control">
                </div>
                <div class="form-group col-md-12">
                  <label>Slider Video linki</label>
                    <input name="ctl00$ContentPlaceHolder1$textboxVideoUrl" runat="server"  id="Video" type="text" class="form-control">
                </div>
                <div class="form-group col-md-9">
                  <label>Haqqında məlumat</label>
                     <textarea name="ctl00$ContentPlaceHolder1$txtAutoSize" runat="server" id="Size" textmode="MultiLine" onkeyup="setHeight(this);" onkeydown="setHeight(this);" type="text" class="form-control" cols="20" rows="4">EduLine Study Abroad &amp; Language Center olaraq əsas hədəfimiz tələbələrə təhsil almalarında sərhədləri aşmağa kömək etməkdir. Yeni dil imkanlarına sahib olmaqla dünyanın istənilən mədəniyyətini yaxından öyrənmək, yeni məlumatlar əldə etmək və ən əsası təhsil almaq mümkündür. Uyğun hədəflərinizə çatmağınız üçün ən sərfəli və keyfiyyətli tədris metodu ilə xarici dilləri sizə ana diliniz kimi doğma edirik. Təcrübəli və əzmkar müəllim və işçi heyətimizlə xaricdə ixtisasartırma və təhsillə bağlı istəklərinizi reallaşdırmağa hazırıq...</textarea>
                </div>
                <div class="form-group col-md-3 text-center" style="margin-top:27px">
                    <input type="file" name="ctl00$ContentPlaceHolder1$FileUploadSekil" runat="server" id="Sekil">
                </div>
                <div class="form-group col-md-3" style="margin-top:4px">
                  <asp:Button  Text="Tesdiq" runat="server"  id="Tesdiq" OnClick="Tesdiq_Click"/>
                </div>
              </div>
            </form>

    </div>
</asp:Content>
