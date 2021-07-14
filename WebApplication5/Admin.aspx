<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="WebApplication5.Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Eduline" runat="server">

    <form runat="server">
        <div class="w3-container">
  <h1>Elaqeye Gonderilenler(Siyahi)</h1>

  <table class="w3-table-all">
    <thead runat="server">
      <tr class="w3-light-grey w3-hover-red">
        <th>Id</th>
        <th>Ad</th>
        <th>Basliq</th>
        <th>Email</th>
        <th>Nomre</th>
        <th>Message</th>
      </tr>
    </thead>
      <tbody runat="server" id="tbody">
    
      </tbody>
  </table>
</div>
    </form>
</asp:Content>
