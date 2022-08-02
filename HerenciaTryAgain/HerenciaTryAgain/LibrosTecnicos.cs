using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaTryAgain
{
    internal class LibrosTecnicos : Libreria
    {
        protected string direccion, numero;
        protected static int contR3 = 0, contV3 = 0;
        public LibrosTecnicos(double preciobase) : base(preciobase)
        {
            RentaoCompra();
        }
        public void RentaoCompra()
        {
            if (this.bandera == true)
            {
                contR3++;
                Console.WriteLine("Deberas introducir su direccion del hogar por rentar este Libro");
                direccion = Console.ReadLine();
                Console.WriteLine("Ahora introdusca su numero telefonico");
                numero = Console.ReadLine();
                precio = (60 * precio) / 100;
                Console.WriteLine("Precio del libro por venderlo es: $" + precio);
            }
            else
            {
                contV3++;
                Console.WriteLine("Precio del libro por comprarlo es: $" + precio);
            }
        }
        public double Precio
        {
            get
            {
                return this.precio;
            }
            set
            {
                this.precio = value;
            }
        }
        public int ContR3
        {
            get
            {
                return contR3;
            }
            set
            {
                contR3 = value;
            }
        }
        public int ContV3
        {
            get
            {
                return contV3;
            }
            set
            {
                contV3 = value;
            }
        }
    }
}
