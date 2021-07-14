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
    public partial class Adminxeber : System.Web.UI.Page
    {
        private object haber;

        protected void Page_Load(object sender, EventArgs e)
        {
            var dt = sql.Execute("Select * from Xeberler");
            int i = 1;
            foreach (DataRow dr in dt.Rows)
            {
                tbody.InnerHtml += $@"<tr class='w3-light-grey w3-hover-red'>
                 <td>{dt.Rows.IndexOf(dr) + 1}</td>
                 <td>{dr["XeberlerPhoto"]}</td>
                 <td>{dr["XeberlerBasliq"]}</td>
                 <td>{dr["XeberlerDetal"]}</td>
               </tr>";
            }
        }

        protected void add_Click(object sender, EventArgs e)
        {
            string PhotoName = "Photo" + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Millisecond + Path.GetExtension(photo.PostedFile.FileName);
            photo.PostedFile.SaveAs(Server.MapPath("Content2/image/" + PhotoName));
            string sorgu = $@"insert into Xeberler values (N'{PhotoName}',N'{basliq.Value}',N'{detal.Value}')";
            sql.Execute(sorgu);
            Response.Redirect("Adminxeber.aspx");
        }
    }
}
