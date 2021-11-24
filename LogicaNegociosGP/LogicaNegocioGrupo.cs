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
   public class LogicaNegocioGrupo
   {
        private AccesoSQL operaciones = null;

        public LogicaNegocioGrupo(string cadconex)
        {
            operaciones = new AccesoSQL(cadconex);
        }

        public List<EntidadGrupo> informacionGrupo(ref string mensaje)
        {
            string consulta = "select idGrupo, NombreGrup, idClasi from Grupo;";
            SqlDataReader contenedor = null;
            SqlConnection cntemp = null;
            List<EntidadGrupo> misobj = new List<EntidadGrupo>();

            cntemp = operaciones.AbrirConexion(ref mensaje);
            contenedor = operaciones.ConsultaReader(consulta, cntemp, ref mensaje);

            if (contenedor != null)
            {
                while (contenedor.Read())
                {
                    misobj.Add(
                        new EntidadGrupo
                        {
                            idGrupo = (int)contenedor[0],
                            NombreGrup = (string)contenedor[1],
                            idClasi =(int)contenedor[2]

                        }
                        );
                }
            }
            return misobj;
        }
        public List<EntidadGrupo> informacionClasificadorAlimentos(ref string mensaje)
        {
            string consulta = "select idGrupo,NombreGrup from Grupo where idClasi=1;";
            SqlDataReader contenedor = null;
            SqlConnection cntemp = null;
            List<EntidadGrupo> misobj = new List<EntidadGrupo>();

            cntemp = operaciones.AbrirConexion(ref mensaje);
            contenedor = operaciones.ConsultaReader(consulta, cntemp, ref mensaje);

            if (contenedor != null)
            {
                while (contenedor.Read())
                {
                    misobj.Add(
                        new EntidadGrupo
                        {
                            idGrupo = (int)contenedor[0],
                            NombreGrup = (string)contenedor[1]
                        }
                        );
                }
            }
            return misobj;
        }
        public List<EntidadGrupo> informacionClasificadorBebidas(ref string mensaje)
        {
            string consulta = "select idGrupo,NombreGrup from Grupo where idClasi=2;";
            SqlDataReader contenedor = null;
            SqlConnection cntemp = null;
            List<EntidadGrupo> misobj = new List<EntidadGrupo>();

            cntemp = operaciones.AbrirConexion(ref mensaje);
            contenedor = operaciones.ConsultaReader(consulta, cntemp, ref mensaje);

            if (contenedor != null)
            {
                while (contenedor.Read())
                {
                    misobj.Add(
                        new EntidadGrupo
                        {
                            idGrupo = (int)contenedor[0],
                            NombreGrup = (string)contenedor[1]
                        }
                        );
                }
            }
            return misobj;
        }


    }
}
