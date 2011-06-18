using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PromoTweet.Classificador
{
    class Classificador

    {       
        public static int RT = 0;
	    public static int DESCONTO = 1;
	    public static int CADASTRO = 2;

        public static int classificar(String texto){

            texto = Preprocessador.preProcessamento(texto);

            double importancia = 0;
            if (texto.Contains("ganh"))
            {
                importancia = 1;
            }
            else if (texto.Contains("gratis") || texto.Contains("free"))
            {
                importancia = 0.8;
            }
            else if (  texto.Contains("concorr")
                    && texto.Contains("particip"))
            {
                importancia = 0.75;
            }

            double prioridadeRT = getPrioridadeRT(texto, importancia);
            double prioridadeCadastro = getPrioridadeCadastro(texto, importancia);
            double prioridadeDesconto = getPrioridadeDesconto(texto, importancia);

            int classe = -1;

            if (prioridadeCadastro != 0) {
                classe = CADASTRO;
            }
            else if (prioridadeRT != 0) {
                classe = RT;
            }
            else if (prioridadeDesconto != 0) {
                classe = DESCONTO;
            }
            
		    return 0;
	}
        /*se o texto possuir a classe RT,
         * retorna uma prioridade > 0;
         * se não possuir, retorna 0
         */
        private static double getPrioridadeRT(string texto, double importancia)
        {
            double prioridade = 0;
            
            if(texto.Contains("de #rt")&& (importancia != 0)){
                prioridade = 100*importancia;
            }
            else if(texto.Contains("rt e concorr")){
                prioridade = 60;
            }
            else if (texto.Contains("#rt") && (importancia != 0))
            {
                prioridade = 50 * importancia;
            }
            
            return prioridade;            
        }

        /*se o texto possuir a classe CADASTRO,
         * retorna uma prioridade > 0;
         * se não possuir, retorna 0.
         */
        private static double getPrioridadeCadastro(string texto, double importancia)
        {
            double prioridade = 0;

            if (texto.Contains("cadastr"))
            {
                prioridade = 1 * importancia;
            }           

            return prioridade;
        }

        /*se o texto possuir a classe DESCONTO,
         * retorna uma prioridade > 0;
         * se não possuir, retorna 0.
         */
        private static double getPrioridadeDesconto(string texto, double importancia)
        {
            double prioridade = 0;

            if (texto.Contains("%off"))
            {
                prioridade = 80;
            }
            else if (texto.Contains("promo") || texto.Contains("ofert"))
            { 
                int de = texto.IndexOf("der$");

                if (de != -1)
                {
                    Console.WriteLine("der$ " + de);

                    int i = de + 4;

                    while (i < texto.Length && ehDigito(texto[i]))
                    {
                        i++;
                    }

                    int por = texto.IndexOf("por", i);
                    //Console.WriteLine("por " + por);

                    if (por != -1 && (por - i) <= 2)
                    {
                        //Console.WriteLine("distancia der$dig - por " + (por - i));
                        prioridade = 100;
                    }
                }
                else {
                    prioridade = 80 * importancia;
                
                }
            }

            return prioridade;
        }

        private static bool ehDigito(char c)
        {
            return (c == '0' || c == '1' || c == '2' ||
                    c == '3' || c == '4' || c == '5' ||
                    c == '6' || c == '7' || c == '8' ||
                    c == '9');
        }

    }
}
