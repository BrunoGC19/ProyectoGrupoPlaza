using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using LibreriaParaSweet;
using ClassEntidadesGP;
using System.Security.Cryptography;

namespace LogicaNegociosGP
{
    public class LogicaNegocioComentario
    {
        private AccesoSQL operaciones = null;
        //Llave de encriptacion 
        string key = "mikey";
        public LogicaNegocioComentario(string cadconex)
        {
            operaciones = new AccesoSQL(cadconex);
        }
        public LogicaNegocioComentario()
        {
           
        }

        public Boolean InsertarComentario(EntidadComentario ob_nuevo,
            ref string mensaje)
        {
            string sentencia = "insert into Comentario (NombreUsr, Correo, Mensaje, MensjIncript)" +
                "values (@nombre,@correo,@mensaje,@mensjincript);";
            Boolean salida = false;

            SqlParameter[] arregloPars = new SqlParameter[]
            {
                new SqlParameter("nombre", SqlDbType.VarChar, 30),
                new SqlParameter("correo", SqlDbType.VarChar, 100),
                new SqlParameter("mensaje", SqlDbType.VarChar, 200),
                new SqlParameter("mensjincript", SqlDbType.VarChar, 200),
            };

            arregloPars[0].Value = ob_nuevo.NombreUsr;
            arregloPars[1].Value = ob_nuevo.Correo;
            arregloPars[2].Value = ob_nuevo.Mensaje;
            arregloPars[3].Value = ob_nuevo.MensjIncript;

            salida = operaciones.OperacionMasSeguraModificacionBD(sentencia, operaciones.AbrirConexion(ref mensaje), ref mensaje, arregloPars);

            return salida;
        }
        public Boolean InsertarMarca(EntidadMarca ob_nuevo,
           ref string mensaje)
        {
            string sentencia = "insert into Marca (Nombre,Descripcion)" +
                "values (@nombre,@descripcion);";
            Boolean salida = false;

            SqlParameter[] arregloPars = new SqlParameter[]
            {
                new SqlParameter("nombre", SqlDbType.VarChar, 100),
                new SqlParameter("descripcion", SqlDbType.VarChar, 100)
            };

            arregloPars[0].Value = ob_nuevo.Nombre;
            arregloPars[1].Value = ob_nuevo.Descripcion;
          

            salida = operaciones.OperacionMasSeguraModificacionBD(sentencia, operaciones.AbrirConexion(ref mensaje), ref mensaje, arregloPars);

            return salida;
        }

        public string EncriptarMD5(ref string mensajeEncrip)
        {

            //arreglo de bytes donde guardaremos la llave
            byte[] keyArray;
            //arreglo de bytes donde guardaremos el texto
            //que vamos a encriptar
            byte[] Arreglo_a_Cifrar =
            UTF8Encoding.UTF8.GetBytes(mensajeEncrip);

            //se utilizan las clases de encriptación
            //provistas por el Framework
            //Algoritmo MD5
            MD5CryptoServiceProvider hashmd5 =
            new MD5CryptoServiceProvider();
            //se guarda la llave para que se le realice
            //hashing
            keyArray = hashmd5.ComputeHash(
            UTF8Encoding.UTF8.GetBytes(key));

            hashmd5.Clear();

            //Algoritmo 3DAS
            TripleDESCryptoServiceProvider tdes =
            new TripleDESCryptoServiceProvider();

            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            //se empieza con la transformación de la cadena
            ICryptoTransform cTransform =
            tdes.CreateEncryptor();

            //arreglo de bytes donde se guarda la
            //cadena cifrada
            byte[] ArrayResultado =
            cTransform.TransformFinalBlock(Arreglo_a_Cifrar,
            0, Arreglo_a_Cifrar.Length);

            tdes.Clear();

            //se regresa el resultado en forma de una cadena
            return Convert.ToBase64String(ArrayResultado,
            0, ArrayResultado.Length);
        }

        public string DesencriptarMD5(ref string mensajeDesencrip)
        {
            byte[] keyArray;
            //convierte el texto en una secuencia de bytes
            byte[] Array_a_Descifrar =
            Convert.FromBase64String(mensajeDesencrip);

            //se llama a las clases que tienen los algoritmos
            //de encriptación se le aplica hashing
            //algoritmo MD5
            MD5CryptoServiceProvider hashmd5 =
            new MD5CryptoServiceProvider();

            keyArray = hashmd5.ComputeHash(
            UTF8Encoding.UTF8.GetBytes(key));

            hashmd5.Clear();

            TripleDESCryptoServiceProvider tdes =
            new TripleDESCryptoServiceProvider();

            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform =
            tdes.CreateDecryptor();

            byte[] resultArray =
            cTransform.TransformFinalBlock(Array_a_Descifrar,
            0, Array_a_Descifrar.Length);

            tdes.Clear();
            //se regresa en forma de cadena
            return UTF8Encoding.UTF8.GetString(resultArray);
        }

        public EntidadComentario informacionMensaje(ref string mensaje, ref string name)
        {
            string consulta = "select MensjIncript from Comentario where NombreUsr= '" + name + "'";
            SqlDataReader contenedor = null;
            SqlConnection cntemp = null;
            EntidadComentario misobj = new EntidadComentario();

            cntemp = operaciones.AbrirConexion(ref mensaje);
            contenedor = operaciones.ConsultaReader(consulta, cntemp, ref mensaje);

            if (contenedor != null)
            {
                while (contenedor.Read())
                {
                    misobj.MensjIncript = (string)contenedor[0];

                }
            }
            return misobj;
        }
        public string Encriptar3DES(string cadena,string key)
        {
            try
            {
                TripleDESCryptoServiceProvider des;
                MD5CryptoServiceProvider hash;

                byte[] keyHash, buff;
                string encriptado;

                hash = new MD5CryptoServiceProvider();

                keyHash = hash.ComputeHash(ASCIIEncoding.ASCII.GetBytes(key));

                hash = null;

                des = new TripleDESCryptoServiceProvider();
                des.Key = keyHash;
                des.Mode = CipherMode.ECB;

                buff = ASCIIEncoding.ASCII.GetBytes(cadena);

                encriptado = Convert.ToBase64String(des.CreateEncryptor().TransformFinalBlock(buff, 0, buff.Length));

                return encriptado;

                


            }catch(Exception ex) { throw ex; }
        }
        public string Desencriptar3DES(string cadena,string key)
        {
            try
            {
                TripleDESCryptoServiceProvider des;
                MD5CryptoServiceProvider hash;

                byte[] keyhash, buff;
                string Desencriptado;

                hash = new MD5CryptoServiceProvider();
                keyhash = hash.ComputeHash(ASCIIEncoding.ASCII.GetBytes(key));

                des = new TripleDESCryptoServiceProvider();

                hash = null;
                des.Key = keyhash;
                des.Mode = CipherMode.ECB;
                buff = Convert.FromBase64String(cadena);
                Desencriptado = ASCIIEncoding.ASCII.GetString(des.CreateDecryptor().TransformFinalBlock(buff, 0, buff.Length));

                return Desencriptado;

            }catch(Exception ex){ throw ex; }
        }
        public EntidadMarca informacionMarca(ref string mensaje, ref string name)
        {
            string consulta = "select Descripcion from Marca where Nombre= '" + name + "'";
            SqlDataReader contenedor = null;
            SqlConnection cntemp = null;
            EntidadMarca misobj = new EntidadMarca();

            cntemp = operaciones.AbrirConexion(ref mensaje);
            contenedor = operaciones.ConsultaReader(consulta, cntemp, ref mensaje);

            if (contenedor != null)
            {
                while (contenedor.Read())
                {
                    misobj.Descripcion = (string)contenedor[0];

                }
            }
            return misobj;
        }

    }
}
