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
    public class LogicaNegocioProducto
    {
        private AccesoSQL operaciones = null;

        public LogicaNegocioProducto(string cadconex)
        {
            operaciones = new AccesoSQL(cadconex);
        }
        public LogicaNegocioProducto()
        {
          
        }

        public DataTable obtenerTodosProductos(ref string m, ref string cons)
        {
            string consulta = "select idProducto, Nombre, Presentacion, Final, idClasi, idGrupo, idSubGrup from Producto where idSubGrup = '" + cons + "'";
            DataTable salidaDT = null;
            DataSet contenedorDS = null;

            contenedorDS = operaciones.ConsultaDS(consulta, operaciones.AbrirConexion(ref m), ref m);
            if (contenedorDS != null)
            {
                salidaDT = contenedorDS.Tables[0];
            }
            return salidaDT;
        }
    }
}
