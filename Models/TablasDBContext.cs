using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Proyecto.Models
{
    public class TablasDBContext: DbContext
    {
        public DbSet<Turista> Turista { get; set; }
        public DbSet<Atraccion> Atraccion { get; set; }
        public DbSet<Boleto> Boleto { get; set; }
        public DbSet<Ciudad> Ciudad { get; set; }
        public DbSet<EmpleadoRestaurante> EmpleadoRestaurante { get; set; }
        public DbSet<EmpleadoTienda> EmpleadoTienda { get; set; }
        public DbSet<Estado> Estado { get; set; }
        public DbSet<Evento> Evento { get; set; }
        public DbSet<Horario> Horario { get; set; }
        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<ParqueDisneyland> ParqueDisneyland { get; set; }
        public DbSet<Platillo> Platillo { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Restaurante> Restaurante { get; set; }
        public DbSet<Tienda> Tienda { get; set; }
        public DbSet<TipoEvento> TipoEvento { get; set; }
        public DbSet<TipoEventoEvento> TipoEventoEvento { get; set; }
        public DbSet<TuristaHotel> TuristaHotel { get; set; }
        public DbSet<TuristaParqueDisneyland> TuristaParqueDisneyland { get; set; }
    }
}