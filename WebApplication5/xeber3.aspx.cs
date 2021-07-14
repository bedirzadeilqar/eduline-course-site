using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class xeber : System.Web.UI.Page
    {
        private object dr;

        protected void Page_Load(object sender, EventArgs e)
        {
            var dt = sql.Execute("Select * from Xeberler");
            string id = Request.Params["id"];
            if (id != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    heber1.InnerHtml = ($@"<div class='row'>
      <div class='col-sm-8'>
        <div class='topb'><span class='los'>Free Conversation</span></div><br>
        <div class='topbt'><img src='Content2/image/{dr["XeberlerPhoto"]}'></div>
        <p></p>
      </div>
      <div class='col-sm-4'>
        <div class='newstop'><span class='los'>Son xəbərlər</span></div>
        <ul class='mt-4' type='none'>
                    <li class='li3'>
                      <div class='left'><img class='news' height='90' src='Content2/image/footxeber.jpg'></div>
                      <div class='right3 mt-3 ml-4'><p>Free Conversation</p>
                    </li>
                    <li class='li3'>
                      <div class='left'><img class='news' height='90' src='Content2/image/footxeber.jpg'></div>
                      <div class='right3 mt-3 ml-4'><p>'Xaricdə TəhsiIi Peşəkardan Soruş!' adlı seminar baş tutmuşdur.</p></div>
                    </li>
                    <li class='li3'>
                      <div class='left'><img class='news' height='90' src='Content2/image/footxeber.jpg'></div>
                      <div class='right3 mt-3 ml-4'><p>İngilis dilində danışıq klubu keçirilib.</p></div>
                    </li>
                </ul>
      </div>
</div>");
                }
  
            }
            else 
            {
                Response.Redirect("Xeberler.aspx");
            }
        }
    }
}