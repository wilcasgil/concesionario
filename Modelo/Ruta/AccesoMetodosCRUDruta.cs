using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Ruta
{
    public class AccesoMetodosCRUDruta
    {
        //Operacion INSERT
        public int InsertRuta(int id, string estacion, int id_vehiculo)
        {
            SqlCommand _comando = MetodosCRUDruta.CrearComandoInsert_r();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@estacion", estacion);
            _comando.Parameters.AddWithValue("@id_vehiculo", id_vehiculo);

            return MetodosCRUDruta.EjecutarComandoInsert_r(_comando);
        }

        //Operacion UPDATE
        public int ActualizarRuta(int id, string estacion, int id_vehiculo)
        {
            SqlCommand _comando = MetodosCRUDruta.CrearComandoUpdate_r();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@estacion", estacion);
            _comando.Parameters.AddWithValue("@id_vehiculo", id_vehiculo);

            return MetodosCRUDruta.EjecutarComandoUpdate_r(_comando);
        }

        //Operacion DELETE
        public int EliminarRuta(int id)
        {
            SqlCommand _comando = MetodosCRUDruta.CrearComandoDelete_r();

            _comando.Parameters.AddWithValue("@id", id);

            return MetodosCRUDruta.EjecutarComandoDelete_r(_comando);
        }

        //Operacion SELECT
        public static DataTable ListarRuta()
        {
            SqlCommand _comando = MetodosCRUDruta.CrearComandoSelect_r();

            _comando.CommandText = "select * from ruta";

            return MetodosCRUDruta.EjecutarComandoSelect_r(_comando);
        }

        //Operacion SELECT para listar id vehiculos
        public static DataTable ObtenerListaVehiculos()
        {
            SqlCommand _comando = MetodosCRUDvehiculo.CrearComandoSelect_v();
            _comando.CommandText = "select * from vehiculo";
            return MetodosCRUDvehiculo.EjecutarComandoSelect_v(_comando);
        }

       
    }
}
