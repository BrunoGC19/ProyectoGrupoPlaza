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
        LogicaNegocioUsuario logUsuario = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                logUsuario = new LogicaNegocioUsuario(ConfigurationManager.ConnectionStrings["cnlocal1"].ConnectionString);

                Session["logUsr"] = logUsuario;
            }
            else
            {
                logUsuario = (LogicaNegocioUsuario)Session["logUsr"];
            }
        }

        protected void btnIniciar_Click(object sender, EventArgs e)
        {
            List<EntidadUsuario> lista = null;
            string usuario = txtUsr.Text;
            string pass = txtPaswr.Text;
            string h = "";
            lista = logUsuario.informacionUsuario(ref h, ref usuario, ref pass);

            for(int q = 0; q < lista.Count; q++)
            {
                if (lista[q].NombreUsr == usuario && lista[q].Contraseña == pass)
                {
                    MessageBox.Show("Bienvenido " + usuario);
                    Response.Redirect("Avisos.aspx");
                }
                else
                {
                    MessageBox.Show("Verifique que sus datos ingresados sean correctos");
                }
            }
        }
    }
}