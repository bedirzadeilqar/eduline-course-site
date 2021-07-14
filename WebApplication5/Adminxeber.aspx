<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Adminxeber.aspx.cs" Inherits="WebApplication5.Adminxeber" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Eduline" runat="server">
<form runat="server">
	<section class="container">
		<div class="row">
			<div class="col-sm-6">
				<input runat="server" class="form-group" type="file" name="file" id="photo"><br />
				<label style="color: red;" class="hy" for="usr">Basliq:</label>
				<input runat="server" id="basliq" type="text" name="basliq" class="form-control" placeholder="basliq"><br />
				<label class="hy" for="usr">Detal:</label>
				<input runat="server" id="detal" type="text" name="detal" class="form-control"  placeholder="detal">
			</div>
			<div class="col-sm-6"></div>
		</div>

		<div class="w3-container">
           <h1>Xeberler(Siyahi)</h1>
  <table class="w3-table-all">
    <thead runat="server">
      <tr class="w3-light-grey w3-hover-red">
        <th>Id</th>
        <th>XeberlerPhoto</th>
        <th>XeberlerBasliq</th>
        <th>XeberlerDetal</th>
      </tr>
    </thead>
      <tbody runat="server" id="tbody">
    
      </tbody>
  </table>
</div>
		<asp:Button runat="server" id="add" Text="Send" OnClick="add_Click" />
	</section>
</form>
   

</asp:Content>
