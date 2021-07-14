<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebApplication5.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Eduline" runat="server">
    
    <div class="section">
      <div class="iframe" style="width: 100%;">
        <iframe height="670" style="width: 210.2%;"   src="https://www.youtube.com/embed/-UnJbNJLSzY" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"></iframe>
      </div>
      
      <div class="welcome">
        <br><br>
        <h1>WELCOME TO <span>EDULINE</span></h1>
        <p>Təhsilinizdəki pillələri birlikdə aşaq....</p>
        <a href="xidmetler.aspx">Xidmətlərimiz</a>
      </div>
    </div>
<br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br>

    <div class="section-1 container">
      <h1>Welcome Our <span class="educationworld">Education World</span> </h1><br>
      <div class="row">
        <div class="col-md-6">
          <iframe width="550" height="350" src="https://www.youtube.com/embed/-UnJbNJLSzY" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen"></iframe>
        </div>
        <div class="col-md-6" id="colmds">
          <div class="firstcolmd" id="solxidmet" runat="server">

          </div>
          <div class="firstcolmd" id="saqxidmet" runat="server">

          </div>
        </div>
      </div>
    </div>




    <section class="counters">
      <div class="container">
        <div>
          <i class="far fa-smile"></i>
          <div class="counter" data-target="1357">0</div>
          <h3>TƏLƏBƏLƏR</h3>
        </div>
        <div>
          <i class="fas fa-user-friends"></i>
          <div class="counter" data-target="51">0</div>
          <h3>MÜƏLLİMLƏR</h3>
        </div>
        <div>
          <i class="fas fa-trophy"></i>
          <div class="counter" data-target="729">0</div>
          <h3>SERTİFİKATLAR</h3>
        </div>
        <div>
          <i class="fas fa-clipboard"></i>
          <div class="counter" data-target="14">0</div>
          <h3>XİDMƏTLƏR</h3>
        </div>
      </div>
    </section>



    <div class="container">
      <div class="main">

      <h1>Bizim <span>Qalereya</span></h1><br>


      <div id="myBtnContainer">
        <button class="btn active" onclick="filterSelection('all')"> Bütün</button>
        <button class="btn" onclick="filterSelection('nature')"> Müəllimlər</button>
        <button class="btn" onclick="filterSelection('cars')"> Tələbələr</button>
        <button class="btn" onclick="filterSelection('people')"> Tədbirlər</button>  
      </div>
      <div class="row">
        <div class="column nature vv">
          <img id="img01" height="207" src="Content2/image/gallery7.jpg" alt="Lights" style="width:100%">
          <div class="hover">
            <h3>Conversation</h3>
            <a class="pl-2 pr-2 pt-2 pb-2" id="myImg" href="Detail.aspx"><i class="fas fa-image"></i></a>
          </div>
        </div>
        <div class="column nature vv">
          <img id="img02" src="Content2/image/gallery3.jpg" alt="Nature" style="width:100%">
          <div class="hover">
            <h3>Conversation</h3>
            <a class="pl-2 pr-2 pt-2 pb-2" id="yourImg" href="Detail.aspx"><i class="fas fa-image"></i></a>
          </div>
        </div>
        <div class="column cars vv">
            <img src="Content2/image/gallery8.jpg" alt="Car" style="width:100%">
            <div class="hover">
            <h3>Conversation</h3>
            <a class="pl-2 pr-2 pt-2 pb-2" href="Detail.aspx"><i class="fas fa-image"></i></a>
          </div>
        </div>
        <div class="column cars vv">
          <img src="Content2/image/gallery4.jpg" alt="Car" style="width:100%">
          <div class="hover">
            <h3>Conversation</h3>
            <a class="pl-2 pr-2 pt-2 pb-2" href="Detail.aspx"><i class="fas fa-image"></i></a>
          </div>
        </div>
        <div class="column cars vv">
          <img src="Content2/image/gallery5.jpg" alt="Car" style="width:100%">
          <div class="hover">
            <h3>Conversation</h3>
            <a class="pl-2 pr-2 pt-2 pb-2" href="Detail.aspx"><i class="fas fa-image"></i></a>
          </div>
        </div>

        <div class="column people vv">
            <img height="200" src="Content2/image/gallery6.jpg" alt="Car" style="width:100%;height: 100%;">
            <div class="hover">
            <h3>Conversation</h3>
            <a class="pl-2 pr-2 pt-2 pb-2" href="Detail.aspx"><i class="fas fa-image"></i></a>
          </div>
        </div>
        <div class="column people vv">
          <img src="Content2/image/gallery1.jpg" alt="Car" style="width:100%">
          <div class="hover">
            <h3>Conversation</h3>
            <a class="pl-2 pr-2 pt-2 pb-2" href="Detail.aspx"><i class="fas fa-image"></i></a>
          </div>
        </div>
        <div class="column people vv">
          <img src="Content2/image/gallery2.jpg" alt="Car" style="width:100%">
          <div class="hover">
            <h3>Conversation</h3>
            <a class="pl-2 pr-2 pt-2 pb-2" href="Detail.aspx"><i class="fas fa-image"></i></a>
          </div>
        </div>
      </div>
    </div>
  </div>

</asp:Content>
