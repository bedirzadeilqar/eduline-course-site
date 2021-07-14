using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var dt = sql.Execute($@"select Top 2 XidmetlerBasliq,XidmetlerVideo,XidmetlerHaqqinda,XidmetPhoto from Xidmetler ORDER BY NEWID()");
            if (dt.Rows.Count==0)
            {
                Response.Redirect("about.aspx");
            }
            else
            {
                if (dt.Rows.Count<=1)
                {
                    solxidmet.InnerHtml = ($@"<img style='width: 100px !important;height: 100px !important;border-radius: 50% !important;' class='iqis' src='Content2/image/{dt.Rows[0]["XidmetPhoto"]}'>
            <h3>{dt.Rows[0]["XidmetlerBasliq"]}</h3>
            <p>{dt.Rows[0]["XidmetlerHaqqinda"]}</p>
            <a href='xidmetler.aspx'>Ətraflı</a>");

           saqxidmet.InnerHtml = ($@"<img style='width: 100px !important;height: 100px !important;border-radius: 50% !important;' class='iqis' src='Content2/image/{dt.Rows[0]["XidmetPhoto"]}'>
            <h3>{dt.Rows[0]["XidmetlerBasliq"]}</h3>
            <p>{dt.Rows[0]["XidmetlerHaqqinda"]}</p>
            <a href='xidmetler.aspx'>Ətraflı</a>");

                }
                else
                {
                    solxidmet.InnerHtml = ($@"<img  style='width: 100px !important;height: 100px !important;border-radius: 50% !important;' src='Content2/image/{dt.Rows[0]["XidmetPhoto"]}'>
            <h3>{dt.Rows[0]["XidmetlerBasliq"]}</h3>
            <p>{dt.Rows[0]["XidmetlerHaqqinda"]}</p>
            <a href='xidmetler.aspx'>Ətraflı</a>");

                    saqxidmet.InnerHtml = ($@"<img  style='width: 100px !important;height: 100px !important;border-radius: 50% !important;' src='Content2/image/{dt.Rows[1]["XidmetPhoto"]}'>
            <h3>{dt.Rows[1]["XidmetlerBasliq"]}</h3>
            <p>{dt.Rows[1]["XidmetlerHaqqinda"]}</p>
            <a href='xidmetler.aspx'>Ətraflı</a>");
                }
            }
        }
    }
}