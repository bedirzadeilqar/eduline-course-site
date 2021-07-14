using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class Admingallery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var dt = sql.Execute("Select * from Gallery");
            int i = 1;
            foreach (DataRow dr in dt.Rows)
            {
                tbody.InnerHtml += $@"<tr class='w3-light-grey w3-hover-red'>
                 <td>{dt.Rows.IndexOf(dr) + 1}</td>
                 <td>{dr["GalleryName"]}</td>
                 <td>{dr["GalleryPhoto"]}</td>
                 <td>{dr["Gallerytype"]}</td>
               </tr>";
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string PhotoName = "Photo" + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Millisecond + Path.GetExtension(galleryphoto.PostedFile.FileName);
            galleryphoto.PostedFile.SaveAs(Server.MapPath("Content2/image/" + PhotoName));
            string sorgu = $@"insert into Gallery values (N'{galleryname.Value}', N'{PhotoName}',N'{netice.Value}')";
            sql.Execute(sorgu);
            Response.Redirect("Admingallery.aspx");
        }
    }
}