using System;

using PromoTweet.Twitter;
using System.Collections.Generic;
using System.Text;

namespace PromoTweet.Extractor
{

    public class Util
    {

        public Util()
        {
            //default constructor
        }

        public static string makeLink(string txtUri)
        {
            if (txtUri.Contains("http://"))
            {

                int i = txtUri.IndexOf("http://");
                int primeiraPosicaoLink = i;
                char[] arrayChar = txtUri.ToCharArray();
                string link = "";
                while (i < arrayChar.Length && arrayChar[i] != ' ')
                {
                    link = link + arrayChar[i];
                    i++;
                }

                link = "<a target=\"_blank\" href=\"" + link + "\">" + link + "</a>";

                string txtPrimeiraParteString = "";
                int a = 0;
                while (a < primeiraPosicaoLink)
                {
                    txtPrimeiraParteString = txtPrimeiraParteString + arrayChar[a];
                    a++;
                }

                string txtTerceiraParteString = "";
                while (i < arrayChar.Length)
                {
                    txtTerceiraParteString = txtTerceiraParteString + arrayChar[i];
                    i++;
                }

                txtUri = txtPrimeiraParteString + link + txtTerceiraParteString;

            }

            return txtUri;
        }

        public static string loadTweets(List<TwitterEntry> lista)
        {

            StringBuilder sb = new StringBuilder();
            int id = 0;

            sb.Append("<table >");
            foreach (TwitterEntry entry in lista)
            {
                sb.Append("<tr><td>");
                sb.Append("<div id=\"entry" + id + "\"" + "display:\"block\" ");
                sb.Append("<div style=\"float:left; width:20%\" display:\"block\">");
                sb.Append("<img height=\"48\" + width=\"48\" id=\"image" + id + "\" src=\"" + entry.Avatar + "\" title=\"" + entry.Author + "\" />");
                sb.Append("</div>");

                sb.Append("<div class=\"tweetBox\">");
                sb.Append("<a id=\"" + id + "\"" + "target=\"_blank\" href=\"" + entry.Uri + "\" class=\"linksTweet\">" + entry.Author + "</a>");
                sb.Append("<br/><label id=\"lb" + id + "\" style=\"text-align:center\">" + Util.makeLink(entry.Tweet) + " </label>");
                sb.Append("</div>");
                sb.Append("</div>");
                sb.Append("</tr></td>");
                id++;
            }
            sb.Append("</table>");

            return sb.ToString();
        }
    }

}