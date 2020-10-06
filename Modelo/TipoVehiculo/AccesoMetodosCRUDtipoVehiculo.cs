using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class AccesoMetodosCRUDtipoVehiculo
    {
        //Operacion INSERT
        public int InsertTipoVehiculo(int id, string nombre)
        {
            SqlCommand _comando = MetodosCRUDtipoVehiculo.CrearComandoProcAlmacInsert_tv();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@nombre", nombre);

            return MetodosCRUDtipoVehiculo.EjecutarComandoProcAlmacInsert_tv(_comando);
        }

        //Operacion SELECT
        public static DataTable ListadoTipoVehiculo()
        {
            SqlCommand _comando = MetodosCRUDtipoVehiculo.CrearComandoSelect_tv();

            _comando.CommandText = "select * from tipo_vehiculo";

            return MetodosCRUDtipoVehiculo.EjecutarComandoSelect_tv(_comando);
        }

        //Operacion UPDATE
        public int UpdateTipoVehiculo(int id, string nombre)
        {
            SqlCommand _comando = MetodosCRUDtipoVehiculo.CrearComandoProcAlmacUpdate_tv();

            _comando.Parameters.AddWithValue("id", id);
            _comando.Parameters.AddWithValue("@nombre", nombre);

            return MetodosCRUDtipoVehiculo.EjecutarComandoProcAlmacUpdate_tv(_comando);
        }

        //Operacion DELETE
        public int DeleteTipoVehiculo(int id)
        {
            SqlCommand _comando = MetodosCRUDtipoVehiculo.CrearComandoProcAlmacDelete_tv();

            _comando.Parameters.AddWithValue("@id", id);

            return MetodosCRUDtipoVehiculo.EjecutarComandoProcAlmacDelete_tv(_comando);
        }


    }
}
