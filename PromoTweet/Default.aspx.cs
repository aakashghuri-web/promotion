using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using PromoTweet.Twitter;

namespace PromoTweet
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TwitterSearch engine = new TwitterSearch();
            List<TwitterEntry> result = engine.BuscaEntradaTwitter("promocao");
            string s = "";
            int id = 0;
            foreach (TwitterEntry entry in result)
            {
                s += "<a target= \"_blank\" href=\""+ entry.Uri +"\"> <img height=\"48\" + width=\"48\" id=\"Image" + (++id) +"\" src=\""+ entry.Avatar + "\" title=\"" + entry.Author +" "+ entry.Tweet + "\"/> <a/>" ;
            }

            Label1.Text = s;
        }
            
    }
}
