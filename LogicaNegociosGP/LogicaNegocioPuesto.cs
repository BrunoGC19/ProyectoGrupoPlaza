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
    public class LogicaNegocioPuesto
    {
        private AccesoSQL operaciones = null;

        public LogicaNegocioPuesto(string cadconex)
        {
            operaciones = new AccesoSQL(cadconex);
        }

        public List<EntidadPuesto> informacionPuesto(ref string mensaje)
        {
            string consulta = "select idPuesto, Nombre from Puesto";
            SqlDataReader contenedor = null;
            SqlConnection cntemp = null;
            List<EntidadPuesto> misobjs = new List<EntidadPuesto>();

            cntemp = operaciones.AbrirConexion(ref mensaje);
            contenedor = operaciones.ConsultaReader(consulta, cntemp, ref mensaje);

            if (contenedor != null)
            {
                while (contenedor.Read())
                {
                    misobjs.Add(
                        new EntidadPuesto
                        {
                            idPuesto = (int)contenedor[0],
                            Nombre = (string)contenedor[1]
                        }
                        );
                }
            }
            return misobjs;
        }
    }
}
