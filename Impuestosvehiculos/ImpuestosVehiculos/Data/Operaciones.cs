
namespace ImpuestosVehiculos.Data
{
    public class Operaciones
    {
        public double? tomar20Porciento(double? IncomeNumber)
        {

             var div = IncomeNumber % 100;
            return IncomeNumber;
        }

        public double? CalcularITBIS(double? incomeNumebr)
        {
            var numb = incomeNumebr * 0.28;
         return numb;

        }
        public double? TOTAL(double? _ImpuestoAduanal,double? _ITBIS,double? Tasa,double? _ValorFactura)
        {
            var resultados = _ImpuestoAduanal + _ITBIS + _ValorFactura;

            return resultados;
        }
    }
}