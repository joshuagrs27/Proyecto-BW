using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Proyecto.Models
{
    [Table("Boleto")]
    public class Boleto
    {
        [Key]

        public Int32 idBoleto
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

        public Int32 idTurista
        {
            get; set;
        }

    }
}