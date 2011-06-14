using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

using PromoTweet.Twitter;
using PromoTweet.Extractor;

namespace PromoTweet
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["firstLoad"] == null)
            {
                TwitterSearch engine = new TwitterSearch();
                List<TwitterEntry> result = new List<TwitterEntry>();


                List<TwitterEntry> query1 = engine.BuscaEntradaTwitter("promoção");
                List<TwitterEntry> query2 = engine.BuscaEntradaTwitter("ganhe");
                //List<TwitterEntry> query3 = engine.BuscaEntradaTwitter("concorra");
                List<TwitterEntry> query4 = engine.BuscaEntradaTwitter("desconto");
                //List<TwitterEntry> query5 = engine.BuscaEntradaTwitter("retuite");
                //List<TwitterEntry> query6 = engine.BuscaEntradaTwitter("oferta");
                List<TwitterEntry> query7 = engine.BuscaEntradaTwitter("cadastre");

                result.AddRange(query1);
                result.AddRange(query2);
                //result.AddRange(query3);
                result.AddRange(query4);
                //result.AddRange(query5);
                //result.AddRange(query6);
                result.AddRange(query7);

                List<TwitterEntry> cadastro = new List<TwitterEntry>();
                List<TwitterEntry> retuite = new List<TwitterEntry>();
                List<TwitterEntry> desconto = new List<TwitterEntry>();

                HashSet<int> keys = new HashSet<int>();
                //app data
                Dictionary<string, int> persistent = (Dictionary<string, int>)Application["persistent"];
                if (persistent == null)
                {
                    persistent = new Dictionary<string, int>();
                }

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

                    if (persistent.ContainsKey(entry.Tweet))
                    {
                        persistent[entry.Tweet] = persistent[entry.Tweet] + 1;
                    }
                    else
                    {
                        persistent[entry.Tweet] = 1;
                    }
                }

                Application.Clear();
                Application["persistent"] = persistent;

                result.Clear();
                divulgacao.Text = Util.loadTweets(cadastro);
                retweets.Text = Util.loadTweets(retuite);
                descontos.Text = Util.loadTweets(desconto);
                top.Text = Util.topTweets(persistent);

                Session["firstLoad"] = true;
            }
        }

        protected void searchKey(object sender, ImageClickEventArgs e)
        {

            if (!TextBoxSearch.Text.Equals(""))
            {
                Session["query"] = TextBoxSearch.Text;
                Response.Redirect("Result.aspx");
            }
        }

    }
}
