using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaInterno
{
    public class ExtratorValorDeArgumentosURL
    {
        private readonly  string _argumentos;
        public string URL { get; }

        public ExtratorValorDeArgumentosURL(string url)
        {
            if (String.IsNullOrEmpty(url))
            {
                throw new ArgumentException("O argumento url não pode ser nulo ou vazio.", nameof(url));
            }

            int indiceInterrogação = url.IndexOf('?');
            _argumentos = url.Substring(indiceInterrogação + 1);

            URL = url;
        }

        //moedaOrigem=real&moedaDestino=dolar
        public string GetValor(string nomeParamentro)
        {
            nomeParamentro = nomeParamentro.ToUpper(); // VALOR
            string argumentoEmCaixaAlta = _argumentos.ToUpper(); //MOEDAORIGEM=REAL&MOEDADESTINO=DOLAR

            string termo = nomeParamentro + "="; //moeadaDestino=
            int indiceTermo = argumentoEmCaixaAlta.IndexOf(termo); // x

            string resultado = _argumentos.Substring(indiceTermo + termo.Length); // dolar
            int indiceComercial = resultado.IndexOf('&');

            if (indiceComercial == -1)
            {
                return resultado;
            }

            return resultado.Remove(indiceComercial);

            //int indiceParamentro = _argumentos.IndexOf
        }

    }
}
