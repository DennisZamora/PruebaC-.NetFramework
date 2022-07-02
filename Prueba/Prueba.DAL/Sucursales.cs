using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.DAL
{
   public  class Sucursales
    {
        public List<sucursal> ListaSucursal()
        {
            try
            {
                using (var context = new LibreriaEntities())
                {
                    var lista = (from x in context.sucursal
                                 select x).ToList();

                    if (lista.Count > 0)
                    {
                        return lista;
                    }else
                    {
                        List<sucursal> listaVacia = new List<sucursal>();
                        return listaVacia;
                    }  
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<sucursal> ListaSucursal2()
        {
            try
            {
                using (var context = new LibreriaEntities())
                {
                    var lista = (from x in context.sucursal
                                 select x).ToList();

                    if (lista.Count > 0)
                    {
                        return lista;
                    }
                    else
                    {
                        List<sucursal> listaVacia = new List<sucursal>();
                        return listaVacia;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
