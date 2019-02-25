using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practia.Cafe.Model
{
    public class Ingrediente
    {
        private string _name;
        public Ingrediente(string nombre) { _name = nombre; }

        private double _cantidad = 500; //gramos
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

        public void MedirCantidad(Ingrediente ingre)
        {
            Cafetera1 cf = new Cafetera1();
            if (((ingre._name == "cafe" || ingre._name == "azucar") && ingre._cantidad < 3) || (ingre._name == "agua" && ingre._cantidad < 50) || (ingre._name == "leche" && ingre._cantidad < 5))
            {
                Console.Write("Cantidad de " + ingre._name + " incompleta");
                //cf.PrepararCafe();
                
            }
            else if (ingre._name == "cafe" || ingre._name == "azucar")
            {
                ingre._cantidad = ingre._cantidad - 3;
                
            }
            else if (ingre._name == "agua")
            {
                ingre._cantidad = ingre._cantidad - 50;
                
            }
            else
            {
                ingre._cantidad = ingre._cantidad - 5;
            }
        }

    }

}