using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class addVehiculos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int id_vehiculo = Int32.Parse(txtId.Text);
            string nombre_vehiculo = txtNomTipo.Text;

            LogicaNegocioTipoVehiculo negocioAddTipoVehiculo = new LogicaNegocioTipoVehiculo();

            int resultadoAddTipoVehiculo = negocioAddTipoVehiculo.NegociarInsertTipoVehiculo(id_vehiculo, nombre_vehiculo);

            if (resultadoAddTipoVehiculo > 0)
                lblMensaje.Text = "Registro agregado con exito";
            else
                lblMensaje.Text = "No se pudo agregar el registro";

            negocioAddTipoVehiculo = null;
        }

        protected void btnList_Click(object sender, EventArgs e)
        {
            GridView.DataSource = LogicaNegocioTipoVehiculo.NegociarListadoDatosTipoVehiculo();
            
            GridView.DataBind();
            
            txtId.Text = txtNomTipo.Text = "";
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int id_vehiculo = Int32.Parse(txtId.Text);
            string nombre_vehiculo = txtNomTipo.Text;

            LogicaNegocioTipoVehiculo negocioActualizarTipoVehiculo = new LogicaNegocioTipoVehiculo();

            int resultadoActualizarTipoVehiculo = negocioActualizarTipoVehiculo.NegociarUpdateTipoVehiculo(id_vehiculo, nombre_vehiculo);

            if (resultadoActualizarTipoVehiculo > 0)
                lblMensaje.Text = "Registro actualizado con exito";
            else
                lblMensaje.Text = "No se pudo actualizar el registro";

            negocioActualizarTipoVehiculo = null;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int id_vehiculo = Int32.Parse(txtId.Text);

            LogicaNegocioTipoVehiculo negocioEliminarTipoVehiculo = new LogicaNegocioTipoVehiculo();

            int resultadoEliminarTipoVehiculo = negocioEliminarTipoVehiculo.NegociarDeleteTipoVehiculo(id_vehiculo);

            if (resultadoEliminarTipoVehiculo > 0)
                lblMensaje.Text = "Registro eliminado con exito";
            else
                lblMensaje.Text = "No se pudo eliminar el registro";

            negocioEliminarTipoVehiculo = null;
        }
    }
}