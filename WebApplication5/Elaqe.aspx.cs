using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class Elaqe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Send_Click(object sender, EventArgs e)
        {
            string sorgu = $@"insert into Client (ClientName,ClientEmail,ClientBasliq,ClientPhone,ClientMessage) values
            (N'{name.Value}',N'{email.Value}',N'{basliq.Value}',N'{number.Value}',N'{message.Value}')";
            sql.Execute(sorgu);
        }
    }
}