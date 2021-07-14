using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void xidmet_Click(object sender, EventArgs e)
        {
            string PhotoName = "Photo" + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Millisecond + Path.GetExtension(photo.PostedFile.FileName);
            photo.PostedFile.SaveAs(Server.MapPath("Content2/image/" + PhotoName));
            string sorgu = $@"insert into Xidmetler(XidmetlerBasliq,XidmetlerHaqqinda,XidmetlerVideo,XidmetPhoto) values (N'{basliq.Value}',N'{about.Value}',N'{link.Value}',N'{PhotoName}')";
            sql.Execute(sorgu);
            Response.Redirect("Yenixidmet.aspx");
        }
    }
}