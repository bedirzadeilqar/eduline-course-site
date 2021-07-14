<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Admingallery.aspx.cs" Inherits="WebApplication5.Admingallery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Eduline" runat="server">
    <section class="cowqun">
    <form runat="server">
        <div class="form-group">
    <label>Name</label>
        <input runat="server" id="galleryname" type="text" placeholder="ad" /><br />
        </div>
        <div class="form-group">
    <label>Photo:</label>
    <input runat="server" id="galleryphoto" type="file" /><br />
        </div>
        <div class="form-group">
    <label>Type:</label>
    <select id="netice" runat="server">
        <option value="1">1-teacher</option>
        <option value="2">2-student</option>
        <option value="3">3-proceedings</option>
    </select>
        </div>
        <asp:Button ID="Button1" runat="server" Text="send" OnClick="Button1_Click" />
        <input type="reset" text="Reset" />


        <div class="w3-container">
           <h1>Gallery(Type)</h1>

  <table class="w3-table-all">
    <thead runat="server">
      <tr class="w3-light-grey w3-hover-red">
        <th>Id</th>
        <th>GalleryName</th>
        <th>GalleryPhoto</th>
        <th>GalleryType</th>
      </tr>
    </thead>
      <tbody runat="server" id="tbody">
    
      </tbody>
  </table>
</div>
    </form>
    </section>

  
        
    
    

</asp:Content>

