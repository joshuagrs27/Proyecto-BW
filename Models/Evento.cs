using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.Models
{
    [Table("Evento")]
    public class Evento
    {
        [Key]
        public Int32 idEvento
        {
            get; set;
        }

        public string nombre
        {
            get; set;
        }

        public DateTime fecha
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