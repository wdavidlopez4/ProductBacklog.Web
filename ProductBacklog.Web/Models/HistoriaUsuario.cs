using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductBacklog.Web.Models
{
    public class HistoriaUsuario : ModelBase
    {
        public string Descripcion { get; set; }

        public string Observacion { get; set; }

        public EstadoEnum Estado { get; set; }

        public HistoriaUsuario(string descripcion, string observacion, EstadoEnum estado):base()
        {
            if (string.IsNullOrWhiteSpace(descripcion))
            {
                throw new ArgumentNullException("es necesario la descripcion para crear la HU");
            }
            else if (string.IsNullOrWhiteSpace(observacion))
            {
                throw new ArgumentNullException("es necesario crear la observacion para HU");
            }
            else
            {
                this.Descripcion = descripcion;
                this.Estado = estado;
                this.Observacion = observacion;
            }
        }

        public HistoriaUsuario()
        {

        }
    }
}
