using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practia.Cafe.dll
{
    class Cafetera
    {
        
        
        private int _cantVasos;
        private double cambio = 0;
        public int CantVasos
        {
            get
            {
                return _cantVasos;
            }

            set
            {
                _cantVasos = 100;
            }
        }

        public void PrepararCafe(double _cantidadIngresada,Opcion _eleccion)
        {
            if (_cantidadIngresada < 2)
            {
                Console.Write("Monto incompleto");
                DevolverMonedas(_cantidadIngresada, _eleccion);
            }
            else
            {
                cambio = _cantidadIngresada - 2;
                Console.WriteLine("Monto ingresado: "+_cantidadIngresada);
                Console.WriteLine("Cambio: " + cambio);
                DevolverMonedas(_cantidadIngresada, _eleccion);
            }

            
        }
        public void DevolverMonedas(double _cantidadIngresada, Opcion _eleccion)
        {
           if(_eleccion == Opcion.Cancelar || _cantidadIngresada <2)
            {
                Console.WriteLine("Devolver: " + _cantidadIngresada);
            }
           else
            {
                Console.WriteLine("Devolver: " + cambio);
                cambio = 0;
            }
        }
        
        }
}
