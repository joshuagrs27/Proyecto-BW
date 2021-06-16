using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.Models
{
    [Table("TuristaParqueDisneyland")]
    public class TuristaParqueDisneyland
    {
        [Key]
        public Int32 idTuristaParqueDisneyland
        {
            get; set;
        }

        public Int32 idTurista
        {
            get; set;
        }

        public Int32 idDisneyland
        {
            get; set;
        }
    }
}