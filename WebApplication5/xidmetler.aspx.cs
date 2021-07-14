using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class xidmetler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
   
           
            var dt = sql.Execute("Select * from Xidmetler");
            foreach (DataRow dr in dt.Rows)
            {
               sm8.InnerHtml =($@"<iframe class='rth' width='700' height='500' src='https://www.youtube.com/embed/rWRL-1Krz_0' frameborder='0' allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>
                <div class='w3-container'>
                    <h3 class='mt-5 ielts'>IELTS Hazırlığı</h3>
                    <div class='w3-panel w3-leftbar w3-light-grey'>
                      <p class='w3-xlarge w3-serif mt-3'><i>Maksimum dərəcədə yüksək IELTS balı toplamaq üçün təcrübəmiz, xaricdən gətirlimiş metodik vəsaitlər, dərslərin müasir səviyyədə təşkili sizin imtahana hazırlaşmanızda çətinliklərə son qoyacaq.</i>       </p>
                    </div>
                </div>");
                sm4.InnerHtml += ($@"<li class='li2'>
                      <div class='left'><img class='news' height='100' src='Content2/image/xidmetphoto.jpg'></div>
                      <div class='right2 mt-3 ml-4'><p>Free Conversa..
                      <span>Eduline, güclü partnerlərinin olması ilə qlobal...</span></p></div>
                    </li>");
            }

        }
    }
}