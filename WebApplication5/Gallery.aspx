<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Gallery.aspx.cs" Inherits="WebApplication5.Gallery" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Eduline" runat="server">
    <div class="container">
        <div class="main">
            <h1>Bizim <span>Qalereya</span></h1>
            <br>
            <div id="myBtnContainer">
                <button class="btn active" onclick="filterSelection('all')">Bütün</button>
                <button class="btn" onclick="filterSelection('f1')">Müəllimlər</button>
                <button class="btn" onclick="filterSelection('f2')">Tələbələr</button>
                <button class="btn" onclick="filterSelection('f3')">Tədbirlər</button>
            </div>
            <div class="row" id="row" runat="server">

            </div>
         </div>
    </div>
</asp:Content>
