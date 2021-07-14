using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class Gallery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var dt = sql.Execute("select * from Gallery");
            dynamic c = "";
            foreach (DataRow dr in dt.Rows)
            {
                //dynamic d = c;
                row.InnerHtml += ($@"<div class='column vv f{dr["Gallerytype"]}'>
                    <img id='img01' height='207' src='Content2/image/{dr["GalleryPhoto"]}' alt='Lights' style='width:100%'>
                    <div class='hover'>
                    <h3>Conversation</h3>
                    <a class='pl-2 pr-2 pt-2 pb-2' id='myImg' href='Detail.aspx'><i class='fas fa-image'></i></a>
                    </div>
                </div>");
            }
        }
    }
}