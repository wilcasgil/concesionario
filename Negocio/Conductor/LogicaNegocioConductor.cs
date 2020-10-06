using Modelo.Conductor;
using Modelo.Vehiculo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Conductor
{
    public class LogicaNegocioConductor
    {
        //Negociar INSERT
        public int NegociarInsertConductor(int id, string nombre, string tipo_licencia, int id_vehiculo, int id_tipo_conductor)
        {
            AccesoMetodosCRUDconductor acceso = new AccesoMetodosCRUDconductor();
            return acceso.InsertConductor(id, nombre, tipo_licencia, id_vehiculo, id_tipo_conductor);
        }

        //Negociar UPDATE
        public int NegociarUpdateConductor(int id, string nombre, string tipo_licencia, int id_vehiculo, int id_tipo_conductor)
        {
            AccesoMetodosCRUDconductor acceso = new AccesoMetodosCRUDconductor();
            return acceso.ActualizarConductor(id, nombre, tipo_licencia, id_vehiculo, id_tipo_conductor);
        }

        //Negociar DELETE
        public int NegociarDeleteConductor(int id)
        {
            AccesoMetodosCRUDconductor acceso = new AccesoMetodosCRUDconductor();
            return acceso.EliminarConductor(id);
        }

        //Negociar LIST
        public static DataTable NegociarListConductor()
        {
            return AccesoMetodosCRUDconductor.ListarConductor();
        }

        //Negociar LIST id vehiculo
        public static DataTable NegociarListVehiculo()
        {
            return AccesoMetodosCRUDconductor.ObtenerListaVehiculos();
        }

        //Negociar LIST id tipo vehiculo
        public static DataTable NegociarListTipoConductor()
        {
            return AccesoMetodosCRUDconductor.ObtenerListaTipoConductor();
        }

    }
}
