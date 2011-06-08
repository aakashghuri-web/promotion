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

            sb.Append("<table style=\"width:270\">");
            foreach (TwitterEntry entry in result)
            {
                
                sb.Append("<tr><td>");
                sb.Append("<div id=\"t\"" + id + "style=\"border-bottom-style:solid; border-bottom-color:Black;\" display:\"block\" ");
                sb.Append("<div style=\"float:left; width:20%\" display:\"block\">");
                        sb.Append("<img height=\"48\" + width=\"48\" id=\"Image" + id + "\" src=\"" + entry.Avatar  + "\" title=\"" + entry.Author + "\" />");
                    sb.Append("</div>");

                    sb.Append("<div class=\"tweetBox\">");
                    sb.Append("<a id=\"a" + id + "\" target=\"_blank\" href=\"" + entry.Uri + "\" class=\"linksTweet\">" + entry.Author + "</a>");
                        sb.Append("<br/><label id=\"l"+ id +"\">" + daReplaceNoLink(entry.Tweet) + " </label>");
                    sb.Append("</div>");
                sb.Append("</div>");
                sb.Append("</tr></td>");
                id++;
                 




            }
            sb.Append("</table>");

            Label1.Text = sb.ToString();
            Label2.Text = sb.ToString();
            Label3.Text = sb.ToString();

            

        }

        public String daReplaceNoLink(String txtUri)
        {
            if(txtUri.Contains("http://")){

                int i = txtUri.IndexOf("http://");
                int primeiraPosicaoLink = i;
                char[] arrayChar = txtUri.ToCharArray();
                String link = "";
                while (i < arrayChar.Length && arrayChar[i] != ' ')
                {
                    link = link + arrayChar[i];
                    i++;
                }



                link = "<a target=\"_blank\" href='" + link + "'>" + link + "</a>";
                
                String txtPrimeiraParteString = "";
                int a = 0;
                while(a<primeiraPosicaoLink){
                    txtPrimeiraParteString = txtPrimeiraParteString + arrayChar[a];
                    a++;
                }

                String txtTerceiraParteString = "";
                while(i < arrayChar.Length){
                    txtTerceiraParteString = txtTerceiraParteString + arrayChar[i];
                    i++;
                }

                txtUri = txtPrimeiraParteString + link + txtTerceiraParteString; 

            }

            return txtUri;

        }

    }
}
