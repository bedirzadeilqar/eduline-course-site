using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class Adminxeberler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.Params["silid"];
            if(id!=null)
            {
                sql.Execute($@"Delete Xeberler where XeberlerId={id}");
                Response.Redirect("Adminxeberler.aspx");
            }
            var dt = sql.Execute("Select * from Xeberler");
            int d = 1;
            StringBuilder sb = new StringBuilder();
            foreach(DataRow dr in dt.Rows)
            {
                sb.Append($@"<tr class='w3-light-grey w3-hover-red'>
                 <td>{dt.Rows.IndexOf(dr) + 1}</td>
                 <td>{dr["XeberlerBasliq"]}</td>
                 <td>{dr["XeberlerDetal"]}</td>
                 <td>{dr["XeberlerPhoto"]}</td>
                 <td class='text-center'><a href='Adminxeberler.aspx?editid={dr["XeberlerId"]}' style='margin-right: 10px'><i class='fa fa-pencil fa-x'></i></a><a href='Adminxeberler.aspx?silid={dr[0]}'><i class='fa fa-trash-o fa-x'></i></a></td></tr>");
                d++;
            }
            tbody.InnerHtml = sb.ToString();


            if(!IsPostBack)
            {
                string id2 = Request.Params["editid"];
                if (id2 != null)
                {
                    var dt2 = sql.Execute($@"Select * from Xeberler where XeberlerId= {id2}");
                    if (dt2.Rows.Count == 0)
                    {
                        Response.Redirect("Adminxeberler.aspx");
                    }

                    basliq.Value = dt2.Rows[0]["XeberlerBasliq"].ToString();
                    detal.Value = dt2.Rows[0]["XeberlerDetal"].ToString();
                }
            }

        }


        protected void add_Click(object sender, EventArgs e)
        {

            string id = Request.Params["editid"];
            if(id!= null)
            {
                string sekil = "";
                if (photo.PostedFile.FileName.Length > 0)
                {
                    string PhotoName = "Photo" + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Millisecond + Path.GetExtension(photo.PostedFile.FileName);
                    photo.PostedFile.SaveAs(Server.MapPath("Content2/image/" + PhotoName));
                    sekil = $" , XeberlerPhoto='{PhotoName}'";

                }
                string sorgu = $@"Update Xeberler set XeberlerBasliq = N'{basliq.Value}',XeberlerDetal = N'{detal.Value}' {sekil} where XeberlerId = {id}";
                sql.Execute(sorgu);
            }
            else
            {
                string PhotoName = "Photo" + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Millisecond + Path.GetExtension(photo.PostedFile.FileName);
                photo.PostedFile.SaveAs(Server.MapPath("Content2/image/" + PhotoName));
                string sorgu = $@"insert into Xeberler(XeberlerPhoto,XeberlerBasliq,XeberlerDetal) values (N'{PhotoName}',N'{basliq.Value}',N'{detal.Value}')";
                sql.Execute(sorgu);
            }
            Response.Redirect("Adminxeberler.aspx");
            
        }
    }
}