using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

using PromoTweet.Twitter;

namespace PromoTweet
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            TwitterSearch engine = new TwitterSearch();
            List<TwitterEntry> result = new List<TwitterEntry>();


            List<TwitterEntry> query1 = engine.BuscaEntradaTwitter("promoção");
            List<TwitterEntry> query2 = engine.BuscaEntradaTwitter("ganhe");
            List<TwitterEntry> query3 = engine.BuscaEntradaTwitter("concorra");
            List<TwitterEntry> query4 = engine.BuscaEntradaTwitter("desconto");
            List<TwitterEntry> query5 = engine.BuscaEntradaTwitter("retuite");
            List<TwitterEntry> query6 = engine.BuscaEntradaTwitter("oferta");
            List<TwitterEntry> query7 = engine.BuscaEntradaTwitter("cadastro");
            List<TwitterEntry> query8 = engine.BuscaEntradaTwitter("cadastre");

            result.AddRange(query1);
            result.AddRange(query2);
            result.AddRange(query3);
            result.AddRange(query4);
            result.AddRange(query5);
            result.AddRange(query6);
            result.AddRange(query7);
            result.AddRange(query8);

            List<TwitterEntry> cadastro = new List<TwitterEntry>();
            List<TwitterEntry> retuite = new List<TwitterEntry>();
            List<TwitterEntry> desconto = new List<TwitterEntry>();
            
            HashSet<int> keys = new HashSet<int>();

            foreach (TwitterEntry entry in result)
            {

                if (!keys.Contains(entry.Tweet.GetHashCode()))
                {

                    int classe = Classificador.Classificador.classificar(entry.Tweet);

                    if (classe == Classificador.Classificador.RT)
                    {
                        retuite.Add(entry);
                    }
                    else if (classe == Classificador.Classificador.DESCONTO)
                    {
                        desconto.Add(entry);
                    }
                    else if (classe == Classificador.Classificador.CADASTRO)
                    {
                        cadastro.Add(entry);
                    }

                    keys.Add(entry.Tweet.GetHashCode());
                }
                
            }
            result.Clear();

            divulgacao.Text = loadTweets(cadastro);
            retweets.Text = loadTweets(retuite);
            descontos.Text = loadTweets(desconto);

        }

        private string loadTweets(List<TwitterEntry> lista)
        {
            
            StringBuilder sb = new StringBuilder();
            int id = 0;

            sb.Append("<table style=\"width:270\">");
            foreach (TwitterEntry entry in lista)
            {
                sb.Append("<tr><td>");
                sb.Append("<div id=\"entry" + id + "\"" + "display:\"block\" ");
                sb.Append("<div style=\"float:left; width:20%\" display:\"block\">");
                sb.Append("<img height=\"48\" + width=\"48\" id=\"image" + id + "\" src=\"" + entry.Avatar + "\" title=\"" + entry.Author + "\" />");
                sb.Append("</div>");

                sb.Append("<div class=\"tweetBox\">");
                sb.Append("<a id=\"" + id + "\"" + "target=\"_blank\" href=\"" + entry.Uri + "\" class=\"linksTweet\">" + entry.Author + "</a>");
                sb.Append("<br/><label id=\"lb" + id + "\" style=\"text-align:center\">" + this.makeLink(entry.Tweet) + " </label>");
                sb.Append("</div>");
                sb.Append("</div>");
                sb.Append("</tr></td>");
                id++;
            }
            sb.Append("</table>");

            return sb.ToString() ;

        }

        private string makeLink(string txtUri)
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

    }
}
