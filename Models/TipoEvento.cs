using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.Models
{
    [Table("TipoEvento")]
    public class TipoEvento
    {
        [Key]
        public Int32 idTipoEvento
        {
            get; set;
        }

        public string nombre
        {
            get; set;
        }

        public Int32 duracionDias
        {
            get; set;
        }

        public string clasificacion
        {
            get; set;
        }
        
    }
}