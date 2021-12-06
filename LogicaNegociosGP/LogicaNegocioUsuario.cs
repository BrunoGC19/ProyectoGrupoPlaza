using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using LibreriaParaSweet;
using ClassEntidadesGP;
using System.Web;
using EASendMail;

namespace LogicaNegociosGP
{
    public class LogicaNegocioUsuario
    {
        private AccesoSQL operaciones = null;

        public LogicaNegocioUsuario(string cadconex)
        {
            operaciones = new AccesoSQL(cadconex);
        }
        public LogicaNegocioUsuario()
        {
        }

        //public string ComparaNombre(string name)
        //{
        //    string consulta = "select ContraseñaIncrip from Usuario where NombreUsr= '" + name + "'";
        //    string contraseñaEncript = "";
        //    SqlDataReader contenedor = null;
        //    SqlConnection cntemp = null;
        //    string mensaje = "";
        //    cntemp = operaciones.AbrirConexion(ref mensaje);
        //    contenedor = operaciones.ConsultaReader(consulta, cntemp, ref mensaje);


        //    contraseñaEncript = contenedor["ContraseñaIncrip"].ToString();





        //    return contraseñaEncript;
        //}

        public EntidadUsuario informacionUsuario(ref string mensaje, ref string usr, ref string cont)
        {
            string consulta = "select idUser, NombreUsr, Contraseña, idPuesto from Usuario where NombreUsr= '" + usr + "' and Contraseña = '" + cont + "'";
            SqlDataReader contenedor = null;
            SqlConnection cntemp = null;
            EntidadUsuario misobj = new EntidadUsuario();

            cntemp = operaciones.AbrirConexion(ref mensaje);
            contenedor = operaciones.ConsultaReader(consulta, cntemp, ref mensaje);

            if (contenedor != null)
            {
                while (contenedor.Read())
                {

                    misobj.idUser = (int)contenedor[0];
                    misobj.NombreUsr = (string)contenedor[1];
                    misobj.Contraseña = (string)contenedor[2];
                    misobj.idPuesto = (int)contenedor[3];

                }
            }
            return misobj;
        }

        public EntidadUsuario informacionContraseña(ref string mensaje, ref string name)
        {
            string consulta = "select ContraseñaIncrip from Usuario where NombreUsr= '" + name + "'";
            SqlDataReader contenedor = null;
            SqlConnection cntemp = null;
            EntidadUsuario misobj = new EntidadUsuario();

            cntemp = operaciones.AbrirConexion(ref mensaje);
            contenedor = operaciones.ConsultaReader(consulta, cntemp, ref mensaje);

            if (contenedor != null)
            {
                while (contenedor.Read())
                {
                    misobj.ContraseñaIncrip = (string)contenedor[0];
                       
                }
            }
            return misobj;
        }

        public Boolean InsertarUsuario(EntidadUsuario ob_nuevo,
            ref string mensaje)
        {
            string sentencia = "insert into Usuario (NombreUsr, Contraseña, ContraseñaIncrip, idMarca, idPuesto)" +
                "values (@nombre,@contrasena,@contraincrip,@idmarca,@idpuesto);";
            Boolean salida = false;

            SqlParameter[] arregloPars = new SqlParameter[]
            {
                new SqlParameter("nombre", SqlDbType.VarChar, 30),
                new SqlParameter("contrasena", SqlDbType.VarChar, 100),
                new SqlParameter("contraincrip", SqlDbType.VarChar, 100),
                new SqlParameter("idmarca", SqlDbType.Int),
                new SqlParameter("idpuesto", SqlDbType.Int),
            };

            arregloPars[0].Value = ob_nuevo.NombreUsr;
            arregloPars[1].Value = ob_nuevo.Contraseña;
            arregloPars[2].Value = ob_nuevo.ContraseñaIncrip;
            arregloPars[3].Value = ob_nuevo.idMarca;
            arregloPars[4].Value = ob_nuevo.idPuesto;

            salida = operaciones.OperacionMasSeguraModificacionBD(sentencia, operaciones.AbrirConexion(ref mensaje), ref mensaje, arregloPars);

            return salida;
        }

        public string EnviarCorreo(ref string correo, ref string asunto, ref string mensajeCorreo)
        {
            string mensaje = "Error de envio";

            try
            {
                SmtpMail objetoCorreo = new SmtpMail("TryIt");
                objetoCorreo.From = "UTP0007276@alumno.utpuebla.edu.mx";
                objetoCorreo.To = correo;
                objetoCorreo.Subject = asunto;
                objetoCorreo.TextBody = mensajeCorreo;

                SmtpServer objetoServer = new SmtpServer("smtp.gmail.com");

                objetoServer.User = "UTP0007276@alumno.utpuebla.edu.mx";
                objetoServer.Password = "madelyn1";
                objetoServer.Port = 587;
                objetoServer.ConnectType = SmtpConnectType.ConnectSSLAuto;

                SmtpClient objetoCliente = new SmtpClient();
                objetoCliente.SendMail(objetoServer, objetoCorreo);
                mensaje = "Correo enviado correctamente";
            }
            catch(Exception ex)
            {
                mensaje = "Error de envio" + ex.Message;
            }
            return mensaje;
        }
    }
}
