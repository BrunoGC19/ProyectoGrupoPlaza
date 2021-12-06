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
    public partial class HomeRestaurant : System.Web.UI.Page
    {
        LogicaFachada fachada = new LogicaFachada();
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("IndexRecetario.aspx");
        }

        protected void btnEnviarMensaje_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtCorreo.Text) || string.IsNullOrEmpty(txtMensaje.Text))
            {
                MessageBox.Show("Ingresa todos los datos que se piden");
            }
            else
            {
                string usuario = txtUsuario.Text;
                string correo = txtCorreo.Text;
                string mensaje = txtMensaje.Text;

                string mensajeEncrip = fachada.EncriptarMD5(ref mensaje);

                EntidadComentario nuevoC
                    = new EntidadComentario()
                    {
                        NombreUsr = usuario,
                        Correo = correo,
                        Mensaje = mensaje,
                        MensjIncript = mensajeEncrip,
                    };
                string cad = "";
                fachada.InsertarComentario(nuevoC, ref cad);
                txtMensaje.Text = cad;
            }
        }
    }
}