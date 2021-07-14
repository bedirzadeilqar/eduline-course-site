using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class About : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var dt = sql.Execute("Select * from EsasMelumatlar");
            foreach(DataRow dr in dt.Rows)
            {
                about2.InnerHtml = ($@"
            <div class='col-sm-4' style='background-color:lavender;'>
                <ul style='list-style-type:none;'>
                    <li><i class='fas fa-envelope'></i>&nbsp;&nbsp;&nbsp;Email:<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{dr["MelumatlarEmailLinki"]}</li>
                    <li><i class='fas fa-phone-alt'></i>&nbsp;&nbsp;&nbsp;Telefon:<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{dr["MelumatlarTelefon1"]}<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{dr["MelumatlarTelefon2"]}</li>
                    <li><i class='fas fa-map-marker-alt'></i>&nbsp;&nbsp;&nbsp;&nbsp;Unvan:<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{dr["MelumatlarUnvan"]}</li>
                </ul>
            </div>
            <div class='col-sm-8' style='background-color:lavenderblush;'>
                <i class='fas fa-info-circle abouticon'></i>&nbsp;&nbsp;haqqimizda<br/>
                <p class='aboutp'>
                   {dr["MelumatlarHaqqindaMelumat"]}
                </p>
            </div>");
            }
        }
    }
}