using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinWeb
{
    class Classificador
    {       
        public static int RT = 0;
	    public static int PROPAGANDA = 1;
	    public static int CADASTRO = 2;

        public static int classificar(String texto){
		int classe = -1;

		//int de = texto.indexOf("de");
		/*int rt = texto.indexOf(" rt ");
		int concorra = texto.indexOf("concorra");*/
		//int promo = texto.indexOf("promo");
		//int oferta = texto.indexOf("oferta");
		//int off = texto.indexOf("%off");
		//int cadastro = texto.indexOf("cadastr");
		//int ganhe = texto.indexOf("ganh");

		if(texto.Contains(" rt ") && (texto.Contains("concorr")||texto.Contains("ganh"))){
			classe = RT;
		}
		else if(texto.Contains("cadastr") && texto.Contains("ganh")){
			classe = CADASTRO;
		}		
		else if(texto.Contains("%off")){
			classe = PROPAGANDA;
		}
		else if(texto.Contains("promo") || texto.Contains("ofert")){			
			
			/*int gratis = texto.indexOf("gratis");
			int free = texto.indexOf("free");
			int desconto = texto.indexOf("desconto");*/
			
			
			int de = texto.IndexOf("der$");
			
			if(texto.Contains("gratis") || texto.Contains("free")
					||texto.Contains("desconto")){
				classe = PROPAGANDA;
			}
			else if(de != - 1){
				Console.WriteLine("der$ " + de);
				
				int i = de+4;

				while(i < texto.Length &&ehDigito(texto[i])){
					i++;
				}

				int por = texto.IndexOf("por", i);
				Console.WriteLine("por " + por);
				
				if(por != -1 && (por -  i) <= 2){
					Console.WriteLine("distancia der$dig - por " + (por - i));
					classe = PROPAGANDA;
				}
			}

			
			
		}
		
		if(classe != -1 && texto.Contains("http")){
			int i = texto.IndexOf(" ", texto.IndexOf("http"));
			
			if(i != -1){
				Console.WriteLine(texto.Substring(texto.IndexOf("http"), i));
			}
			else{
				Console.WriteLine(texto.Substring(texto.IndexOf("http")));
			}
		}




		return classe;
	}

        private static bool ehDigito(char c)
        {
            return (c == '0' || c == '1' || c == '2' ||
                    c == '3' || c == '4' || c == '5' ||
                    c == '6' || c == '7' || c == '8' ||
                    c == '9');
        }

        static void Main()
        {
            String s = MensagemAux.pro7;
		    Console.WriteLine(s);
		    s = s.ToLower();
		    s = Preprocessador.removerAcentuacao(s);
	    	s = Preprocessador.removerPontuacao(s);
    		s = Preprocessador.adaptarPreco(s);

		    Console.WriteLine(classificar(s));
        }

    }
}
