namespace ImpuestosVehiculos.Data
{
    //objeto para calcular
    public class CalculoObject
    {
        public string Marca  { get; set; }
        public string Modelo { get; set; }
        public string Ano { get; set; }
        public string Pais { get; set; }
        public  string TratadoAcuerdo { get; set; }
        public double? ValorFactura { get; set; }
        public double? Flete { get; set;}
        public double? Seguro { get; set; }
        public double? Otros { get; set; }
    }
}