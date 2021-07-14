using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class tedbir : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)

        {
            var dt = sql.Execute("Select * from Tedbirler4");
			string id = Request.Params["id"];
			if (id != null)
            {
				foreach (DataRow dr in dt.Rows)
				{
					tedbir12.InnerHtml = ($@"<div class='row'>
			<div class='col-sm-4'>
				<h5>Tedbirin Adi:</h5>
				<p>{dr["TedbirlerBasliq"]}</p>
				<h5>Ünvanı:</h5>
				<p>EduLine</p>
				<h5>Başlama vaxtı:</h5>
				<p>{dr["TedbirlerAy"]},{dr["TedbirlerGun"]},{dr["TedbirlerIl"]},{dr["TedbirlerSaat"]}</p>
				<h5>Yer sayı:</h5>
				<p>20</p>
				<h5>Qeydiyyat linki:</h5>
				<p>https://www.facebook.com/events/1830371940384607/?ti=icl</p>
			</div>
			<div class='col-sm-8'>
				<img class='ml-5' width='600' src='Content2/image/{dr["TedbirlerPhoto"]}'>
			</div>
		</div>
		<div class='row'>
			<h2 class='tedbirnot ml-3'>Conversation</h2>
			<span class='ml-3 mt-2 yut'>30 Iyun tarixində EduLineda Native Speaker Katie Shmidthlə conversation keçiriləcək.Conversationda tələbələrimiz ingilis dilini əslən amerikalının danışığından eşitdilər. Conversationda müxtəlif mövzular ətrafında müzakirələr aparılıb.</span>
		</div>");
				}
			}
            else
            {
				Response.Redirect("Tedbirler.aspx");
            }

        }
    }
}