using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using LibreriaParaSweet;
using ClassEntidadesGP;

namespace LogicaNegociosGP
{
    public class LogicaNegocioMarca
    {
        private AccesoSQL operaciones = null;

        public LogicaNegocioMarca(string cadconex)
        {
            operaciones = new AccesoSQL(cadconex);
        }

        public List<EntidadMarca> informacionMarcas(ref string mensaje)
        {
            string consulta = "select idMarca, Nombre from Marca";
            SqlDataReader contenedor = null;
            SqlConnection cntemp = null;
            List<EntidadMarca> misobjs = new List<EntidadMarca>();

            cntemp = operaciones.AbrirConexion(ref mensaje);
            contenedor = operaciones.ConsultaReader(consulta, cntemp, ref mensaje);

            if (contenedor != null)
            {
                while (contenedor.Read())
                {
                    misobjs.Add(
                        new EntidadMarca
                        {
                            idMarca = (int)contenedor[0],
                            Nombre = (string)contenedor[1]
                        }
                        );
                }
            }
            return misobjs;
        }

    }
}
