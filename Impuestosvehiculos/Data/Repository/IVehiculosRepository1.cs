using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public interface IVehiculosRepository
    {
        Vehiculos TodosVehiculos();
        IEnumerable<string> ModelosByMarca(string marca);
        IEnumerable<string> TipoDeVehiculosByModelo(string modelo);
        IEnumerable<string> Pais(string modelo);
        IEnumerable<string> Descripcion(string modelo,string pais);
        IQueryable<int?> Ano(string marca,string modelo);
    }
}
