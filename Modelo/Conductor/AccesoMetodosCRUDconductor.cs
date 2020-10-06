using Modelo.TipoConductor;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Conductor
{
    public class AccesoMetodosCRUDconductor
    {
        //Operacion INSERT
        public int InsertConductor(int id, string nombre, string tipo_licencia, int id_vehiculo, int id_tipo_conductor)
        {
            SqlCommand _comando = MetodosCRUDconductor.CrearComandoInsert_c();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@nombre", nombre);
            _comando.Parameters.AddWithValue("@tipo_licencia", tipo_licencia);
            _comando.Parameters.AddWithValue("@id_vehiculo", id_vehiculo);
            _comando.Parameters.AddWithValue("@id_tipo_conductor", id_tipo_conductor);

            return MetodosCRUDconductor.EjecutarComandoInsert_c(_comando);
        }

        //Operacion UPDATE
        public int ActualizarConductor(int id, string nombre, string tipo_licencia, int id_vehiculo, int id_tipo_conductor)
        {
            SqlCommand _comando = MetodosCRUDconductor.CrearComandoUpdate_c();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@nombre", nombre);
            _comando.Parameters.AddWithValue("@tipo_licencia", tipo_licencia);
            _comando.Parameters.AddWithValue("@id_vehiculo", id_vehiculo);
            _comando.Parameters.AddWithValue("@id_tipo_conductor", id_tipo_conductor);

            return MetodosCRUDconductor.EjecutarComandoUpdate_c(_comando);
        }

        //Operacion DELETE
        public int EliminarConductor(int id)
        {
            SqlCommand _comando = MetodosCRUDconductor.CrearComandoDelete_c();

            _comando.Parameters.AddWithValue("@id", id);

            return MetodosCRUDconductor.EjecutarComandoDelete_c(_comando);
        }

        //Operacion SELECT
        public static DataTable ListarConductor()
        {
            SqlCommand _comando = MetodosCRUDconductor.CrearComandoSelect_c();

            _comando.CommandText = "select * from conductor";

            return MetodosCRUDconductor.EjecutarComandoSelect_c(_comando);
        }

        //Operacion SELECT para listar id vehiculos
        public static DataTable ObtenerListaVehiculos()
        {
            SqlCommand _comando = MetodosCRUDvehiculo.CrearComandoSelect_v();
            _comando.CommandText = "select * from vehiculo";
            return MetodosCRUDvehiculo.EjecutarComandoSelect_v(_comando);
        }

        //Operacion SELECT para listar id tipo vehiculos
        public static DataTable ObtenerListaTipoConductor()
        {
            SqlCommand _comando = MetodosCRUDtipoConductor.CrearComandoSelect_tc();
            _comando.CommandText = "select * from tipo_conductor";
            return MetodosCRUDtipoConductor.EjecutarComandoSelect_tc(_comando);
        }
    }
}
