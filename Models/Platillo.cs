using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.Models
{
    [Table("Platillo")]
    public class Platillo
    {
        [Key]
        public Int32 idPlatillo
        {
            get; set;
        }

        public string nombre
        {
            get; set;
        }

        public string sabor
        {
            get; set;
        }

        public Double precio
        {
            get; set;
        }

        public Int32 idRestaurante
        {
            get; set;
        }

        public Int32 idTurista
        {
            get; set;
        }
    }
}