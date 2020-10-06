using Modelo.Vehiculo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Vehiculo
{
    public class LogicaNegocioVehiculo
    {
        //Negociar INSERT
        public int NegociarInsertVehiculo(int id, string marca, string modelo, string matricula, int anio, int id_tipo_vehiculo)
        {
            AccesoMetodosCRUDvehiculo acceso = new AccesoMetodosCRUDvehiculo();
            return acceso.InsertVehiculo(id, marca, modelo, matricula, anio, id_tipo_vehiculo);
        }

        //Negociar UPDATE
        public int NegociarUpdateVehiculo(int id, string marca, string modelo, string matricula, int anio, int id_tipo_vehiculo)
        {
            AccesoMetodosCRUDvehiculo acceso = new AccesoMetodosCRUDvehiculo();
            return acceso.ActualizarVehiculo(id, marca, modelo, matricula, anio, id_tipo_vehiculo);
        }

        //Negociar DELETE
        public int NegociarDeleteVehiculo(int id)
        {
            AccesoMetodosCRUDvehiculo acceso = new AccesoMetodosCRUDvehiculo();
            return acceso.EliminarVehiculo(id);
        }

        //Negociar LIST
        public static DataTable NegociarListVehiculo()
        {
            return AccesoMetodosCRUDvehiculo.ListarVehiculo();
        }

        //Negociar LIST tipo vehiculo
        public static DataTable NegociarListTipoVehiculo()
        {
            return AccesoMetodosCRUDvehiculo.ObtenerListaTipoVehiculo();
        }
    }
}
