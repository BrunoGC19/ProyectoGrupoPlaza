using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

using ClassEntidadesGP;
using LogicaNegociosGP;
using System.Configuration;

namespace WebFormsGP
{
    public partial class RecuperarContra : System.Web.UI.Page
    {
        LogicaNegocioUsuario logUsu = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                logUsu = new LogicaNegocioUsuario(ConfigurationManager.ConnectionStrings["cnlocal1"].ConnectionString);

                Session["logUsur"] = logUsu;
            }
            else
            {
           
                logUsu = (LogicaNegocioUsuario)Session["logUsur"];
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtUsr.Text;
            string mns = "";
            EntidadUsuario user = new EntidadUsuario();
            user = logUsu.informacionContraseña(ref mns,ref nombre);
            txtPaswr.Text = user.ContraseñaIncrip;

        }

        protected void btnDescomprimir_Click(object sender, EventArgs e)
        {
            int key =Convert.ToInt32(txtClave.Text);
            string mensaje = txtPaswr.Text;
            string correo = txtCorreo.Text;
            string asunto = "RECUPERACION DE CONTRASEÑA";
            string pass = DescriptarMensaje(mensaje, key);
            string msg = logUsu.EnviarCorreo(ref correo, ref asunto, ref pass);

            ScriptManager.RegisterClientScriptBlock(this, typeof(string), "MsgAlert", "alert('" + msg + "');window.location = 'RecuperarContra.aspx';", true);
        }
        public string DescriptarMensaje(string Mensaje, int key)
        {
            string letras = "abcdefghijklmnñopkrstuvwxyz ABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
            string code = "";
            string resp = "";

            for (int i = 0; i < Mensaje.Length; i++)
            {
                string letra = Mensaje.Substring(i, 1);
                int posicion = letras.IndexOf(letra);
                int encript = (posicion - key) % 27;

                if (encript < 0)
                {
                    encript = encript + 27;
                }

                if (Mensaje[i] == '/')
                {
                    code += ' ';
                }
                else
                {
                    code = code + letras.Substring(encript, 1);
                }
                resp = code;
            }
            resp = code;
            return code;
        }
    }
}