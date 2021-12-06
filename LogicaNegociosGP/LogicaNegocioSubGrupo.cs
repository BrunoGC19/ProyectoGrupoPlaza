using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using LibreriaParaSweet;
using ClassEntidadesGP;

namespace LogicaNegociosGP
{
   public class LogicaNegocioSubGrupo
   {
        private AccesoSQL operaciones = null;

        public LogicaNegocioSubGrupo(string cadconex)
        {
            operaciones = new AccesoSQL(cadconex);
        }
        public LogicaNegocioSubGrupo()
        {
            
        }

        public List<EntidadSubGrupo> informacionSubGrupo(ref string mensaje,int subG)
        {
            string consulta = "select idSubGrup,NombreSubGrup from SubGrupo where idGrupo =" + subG + ";";
            SqlDataReader contenedor = null;
            SqlConnection cntemp = null;
            List<EntidadSubGrupo> misobj = new List<EntidadSubGrupo>();

            cntemp = operaciones.AbrirConexion(ref mensaje);
            contenedor = operaciones.ConsultaReader(consulta, cntemp, ref mensaje);

            if (contenedor != null)
            {
                while (contenedor.Read())
                {
                    misobj.Add(
                        new EntidadSubGrupo
                        {
                            idSubGrup = (int)contenedor[0],
                            NombreSubGrup = (string)contenedor[1]
                        }
                        );
                }
            }
            return misobj;
        }

    }
}
