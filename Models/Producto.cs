using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.Models
{
    [Table("Producto")]
    public class Producto
    {
        [Key]
        public Int32 idProducto
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

        public Double precio
        {
            get; set;
        }

        public Int32 idTienda
        {
            get; set;
        }

        public Int32 idTurista
        {
            get; set;
        }
    }
}