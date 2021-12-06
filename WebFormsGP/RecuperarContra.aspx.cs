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
        LogicaFachada logicaFachada = new LogicaFachada();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsr.Text))
            {
                MessageBox.Show("Para buscar ingresa tu usuario");
            }
            else
            {
                string nombre = txtUsr.Text;
                string mns = "";
                EntidadUsuario user = new EntidadUsuario();
                user = logicaFachada.informacionContraseña(ref mns, ref nombre);
                txtPaswr.Text = user.ContraseñaIncrip;
            }    

        }

        protected void btnDescomprimir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClave.Text) || string.IsNullOrEmpty(txtCorreo.Text))
            {
                MessageBox.Show("Verifica que esten todos los campos llenos");
            }
            else
            {
                int key = Convert.ToInt32(txtClave.Text);
                string mensaje = txtPaswr.Text;
                string correo = txtCorreo.Text;
                string asunto = "RECUPERACION DE CONTRASEÑA";
                string pass = DescriptarMensaje(mensaje, key);
                string msg = logicaFachada.EnviarCorreo(ref correo, ref asunto, ref pass);

                ScriptManager.RegisterClientScriptBlock(this, typeof(string), "MsgAlert", "alert('" + msg + "');window.location = 'RecuperarContra.aspx';", true);
            }
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