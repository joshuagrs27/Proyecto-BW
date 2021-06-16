using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.Models
{
    [Table("TuristaHotel")]
    public class TuristaHotel
    {
        [Key]
        public Int32 idTuristaHotel
        {
            get; set;
        }

        public Int32 idTurista
        {
            get; set;
        }

        public Int32 idHotel
        {
            get; set;
        }
    }
}