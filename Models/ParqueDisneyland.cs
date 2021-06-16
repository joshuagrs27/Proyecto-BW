using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.Models
{
    [Table("ParqueDisneyland")]
    public class ParqueDisneyland
    {
        [Key]
        public Int32 idDisneyland
        {
            get; set;
        }

        public string nombre
        {
            get; set;
        }

        public string pais
        {
            get; set;
        }

        public string telefono
        {
            get; set;
        }

        public Int32 idHorario
        {
            get; set;
        }

        public Int32 idEstado
        {
            get; set;
        }
    }
}