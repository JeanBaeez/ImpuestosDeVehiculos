using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Data.Repository
{
    public class VehiculosRepository : IVehiculosRepository
    {
        private readonly VehiculosContext _db;

        public VehiculosRepository(VehiculosContext _db) 
        {
            this._db = _db;
        }
        public IEnumerable<string>ModelosByMarca(string marca)
        {
            IEnumerable<Vehiculos> Vehiculos = _db.Vehiculos;
            var marcas = Vehiculos.Where(x => x.Marca == marca).Select(p => p.Modelo).Distinct(); 
            return marcas; 
            
        }

        public IEnumerable<string> Pais(string modelo)
        {

            IEnumerable<Vehiculos> Vehiculos = _db.Vehiculos;
            var tipoAutomovil = Vehiculos.Where(x => x.Modelo == modelo).Select(p => p.Pais).Select(x => x.TrimStart().TrimEnd());

            return tipoAutomovil.Distinct();
        }

        public IEnumerable<string> TipoDeVehiculosByModelo(string modelo)
        {
            IEnumerable<Vehiculos> Vehiculos = _db.Vehiculos;
            var tipoAutomovil = Vehiculos.Where(x =>  x.Modelo == modelo).Select(p => p.NombreDeProducto).Select(x=>x.TrimStart().TrimEnd());
        
            return tipoAutomovil.Distinct();
        }

        public Vehiculos TodosVehiculos()
        {
            throw new NotImplementedException();
        }


        public IEnumerable<string> Descripcion (string pais,string modelo){

          var data = _db.Vehiculos;
            var descripcion = data.Where(x => x.Modelo == modelo && x.Pais == pais).Select(p => p.EspecificacionDeProducto).Select(s => s.TrimStart().TrimEnd());
          return descripcion;


        }
          public IQueryable<int?> Ano (string marca,string modelo){

          var data = _db.Vehiculos;
            var ano = data.Where(x => x.Marca == marca && x.Modelo == modelo).Select(e=>e.Año);
            
          return ano;


        }
    }
}
