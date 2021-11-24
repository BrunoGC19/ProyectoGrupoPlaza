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
        LogicaNegocioClasi logClasificador = null;
        LogicaNegocioGrupo LogGrupo = null;
        LogicaNegocioSubGrupo LogSubG = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                logClasificador = new LogicaNegocioClasi(ConfigurationManager.ConnectionStrings["cnlocal1"].ConnectionString);
                LogGrupo = new LogicaNegocioGrupo(ConfigurationManager.ConnectionStrings["cnlocal1"].ConnectionString);
                LogSubG = new LogicaNegocioSubGrupo(ConfigurationManager.ConnectionStrings["cnlocal1"].ConnectionString);


                Session["logCla"] = logClasificador;
                Session["logGrupo"] = LogGrupo;
                Session["logSubG"] = LogSubG;
            }
            else
            {
                logClasificador = (LogicaNegocioClasi)Session["logCla"];
                LogGrupo = (LogicaNegocioGrupo)Session["logGrupo"];
                LogSubG = (LogicaNegocioSubGrupo)Session["logSubG"];
            }
            
            //TextBox1.Text = h;
        }

        protected void btnAlimentos_Click(object sender, EventArgs e)
        {
            List<EntidadGrupo> lista = null;
            string h = "";
            lista = LogGrupo.informacionClasificadorAlimentos(ref h);
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
            lista = LogGrupo.informacionClasificadorBebidas(ref h);
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
            lista = LogSubG.informacionSubGrupo(ref h,Convert.ToInt16( ListBox1.SelectedItem.Value));
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