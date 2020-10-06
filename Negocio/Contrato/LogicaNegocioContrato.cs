using Modelo.Contrato;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Contrato
{
    public class LogicaNegocioContrato
    {
        //Negociar INSERT
        public int NegociarInsertContrato(int id, int id_vehiculo, int id_tipo_conductor)
        {
            AccesoMetodosCRUDcontrato acceso = new AccesoMetodosCRUDcontrato();
            return acceso.InsertContrato(id,  id_vehiculo, id_tipo_conductor);
        }

        //Negociar UPDATE
        public int NegociarUpdateContrato(int id, int id_vehiculo, int id_tipo_conductor)
        {
            AccesoMetodosCRUDcontrato acceso = new AccesoMetodosCRUDcontrato();
            return acceso.ActualizarContrato(id, id_vehiculo, id_tipo_conductor);
        }

        //Negociar DELETE
        public int NegociarDeleteContrato(int id)
        {
            AccesoMetodosCRUDcontrato acceso = new AccesoMetodosCRUDcontrato();
            return acceso.EliminarContrato(id);
        }

        //Negociar LIST
        public static DataTable NegociarListContrato()
        {
            return AccesoMetodosCRUDcontrato.ListarContrato();
        }

        //Negociar LIST id vehiculo
        public static DataTable NegociarListVehiculo()
        {
            return AccesoMetodosCRUDcontrato.ObtenerListaVehiculos();
        }

        //Negociar LIST id tipo vehiculo
        public static DataTable NegociarListTipoVehiculo()
        {
            return AccesoMetodosCRUDcontrato.ObtenerListaTipoVehiculo();
        }
    }
}
