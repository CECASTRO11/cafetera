using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practia.Cafe.Model
{

    public class Cafetera1
    {

        Cliente user = new Cliente();
        private double _cambio;
        private int _cantVasos =10;
        public int CantVasos
        {
            get
            {
                return _cantVasos;
            }

            set
            {
                _cantVasos = value;
            }
        }

        public Ingrediente Ingrediente
        {
            get;
            set;
        }

        public Cliente Cliente
        {
            get;
            set;
        }

        public void PrepararCafe(double _cantidadIngresada)
        {

            if (_cantidadIngresada < 2 && _cantidadIngresada>0)
            {
                Console.WriteLine("");
                Console.WriteLine("Monto incompleto");
            }
            else if(_cantidadIngresada >= 2)
            {
                
                _cambio = _cantidadIngresada - 2;
                Console.WriteLine("Monto ingresado: " + _cantidadIngresada);
                Console.WriteLine("");
            }else
            {
                user.IngresarCantidad();
            }



            DevolverMonedas(_cantidadIngresada);


        }
        public void DevolverMonedas(double _cantidadIngresada)
        {

            Eleccion _eleccion;

            if (_cantidadIngresada < 2 && _cantidadIngresada > 0)
            {
                Console.WriteLine("Devolver: " + _cantidadIngresada);
                _cantidadIngresada = 0;

            }
            else
            {

                _eleccion = user.Elegir();
                if (_eleccion == Eleccion.Cancelar)
                {
                    Console.WriteLine("Devolver: " + _cantidadIngresada);
                }
                else
                {
                    Console.WriteLine("Cambio: " + _cambio);
                    _cambio = 0;
                    ServirCafe(_eleccion);
                }
            }

        }
        private void ServirCafe(Eleccion _eleccion)
        {
            string C;

            if (_eleccion == Eleccion.CafeEspresso) { C = "Cafe espreso"; }
            else if (_eleccion == Eleccion.CafeEspressosa) { C = "Cafe espreso sin azucar"; }
            else if (_eleccion == Eleccion.latte) { C = "Latte"; }
            else { C = "Latte sin azucar"; }

            Console.WriteLine("Preparando: " + C);
            _cantVasos--;
        }
        public void CargarVasos()
        {
            int n;
            do
            {
                Console.Write("Ingrese la cantidad de vasos: ");
                n = Convert.ToInt32(Console.ReadLine());
                _cantVasos += n;

            } while (n <= 0);
            //PrepararCafe();

            
        }

    }

}
