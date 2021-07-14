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
    public partial class Admintedbirler : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.Params["silid"];
            if (id!=null)
            {
                sql.Execute($@"Delete Tedbirler4 where TedbirlerID={id}");
                Response.Redirect("Admintedbirler.aspx");
            }
            var dt = sql.Execute("Select * from Tedbirler4");
            int d = 1;
            StringBuilder sb = new StringBuilder();
            foreach (DataRow dr in dt.Rows)
            {
                sb.Append($@"<tr class='w3-light-grey w3-hover-red'>
                 <td>{d}</td>
                 <td>{dr["TedbirlerBasliq"]}</td>
                 <td>{dr["TedbirlerDetal"]}</td>
                 <td>{dr["TedbirlerAy"]}</td>
                 <td>{dr["TedbirlerGun"]}</td>
                 <td>{dr["TedbirlerIl"]}</td>
                 <td>{dr["TedbirlerSaat"]}</td>
                 <td>{dr["TedbirlerKonum"]}</td>
                 <td>{dr["TedbirlerPhoto"]}</td>
                 <td class='text-center'><a href='Admintedbirler.aspx?editid={dr[0]}' style='margin-right: 10px'><i class='fa fa-pencil fa-x'></i></a><a href='Admintedbirler.aspx?silid={dr[0]}'><i class='fa fa-trash-o fa-x'></i></a></td>");
                d++;
            }
            tbody.InnerHtml = sb.ToString();

            if (!IsPostBack)
            {
                string id2 = Request.Params["editid"];
                if (id2 !=null)
                {
                    var dt2 = sql.Execute($@"Select * from Tedbirler4 where TedbirlerId= {id2}");
                    if (dt2.Rows.Count == 0)
                    {
                        Response.Redirect("Admintedbirler.aspx");
                    }

                    basliq.Value = dt2.Rows[0]["TedbirlerBasliq"].ToString();
                    detal.Value = dt2.Rows[0]["TedbirlerDetal"].ToString();
                    ay.Value = dt2.Rows[0]["TedbirlerAy"].ToString();
                    gun.Value = dt2.Rows[0]["TedbirlerGun"].ToString();
                    il.Value = dt2.Rows[0]["TedbirlerIl"].ToString();
                    saat.Value = dt2.Rows[0]["TedbirlerSaat"].ToString();
                    konum.Value = dt2.Rows[0]["TedbirlerKonum"].ToString();
                }
            }
        }


        protected void add_Click(object sender, EventArgs e)
        {
            string id = Request.Params["editid"];
            if(id!=null)
            {
                string sekil = "";
                if (photo.PostedFile.FileName.Length>0)
                {
                    string PhotoName = "Photo" + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Millisecond + Path.GetExtension(photo.PostedFile.FileName);
                    photo.PostedFile.SaveAs(Server.MapPath("Content2/image/" + PhotoName));
                    sekil = $" , TedbirlerPhoto='{PhotoName}'";

                }
                string sorgu = $@"Update Tedbirler4 set TedbirlerBasliq = N'{basliq.Value}',TedbirlerDetal = N'{detal.Value}',TedbirlerAy = N'{ay.Value}',TedbirlerGun = N'{gun.Value}',TedbirlerIl = N'{il.Value}',TedbirlerSaat = N'{saat.Value}',TedbirlerKonum = N'{konum.Value}',TedbirlerPhoto = N'{photo.Value}' where TedbirlerId = {id}";
                sql.Execute(sorgu);
            }
            else
            {
                string PhotoName = "Photo" + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Millisecond + Path.GetExtension(photo.PostedFile.FileName);
                photo.PostedFile.SaveAs(Server.MapPath("Content2/image/" + PhotoName));
                string sorgu = $@"insert into Tedbirler4(TedbirlerPhoto,TedbirlerBasliq,TedbirlerDetal,TedbirlerAy,TedbirlerGun,TedbirlerIl,TedbirlerSaat,TedbirlerKonum) values (N'{PhotoName}',N'{basliq.Value}',N'{detal.Value}',N'{ay.Value}',N'{gun.Value}',N'{il.Value}',N'{saat.Value}',N'{konum.Value}')";
                sql.Execute(sorgu);
                Response.Redirect("AdminTedbirler.aspx");
            }
        }
    }
}