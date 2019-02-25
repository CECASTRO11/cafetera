
using Practia.Cafe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Practia.Cafe.App
{
    class Program
    {
        static void Main(string[] args)
        {
            double _cantidadIngresada;
            int d = 0;
            //Creo Cafetera1
            Cafetera1 cafetera = new Cafetera1();



            //Creo Usuario
            Cliente user = new Cliente();

            //Creo Ingredientes
            Ingrediente cafe = new Ingrediente("cafe");

            Ingrediente azucar = new Ingrediente("azucar");

            Ingrediente agua = new Ingrediente("agua");

            Ingrediente leche = new Ingrediente("leche");

            //Medir cantidad de los ingredientes
            /*if (opcion == Eleccion.CafeEspresso)
            {
                agua.MedirCantidad(agua);
                cafe.MedirCantidad(cafe);
                azucar.MedirCantidad(azucar);
            }
            else if (opcion == Eleccion.CafeEspressosa)
            {
                agua.MedirCantidad(agua);
                cafe.MedirCantidad(cafe);
            }
            else if (opcion == Eleccion.latte)
            {
                agua.MedirCantidad(agua);
                leche.MedirCantidad(leche);
                cafe.MedirCantidad(cafe);
                azucar.MedirCantidad(azucar);
            }
            else if (opcion == Eleccion.lattesa)
            {
                agua.MedirCantidad(agua);
                leche.MedirCantidad(leche);
                cafe.MedirCantidad(cafe);
            }
            else
            {
                cafetera.PrepararCafe(Eleccion.Cancelar);
            }*/
            do
            {

                if (cafetera.CantVasos == 0)
                {
                    do
                    {
                        Console.WriteLine("");
                        Console.WriteLine("No quedan mas vasos");
                        Console.WriteLine("");
                        Console.Write("Desea agregar mas vasos  1.Si  2.No: ");
                        d = Convert.ToInt32(Console.ReadLine());

                        if (d == 1)
                        {
                            cafetera.CargarVasos();
                        }
                    } while (cafetera.CantVasos == 0);
                }
                if (cafetera.CantVasos < 6)
                {
                         Console.WriteLine("");
                         Console.WriteLine("¡Quedan pocos vasos!");
                         Console.WriteLine("");
                         Console.Write("Desea agregar mas vasos  1.Si  2.No: ");
                         d = Convert.ToInt32(Console.ReadLine());

                         if (d == 1)
                         {
                             cafetera.CargarVasos();
                         }
                 }

                _cantidadIngresada = user.IngresarCantidad();
                if(_cantidadIngresada > 0)
                {
                    cafetera.PrepararCafe(_cantidadIngresada);
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
            } while (cafetera.CantVasos >= 0);
        }
    }
}