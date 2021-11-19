using System.Threading.Tasks;
using ResourceAPI.Controllers;
namespace ImpuestosVehiculos.Data
{
    
    //objeto para mostrar en el ui
    public class ResultadosObject
    {
        public ResultadosObject()
        {
          
        }
        public double TasaDeCambio { get; set; }
        public double? ImpuestoAduanal { get; set; }
        public double? ITBIS { get; set; }
        public double? Total { get; set; }





        public ResultadosObject Resultados(CalculoObject Object)
        {
            Operaciones operaciones = new Operaciones();
            ResultadosObject resultados = new();


            var porciento = operaciones.tomar20Porciento(Object.ValorFactura);

            var itbis = operaciones.CalcularITBIS(Object.ValorFactura);
            resultados.ImpuestoAduanal = porciento;
            resultados.ITBIS = itbis;
            resultados.TasaDeCambio = 56.38;
            resultados.Total = operaciones.TOTAL(_ImpuestoAduanal: porciento, _ITBIS: itbis, Tasa: TasaDeCambio, _ValorFactura: Object.ValorFactura);
            //CurrencyController api = new CurrencyController();

            // var res = await api.getDollar();.Value;
            return resultados;


        }
    }
}