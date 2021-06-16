using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.Models
{
    [Table("TipoEventoEvento")]
    public class TipoEventoEvento
    {
        [Key]
        public Int32 idTipoEventoEvento
        {
            get; set;
        }

        public Int32 idEvento
        {
            get; set;
        }

        public Int32 idTipoEvento
        {
            get; set;
        }

        
    }
}