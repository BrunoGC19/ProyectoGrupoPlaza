using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassEntidadesGP;
using System.Configuration;
namespace LogicaNegociosGP
{
    public class LogicaFachada
    {
        LogicaNegocioClasi logicaNegocioClasi;
        LogicaNegocioComentario logicaNegocioComentario;
        LogicaNegocioGrupo logicaNegocioGrupo;
        LogicaNegocioMarca logicaNegocioMarca;
        LogicaNegocioProducto logicaNegocioProducto;
        LogicaNegocioPuesto logicaNegocioPuesto;
        LogicaNegocioSubGrupo logicaNegocioSubGrupo;
        LogicaNegocioUsuario logicaNegocioUsuario;
        

        public LogicaFachada()
        {
            logicaNegocioClasi=new LogicaNegocioClasi(ConfigurationManager.ConnectionStrings["cnlocal1"].ConnectionString);
            logicaNegocioComentario = new LogicaNegocioComentario(ConfigurationManager.ConnectionStrings["cnlocal1"].ConnectionString);
            logicaNegocioGrupo = new LogicaNegocioGrupo(ConfigurationManager.ConnectionStrings["cnlocal1"].ConnectionString);
            logicaNegocioMarca = new LogicaNegocioMarca(ConfigurationManager.ConnectionStrings["cnlocal1"].ConnectionString);
            logicaNegocioProducto = new LogicaNegocioProducto(ConfigurationManager.ConnectionStrings["cnlocal1"].ConnectionString);
            logicaNegocioPuesto = new LogicaNegocioPuesto(ConfigurationManager.ConnectionStrings["cnlocal1"].ConnectionString);
            logicaNegocioSubGrupo = new LogicaNegocioSubGrupo(ConfigurationManager.ConnectionStrings["cnlocal1"].ConnectionString);
            logicaNegocioUsuario = new LogicaNegocioUsuario(ConfigurationManager.ConnectionStrings["cnlocal1"].ConnectionString);
        }
        public Boolean InsertarComentario(EntidadComentario ob_nuevo,ref string mensaje)
        {
            return logicaNegocioComentario.InsertarComentario(ob_nuevo,ref mensaje);
        }
        public Boolean InsertarMarca(EntidadMarca ob_nuevo,ref string mensaje)
        {
            return logicaNegocioComentario.InsertarMarca(ob_nuevo, ref mensaje);
        }

        public string EncriptarMD5(ref string mensajeEncrip)
        {
            return logicaNegocioComentario.EncriptarMD5(ref mensajeEncrip);

        }

        public string DesencriptarMD5(ref string mensajeDesencrip)
        {
            return logicaNegocioComentario.DesencriptarMD5(ref mensajeDesencrip);
        }

        public EntidadComentario informacionMensaje(ref string mensaje, ref string name)
        {
            return logicaNegocioComentario.informacionMensaje(ref mensaje,ref name);
        }
        public string Encriptar3DES(string cadena, string key)
        {
            return logicaNegocioComentario.Encriptar3DES(cadena, key);
        }
        public string Desencriptar3DES(string cadena, string key)
        {
            return logicaNegocioComentario.Desencriptar3DES(cadena, key);
        }
        public EntidadMarca informacionMarca(ref string mensaje, ref string name)
        {
            return logicaNegocioComentario.informacionMarca(ref mensaje,ref name);
        }



        public List<EntidadGrupo> informacionClasificadorAlimentos(ref string mensaje)
        {
            return logicaNegocioGrupo.informacionClasificadorAlimentos(ref mensaje);
        }
        public List<EntidadGrupo> informacionClasificadorBebidas(ref string mensaje)
        {
            return logicaNegocioGrupo.informacionClasificadorBebidas(ref mensaje);
        }



        public List<EntidadSubGrupo> informacionSubGrupo(ref string mensaje, int subG)
        {
            return logicaNegocioSubGrupo.informacionSubGrupo(ref mensaje, subG);
        }


        public EntidadUsuario informacionUsuario(ref string mensaje, ref string usr, ref string cont)
        {
            return logicaNegocioUsuario.informacionUsuario(ref mensaje,ref usr,ref cont);
        }

        public EntidadUsuario informacionContraseña(ref string mensaje, ref string name)
        {
            return logicaNegocioUsuario.informacionContraseña(ref mensaje,ref name);
        }

        public Boolean InsertarUsuario(EntidadUsuario ob_nuevo,
            ref string mensaje)
        {
            return logicaNegocioUsuario.InsertarUsuario(ob_nuevo, ref mensaje);
        }

        public string EnviarCorreo(ref string correo, ref string asunto, ref string mensajeCorreo)
        {
            return logicaNegocioUsuario.EnviarCorreo(ref correo,ref asunto,ref mensajeCorreo);
        }


        public List<EntidadMarca> informacionMarcas(ref string mensaje)
        {
            return logicaNegocioMarca.informacionMarcas(ref mensaje);
        }

        public List<EntidadPuesto> informacionPuesto(ref string mensaje)
        {
            return logicaNegocioPuesto.informacionPuesto(ref mensaje);
        }
    }
}
