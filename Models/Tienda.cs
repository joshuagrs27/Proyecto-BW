using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.Models
{
    [Table("Tienda")]
    public class Tienda
    {
        [Key]
        public Int32 idTienda
        {
            get; set;
        }

        public string nombre
        {
            get; set;
        }

        public string tipo
        {
            get; set;
        }
        public string ubicacion
        {
            get; set;
        }
        public Int32 idDisneyland
        {
            get; set;
        }
    }
}