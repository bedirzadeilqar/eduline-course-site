using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var dt = sql.Execute("Select * from Client");
            int i = 1;
            foreach (DataRow item in dt.Rows)
            {
                tbody.InnerHtml += $@"<tr class='w3-hover-blue'>
                 <td>{i}</td>
                 <td>{item["ClientName"]}</td>
                 <td>{item["ClientEmail"]}</td>
                 <td>{item["ClientBasliq"]}</td>
                 <td>{item["ClientPhone"]}</td>
                 <td>{item["ClientMessage"]}</td>
               </tr>";
                i++;
            }
        }
    }
}