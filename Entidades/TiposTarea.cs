using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static segundo_parcial.Entidades.Proyectos;

namespace segundo_parcial.Entidades
{
    public class TiposTarea
    {
        [Key]
        public int TipoId { get; set; }
        public string Descripcion { get; set; }

        [ForeignKey("TipoId")]
        public virtual List<ProyectosDetalle> Detalle { get; set; }

        public TiposTarea()
        {
            Detalle = new List<ProyectosDetalle>();
        }
    }
}
