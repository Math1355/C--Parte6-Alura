using System;
using System.Text.RegularExpressions;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using Humanizer;

namespace ByteBank.SistemaInterno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ola mundo!");
            Console.WriteLine(123);
            Console.WriteLine(10.5);
            Console.WriteLine(true);

            object conta = new ContaCorrente(4848, 4564561);
            object desenvolvedor = new Desenvolvedor("465465465");

            string ContaToString = conta.ToString();

            Console.WriteLine("Resultado " + ContaToString);

            Console.ReadLine();
        }
        static void TestaString()
        {
            //pagina?argumentos
            //0123456789

            /* Exemplo de exercicio
            String texto = "Gustavo_Silva";

            if (string.IsNullOrEmpty(texto))
            {
                Console.WriteLine("String vazia");
            }

            Int32 indice = texto.IndexOf("Gustavo");
            String texto2 = texto.Substring(indice + 1);

            Console.WriteLine("Tamanho: " + texto.Length);
            Console.WriteLine("Indice: " + indice);
            Console.WriteLine(texto2);
            Console.ReadLine();
            */

            //moeadaOrigem=real&moedaDestino=dolar

            //Olá, meu nome e Matheus e você pode entrar em contato comigo através do número 8457-4456!
            //Meu nome é Matheus, me ligue em 4784-4556

            //string padrao = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
            //string padrao = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
            //string padrao = "[0-9]{4}[-][0-9]{4}";
            //string padrao = "[0-9]{4,5}[-]{0,1}[0-9]{4}";
            //string padrao = "[0-9]{4,5}-{0,1}[0-9]{4}";
            string padrao = "[0-9]{4,5}-?[0-9]{4}";

            string textoDeTeste = "Olá, meu nome e Matheus e você pode entrar em contato comigo através do número 98457-4456";

            Match resultado = Regex.Match(textoDeTeste, padrao);

            Console.WriteLine(resultado.Value);

            Console.ReadLine();




            string urlParamentros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParamentros);

            string valor = extratorDeValores.GetValor("moedaDestino");
            Console.WriteLine("Valor de moedaDestino: " + valor);

            string valorMoedaOrigem = extratorDeValores.GetValor("moedaOrigem");
            Console.WriteLine("Valor de moedaOrigem: " + valorMoedaOrigem);

            Console.WriteLine(extratorDeValores.GetValor("valor"));

            Console.ReadLine();


            // Testando o metodo remove
            string testeRemocao = "primeiraParte&parteParaRemover";
            int indiceEComercial = testeRemocao.IndexOf('&');

            Console.WriteLine(testeRemocao.Remove(indiceEComercial));
            Console.ReadLine();

            string palavra = "moeadaOrigem=moedaDestino&moedaDestino=dolar";
            string nomeArgumento = "moedaDestino=";

            int indice = palavra.IndexOf(nomeArgumento);
            Console.WriteLine(indice);

            Console.WriteLine("Tamanho da string nomeArgumento " + nomeArgumento.Length);

            Console.WriteLine(palavra);
            Console.WriteLine(palavra.Substring(indice));
            Console.WriteLine(palavra.Substring(indice + nomeArgumento.Length));

            Console.ReadLine();


            //Testando o IsNullOrEmpty
            string textoVazio = "";
            string textoNulo = null;
            Console.WriteLine(String.IsNullOrEmpty(textoVazio));
            Console.WriteLine(String.IsNullOrEmpty(textoNulo));
            Console.ReadLine();



            ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL(null);


            string url = "paginas?argumentos";

            int indiceInterrogacao = url.IndexOf('?');

            Console.WriteLine(indiceInterrogacao);

            Console.WriteLine(url);

            string argumentos = url.Substring(indiceInterrogacao + 1);

            Console.WriteLine(argumentos);

            Console.ReadLine();
        }
    }
}
