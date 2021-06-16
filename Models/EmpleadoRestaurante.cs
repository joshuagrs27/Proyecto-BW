using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Proyecto.Models
{
    [Table("EmpleadoRestaurante")]
    public class EmpleadoRestaurante
    {
        [Key]
        public Int32 idEmpleadoRestaurante
        {
            get; set;
        }

        public string nombres
        {
            get; set;
        }

        public string apellidoPaterno
        {
            get; set;
        }

        public string apellidoMaterno
        {
            get; set;
        }

        public Int32 idRestaurante
        {
            get; set;
        }
    }
}