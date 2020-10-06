using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Contrato
{
    public class AccesoMetodosCRUDcontrato
    {
        //Operacion INSERT
        public int InsertContrato(int id, int id_vehiculo, int id_tipo_conductor)
        {
            SqlCommand _comando = MetodosCRUDcontrato.CrearComandoInsert_cont();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@id_vehiculo", id_vehiculo);
            _comando.Parameters.AddWithValue("@id_tipo_conductor", id_tipo_conductor);

            return MetodosCRUDcontrato.EjecutarComandoInsert_cont(_comando);
        }

        //Operacion UPDATE
        public int ActualizarContrato(int id, int id_vehiculo, int id_tipo_conductor)
        {
            SqlCommand _comando = MetodosCRUDcontrato.CrearComandoUpdate_cont();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@id_vehiculo", id_vehiculo);
            _comando.Parameters.AddWithValue("@id_tipo_conductor", id_tipo_conductor);

            return MetodosCRUDcontrato.EjecutarComandoUpdate_cont(_comando);
        }

        //Operacion DELETE
        public int EliminarContrato(int id)
        {
            SqlCommand _comando = MetodosCRUDcontrato.CrearComandoDelete_cont();

            _comando.Parameters.AddWithValue("@id", id);

            return MetodosCRUDcontrato.EjecutarComandoDelete_cont(_comando);
        }

        //Operacion SELECT
        public static DataTable ListarContrato()
        {
            SqlCommand _comando = MetodosCRUDcontrato.CrearComandoSelect_cont();

            _comando.CommandText = "select * from contrato";

            return MetodosCRUDcontrato.EjecutarComandoSelect_cont(_comando);
        }

        //Operacion SELECT para listar id vehiculos
        public static DataTable ObtenerListaVehiculos()
        {
            SqlCommand _comando = MetodosCRUDvehiculo.CrearComandoSelect_v();
            _comando.CommandText = "select * from vehiculo";
            return MetodosCRUDvehiculo.EjecutarComandoSelect_v(_comando);
        }

        //Operacion SELECT para listar id tipo vehiculos
        public static DataTable ObtenerListaTipoVehiculo()
        {
            SqlCommand _comando = MetodosCRUDtipoVehiculo.CrearComandoSelect_tv();
            _comando.CommandText = "select * from tipo_vehiculo";
            return MetodosCRUDtipoVehiculo.EjecutarComandoSelect_tv(_comando);
        }
    }
}
