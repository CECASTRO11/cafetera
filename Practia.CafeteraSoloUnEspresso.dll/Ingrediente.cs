using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practia.Cafe.dll
{
    class Ingrediente
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        private double _cantidad =500; //gramos
        public double Cantidad
        {
            get
            {
                return _cantidad;
            }

            set
            {
                _cantidad = value;
            }
        }

        private bool MedirCantidad(Ingrediente ingre)
        {
            if (((ingre._name == "cafe" || ingre._name == "azucar") && ingre._cantidad < 3) || (ingre._name == "agua" && ingre._cantidad < 50) || (ingre._name == "leche" && ingre._cantidad < 5))
            {
                Console.Write("Cantidad de " + ingre._name + " incompleta");
                return false;
            }
            else if (ingre._name == "cafe" || ingre._name == "azucar")
            {
                ingre._cantidad = ingre._cantidad - 3;
                return true;
            }
            else if (ingre._name == "agua")
            {
                ingre._cantidad = ingre._cantidad - 50;
                return true;
            }
            else
            {
                ingre._cantidad = ingre._cantidad - 5;
                return true;
            }
        }
        }
}
