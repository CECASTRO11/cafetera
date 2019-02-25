using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practia.Cafe.Model
{
    public class Cliente
    {
        private double _cantidadIngresada;

        public double CantidadIngresada
        {
            get
            {
                return _cantidadIngresada;
            }

            set
            {
                _cantidadIngresada = IngresarCantidad();
            }
        }

        public Eleccion Eleccion
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public double IngresarCantidad()
        {
            
            Console.Write("Ingrese 2$ por favor: ");
            return Convert.ToDouble(Console.ReadLine());
            
        }
        public Eleccion Elegir()
        {
            int e;
                Console.WriteLine("ingrese el valor de su eleccion");
                Console.WriteLine("1 = Cafe Espreso");
                Console.WriteLine("2 = Cafe Espreso Sin Azucar");
                Console.WriteLine("3 = Latte");
                Console.WriteLine("4 = Latte Sin Azucar");
                Console.WriteLine("5 = Cancelar");
                Console.Write("Eleccion: ");
                e = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
                switch (e)
                {
                    case 1:
                        return Eleccion.CafeEspresso;
                    case 2:
                        return Eleccion.CafeEspressosa;
                    case 3:
                        return Eleccion.latte;
                    case 4:
                        return Eleccion.lattesa;
                    case 5:
                        return Eleccion.Cancelar;
                    default:
                    Console.WriteLine("Ingrese un valor correcto por favor");
                    Console.WriteLine("");
                        Elegir();
                    return Eleccion.Cancelar;
                }
            }
    }
}