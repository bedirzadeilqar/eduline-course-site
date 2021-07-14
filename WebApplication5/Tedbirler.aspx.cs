using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class Tedbirler : System.Web.UI.Page
    {
        private object ygu;

        protected void Page_Load(object sender, EventArgs e)
        {
            var dt = sql.Execute("Select * from Tedbirler4");
            foreach (DataRow dr in dt.Rows)
            {
                ilqar.InnerHtml += $@"<div class='row bor'>
            <div class='col-sm-4'><img width ='350' src='Content2/image/{dr["TedbirlerPhoto"]}'></div>
			<div class='col-sm-4'>   
				<span class='conver'>{dr["TedbirlerBasliq"]}</span>
				<p>{dr["TedbirlerDetal"]}</p>
				<a href = 'tedbir2.aspx?id={dr["TedbirlerId"]}' class='large'>etrafli&nbsp;<i class='fas fa-angle-double-right'></i></a>
			</div>
			<div class='col-sm-4'>
				<br><br><span class='bow'>{dr["TedbirlerAy"]}</span>&nbsp;&nbsp;<span class='bow'>{dr["TedbirlerGun"]}</span>&nbsp;&nbsp;<span class='bow'>{dr["TedbirlerIl"]}</span><br><br><br>
				<i class='fas fa-clock'></i>&nbsp;&nbsp;{dr["TedbirlerSaat"]}<br><i class='fas fa-map-marker-alt'></i>&nbsp;&nbsp;&nbsp;<span>{dr["TedbirlerKonum"]}</span>
			</div>
		</div>";
            }
        }
    }
}