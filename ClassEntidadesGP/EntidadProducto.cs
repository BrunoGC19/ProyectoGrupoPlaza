using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEntidadesGP
{
    public class EntidadProducto
    {
        public int idProducto { get; set; }
        public string Nombre { get; set; }
        public int Final { get; set; }
        public int Unidad { get; set; }
        public int idProcedimiento { get; set; }
        public string rutaImagen { get; set; }
        public string rutaVideo { get; set; }
        public DateTime fecha { get; set; }

    }
}
