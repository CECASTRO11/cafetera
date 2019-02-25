using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practia.Cafe.dll
{
    class Cliente
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
        
        public Opcion Eleccion
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }
        public double IngresarCantidad()
        {
            Console.Write("Ingrese 2$ por favor");
            return Convert.ToDouble(Console.ReadLine());
        }

    }
}

