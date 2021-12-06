using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ClassEntidadesGP;
using LogicaNegociosGP;
using System.Configuration;

namespace WebFormsGP
{
    public partial class Recetario : System.Web.UI.Page
    {
        LogicaFachada fachada = new LogicaFachada();
        
        //LogicaNegocioGrupo LogGrupo = null;
      

        protected void Page_Load(object sender, EventArgs e)
        {           
            
            //TextBox1.Text = h;
        }

        protected void btnAlimentos_Click(object sender, EventArgs e)
        {
            List<EntidadGrupo> lista = null;
            string h = "";
            lista = fachada.informacionClasificadorAlimentos(ref h);
            ListBox1.Items.Clear();

            for (int q = 0; q < lista.Count; q++)
            {
                ListBox1.Items.Add(
                    new ListItem(lista[q].NombreGrup, lista[q].idGrupo.ToString()));
            }
        }

        protected void btnBebidas_Click(object sender, EventArgs e)
        {
            List<EntidadGrupo> lista = null;
            string h = "";
            lista = fachada.informacionClasificadorBebidas(ref h);
            ListBox1.Items.Clear();

            for (int q = 0; q < lista.Count; q++)
            {
                ListBox1.Items.Add(
                    new ListItem(lista[q].NombreGrup,lista[q].idGrupo.ToString()));
            }
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<EntidadSubGrupo> lista = null;
            string h = "";
            lista = fachada.informacionSubGrupo(ref h,Convert.ToInt16( ListBox1.SelectedItem.Value));
            ListBox2.Items.Clear();

            for (int q = 0; q < lista.Count; q++)
            {
                ListBox2.Items.Add(
                    new ListItem(lista[q].NombreSubGrup));
            }
        }

        protected void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nomProd = ListBox2.Items[0].Text;
            if (ListBox2.Items[0].Selected)
            {
                Response.Redirect("Recetario2.aspx?idSubGrup=" + nomProd);
            }
        }
    }
}