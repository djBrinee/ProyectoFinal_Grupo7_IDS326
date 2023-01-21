using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngleSharp;


namespace ProyectoFinal_Grupo7_IDS326
{
    public struct Tasa
    {
        public string Entidad;
        public decimal Valor;
        public string MonedaOrigen;
        public string MonedaDestino;

        public Tasa(decimal valor, string monedaOrigen, string monedaDestino, string entidad = "")
        {
            Entidad = entidad;
            Valor = valor;
            MonedaOrigen = monedaOrigen;
            MonedaDestino = monedaDestino;
        }

    }

    // Esta interfaz es para poder hacer un stub de BuscadorTasas para las Pruebas Unitarias
    public interface IBuscadorTasas
    {
        Task<List<Tasa>> ObtenerTasas();
    }

    /* Esta es la clase que hace un request a infodolar.com.do y hace un scrapping de las tasas.
    Tendrán que hacer un stub de esta clase en el proyecto de Pruebas Unitarias, para sustituirla
    por una versión que no haga el request realmente (al final, descarté lo que les había comentado
    de hacer un stub del HttpClient o del BrowsingContext porque se complicaría demasiado).*/
    public class BuscadorTasas : IBuscadorTasas
    {
        /* Este método debería ser async para poder hacerle un await al método "OpenAsync". 
         La razón por la que no lo puse async, es para que lo hagan ustedes mismos cuando lo integren
        a su proyecto. */
        public async Task<List<Tasa>> ObtenerTasas()
        {
            List<Tasa> tasas = new List<Tasa>();
            var config = Configuration.Default.WithDefaultLoader();
            var address = "https://www.infodolar.com.do/";
            var context = BrowsingContext.New(config);
            var document = await context.OpenAsync(address); //deben de sustituirlo por un await
            var cells = document.QuerySelectorAll("table#Dolar tbody tr");

            foreach (var i in cells)
            {
                var bankName = i.Children[0].QuerySelector("span.nombre")?.TextContent.Trim() ?? "";
                var buyPriceConSimbolo = i.Children[1].TextContent.Split('\n')[1].Trim();
                var sellPriceConSimbolo = i.Children[2].TextContent.Split('\n')[1].Trim();
                decimal buyPrice = buyPriceConSimbolo != "" ? Convert.ToDecimal(buyPriceConSimbolo.Replace("$", ""), CultureInfo.InvariantCulture) : (decimal)0.00;
                decimal sellPrice = sellPriceConSimbolo != "" ? Convert.ToDecimal(sellPriceConSimbolo.Replace("$", "")) : (decimal)0.0;
                tasas.Add(new Tasa(buyPrice, "USD", "DOP", bankName));
                tasas.Add(new Tasa(sellPrice, "DOP", "USD", bankName));
            }
            return tasas;

        }
    }
}
