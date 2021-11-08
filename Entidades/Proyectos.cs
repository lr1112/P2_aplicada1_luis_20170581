using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace segundo_parcial.Entidades
{
    public class Proyectos
    {
        [Key]
        public int ProyectoId { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public double TiempoTotal { get; set; }

        [ForeignKey("ProyectoId")]
        public virtual List<ProyectosDetalle> Detalle { get; set; }

        public Proyectos()
        {
            Fecha = DateTime.Now;
            Detalle = new List<ProyectosDetalle>();
        }

        public class ProyectosDetalle
        {
            [Key]
            public int ProyectosDetalleId { get; set; }
            public int ProyectoId { get; set; }
            public int TipoId { get; set; }
            public string Requerimiento { get; set; }
            public double Tiempo { get; set; }

        }
    }
}
