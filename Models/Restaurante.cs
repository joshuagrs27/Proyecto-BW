using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.Models
{
    [Table("Restaurante")]
    public class Restaurante
    {
        [Key]
        public Int32 idRestaurante
        {
            get; set;
        }

        public string nombre
        {
            get; set;
        }

        public Int32 capacidad
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