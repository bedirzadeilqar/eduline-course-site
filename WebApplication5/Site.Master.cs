using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var dt = sql.Execute("Select * from Xidmetler");
            foreach (DataRow dr in dt.Rows)
            {
              ul.InnerHtml += ($@"<a class='dropdown-item' href='xidmetler.aspx?id={dr["XidmtlerId"]}'>{dr["XidmetlerBasliq"]}</a>");
            }

            var dt2 = sql.Execute("select * from Tedbirler4");
            foreach(DataRow dr2 in dt2.Rows)
            {
               tedbirs.InnerHtml += ($@"<li class='li'>
                           <div class='left'>
                                <img class='news' height='90' src='Content2/image/{dr2["TedbirlerPhoto"]}'>
                           //</div>
                            <div class='right mt-3 ml-4'>
                               <p>
                                    <a class='imperia' href='tedbir.aspx'>Conversation</a>
                                    <span>{dr2["TedbirlerAy"]},{dr2["TedbirlerGun"]},{dr2["TedbirlerIl"]}</span>
                               </p>
                           </div>
                      </li>");
            }

            
        }
    }
}
      
