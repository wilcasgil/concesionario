using Negocio.Conductor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class addConductor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) 
            { 
            DropDownListIdVehiculo_SelectedIndexChanged(sender, e);
            DropDownListIdTipoConductor_SelectedIndexChanged(sender, e);
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int id_conductor = Int32.Parse(txtId.Text);
            string nombre_conductor = txtNombre.Text;
            string tipo_licencia_conductor = txtTipo_Licencia.Text;
            int id_vehiculo = Int32.Parse(DropDownListIdVehiculo.Text);
            int id_tipo_conductor = Int32.Parse(DropDownListIdTipoConductor.Text);

            LogicaNegocioConductor negocioInsertConductor = new LogicaNegocioConductor();

            int resultadoAddConductor = negocioInsertConductor.NegociarInsertConductor(id_conductor, nombre_conductor, tipo_licencia_conductor, id_vehiculo, id_tipo_conductor);

            if (resultadoAddConductor > 0)
                lblMensaje.Text = "Registro agregado con exito";
            else
                lblMensaje.Text = "No se pudo agregar el registro";

            negocioInsertConductor = null;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int id_conductor = Int32.Parse(txtId.Text);
            string nombre_conductor = txtNombre.Text;
            string tipo_licencia_conductor = txtTipo_Licencia.Text;
            int id_vehiculo = Int32.Parse(DropDownListIdVehiculo.Text);
            int id_tipo_conductor = Int32.Parse(DropDownListIdTipoConductor.Text);

            LogicaNegocioConductor negocioUpdateConductor = new LogicaNegocioConductor();

            int resultadoUpdateConductor = negocioUpdateConductor.NegociarUpdateConductor(id_conductor, nombre_conductor, tipo_licencia_conductor, id_vehiculo, id_tipo_conductor);

            if (resultadoUpdateConductor > 0)
                lblMensaje.Text = "Registro modificado con exito";
            else
                lblMensaje.Text = "No se pudo modificar el registro";

            negocioUpdateConductor = null;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int id_conductor = Int32.Parse(txtId.Text);

            LogicaNegocioConductor negocioDeleteConductor = new LogicaNegocioConductor();

            int resultadoDeleteConductor = negocioDeleteConductor.NegociarDeleteConductor(id_conductor);

            if (resultadoDeleteConductor > 0)
                lblMensaje.Text = "Registro eliminado con exito";
            else
                lblMensaje.Text = "No se pudo eliminar el registro";

            negocioDeleteConductor = null;
        }

        protected void btnList_Click(object sender, EventArgs e)
        {
            GridView.DataSource = LogicaNegocioConductor.NegociarListConductor();
            GridView.DataBind();
        }

        protected void DropDownListIdVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownListIdVehiculo.DataSource = LogicaNegocioConductor.NegociarListVehiculo();

            DropDownListIdVehiculo.DataTextField = "id";
            DropDownListIdVehiculo.DataValueField = "id";

            DropDownListIdVehiculo.DataBind();
        }

        protected void DropDownListIdTipoConductor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownListIdTipoConductor.DataSource = LogicaNegocioConductor.NegociarListTipoConductor();

            DropDownListIdTipoConductor.DataTextField = "nombre";
            DropDownListIdTipoConductor.DataValueField = "id";

            DropDownListIdTipoConductor.DataBind();

        }
    }
}