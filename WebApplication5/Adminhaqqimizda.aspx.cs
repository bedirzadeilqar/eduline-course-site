using System;
using System.Collections.Generic;
using System.IO;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class Adminhaqqimizda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Tesdiq_Click(object sender, EventArgs e)
        {
            string PhotoName = "Photo" + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Millisecond + Path.GetExtension(Sekil.PostedFile.FileName);
            Sekil.PostedFile.SaveAs(Server.MapPath("Content2/image/" + PhotoName));
            string sorgu = $@"insert into EsasMelumatlar values (N'{facebook.Value}',N'{instagram.Value}',N'{youtube.Value}',N'{twitter.Value}',N'{website.Value}',N'{email.Value}',N'{telefon1.Value}',N'{telefon2.Value}',N'{sloqan.Value}',N'{unvan.Value}',N'{Video.Value}',N'{Size.Value}','{PhotoName}')";
            sql.Execute(sorgu);
            //Response.Redirect("Adminhaqqimizda.aspx");
        }
    }
}