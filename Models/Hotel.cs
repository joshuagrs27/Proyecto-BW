using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.Models
{
    [Table("Hotel")]
    public class Hotel
    {
        [Key]
        public Int32 idHotel
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

    }
}