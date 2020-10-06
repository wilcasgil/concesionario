using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Vehiculo
{
    public class AccesoMetodosCRUDvehiculo
    {
        //Operacion INSERT
        public int InsertVehiculo(int id, string marca, string modelo, string matricula, int anio, int id_tipo_vehiculo)
        {
            SqlCommand _comando = MetodosCRUDvehiculo.CrearComandoInsert_v();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@marca", marca);
            _comando.Parameters.AddWithValue("@modelo", modelo);
            _comando.Parameters.AddWithValue("@matricula", matricula);
            _comando.Parameters.AddWithValue("@anio", anio);
            _comando.Parameters.AddWithValue("@id_tipo_vehiculo", id_tipo_vehiculo);

            return MetodosCRUDvehiculo.EjecutarComandoInsert_v(_comando);
        }

        //Operacion UPDATE
        public int ActualizarVehiculo(int id, string marca, string modelo, string matricula, int anio, int id_tipo_vehiculo)
        {
            SqlCommand _comando = MetodosCRUDvehiculo.CrearComandoUpdate_v();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@marca", marca);
            _comando.Parameters.AddWithValue("@modelo", modelo);
            _comando.Parameters.AddWithValue("@matricula", matricula);
            _comando.Parameters.AddWithValue("@anio", anio);
            _comando.Parameters.AddWithValue("@id_tipo_vehiculo", id_tipo_vehiculo);

            return MetodosCRUDvehiculo.EjecutarComandoUpdate_v(_comando);
        }

        //Operacion DELETE
        public int EliminarVehiculo(int id)
        {
            SqlCommand _comando = MetodosCRUDvehiculo.CrearComandoDelete_v();

            _comando.Parameters.AddWithValue("@id", id);

            return MetodosCRUDvehiculo.EjecutarComandoDelete_v(_comando);
        }

        //Operacion SELECT
        public static DataTable ListarVehiculo()
        {
            SqlCommand _comando = MetodosCRUDvehiculo.CrearComandoSelect_v();

            _comando.CommandText = "select * from vehiculo";

            return MetodosCRUDvehiculo.EjecutarComandoSelect_v(_comando);
        }

        //Operacion SELECT para listar tipos de personas
        public static DataTable ObtenerListaTipoVehiculo()
        {
            SqlCommand _comando = MetodosCRUDtipoVehiculo.CrearComandoSelect_tv();
            _comando.CommandText = "select * from tipo_vehiculo";
            return MetodosCRUDtipoVehiculo.EjecutarComandoSelect_tv(_comando);
        }
    }
}
