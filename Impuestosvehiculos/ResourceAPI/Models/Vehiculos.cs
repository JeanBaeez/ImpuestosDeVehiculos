﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ResourceAPI.Models
{
    [Keyless]
    public  class Vehiculos
    {
        [Column("Codigo_de_Producto")]
        [StringLength(50)]
        public string CodigoDeProducto { get; set; }
        [Column("Codigo_Arancel")]
        [StringLength(50)]
        public string CodigoArancel { get; set; }
        [Column("Nombre_de_Producto")]
        [StringLength(50)]
        public string NombreDeProducto { get; set; }
        [StringLength(50)]
        public string Marca { get; set; }
        [Column("modelo")]
        [StringLength(50)]
        public string Modelo { get; set; }
        public int? Año { get; set; }
        [Column("Especificacion_de_Producto")]
        [StringLength(250)]
        public string EspecificacionDeProducto { get; set; }
        [StringLength(50)]
        public string Pais { get; set; }
        [Column(TypeName = "money")]
        public decimal? Valor { get; set; }
    }
}