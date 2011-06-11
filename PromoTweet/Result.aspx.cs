using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PromoTweet.Twitter;
using PromoTweet.Extractor;

namespace PromoTweet
{
    public partial class Result : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string divulgacaoResult = (string) Session["divulgacao"];
            string retweetsResult = (string) Session["retweets"];
            string descontosResult = (string) Session["descontos"];

            //preenche dados 
            if (divulgacaoResult != null)
            {
                divulgacao.Text = divulgacaoResult;
            }
            if (retweetsResult != null)
            {
                retweets.Text = retweetsResult;
            }
            if (descontosResult != null)
            {
                descontos.Text = descontosResult;
            }
            
            //limpa dados da sessão
            Session.Clear();
        }

        protected void searchKey(object sender, ImageClickEventArgs e)
        {
            TwitterSearch engine = new TwitterSearch();
            List<TwitterEntry> result = new List<TwitterEntry>();


            List<TwitterEntry> query1 = engine.BuscaEntradaTwitter(TextBoxSearch.Text);
            List<TwitterEntry> query2 = engine.BuscaEntradaTwitter("ganhe " + TextBoxSearch.Text);
            List<TwitterEntry> query3 = engine.BuscaEntradaTwitter("concorra " + TextBoxSearch.Text);
            List<TwitterEntry> query4 = engine.BuscaEntradaTwitter("desconto " + TextBoxSearch.Text);
            List<TwitterEntry> query5 = engine.BuscaEntradaTwitter("retuite " + TextBoxSearch.Text);
            List<TwitterEntry> query6 = engine.BuscaEntradaTwitter("oferta " + TextBoxSearch.Text);
            List<TwitterEntry> query7 = engine.BuscaEntradaTwitter("cadastre " + TextBoxSearch.Text);

            result.AddRange(query1);
            result.AddRange(query2);
            result.AddRange(query3);
            result.AddRange(query4);
            result.AddRange(query5);
            result.AddRange(query6);
            result.AddRange(query7);

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

            divulgacao.Text = Util.loadTweets(cadastro);
            retweets.Text = Util.loadTweets(retuite);
            descontos.Text = Util.loadTweets(desconto);
        }
    }
}