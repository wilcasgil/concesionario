using Modelo.Ruta;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Ruta
{
    public class LogicaNegocioRuta
    {
        //Negociar INSERT
        public int NegociarInsertRuta(int id, string estacion, int id_vehiculo)
        {
            AccesoMetodosCRUDruta acceso = new AccesoMetodosCRUDruta();
            return acceso.InsertRuta(id, estacion, id_vehiculo);
        }

        //Negociar UPDATE
        public int NegociarUpdateRuta(int id, string estacion, int id_vehiculo)
        {
            AccesoMetodosCRUDruta acceso = new AccesoMetodosCRUDruta();
            return acceso.ActualizarRuta(id, estacion, id_vehiculo);
        }

        //Negociar DELETE
        public int NegociarDeleteRuta(int id)
        {
            AccesoMetodosCRUDruta acceso = new AccesoMetodosCRUDruta();
            return acceso.EliminarRuta(id);
        }

        //Negociar LIST
        public static DataTable NegociarListRuta()
        {
            return AccesoMetodosCRUDruta.ListarRuta();
        }

        //Negociar LIST id vehiculo
        public static DataTable NegociarListVehiculo()
        {
            return AccesoMetodosCRUDruta.ObtenerListaVehiculos();
        }
    }
}
