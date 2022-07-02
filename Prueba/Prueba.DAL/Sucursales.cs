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

        public sucursal registro(sucursal nuevaSucursal)
        {
            try
            {
                using (var context = new LibreriaEntities())
                {
                    //LinQ
                    sucursal sucursal = new sucursal();
                    sucursal.nombre = nuevaSucursal.nombre;
                    sucursal.ubicacion = nuevaSucursal.ubicacion;
                    sucursal.telefono = nuevaSucursal.telefono;
                    context.sucursal.Add(sucursal);
                    context.SaveChanges();
                    return sucursal;
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }

    }
}
