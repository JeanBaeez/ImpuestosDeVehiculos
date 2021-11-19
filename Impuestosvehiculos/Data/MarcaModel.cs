using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class MarcaModel
    {
        [StringLength(50)]
        public string Marca { get; set; }
    }
}
