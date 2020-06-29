using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayer.Datos;
using NLayer.Entidades;
using NLayer.Negocio;


namespace NLayer.Consola
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                PrestamoServicio servicio = new PrestamoServicio();

                int id = servicio.SacarPrestamo("Prestamo Subsidiado", 25.5, 3, 8);

                Console.WriteLine("Prestamo id: " + id.ToString());
                /*
                TipoPrestamoServicio servicio = new TipoPrestamoServicio();

                List<TipoPrestamo> lst = servicio.TraerTipoPrestamos();

                foreach (TipoPrestamo p in lst)
                {
                    Console.WriteLine(p.Linea + " TNA: " + p.TNA);
                }
                */
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }

            Console.ReadKey();

        }
    }
}
