using Datos;
using Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NCompras
    {
        public static void Create(Compras c)
        {
            try
            {
                if (c.id == 0)
                    DCompras.Create(c);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static void Update(Compras c)
        {
            try
            {
                DCompras.Update(c);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static void Delete(int id)
        {
            try
            {
                DCompras.Delete(id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static List<Compras> Get()
        {
            try
            {
                return DCompras.getAll();
            }
            catch (Exception e)
            {
                throw e;
            }

        }
    }
}
