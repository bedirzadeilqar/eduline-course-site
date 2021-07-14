using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class xeberlerzahir : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var dt = sql.Execute("Select * from Xeberler");
            foreach (DataRow dr2 in dt.Rows)
            {
                xeberzahir.InnerHtml += ($@"<div class='row haberler'>
			<div class='col-sm-4 firstcolsm'>
				<img src='Content2/image/footxeber.jpg'>
			</div>
			<div class='col-sm-8'>
				<h4>'XARICDƏ TƏHSIII PEŞƏKARDAN SORUŞ!' ADLI SEMINAR BAŞ TUTMUŞDUR.</h4>
				<p>10 mart tarixində mərkəzimizdə 'Xaricdə TəhsiIi Peşəkardan Soruş!' adlı seminarı baş tutmuşdur. Seminarda Rüfət Məmmədxanlı, Turxan İsmayılzadə və Orxan Qurbanlı Almaniya, Hollnın üstünlüklərindən danışıblar. O cümlədən, təlimçilər uyğun universitetlərin seçilməsi, motivasiya və yazılma üslublarından etlər barasində geniş məlbələr və təlimçilərlə birlikdə xatirə fotosu çəkilmişdir.</p>
				<a href='xeber3.aspx?id={dr2["XeberlerId"]}' class='etrafli'>Ətraflı&nbsp; <i class='fas fa-angle-double-right'></i></a>
			</div>
		</div>");
            }
        }
    }
}