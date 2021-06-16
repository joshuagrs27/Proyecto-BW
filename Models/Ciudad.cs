using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Proyecto.Models
{
    [Table("Ciudad")]
    public class Ciudad
    {
        [Key]
        public Int32 idCiudad
        {
            get; set;
        }

        public string nombre
        {
            get; set;
        }

        public Double superficie
        {
            get; set;
        }

        public Double poblacion
        {
            get; set;
        }

       
    }
}