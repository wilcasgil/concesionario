using Negocio.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class addContrato : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
            DropDownListIdVehiculo_SelectedIndexChanged(sender, e);
            DropDownListIdTipoVehiculo_SelectedIndexChanged(sender, e);
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int id_contrato = Int32.Parse(txtId.Text);
            int id_vehiculo = Int32.Parse(DropDownListIdVehiculo.Text);
            int id_tipo_conductor = Int32.Parse(DropDownListIdTipoVehiculo.Text);

            LogicaNegocioContrato negocioInsertContrato = new LogicaNegocioContrato();

            int resultadoAddContrato = negocioInsertContrato.NegociarInsertContrato(id_contrato, id_vehiculo, id_tipo_conductor);

            if (resultadoAddContrato > 0)
                lblMensaje.Text = "Registro agregado con exito";
            else
                lblMensaje.Text = "No se pudo agregar el registro";

            negocioInsertContrato = null;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int id_contrato = Int32.Parse(txtId.Text);
            int id_vehiculo = Int32.Parse(DropDownListIdVehiculo.Text);
            int id_tipo_conductor = Int32.Parse(DropDownListIdTipoVehiculo.Text);

            LogicaNegocioContrato negocioUpdateContrato = new LogicaNegocioContrato();

            int resultadoUpdateContrato = negocioUpdateContrato.NegociarUpdateContrato(id_contrato, id_vehiculo, id_tipo_conductor);

            if (resultadoUpdateContrato > 0)
                lblMensaje.Text = "Registro agregado con exito";
            else
                lblMensaje.Text = "No se pudo agregar el registro";

            negocioUpdateContrato = null;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int id_contrato = Int32.Parse(txtId.Text);

            LogicaNegocioContrato negocioDeleteContrato = new LogicaNegocioContrato();

            int resultadoDeleteContrato = negocioDeleteContrato.NegociarDeleteContrato(id_contrato);

            if (resultadoDeleteContrato > 0)
                lblMensaje.Text = "Registro agregado con exito";
            else
                lblMensaje.Text = "No se pudo agregar el registro";

            negocioDeleteContrato = null;
        }

        protected void btnList_Click(object sender, EventArgs e)
        {
            GridView.DataSource = LogicaNegocioContrato.NegociarListContrato();
            GridView.DataBind();
        }

        protected void DropDownListIdVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownListIdVehiculo.DataSource = LogicaNegocioContrato.NegociarListVehiculo();

            DropDownListIdVehiculo.DataTextField = "id";
            DropDownListIdVehiculo.DataValueField = "id";

            DropDownListIdVehiculo.DataBind();
        }

        protected void DropDownListIdTipoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownListIdTipoVehiculo.DataSource = LogicaNegocioContrato.NegociarListTipoVehiculo();

            DropDownListIdTipoVehiculo.DataTextField = "nombre";
            DropDownListIdTipoVehiculo.DataValueField = "id";

            DropDownListIdTipoVehiculo.DataBind();
        }
    }
}