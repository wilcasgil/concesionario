using Negocio.Ruta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class addRuta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
            DropDownListIdVehiculo_SelectedIndexChanged(sender, e);
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int id_ruta = Int32.Parse(txtId.Text);
            string estacion_ruta = txtEstacion.Text;
            int id_vehiculo = Int32.Parse(DropDownListIdVehiculo.Text);

            LogicaNegocioRuta negocioInsertRuta = new LogicaNegocioRuta();

            int resultadoAddRuta = negocioInsertRuta.NegociarInsertRuta(id_ruta, estacion_ruta, id_vehiculo);

            if (resultadoAddRuta > 0)
                lblMensaje.Text = "Registro agregado con exito";
            else
                lblMensaje.Text = "No se pudo agregar el registro";

            negocioInsertRuta = null;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int id_ruta = Int32.Parse(txtId.Text);
            string estacion_ruta = txtEstacion.Text;
            int id_vehiculo = Int32.Parse(DropDownListIdVehiculo.Text);

            LogicaNegocioRuta negocioUpdateRuta = new LogicaNegocioRuta();

            int resultadoUpdateRuta = negocioUpdateRuta.NegociarUpdateRuta(id_ruta, estacion_ruta, id_vehiculo);

            if (resultadoUpdateRuta > 0)
                lblMensaje.Text = "Registro modificado con exito";
            else
                lblMensaje.Text = "No se pudo modificar el registro";

            negocioUpdateRuta = null;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int id_ruta = Int32.Parse(txtId.Text);

            LogicaNegocioRuta negocioDeleteRuta = new LogicaNegocioRuta();

            int resultadoDeleteRuta = negocioDeleteRuta.NegociarDeleteRuta(id_ruta);

            if (resultadoDeleteRuta > 0)
                lblMensaje.Text = "Registro eliminado con exito";
            else
                lblMensaje.Text = "No se pudo eliminar el registro";

            negocioDeleteRuta = null;
        }

        protected void btnList_Click(object sender, EventArgs e)
        {
            GridView.DataSource = LogicaNegocioRuta.NegociarListRuta();
            GridView.DataBind();
        }

        protected void DropDownListIdVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownListIdVehiculo.DataSource = LogicaNegocioRuta.NegociarListVehiculo();

            DropDownListIdVehiculo.DataTextField = "id";
            DropDownListIdVehiculo.DataValueField = "id";

            DropDownListIdVehiculo.DataBind();
        }
    }
}