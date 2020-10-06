using Negocio.TipoConductor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class addTipoConductor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int id_conductor = Int32.Parse(txtId.Text);
            string nombre_conductor = txtNomTipo.Text;

            LogicaNegocioTipoConductor negocioAddTipoConductor = new LogicaNegocioTipoConductor();

            int resultadoAddTipoConductor = negocioAddTipoConductor.NegociarInsertTipoConductor(id_conductor, nombre_conductor);

            if (resultadoAddTipoConductor > 0)
                lblMensaje.Text = "Registro agregado con exito";
            else
                lblMensaje.Text = "No se pudo agregar el registro";

            negocioAddTipoConductor = null;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int id_conductor = Int32.Parse(txtId.Text);
            string nombre_conductor = txtNomTipo.Text;

            LogicaNegocioTipoConductor negocioActualizarTipoConductor = new LogicaNegocioTipoConductor();

            int resultadoActualizarTipoConductor = negocioActualizarTipoConductor.NegociarUpdateTipoConductor(id_conductor, nombre_conductor);

            if (resultadoActualizarTipoConductor > 0)
                lblMensaje.Text = "Registro agregado con exito";
            else
                lblMensaje.Text = "No se pudo agregar el registro";

            negocioActualizarTipoConductor = null;
        }

        protected void btnList_Click(object sender, EventArgs e)
        {
            GridView.DataSource = LogicaNegocioTipoConductor.NegociarListadoDatosTipoConductor();
            GridView.DataBind();
            txtId.Text = txtNomTipo.Text = "";
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int id_conductor = Int32.Parse(txtId.Text);

            LogicaNegocioTipoConductor negocioEliminarTipoConductor = new LogicaNegocioTipoConductor();

            int resultadoEliminarTipoConductor = negocioEliminarTipoConductor.NegociarDeleteTipoConductor(id_conductor);

            if (resultadoEliminarTipoConductor > 0)
                lblMensaje.Text = "Registro eliminado con exito";
            else
                lblMensaje.Text = "No se pudo eliminar el registro";

            negocioEliminarTipoConductor = null;
        }
    }
}