using Negocio.Vehiculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class addVehiculos1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) 
            { 
            DropDownListIdTipoVehiculo_SelectedIndexChanged(sender, e);
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int id_vehiculo = Int32.Parse(txtId.Text);
            string marca_vehiculo = txtMarca.Text;
            string modelo_vehiculo = txtModelo.Text;
            string matricula_vehiculo = txtMatricula.Text;
            int anio_vehiculo = Int32.Parse(txtAnio.Text);
            int id_tipo_vehiculo = Int32.Parse(DropDownListIdTipoVehiculo.Text);

            LogicaNegocioVehiculo negocioInsertVehiculo = new LogicaNegocioVehiculo();

            int resultadoAddVehiculo = negocioInsertVehiculo.NegociarInsertVehiculo(id_vehiculo, marca_vehiculo, modelo_vehiculo, matricula_vehiculo, anio_vehiculo, id_tipo_vehiculo);

            if (resultadoAddVehiculo > 0)
                lblMensaje.Text = "Registro agregado con exito";
            else
                lblMensaje.Text = "No se pudo agregar el registro";

            negocioInsertVehiculo = null;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int id_vehiculo = Int32.Parse(txtId.Text);
            string marca_vehiculo = txtMarca.Text;
            string modelo_vehiculo = txtModelo.Text;
            string matricula_vehiculo = txtMatricula.Text;
            int anio_vehiculo = Int32.Parse(txtAnio.Text);
            int id_tipo_vehiculo = Int32.Parse(DropDownListIdTipoVehiculo.Text);

            LogicaNegocioVehiculo negocioUpdateVehiculo = new LogicaNegocioVehiculo();

            int resultadoUpdateVehiculo = negocioUpdateVehiculo.NegociarUpdateVehiculo(id_vehiculo, marca_vehiculo, modelo_vehiculo, matricula_vehiculo, anio_vehiculo, id_tipo_vehiculo);

            if (resultadoUpdateVehiculo > 0)
                lblMensaje.Text = "Registro modificado con exito";
            else
                lblMensaje.Text = "No se pudo modificar el registro";

            negocioUpdateVehiculo = null;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int id_vehiculo = Int32.Parse(txtId.Text);

            LogicaNegocioVehiculo negocioDeleteVehiculo = new LogicaNegocioVehiculo();

            int resultadoDeleteVehiculo = negocioDeleteVehiculo.NegociarDeleteVehiculo(id_vehiculo);

            if (resultadoDeleteVehiculo > 0)
                lblMensaje.Text = "Registro eliminado con exito";
            else
                lblMensaje.Text = "No se pudo eliminar el registro";

            negocioDeleteVehiculo = null;
        }

        protected void btnList_Click(object sender, EventArgs e)
        {
            GridView.DataSource = LogicaNegocioVehiculo.NegociarListVehiculo();
            GridView.DataBind();
        }

        protected void DropDownListIdTipoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownListIdTipoVehiculo.DataSource = LogicaNegocioVehiculo.NegociarListTipoVehiculo();

            DropDownListIdTipoVehiculo.DataValueField = "id";
            DropDownListIdTipoVehiculo.DataTextField = "nombre";
            
            DropDownListIdTipoVehiculo.DataBind();

        }
    }
}