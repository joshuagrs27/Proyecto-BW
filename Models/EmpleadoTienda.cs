using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Proyecto.Models
{
    [Table("EmpleadoTienda")]
    public class EmpleadoTienda
    {
        [Key]
        public Int32 idEmpleadoTienda
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

        public Int32 idTienda
        {
            get; set;
        }
    }
}