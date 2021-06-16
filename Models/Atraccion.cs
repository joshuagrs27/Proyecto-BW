using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Proyecto.Models
{
    [Table("Atracción")]
    public class Atraccion
    {
        [Key]
        public Int32 idAtraccion
        {
            get; set;
        }

        public string nombre
        {
            get; set;
        }

        public TimeSpan horaApertura
        {
            get; set;
        }

        public TimeSpan horaCierre
        {
            get; set;
        }

        public Double precio
        {
            get; set;
        }

        public Int32 idDisneyland
        {
            get; set;
        }

       
    }
}