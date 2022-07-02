using Prueba.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.BLL
{
    public class SucursalesBLL
    {

        public List<sucursal> listaSucursal()
        {
            try
            {
                Sucursales listaSucursal = new Sucursales();
                return listaSucursal.ListaSucursal();
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
