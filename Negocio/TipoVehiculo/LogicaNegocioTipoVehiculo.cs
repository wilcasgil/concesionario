using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class LogicaNegocioTipoVehiculo
    {
        //Negociar INSERT
        public int NegociarInsertTipoVehiculo(int id, string nombre)
        {
            AccesoMetodosCRUDtipoVehiculo acceso = new AccesoMetodosCRUDtipoVehiculo();

            return acceso.InsertTipoVehiculo(id, nombre);
        }

        //Negociar SELECT
        public static DataTable NegociarListadoDatosTipoVehiculo()
        {
            return AccesoMetodosCRUDtipoVehiculo.ListadoTipoVehiculo();
        }

        //Negociar UPDATE
        public int NegociarUpdateTipoVehiculo(int id, string nombre)
        {
            AccesoMetodosCRUDtipoVehiculo acceso = new AccesoMetodosCRUDtipoVehiculo();

            return acceso.UpdateTipoVehiculo(id, nombre);
        }

        //Negociar DELETE
        public int NegociarDeleteTipoVehiculo(int id)
        {
            AccesoMetodosCRUDtipoVehiculo acceso = new AccesoMetodosCRUDtipoVehiculo();

            return acceso.DeleteTipoVehiculo(id);
        }
    }
}
