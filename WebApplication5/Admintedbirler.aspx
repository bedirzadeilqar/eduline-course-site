<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Admintedbirler.aspx.cs" Inherits="WebApplication5.Admintedbirler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Eduline" runat="server">
    <div class="container">
    <form runat="server">
	<%--<section class="container">--%>
		<div class="row">
			<div class="col-sm-6">
				<input runat="server" class="form-group" type="file" name="file" id="photo"><br />
				<label style="color: red;" class="hy" for="usr">Basliq:</label>
				<input runat="server" id="basliq" type="text" name="basliq" class="form-control" placeholder="basliq"><br />
				<label class="hy" for="usr">Detal:</label>
				<input runat="server" id="detal" type="text" name="detal" class="form-control"  placeholder="detal">
                <label class="hy" for="usr">Ay:</label>
				<input runat="server" id="ay" type="text" name="detal" class="form-control"  placeholder="ay">
                <label class="hy" for="usr"Gun:</label>
				<input runat="server" id="gun" type="text" name="detal" class="form-control"  placeholder="gun">
                <label class="hy" for="usr"Gun:</label>
				<input runat="server" id="il" type="text" name="detal" class="form-control"  placeholder="il">
                <label class="hy" for="usr"Gun:</label>
				<input runat="server" id="saat" type="text" name="detal" class="form-control"  placeholder="saat">
                <label class="hy" for="usr"Gun:</label>
				<input runat="server" id="konum" type="text" name="detal" class="form-control"  placeholder="konum">
			</div>
			<div class="col-sm-6"></div>
		</div>
		</div>

		<div class="w3-container">
           <h1>Tedbirler(Siyahi)</h1>
  <table class="w3-table-all">
    <thead runat="server">
      <tr class="w3-light-grey w3-hover-red">
         <th>Id</th>
		  <th>TedbirlerBasliq</th>
		  <th>Tedbirlerdetal</th>
		  <th>TedbirlerAy</th>
		  <th>TedbirlerGun</th>
		  <th>TedbirlerIl</th>
		  <th>TedbirlerSaat</th>
		  <th>TedbirlerKonum</th>
		  <th>TedbirlerPhoto</th>
		  <th class="text-center"><i class="fa fa-plus"></i></th>
      </tr>
    </thead>
      <tbody runat="server" id="tbody">

      </tbody>
  </table>
</div>
        <asp:Button runat="server" id="add" Text="add" OnClick="add_Click" />
	<%--</section>--%>
</form>
</asp:Content>
