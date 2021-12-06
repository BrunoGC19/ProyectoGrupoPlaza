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
    public partial class IndexRecetario : System.Web.UI.Page
    {
        LogicaFachada logicaFachada = new LogicaFachada();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnIniciar_Click(object sender, EventArgs e)
        {
            EntidadUsuario user = new EntidadUsuario();
            string usuario = txtUsr.Text;
            string pass = txtPaswr.Text;
            string h = "";
            user = logicaFachada.informacionUsuario(ref h, ref usuario, ref pass);

            if (user.idPuesto == 1 || user.idPuesto == 2)
            {
                MessageBox.Show("Bienvenido Admin " + usuario);
                Response.Redirect("Admin1.aspx");
            }
            else
            {
                MessageBox.Show("Bienvenido " + usuario);
                Response.Redirect("Avisos.aspx");
            }
        }
    }
}