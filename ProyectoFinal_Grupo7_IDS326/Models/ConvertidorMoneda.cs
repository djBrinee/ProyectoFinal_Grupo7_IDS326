using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Grupo7_IDS326
{
    public class ConvertidorMoneda
    {
        IBuscadorTasas buscadorTasas;
        public ConvertidorMoneda(IBuscadorTasas buscadorTasas)
        {
            this.buscadorTasas = buscadorTasas;
        }

        // Esto no es necesario para su programa. Esto sólo es mostrando como recorrer la lista de tasas
        public void MostrarReporteDeTasas()
        {
            var tasas = buscadorTasas.ObtenerTasas();
            foreach (Tasa tasa in tasas.Result)
                Console.WriteLine($"{tasa.Entidad,-45}  {tasa.Valor,6}  {tasa.MonedaOrigen}->{tasa.MonedaDestino}");
        }

        public async Task<decimal> ConvertidorDolaresAPesos (decimal pesos)
        {
            var tasas = await buscadorTasas.ObtenerTasas();

            // Filtrando lista, según criterios Entidad, MonedaOrigen y Destino, y tomando el 1er resultado
            var tasaVentaDolaresPopular = tasas.Where(x => x.Entidad == "Banco Popular"
                                                     && x.MonedaOrigen == "USD"
                                                     && x.MonedaDestino == "DOP").First();

            /* Debido a que todas las tasas están en DOP, para convertir de Pesos a Dólares se debe dividir,
             mientras que para convertir de Dólares a Pesos se debe multiplicar. Es decir:
                   DOP->USD:    cantidadDolares = cantidadPesos   ÷ tasaPesos
                   USD->DOP:    cantidadPesos   = cantidadDolares × tasaPesos 
            */
            return  Math.Round(pesos * tasaVentaDolaresPopular.Valor,2);
        }
    }
}
