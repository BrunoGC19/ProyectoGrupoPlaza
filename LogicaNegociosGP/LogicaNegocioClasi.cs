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
    public class LogicaNegocioClasi
    {
        private AccesoSQL operaciones = null;

        public LogicaNegocioClasi(string cadconex)
        {
            operaciones = new AccesoSQL(cadconex);
        }

        
    }

}
