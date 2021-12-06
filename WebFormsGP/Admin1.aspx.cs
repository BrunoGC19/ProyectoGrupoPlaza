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
    public partial class Admin1 : System.Web.UI.Page
    {
        LogicaFachada fachada = new LogicaFachada();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnRecuperar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsr.Text))
            {
                MessageBox.Show("Para buscar ingresa tu usuario");
            }
            else
            {
                string nombre = txtUsr.Text;
                string mensaje = "";
                EntidadComentario comentario = new EntidadComentario();
                comentario = fachada.informacionMensaje(ref mensaje, ref nombre);
                txtMensaje.Text = comentario.MensjIncript;
            }
        }

        protected void btnDescomprimir_Click(object sender, EventArgs e)
        {
            string mensaje = txtMensaje.Text;
            txtMensjDesen.Text = fachada.DesencriptarMD5(ref mensaje);
            string mensaje2 = "Desencriptacion Correcta";
            MessageBox.Show(mensaje2);
        }

        protected void btnInsertarMarca_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNombre.Text)) throw new Exception("Ingrese texto a incriptar");                

                string nombreMarca = txtNombre.Text;
                string mensajeEncrip = fachada.Encriptar3DES(nombreMarca,txtDescripcion.Text);
                string key = txtDescripcion.Text;

       

                EntidadMarca nuevaM
                    = new EntidadMarca()
                    {
                        Nombre = nombreMarca,
                        Descripcion = mensajeEncrip
                    };
                string cad = "";
                fachada.InsertarMarca(nuevaM, ref cad);
                txtMensaje.Text = cad;


            }
            catch(Exception ex)
            {
                Response.Write("<Script Language='JavaScript'>parent.alert('" + ex.Message + "')</Script>");
            }
        }

        protected void btnBuscarMarca_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMarca.Text))
            {
                MessageBox.Show("Para buscar ingresa la marca");
            }
            else
            {
                string nombre = txtMarca.Text;
                string mns = "";
                EntidadMarca user = new EntidadMarca();
                user = fachada.informacionMarca(ref mns, ref nombre);
                txtDescripcionMarca.Text = user.Descripcion;
            }
        }

        protected void btnDescomDescrip_Click(object sender, EventArgs e)
        {
            txtDescomprimirText.Text = fachada.Desencriptar3DES(txtDescripcionMarca.Text, TextBox1.Text);
        }
    }
}