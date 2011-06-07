using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PromoTweet.Twitter;
using System.Text;

namespace Mineracao1._0
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



            TwitterSearch engine = new TwitterSearch();
            List<TwitterEntry> result = engine.BuscaEntradaTwitter("promocao");
            StringBuilder sb = new StringBuilder();
            int id = 0;
            foreach (TwitterEntry entry in result)
            {
                sb.Append("<div id=\"t\"" + id + "style=\"border-bottom-style:solid; border-bottom-color:Black;\" display:\"block\" ");
                sb.Append("<div style=\"float:left; width:20%\" display:\"block\">");
                        sb.Append("<img height=\"48\" + width=\"48\" id=\"Image" + id + "\" src=\"" + entry.Avatar  + "\" title=\"" + entry.Author + "\" />");
                    sb.Append("</div>");

                    sb.Append("<div style=\"width:80%;padding-left:4px\" display:\"block\"");
                        sb.Append("<a id=\"a"+ id +"\" target=\"_blank\" href=\""+ entry.Uri + "\" class=\"linksTweet\">"+ entry.Author +"</a><br/>");
                        sb.Append("<label id=\"l"+ id +"\">" + entry.Tweet + " </label>");
                    sb.Append("</div>");
                sb.Append("<br /></div>");
                id++;
            }

            Label1.Text = sb.ToString();
            Label2.Text = sb.ToString();
            Label3.Text = sb.ToString();

        }

    }
}
