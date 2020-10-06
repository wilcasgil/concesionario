using Modelo.TipoConductor;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.TipoConductor
{
    public class LogicaNegocioTipoConductor
    {
        //Negociar INSERT
        public int NegociarInsertTipoConductor(int id, string nombre)
        {
            AccesoMetodosCRUDtipoConductor acceso = new AccesoMetodosCRUDtipoConductor();

            return acceso.InsertTipoConductor(id, nombre);
        }

        //Negociar SELECT
        public static DataTable NegociarListadoDatosTipoConductor()
        {
            return AccesoMetodosCRUDtipoConductor.ListadoTipoConductor();
        }

        //Negociar UPDATE
        public int NegociarUpdateTipoConductor(int id, string nombre)
        {
            AccesoMetodosCRUDtipoConductor acceso = new AccesoMetodosCRUDtipoConductor();

            return acceso.UpdateTipoConductor(id, nombre);
        }

        //Negociar DELETE
        public int NegociarDeleteTipoConductor(int id)
        {
            AccesoMetodosCRUDtipoConductor acceso = new AccesoMetodosCRUDtipoConductor();

            return acceso.DeleteTipoConductor(id);
        }
    }
}
