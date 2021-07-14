<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Yenixidmet.aspx.cs" Inherits="WebApplication5.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Eduline" runat="server">
    <form action="#" method="post" runat="server" id="form">
        <div class="tgh container">
        <h1>Yeni Xidmet</h1>
        <hr />
        <label>Xidmetin Basligi:</label><br />
        <input runat="server" id="basliq" /><br />
        <label>Xidmet haqqinda:</label><br />
        <textarea runat="server" id="about"></textarea>
        <label>Video Linki:</label><br />
        <textarea runat="server" id="link"></textarea>
        <input runat="server" type="file" id="photo" />
        <asp:Button runat="server" ID="xidmet" OnClick="xidmet_Click" />
            </div>
    </form>
</asp:Content>
