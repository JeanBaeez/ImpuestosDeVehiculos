using Data;
using Data.Repository;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ResourceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiculosController : ControllerBase
    {
        private readonly VehiculosContext _db;
        private readonly Vehiculos _Vehiculos = new Vehiculos();
        private readonly IVehiculosRepository _Repo;

        public VehiculosController(VehiculosContext db, Vehiculos vehiculos,IVehiculosRepository Repo)
        {
            _db = db;
            vehiculos = _Vehiculos;
            _Repo = Repo;
        }

        [HttpGet]
        public   ActionResult GetVehiculos()
        {
            IEnumerable vehiculos =   _db.Vehiculos;
            return Ok(vehiculos);

        }

        [HttpGet]
        [Route("/Marcas")]
        public ActionResult<IEnumerable<string>> GetMarcas()
        {
            IEnumerable<string> marcas = _db.Vehiculos.Select(x => x.Marca).Distinct();/* Select(x => x.Marca).Distinct();*/
            return Ok(marcas);

        }

        [HttpGet]
        [Route("/Modelos/{marca}")]
        public ActionResult<IEnumerable<string>> GetModelos(string marca)
        {
           var marcas =  _Repo.ModelosByMarca(marca);

            return Ok(marcas);
        }
        [HttpGet]
        [Route("/TipoAutomovil/{modelo}")]
        public ActionResult<IEnumerable<string>> GetTipoAutomovil(string modelo)
        {
            var modelos = _Repo.TipoDeVehiculosByModelo(modelo);


            return Ok(modelos);
        }




        [HttpGet]
        [Route("/Pais/{modelo}")]
        public ActionResult<IEnumerable<string>> GetPais(string modelo)
        {
            var modelos = _Repo.Pais(modelo);


            return Ok(modelos);
        }



[HttpGet]
[Route("/Descripcion/{pais}/{modelo}")]
public ActionResult<IEnumerable<string>>GetDescripcion(string pais,string modelo)
{



        var desc = _Repo.Descripcion(pais,modelo);
        return Ok(desc);

}


[HttpGet]
[Route("/Ano/{marca}/{modelo}")]
public ActionResult<IEnumerable<int>> GetAno(string marca, string modelo){


        var ano = _Repo.Ano(marca,modelo);

var data = (from item in ano
            select item).Distinct();
        return Ok(data);

}


    }
}
