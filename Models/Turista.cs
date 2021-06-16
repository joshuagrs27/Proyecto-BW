using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Proyecto.Models
{
    [Table("Turista")]
    public class Turista
    {
        [Key]

        public Int32 idTurista
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

        public string telefono
        {
            get; set;
        }

        public string genero
        {
            get; set;
        }

        public string nacionalidad
        {
            get; set;
        }
       
    }
}