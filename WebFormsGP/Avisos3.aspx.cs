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
    public partial class Avisos3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnContinuar_Click(object sender, EventArgs e)
        {
            if (CheckBox1.Checked == true)
            {
                Response.Redirect("Recetario.aspx");
            }
            else
            {
                MessageBox.Show("Acepte el acuerdo de confidencialidad");
            }
        }
    }
}