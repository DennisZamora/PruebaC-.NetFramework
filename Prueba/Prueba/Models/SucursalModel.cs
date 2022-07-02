using Prueba.BLL;
using Prueba.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prueba.Models
{
    public class SucursalModel
    {
        public List<sucursal> listaSucursal()
        {
            try
            {
                SucursalesBLL listaSucursales = new SucursalesBLL();
                return listaSucursales.listaSucursal();
            }
            catch (Exception)
            {

                throw;
            }
           
        }
    }
}