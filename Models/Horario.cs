using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.Models
{
    [Table("Horario")]
    public class Horario
    {
        [Key]
        public Int32 idHorario
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

        public string dia
        {
            get; set;
        }

       
    }
}