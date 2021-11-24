using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEntidadesGP
{
    public class EntidadSubGrupo
    {
        public int idSubGrup { get; set; }
        public string NombreSubGrup { get; set; }
        public string DescripSubGrup { get; set; }
        public int idClasi { get; set; }
        public int idGrupo { get; set; }
    }
}
